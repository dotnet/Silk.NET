// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='UI_ANIMATION_TIMER_CLIENT_STATUS.xml' path='doc/member[@name="UI_ANIMATION_TIMER_CLIENT_STATUS"]/*'/>
public enum UI_ANIMATION_TIMER_CLIENT_STATUS
{
    /// <include file='UI_ANIMATION_TIMER_CLIENT_STATUS.xml' path='doc/member[@name="UI_ANIMATION_TIMER_CLIENT_STATUS.UI_ANIMATION_TIMER_CLIENT_IDLE"]/*'/>
    UI_ANIMATION_TIMER_CLIENT_IDLE = 0,
    /// <include file='UI_ANIMATION_TIMER_CLIENT_STATUS.xml' path='doc/member[@name="UI_ANIMATION_TIMER_CLIENT_STATUS.UI_ANIMATION_TIMER_CLIENT_BUSY"]/*'/>
    UI_ANIMATION_TIMER_CLIENT_BUSY = 1,
}