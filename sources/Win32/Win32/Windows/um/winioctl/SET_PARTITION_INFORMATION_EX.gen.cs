// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SET_PARTITION_INFORMATION_EX
{
    public PARTITION_STYLE PartitionStyle;

    [NativeTypeName("__AnonymousRecord_winioctl_L9243_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref SET_PARTITION_INFORMATION Mbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Mbr; }
    }

    [UnscopedRef]
    public ref PARTITION_INFORMATION_GPT Gpt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Gpt; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("SET_PARTITION_INFORMATION_MBR")]
        public SET_PARTITION_INFORMATION Mbr;

        [FieldOffset(0)]
        [NativeTypeName("SET_PARTITION_INFORMATION_GPT")]
        public PARTITION_INFORMATION_GPT Gpt;
    }
}
