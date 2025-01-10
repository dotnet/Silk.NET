// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct ADDRINFOEX5
{
    public int ai_flags;
    public int ai_family;
    public int ai_socktype;
    public int ai_protocol;

    [NativeTypeName("size_t")]
    public nuint ai_addrlen;

    [NativeTypeName("PWSTR")]
    public ushort* ai_canonname;

    [NativeTypeName("struct sockaddr *")]
    public SOCKADDR* ai_addr;
    public void* ai_blob;

    [NativeTypeName("size_t")]
    public nuint ai_bloblen;
    public Guid* ai_provider;

    [NativeTypeName("struct addrinfoex5 *")]
    public ADDRINFOEX5* ai_next;
    public int ai_version;

    [NativeTypeName("PWSTR")]
    public ushort* ai_fqdn;
    public int ai_interfaceindex;
    public HANDLE ai_resolutionhandle;

    [NativeTypeName("unsigned int")]
    public uint ai_ttl;
}
