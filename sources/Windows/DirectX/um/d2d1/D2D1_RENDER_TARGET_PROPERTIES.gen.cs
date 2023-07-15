// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_RENDER_TARGET_PROPERTIES.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES"]/*'/>
public partial struct D2D1_RENDER_TARGET_PROPERTIES
{
    /// <include file='D2D1_RENDER_TARGET_PROPERTIES.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES.type"]/*'/>
    public D2D1_RENDER_TARGET_TYPE type;
    /// <include file='D2D1_RENDER_TARGET_PROPERTIES.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES.pixelFormat"]/*'/>
    public D2D1_PIXEL_FORMAT pixelFormat;
    /// <include file='D2D1_RENDER_TARGET_PROPERTIES.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES.dpiX"]/*'/>
    public float dpiX;
    /// <include file='D2D1_RENDER_TARGET_PROPERTIES.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES.dpiY"]/*'/>
    public float dpiY;
    /// <include file='D2D1_RENDER_TARGET_PROPERTIES.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES.usage"]/*'/>
    public D2D1_RENDER_TARGET_USAGE usage;
    /// <include file='D2D1_RENDER_TARGET_PROPERTIES.xml' path='doc/member[@name="D2D1_RENDER_TARGET_PROPERTIES.minLevel"]/*'/>
    public D2D1_FEATURE_LEVEL minLevel;
}