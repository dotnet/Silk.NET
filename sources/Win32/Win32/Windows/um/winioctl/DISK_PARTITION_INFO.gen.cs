// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISK_PARTITION_INFO
{
    [NativeTypeName("DWORD")]
    public uint SizeOfPartitionInfo;
    public PARTITION_STYLE PartitionStyle;

    [NativeTypeName("__AnonymousRecord_winioctl_L9444_C9")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._Mbr_e__Struct Mbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Mbr; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._Gpt_e__Struct Gpt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Gpt; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L9445_C17")]
        public _Mbr_e__Struct Mbr;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L9449_C17")]
        public _Gpt_e__Struct Gpt;

        public partial struct _Mbr_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint Signature;

            [NativeTypeName("DWORD")]
            public uint CheckSum;
        }

        public partial struct _Gpt_e__Struct
        {
            public Guid DiskId;
        }
    }
}
