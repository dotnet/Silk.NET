// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='ADDRINFOEXW.xml' path='doc/member[@name="ADDRINFOEXW"]/*'/>
public unsafe partial struct ADDRINFOEXW
{
    /// <include file='ADDRINFOEXW.xml' path='doc/member[@name="ADDRINFOEXW.ai_flags"]/*'/>
    public int ai_flags;
    /// <include file='ADDRINFOEXW.xml' path='doc/member[@name="ADDRINFOEXW.ai_family"]/*'/>
    public int ai_family;
    /// <include file='ADDRINFOEXW.xml' path='doc/member[@name="ADDRINFOEXW.ai_socktype"]/*'/>
    public int ai_socktype;
    /// <include file='ADDRINFOEXW.xml' path='doc/member[@name="ADDRINFOEXW.ai_protocol"]/*'/>
    public int ai_protocol;
    /// <include file='ADDRINFOEXW.xml' path='doc/member[@name="ADDRINFOEXW.ai_addrlen"]/*'/>
    [NativeTypeName("size_t")]
    public nuint ai_addrlen;
    /// <include file='ADDRINFOEXW.xml' path='doc/member[@name="ADDRINFOEXW.ai_canonname"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* ai_canonname;
    /// <include file='ADDRINFOEXW.xml' path='doc/member[@name="ADDRINFOEXW.ai_addr"]/*'/>
    [NativeTypeName("struct sockaddr *")]
    public SOCKADDR* ai_addr;
    /// <include file='ADDRINFOEXW.xml' path='doc/member[@name="ADDRINFOEXW.ai_blob"]/*'/>
    public void* ai_blob;
    /// <include file='ADDRINFOEXW.xml' path='doc/member[@name="ADDRINFOEXW.ai_bloblen"]/*'/>
    [NativeTypeName("size_t")]
    public nuint ai_bloblen;
    /// <include file='ADDRINFOEXW.xml' path='doc/member[@name="ADDRINFOEXW.ai_provider"]/*'/>
    [NativeTypeName("LPGUID")]
    public Guid* ai_provider;
    /// <include file='ADDRINFOEXW.xml' path='doc/member[@name="ADDRINFOEXW.ai_next"]/*'/>
    [NativeTypeName("struct addrinfoexW *")]
    public ADDRINFOEXW* ai_next;
}