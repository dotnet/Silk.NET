// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct NOTIFYICONDATAA
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public HWND hWnd;
    public uint uID;
    public uint uFlags;
    public uint uCallbackMessage;
    public HICON hIcon;

    [NativeTypeName("CHAR[128]")]
    public _szTip_e__FixedBuffer szTip;

    [NativeTypeName("DWORD")]
    public uint dwState;

    [NativeTypeName("DWORD")]
    public uint dwStateMask;

    [NativeTypeName("CHAR[256]")]
    public _szInfo_e__FixedBuffer szInfo;

    [NativeTypeName("__AnonymousRecord_shellapi_L1027_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("CHAR[64]")]
    public _szInfoTitle_e__FixedBuffer szInfoTitle;

    [NativeTypeName("DWORD")]
    public uint dwInfoFlags;
    public Guid guidItem;
    public HICON hBalloonIcon;

    [UnscopedRef]
    public ref uint uTimeout
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.uTimeout; }
    }

    [UnscopedRef]
    public ref uint uVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.uVersion; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint uTimeout;

        [FieldOffset(0)]
        public uint uVersion;
    }

    [InlineArray(128)]
    public partial struct _szTip_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(256)]
    public partial struct _szInfo_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(64)]
    public partial struct _szInfoTitle_e__FixedBuffer
    {
        public sbyte e0;
    }
}
