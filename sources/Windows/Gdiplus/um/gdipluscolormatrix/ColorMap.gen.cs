// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluscolormatrix.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='ColorMap.xml' path='doc/member[@name="ColorMap"]/*'/>
public partial struct ColorMap
{
    /// <include file='ColorMap.xml' path='doc/member[@name="ColorMap.oldColor"]/*'/>
    [NativeTypeName("Gdiplus::Color")]
    public Color oldColor;
    /// <include file='ColorMap.xml' path='doc/member[@name="ColorMap.newColor"]/*'/>
    [NativeTypeName("Gdiplus::Color")]
    public Color newColor;
}