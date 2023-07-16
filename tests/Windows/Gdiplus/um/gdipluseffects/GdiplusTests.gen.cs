// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Gdiplus.Gdiplus;

namespace Silk.NET.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "Gdiplus"/> class.</summary>
public static unsafe partial class GdiplusTests
{
    /// <summary>Validates that the value of the <see cref = "BlurEffectGuid"/> property is correct.</summary>
    [Test]
    public static void BlurEffectGuidTest()
    {
        Assert.That(BlurEffectGuid, Is.EqualTo(new Guid(0x633c80a4, 0x1843, 0x482b, 0x9e, 0xf2, 0xbe, 0x28, 0x34, 0xc5, 0xfd, 0xd4)));
    }

    /// <summary>Validates that the value of the <see cref = "SharpenEffectGuid"/> property is correct.</summary>
    [Test]
    public static void SharpenEffectGuidTest()
    {
        Assert.That(SharpenEffectGuid, Is.EqualTo(new Guid(0x63cbf3ee, 0xc526, 0x402c, 0x8f, 0x71, 0x62, 0xc5, 0x40, 0xbf, 0x51, 0x42)));
    }

    /// <summary>Validates that the value of the <see cref = "ColorMatrixEffectGuid"/> property is correct.</summary>
    [Test]
    public static void ColorMatrixEffectGuidTest()
    {
        Assert.That(ColorMatrixEffectGuid, Is.EqualTo(new Guid(0x718f2615, 0x7933, 0x40e3, 0xa5, 0x11, 0x5f, 0x68, 0xfe, 0x14, 0xdd, 0x74)));
    }

    /// <summary>Validates that the value of the <see cref = "ColorLUTEffectGuid"/> property is correct.</summary>
    [Test]
    public static void ColorLUTEffectGuidTest()
    {
        Assert.That(ColorLUTEffectGuid, Is.EqualTo(new Guid(0xa7ce72a9, 0xf7f, 0x40d7, 0xb3, 0xcc, 0xd0, 0xc0, 0x2d, 0x5c, 0x32, 0x12)));
    }

    /// <summary>Validates that the value of the <see cref = "BrightnessContrastEffectGuid"/> property is correct.</summary>
    [Test]
    public static void BrightnessContrastEffectGuidTest()
    {
        Assert.That(BrightnessContrastEffectGuid, Is.EqualTo(new Guid(0xd3a1dbe1, 0x8ec4, 0x4c17, 0x9f, 0x4c, 0xea, 0x97, 0xad, 0x1c, 0x34, 0x3d)));
    }

    /// <summary>Validates that the value of the <see cref = "HueSaturationLightnessEffectGuid"/> property is correct.</summary>
    [Test]
    public static void HueSaturationLightnessEffectGuidTest()
    {
        Assert.That(HueSaturationLightnessEffectGuid, Is.EqualTo(new Guid(0x8b2dd6c3, 0xeb07, 0x4d87, 0xa5, 0xf0, 0x71, 0x8, 0xe2, 0x6a, 0x9c, 0x5f)));
    }

    /// <summary>Validates that the value of the <see cref = "LevelsEffectGuid"/> property is correct.</summary>
    [Test]
    public static void LevelsEffectGuidTest()
    {
        Assert.That(LevelsEffectGuid, Is.EqualTo(new Guid(0x99c354ec, 0x2a31, 0x4f3a, 0x8c, 0x34, 0x17, 0xa8, 0x3, 0xb3, 0x3a, 0x25)));
    }

    /// <summary>Validates that the value of the <see cref = "TintEffectGuid"/> property is correct.</summary>
    [Test]
    public static void TintEffectGuidTest()
    {
        Assert.That(TintEffectGuid, Is.EqualTo(new Guid(0x1077af00, 0x2848, 0x4441, 0x94, 0x89, 0x44, 0xad, 0x4c, 0x2d, 0x7a, 0x2c)));
    }

    /// <summary>Validates that the value of the <see cref = "ColorBalanceEffectGuid"/> property is correct.</summary>
    [Test]
    public static void ColorBalanceEffectGuidTest()
    {
        Assert.That(ColorBalanceEffectGuid, Is.EqualTo(new Guid(0x537e597d, 0x251e, 0x48da, 0x96, 0x64, 0x29, 0xca, 0x49, 0x6b, 0x70, 0xf8)));
    }

    /// <summary>Validates that the value of the <see cref = "RedEyeCorrectionEffectGuid"/> property is correct.</summary>
    [Test]
    public static void RedEyeCorrectionEffectGuidTest()
    {
        Assert.That(RedEyeCorrectionEffectGuid, Is.EqualTo(new Guid(0x74d29d05, 0x69a4, 0x4266, 0x95, 0x49, 0x3c, 0xc5, 0x28, 0x36, 0xb6, 0x32)));
    }

    /// <summary>Validates that the value of the <see cref = "ColorCurveEffectGuid"/> property is correct.</summary>
    [Test]
    public static void ColorCurveEffectGuidTest()
    {
        Assert.That(ColorCurveEffectGuid, Is.EqualTo(new Guid(0xdd6a0022, 0x58e4, 0x4a67, 0x9d, 0x9b, 0xd4, 0x8e, 0xb8, 0x81, 0xa5, 0x3d)));
    }
}