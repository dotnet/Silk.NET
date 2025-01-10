// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D10_EFFECT_SHADER_DESC
{
    [NativeTypeName("const BYTE *")]
    public byte* pInputSignature;
    public BOOL IsInline;

    [NativeTypeName("const BYTE *")]
    public byte* pBytecode;
    public uint BytecodeLength;

    [NativeTypeName("LPCSTR")]
    public sbyte* SODecl;
    public uint NumInputSignatureEntries;
    public uint NumOutputSignatureEntries;
}
