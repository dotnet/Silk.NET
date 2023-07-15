// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SD_GLOBAL_CHANGE_INPUT.xml' path='doc/member[@name="SD_GLOBAL_CHANGE_INPUT"]/*'/>
public partial struct SD_GLOBAL_CHANGE_INPUT
{
    /// <include file='SD_GLOBAL_CHANGE_INPUT.xml' path='doc/member[@name="SD_GLOBAL_CHANGE_INPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='SD_GLOBAL_CHANGE_INPUT.xml' path='doc/member[@name="SD_GLOBAL_CHANGE_INPUT.ChangeType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ChangeType;
    /// <include file='SD_GLOBAL_CHANGE_INPUT.xml' path='doc/member[@name="SD_GLOBAL_CHANGE_INPUT.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L14261_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdChange"]/*'/>
    [UnscopedRef]
    public ref SD_CHANGE_MACHINE_SID_INPUT SdChange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.SdChange;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdQueryStats"]/*'/>
    [UnscopedRef]
    public ref SD_QUERY_STATS_INPUT SdQueryStats
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.SdQueryStats;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdEnumSds"]/*'/>
    [UnscopedRef]
    public ref SD_ENUM_SDS_INPUT SdEnumSds
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.SdEnumSds;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdChange"]/*'/>
        [FieldOffset(0)]
        public SD_CHANGE_MACHINE_SID_INPUT SdChange;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdQueryStats"]/*'/>
        [FieldOffset(0)]
        public SD_QUERY_STATS_INPUT SdQueryStats;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SdEnumSds"]/*'/>
        [FieldOffset(0)]
        public SD_ENUM_SDS_INPUT SdEnumSds;
    }
}