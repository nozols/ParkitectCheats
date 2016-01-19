using UnityEngine;
using System;
using System.IO;

namespace CheatMod
{
    public class Main : IMod
    {
        public GameObject _go;
        public static  StreamWriter sw;
        public string Identifier { get; set; }


        public void onEnabled()
        {
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
    }
}
