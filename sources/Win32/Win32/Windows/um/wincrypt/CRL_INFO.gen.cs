// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRL_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

    [NativeTypeName("CERT_NAME_BLOB")]
    public CRYPT_DATA_BLOB Issuer;
    public FILETIME ThisUpdate;
    public FILETIME NextUpdate;

    [NativeTypeName("DWORD")]
    public uint cCRLEntry;

    [NativeTypeName("PCRL_ENTRY")]
    public CRL_ENTRY* rgCRLEntry;

    [NativeTypeName("DWORD")]
    public uint cExtension;

    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}
