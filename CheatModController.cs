using System.Collections.Generic;
using UnityEngine;
using CheatMod.Windows;
using CheatMod.Reference;
using System.Collections;

namespace CheatMod
{
    class CheatModController : MonoBehaviour
    {
        public static List<CMWindow> windows = new List<CMWindow>();
        private static LightMoodController _lightMoodController;
        private static float LightIntensityValue = 1.2F;

        void Start()
        {
            Debug.Log("Started CheatModController");
            //SkinCreator.ApplyStylesToSkin();
            _lightMoodController = FindObjectOfType<LightMoodController>();

            windows.Add(new MainWindow(WindowIds.MainWindow));
            windows.Add(new AdvancedWindow(WindowIds.AdvancedWindow));
            windows.Add(new ConfirmWindow(WindowIds.ConfirmWindow));
            windows.Add(new MessageWindow(WindowIds.MessageWindow));
            windows.Add(new WeatherWindow(WindowIds.WeatherWindow));

            //StartCoroutine(UpdateTime());
        }

        void OnDestroy()
        {
            //StopCoroutine(UpdateTime());
        }

        void Update() {
            _lightMoodController.keyLight.intensity = LightIntensityValue;
            if (Input.GetKeyDown(KeyCode.T) || (Input.GetKeyDown(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.T))) {
                Debug.Log("Toggled Cheatmod window");
                CMWindow window = getWindow(WindowIds.MainWindow);
                Debug.Log(window);
                window.ToggleWindowState();
                //gettWindow(WindowIds.MainWindow).ToggleWindowState();
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                windows.ForEach(delegate(CMWindow window){
                    window.CloseWindow();
                });
            }
        }

        void OnGUI()
        {
            //GUI.skin = SkinCreator.skin;
            windows.ForEach(delegate(CMWindow window){
                if (window.isOpen) {
                    window.DrawWindow();
                }
            });
        }

        public static CMWindow getWindow(int id) {
            return windows.Find(x => x.id == id);
        }

        public static void setLightIntensity(float intensity)
        {
            LightIntensityValue = intensity;
        }

        private IEnumerator UpdateTime()
        {
            for (;;) { 
                _lightMoodController.keyLight.intensity = LightIntensityValue;

                yield return new UnityEngine.WaitForSeconds(0.5F);
            }
        }
    }
}
