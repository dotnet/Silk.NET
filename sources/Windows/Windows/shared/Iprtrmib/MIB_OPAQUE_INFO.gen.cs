// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='MIB_OPAQUE_INFO.xml' path='doc/member[@name="MIB_OPAQUE_INFO"]/*'/>
public unsafe partial struct MIB_OPAQUE_INFO
{
    /// <include file='MIB_OPAQUE_INFO.xml' path='doc/member[@name="MIB_OPAQUE_INFO.dwId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwId;
    /// <include file='MIB_OPAQUE_INFO.xml' path='doc/member[@name="MIB_OPAQUE_INFO.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_Iprtrmib_L306_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ullAlign"]/*'/>
    [UnscopedRef]
    public ref ulong ullAlign
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ullAlign;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.rgbyData"]/*'/>
    [UnscopedRef]
    public Span<byte> rgbyData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.rgbyData[0], 1);
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ullAlign"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong ullAlign;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.rgbyData"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("BYTE[1]")]
        public fixed byte rgbyData[1];
    }
}