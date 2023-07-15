// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluscolormatrix.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='ColorMatrix.xml' path='doc/member[@name="ColorMatrix"]/*'/>
public unsafe partial struct ColorMatrix
{
    /// <include file='ColorMatrix.xml' path='doc/member[@name="ColorMatrix.m"]/*'/>
    [NativeTypeName("REAL[5][5]")]
    public fixed float m[5 * 5];
}