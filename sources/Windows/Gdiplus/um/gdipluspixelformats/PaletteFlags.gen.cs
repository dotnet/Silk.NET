// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluspixelformats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Gdiplus;
/// <include file='PaletteFlags.xml' path='doc/member[@name="PaletteFlags"]/*'/>
[Flags]
public enum PaletteFlags
{
    /// <include file='PaletteFlags.xml' path='doc/member[@name="PaletteFlags.PaletteFlagsHasAlpha"]/*'/>
    PaletteFlagsHasAlpha = 0x0001,
    /// <include file='PaletteFlags.xml' path='doc/member[@name="PaletteFlags.PaletteFlagsGrayScale"]/*'/>
    PaletteFlagsGrayScale = 0x0002,
    /// <include file='PaletteFlags.xml' path='doc/member[@name="PaletteFlags.PaletteFlagsHalftone"]/*'/>
    PaletteFlagsHalftone = 0x0004,
}