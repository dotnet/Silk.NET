// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='HueSaturationLightnessParams.xml' path='doc/member[@name="HueSaturationLightnessParams"]/*'/>
public partial struct HueSaturationLightnessParams
{
    /// <include file='HueSaturationLightnessParams.xml' path='doc/member[@name="HueSaturationLightnessParams.hueLevel"]/*'/>
    public int hueLevel;
    /// <include file='HueSaturationLightnessParams.xml' path='doc/member[@name="HueSaturationLightnessParams.saturationLevel"]/*'/>
    public int saturationLevel;
    /// <include file='HueSaturationLightnessParams.xml' path='doc/member[@name="HueSaturationLightnessParams.lightnessLevel"]/*'/>
    public int lightnessLevel;
}