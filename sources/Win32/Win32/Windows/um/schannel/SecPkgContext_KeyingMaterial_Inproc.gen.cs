// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SecPkgContext_KeyingMaterial_Inproc
{
    [NativeTypeName("WORD")]
    public ushort cbLabel;

    [NativeTypeName("LPSTR")]
    public sbyte* pszLabel;

    [NativeTypeName("WORD")]
    public ushort cbContextValue;

    [NativeTypeName("PBYTE")]
    public byte* pbContextValue;

    [NativeTypeName("DWORD")]
    public uint cbKeyingMaterial;

    [NativeTypeName("PBYTE")]
    public byte* pbKeyingMaterial;
}
