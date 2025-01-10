// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
[Obsolete("ADDRINFOEX2W")]
public unsafe partial struct ADDRINFOEX2A
{
    public int ai_flags;
    public int ai_family;
    public int ai_socktype;
    public int ai_protocol;

    [NativeTypeName("size_t")]
    public nuint ai_addrlen;

    [NativeTypeName("char *")]
    public sbyte* ai_canonname;

    [NativeTypeName("struct sockaddr *")]
    public SOCKADDR* ai_addr;
    public void* ai_blob;

    [NativeTypeName("size_t")]
    public nuint ai_bloblen;

    [NativeTypeName("LPGUID")]
    public Guid* ai_provider;

    [NativeTypeName("struct addrinfoex2A *")]
    public ADDRINFOEX2A* ai_next;
    public int ai_version;

    [NativeTypeName("char *")]
    public sbyte* ai_fqdn;
}
