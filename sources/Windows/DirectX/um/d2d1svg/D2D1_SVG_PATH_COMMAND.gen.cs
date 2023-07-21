// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND"]/*' />
public enum D2D1_SVG_PATH_COMMAND
{
    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_CLOSE_PATH"]/*' />
    D2D1_SVG_PATH_COMMAND_CLOSE_PATH = 0,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_MOVE_ABSOLUTE"]/*' />
    D2D1_SVG_PATH_COMMAND_MOVE_ABSOLUTE = 1,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_MOVE_RELATIVE"]/*' />
    D2D1_SVG_PATH_COMMAND_MOVE_RELATIVE = 2,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_LINE_ABSOLUTE"]/*' />
    D2D1_SVG_PATH_COMMAND_LINE_ABSOLUTE = 3,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_LINE_RELATIVE"]/*' />
    D2D1_SVG_PATH_COMMAND_LINE_RELATIVE = 4,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_CUBIC_ABSOLUTE"]/*' />
    D2D1_SVG_PATH_COMMAND_CUBIC_ABSOLUTE = 5,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_CUBIC_RELATIVE"]/*' />
    D2D1_SVG_PATH_COMMAND_CUBIC_RELATIVE = 6,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_QUADRADIC_ABSOLUTE"]/*' />
    D2D1_SVG_PATH_COMMAND_QUADRADIC_ABSOLUTE = 7,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_QUADRADIC_RELATIVE"]/*' />
    D2D1_SVG_PATH_COMMAND_QUADRADIC_RELATIVE = 8,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_ARC_ABSOLUTE"]/*' />
    D2D1_SVG_PATH_COMMAND_ARC_ABSOLUTE = 9,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_ARC_RELATIVE"]/*' />
    D2D1_SVG_PATH_COMMAND_ARC_RELATIVE = 10,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_HORIZONTAL_ABSOLUTE"]/*' />
    D2D1_SVG_PATH_COMMAND_HORIZONTAL_ABSOLUTE = 11,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_HORIZONTAL_RELATIVE"]/*' />
    D2D1_SVG_PATH_COMMAND_HORIZONTAL_RELATIVE = 12,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_VERTICAL_ABSOLUTE"]/*' />
    D2D1_SVG_PATH_COMMAND_VERTICAL_ABSOLUTE = 13,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_VERTICAL_RELATIVE"]/*' />
    D2D1_SVG_PATH_COMMAND_VERTICAL_RELATIVE = 14,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_ABSOLUTE"]/*' />
    D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_ABSOLUTE = 15,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_RELATIVE"]/*' />
    D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_RELATIVE = 16,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_ABSOLUTE"]/*' />
    D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_ABSOLUTE = 17,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_RELATIVE"]/*' />
    D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_RELATIVE = 18,

    /// <include file='D2D1_SVG_PATH_COMMAND.xml' path='doc/member[@name="D2D1_SVG_PATH_COMMAND.D2D1_SVG_PATH_COMMAND_FORCE_DWORD"]/*' />
    D2D1_SVG_PATH_COMMAND_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
