// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='styleBackfaceVisibility.xml' path='doc/member[@name="styleBackfaceVisibility"]/*' />
public enum styleBackfaceVisibility
{
    /// <include file='styleBackfaceVisibility.xml' path='doc/member[@name="styleBackfaceVisibility.styleBackfaceVisibilityVisible"]/*' />
    styleBackfaceVisibilityVisible = 0,

    /// <include file='styleBackfaceVisibility.xml' path='doc/member[@name="styleBackfaceVisibility.styleBackfaceVisibilityHidden"]/*' />
    styleBackfaceVisibilityHidden = 1,

    /// <include file='styleBackfaceVisibility.xml' path='doc/member[@name="styleBackfaceVisibility.styleBackfaceVisibilityNotSet"]/*' />
    styleBackfaceVisibilityNotSet = 2,

    /// <include file='styleBackfaceVisibility.xml' path='doc/member[@name="styleBackfaceVisibility.styleBackfaceVisibility_Max"]/*' />
    styleBackfaceVisibility_Max = 2147483647,
}
