using UnityEngine;

namespace CheatMod
{
    public class Main : IMod
    {
        public GameObject _go;

        public string Description
        {
            get
            {
                return "Cheats for Parkitect.";
            }
        }

        public string Name
        {
            get
            {
                return "Cheat Mod";
            }
        }

        public void onDisabled()
        {
            UnityEngine.Object.Destroy(_go);
        }

        public void onEnabled()
        {
            _go = new GameObject();
            _go.AddComponent<CheatModController>();
        }
    }
}
