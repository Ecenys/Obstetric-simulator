using UnityEngine;
using System.Collections;
using System.Xml;

public class TouchableObject : MonoBehaviour {
    public string ParteDelCuerpo;

	public double stiffness;
	public double staticFriction;
	public double dynamicFriction;
	public double damping;
	public double viscosity;
    public int objectId;

	// Use this for initialization
	void Start () {
        string options = GameObject.FindWithTag("God").GetComponent<ReaderWriter>().ReadString("Options.conf");
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(options);

        AsignarValores(doc);
        damping = 0;

        var devicePosition = GameObject.Find("Haptic Origin");

        Mesh mesh = this.GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;
        int[,] triangles = new int[(mesh.triangles.Length / 3),3];

        for (int i = 0; i < mesh.triangles.Length / 3; i++)
        {
            triangles[i, 0] = mesh.triangles[3 * i];
            triangles[i, 1] = mesh.triangles[3 * i + 1];
            triangles[i, 2] = mesh.triangles[3 * i + 2];
        }

        //objectId = HapticNativePlugin.AddObject(this.transform.position - devicePosition.transform.position, this.transform.localScale, this.transform.localRotation.eulerAngles, vertices, normals, mesh.vertices.Length, triangles, mesh.triangles.Length / 3);
        //objectId = HapticNativePlugin.AddObject(this.transform.localPosition - devicePosition.transform.localPosition, this.transform.localScale, this.transform.localRotation.eulerAngles, vertices, normals, mesh.vertices.Length, triangles, mesh.triangles.Length / 3);

        //objectId = HapticNativePlugin.AddModificableObject(this.transform.localPosition - devicePosition.transform.localPosition, this.transform.localScale, this.transform.localRotation.eulerAngles, vertices, normals, mesh.vertices.Length, triangles, mesh.triangles.Length / 3, stiffness, staticFriction, dynamicFriction, damping, viscosity);
        objectId = HapticNativePlugin.AddSimpleObject(this.transform.localPosition - devicePosition.transform.localPosition, this.transform.localScale, this.transform.localRotation.eulerAngles, vertices, normals, mesh.vertices.Length, triangles, mesh.triangles.Length / 3, stiffness / 10, staticFriction / 10, dynamicFriction / 10);
    }

    private void AsignarValores(XmlDocument doc) {
        if (ParteDelCuerpo == "Utero")
        {
            XmlNodeList Dureza = doc.GetElementsByTagName("DurezaMadre");
            this.stiffness = double.Parse(Dureza[0].InnerText);

            XmlNodeList Fricion = doc.GetElementsByTagName("FricionMadre");
            this.staticFriction = double.Parse(Fricion[0].InnerText);
            this.dynamicFriction = double.Parse(Fricion[0].InnerText);

            XmlNodeList Viscosidad = doc.GetElementsByTagName("ViscosidadMadre");
            this.viscosity = double.Parse(Viscosidad[0].InnerText);
        }
        if (ParteDelCuerpo == "Cabeza")
        {
            XmlNodeList Dureza = doc.GetElementsByTagName("DurezaHijo");
            this.stiffness = double.Parse(Dureza[0].InnerText);

            XmlNodeList Fricion = doc.GetElementsByTagName("FricionHijo");
            this.staticFriction = double.Parse(Fricion[0].InnerText);
            this.dynamicFriction = double.Parse(Fricion[0].InnerText);

            XmlNodeList Viscosidad = doc.GetElementsByTagName("ViscosidadHijo");
            this.viscosity = double.Parse(Viscosidad[0].InnerText);
        }
        if (ParteDelCuerpo == "Fontanela")
        {
            XmlNodeList Dureza = doc.GetElementsByTagName("DurezaHijoFontanela");
            this.stiffness = double.Parse(Dureza[0].InnerText);

            XmlNodeList Fricion = doc.GetElementsByTagName("FricionHijoFontanela");
            this.staticFriction = double.Parse(Fricion[0].InnerText);
            this.dynamicFriction = double.Parse(Fricion[0].InnerText);

            XmlNodeList Viscosidad = doc.GetElementsByTagName("ViscosidadHijoFontanela");
            this.viscosity = double.Parse(Viscosidad[0].InnerText);
        }
        if (ParteDelCuerpo == "Vagina")
        {

        }

        if (ParteDelCuerpo == "Nada")
        {
            this.stiffness = 8;
            this.staticFriction = 0;
            this.dynamicFriction = 0;
            this.viscosity = 0;
        }
    }
}
