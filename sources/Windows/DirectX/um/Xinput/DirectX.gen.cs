// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XInputGetState"]/*'/>
    [DllImport("xinput1_4", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint XInputGetState([NativeTypeName("DWORD")] uint dwUserIndex, XINPUT_STATE* pState);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XInputSetState"]/*'/>
    [DllImport("xinput1_4", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint XInputSetState([NativeTypeName("DWORD")] uint dwUserIndex, XINPUT_VIBRATION* pVibration);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XInputGetCapabilities"]/*'/>
    [DllImport("xinput1_4", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint XInputGetCapabilities([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("DWORD")] uint dwFlags, XINPUT_CAPABILITIES* pCapabilities);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XInputEnable"]/*'/>
    [DllImport("xinput1_4", ExactSpelling = true)]
    public static extern void XInputEnable(BOOL enable);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XInputGetAudioDeviceIds"]/*'/>
    [DllImport("xinput1_4", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint XInputGetAudioDeviceIds([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("LPWSTR")] ushort* pRenderDeviceId, uint* pRenderCount, [NativeTypeName("LPWSTR")] ushort* pCaptureDeviceId, uint* pCaptureCount);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XInputGetBatteryInformation"]/*'/>
    [DllImport("xinput1_4", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint XInputGetBatteryInformation([NativeTypeName("DWORD")] uint dwUserIndex, byte devType, XINPUT_BATTERY_INFORMATION* pBatteryInformation);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XInputGetKeystroke"]/*'/>
    [DllImport("xinput1_4", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint XInputGetKeystroke([NativeTypeName("DWORD")] uint dwUserIndex, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("PXINPUT_KEYSTROKE")] XINPUT_KEYSTROKE* pKeystroke);
    [NativeTypeName("#define XUSER_MAX_COUNT 4")]
    public const int XUSER_MAX_COUNT = 4;
    [NativeTypeName("#define XUSER_INDEX_ANY 0x000000FF")]
    public const int XUSER_INDEX_ANY = 0x000000FF;
}