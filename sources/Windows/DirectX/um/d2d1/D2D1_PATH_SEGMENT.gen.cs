// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='D2D1_PATH_SEGMENT.xml' path='doc/member[@name="D2D1_PATH_SEGMENT"]/*' />
[Flags]
public enum D2D1_PATH_SEGMENT
{
    /// <include file='D2D1_PATH_SEGMENT.xml' path='doc/member[@name="D2D1_PATH_SEGMENT.D2D1_PATH_SEGMENT_NONE"]/*' />
    D2D1_PATH_SEGMENT_NONE = 0x00000000,

    /// <include file='D2D1_PATH_SEGMENT.xml' path='doc/member[@name="D2D1_PATH_SEGMENT.D2D1_PATH_SEGMENT_FORCE_UNSTROKED"]/*' />
    D2D1_PATH_SEGMENT_FORCE_UNSTROKED = 0x00000001,

    /// <include file='D2D1_PATH_SEGMENT.xml' path='doc/member[@name="D2D1_PATH_SEGMENT.D2D1_PATH_SEGMENT_FORCE_ROUND_LINE_JOIN"]/*' />
    D2D1_PATH_SEGMENT_FORCE_ROUND_LINE_JOIN = 0x00000002,

    /// <include file='D2D1_PATH_SEGMENT.xml' path='doc/member[@name="D2D1_PATH_SEGMENT.D2D1_PATH_SEGMENT_FORCE_DWORD"]/*' />
    D2D1_PATH_SEGMENT_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
