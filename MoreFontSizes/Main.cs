using HarmonyLib;
using System;
using System.Reflection;
using UnityEngine;
using UnityModManagerNet;

namespace MoreFontSizes {
    /// <summary>
    /// Entry point to the application.
    /// </summary>
    public class Main {
        public static bool Enabled;

        static bool Load(UnityModManager.ModEntry modEntry) {
            modEntry.OnToggle = OnToggle;

            var harmony = new Harmony(modEntry.Info.Id);
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            return true;
        }

        static bool OnToggle(UnityModManager.ModEntry modEntry, bool value) {
            Enabled = value;
            return true;
        }
    }
}
