// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='htmlEndPoints.xml' path='doc/member[@name="htmlEndPoints"]/*' />
public enum htmlEndPoints
{
    /// <include file='htmlEndPoints.xml' path='doc/member[@name="htmlEndPoints.htmlEndPointsStartToStart"]/*' />
    htmlEndPointsStartToStart = 1,

    /// <include file='htmlEndPoints.xml' path='doc/member[@name="htmlEndPoints.htmlEndPointsStartToEnd"]/*' />
    htmlEndPointsStartToEnd = 2,

    /// <include file='htmlEndPoints.xml' path='doc/member[@name="htmlEndPoints.htmlEndPointsEndToStart"]/*' />
    htmlEndPointsEndToStart = 3,

    /// <include file='htmlEndPoints.xml' path='doc/member[@name="htmlEndPoints.htmlEndPointsEndToEnd"]/*' />
    htmlEndPointsEndToEnd = 4,

    /// <include file='htmlEndPoints.xml' path='doc/member[@name="htmlEndPoints.htmlEndPoints_Max"]/*' />
    htmlEndPoints_Max = 2147483647,
}
