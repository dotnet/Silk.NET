// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Gdiplus.Gdiplus;

namespace Silk.NET.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "Gdiplus"/> class.</summary>
public static partial class GdiplusTests
{
    /// <summary>Validates that the value of the <see cref = "ImageFormatUndefined"/> property is correct.</summary>
    [Test]
    public static void ImageFormatUndefinedTest()
    {
        Assert.That(ImageFormatUndefined, Is.EqualTo(new Guid(0xb96b3ca9, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "ImageFormatMemoryBMP"/> property is correct.</summary>
    [Test]
    public static void ImageFormatMemoryBMPTest()
    {
        Assert.That(ImageFormatMemoryBMP, Is.EqualTo(new Guid(0xb96b3caa, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "ImageFormatBMP"/> property is correct.</summary>
    [Test]
    public static void ImageFormatBMPTest()
    {
        Assert.That(ImageFormatBMP, Is.EqualTo(new Guid(0xb96b3cab, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "ImageFormatEMF"/> property is correct.</summary>
    [Test]
    public static void ImageFormatEMFTest()
    {
        Assert.That(ImageFormatEMF, Is.EqualTo(new Guid(0xb96b3cac, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "ImageFormatWMF"/> property is correct.</summary>
    [Test]
    public static void ImageFormatWMFTest()
    {
        Assert.That(ImageFormatWMF, Is.EqualTo(new Guid(0xb96b3cad, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "ImageFormatJPEG"/> property is correct.</summary>
    [Test]
    public static void ImageFormatJPEGTest()
    {
        Assert.That(ImageFormatJPEG, Is.EqualTo(new Guid(0xb96b3cae, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "ImageFormatPNG"/> property is correct.</summary>
    [Test]
    public static void ImageFormatPNGTest()
    {
        Assert.That(ImageFormatPNG, Is.EqualTo(new Guid(0xb96b3caf, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "ImageFormatGIF"/> property is correct.</summary>
    [Test]
    public static void ImageFormatGIFTest()
    {
        Assert.That(ImageFormatGIF, Is.EqualTo(new Guid(0xb96b3cb0, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "ImageFormatTIFF"/> property is correct.</summary>
    [Test]
    public static void ImageFormatTIFFTest()
    {
        Assert.That(ImageFormatTIFF, Is.EqualTo(new Guid(0xb96b3cb1, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "ImageFormatEXIF"/> property is correct.</summary>
    [Test]
    public static void ImageFormatEXIFTest()
    {
        Assert.That(ImageFormatEXIF, Is.EqualTo(new Guid(0xb96b3cb2, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "ImageFormatIcon"/> property is correct.</summary>
    [Test]
    public static void ImageFormatIconTest()
    {
        Assert.That(ImageFormatIcon, Is.EqualTo(new Guid(0xb96b3cb5, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "ImageFormatHEIF"/> property is correct.</summary>
    [Test]
    public static void ImageFormatHEIFTest()
    {
        Assert.That(ImageFormatHEIF, Is.EqualTo(new Guid(0xb96b3cb6, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "ImageFormatWEBP"/> property is correct.</summary>
    [Test]
    public static void ImageFormatWEBPTest()
    {
        Assert.That(ImageFormatWEBP, Is.EqualTo(new Guid(0xb96b3cb7, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "FrameDimensionTime"/> property is correct.</summary>
    [Test]
    public static void FrameDimensionTimeTest()
    {
        Assert.That(FrameDimensionTime, Is.EqualTo(new Guid(0x6aedbd6d, 0x3fb5, 0x418a, 0x83, 0xa6, 0x7f, 0x45, 0x22, 0x9d, 0xc8, 0x72)));
    }

    /// <summary>Validates that the value of the <see cref = "FrameDimensionResolution"/> property is correct.</summary>
    [Test]
    public static void FrameDimensionResolutionTest()
    {
        Assert.That(FrameDimensionResolution, Is.EqualTo(new Guid(0x84236f7b, 0x3bd3, 0x428f, 0x8d, 0xab, 0x4e, 0xa1, 0x43, 0x9c, 0xa3, 0x15)));
    }

    /// <summary>Validates that the value of the <see cref = "FrameDimensionPage"/> property is correct.</summary>
    [Test]
    public static void FrameDimensionPageTest()
    {
        Assert.That(FrameDimensionPage, Is.EqualTo(new Guid(0x7462dc86, 0x6180, 0x4c7e, 0x8e, 0x3f, 0xee, 0x73, 0x33, 0xa7, 0xa4, 0x83)));
    }

    /// <summary>Validates that the value of the <see cref = "FormatIDImageInformation"/> property is correct.</summary>
    [Test]
    public static void FormatIDImageInformationTest()
    {
        Assert.That(FormatIDImageInformation, Is.EqualTo(new Guid(0xe5836cbe, 0x5eef, 0x4f1d, 0xac, 0xde, 0xae, 0x4c, 0x43, 0xb6, 0x08, 0xce)));
    }

    /// <summary>Validates that the value of the <see cref = "FormatIDJpegAppHeaders"/> property is correct.</summary>
    [Test]
    public static void FormatIDJpegAppHeadersTest()
    {
        Assert.That(FormatIDJpegAppHeaders, Is.EqualTo(new Guid(0x1c4afdcd, 0x6177, 0x43cf, 0xab, 0xc7, 0x5f, 0x51, 0xaf, 0x39, 0xee, 0x85)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderCompression"/> property is correct.</summary>
    [Test]
    public static void EncoderCompressionTest()
    {
        Assert.That(EncoderCompression, Is.EqualTo(new Guid(0xe09d739d, 0xccd4, 0x44ee, 0x8e, 0xba, 0x3f, 0xbf, 0x8b, 0xe4, 0xfc, 0x58)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderColorDepth"/> property is correct.</summary>
    [Test]
    public static void EncoderColorDepthTest()
    {
        Assert.That(EncoderColorDepth, Is.EqualTo(new Guid(0x66087055, 0xad66, 0x4c7c, 0x9a, 0x18, 0x38, 0xa2, 0x31, 0x0b, 0x83, 0x37)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderScanMethod"/> property is correct.</summary>
    [Test]
    public static void EncoderScanMethodTest()
    {
        Assert.That(EncoderScanMethod, Is.EqualTo(new Guid(0x3a4e2661, 0x3109, 0x4e56, 0x85, 0x36, 0x42, 0xc1, 0x56, 0xe7, 0xdc, 0xfa)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderVersion"/> property is correct.</summary>
    [Test]
    public static void EncoderVersionTest()
    {
        Assert.That(EncoderVersion, Is.EqualTo(new Guid(0x24d18c76, 0x814a, 0x41a4, 0xbf, 0x53, 0x1c, 0x21, 0x9c, 0xcc, 0xf7, 0x97)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderRenderMethod"/> property is correct.</summary>
    [Test]
    public static void EncoderRenderMethodTest()
    {
        Assert.That(EncoderRenderMethod, Is.EqualTo(new Guid(0x6d42c53a, 0x229a, 0x4825, 0x8b, 0xb7, 0x5c, 0x99, 0xe2, 0xb9, 0xa8, 0xb8)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderQuality"/> property is correct.</summary>
    [Test]
    public static void EncoderQualityTest()
    {
        Assert.That(EncoderQuality, Is.EqualTo(new Guid(0x1d5be4b5, 0xfa4a, 0x452d, 0x9c, 0xdd, 0x5d, 0xb3, 0x51, 0x05, 0xe7, 0xeb)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderTransformation"/> property is correct.</summary>
    [Test]
    public static void EncoderTransformationTest()
    {
        Assert.That(EncoderTransformation, Is.EqualTo(new Guid(0x8d0eb2d1, 0xa58e, 0x4ea8, 0xaa, 0x14, 0x10, 0x80, 0x74, 0xb7, 0xb6, 0xf9)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderLuminanceTable"/> property is correct.</summary>
    [Test]
    public static void EncoderLuminanceTableTest()
    {
        Assert.That(EncoderLuminanceTable, Is.EqualTo(new Guid(0xedb33bce, 0x0266, 0x4a77, 0xb9, 0x04, 0x27, 0x21, 0x60, 0x99, 0xe7, 0x17)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderChrominanceTable"/> property is correct.</summary>
    [Test]
    public static void EncoderChrominanceTableTest()
    {
        Assert.That(EncoderChrominanceTable, Is.EqualTo(new Guid(0xf2e455dc, 0x09b3, 0x4316, 0x82, 0x60, 0x67, 0x6a, 0xda, 0x32, 0x48, 0x1c)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderSaveFlag"/> property is correct.</summary>
    [Test]
    public static void EncoderSaveFlagTest()
    {
        Assert.That(EncoderSaveFlag, Is.EqualTo(new Guid(0x292266fc, 0xac40, 0x47bf, 0x8c, 0xfc, 0xa8, 0x5b, 0x89, 0xa6, 0x55, 0xde)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderColorSpace"/> property is correct.</summary>
    [Test]
    public static void EncoderColorSpaceTest()
    {
        Assert.That(EncoderColorSpace, Is.EqualTo(new Guid(0xae7a62a0, 0xee2c, 0x49d8, 0x9d, 0x7, 0x1b, 0xa8, 0xa9, 0x27, 0x59, 0x6e)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderImageItems"/> property is correct.</summary>
    [Test]
    public static void EncoderImageItemsTest()
    {
        Assert.That(EncoderImageItems, Is.EqualTo(new Guid(0x63875e13, 0x1f1d, 0x45ab, 0x91, 0x95, 0xa2, 0x9b, 0x60, 0x66, 0xa6, 0x50)));
    }

    /// <summary>Validates that the value of the <see cref = "EncoderSaveAsCMYK"/> property is correct.</summary>
    [Test]
    public static void EncoderSaveAsCMYKTest()
    {
        Assert.That(EncoderSaveAsCMYK, Is.EqualTo(new Guid(0xa219bbc9, 0xa9d, 0x4005, 0xa3, 0xee, 0x3a, 0x42, 0x1b, 0x8b, 0xb0, 0x6c)));
    }

    /// <summary>Validates that the value of the <see cref = "CodecIImageBytes"/> property is correct.</summary>
    [Test]
    public static void CodecIImageBytesTest()
    {
        Assert.That(CodecIImageBytes, Is.EqualTo(new Guid(0x025d1823, 0x6c7d, 0x447b, 0xbb, 0xdb, 0xa3, 0xcb, 0xc3, 0xdf, 0xa2, 0xfc)));
    }
}