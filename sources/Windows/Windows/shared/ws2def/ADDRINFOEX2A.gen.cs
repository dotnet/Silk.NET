// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A"]/*'/>
[SupportedOSPlatform("windows6.2")]
[Obsolete("ADDRINFOEX2W")]
public unsafe partial struct ADDRINFOEX2A
{
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_flags"]/*'/>
    public int ai_flags;
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_family"]/*'/>
    public int ai_family;
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_socktype"]/*'/>
    public int ai_socktype;
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_protocol"]/*'/>
    public int ai_protocol;
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_addrlen"]/*'/>
    [NativeTypeName("size_t")]
    public nuint ai_addrlen;
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_canonname"]/*'/>
    [NativeTypeName("char *")]
    public sbyte* ai_canonname;
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_addr"]/*'/>
    [NativeTypeName("struct sockaddr *")]
    public SOCKADDR* ai_addr;
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_blob"]/*'/>
    public void* ai_blob;
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_bloblen"]/*'/>
    [NativeTypeName("size_t")]
    public nuint ai_bloblen;
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_provider"]/*'/>
    [NativeTypeName("LPGUID")]
    public Guid* ai_provider;
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_next"]/*'/>
    [NativeTypeName("struct addrinfoex2A *")]
    public ADDRINFOEX2A* ai_next;
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_version"]/*'/>
    public int ai_version;
    /// <include file='ADDRINFOEX2A.xml' path='doc/member[@name="ADDRINFOEX2A.ai_fqdn"]/*'/>
    [NativeTypeName("char *")]
    public sbyte* ai_fqdn;
}