// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='styleMsTouchAction.xml' path='doc/member[@name="styleMsTouchAction"]/*'/>
public enum styleMsTouchAction
{
    /// <include file='styleMsTouchAction.xml' path='doc/member[@name="styleMsTouchAction.styleMsTouchActionNotSet"]/*'/>
    styleMsTouchActionNotSet = -1,
    /// <include file='styleMsTouchAction.xml' path='doc/member[@name="styleMsTouchAction.styleMsTouchActionNone"]/*'/>
    styleMsTouchActionNone = 0,
    /// <include file='styleMsTouchAction.xml' path='doc/member[@name="styleMsTouchAction.styleMsTouchActionAuto"]/*'/>
    styleMsTouchActionAuto = 1,
    /// <include file='styleMsTouchAction.xml' path='doc/member[@name="styleMsTouchAction.styleMsTouchActionManipulation"]/*'/>
    styleMsTouchActionManipulation = 2,
    /// <include file='styleMsTouchAction.xml' path='doc/member[@name="styleMsTouchAction.styleMsTouchActionDoubleTapZoom"]/*'/>
    styleMsTouchActionDoubleTapZoom = 4,
    /// <include file='styleMsTouchAction.xml' path='doc/member[@name="styleMsTouchAction.styleMsTouchActionPanX"]/*'/>
    styleMsTouchActionPanX = 8,
    /// <include file='styleMsTouchAction.xml' path='doc/member[@name="styleMsTouchAction.styleMsTouchActionPanY"]/*'/>
    styleMsTouchActionPanY = 16,
    /// <include file='styleMsTouchAction.xml' path='doc/member[@name="styleMsTouchAction.styleMsTouchActionPinchZoom"]/*'/>
    styleMsTouchActionPinchZoom = 32,
    /// <include file='styleMsTouchAction.xml' path='doc/member[@name="styleMsTouchAction.styleMsTouchActionCrossSlideX"]/*'/>
    styleMsTouchActionCrossSlideX = 64,
    /// <include file='styleMsTouchAction.xml' path='doc/member[@name="styleMsTouchAction.styleMsTouchActionCrossSlideY"]/*'/>
    styleMsTouchActionCrossSlideY = 128,
    /// <include file='styleMsTouchAction.xml' path='doc/member[@name="styleMsTouchAction.styleMsTouchAction_Max"]/*'/>
    styleMsTouchAction_Max = 2147483647,
}