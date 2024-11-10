using System;
using BepInEx;
using UnityEngine;
using RWF;
using RWF.Swagshit;
using System.IO;
using System.Collections.Generic;
using RWF.FNFJSON;
using System.Linq;
using System.Collections;
using System.Runtime.InteropServices;
using Rewired.UI.ControlMapper;

//You dont have to follow the naming structure or id structure but its funni kek

namespace rwf_testmod
{
    [BepInPlugin(MOD_ID, "RWF: TestMod", "1.0.0")]
    class Plugin : BaseUnityPlugin
    {
        private const string MOD_ID = "yournamehere.rwf.testmod";
        // Add hooks
        public void OnEnable()
        {

            On.RainWorld.OnModsInit += Extras.WrapInit(LoadResources);

            //Add RWF Hooks Here

        }

        // Load any resources, such as sprites or sounds
        private void LoadResources(RainWorld rainWorld)
        {
            //Load Non-Character/Stage Related images here
        }
        
    }
}