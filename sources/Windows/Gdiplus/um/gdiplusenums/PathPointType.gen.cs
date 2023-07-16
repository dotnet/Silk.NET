// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Gdiplus;
/// <include file='PathPointType.xml' path='doc/member[@name="PathPointType"]/*'/>
public enum PathPointType
{
    /// <include file='PathPointType.xml' path='doc/member[@name="PathPointType.PathPointTypeStart"]/*'/>
    PathPointTypeStart = 0,
    /// <include file='PathPointType.xml' path='doc/member[@name="PathPointType.PathPointTypeLine"]/*'/>
    PathPointTypeLine = 1,
    /// <include file='PathPointType.xml' path='doc/member[@name="PathPointType.PathPointTypeBezier"]/*'/>
    PathPointTypeBezier = 3,
    /// <include file='PathPointType.xml' path='doc/member[@name="PathPointType.PathPointTypePathTypeMask"]/*'/>
    PathPointTypePathTypeMask = 0x07,
    /// <include file='PathPointType.xml' path='doc/member[@name="PathPointType.PathPointTypeDashMode"]/*'/>
    PathPointTypeDashMode = 0x10,
    /// <include file='PathPointType.xml' path='doc/member[@name="PathPointType.PathPointTypePathMarker"]/*'/>
    PathPointTypePathMarker = 0x20,
    /// <include file='PathPointType.xml' path='doc/member[@name="PathPointType.PathPointTypeCloseSubpath"]/*'/>
    PathPointTypeCloseSubpath = 0x80,
    /// <include file='PathPointType.xml' path='doc/member[@name="PathPointType.PathPointTypeBezier3"]/*'/>
    PathPointTypeBezier3 = 3,
}