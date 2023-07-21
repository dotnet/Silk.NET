// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='styleTransformStyle.xml' path='doc/member[@name="styleTransformStyle"]/*' />
public enum styleTransformStyle
{
    /// <include file='styleTransformStyle.xml' path='doc/member[@name="styleTransformStyle.styleTransformStyleFlat"]/*' />
    styleTransformStyleFlat = 0,

    /// <include file='styleTransformStyle.xml' path='doc/member[@name="styleTransformStyle.styleTransformStylePreserve3D"]/*' />
    styleTransformStylePreserve3D = 1,

    /// <include file='styleTransformStyle.xml' path='doc/member[@name="styleTransformStyle.styleTransformStyleNotSet"]/*' />
    styleTransformStyleNotSet = 2,

    /// <include file='styleTransformStyle.xml' path='doc/member[@name="styleTransformStyle.styleTransformStyle_Max"]/*' />
    styleTransformStyle_Max = 2147483647,
}
