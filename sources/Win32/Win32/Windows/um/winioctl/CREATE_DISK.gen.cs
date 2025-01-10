// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CREATE_DISK
{
    public PARTITION_STYLE PartitionStyle;

    [NativeTypeName("__AnonymousRecord_winioctl_L9272_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref CREATE_DISK_MBR Mbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Mbr; }
    }

    [UnscopedRef]
    public ref CREATE_DISK_GPT Gpt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Gpt; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public CREATE_DISK_MBR Mbr;

        [FieldOffset(0)]
        public CREATE_DISK_GPT Gpt;
    }
}
