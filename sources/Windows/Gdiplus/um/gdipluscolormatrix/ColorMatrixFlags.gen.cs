// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluscolormatrix.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Gdiplus;
/// <include file='ColorMatrixFlags.xml' path='doc/member[@name="ColorMatrixFlags"]/*'/>
[Flags]
public enum ColorMatrixFlags
{
    /// <include file='ColorMatrixFlags.xml' path='doc/member[@name="ColorMatrixFlags.ColorMatrixFlagsDefault"]/*'/>
    ColorMatrixFlagsDefault = 0,
    /// <include file='ColorMatrixFlags.xml' path='doc/member[@name="ColorMatrixFlags.ColorMatrixFlagsSkipGrays"]/*'/>
    ColorMatrixFlagsSkipGrays = 1,
    /// <include file='ColorMatrixFlags.xml' path='doc/member[@name="ColorMatrixFlags.ColorMatrixFlagsAltGray"]/*'/>
    ColorMatrixFlagsAltGray = 2,
}