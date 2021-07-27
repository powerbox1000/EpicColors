using HarmonyLib;
using UnityEngine;
using System.Linq;
using static EpicColors.CustomColorHandler;

namespace EpicColors
{
    [HarmonyPatch]
    [HarmonyPriority(Priority.Last)]
    public static class Watermark {
        public static string GetColorName(this int colorId) {
            var IdList = colorId - OldMainCount;

            var name = AllColors.ElementAtOrDefault(IdList) != null? 
            AllColors[IdList].Name : "";
            var color = Palette.PlayerColors[colorId].ToHexString();

            return name != ""? $"You are using <color=#{color}>{name}</color>": "";
        }
    }
}
