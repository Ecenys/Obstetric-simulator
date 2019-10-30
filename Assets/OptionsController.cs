using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    public Text madreDureza, madreViscosidad, madreFricion;
    public Text bebeDureza, bebeViscosidad, bebeFricion;

    private XmlDocument doc;
    private ReaderWriter monitor;
    private string text;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            monitor = GetComponent<ReaderWriter>();
            text = monitor.ReadString("Options.conf");
            doc = new XmlDocument();
            doc.LoadXml(text);
            AsignarValores(doc);
        }
        catch (Exception)
        {
            Debug.LogError("Archivo Options.conf corruto, asignando codigo predeterminado");
            ValoresPredeterminados();
        }
        
    }

    private void AsignarValores(XmlDocument doc)
    {
        try
        {
            XmlNodeList DurezaMadre = doc.GetElementsByTagName("DurezaMadre");
            madreDureza.text = DurezaMadre[0].InnerText;
            XmlNodeList ViscosidadMadre = doc.GetElementsByTagName("ViscosidadMadre");
            madreViscosidad.text = ViscosidadMadre[0].InnerText;
            XmlNodeList FricionMadre = doc.GetElementsByTagName("FricionMadre");
            madreFricion.text = FricionMadre[0].InnerText;
            XmlNodeList DurezaBebe = doc.GetElementsByTagName("DurezaHijo");
            bebeDureza.text = DurezaBebe[0].InnerText;
            XmlNodeList ViscosidadBebe = doc.GetElementsByTagName("ViscosidadHijo");
            bebeViscosidad.text = ViscosidadBebe[0].InnerText;
            XmlNodeList FricionBebe = doc.GetElementsByTagName("FricionHijo");
            bebeFricion.text = FricionBebe[0].InnerText;
        }
        catch (Exception ex) {
            throw;
        }
    }

    public void ValoresPredeterminados() {
        doc = new XmlDocument();
        doc.LoadXml(OpcionesPredeterminadas());
        AsignarValores(this.doc);
    }

    private string OpcionesPredeterminadas()
    {
        return @"<Opciones>
                    <DurezaMadre>6</DurezaMadre>

                    <ViscosidadMadre>5</ViscosidadMadre>

                    <FricionMadre>4</FricionMadre>

                    <DurezaHijo>3</DurezaHijo>

                    <ViscosidadHijo>2</ViscosidadHijo>

                    <FricionHijo>1</FricionHijo>
                </Opciones> ";
    }
}
