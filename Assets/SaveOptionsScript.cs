using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveOptionsScript : MonoBehaviour
{
    public void Save()
    {
        /**
         * añadir lectura de los campos de opciones añadirlos al xml
         */
        File.WriteAllText(@"Options.conf", Xml());
    }

    private string Xml() {
        return @"<Opciones>
	                <DurezaMadre>3</DurezaMadre>
	                <ViscosidadMadre>0</ViscosidadMadre>
	                <FricionMadre>0,1</FricionMadre>
	                <DurezaHijo>3</DurezaHijo>
	                <ViscosidadHijo>0,1</ViscosidadHijo>
	                <FricionHijo>0,1</FricionHijo>
	                <DurezaHijoFontanela>0,65</DurezaHijoFontanela>
	                <ViscosidadHijoFontanela>0,1</ViscosidadHijoFontanela>
	                <FricionHijoFontanela>0,1</FricionHijoFontanela>
                </Opciones>";
    }
}
