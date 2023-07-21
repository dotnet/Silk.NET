// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='styleUserZoom.xml' path='doc/member[@name="styleUserZoom"]/*' />
public enum styleUserZoom
{
    /// <include file='styleUserZoom.xml' path='doc/member[@name="styleUserZoom.styleUserZoomNotSet"]/*' />
    styleUserZoomNotSet = 0,

    /// <include file='styleUserZoom.xml' path='doc/member[@name="styleUserZoom.styleUserZoomZoom"]/*' />
    styleUserZoomZoom = 1,

    /// <include file='styleUserZoom.xml' path='doc/member[@name="styleUserZoom.styleUserZoomFixed"]/*' />
    styleUserZoomFixed = 2,

    /// <include file='styleUserZoom.xml' path='doc/member[@name="styleUserZoom.styleUserZoom_Max"]/*' />
    styleUserZoom_Max = 2147483647,
}
