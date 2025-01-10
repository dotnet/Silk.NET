// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CERT_CHAIN_FIND_BY_ISSUER_PARA
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("LPCSTR")]
    public sbyte* pszUsageIdentifier;

    [NativeTypeName("DWORD")]
    public uint dwKeySpec;

    [NativeTypeName("DWORD")]
    public uint dwAcquirePrivateKeyFlags;

    [NativeTypeName("DWORD")]
    public uint cIssuer;

    [NativeTypeName("CERT_NAME_BLOB *")]
    public CRYPT_DATA_BLOB* rgIssuer;

    [NativeTypeName("PFN_CERT_CHAIN_FIND_BY_ISSUER_CALLBACK")]
    public delegate* unmanaged<CERT_CONTEXT*, void*, BOOL> pfnFindCallback;
    public void* pvFindArg;
}
