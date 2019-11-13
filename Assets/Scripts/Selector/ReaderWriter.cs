using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class ReaderWriter : MonoBehaviour
{
        //[MenuItem("Tools/Write file")]
        public void WriteString(string path, string text)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine(text);
                tw.Close();
            }
            else if (File.Exists(path))
            {
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine(text);
                tw.Close();
            }

        /*
            string path = "Assets/Resources/test.txt";

            //Write some text to the test.txt file
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine("Test");
            writer.Close();

            //Re-import the file to update the reference in the editor
            AssetDatabase.ImportAsset(path);
            //TextAsset asset = Resources.Load("test");

            //Print the text from the file
            //Debug.Log(asset.text);
            */
        }

        //[MenuItem("Tools/Read file")]
        public string ReadString(string path)
        {
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        string text = reader.ReadToEnd();
        reader.Close();
        //return File.ReadAllText(path);
        return text;
        }
}
