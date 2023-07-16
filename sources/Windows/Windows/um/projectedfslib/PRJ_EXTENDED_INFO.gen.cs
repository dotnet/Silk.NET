// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='PRJ_EXTENDED_INFO.xml' path='doc/member[@name="PRJ_EXTENDED_INFO"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct PRJ_EXTENDED_INFO
{
    /// <include file='PRJ_EXTENDED_INFO.xml' path='doc/member[@name="PRJ_EXTENDED_INFO.InfoType"]/*'/>
    public PRJ_EXT_INFO_TYPE InfoType;
    /// <include file='PRJ_EXTENDED_INFO.xml' path='doc/member[@name="PRJ_EXTENDED_INFO.NextInfoOffset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint NextInfoOffset;
    /// <include file='PRJ_EXTENDED_INFO.xml' path='doc/member[@name="PRJ_EXTENDED_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_projectedfslib_L102_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Symlink"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._Symlink_e__Struct Symlink
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Symlink;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Symlink"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_projectedfslib_L103_C9")]
        public _Symlink_e__Struct Symlink;
        /// <include file='_Symlink_e__Struct.xml' path='doc/member[@name="_Symlink_e__Struct"]/*'/>
        public unsafe partial struct _Symlink_e__Struct
        {
            /// <include file='_Symlink_e__Struct.xml' path='doc/member[@name="_Symlink_e__Struct.TargetName"]/*'/>
            [NativeTypeName("PCWSTR")]
            public ushort* TargetName;
        }
    }
}