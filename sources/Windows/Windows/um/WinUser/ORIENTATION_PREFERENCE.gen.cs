// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='ORIENTATION_PREFERENCE.xml' path='doc/member[@name="ORIENTATION_PREFERENCE"]/*'/>
[Flags]
public enum ORIENTATION_PREFERENCE
{
    /// <include file='ORIENTATION_PREFERENCE.xml' path='doc/member[@name="ORIENTATION_PREFERENCE.ORIENTATION_PREFERENCE_NONE"]/*'/>
    ORIENTATION_PREFERENCE_NONE = 0x0,
    /// <include file='ORIENTATION_PREFERENCE.xml' path='doc/member[@name="ORIENTATION_PREFERENCE.ORIENTATION_PREFERENCE_LANDSCAPE"]/*'/>
    ORIENTATION_PREFERENCE_LANDSCAPE = 0x1,
    /// <include file='ORIENTATION_PREFERENCE.xml' path='doc/member[@name="ORIENTATION_PREFERENCE.ORIENTATION_PREFERENCE_PORTRAIT"]/*'/>
    ORIENTATION_PREFERENCE_PORTRAIT = 0x2,
    /// <include file='ORIENTATION_PREFERENCE.xml' path='doc/member[@name="ORIENTATION_PREFERENCE.ORIENTATION_PREFERENCE_LANDSCAPE_FLIPPED"]/*'/>
    ORIENTATION_PREFERENCE_LANDSCAPE_FLIPPED = 0x4,
    /// <include file='ORIENTATION_PREFERENCE.xml' path='doc/member[@name="ORIENTATION_PREFERENCE.ORIENTATION_PREFERENCE_PORTRAIT_FLIPPED"]/*'/>
    ORIENTATION_PREFERENCE_PORTRAIT_FLIPPED = 0x8,
}