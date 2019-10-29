using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncryptorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public string Encriptar(string _cadenaAencriptar)
    {
        string result = string.Empty;
        byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
        result = Convert.ToBase64String(encryted);
        return result;
    }

    /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
    public string DesEncriptar(string _cadenaAdesencriptar)
    {
        string result = string.Empty;
        byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
        //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
        result = System.Text.Encoding.Unicode.GetString(decryted);
        return result;
    }
}
