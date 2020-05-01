using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;


public static class SaveSystem
{
    public static void SavePlayerStatus(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.yes";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerStatus status = new PlayerStatus(player);

        formatter.Serialize(stream, status);
        stream.Close();

    }

    public static PlayerStatus LoadPlayerStatus()
    {
        string path = Application.persistentDataPath + "/player.yes";

        if (File.Exists(path))
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            PlayerStatus status = formatter.Deserialize(stream) as PlayerStatus;
            stream.Close();
            return status;
        }
        else
        {
            Debug.LogError("file not found");
            return null;
        }
    }
}
