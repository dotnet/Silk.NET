// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DEVICE_LOCATION
{
    [NativeTypeName("DWORD")]
    public uint Socket;

    [NativeTypeName("DWORD")]
    public uint Slot;

    [NativeTypeName("DWORD")]
    public uint Adapter;

    [NativeTypeName("DWORD")]
    public uint Port;

    [NativeTypeName("__AnonymousRecord_winioctl_L3065_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint Channel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous1.Channel; }
    }

    [UnscopedRef]
    public ref uint Device
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous1.Device; }
    }

    [UnscopedRef]
    public ref uint Target
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous2.Target; }
    }

    [UnscopedRef]
    public ref uint Lun
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous2.Lun; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L3067_C9")]
        public _Anonymous1_e__Struct Anonymous1;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L3075_C9")]
        public _Anonymous2_e__Struct Anonymous2;

        public partial struct _Anonymous1_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint Channel;

            [NativeTypeName("DWORD")]
            public uint Device;
        }

        public partial struct _Anonymous2_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint Target;

            [NativeTypeName("DWORD")]
            public uint Lun;
        }
    }
}
