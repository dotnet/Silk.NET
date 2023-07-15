// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_PIXEL_FORMAT.xml' path='doc/member[@name="D2D1_PIXEL_FORMAT"]/*'/>
public partial struct D2D1_PIXEL_FORMAT
{
    /// <include file='D2D1_PIXEL_FORMAT.xml' path='doc/member[@name="D2D1_PIXEL_FORMAT.format"]/*'/>
    public DXGI_FORMAT format;
    /// <include file='D2D1_PIXEL_FORMAT.xml' path='doc/member[@name="D2D1_PIXEL_FORMAT.alphaMode"]/*'/>
    public D2D1_ALPHA_MODE alphaMode;
}