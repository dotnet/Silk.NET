// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_SVG_UNIT_TYPE.xml' path='doc/member[@name="D2D1_SVG_UNIT_TYPE"]/*'/>
public enum D2D1_SVG_UNIT_TYPE
{
    /// <include file='D2D1_SVG_UNIT_TYPE.xml' path='doc/member[@name="D2D1_SVG_UNIT_TYPE.D2D1_SVG_UNIT_TYPE_USER_SPACE_ON_USE"]/*'/>
    D2D1_SVG_UNIT_TYPE_USER_SPACE_ON_USE = 0,
    /// <include file='D2D1_SVG_UNIT_TYPE.xml' path='doc/member[@name="D2D1_SVG_UNIT_TYPE.D2D1_SVG_UNIT_TYPE_OBJECT_BOUNDING_BOX"]/*'/>
    D2D1_SVG_UNIT_TYPE_OBJECT_BOUNDING_BOX = 1,
    /// <include file='D2D1_SVG_UNIT_TYPE.xml' path='doc/member[@name="D2D1_SVG_UNIT_TYPE.D2D1_SVG_UNIT_TYPE_FORCE_DWORD"]/*'/>
    D2D1_SVG_UNIT_TYPE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}