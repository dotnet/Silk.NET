// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='PARTITION_INFORMATION_EX.xml' path='doc/member[@name="PARTITION_INFORMATION_EX"]/*' />
public partial struct PARTITION_INFORMATION_EX
{
    /// <include file='PARTITION_INFORMATION_EX.xml' path='doc/member[@name="PARTITION_INFORMATION_EX.PartitionStyle"]/*' />
    public PARTITION_STYLE PartitionStyle;

    /// <include file='PARTITION_INFORMATION_EX.xml' path='doc/member[@name="PARTITION_INFORMATION_EX.StartingOffset"]/*' />
    public LARGE_INTEGER StartingOffset;

    /// <include file='PARTITION_INFORMATION_EX.xml' path='doc/member[@name="PARTITION_INFORMATION_EX.PartitionLength"]/*' />
    public LARGE_INTEGER PartitionLength;

    /// <include file='PARTITION_INFORMATION_EX.xml' path='doc/member[@name="PARTITION_INFORMATION_EX.PartitionNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint PartitionNumber;

    /// <include file='PARTITION_INFORMATION_EX.xml' path='doc/member[@name="PARTITION_INFORMATION_EX.RewritePartition"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte RewritePartition;

    /// <include file='PARTITION_INFORMATION_EX.xml' path='doc/member[@name="PARTITION_INFORMATION_EX.IsServicePartition"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte IsServicePartition;

    /// <include file='PARTITION_INFORMATION_EX.xml' path='doc/member[@name="PARTITION_INFORMATION_EX.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L9037_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Mbr"]/*' />
    [UnscopedRef]
    public ref PARTITION_INFORMATION_MBR Mbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Mbr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Gpt"]/*' />
    [UnscopedRef]
    public ref PARTITION_INFORMATION_GPT Gpt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Gpt;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Mbr"]/*' />
        [FieldOffset(0)]
        public PARTITION_INFORMATION_MBR Mbr;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Gpt"]/*' />
        [FieldOffset(0)]
        public PARTITION_INFORMATION_GPT Gpt;
    }
}
