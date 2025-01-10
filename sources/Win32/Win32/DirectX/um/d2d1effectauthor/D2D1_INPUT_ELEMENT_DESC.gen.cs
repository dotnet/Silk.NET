// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D2D1_INPUT_ELEMENT_DESC
{
    [NativeTypeName("PCSTR")]
    public sbyte* semanticName;

    [NativeTypeName("UINT32")]
    public uint semanticIndex;
    public DXGI_FORMAT format;

    [NativeTypeName("UINT32")]
    public uint inputSlot;

    [NativeTypeName("UINT32")]
    public uint alignedByteOffset;
}
