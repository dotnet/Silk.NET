// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='ADDRINFO_DNS_SERVER.xml' path='doc/member[@name="ADDRINFO_DNS_SERVER"]/*'/>
public unsafe partial struct ADDRINFO_DNS_SERVER
{
    /// <include file='ADDRINFO_DNS_SERVER.xml' path='doc/member[@name="ADDRINFO_DNS_SERVER.ai_servertype"]/*'/>
    [NativeTypeName("unsigned int")]
    public uint ai_servertype;
    /// <include file='ADDRINFO_DNS_SERVER.xml' path='doc/member[@name="ADDRINFO_DNS_SERVER.ai_flags"]/*'/>
    [NativeTypeName("unsigned long long")]
    public ulong ai_flags;
    /// <include file='ADDRINFO_DNS_SERVER.xml' path='doc/member[@name="ADDRINFO_DNS_SERVER.ai_addrlen"]/*'/>
    [NativeTypeName("unsigned int")]
    public uint ai_addrlen;
    /// <include file='ADDRINFO_DNS_SERVER.xml' path='doc/member[@name="ADDRINFO_DNS_SERVER.ai_addr"]/*'/>
    [NativeTypeName("struct sockaddr *")]
    public SOCKADDR* ai_addr;
    /// <include file='ADDRINFO_DNS_SERVER.xml' path='doc/member[@name="ADDRINFO_DNS_SERVER.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_ws2def_L1101_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ai_template"]/*'/>
    [UnscopedRef]
    public ref ushort* ai_template
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ai_template;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ai_template"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PWSTR")]
        public ushort* ai_template;
    }
}