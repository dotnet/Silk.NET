// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum FEEDBACK_TYPE
{
    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_TOUCH_CONTACTVISUALIZATION"]/*' />
    FEEDBACK_TOUCH_CONTACTVISUALIZATION = 1,

    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_PEN_BARRELVISUALIZATION"]/*' />
    FEEDBACK_PEN_BARRELVISUALIZATION = 2,

    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_PEN_TAP"]/*' />
    FEEDBACK_PEN_TAP = 3,

    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_PEN_DOUBLETAP"]/*' />
    FEEDBACK_PEN_DOUBLETAP = 4,

    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_PEN_PRESSANDHOLD"]/*' />
    FEEDBACK_PEN_PRESSANDHOLD = 5,

    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_PEN_RIGHTTAP"]/*' />
    FEEDBACK_PEN_RIGHTTAP = 6,

    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_TOUCH_TAP"]/*' />
    FEEDBACK_TOUCH_TAP = 7,

    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_TOUCH_DOUBLETAP"]/*' />
    FEEDBACK_TOUCH_DOUBLETAP = 8,

    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_TOUCH_PRESSANDHOLD"]/*' />
    FEEDBACK_TOUCH_PRESSANDHOLD = 9,

    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_TOUCH_RIGHTTAP"]/*' />
    FEEDBACK_TOUCH_RIGHTTAP = 10,

    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_GESTURE_PRESSANDTAP"]/*' />
    FEEDBACK_GESTURE_PRESSANDTAP = 11,

    /// <include file='FEEDBACK_TYPE.xml' path='doc/member[@name="FEEDBACK_TYPE.FEEDBACK_MAX"]/*' />
    FEEDBACK_MAX = unchecked((int)(0xFFFFFFFF)),
}
