// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_RENDER_TARGET_USAGE.xml' path='doc/member[@name="D2D1_RENDER_TARGET_USAGE"]/*'/>
[Flags]
public enum D2D1_RENDER_TARGET_USAGE
{
    /// <include file='D2D1_RENDER_TARGET_USAGE.xml' path='doc/member[@name="D2D1_RENDER_TARGET_USAGE.D2D1_RENDER_TARGET_USAGE_NONE"]/*'/>
    D2D1_RENDER_TARGET_USAGE_NONE = 0x00000000,
    /// <include file='D2D1_RENDER_TARGET_USAGE.xml' path='doc/member[@name="D2D1_RENDER_TARGET_USAGE.D2D1_RENDER_TARGET_USAGE_FORCE_BITMAP_REMOTING"]/*'/>
    D2D1_RENDER_TARGET_USAGE_FORCE_BITMAP_REMOTING = 0x00000001,
    /// <include file='D2D1_RENDER_TARGET_USAGE.xml' path='doc/member[@name="D2D1_RENDER_TARGET_USAGE.D2D1_RENDER_TARGET_USAGE_GDI_COMPATIBLE"]/*'/>
    D2D1_RENDER_TARGET_USAGE_GDI_COMPATIBLE = 0x00000002,
    /// <include file='D2D1_RENDER_TARGET_USAGE.xml' path='doc/member[@name="D2D1_RENDER_TARGET_USAGE.D2D1_RENDER_TARGET_USAGE_FORCE_DWORD"]/*'/>
    D2D1_RENDER_TARGET_USAGE_FORCE_DWORD = unchecked((int)(0xffffffff)),
}