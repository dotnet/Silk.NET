// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='UI_ANIMATION_MANAGER_STATUS.xml' path='doc/member[@name="UI_ANIMATION_MANAGER_STATUS"]/*'/>
public enum UI_ANIMATION_MANAGER_STATUS
{
    /// <include file='UI_ANIMATION_MANAGER_STATUS.xml' path='doc/member[@name="UI_ANIMATION_MANAGER_STATUS.UI_ANIMATION_MANAGER_IDLE"]/*'/>
    UI_ANIMATION_MANAGER_IDLE = 0,
    /// <include file='UI_ANIMATION_MANAGER_STATUS.xml' path='doc/member[@name="UI_ANIMATION_MANAGER_STATUS.UI_ANIMATION_MANAGER_BUSY"]/*'/>
    UI_ANIMATION_MANAGER_BUSY = 1,
}