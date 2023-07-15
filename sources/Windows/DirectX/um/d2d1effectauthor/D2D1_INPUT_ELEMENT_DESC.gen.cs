// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D2D1_INPUT_ELEMENT_DESC"]/*'/>
public unsafe partial struct D2D1_INPUT_ELEMENT_DESC
{
    /// <include file='D2D1_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D2D1_INPUT_ELEMENT_DESC.semanticName"]/*'/>
    [NativeTypeName("PCSTR")]
    public sbyte* semanticName;
    /// <include file='D2D1_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D2D1_INPUT_ELEMENT_DESC.semanticIndex"]/*'/>
    [NativeTypeName("UINT32")]
    public uint semanticIndex;
    /// <include file='D2D1_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D2D1_INPUT_ELEMENT_DESC.format"]/*'/>
    public DXGI_FORMAT format;
    /// <include file='D2D1_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D2D1_INPUT_ELEMENT_DESC.inputSlot"]/*'/>
    [NativeTypeName("UINT32")]
    public uint inputSlot;
    /// <include file='D2D1_INPUT_ELEMENT_DESC.xml' path='doc/member[@name="D2D1_INPUT_ELEMENT_DESC.alignedByteOffset"]/*'/>
    [NativeTypeName("UINT32")]
    public uint alignedByteOffset;
}