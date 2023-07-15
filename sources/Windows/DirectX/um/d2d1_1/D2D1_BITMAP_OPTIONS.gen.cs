// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_BITMAP_OPTIONS.xml' path='doc/member[@name="D2D1_BITMAP_OPTIONS"]/*'/>
[Flags]
public enum D2D1_BITMAP_OPTIONS
{
    /// <include file='D2D1_BITMAP_OPTIONS.xml' path='doc/member[@name="D2D1_BITMAP_OPTIONS.D2D1_BITMAP_OPTIONS_NONE"]/*'/>
    D2D1_BITMAP_OPTIONS_NONE = 0x00000000,
    /// <include file='D2D1_BITMAP_OPTIONS.xml' path='doc/member[@name="D2D1_BITMAP_OPTIONS.D2D1_BITMAP_OPTIONS_TARGET"]/*'/>
    D2D1_BITMAP_OPTIONS_TARGET = 0x00000001,
    /// <include file='D2D1_BITMAP_OPTIONS.xml' path='doc/member[@name="D2D1_BITMAP_OPTIONS.D2D1_BITMAP_OPTIONS_CANNOT_DRAW"]/*'/>
    D2D1_BITMAP_OPTIONS_CANNOT_DRAW = 0x00000002,
    /// <include file='D2D1_BITMAP_OPTIONS.xml' path='doc/member[@name="D2D1_BITMAP_OPTIONS.D2D1_BITMAP_OPTIONS_CPU_READ"]/*'/>
    D2D1_BITMAP_OPTIONS_CPU_READ = 0x00000004,
    /// <include file='D2D1_BITMAP_OPTIONS.xml' path='doc/member[@name="D2D1_BITMAP_OPTIONS.D2D1_BITMAP_OPTIONS_GDI_COMPATIBLE"]/*'/>
    D2D1_BITMAP_OPTIONS_GDI_COMPATIBLE = 0x00000008,
    /// <include file='D2D1_BITMAP_OPTIONS.xml' path='doc/member[@name="D2D1_BITMAP_OPTIONS.D2D1_BITMAP_OPTIONS_FORCE_DWORD"]/*'/>
    D2D1_BITMAP_OPTIONS_FORCE_DWORD = unchecked((int)(0xffffffff)),
}