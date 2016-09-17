using System;
using UnityEngine;

namespace CheatMod
{
    public class GlobalToggles : CMWindow
    {

        public GlobalToggles(CheatModController cheatController) : base(cheatController) {

            windowName = "Debug Toggles";
            drawCloseButton = true;
            WindowRect = new Rect(620, 20, 400, 200);
        }

        public override void DrawContent ()
        {
            if (!Global.IS_RELEASE_BUILD) {
                GUILayout.BeginHorizontal ();
                ScriptableSingleton<DebugPreferences>.Instance.drawDebugUI = GUILayout.Toggle (ScriptableSingleton<DebugPreferences>.Instance.drawDebugUI , "Toggle ingame debug menu");
                GUILayout.EndHorizontal ();
            }

            GUILayout.BeginHorizontal();
            Global.CAN_BUILD_OUTSIDE_PARKBOUNDS = GUILayout.Toggle(Global.CAN_BUILD_OUTSIDE_PARKBOUNDS,"CAN_BUILD_OUTSIDE_PARKBOUNDS");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.NO_TRACKBUILDER_RESTRICTIONS = GUILayout.Toggle(Global.NO_TRACKBUILDER_RESTRICTIONS,"NO_TRACKBUILDER_RESTRICTIONS");
            GUILayout.EndHorizontal();

            /*  GUILayout.BeginHorizontal();
            Global.CULL_ONSCREEN = GUILayout.Toggle(Global.CULL_ONSCREEN,"CULL_ONSCREEN");
            GUILayout.EndHorizontal();*/

            GUILayout.BeginHorizontal();
            Global.DRAW_COORDS_AT_MOUSE = GUILayout.Toggle(Global.DRAW_COORDS_AT_MOUSE,"DRAW_COORDS_AT_MOUSE");
            GUILayout.EndHorizontal();
            /*
            GUILayout.BeginHorizontal();
            Global.DRAW_STATION_INFO = GUILayout.Toggle(Global.DRAW_STATION_INFO,"DRAW_STATION_INFO");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_TRACK_CONTROLPOINTS = GUILayout.Toggle(Global.DRAW_TRACK_CONTROLPOINTS,"DRAW_TRACK_CONTROLPOINTS");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_TRACK_SPAWNLOCATIONS = GUILayout.Toggle(Global.DRAW_TRACK_SPAWNLOCATIONS,"DRAW_TRACK_SPAWNLOCATIONS");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_TRACK_TUNNEL_BOUNDS = GUILayout.Toggle(Global.DRAW_TRACK_TUNNEL_BOUNDS,"DRAW_TRACK_TUNNEL_BOUNDS");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_TRAIN_INFO = GUILayout.Toggle(Global.DRAW_TRAIN_INFO,"DRAW_TRAIN_INFO");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_FLATRIDE_INFO = GUILayout.Toggle(Global.DRAW_FLATRIDE_INFO,"DRAW_FLATRIDE_INFO");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_PERSON_INFO = GUILayout.Toggle(Global.DRAW_PERSON_INFO,"DRAW_PERSON_INFO");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_PERSON_LOOKAT = GUILayout.Toggle(Global.DRAW_PERSON_LOOKAT,"DRAW_PERSON_LOOKAT");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_PERSON_WALKTO = GUILayout.Toggle(Global.DRAW_PERSON_WALKTO,"DRAW_PERSON_WALKTO");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_PERSON_PATHS = GUILayout.Toggle(Global.DRAW_PERSON_PATHS,"DRAW_PERSON_PATHS");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_PERSON_BINS = GUILayout.Toggle(Global.DRAW_PERSON_BINS,"DRAW_PERSON_BINS");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_SCENERY_VISIBILITY = GUILayout.Toggle(Global.DRAW_SCENERY_VISIBILITY,"DRAW_SCENERY_VISIBILITY");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_COLLIDER_BOUNDS = GUILayout.Toggle(Global.DRAW_COLLIDER_BOUNDS,"DRAW_COLLIDER_BOUNDS");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_SHOCKWAVES = GUILayout.Toggle(Global.DRAW_SHOCKWAVES,"DRAW_SHOCKWAVES");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_CONNECTIVITY_GUESTS = GUILayout.Toggle(Global.DRAW_CONNECTIVITY_GUESTS,"DRAW_CONNECTIVITY_GUESTS");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.DRAW_CONNECTIVITY_STAFF = GUILayout.Toggle(Global.DRAW_CONNECTIVITY_STAFF,"DRAW_CONNECTIVITY_STAFF");
            GUILayout.EndHorizontal();*/

            GUILayout.BeginHorizontal();
            Global.GUESTS_LIKE_EVERY_RIDE = GUILayout.Toggle(Global.GUESTS_LIKE_EVERY_RIDE,"GUESTS_LIKE_EVERY_RIDE");
            GUILayout.EndHorizontal();

            /*GUILayout.BeginHorizontal();
            Global.USE_RUNTIME_BATCHER = GUILayout.Toggle(Global.USE_RUNTIME_BATCHER,"USE_RUNTIME_BATCHER");
            GUILayout.EndHorizontal();*/

            GUILayout.BeginHorizontal();
            Global.PERSON_SPAWN = GUILayout.Toggle(Global.PERSON_SPAWN,"PERSON_SPAWN");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.PERSON_FOOTPRINTS_ENABLED = GUILayout.Toggle(Global.PERSON_FOOTPRINTS_ENABLED,"PERSON_FOOTPRINTS_ENABLED");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.PERSON_HEADLOOK_ENABLED = GUILayout.Toggle(Global.PERSON_HEADLOOK_ENABLED,"PERSON_HEADLOOK_ENABLED");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.YARR = GUILayout.Toggle(Global.YARR,"YARR");
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            Global.ALWAYS_SUNNY = GUILayout.Toggle(Global.ALWAYS_SUNNY,"ALWAYS_SUNNY");
            GUILayout.EndHorizontal();


            base.DrawContent ();
        }

        public float TextFloat(float input)
        {
            float output;
            if (float.TryParse (GUILayout.TextField (input.ToString()), out output)) {
                return output;
            }
            return input;
        }
    }
}

