// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='MFPaletteEntry.xml' path='doc/member[@name="MFPaletteEntry"]/*'/>
[StructLayout(LayoutKind.Explicit)]
public partial struct MFPaletteEntry
{
    /// <include file='MFPaletteEntry.xml' path='doc/member[@name="MFPaletteEntry.ARGB"]/*'/>
    [FieldOffset(0)]
    public MFARGB ARGB;
    /// <include file='MFPaletteEntry.xml' path='doc/member[@name="MFPaletteEntry.AYCbCr"]/*'/>
    [FieldOffset(0)]
    public MFAYUVSample AYCbCr;
}