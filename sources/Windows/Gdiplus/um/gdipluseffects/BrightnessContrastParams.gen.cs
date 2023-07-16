// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Gdiplus;
/// <include file='BrightnessContrastParams.xml' path='doc/member[@name="BrightnessContrastParams"]/*'/>
public partial struct BrightnessContrastParams
{
    /// <include file='BrightnessContrastParams.xml' path='doc/member[@name="BrightnessContrastParams.brightnessLevel"]/*'/>
    public int brightnessLevel;
    /// <include file='BrightnessContrastParams.xml' path='doc/member[@name="BrightnessContrastParams.contrastLevel"]/*'/>
    public int contrastLevel;
}