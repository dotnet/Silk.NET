// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Gdiplus;
/// <include file='ObjectType.xml' path='doc/member[@name="ObjectType"]/*'/>
public enum ObjectType
{
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypeInvalid"]/*'/>
    ObjectTypeInvalid,
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypeBrush"]/*'/>
    ObjectTypeBrush,
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypePen"]/*'/>
    ObjectTypePen,
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypePath"]/*'/>
    ObjectTypePath,
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypeRegion"]/*'/>
    ObjectTypeRegion,
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypeImage"]/*'/>
    ObjectTypeImage,
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypeFont"]/*'/>
    ObjectTypeFont,
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypeStringFormat"]/*'/>
    ObjectTypeStringFormat,
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypeImageAttributes"]/*'/>
    ObjectTypeImageAttributes,
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypeCustomLineCap"]/*'/>
    ObjectTypeCustomLineCap,
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypeGraphics"]/*'/>
    ObjectTypeGraphics,
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypeMax"]/*'/>
    ObjectTypeMax = ObjectTypeGraphics,
    /// <include file='ObjectType.xml' path='doc/member[@name="ObjectType.ObjectTypeMin"]/*'/>
    ObjectTypeMin = ObjectTypeBrush,
}