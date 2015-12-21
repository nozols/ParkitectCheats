using UnityEngine;

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
                if (GUI.Button(new Rect(WindowRect.width - 18, 2, 15, 15), "X"))
                {
                    CloseWindow();
                }
            }
            DrawContent();
            GUI.DragWindow(TitleBarRect);
        }

        public virtual void DrawContent()
        {

        }
    }
}
