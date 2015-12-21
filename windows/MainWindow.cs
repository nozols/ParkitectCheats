using CheatMod.Reference;
using UnityEngine;

namespace CheatMod.Windows
{
    class MainWindow : CMWindow
    {
        public MainWindow(int windowId) : base(windowId){
            windowName = "Cheat Mod";
            WindowRect = new Rect(20, 20, 700, 200);
        }

        public override void DrawContent()
        {
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Spawn 1 Guest"))
            {
                GameController.Instance.park.spawnGuest();
            }
            if (GUILayout.Button("Spawn 5 Guests"))
            {
                for (byte i = 0; i < 5; i++)
                {
                    GameController.Instance.park.spawnGuest();
                }
            }
            if (GUILayout.Button("Spawn 10 Guests"))
            {
                for (byte i = 0; i < 10; i++)
                {
                    GameController.Instance.park.spawnGuest();
                }
            }
            if (GUILayout.Button("Spawn 100 Guest"))
            {
                for (byte i = 0; i < 100; i++)
                {
                    GameController.Instance.park.spawnGuest();
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Give $1K"))
            {
                GameController.Instance.park.parkInfo.moneyTransaction(1000, MonthlyTransactions.Transaction.WAGES);
            }
            if (GUILayout.Button("Give $10K"))
            {
                GameController.Instance.park.parkInfo.moneyTransaction(10000, MonthlyTransactions.Transaction.WAGES);
            }
            if (GUILayout.Button("Give $100K"))
            {
                GameController.Instance.park.parkInfo.moneyTransaction(100000, MonthlyTransactions.Transaction.WAGES);
            }
            if (GUILayout.Button("Give $1M"))
            {
                GameController.Instance.park.parkInfo.moneyTransaction(1000000, MonthlyTransactions.Transaction.WAGES);
            }
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Set speed 1x"))
            {
                Time.timeScale = 1;
            }
            if (GUILayout.Button("Set speed 5x"))
            {
                Time.timeScale = 5;
            }
            if (GUILayout.Button("Set speed 10x"))
            {
                Time.timeScale = 10;
            }
            if (GUILayout.Button("Set speed 15x"))
            {
                Time.timeScale = 15;
            }
            GUILayout.Label("Current speed: " + Time.timeScale);
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Rate cleanliness 1"))
            {
                GameController.Instance.park.parkInfo.rateCleanliness(1.0F);
            }
            if (GUILayout.Button("Rate cleanliness 10"))
            {
                GameController.Instance.park.parkInfo.rateCleanliness(5.0F);
            }
            if (GUILayout.Button("Rate cleanliness 100"))
            {
                GameController.Instance.park.parkInfo.rateCleanliness(10.0F);
            }
            GUILayout.Label("Current Rating: " + GameController.Instance.park.parkInfo.RatingCleanliness);
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Rate price statisfaction 1"))
            {
                GameController.Instance.park.parkInfo.ratePriceSatisfaction(1.0F);
            }
            if (GUILayout.Button("Rate price statisfaction 10"))
            {
                GameController.Instance.park.parkInfo.ratePriceSatisfaction(5.0F);
            }
            if (GUILayout.Button("Rate price statisfaction 100"))
            {
                GameController.Instance.park.parkInfo.ratePriceSatisfaction(10.0F);
            }
            GUILayout.Label("Current Rating: " + GameController.Instance.park.parkInfo.RatingPriceSatisfaction);
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Recalculate current ratings")) {
                GameController.Instance.park.parkInfo.triggerRecalculateCurrentRatings();
            }
            if (GUILayout.Button("Open advanced window")) {
                CheatModController.getWindow(WindowIds.AdvancedWindow).OpenWindow();
            }
            GUILayout.EndHorizontal();
            
        }
    }
}
