// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_SUBPROPERTY.xml' path='doc/member[@name="D2D1_SUBPROPERTY"]/*'/>
public enum D2D1_SUBPROPERTY
{
    /// <include file='D2D1_SUBPROPERTY.xml' path='doc/member[@name="D2D1_SUBPROPERTY.D2D1_SUBPROPERTY_DISPLAYNAME"]/*'/>
    D2D1_SUBPROPERTY_DISPLAYNAME = unchecked((int)(0x80000000)),
    /// <include file='D2D1_SUBPROPERTY.xml' path='doc/member[@name="D2D1_SUBPROPERTY.D2D1_SUBPROPERTY_ISREADONLY"]/*'/>
    D2D1_SUBPROPERTY_ISREADONLY = unchecked((int)(0x80000001)),
    /// <include file='D2D1_SUBPROPERTY.xml' path='doc/member[@name="D2D1_SUBPROPERTY.D2D1_SUBPROPERTY_MIN"]/*'/>
    D2D1_SUBPROPERTY_MIN = unchecked((int)(0x80000002)),
    /// <include file='D2D1_SUBPROPERTY.xml' path='doc/member[@name="D2D1_SUBPROPERTY.D2D1_SUBPROPERTY_MAX"]/*'/>
    D2D1_SUBPROPERTY_MAX = unchecked((int)(0x80000003)),
    /// <include file='D2D1_SUBPROPERTY.xml' path='doc/member[@name="D2D1_SUBPROPERTY.D2D1_SUBPROPERTY_DEFAULT"]/*'/>
    D2D1_SUBPROPERTY_DEFAULT = unchecked((int)(0x80000004)),
    /// <include file='D2D1_SUBPROPERTY.xml' path='doc/member[@name="D2D1_SUBPROPERTY.D2D1_SUBPROPERTY_FIELDS"]/*'/>
    D2D1_SUBPROPERTY_FIELDS = unchecked((int)(0x80000005)),
    /// <include file='D2D1_SUBPROPERTY.xml' path='doc/member[@name="D2D1_SUBPROPERTY.D2D1_SUBPROPERTY_INDEX"]/*'/>
    D2D1_SUBPROPERTY_INDEX = unchecked((int)(0x80000006)),
    /// <include file='D2D1_SUBPROPERTY.xml' path='doc/member[@name="D2D1_SUBPROPERTY.D2D1_SUBPROPERTY_FORCE_DWORD"]/*'/>
    D2D1_SUBPROPERTY_FORCE_DWORD = unchecked((int)(0xffffffff)),
}