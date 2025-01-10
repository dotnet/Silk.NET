// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct RID_DEVICE_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwType;

    [NativeTypeName("__AnonymousRecord_winuser_L15240_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref RID_DEVICE_INFO_MOUSE mouse
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.mouse; }
    }

    [UnscopedRef]
    public ref RID_DEVICE_INFO_KEYBOARD keyboard
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.keyboard; }
    }

    [UnscopedRef]
    public ref RID_DEVICE_INFO_HID hid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hid; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public RID_DEVICE_INFO_MOUSE mouse;

        [FieldOffset(0)]
        public RID_DEVICE_INFO_KEYBOARD keyboard;

        [FieldOffset(0)]
        public RID_DEVICE_INFO_HID hid;
    }
}
