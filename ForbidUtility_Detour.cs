using System;
using System.Reflection;
using UnityEngine;
using RimWorld;
using Verse;
using Verse.Sound;

namespace ItsDangerous
{
    static class ForbidUtility_Detour
    {
        public static bool CaresAboutForbidden(Pawn pawn, bool cellTarget)
        {
            return !pawn.InMentalState && pawn.HostFaction == null && (!cellTarget || pawn.playerSettings == null || pawn.playerSettings.master == null || !pawn.playerSettings.master.Downed);
        }
    }
}
