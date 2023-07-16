// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.GetdfDIJoystick"]/*'/>
    [DllImport("dinput8", ExactSpelling = true)]
    [return: NativeTypeName("LPCDIDATAFORMAT")]
    public static extern DIDATAFORMAT* GetdfDIJoystick();
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DirectInput8Create"]/*'/>
    [DllImport("dinput8", ExactSpelling = true)]
    public static extern HRESULT DirectInput8Create(HINSTANCE hinst, [NativeTypeName("DWORD")] uint dwVersion, [NativeTypeName("const IID &")] Guid* riidltf, [NativeTypeName("LPVOID *")] void** ppvOut, [NativeTypeName("LPUNKNOWN")] IUnknown* punkOuter);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.joyConfigChanged"]/*'/>
    [DllImport("Winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint joyConfigChanged([NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.ShowJoyCPL"]/*'/>
    [DllImport("joy.cpl", ExactSpelling = true)]
    public static extern void ShowJoyCPL(HWND hWnd);
    [NativeTypeName("#define DIRECTINPUT_HEADER_VERSION 0x0800")]
    public const int DIRECTINPUT_HEADER_VERSION = 0x0800;
    [NativeTypeName("#define DIRECTINPUT_VERSION DIRECTINPUT_HEADER_VERSION")]
    public const int DIRECTINPUT_VERSION = 0x0800;
    [NativeTypeName("#define DIPROPRANGE_NOMIN ((LONG)0x80000000)")]
    public const int DIPROPRANGE_NOMIN = unchecked((int)(0x80000000));
    [NativeTypeName("#define DIPROPRANGE_NOMAX ((LONG)0x7FFFFFFF)")]
    public const int DIPROPRANGE_NOMAX = ((int)(0x7FFFFFFF));
    [NativeTypeName("#define MAXCPOINTSNUM 8")]
    public const int MAXCPOINTSNUM = 8;
}