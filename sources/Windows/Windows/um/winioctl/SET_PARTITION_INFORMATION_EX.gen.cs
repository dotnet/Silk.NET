// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SET_PARTITION_INFORMATION_EX.xml' path='doc/member[@name="SET_PARTITION_INFORMATION_EX"]/*'/>
public partial struct SET_PARTITION_INFORMATION_EX
{
    /// <include file='SET_PARTITION_INFORMATION_EX.xml' path='doc/member[@name="SET_PARTITION_INFORMATION_EX.PartitionStyle"]/*'/>
    public PARTITION_STYLE PartitionStyle;
    /// <include file='SET_PARTITION_INFORMATION_EX.xml' path='doc/member[@name="SET_PARTITION_INFORMATION_EX.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L8969_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Mbr"]/*'/>
    [UnscopedRef]
    public ref SET_PARTITION_INFORMATION Mbr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Mbr;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Gpt"]/*'/>
    [UnscopedRef]
    public ref PARTITION_INFORMATION_GPT Gpt
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
        [NativeTypeName("SET_PARTITION_INFORMATION_MBR")]
        public SET_PARTITION_INFORMATION Mbr;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Gpt"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("SET_PARTITION_INFORMATION_GPT")]
        public PARTITION_INFORMATION_GPT Gpt;
    }
}