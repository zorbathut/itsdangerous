using CommunityCoreLibrary_ItsDangerous;
using System;
using System.Reflection;
using UnityEngine;
using Verse;

namespace ItsDangerous
{
    class Bootstrap : Def
    {
        static Bootstrap()
        {
            try
            {
                {
                    MethodInfo method1 = typeof(RimWorld.ThinkNode_ConditionalShouldFollowMaster).GetMethod("Satisfied", BindingFlags.Instance | BindingFlags.NonPublic);
                    MethodInfo method2 = typeof(ThinkNode_ConditionalShouldFollowMaster_Detour).GetMethod("Satisfied", BindingFlags.Static | BindingFlags.Public);
                    if (!Detours.TryDetourFromTo(method1, method2))
                    {
                        Log.Error("EVERYTHING IS BROKEN 1");
                        return;
                    }
                }
            }
            catch (Exception)
            {
                Log.Error("something is seriously wrong");
            }
        }
    }
}
