using UnityEngine;
using System;
using System.IO;

namespace CheatMod
{
    public class Main : IMod , IModSettings 
    {
        public GameObject _go;
        public static  StreamWriter sw;
        public string Identifier { get; set; }
        public static Configuration configuration{ get; private set; }

        public void onEnabled()
        {
            if (configuration == null) {
                configuration = new Configuration (Path);
                configuration.Load ();
                configuration.Save ();
            }

            if (configuration.settings.debugBuildMode) {
               // Global.IS_RELEASE_BUILD = false;
				//Global.is
                ScriptableSingleton<DebugPreferences>.Instance.drawDebugUI = true;
                //new GameObject ("Mod tools").AddComponent<DebugToolsMenu> ();
            } else {
                //Global.IS_RELEASE_BUILD = true;
            }

            sw = File.AppendText (this.Path + @"/mod.log");
                
            _go = new GameObject();
            var modController = _go.AddComponent<CheatModController>();
            modController.Load ();

        }

        public void onDisabled()
        {
            UnityEngine.Object.Destroy(_go);
            sw.Close();
        }


        public static void Log(Exception e)
        {
 
            sw.WriteLine(e);
            sw.Flush();

        }

        public static void Log(string value)
        {

            sw.WriteLine(value);
            sw.Flush();

        }

        public static void Log(int value)
        {

            sw.WriteLine(value);
            sw.Flush();

        }

        public string Name
        {
            get
            {
                return "Cheat Mod";
            }
        }

        public string Description
        {
            get
            {
                return "Cheats for Parkitect.";
            }
        }
            
        public string Path { get; set; }


        #region Implementation of IModSettings

        private bool FetchKey(out KeyCode outKey)
        {
            foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode))) {
                if (Input.GetKeyDown (key)) {
                    outKey = key;
                    return true;
                }
            }
            outKey = KeyCode.A;
            return false;
        }


        public void onDrawSettingsUI() {
            Main.configuration.DrawGUI ();
        }

        public void onSettingsOpened() {
            if (Main.configuration == null)
                Main.configuration = new Configuration (this.Path);
            Main.configuration.Load ();

        }
        public void onSettingsClosed() {
            Main.configuration.Save ();
        }

        #endregion
    }
}
