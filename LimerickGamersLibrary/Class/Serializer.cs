using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LimerickGamersLibrary.Class
{
    class ModelSerializer
    {
        public ModelSerializer()
        {
        }

        public void SerializeStatic(string filename, SerializableModel sModel)
        {
            try
            {
                using (Stream strm = File.Open(filename, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(strm, sModel);
                }
            }
            catch (Exception)
            {
                throw new Exception("File not found.");
            }

        }

        public SerializableModel DeserializeStatic(string filename)
        {
            SerializableModel sModel;

            try
            {
                using (Stream strm = File.Open(filename, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    sModel = (SerializableModel)bf.Deserialize(strm);
                }
            }
            catch (Exception)
            {
                
                throw new Exception();
            }

            return sModel;
        }
    }


}
