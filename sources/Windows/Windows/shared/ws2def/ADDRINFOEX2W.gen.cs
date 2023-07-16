// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ADDRINFOEX2W
{
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_flags"]/*'/>
    public int ai_flags;
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_family"]/*'/>
    public int ai_family;
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_socktype"]/*'/>
    public int ai_socktype;
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_protocol"]/*'/>
    public int ai_protocol;
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_addrlen"]/*'/>
    [NativeTypeName("size_t")]
    public nuint ai_addrlen;
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_canonname"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* ai_canonname;
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_addr"]/*'/>
    [NativeTypeName("struct sockaddr *")]
    public SOCKADDR* ai_addr;
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_blob"]/*'/>
    public void* ai_blob;
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_bloblen"]/*'/>
    [NativeTypeName("size_t")]
    public nuint ai_bloblen;
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_provider"]/*'/>
    [NativeTypeName("LPGUID")]
    public Guid* ai_provider;
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_next"]/*'/>
    [NativeTypeName("struct addrinfoex2W *")]
    public ADDRINFOEX2W* ai_next;
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_version"]/*'/>
    public int ai_version;
    /// <include file='ADDRINFOEX2W.xml' path='doc/member[@name="ADDRINFOEX2W.ai_fqdn"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* ai_fqdn;
}