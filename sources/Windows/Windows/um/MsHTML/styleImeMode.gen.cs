// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='styleImeMode.xml' path='doc/member[@name="styleImeMode"]/*' />
public enum styleImeMode
{
    /// <include file='styleImeMode.xml' path='doc/member[@name="styleImeMode.styleImeModeAuto"]/*' />
    styleImeModeAuto = 0,

    /// <include file='styleImeMode.xml' path='doc/member[@name="styleImeMode.styleImeModeActive"]/*' />
    styleImeModeActive = 1,

    /// <include file='styleImeMode.xml' path='doc/member[@name="styleImeMode.styleImeModeInactive"]/*' />
    styleImeModeInactive = 2,

    /// <include file='styleImeMode.xml' path='doc/member[@name="styleImeMode.styleImeModeDisabled"]/*' />
    styleImeModeDisabled = 3,

    /// <include file='styleImeMode.xml' path='doc/member[@name="styleImeMode.styleImeModeNotSet"]/*' />
    styleImeModeNotSet = 4,

    /// <include file='styleImeMode.xml' path='doc/member[@name="styleImeMode.styleImeMode_Max"]/*' />
    styleImeMode_Max = 2147483647,
}
