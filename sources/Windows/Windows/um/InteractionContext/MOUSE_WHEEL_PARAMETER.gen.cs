// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MOUSE_WHEEL_PARAMETER.xml' path='doc/member[@name="MOUSE_WHEEL_PARAMETER"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum MOUSE_WHEEL_PARAMETER
{
    /// <include file='MOUSE_WHEEL_PARAMETER.xml' path='doc/member[@name="MOUSE_WHEEL_PARAMETER.MOUSE_WHEEL_PARAMETER_CHAR_TRANSLATION_X"]/*' />
    MOUSE_WHEEL_PARAMETER_CHAR_TRANSLATION_X = 0x00000001,

    /// <include file='MOUSE_WHEEL_PARAMETER.xml' path='doc/member[@name="MOUSE_WHEEL_PARAMETER.MOUSE_WHEEL_PARAMETER_CHAR_TRANSLATION_Y"]/*' />
    MOUSE_WHEEL_PARAMETER_CHAR_TRANSLATION_Y = 0x00000002,

    /// <include file='MOUSE_WHEEL_PARAMETER.xml' path='doc/member[@name="MOUSE_WHEEL_PARAMETER.MOUSE_WHEEL_PARAMETER_DELTA_SCALE"]/*' />
    MOUSE_WHEEL_PARAMETER_DELTA_SCALE = 0x00000003,

    /// <include file='MOUSE_WHEEL_PARAMETER.xml' path='doc/member[@name="MOUSE_WHEEL_PARAMETER.MOUSE_WHEEL_PARAMETER_DELTA_ROTATION"]/*' />
    MOUSE_WHEEL_PARAMETER_DELTA_ROTATION = 0x00000004,

    /// <include file='MOUSE_WHEEL_PARAMETER.xml' path='doc/member[@name="MOUSE_WHEEL_PARAMETER.MOUSE_WHEEL_PARAMETER_PAGE_TRANSLATION_X"]/*' />
    MOUSE_WHEEL_PARAMETER_PAGE_TRANSLATION_X = 0x00000005,

    /// <include file='MOUSE_WHEEL_PARAMETER.xml' path='doc/member[@name="MOUSE_WHEEL_PARAMETER.MOUSE_WHEEL_PARAMETER_PAGE_TRANSLATION_Y"]/*' />
    MOUSE_WHEEL_PARAMETER_PAGE_TRANSLATION_Y = 0x00000006,

    /// <include file='MOUSE_WHEEL_PARAMETER.xml' path='doc/member[@name="MOUSE_WHEEL_PARAMETER.MOUSE_WHEEL_PARAMETER_MAX"]/*' />
    MOUSE_WHEEL_PARAMETER_MAX = unchecked((int)(0xffffffff)),
}
