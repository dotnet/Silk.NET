// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SSL_CREDENTIAL_CERTIFICATE
{
    [NativeTypeName("DWORD")]
    public uint cbPrivateKey;

    [NativeTypeName("PBYTE")]
    public byte* pPrivateKey;

    [NativeTypeName("DWORD")]
    public uint cbCertificate;

    [NativeTypeName("PBYTE")]
    public byte* pCertificate;

    [NativeTypeName("PSTR")]
    public sbyte* pszPassword;
}
