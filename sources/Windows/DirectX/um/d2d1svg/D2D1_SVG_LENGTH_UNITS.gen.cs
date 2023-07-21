// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_SVG_LENGTH_UNITS.xml' path='doc/member[@name="D2D1_SVG_LENGTH_UNITS"]/*' />
public enum D2D1_SVG_LENGTH_UNITS
{
    /// <include file='D2D1_SVG_LENGTH_UNITS.xml' path='doc/member[@name="D2D1_SVG_LENGTH_UNITS.D2D1_SVG_LENGTH_UNITS_NUMBER"]/*' />
    D2D1_SVG_LENGTH_UNITS_NUMBER = 0,

    /// <include file='D2D1_SVG_LENGTH_UNITS.xml' path='doc/member[@name="D2D1_SVG_LENGTH_UNITS.D2D1_SVG_LENGTH_UNITS_PERCENTAGE"]/*' />
    D2D1_SVG_LENGTH_UNITS_PERCENTAGE = 1,

    /// <include file='D2D1_SVG_LENGTH_UNITS.xml' path='doc/member[@name="D2D1_SVG_LENGTH_UNITS.D2D1_SVG_LENGTH_UNITS_FORCE_DWORD"]/*' />
    D2D1_SVG_LENGTH_UNITS_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
