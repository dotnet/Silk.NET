// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Contrast"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1ContrastTest()
    {
        Assert.That(CLSID_D2D1Contrast, Is.EqualTo(new Guid(0xb648a78a, 0x0ed5, 0x4f80, 0xa9, 0x4a, 0x8e, 0x82, 0x5a, 0xca, 0x6b, 0x77)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1RgbToHue"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1RgbToHueTest()
    {
        Assert.That(CLSID_D2D1RgbToHue, Is.EqualTo(new Guid(0x23f3e5ec, 0x91e8, 0x4d3d, 0xad, 0x0a, 0xaf, 0xad, 0xc1, 0x00, 0x4a, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1HueToRgb"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1HueToRgbTest()
    {
        Assert.That(CLSID_D2D1HueToRgb, Is.EqualTo(new Guid(0x7b78a6bd, 0x0141, 0x4def, 0x8a, 0x52, 0x63, 0x56, 0xee, 0x0c, 0xbd, 0xd5)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1ChromaKey"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1ChromaKeyTest()
    {
        Assert.That(CLSID_D2D1ChromaKey, Is.EqualTo(new Guid(0x74C01F5B, 0x2A0D, 0x408C, 0x88, 0xE2, 0xC7, 0xA3, 0xC7, 0x19, 0x77, 0x42)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Emboss"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1EmbossTest()
    {
        Assert.That(CLSID_D2D1Emboss, Is.EqualTo(new Guid(0xb1c5eb2b, 0x0348, 0x43f0, 0x81, 0x07, 0x49, 0x57, 0xca, 0xcb, 0xa2, 0xae)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Exposure"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1ExposureTest()
    {
        Assert.That(CLSID_D2D1Exposure, Is.EqualTo(new Guid(0xb56c8cfa, 0xf634, 0x41ee, 0xbe, 0xe0, 0xff, 0xa6, 0x17, 0x10, 0x60, 0x04)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Grayscale"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1GrayscaleTest()
    {
        Assert.That(CLSID_D2D1Grayscale, Is.EqualTo(new Guid(0x36DDE0EB, 0x3725, 0x42E0, 0x83, 0x6D, 0x52, 0xFB, 0x20, 0xAE, 0xE6, 0x44)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Invert"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1InvertTest()
    {
        Assert.That(CLSID_D2D1Invert, Is.EqualTo(new Guid(0xe0c3784d, 0xcb39, 0x4e84, 0xb6, 0xfd, 0x6b, 0x72, 0xf0, 0x81, 0x02, 0x63)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Posterize"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1PosterizeTest()
    {
        Assert.That(CLSID_D2D1Posterize, Is.EqualTo(new Guid(0x2188945e, 0x33a3, 0x4366, 0xb7, 0xbc, 0x08, 0x6b, 0xd0, 0x2d, 0x08, 0x84)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Sepia"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1SepiaTest()
    {
        Assert.That(CLSID_D2D1Sepia, Is.EqualTo(new Guid(0x3a1af410, 0x5f1d, 0x4dbe, 0x84, 0xdf, 0x91, 0x5d, 0xa7, 0x9b, 0x71, 0x53)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Sharpen"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1SharpenTest()
    {
        Assert.That(CLSID_D2D1Sharpen, Is.EqualTo(new Guid(0xC9B887CB, 0xC5FF, 0x4DC5, 0x97, 0x79, 0x27, 0x3D, 0xCF, 0x41, 0x7C, 0x7D)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Straighten"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1StraightenTest()
    {
        Assert.That(CLSID_D2D1Straighten, Is.EqualTo(new Guid(0x4da47b12, 0x79a3, 0x4fb0, 0x82, 0x37, 0xbb, 0xc3, 0xb2, 0xa4, 0xde, 0x08)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1TemperatureTint"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1TemperatureTintTest()
    {
        Assert.That(CLSID_D2D1TemperatureTint, Is.EqualTo(new Guid(0x89176087, 0x8AF9, 0x4A08, 0xAE, 0xB1, 0x89, 0x5F, 0x38, 0xDB, 0x17, 0x66)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Vignette"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1VignetteTest()
    {
        Assert.That(CLSID_D2D1Vignette, Is.EqualTo(new Guid(0xc00c40be, 0x5e67, 0x4ca3, 0x95, 0xb4, 0xf4, 0xb0, 0x2c, 0x11, 0x51, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1EdgeDetection"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1EdgeDetectionTest()
    {
        Assert.That(CLSID_D2D1EdgeDetection, Is.EqualTo(new Guid(0xEFF583CA, 0xCB07, 0x4AA9, 0xAC, 0x5D, 0x2C, 0xC4, 0x4C, 0x76, 0x46, 0x0F)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1HighlightsShadows"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1HighlightsShadowsTest()
    {
        Assert.That(CLSID_D2D1HighlightsShadows, Is.EqualTo(new Guid(0xCADC8384, 0x323F, 0x4C7E, 0xA3, 0x61, 0x2E, 0x2B, 0x24, 0xDF, 0x6E, 0xE4)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1LookupTable3D"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1LookupTable3DTest()
    {
        Assert.That(CLSID_D2D1LookupTable3D, Is.EqualTo(new Guid(0x349E0EDA, 0x0088, 0x4A79, 0x9C, 0xA3, 0xC7, 0xE3, 0x00, 0x20, 0x20, 0x20)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Opacity"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1OpacityTest()
    {
        Assert.That(CLSID_D2D1Opacity, Is.EqualTo(new Guid(0x811d79a4, 0xde28, 0x4454, 0x80, 0x94, 0xc6, 0x46, 0x85, 0xf8, 0xbd, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1AlphaMask"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1AlphaMaskTest()
    {
        Assert.That(CLSID_D2D1AlphaMask, Is.EqualTo(new Guid(0xc80ecff0, 0x3fd5, 0x4f05, 0x83, 0x28, 0xc5, 0xd1, 0x72, 0x4b, 0x4f, 0x0a)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1CrossFade"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1CrossFadeTest()
    {
        Assert.That(CLSID_D2D1CrossFade, Is.EqualTo(new Guid(0x12f575e8, 0x4db1, 0x485f, 0x9a, 0x84, 0x03, 0xa0, 0x7d, 0xd3, 0x82, 0x9f)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Tint"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1TintTest()
    {
        Assert.That(CLSID_D2D1Tint, Is.EqualTo(new Guid(0x36312b17, 0xf7dd, 0x4014, 0x91, 0x5d, 0xff, 0xca, 0x76, 0x8c, 0xf2, 0x11)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1WhiteLevelAdjustment"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1WhiteLevelAdjustmentTest()
    {
        Assert.That(CLSID_D2D1WhiteLevelAdjustment, Is.EqualTo(new Guid(0x44a1cadb, 0x6cdd, 0x4818, 0x8f, 0xf4, 0x26, 0xc1, 0xcf, 0xe9, 0x5b, 0xdb)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1HdrToneMap"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1HdrToneMapTest()
    {
        Assert.That(CLSID_D2D1HdrToneMap, Is.EqualTo(new Guid(0x7b0b748d, 0x4610, 0x4486, 0xa9, 0x0c, 0x99, 0x9d, 0x9a, 0x2e, 0x2b, 0x11)));
    }
}