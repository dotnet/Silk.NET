// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct JOBOBJECT_CPU_RATE_CONTROL_INFORMATION
{
    /// <include file='JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.ControlFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ControlFlags;
    /// <include file='JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L13027_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CpuRate"]/*'/>
    [UnscopedRef]
    public ref uint CpuRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.CpuRate;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Weight"]/*'/>
    [UnscopedRef]
    public ref uint Weight
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Weight;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MinRate"]/*'/>
    [UnscopedRef]
    public ref ushort MinRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.MinRate;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MaxRate"]/*'/>
    [UnscopedRef]
    public ref ushort MaxRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.MaxRate;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CpuRate"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint CpuRate;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Weight"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Weight;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L13030_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MinRate"]/*'/>
            [NativeTypeName("WORD")]
            public ushort MinRate;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MaxRate"]/*'/>
            [NativeTypeName("WORD")]
            public ushort MaxRate;
        }
    }
}