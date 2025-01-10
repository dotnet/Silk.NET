// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct HTTP_SERVICE_CONFIG_SSL_PARAM
{
    [NativeTypeName("ULONG")]
    public uint SslHashLength;

    [NativeTypeName("PVOID")]
    public void* pSslHash;
    public Guid AppId;

    [NativeTypeName("PWSTR")]
    public ushort* pSslCertStoreName;

    [NativeTypeName("DWORD")]
    public uint DefaultCertCheckMode;

    [NativeTypeName("DWORD")]
    public uint DefaultRevocationFreshnessTime;

    [NativeTypeName("DWORD")]
    public uint DefaultRevocationUrlRetrievalTimeout;

    [NativeTypeName("PWSTR")]
    public ushort* pDefaultSslCtlIdentifier;

    [NativeTypeName("PWSTR")]
    public ushort* pDefaultSslCtlStoreName;

    [NativeTypeName("DWORD")]
    public uint DefaultFlags;
}
