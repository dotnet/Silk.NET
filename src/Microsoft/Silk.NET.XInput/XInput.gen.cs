// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.XInput
{
    public unsafe partial class XInput : NativeAPI
    {

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetState")]
        public unsafe partial uint GetState(uint dwUserIndex, State* pState);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetState")]
        public partial uint GetState(uint dwUserIndex, ref State pState);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputSetState")]
        public unsafe partial uint SetState(uint dwUserIndex, Vibration* pVibration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputSetState")]
        public partial uint SetState(uint dwUserIndex, ref Vibration pVibration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetCapabilities")]
        public unsafe partial uint GetCapabilities(uint dwUserIndex, uint dwFlags, Capabilities* pCapabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetCapabilities")]
        public partial uint GetCapabilities(uint dwUserIndex, uint dwFlags, ref Capabilities pCapabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 279, Column 13 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputEnable")]
        public partial void Enable(int enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, ref char pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, ref char pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, string pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, string pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, ref uint pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, ref uint pRenderCount, char* pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, ref uint pRenderCount, ref char pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, ref uint pRenderCount, ref char pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, ref uint pRenderCount, string pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, ref uint pRenderCount, string pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, uint* pRenderCount, ref char pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, uint* pRenderCount, ref char pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, uint* pRenderCount, string pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, uint* pRenderCount, string pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, ref uint pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, ref uint pRenderCount, char* pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, ref uint pRenderCount, ref char pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, ref uint pRenderCount, ref char pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, ref uint pRenderCount, string pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, ref uint pRenderCount, string pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, string pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, string pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, string pRenderDeviceId, uint* pRenderCount, ref char pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, string pRenderDeviceId, uint* pRenderCount, ref char pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, string pRenderDeviceId, uint* pRenderCount, string pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, string pRenderDeviceId, uint* pRenderCount, string pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, string pRenderDeviceId, ref uint pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, string pRenderDeviceId, ref uint pRenderCount, char* pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, string pRenderDeviceId, ref uint pRenderCount, ref char pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public partial uint GetAudioDeviceIds(uint dwUserIndex, string pRenderDeviceId, ref uint pRenderCount, ref char pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, string pRenderDeviceId, ref uint pRenderCount, string pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds")]
        public partial uint GetAudioDeviceIds(uint dwUserIndex, string pRenderDeviceId, ref uint pRenderCount, string pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 297, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetBatteryInformation")]
        public unsafe partial uint GetBatteryInformation(uint dwUserIndex, byte devType, BatteryInformation* pBatteryInformation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 297, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetBatteryInformation")]
        public partial uint GetBatteryInformation(uint dwUserIndex, byte devType, ref BatteryInformation pBatteryInformation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetKeystroke")]
        public unsafe partial uint GetKeystroke(uint dwUserIndex, uint dwReserved, Keystroke* pKeystroke);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 14 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um\\Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetKeystroke")]
        public partial uint GetKeystroke(uint dwUserIndex, uint dwReserved, ref Keystroke pKeystroke);


        public XInput(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

