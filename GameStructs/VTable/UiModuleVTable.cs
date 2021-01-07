﻿using System;
using System.Runtime.InteropServices;

namespace SimpleTweaksPlugin.GameStructs.Client.UI.VTable {

    [StructLayout(LayoutKind.Sequential, Size = 0x658)]
    public unsafe struct UiModuleVTable {
        public void* vf0; // dtor
        public void* vf1;
        public void* vf2;
        public void* vf3;
        public void* vf4;
        public void* vf5;
        public void* vf6;
        public void* vf7;
        public void* vf8;
        public void* vf9;
        public void* vf10;
        public void* vf11;
        public void* vf12;
        public IntPtr GetRaptureHotbarModule;
        public IntPtr GetRaptureGearsetModule;

    }
}
