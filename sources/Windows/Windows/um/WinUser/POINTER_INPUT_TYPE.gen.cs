// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='POINTER_INPUT_TYPE.xml' path='doc/member[@name="POINTER_INPUT_TYPE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum POINTER_INPUT_TYPE
{
    /// <include file='POINTER_INPUT_TYPE.xml' path='doc/member[@name="POINTER_INPUT_TYPE.PT_POINTER"]/*' />
    PT_POINTER = 1,

    /// <include file='POINTER_INPUT_TYPE.xml' path='doc/member[@name="POINTER_INPUT_TYPE.PT_TOUCH"]/*' />
    PT_TOUCH = 2,

    /// <include file='POINTER_INPUT_TYPE.xml' path='doc/member[@name="POINTER_INPUT_TYPE.PT_PEN"]/*' />
    PT_PEN = 3,

    /// <include file='POINTER_INPUT_TYPE.xml' path='doc/member[@name="POINTER_INPUT_TYPE.PT_MOUSE"]/*' />
    PT_MOUSE = 4,

    /// <include file='POINTER_INPUT_TYPE.xml' path='doc/member[@name="POINTER_INPUT_TYPE.PT_TOUCHPAD"]/*' />
    PT_TOUCHPAD = 5,
}
