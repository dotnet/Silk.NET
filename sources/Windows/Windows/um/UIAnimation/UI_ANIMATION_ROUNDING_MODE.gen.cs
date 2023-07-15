// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='UI_ANIMATION_ROUNDING_MODE.xml' path='doc/member[@name="UI_ANIMATION_ROUNDING_MODE"]/*'/>
public enum UI_ANIMATION_ROUNDING_MODE
{
    /// <include file='UI_ANIMATION_ROUNDING_MODE.xml' path='doc/member[@name="UI_ANIMATION_ROUNDING_MODE.UI_ANIMATION_ROUNDING_NEAREST"]/*'/>
    UI_ANIMATION_ROUNDING_NEAREST = 0,
    /// <include file='UI_ANIMATION_ROUNDING_MODE.xml' path='doc/member[@name="UI_ANIMATION_ROUNDING_MODE.UI_ANIMATION_ROUNDING_FLOOR"]/*'/>
    UI_ANIMATION_ROUNDING_FLOOR = 1,
    /// <include file='UI_ANIMATION_ROUNDING_MODE.xml' path='doc/member[@name="UI_ANIMATION_ROUNDING_MODE.UI_ANIMATION_ROUNDING_CEILING"]/*'/>
    UI_ANIMATION_ROUNDING_CEILING = 2,
}