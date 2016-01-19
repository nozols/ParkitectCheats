using System;
using UnityEngine;

namespace CheatMod.Windows
{

   
    public class ConfirmWindow : CMWindow
    {
        public delegate void OnSignal(bool yn);
        public event OnSignal Signal; 

       // private Func<bool, bool> fn;
        public string message = "Please confirm";

        public ConfirmWindow(CheatModController cheatController) : base(cheatController) {
            windowName = "Are you sure?";
            drawCloseButton = false;
            WindowRect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100);
        }

        public override void DrawContent()
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label(message);
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Yes")) {
                Signal(true);
                _clearInvocation ();
                CloseWindow();
            }
            if (GUILayout.Button("No"))
            {
                Signal(false);
                _clearInvocation ();
                CloseWindow();
            }
          
            GUILayout.EndHorizontal();
        }

        private void _clearInvocation()
        {
            foreach (var invocation in Signal.GetInvocationList()) {
                Signal -= invocation as OnSignal;
            }
        }

       
    }
}
