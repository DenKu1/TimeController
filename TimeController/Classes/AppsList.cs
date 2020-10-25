using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;



namespace TimeController
{
    [Serializable]
    public abstract class AppsList
    {
        public ProcInfo[] appsArray;

        public void Save(string file)
        {
            using (Stream stream = File.Open(file, FileMode.Create))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, this);
            }
        }

        public void Load(string file)
        {
            AppsList appsList;
            using (Stream stream = File.Open(file, FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();

                try
                {
                    appsList = (AppsList)bin.Deserialize(stream);
                    this.appsArray = appsList.appsArray;
                }
                catch
                {
                    MessageBox.Show("Неможливо здійснити зчитування з диску!");
                }


            }

            
        }

    }

    [Serializable]
    public class TrackApps : AppsList { }

    [Serializable]
    public class BlackListApps : AppsList { }

}

