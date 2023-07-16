// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DRIVE_LAYOUT_INFORMATION_EX.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_EX"]/*'/>
public partial struct DRIVE_LAYOUT_INFORMATION_EX
{
    /// <include file='DRIVE_LAYOUT_INFORMATION_EX.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_EX.PartitionStyle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PartitionStyle;
    /// <include file='DRIVE_LAYOUT_INFORMATION_EX.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_EX.PartitionCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PartitionCount;
    /// <include file='DRIVE_LAYOUT_INFORMATION_EX.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_EX.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L9090_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='DRIVE_LAYOUT_INFORMATION_EX.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_EX.PartitionEntry"]/*'/>
    [NativeTypeName("PARTITION_INFORMATION_EX[1]")]
    public _PartitionEntry_e__FixedBuffer PartitionEntry;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Mbr"]/*'/>
    [UnscopedRef]
    public ref DRIVE_LAYOUT_INFORMATION_MBR Mbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Mbr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Gpt"]/*'/>
    [UnscopedRef]
    public ref DRIVE_LAYOUT_INFORMATION_GPT Gpt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Gpt;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Mbr"]/*'/>
        [FieldOffset(0)]
        public DRIVE_LAYOUT_INFORMATION_MBR Mbr;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Gpt"]/*'/>
        [FieldOffset(0)]
        public DRIVE_LAYOUT_INFORMATION_GPT Gpt;
    }

    /// <include file='_PartitionEntry_e__FixedBuffer.xml' path='doc/member[@name="_PartitionEntry_e__FixedBuffer"]/*'/>
    public partial struct _PartitionEntry_e__FixedBuffer
    {
        public PARTITION_INFORMATION_EX e0;
        [UnscopedRef]
        public ref PARTITION_INFORMATION_EX this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PARTITION_INFORMATION_EX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}