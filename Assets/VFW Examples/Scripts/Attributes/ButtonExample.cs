﻿using UnityEngine;
using System.Collections;
using Vexe.Runtime.Types;

namespace VFWExamples
{
    public class ButtonExample : BetterBehaviour
    {
        [Button("Log1", "1", "toolbarButton"),
         Button(0, "Log2", "2"),
         Button(1, "Log3", "3", "miniButtonRight")]
        public int value;

        public ButtonStruct test;

        void Log1(int x) { Log("1: " + x); }
        void Log2(int x) { Log("2: " + x); }
        void Log3(int x) { Log("3: " + x); }

        public struct ButtonStruct
        {
            [PerItem, Button("LogGO", "L")]
            public GameObject[] gos;

            void LogGO(GameObject go)
            {
                sLog(go);
            }
        }
    }
}