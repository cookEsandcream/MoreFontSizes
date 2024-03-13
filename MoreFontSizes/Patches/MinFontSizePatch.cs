using HarmonyLib;
using Kingmaker.UI.SettingsUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFontSizes.Patches {
    /// <summary>
    /// Set the minimum font size.
    /// </summary>
    [HarmonyPatch(typeof(SettingsEntitySlider), "MinValue", MethodType.Getter)]
    static class MinFontSizePatch {
        const float MinFontSize = 0.1f;
        static void Postfix(SettingsEntitySlider __instance, ref float __result) {
            if (!Main.Enabled) return;
            // Postfix needs to apply to the class that declares MinValue; only change font size's slider.
            if (!(__instance.GetType() == typeof(SettingsEntitySliderScaleFont))) return;
            __result = MinFontSize;
        }
    }
}
