// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_GAUSSIANBLUR_PROP.xml' path='doc/member[@name="D2D1_GAUSSIANBLUR_PROP"]/*'/>
public enum D2D1_GAUSSIANBLUR_PROP
{
    /// <include file='D2D1_GAUSSIANBLUR_PROP.xml' path='doc/member[@name="D2D1_GAUSSIANBLUR_PROP.D2D1_GAUSSIANBLUR_PROP_STANDARD_DEVIATION"]/*'/>
    D2D1_GAUSSIANBLUR_PROP_STANDARD_DEVIATION = 0,
    /// <include file='D2D1_GAUSSIANBLUR_PROP.xml' path='doc/member[@name="D2D1_GAUSSIANBLUR_PROP.D2D1_GAUSSIANBLUR_PROP_OPTIMIZATION"]/*'/>
    D2D1_GAUSSIANBLUR_PROP_OPTIMIZATION = 1,
    /// <include file='D2D1_GAUSSIANBLUR_PROP.xml' path='doc/member[@name="D2D1_GAUSSIANBLUR_PROP.D2D1_GAUSSIANBLUR_PROP_BORDER_MODE"]/*'/>
    D2D1_GAUSSIANBLUR_PROP_BORDER_MODE = 2,
    /// <include file='D2D1_GAUSSIANBLUR_PROP.xml' path='doc/member[@name="D2D1_GAUSSIANBLUR_PROP.D2D1_GAUSSIANBLUR_PROP_FORCE_DWORD"]/*'/>
    D2D1_GAUSSIANBLUR_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}