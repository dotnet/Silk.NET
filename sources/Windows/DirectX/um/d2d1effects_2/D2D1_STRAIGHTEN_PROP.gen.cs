// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_STRAIGHTEN_PROP.xml' path='doc/member[@name="D2D1_STRAIGHTEN_PROP"]/*'/>
public enum D2D1_STRAIGHTEN_PROP
{
    /// <include file='D2D1_STRAIGHTEN_PROP.xml' path='doc/member[@name="D2D1_STRAIGHTEN_PROP.D2D1_STRAIGHTEN_PROP_ANGLE"]/*'/>
    D2D1_STRAIGHTEN_PROP_ANGLE = 0,
    /// <include file='D2D1_STRAIGHTEN_PROP.xml' path='doc/member[@name="D2D1_STRAIGHTEN_PROP.D2D1_STRAIGHTEN_PROP_MAINTAIN_SIZE"]/*'/>
    D2D1_STRAIGHTEN_PROP_MAINTAIN_SIZE = 1,
    /// <include file='D2D1_STRAIGHTEN_PROP.xml' path='doc/member[@name="D2D1_STRAIGHTEN_PROP.D2D1_STRAIGHTEN_PROP_SCALE_MODE"]/*'/>
    D2D1_STRAIGHTEN_PROP_SCALE_MODE = 2,
    /// <include file='D2D1_STRAIGHTEN_PROP.xml' path='doc/member[@name="D2D1_STRAIGHTEN_PROP.D2D1_STRAIGHTEN_PROP_FORCE_DWORD"]/*'/>
    D2D1_STRAIGHTEN_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}