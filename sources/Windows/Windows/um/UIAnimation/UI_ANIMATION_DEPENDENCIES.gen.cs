// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='UI_ANIMATION_DEPENDENCIES.xml' path='doc/member[@name="UI_ANIMATION_DEPENDENCIES"]/*'/>
[Flags]
public enum UI_ANIMATION_DEPENDENCIES
{
    /// <include file='UI_ANIMATION_DEPENDENCIES.xml' path='doc/member[@name="UI_ANIMATION_DEPENDENCIES.UI_ANIMATION_DEPENDENCY_NONE"]/*'/>
    UI_ANIMATION_DEPENDENCY_NONE = 0,
    /// <include file='UI_ANIMATION_DEPENDENCIES.xml' path='doc/member[@name="UI_ANIMATION_DEPENDENCIES.UI_ANIMATION_DEPENDENCY_INTERMEDIATE_VALUES"]/*'/>
    UI_ANIMATION_DEPENDENCY_INTERMEDIATE_VALUES = 0x1,
    /// <include file='UI_ANIMATION_DEPENDENCIES.xml' path='doc/member[@name="UI_ANIMATION_DEPENDENCIES.UI_ANIMATION_DEPENDENCY_FINAL_VALUE"]/*'/>
    UI_ANIMATION_DEPENDENCY_FINAL_VALUE = 0x2,
    /// <include file='UI_ANIMATION_DEPENDENCIES.xml' path='doc/member[@name="UI_ANIMATION_DEPENDENCIES.UI_ANIMATION_DEPENDENCY_FINAL_VELOCITY"]/*'/>
    UI_ANIMATION_DEPENDENCY_FINAL_VELOCITY = 0x4,
    /// <include file='UI_ANIMATION_DEPENDENCIES.xml' path='doc/member[@name="UI_ANIMATION_DEPENDENCIES.UI_ANIMATION_DEPENDENCY_DURATION"]/*'/>
    UI_ANIMATION_DEPENDENCY_DURATION = 0x8,
}