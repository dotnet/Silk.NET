// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_KEY_PROV_INFO
{
    [NativeTypeName("LPWSTR")]
    public ushort* pwszContainerName;

    [NativeTypeName("LPWSTR")]
    public ushort* pwszProvName;

    [NativeTypeName("DWORD")]
    public uint dwProvType;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint cProvParam;

    [NativeTypeName("PCRYPT_KEY_PROV_PARAM")]
    public CRYPT_KEY_PROV_PARAM* rgProvParam;

    [NativeTypeName("DWORD")]
    public uint dwKeySpec;
}
