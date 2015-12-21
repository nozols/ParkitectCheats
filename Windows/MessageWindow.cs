using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace CheatMod.Windows
{
    class MessageWindow : CMWindow
    {
        public string message = "Wait what...";

        public MessageWindow(int windowId) : base(windowId)
        {
            windowName = "Cheat Mod Message";
            drawCloseButton = false;
            WindowRect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 10);
        }

        public override void DrawContent()
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label(message);
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Close"))
            {
                CloseWindow();
            }
            GUILayout.EndHorizontal();
        }
    }
}
