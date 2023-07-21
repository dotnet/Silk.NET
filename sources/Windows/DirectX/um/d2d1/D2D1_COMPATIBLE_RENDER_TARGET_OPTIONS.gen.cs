// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.DirectX;

/// <include file='D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS.xml' path='doc/member[@name="D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS"]/*' />
[Flags]
public enum D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS
{
    /// <include file='D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS.xml' path='doc/member[@name="D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE"]/*' />
    D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE = 0x00000000,

    /// <include file='D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS.xml' path='doc/member[@name="D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_GDI_COMPATIBLE"]/*' />
    D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_GDI_COMPATIBLE = 0x00000001,

    /// <include file='D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS.xml' path='doc/member[@name="D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_FORCE_DWORD"]/*' />
    D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
