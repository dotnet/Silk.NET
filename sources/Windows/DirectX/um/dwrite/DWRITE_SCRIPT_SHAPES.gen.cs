// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='DWRITE_SCRIPT_SHAPES.xml' path='doc/member[@name="DWRITE_SCRIPT_SHAPES"]/*' />
[Flags]
public enum DWRITE_SCRIPT_SHAPES
{
    /// <include file='DWRITE_SCRIPT_SHAPES.xml' path='doc/member[@name="DWRITE_SCRIPT_SHAPES.DWRITE_SCRIPT_SHAPES_DEFAULT"]/*' />
    DWRITE_SCRIPT_SHAPES_DEFAULT = 0,

    /// <include file='DWRITE_SCRIPT_SHAPES.xml' path='doc/member[@name="DWRITE_SCRIPT_SHAPES.DWRITE_SCRIPT_SHAPES_NO_VISUAL"]/*' />
    DWRITE_SCRIPT_SHAPES_NO_VISUAL = 1,
}
