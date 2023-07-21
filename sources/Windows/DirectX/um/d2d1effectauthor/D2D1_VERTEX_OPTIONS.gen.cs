// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='D2D1_VERTEX_OPTIONS.xml' path='doc/member[@name="D2D1_VERTEX_OPTIONS"]/*' />
[Flags]
public enum D2D1_VERTEX_OPTIONS
{
    /// <include file='D2D1_VERTEX_OPTIONS.xml' path='doc/member[@name="D2D1_VERTEX_OPTIONS.D2D1_VERTEX_OPTIONS_NONE"]/*' />
    D2D1_VERTEX_OPTIONS_NONE = 0,

    /// <include file='D2D1_VERTEX_OPTIONS.xml' path='doc/member[@name="D2D1_VERTEX_OPTIONS.D2D1_VERTEX_OPTIONS_DO_NOT_CLEAR"]/*' />
    D2D1_VERTEX_OPTIONS_DO_NOT_CLEAR = 1,

    /// <include file='D2D1_VERTEX_OPTIONS.xml' path='doc/member[@name="D2D1_VERTEX_OPTIONS.D2D1_VERTEX_OPTIONS_USE_DEPTH_BUFFER"]/*' />
    D2D1_VERTEX_OPTIONS_USE_DEPTH_BUFFER = 2,

    /// <include file='D2D1_VERTEX_OPTIONS.xml' path='doc/member[@name="D2D1_VERTEX_OPTIONS.D2D1_VERTEX_OPTIONS_ASSUME_NO_OVERLAP"]/*' />
    D2D1_VERTEX_OPTIONS_ASSUME_NO_OVERLAP = 4,

    /// <include file='D2D1_VERTEX_OPTIONS.xml' path='doc/member[@name="D2D1_VERTEX_OPTIONS.D2D1_VERTEX_OPTIONS_FORCE_DWORD"]/*' />
    D2D1_VERTEX_OPTIONS_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
