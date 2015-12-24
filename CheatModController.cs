using System.Collections.Generic;
using UnityEngine;
using CheatMod.Windows;
using CheatMod.Reference;

namespace CheatMod
{
    class CheatModController : MonoBehaviour
    {
        public static List<CMWindow> windows = new List<CMWindow>();

        void Start()
        {
            Debug.Log("Started CheatModController");
            windows.Add(new MainWindow(WindowIds.MainWindow));
            windows.Add(new AdvancedWindow(WindowIds.AdvancedWindow));
            windows.Add(new ConfirmWindow(WindowIds.ConfirmWindow));
            windows.Add(new MessageWindow(WindowIds.MessageWindow));
        }

        void Update() {
            if (Input.GetKeyDown(KeyCode.T) || (Input.GetKeyDown(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.T))) {
                Debug.Log("Toggled Cheatmod window");
                getWindow(WindowIds.MainWindow).ToggleWindowState();
            }
        }

        void OnGUI()
        {
            windows.ForEach(delegate(CMWindow window){
                if (window.isOpen) {
                    window.DrawWindow();
                }
            });
        }

        public static CMWindow getWindow(int id) {
            return windows.Find(x => x.id == id);
        }
    }
}
