// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='ADDRINFOEXA.xml' path='doc/member[@name="ADDRINFOEXA"]/*'/>
[Obsolete("ADDRINFOEXW")]
public unsafe partial struct ADDRINFOEXA
{
    /// <include file='ADDRINFOEXA.xml' path='doc/member[@name="ADDRINFOEXA.ai_flags"]/*'/>
    public int ai_flags;
    /// <include file='ADDRINFOEXA.xml' path='doc/member[@name="ADDRINFOEXA.ai_family"]/*'/>
    public int ai_family;
    /// <include file='ADDRINFOEXA.xml' path='doc/member[@name="ADDRINFOEXA.ai_socktype"]/*'/>
    public int ai_socktype;
    /// <include file='ADDRINFOEXA.xml' path='doc/member[@name="ADDRINFOEXA.ai_protocol"]/*'/>
    public int ai_protocol;
    /// <include file='ADDRINFOEXA.xml' path='doc/member[@name="ADDRINFOEXA.ai_addrlen"]/*'/>
    [NativeTypeName("size_t")]
    public nuint ai_addrlen;
    /// <include file='ADDRINFOEXA.xml' path='doc/member[@name="ADDRINFOEXA.ai_canonname"]/*'/>
    [NativeTypeName("char *")]
    public sbyte* ai_canonname;
    /// <include file='ADDRINFOEXA.xml' path='doc/member[@name="ADDRINFOEXA.ai_addr"]/*'/>
    [NativeTypeName("struct sockaddr *")]
    public SOCKADDR* ai_addr;
    /// <include file='ADDRINFOEXA.xml' path='doc/member[@name="ADDRINFOEXA.ai_blob"]/*'/>
    public void* ai_blob;
    /// <include file='ADDRINFOEXA.xml' path='doc/member[@name="ADDRINFOEXA.ai_bloblen"]/*'/>
    [NativeTypeName("size_t")]
    public nuint ai_bloblen;
    /// <include file='ADDRINFOEXA.xml' path='doc/member[@name="ADDRINFOEXA.ai_provider"]/*'/>
    [NativeTypeName("LPGUID")]
    public Guid* ai_provider;
    /// <include file='ADDRINFOEXA.xml' path='doc/member[@name="ADDRINFOEXA.ai_next"]/*'/>
    [NativeTypeName("struct addrinfoexA *")]
    public ADDRINFOEXA* ai_next;
}