using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
using UnityEngine;
using PTmod;
using PTconsole;
using HarmonyLib;


namespace myMod
{
    [PTmodLoad]
    public class myMod : MonoBehaviour
    {

        // runs once at start
        private void Start()
        {
            Debug.Log("Hello from my mod");
        }

        // runs every frame
        private void Update()
        {

        }

        // unity imgui code goes here
        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 200, 200), "myMod has succesfully loaded!");
        }
    }
}