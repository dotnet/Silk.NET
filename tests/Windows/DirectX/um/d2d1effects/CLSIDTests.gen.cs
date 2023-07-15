// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_D2D12DAffineTransform"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D12DAffineTransformTest()
    {
        Assert.That(CLSID_D2D12DAffineTransform, Is.EqualTo(new Guid(0x6AA97485, 0x6354, 0x4cfc, 0x90, 0x8C, 0xE4, 0xA7, 0x4F, 0x62, 0xC9, 0x6C)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D13DPerspectiveTransform"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D13DPerspectiveTransformTest()
    {
        Assert.That(CLSID_D2D13DPerspectiveTransform, Is.EqualTo(new Guid(0xC2844D0B, 0x3D86, 0x46e7, 0x85, 0xBA, 0x52, 0x6C, 0x92, 0x40, 0xF3, 0xFB)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D13DTransform"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D13DTransformTest()
    {
        Assert.That(CLSID_D2D13DTransform, Is.EqualTo(new Guid(0xe8467b04, 0xec61, 0x4b8a, 0xb5, 0xde, 0xd4, 0xd7, 0x3d, 0xeb, 0xea, 0x5a)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1ArithmeticComposite"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1ArithmeticCompositeTest()
    {
        Assert.That(CLSID_D2D1ArithmeticComposite, Is.EqualTo(new Guid(0xfc151437, 0x049a, 0x4784, 0xa2, 0x4a, 0xf1, 0xc4, 0xda, 0xf2, 0x09, 0x87)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Atlas"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1AtlasTest()
    {
        Assert.That(CLSID_D2D1Atlas, Is.EqualTo(new Guid(0x913e2be4, 0xfdcf, 0x4fe2, 0xa5, 0xf0, 0x24, 0x54, 0xf1, 0x4f, 0xf4, 0x8)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1BitmapSource"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1BitmapSourceTest()
    {
        Assert.That(CLSID_D2D1BitmapSource, Is.EqualTo(new Guid(0x5fb6c24d, 0xc6dd, 0x4231, 0x94, 0x4, 0x50, 0xf4, 0xd5, 0xc3, 0x25, 0x2d)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Blend"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1BlendTest()
    {
        Assert.That(CLSID_D2D1Blend, Is.EqualTo(new Guid(0x81c5b77b, 0x13f8, 0x4cdd, 0xad, 0x20, 0xc8, 0x90, 0x54, 0x7a, 0xc6, 0x5d)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Border"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1BorderTest()
    {
        Assert.That(CLSID_D2D1Border, Is.EqualTo(new Guid(0x2A2D49C0, 0x4ACF, 0x43c7, 0x8C, 0x6A, 0x7C, 0x4A, 0x27, 0x87, 0x4D, 0x27)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Brightness"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1BrightnessTest()
    {
        Assert.That(CLSID_D2D1Brightness, Is.EqualTo(new Guid(0x8cea8d1e, 0x77b0, 0x4986, 0xb3, 0xb9, 0x2f, 0x0c, 0x0e, 0xae, 0x78, 0x87)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1ColorManagement"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1ColorManagementTest()
    {
        Assert.That(CLSID_D2D1ColorManagement, Is.EqualTo(new Guid(0x1A28524C, 0xFDD6, 0x4AA4, 0xAE, 0x8F, 0x83, 0x7E, 0xB8, 0x26, 0x7B, 0x37)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1ColorMatrix"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1ColorMatrixTest()
    {
        Assert.That(CLSID_D2D1ColorMatrix, Is.EqualTo(new Guid(0x921F03D6, 0x641C, 0x47DF, 0x85, 0x2D, 0xB4, 0xBB, 0x61, 0x53, 0xAE, 0x11)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Composite"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1CompositeTest()
    {
        Assert.That(CLSID_D2D1Composite, Is.EqualTo(new Guid(0x48fc9f51, 0xf6ac, 0x48f1, 0x8b, 0x58, 0x3b, 0x28, 0xac, 0x46, 0xf7, 0x6d)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1ConvolveMatrix"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1ConvolveMatrixTest()
    {
        Assert.That(CLSID_D2D1ConvolveMatrix, Is.EqualTo(new Guid(0x407f8c08, 0x5533, 0x4331, 0xa3, 0x41, 0x23, 0xcc, 0x38, 0x77, 0x84, 0x3e)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Crop"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1CropTest()
    {
        Assert.That(CLSID_D2D1Crop, Is.EqualTo(new Guid(0xE23F7110, 0x0E9A, 0x4324, 0xAF, 0x47, 0x6A, 0x2C, 0x0C, 0x46, 0xF3, 0x5B)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1DirectionalBlur"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1DirectionalBlurTest()
    {
        Assert.That(CLSID_D2D1DirectionalBlur, Is.EqualTo(new Guid(0x174319a6, 0x58e9, 0x49b2, 0xbb, 0x63, 0xca, 0xf2, 0xc8, 0x11, 0xa3, 0xdb)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1DiscreteTransfer"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1DiscreteTransferTest()
    {
        Assert.That(CLSID_D2D1DiscreteTransfer, Is.EqualTo(new Guid(0x90866fcd, 0x488e, 0x454b, 0xaf, 0x06, 0xe5, 0x04, 0x1b, 0x66, 0xc3, 0x6c)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1DisplacementMap"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1DisplacementMapTest()
    {
        Assert.That(CLSID_D2D1DisplacementMap, Is.EqualTo(new Guid(0xedc48364, 0x417, 0x4111, 0x94, 0x50, 0x43, 0x84, 0x5f, 0xa9, 0xf8, 0x90)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1DistantDiffuse"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1DistantDiffuseTest()
    {
        Assert.That(CLSID_D2D1DistantDiffuse, Is.EqualTo(new Guid(0x3e7efd62, 0xa32d, 0x46d4, 0xa8, 0x3c, 0x52, 0x78, 0x88, 0x9a, 0xc9, 0x54)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1DistantSpecular"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1DistantSpecularTest()
    {
        Assert.That(CLSID_D2D1DistantSpecular, Is.EqualTo(new Guid(0x428c1ee5, 0x77b8, 0x4450, 0x8a, 0xb5, 0x72, 0x21, 0x9c, 0x21, 0xab, 0xda)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1DpiCompensation"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1DpiCompensationTest()
    {
        Assert.That(CLSID_D2D1DpiCompensation, Is.EqualTo(new Guid(0x6c26c5c7, 0x34e0, 0x46fc, 0x9c, 0xfd, 0xe5, 0x82, 0x37, 0x6, 0xe2, 0x28)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Flood"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1FloodTest()
    {
        Assert.That(CLSID_D2D1Flood, Is.EqualTo(new Guid(0x61c23c20, 0xae69, 0x4d8e, 0x94, 0xcf, 0x50, 0x07, 0x8d, 0xf6, 0x38, 0xf2)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1GammaTransfer"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1GammaTransferTest()
    {
        Assert.That(CLSID_D2D1GammaTransfer, Is.EqualTo(new Guid(0x409444c4, 0xc419, 0x41a0, 0xb0, 0xc1, 0x8c, 0xd0, 0xc0, 0xa1, 0x8e, 0x42)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1GaussianBlur"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1GaussianBlurTest()
    {
        Assert.That(CLSID_D2D1GaussianBlur, Is.EqualTo(new Guid(0x1feb6d69, 0x2fe6, 0x4ac9, 0x8c, 0x58, 0x1d, 0x7f, 0x93, 0xe7, 0xa6, 0xa5)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Scale"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1ScaleTest()
    {
        Assert.That(CLSID_D2D1Scale, Is.EqualTo(new Guid(0x9daf9369, 0x3846, 0x4d0e, 0xa4, 0x4e, 0xc, 0x60, 0x79, 0x34, 0xa5, 0xd7)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Histogram"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1HistogramTest()
    {
        Assert.That(CLSID_D2D1Histogram, Is.EqualTo(new Guid(0x881db7d0, 0xf7ee, 0x4d4d, 0xa6, 0xd2, 0x46, 0x97, 0xac, 0xc6, 0x6e, 0xe8)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1HueRotation"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1HueRotationTest()
    {
        Assert.That(CLSID_D2D1HueRotation, Is.EqualTo(new Guid(0x0f4458ec, 0x4b32, 0x491b, 0x9e, 0x85, 0xbd, 0x73, 0xf4, 0x4d, 0x3e, 0xb6)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1LinearTransfer"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1LinearTransferTest()
    {
        Assert.That(CLSID_D2D1LinearTransfer, Is.EqualTo(new Guid(0xad47c8fd, 0x63ef, 0x4acc, 0x9b, 0x51, 0x67, 0x97, 0x9c, 0x03, 0x6c, 0x06)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1LuminanceToAlpha"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1LuminanceToAlphaTest()
    {
        Assert.That(CLSID_D2D1LuminanceToAlpha, Is.EqualTo(new Guid(0x41251ab7, 0x0beb, 0x46f8, 0x9d, 0xa7, 0x59, 0xe9, 0x3f, 0xcc, 0xe5, 0xde)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Morphology"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1MorphologyTest()
    {
        Assert.That(CLSID_D2D1Morphology, Is.EqualTo(new Guid(0xeae6c40d, 0x626a, 0x4c2d, 0xbf, 0xcb, 0x39, 0x10, 0x01, 0xab, 0xe2, 0x02)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1OpacityMetadata"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1OpacityMetadataTest()
    {
        Assert.That(CLSID_D2D1OpacityMetadata, Is.EqualTo(new Guid(0x6c53006a, 0x4450, 0x4199, 0xaa, 0x5b, 0xad, 0x16, 0x56, 0xfe, 0xce, 0x5e)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1PointDiffuse"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1PointDiffuseTest()
    {
        Assert.That(CLSID_D2D1PointDiffuse, Is.EqualTo(new Guid(0xb9e303c3, 0xc08c, 0x4f91, 0x8b, 0x7b, 0x38, 0x65, 0x6b, 0xc4, 0x8c, 0x20)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1PointSpecular"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1PointSpecularTest()
    {
        Assert.That(CLSID_D2D1PointSpecular, Is.EqualTo(new Guid(0x09c3ca26, 0x3ae2, 0x4f09, 0x9e, 0xbc, 0xed, 0x38, 0x65, 0xd5, 0x3f, 0x22)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Premultiply"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1PremultiplyTest()
    {
        Assert.That(CLSID_D2D1Premultiply, Is.EqualTo(new Guid(0x06eab419, 0xdeed, 0x4018, 0x80, 0xd2, 0x3e, 0x1d, 0x47, 0x1a, 0xde, 0xb2)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Saturation"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1SaturationTest()
    {
        Assert.That(CLSID_D2D1Saturation, Is.EqualTo(new Guid(0x5cb2d9cf, 0x327d, 0x459f, 0xa0, 0xce, 0x40, 0xc0, 0xb2, 0x08, 0x6b, 0xf7)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Shadow"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1ShadowTest()
    {
        Assert.That(CLSID_D2D1Shadow, Is.EqualTo(new Guid(0xC67EA361, 0x1863, 0x4e69, 0x89, 0xDB, 0x69, 0x5D, 0x3E, 0x9A, 0x5B, 0x6B)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1SpotDiffuse"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1SpotDiffuseTest()
    {
        Assert.That(CLSID_D2D1SpotDiffuse, Is.EqualTo(new Guid(0x818a1105, 0x7932, 0x44f4, 0xaa, 0x86, 0x08, 0xae, 0x7b, 0x2f, 0x2c, 0x93)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1SpotSpecular"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1SpotSpecularTest()
    {
        Assert.That(CLSID_D2D1SpotSpecular, Is.EqualTo(new Guid(0xedae421e, 0x7654, 0x4a37, 0x9d, 0xb8, 0x71, 0xac, 0xc1, 0xbe, 0xb3, 0xc1)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1TableTransfer"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1TableTransferTest()
    {
        Assert.That(CLSID_D2D1TableTransfer, Is.EqualTo(new Guid(0x5bf818c3, 0x5e43, 0x48cb, 0xb6, 0x31, 0x86, 0x83, 0x96, 0xd6, 0xa1, 0xd4)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Tile"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1TileTest()
    {
        Assert.That(CLSID_D2D1Tile, Is.EqualTo(new Guid(0xB0784138, 0x3B76, 0x4bc5, 0xB1, 0x3B, 0x0F, 0xA2, 0xAD, 0x02, 0x65, 0x9F)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1Turbulence"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1TurbulenceTest()
    {
        Assert.That(CLSID_D2D1Turbulence, Is.EqualTo(new Guid(0xCF2BB6AE, 0x889A, 0x4ad7, 0xBA, 0x29, 0xA2, 0xFD, 0x73, 0x2C, 0x9F, 0xC9)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D2D1UnPremultiply"/> property is correct.</summary>
    [Test]
    public static void CLSID_D2D1UnPremultiplyTest()
    {
        Assert.That(CLSID_D2D1UnPremultiply, Is.EqualTo(new Guid(0xfb9ac489, 0xad8d, 0x41ed, 0x99, 0x99, 0xbb, 0x63, 0x47, 0xd1, 0x10, 0xf7)));
    }
}