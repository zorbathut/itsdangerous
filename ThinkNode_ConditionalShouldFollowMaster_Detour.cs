using System;
using System.Reflection;
using UnityEngine;
using RimWorld;
using Verse;
using Verse.Sound;

namespace ItsDangerous
{
    static class ThinkNode_ConditionalShouldFollowMaster_Detour
    {
        public static bool Satisfied(this ThinkNode_ConditionalShouldFollowMaster node, Pawn pawn)
        {
            if (pawn.playerSettings == null)
            {
                return false;
            }
            Pawn master = pawn.playerSettings.master;
            if (master == null)
            {
                return false;
            }
            Pawn carriedBy = master.CarriedBy;
            return (master.Spawned || carriedBy != null) && (master.Downed || (master.CurJob != null && master.CurJob.def == JobDefOf.Hunt) || (carriedBy != null && carriedBy.HostileTo(master)));
        }
    }
}
