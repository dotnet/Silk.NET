// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_SVG_ATTRIBUTE_STRING_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_STRING_TYPE"]/*'/>
public enum D2D1_SVG_ATTRIBUTE_STRING_TYPE
{
    /// <include file='D2D1_SVG_ATTRIBUTE_STRING_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_STRING_TYPE.D2D1_SVG_ATTRIBUTE_STRING_TYPE_SVG"]/*'/>
    D2D1_SVG_ATTRIBUTE_STRING_TYPE_SVG = 0,
    /// <include file='D2D1_SVG_ATTRIBUTE_STRING_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_STRING_TYPE.D2D1_SVG_ATTRIBUTE_STRING_TYPE_ID"]/*'/>
    D2D1_SVG_ATTRIBUTE_STRING_TYPE_ID = 1,
    /// <include file='D2D1_SVG_ATTRIBUTE_STRING_TYPE.xml' path='doc/member[@name="D2D1_SVG_ATTRIBUTE_STRING_TYPE.D2D1_SVG_ATTRIBUTE_STRING_TYPE_FORCE_DWORD"]/*'/>
    D2D1_SVG_ATTRIBUTE_STRING_TYPE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}