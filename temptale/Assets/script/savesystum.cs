using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class savesystum
{
    public static void Save(inventory Inventory)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string Path = Application.persistentDataPath +"/player.NEHEHE";
        FileStream stream = new FileStream(Path,FileMode.Create);
        data Data = new data(Inventory);

        formatter.Serialize(stream,Data);
        stream.Close();
    }
    public static data Load()
    {
        string Path = Application.persistentDataPath +"/player.NEHEHE";
        if(File.Exists(Path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(Path,FileMode.Open);
            data Data = formatter.Deserialize(stream) as data;
            stream.Close();
            return Data;
        }else
        {
           Debug.Log("Application.persistentDataPath/player.NEHEHE no found");
           return null; 
        }
    }
}
