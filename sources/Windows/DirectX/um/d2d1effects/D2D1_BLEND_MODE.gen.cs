// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE"]/*' />
public enum D2D1_BLEND_MODE
{
    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_MULTIPLY"]/*' />
    D2D1_BLEND_MODE_MULTIPLY = 0,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_SCREEN"]/*' />
    D2D1_BLEND_MODE_SCREEN = 1,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_DARKEN"]/*' />
    D2D1_BLEND_MODE_DARKEN = 2,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_LIGHTEN"]/*' />
    D2D1_BLEND_MODE_LIGHTEN = 3,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_DISSOLVE"]/*' />
    D2D1_BLEND_MODE_DISSOLVE = 4,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_COLOR_BURN"]/*' />
    D2D1_BLEND_MODE_COLOR_BURN = 5,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_LINEAR_BURN"]/*' />
    D2D1_BLEND_MODE_LINEAR_BURN = 6,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_DARKER_COLOR"]/*' />
    D2D1_BLEND_MODE_DARKER_COLOR = 7,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_LIGHTER_COLOR"]/*' />
    D2D1_BLEND_MODE_LIGHTER_COLOR = 8,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_COLOR_DODGE"]/*' />
    D2D1_BLEND_MODE_COLOR_DODGE = 9,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_LINEAR_DODGE"]/*' />
    D2D1_BLEND_MODE_LINEAR_DODGE = 10,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_OVERLAY"]/*' />
    D2D1_BLEND_MODE_OVERLAY = 11,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_SOFT_LIGHT"]/*' />
    D2D1_BLEND_MODE_SOFT_LIGHT = 12,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_HARD_LIGHT"]/*' />
    D2D1_BLEND_MODE_HARD_LIGHT = 13,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_VIVID_LIGHT"]/*' />
    D2D1_BLEND_MODE_VIVID_LIGHT = 14,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_LINEAR_LIGHT"]/*' />
    D2D1_BLEND_MODE_LINEAR_LIGHT = 15,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_PIN_LIGHT"]/*' />
    D2D1_BLEND_MODE_PIN_LIGHT = 16,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_HARD_MIX"]/*' />
    D2D1_BLEND_MODE_HARD_MIX = 17,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_DIFFERENCE"]/*' />
    D2D1_BLEND_MODE_DIFFERENCE = 18,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_EXCLUSION"]/*' />
    D2D1_BLEND_MODE_EXCLUSION = 19,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_HUE"]/*' />
    D2D1_BLEND_MODE_HUE = 20,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_SATURATION"]/*' />
    D2D1_BLEND_MODE_SATURATION = 21,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_COLOR"]/*' />
    D2D1_BLEND_MODE_COLOR = 22,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_LUMINOSITY"]/*' />
    D2D1_BLEND_MODE_LUMINOSITY = 23,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_SUBTRACT"]/*' />
    D2D1_BLEND_MODE_SUBTRACT = 24,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_DIVISION"]/*' />
    D2D1_BLEND_MODE_DIVISION = 25,

    /// <include file='D2D1_BLEND_MODE.xml' path='doc/member[@name="D2D1_BLEND_MODE.D2D1_BLEND_MODE_FORCE_DWORD"]/*' />
    D2D1_BLEND_MODE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
