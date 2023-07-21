// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='styleInitialColor.xml' path='doc/member[@name="styleInitialColor"]/*' />
public enum styleInitialColor
{
    /// <include file='styleInitialColor.xml' path='doc/member[@name="styleInitialColor.styleInitialColorNoInitial"]/*' />
    styleInitialColorNoInitial = 0,

    /// <include file='styleInitialColor.xml' path='doc/member[@name="styleInitialColor.styleInitialColorColorProperty"]/*' />
    styleInitialColorColorProperty = 1,

    /// <include file='styleInitialColor.xml' path='doc/member[@name="styleInitialColor.styleInitialColorTransparent"]/*' />
    styleInitialColorTransparent = 2,

    /// <include file='styleInitialColor.xml' path='doc/member[@name="styleInitialColor.styleInitialColorInvert"]/*' />
    styleInitialColorInvert = 3,

    /// <include file='styleInitialColor.xml' path='doc/member[@name="styleInitialColor.styleInitialColor_Max"]/*' />
    styleInitialColor_Max = 2147483647,
}
