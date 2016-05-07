using System;
using System.Collections.Generic;
using System.IO;
using Space3D;
using System.Runtime.Serialization.Formatters.Binary;


public static class Storage
{


    public static void StoreFiles(String destination, Path3D files)
    {

        using (FileStream storeFiles = new FileStream(destination, FileMode.Create))
        {

            BinaryFormatter data = new BinaryFormatter();
            data.Serialize(storeFiles, files);
        }
    }
    public static Path3D RestoreFiles(String file)
    {
        using (FileStream getFiles = new FileStream(file, FileMode.Open))
        {
            BinaryFormatter data = new BinaryFormatter();
        return (Path3D)data.Deserialize(getFiles);

        }
    }
}
   
    

    

