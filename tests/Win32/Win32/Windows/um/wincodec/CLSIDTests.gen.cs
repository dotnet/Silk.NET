// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_WICImagingFactory1"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICImagingFactory1Test()
    {
        Assert.That(
            CLSID_WICImagingFactory1,
            Is.EqualTo(
                new Guid(0xcacaf262, 0x9370, 0x4615, 0xa1, 0x3b, 0x9f, 0x55, 0x39, 0xda, 0x4c, 0xa)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICImagingFactory2"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICImagingFactory2Test()
    {
        Assert.That(
            CLSID_WICImagingFactory2,
            Is.EqualTo(
                new Guid(0x317d06e8, 0x5f24, 0x433d, 0xbd, 0xf7, 0x79, 0xce, 0x68, 0xd8, 0xab, 0xc2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngDecoder1"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICPngDecoder1Test()
    {
        Assert.That(
            CLSID_WICPngDecoder1,
            Is.EqualTo(
                new Guid(0x389ea17b, 0x5078, 0x4cde, 0xb6, 0xef, 0x25, 0xc1, 0x51, 0x75, 0xc7, 0x51)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngDecoder2"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICPngDecoder2Test()
    {
        Assert.That(
            CLSID_WICPngDecoder2,
            Is.EqualTo(
                new Guid(0xe018945b, 0xaa86, 0x4008, 0x9b, 0xd4, 0x67, 0x77, 0xa1, 0xe4, 0x0c, 0x11)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICBmpDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICBmpDecoderTest()
    {
        Assert.That(
            CLSID_WICBmpDecoder,
            Is.EqualTo(
                new Guid(0x6b462062, 0x7cbf, 0x400d, 0x9f, 0xdb, 0x81, 0x3d, 0xd1, 0x0f, 0x27, 0x78)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICIcoDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICIcoDecoderTest()
    {
        Assert.That(
            CLSID_WICIcoDecoder,
            Is.EqualTo(
                new Guid(0xc61bfcdf, 0x2e0f, 0x4aad, 0xa8, 0xd7, 0xe0, 0x6b, 0xaf, 0xeb, 0xcd, 0xfe)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICJpegDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICJpegDecoderTest()
    {
        Assert.That(
            CLSID_WICJpegDecoder,
            Is.EqualTo(
                new Guid(0x9456a480, 0xe88b, 0x43ea, 0x9e, 0x73, 0x0b, 0x2d, 0x9b, 0x71, 0xb1, 0xca)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICGifDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICGifDecoderTest()
    {
        Assert.That(
            CLSID_WICGifDecoder,
            Is.EqualTo(
                new Guid(0x381dda3c, 0x9ce9, 0x4834, 0xa2, 0x3e, 0x1f, 0x98, 0xf8, 0xfc, 0x52, 0xbe)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICTiffDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICTiffDecoderTest()
    {
        Assert.That(
            CLSID_WICTiffDecoder,
            Is.EqualTo(
                new Guid(0xb54e85d9, 0xfe23, 0x499f, 0x8b, 0x88, 0x6a, 0xce, 0xa7, 0x13, 0x75, 0x2b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICWmpDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICWmpDecoderTest()
    {
        Assert.That(
            CLSID_WICWmpDecoder,
            Is.EqualTo(
                new Guid(0xa26cec36, 0x234c, 0x4950, 0xae, 0x16, 0xe3, 0x4a, 0xac, 0xe7, 0x1d, 0x0d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICDdsDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICDdsDecoderTest()
    {
        Assert.That(
            CLSID_WICDdsDecoder,
            Is.EqualTo(
                new Guid(0x9053699f, 0xa341, 0x429d, 0x9e, 0x90, 0xee, 0x43, 0x7c, 0xf8, 0x0c, 0x73)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICBmpEncoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICBmpEncoderTest()
    {
        Assert.That(
            CLSID_WICBmpEncoder,
            Is.EqualTo(
                new Guid(0x69be8bb4, 0xd66d, 0x47c8, 0x86, 0x5a, 0xed, 0x15, 0x89, 0x43, 0x37, 0x82)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngEncoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICPngEncoderTest()
    {
        Assert.That(
            CLSID_WICPngEncoder,
            Is.EqualTo(
                new Guid(0x27949969, 0x876a, 0x41d7, 0x94, 0x47, 0x56, 0x8f, 0x6a, 0x35, 0xa4, 0xdc)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICJpegEncoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICJpegEncoderTest()
    {
        Assert.That(
            CLSID_WICJpegEncoder,
            Is.EqualTo(
                new Guid(0x1a34f5c1, 0x4a5a, 0x46dc, 0xb6, 0x44, 0x1f, 0x45, 0x67, 0xe7, 0xa6, 0x76)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICGifEncoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICGifEncoderTest()
    {
        Assert.That(
            CLSID_WICGifEncoder,
            Is.EqualTo(
                new Guid(0x114f5598, 0x0b22, 0x40a0, 0x86, 0xa1, 0xc8, 0x3e, 0xa4, 0x95, 0xad, 0xbd)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICTiffEncoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICTiffEncoderTest()
    {
        Assert.That(
            CLSID_WICTiffEncoder,
            Is.EqualTo(
                new Guid(0x0131be10, 0x2001, 0x4c5f, 0xa9, 0xb0, 0xcc, 0x88, 0xfa, 0xb6, 0x4c, 0xe8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICWmpEncoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICWmpEncoderTest()
    {
        Assert.That(
            CLSID_WICWmpEncoder,
            Is.EqualTo(
                new Guid(0xac4ce3cb, 0xe1c1, 0x44cd, 0x82, 0x15, 0x5a, 0x16, 0x65, 0x50, 0x9e, 0xc2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICDdsEncoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICDdsEncoderTest()
    {
        Assert.That(
            CLSID_WICDdsEncoder,
            Is.EqualTo(
                new Guid(0xa61dde94, 0x66ce, 0x4ac1, 0x88, 0x1b, 0x71, 0x68, 0x05, 0x88, 0x89, 0x5e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICAdngDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICAdngDecoderTest()
    {
        Assert.That(
            CLSID_WICAdngDecoder,
            Is.EqualTo(
                new Guid(0x981d9411, 0x909e, 0x42a7, 0x8f, 0x5d, 0xa7, 0x47, 0xff, 0x05, 0x2e, 0xdb)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICJpegQualcommPhoneEncoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICJpegQualcommPhoneEncoderTest()
    {
        Assert.That(
            CLSID_WICJpegQualcommPhoneEncoder,
            Is.EqualTo(
                new Guid(0x68ed5c62, 0xf534, 0x4979, 0xb2, 0xb3, 0x68, 0x6a, 0x12, 0xb2, 0xb3, 0x4c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICHeifDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICHeifDecoderTest()
    {
        Assert.That(
            CLSID_WICHeifDecoder,
            Is.EqualTo(
                new Guid(0xe9A4A80a, 0x44fe, 0x4DE4, 0x89, 0x71, 0x71, 0x50, 0XB1, 0X0a, 0X51, 0X99)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICHeifEncoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICHeifEncoderTest()
    {
        Assert.That(
            CLSID_WICHeifEncoder,
            Is.EqualTo(
                new Guid(0x0dbecec1, 0x9eb3, 0x4860, 0x9c, 0x6f, 0xdd, 0xbe, 0x86, 0x63, 0x45, 0x75)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICWebpDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICWebpDecoderTest()
    {
        Assert.That(
            CLSID_WICWebpDecoder,
            Is.EqualTo(
                new Guid(0x7693E886, 0x51C9, 0x4070, 0x84, 0x19, 0x9F, 0x70, 0X73, 0X8E, 0XC8, 0XFA)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICRAWDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICRAWDecoderTest()
    {
        Assert.That(
            CLSID_WICRAWDecoder,
            Is.EqualTo(
                new Guid(0x41945702, 0x8302, 0x44A6, 0x94, 0x45, 0xAC, 0x98, 0xE8, 0xAF, 0xA0, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICJpegXLDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICJpegXLDecoderTest()
    {
        Assert.That(
            CLSID_WICJpegXLDecoder,
            Is.EqualTo(
                new Guid(0xfc6ceece, 0xaef5, 0x4a23, 0x96, 0xec, 0x59, 0x84, 0xff, 0xb4, 0x86, 0xd9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICJpegXLEncoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICJpegXLEncoderTest()
    {
        Assert.That(
            CLSID_WICJpegXLEncoder,
            Is.EqualTo(
                new Guid(0x0e4ecd3b, 0x1ba6, 0x4636, 0x81, 0x98, 0x56, 0xc7, 0x30, 0x40, 0x96, 0x4a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICImagingCategories"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICImagingCategoriesTest()
    {
        Assert.That(
            CLSID_WICImagingCategories,
            Is.EqualTo(
                new Guid(0xfae3d380, 0xfea4, 0x4623, 0x8c, 0x75, 0xc6, 0xb6, 0x11, 0x10, 0xb6, 0x81)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICDefaultFormatConverter"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICDefaultFormatConverterTest()
    {
        Assert.That(
            CLSID_WICDefaultFormatConverter,
            Is.EqualTo(
                new Guid(0x1a3f11dc, 0xb514, 0x4b17, 0x8c, 0x5f, 0x21, 0x54, 0x51, 0x38, 0x52, 0xf1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICFormatConverterHighColor"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICFormatConverterHighColorTest()
    {
        Assert.That(
            CLSID_WICFormatConverterHighColor,
            Is.EqualTo(
                new Guid(0xac75d454, 0x9f37, 0x48f8, 0xb9, 0x72, 0x4e, 0x19, 0xbc, 0x85, 0x60, 0x11)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICFormatConverterNChannel"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICFormatConverterNChannelTest()
    {
        Assert.That(
            CLSID_WICFormatConverterNChannel,
            Is.EqualTo(
                new Guid(0xc17cabb2, 0xd4a3, 0x47d7, 0xa5, 0x57, 0x33, 0x9b, 0x2e, 0xfb, 0xd4, 0xf1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICFormatConverterWMPhoto"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICFormatConverterWMPhotoTest()
    {
        Assert.That(
            CLSID_WICFormatConverterWMPhoto,
            Is.EqualTo(
                new Guid(0x9cb5172b, 0xd600, 0x46ba, 0xab, 0x77, 0x77, 0xbb, 0x7e, 0x3a, 0x00, 0xd9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPlanarFormatConverter"/> property is correct.</summary>

    [Test]
    public static void CLSID_WICPlanarFormatConverterTest()
    {
        Assert.That(
            CLSID_WICPlanarFormatConverter,
            Is.EqualTo(
                new Guid(0x184132b8, 0x32f8, 0x4784, 0x91, 0x31, 0xdd, 0x72, 0x24, 0xb2, 0x34, 0x38)
            )
        );
    }
}
