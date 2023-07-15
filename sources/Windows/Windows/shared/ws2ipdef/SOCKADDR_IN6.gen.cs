// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SOCKADDR_IN6.xml' path='doc/member[@name="SOCKADDR_IN6"]/*'/>
public partial struct SOCKADDR_IN6
{
    /// <include file='SOCKADDR_IN6.xml' path='doc/member[@name="SOCKADDR_IN6.sin6_family"]/*'/>
    [NativeTypeName("ADDRESS_FAMILY")]
    public ushort sin6_family;
    /// <include file='SOCKADDR_IN6.xml' path='doc/member[@name="SOCKADDR_IN6.sin6_port"]/*'/>
    public ushort sin6_port;
    /// <include file='SOCKADDR_IN6.xml' path='doc/member[@name="SOCKADDR_IN6.sin6_flowinfo"]/*'/>
    [NativeTypeName("ULONG")]
    public uint sin6_flowinfo;
    /// <include file='SOCKADDR_IN6.xml' path='doc/member[@name="SOCKADDR_IN6.sin6_addr"]/*'/>
    public IN6_ADDR sin6_addr;
    /// <include file='SOCKADDR_IN6.xml' path='doc/member[@name="SOCKADDR_IN6.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_ws2ipdef_L196_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.sin6_scope_id"]/*'/>
    [UnscopedRef]
    public ref uint sin6_scope_id
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.sin6_scope_id;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.sin6_scope_struct"]/*'/>
    [UnscopedRef]
    public ref SCOPE_ID sin6_scope_struct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.sin6_scope_struct;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.sin6_scope_id"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint sin6_scope_id;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.sin6_scope_struct"]/*'/>
        [FieldOffset(0)]
        public SCOPE_ID sin6_scope_struct;
    }
}