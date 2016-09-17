
using System;
using UnityEngine;
namespace CheatMod
{
    public class ModSettings : SerializedRawObject 
    {
        [Serialized]
        public KeyCode openWindow{ get; set;}

        [Serialized]
        public bool debugBuildMode{ get; set;}

        public ModSettings ()
        {
            openWindow = KeyCode.F6;
            debugBuildMode = false;
        }

    }
}