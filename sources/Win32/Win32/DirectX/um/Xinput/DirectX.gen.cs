// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("xinput1_4", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint XInputGetState(
        [NativeTypeName("DWORD")] uint dwUserIndex,
        XINPUT_STATE* pState
    );

    [DllImport("xinput1_4", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint XInputSetState(
        [NativeTypeName("DWORD")] uint dwUserIndex,
        XINPUT_VIBRATION* pVibration
    );

    [DllImport("xinput1_4", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint XInputGetCapabilities(
        [NativeTypeName("DWORD")] uint dwUserIndex,
        [NativeTypeName("DWORD")] uint dwFlags,
        XINPUT_CAPABILITIES* pCapabilities
    );

    [DllImport("xinput1_4", ExactSpelling = true)]
    public static extern void XInputEnable(BOOL enable);

    [DllImport("xinput1_4", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint XInputGetAudioDeviceIds(
        [NativeTypeName("DWORD")] uint dwUserIndex,
        [NativeTypeName("LPWSTR")] ushort* pRenderDeviceId,
        uint* pRenderCount,
        [NativeTypeName("LPWSTR")] ushort* pCaptureDeviceId,
        uint* pCaptureCount
    );

    [DllImport("xinput1_4", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint XInputGetBatteryInformation(
        [NativeTypeName("DWORD")] uint dwUserIndex,
        byte devType,
        XINPUT_BATTERY_INFORMATION* pBatteryInformation
    );

    [DllImport("xinput1_4", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint XInputGetKeystroke(
        [NativeTypeName("DWORD")] uint dwUserIndex,
        [NativeTypeName("DWORD")] uint dwReserved,
        [NativeTypeName("PXINPUT_KEYSTROKE")] XINPUT_KEYSTROKE* pKeystroke
    );

    [NativeTypeName("#define XUSER_MAX_COUNT 4")]
    public const int XUSER_MAX_COUNT = 4;

    [NativeTypeName("#define XUSER_INDEX_ANY 0x000000FF")]
    public const int XUSER_INDEX_ANY = 0x000000FF;
}
