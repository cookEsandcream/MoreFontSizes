using HarmonyLib;
using Kingmaker.UI.SettingsUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreFontSizes.Patches {
    /// <summary>
    /// Set the maximum font size.
    /// </summary>
    [HarmonyPatch(typeof(SettingsEntitySlider), "MaxValue", MethodType.Getter)]
    static class MaxFontSizePatch {
        const float MaxFontSize = 5f;
        static void Postfix(SettingsEntitySlider __instance, ref float __result) {
            if (!Main.Enabled) return;
            // Postfix needs to apply to the class that declares MaxValue; only change font size's slider.
            if (!(__instance.GetType() == typeof(SettingsEntitySliderScaleFont))) return;
            __result = MaxFontSize;
        }
    }
}
