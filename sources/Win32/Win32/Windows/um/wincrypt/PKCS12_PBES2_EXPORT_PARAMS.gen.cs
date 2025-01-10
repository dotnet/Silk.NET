// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PKCS12_PBES2_EXPORT_PARAMS
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("PVOID")]
    public void* hNcryptDescriptor;

    [NativeTypeName("LPWSTR")]
    public ushort* pwszPbes2Alg;
}
