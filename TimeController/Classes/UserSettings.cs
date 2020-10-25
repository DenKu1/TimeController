using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TimeController
{
    public class UserSettings
    {
        public int workDuration;
        public int breakDuration;

        public bool showMessage;
        public bool playSound;
        public bool disableMouse;
        public bool disableKeyboard;

        public bool trackActive;
        public bool trackBlackList;

        public TrackApps trackApps = new TrackApps();
        public BlackListApps blackListApps = new BlackListApps();

        public DesignTypes currentDesign;

        private void SaveMyINI(string path)
        {
            INIManager manager = new INIManager(path);

            manager.WritePrivateString("durations", "workDuration", workDuration.ToString());
            manager.WritePrivateString("durations", "breakDuration", breakDuration.ToString());

            manager.WritePrivateString("break_settings", "showMessage", showMessage.ToString());
            manager.WritePrivateString("break_settings", "playSound", playSound.ToString());
            manager.WritePrivateString("break_settings", "disableMouse", disableMouse.ToString());
            manager.WritePrivateString("break_settings", "disableKeyboard", disableKeyboard.ToString());

            manager.WritePrivateString("operation_mode", "trackActive", trackActive.ToString());
            manager.WritePrivateString("operation_mode", "trackBlackList", trackBlackList.ToString());

            manager.WritePrivateString("design", "type", currentDesign.ToString());
        }

        public void SaveSettings(string path)
        {
            SaveMyINI(path + @"\Settings.ini");

            trackApps.Save(path + @"\trackApps.bin");
            blackListApps.Save(path + @"\blackListApps.bin");

        }

        private void LoadMyINI(string path)
        {        
            INIManager manager = new INIManager(path);

            workDuration = int.Parse(manager.GetPrivateString("durations", "workDuration"));
            breakDuration = int.Parse(manager.GetPrivateString("durations", "breakDuration"));

            showMessage = bool.Parse(manager.GetPrivateString("break_settings", "showMessage"));
            playSound = bool.Parse(manager.GetPrivateString("break_settings", "playSound"));
            disableMouse = bool.Parse(manager.GetPrivateString("break_settings", "disableMouse"));
            disableKeyboard = bool.Parse(manager.GetPrivateString("break_settings", "disableKeyboard"));

            trackActive = bool.Parse(manager.GetPrivateString("operation_mode", "trackActive"));
            trackBlackList = bool.Parse(manager.GetPrivateString("operation_mode", "trackBlackList"));

            currentDesign = Utils.ParseEnum(manager.GetPrivateString("design", "type"));
        }

        public void LoadSettings(string path)
        {
            if (File.Exists(path + @"\trackApps.bin"))
            {
                LoadMyINI(path + @"\Settings.ini");
            }

            if (File.Exists(path + @"\trackApps.bin"))
            {
                trackApps.Load(path + @"\trackApps.bin");
            }

            if (File.Exists(path + @"\blackListApps.bin"))
            {
                blackListApps.Load(path + @"\blackListApps.bin");
            }

           
        }

      

    }
}