// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_BITMAPSOURCE_PROP.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_PROP"]/*'/>
public enum D2D1_BITMAPSOURCE_PROP
{
    /// <include file='D2D1_BITMAPSOURCE_PROP.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_PROP.D2D1_BITMAPSOURCE_PROP_WIC_BITMAP_SOURCE"]/*'/>
    D2D1_BITMAPSOURCE_PROP_WIC_BITMAP_SOURCE = 0,
    /// <include file='D2D1_BITMAPSOURCE_PROP.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_PROP.D2D1_BITMAPSOURCE_PROP_SCALE"]/*'/>
    D2D1_BITMAPSOURCE_PROP_SCALE = 1,
    /// <include file='D2D1_BITMAPSOURCE_PROP.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_PROP.D2D1_BITMAPSOURCE_PROP_INTERPOLATION_MODE"]/*'/>
    D2D1_BITMAPSOURCE_PROP_INTERPOLATION_MODE = 2,
    /// <include file='D2D1_BITMAPSOURCE_PROP.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_PROP.D2D1_BITMAPSOURCE_PROP_ENABLE_DPI_CORRECTION"]/*'/>
    D2D1_BITMAPSOURCE_PROP_ENABLE_DPI_CORRECTION = 3,
    /// <include file='D2D1_BITMAPSOURCE_PROP.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_PROP.D2D1_BITMAPSOURCE_PROP_ALPHA_MODE"]/*'/>
    D2D1_BITMAPSOURCE_PROP_ALPHA_MODE = 4,
    /// <include file='D2D1_BITMAPSOURCE_PROP.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_PROP.D2D1_BITMAPSOURCE_PROP_ORIENTATION"]/*'/>
    D2D1_BITMAPSOURCE_PROP_ORIENTATION = 5,
    /// <include file='D2D1_BITMAPSOURCE_PROP.xml' path='doc/member[@name="D2D1_BITMAPSOURCE_PROP.D2D1_BITMAPSOURCE_PROP_FORCE_DWORD"]/*'/>
    D2D1_BITMAPSOURCE_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}