// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='GESTURE_TYPE.xml' path='doc/member[@name="GESTURE_TYPE"]/*'/>
public enum GESTURE_TYPE
{
    /// <include file='GESTURE_TYPE.xml' path='doc/member[@name="GESTURE_TYPE.GT_PEN_TAP"]/*'/>
    GT_PEN_TAP = 0,
    /// <include file='GESTURE_TYPE.xml' path='doc/member[@name="GESTURE_TYPE.GT_PEN_DOUBLETAP"]/*'/>
    GT_PEN_DOUBLETAP = 1,
    /// <include file='GESTURE_TYPE.xml' path='doc/member[@name="GESTURE_TYPE.GT_PEN_RIGHTTAP"]/*'/>
    GT_PEN_RIGHTTAP = 2,
    /// <include file='GESTURE_TYPE.xml' path='doc/member[@name="GESTURE_TYPE.GT_PEN_PRESSANDHOLD"]/*'/>
    GT_PEN_PRESSANDHOLD = 3,
    /// <include file='GESTURE_TYPE.xml' path='doc/member[@name="GESTURE_TYPE.GT_PEN_PRESSANDHOLDABORT"]/*'/>
    GT_PEN_PRESSANDHOLDABORT = 4,
    /// <include file='GESTURE_TYPE.xml' path='doc/member[@name="GESTURE_TYPE.GT_TOUCH_TAP"]/*'/>
    GT_TOUCH_TAP = 5,
    /// <include file='GESTURE_TYPE.xml' path='doc/member[@name="GESTURE_TYPE.GT_TOUCH_DOUBLETAP"]/*'/>
    GT_TOUCH_DOUBLETAP = 6,
    /// <include file='GESTURE_TYPE.xml' path='doc/member[@name="GESTURE_TYPE.GT_TOUCH_RIGHTTAP"]/*'/>
    GT_TOUCH_RIGHTTAP = 7,
    /// <include file='GESTURE_TYPE.xml' path='doc/member[@name="GESTURE_TYPE.GT_TOUCH_PRESSANDHOLD"]/*'/>
    GT_TOUCH_PRESSANDHOLD = 8,
    /// <include file='GESTURE_TYPE.xml' path='doc/member[@name="GESTURE_TYPE.GT_TOUCH_PRESSANDHOLDABORT"]/*'/>
    GT_TOUCH_PRESSANDHOLDABORT = 9,
    /// <include file='GESTURE_TYPE.xml' path='doc/member[@name="GESTURE_TYPE.GT_TOUCH_PRESSANDTAP"]/*'/>
    GT_TOUCH_PRESSANDTAP = 10,
}