// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_JPEG_QUANTIZATION_TABLE.xml' path='doc/member[@name="DXGI_JPEG_QUANTIZATION_TABLE"]/*'/>
public unsafe partial struct DXGI_JPEG_QUANTIZATION_TABLE
{
    /// <include file='DXGI_JPEG_QUANTIZATION_TABLE.xml' path='doc/member[@name="DXGI_JPEG_QUANTIZATION_TABLE.Elements"]/*'/>
    [NativeTypeName("BYTE[64]")]
    public fixed byte Elements[64];
}