using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//íçà”

public class CSVWriter : MonoBehaviour
{
    public string fileName;

    void Start()
    {
       WriteCSV("Hello,World");
    }
    public void WriteCSV(string txt)
    {
        StreamWriter streamWriter;
        FileInfo fileInfo;
        fileInfo = new FileInfo(Application.dataPath+"/"+ fileName + ".csv");
        streamWriter = fileInfo.AppendText();
        streamWriter.WriteLine(txt);
        streamWriter.Flush();
        streamWriter.Close();
    }
}
