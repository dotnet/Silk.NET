// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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
        [NativeName("Type", "")]
        [NativeName("Name", "XINPUT_DLL_A")]
        public const string DllA = unchecked((string) "xinput1_4.dll");
        [NativeName("Type", "")]
        [NativeName("Name", "XINPUT_DLL_W")]
        public const string DllW = unchecked((string) "xinput1_4.dll");
        [NativeName("Type", "")]
        [NativeName("Name", "XINPUT_DLL")]
        public const string Dll = unchecked((string) "xinput1_4.dll");
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_DEVTYPE_GAMEPAD")]
        public const int DevtypeGamepad = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_DEVSUBTYPE_GAMEPAD")]
        public const int DevsubtypeGamepad = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_DEVSUBTYPE_UNKNOWN")]
        public const int DevsubtypeUnknown = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_DEVSUBTYPE_WHEEL")]
        public const int DevsubtypeWheel = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_DEVSUBTYPE_ARCADE_STICK")]
        public const int DevsubtypeArcadeStick = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_DEVSUBTYPE_FLIGHT_STICK")]
        public const int DevsubtypeFlightStick = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_DEVSUBTYPE_DANCE_PAD")]
        public const int DevsubtypeDancePad = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_DEVSUBTYPE_GUITAR")]
        public const int DevsubtypeGuitar = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_DEVSUBTYPE_GUITAR_ALTERNATE")]
        public const int DevsubtypeGuitarAlternate = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_DEVSUBTYPE_DRUM_KIT")]
        public const int DevsubtypeDrumKit = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_DEVSUBTYPE_GUITAR_BASS")]
        public const int DevsubtypeGuitarBass = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_DEVSUBTYPE_ARCADE_PAD")]
        public const int DevsubtypeArcadePad = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_CAPS_VOICE_SUPPORTED")]
        public const int CapsVoiceSupported = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_CAPS_FFB_SUPPORTED")]
        public const int CapsFfbSupported = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_CAPS_WIRELESS")]
        public const int CapsWireless = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_CAPS_PMD_SUPPORTED")]
        public const int CapsPmdSupported = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_CAPS_NO_NAVIGATION")]
        public const int CapsNoNavigation = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_DPAD_UP")]
        public const int GamepadDpadUp = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_DPAD_DOWN")]
        public const int GamepadDpadDown = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_DPAD_LEFT")]
        public const int GamepadDpadLeft = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_DPAD_RIGHT")]
        public const int GamepadDpadRight = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_START")]
        public const int GamepadStart = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_BACK")]
        public const int GamepadBack = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_LEFT_THUMB")]
        public const int GamepadLeftThumb = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_RIGHT_THUMB")]
        public const int GamepadRightThumb = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_LEFT_SHOULDER")]
        public const int GamepadLeftShoulder = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_RIGHT_SHOULDER")]
        public const int GamepadRightShoulder = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_A")]
        public const int GamepadA = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_B")]
        public const int GamepadB = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_X")]
        public const int GamepadX = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_Y")]
        public const int GamepadY = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE")]
        public const int GamepadLeftThumbDeadzone = unchecked((int) 0x1EA9);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE")]
        public const int GamepadRightThumbDeadzone = unchecked((int) 0x21F1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_GAMEPAD_TRIGGER_THRESHOLD")]
        public const int GamepadTriggerThreshold = unchecked((int) 0x1E);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_FLAG_GAMEPAD")]
        public const int FlagGamepad = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "BATTERY_DEVTYPE_GAMEPAD")]
        public const int BatteryDevtypeGamepad = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "BATTERY_DEVTYPE_HEADSET")]
        public const int BatteryDevtypeHeadset = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "BATTERY_TYPE_DISCONNECTED")]
        public const int BatteryTypeDisconnected = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "BATTERY_TYPE_WIRED")]
        public const int BatteryTypeWired = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "BATTERY_TYPE_ALKALINE")]
        public const int BatteryTypeAlkaline = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "BATTERY_TYPE_NIMH")]
        public const int BatteryTypeNimh = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "BATTERY_TYPE_UNKNOWN")]
        public const int BatteryTypeUnknown = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "BATTERY_LEVEL_EMPTY")]
        public const int BatteryLevelEmpty = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "BATTERY_LEVEL_LOW")]
        public const int BatteryLevelLow = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "BATTERY_LEVEL_MEDIUM")]
        public const int BatteryLevelMedium = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "BATTERY_LEVEL_FULL")]
        public const int BatteryLevelFull = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "XUSER_MAX_COUNT")]
        public const int XuserMaxCount = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "XUSER_INDEX_ANY")]
        public const int XuserIndexAny = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_A")]
        public const int VKPadA = unchecked((int) 0x5800);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_B")]
        public const int VKPadB = unchecked((int) 0x5801);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_X")]
        public const int VKPadX = unchecked((int) 0x5802);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_Y")]
        public const int VKPadY = unchecked((int) 0x5803);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_RSHOULDER")]
        public const int VKPadRshoulder = unchecked((int) 0x5804);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_LSHOULDER")]
        public const int VKPadLshoulder = unchecked((int) 0x5805);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_LTRIGGER")]
        public const int VKPadLtrigger = unchecked((int) 0x5806);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_RTRIGGER")]
        public const int VKPadRtrigger = unchecked((int) 0x5807);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_DPAD_UP")]
        public const int VKPadDpadUp = unchecked((int) 0x5810);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_DPAD_DOWN")]
        public const int VKPadDpadDown = unchecked((int) 0x5811);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_DPAD_LEFT")]
        public const int VKPadDpadLeft = unchecked((int) 0x5812);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_DPAD_RIGHT")]
        public const int VKPadDpadRight = unchecked((int) 0x5813);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_START")]
        public const int VKPadStart = unchecked((int) 0x5814);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_BACK")]
        public const int VKPadBack = unchecked((int) 0x5815);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_LTHUMB_PRESS")]
        public const int VKPadLthumbPress = unchecked((int) 0x5816);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_RTHUMB_PRESS")]
        public const int VKPadRthumbPress = unchecked((int) 0x5817);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_LTHUMB_UP")]
        public const int VKPadLthumbUp = unchecked((int) 0x5820);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_LTHUMB_DOWN")]
        public const int VKPadLthumbDown = unchecked((int) 0x5821);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_LTHUMB_RIGHT")]
        public const int VKPadLthumbRight = unchecked((int) 0x5822);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_LTHUMB_LEFT")]
        public const int VKPadLthumbLeft = unchecked((int) 0x5823);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_LTHUMB_UPLEFT")]
        public const int VKPadLthumbUpleft = unchecked((int) 0x5824);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_LTHUMB_UPRIGHT")]
        public const int VKPadLthumbUpright = unchecked((int) 0x5825);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_LTHUMB_DOWNRIGHT")]
        public const int VKPadLthumbDownright = unchecked((int) 0x5826);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_LTHUMB_DOWNLEFT")]
        public const int VKPadLthumbDownleft = unchecked((int) 0x5827);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_RTHUMB_UP")]
        public const int VKPadRthumbUp = unchecked((int) 0x5830);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_RTHUMB_DOWN")]
        public const int VKPadRthumbDown = unchecked((int) 0x5831);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_RTHUMB_RIGHT")]
        public const int VKPadRthumbRight = unchecked((int) 0x5832);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_RTHUMB_LEFT")]
        public const int VKPadRthumbLeft = unchecked((int) 0x5833);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_RTHUMB_UPLEFT")]
        public const int VKPadRthumbUpleft = unchecked((int) 0x5834);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_RTHUMB_UPRIGHT")]
        public const int VKPadRthumbUpright = unchecked((int) 0x5835);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_RTHUMB_DOWNRIGHT")]
        public const int VKPadRthumbDownright = unchecked((int) 0x5836);
        [NativeName("Type", "int")]
        [NativeName("Name", "VK_PAD_RTHUMB_DOWNLEFT")]
        public const int VKPadRthumbDownleft = unchecked((int) 0x5837);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_KEYSTROKE_KEYDOWN")]
        public const int KeystrokeKeydown = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_KEYSTROKE_KEYUP")]
        public const int KeystrokeKeyup = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "XINPUT_KEYSTROKE_REPEAT")]
        public const int KeystrokeRepeat = unchecked((int) 0x4);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetState", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetState(uint dwUserIndex, State* pState);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetState", Convention = CallingConvention.StdCall)]
        public partial uint GetState(uint dwUserIndex, ref State pState);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputSetState", Convention = CallingConvention.StdCall)]
        public unsafe partial uint SetState(uint dwUserIndex, Vibration* pVibration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 264, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputSetState", Convention = CallingConvention.StdCall)]
        public partial uint SetState(uint dwUserIndex, ref Vibration pVibration);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetCapabilities", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetCapabilities(uint dwUserIndex, uint dwFlags, Capabilities* pCapabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 270, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetCapabilities", Convention = CallingConvention.StdCall)]
        public partial uint GetCapabilities(uint dwUserIndex, uint dwFlags, ref Capabilities pCapabilities);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 279, Column 13 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputEnable", Convention = CallingConvention.StdCall)]
        public partial void Enable(Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, ref char pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, ref char pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, uint* pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, ref uint pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, ref uint pRenderCount, char* pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, ref uint pRenderCount, ref char pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, ref uint pRenderCount, ref char pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, ref uint pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, char* pRenderDeviceId, ref uint pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, uint* pRenderCount, ref char pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, uint* pRenderCount, ref char pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, uint* pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, uint* pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, ref uint pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, ref uint pRenderCount, char* pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, ref uint pRenderCount, ref char pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, ref uint pRenderCount, ref char pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, ref uint pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public partial uint GetAudioDeviceIds(uint dwUserIndex, ref char pRenderDeviceId, ref uint pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, uint* pRenderCount, char* pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, uint* pRenderCount, ref char pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, uint* pRenderCount, ref char pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, uint* pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, uint* pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, ref uint pRenderCount, char* pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, ref uint pRenderCount, char* pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, ref uint pRenderCount, ref char pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public partial uint GetAudioDeviceIds(uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, ref uint pRenderCount, ref char pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetAudioDeviceIds(uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, ref uint pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, uint* pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetAudioDeviceIds", Convention = CallingConvention.StdCall)]
        public partial uint GetAudioDeviceIds(uint dwUserIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pRenderDeviceId, ref uint pRenderCount, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pCaptureDeviceId, ref uint pCaptureCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 297, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetBatteryInformation", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetBatteryInformation(uint dwUserIndex, byte devType, BatteryInformation* pBatteryInformation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 297, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetBatteryInformation", Convention = CallingConvention.StdCall)]
        public partial uint GetBatteryInformation(uint dwUserIndex, byte devType, ref BatteryInformation pBatteryInformation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetKeystroke", Convention = CallingConvention.StdCall)]
        public unsafe partial uint GetKeystroke(uint dwUserIndex, uint dwReserved, Keystroke* pKeystroke);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 14 in Xinput.h")]
        [NativeApi(EntryPoint = "XInputGetKeystroke", Convention = CallingConvention.StdCall)]
        public partial uint GetKeystroke(uint dwUserIndex, uint dwReserved, ref Keystroke pKeystroke);


        public XInput(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

