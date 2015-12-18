using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using CheatMod.windows;

namespace CheatMod
{
    class CheatModController : MonoBehaviour
    {
        private List<CMWindow> windows = new List<CMWindow>();

        void Start()
        {
            Debug.Log("Started CheatModController");
            windows.Add(new MainWindow(1));
        }

        void Update() {
            if (Input.GetKeyDown(KeyCode.C)) {
                CMWindow window = windows.Find(x=> x.id == 1);
                window.isOpen = !window.isOpen;
                Debug.Log("Toggled window: " + window.isOpen);
            }
        }

        void OnGui()
        {
            windows.ForEach(delegate(CMWindow window){
                Debug.Log(window);
                Debug.Log(window.isOpen);
                if (window.isOpen) {
                    window.DrawWindow();
                    Debug.Log("Drawing window" + window.id);
                }
            });
        }
    }
}
