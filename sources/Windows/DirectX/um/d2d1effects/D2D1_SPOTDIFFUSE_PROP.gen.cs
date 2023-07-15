// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_SPOTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_SPOTDIFFUSE_PROP"]/*'/>
public enum D2D1_SPOTDIFFUSE_PROP
{
    /// <include file='D2D1_SPOTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_SPOTDIFFUSE_PROP.D2D1_SPOTDIFFUSE_PROP_LIGHT_POSITION"]/*'/>
    D2D1_SPOTDIFFUSE_PROP_LIGHT_POSITION = 0,
    /// <include file='D2D1_SPOTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_SPOTDIFFUSE_PROP.D2D1_SPOTDIFFUSE_PROP_POINTS_AT"]/*'/>
    D2D1_SPOTDIFFUSE_PROP_POINTS_AT = 1,
    /// <include file='D2D1_SPOTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_SPOTDIFFUSE_PROP.D2D1_SPOTDIFFUSE_PROP_FOCUS"]/*'/>
    D2D1_SPOTDIFFUSE_PROP_FOCUS = 2,
    /// <include file='D2D1_SPOTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_SPOTDIFFUSE_PROP.D2D1_SPOTDIFFUSE_PROP_LIMITING_CONE_ANGLE"]/*'/>
    D2D1_SPOTDIFFUSE_PROP_LIMITING_CONE_ANGLE = 3,
    /// <include file='D2D1_SPOTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_SPOTDIFFUSE_PROP.D2D1_SPOTDIFFUSE_PROP_DIFFUSE_CONSTANT"]/*'/>
    D2D1_SPOTDIFFUSE_PROP_DIFFUSE_CONSTANT = 4,
    /// <include file='D2D1_SPOTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_SPOTDIFFUSE_PROP.D2D1_SPOTDIFFUSE_PROP_SURFACE_SCALE"]/*'/>
    D2D1_SPOTDIFFUSE_PROP_SURFACE_SCALE = 5,
    /// <include file='D2D1_SPOTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_SPOTDIFFUSE_PROP.D2D1_SPOTDIFFUSE_PROP_COLOR"]/*'/>
    D2D1_SPOTDIFFUSE_PROP_COLOR = 6,
    /// <include file='D2D1_SPOTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_SPOTDIFFUSE_PROP.D2D1_SPOTDIFFUSE_PROP_KERNEL_UNIT_LENGTH"]/*'/>
    D2D1_SPOTDIFFUSE_PROP_KERNEL_UNIT_LENGTH = 7,
    /// <include file='D2D1_SPOTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_SPOTDIFFUSE_PROP.D2D1_SPOTDIFFUSE_PROP_SCALE_MODE"]/*'/>
    D2D1_SPOTDIFFUSE_PROP_SCALE_MODE = 8,
    /// <include file='D2D1_SPOTDIFFUSE_PROP.xml' path='doc/member[@name="D2D1_SPOTDIFFUSE_PROP.D2D1_SPOTDIFFUSE_PROP_FORCE_DWORD"]/*'/>
    D2D1_SPOTDIFFUSE_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}