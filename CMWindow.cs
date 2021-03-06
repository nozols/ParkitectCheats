﻿using UnityEngine;

namespace CheatMod
{
    class CMWindow
    {
        
        public int id;
        public string windowName = "CMWindow";
        public bool isOpen = false;
        protected bool usesSkin = true;
        protected bool drawCloseButton = true;
        public Rect WindowRect = new Rect(20, 20, 200, 200);
        public Rect TitleBarRect = new Rect(0, 0, 200000000, 20);

        public CMWindow(int windowId)
        {
            id = windowId;       
        }

        public void ToggleWindowState()
        {
            isOpen = !isOpen;
        }

        public void OpenWindow()
        {
            isOpen = true;
        }

        public void CloseWindow()
        {
            isOpen = false;
        }

        public void DrawWindow()
        {
            WindowRect = GUILayout.Window(id, WindowRect, DrawMain, windowName);
        }

        public void DrawMain(int windowId)
        {
            if (drawCloseButton)
            {
                if (GUI.Button(new Rect(WindowRect.width - 21, 6, 15, 15), "x"))
                {
                    CloseWindow();
                }
            }
            GUI.BeginGroup(new Rect(0, /*27*/0, WindowRect.width, WindowRect.height/* - 33*/));
            DrawContent();
            
            GUI.EndGroup();
            GUI.DragWindow(TitleBarRect);
        }

        public virtual void DrawContent()
        {

        }
    }
}
