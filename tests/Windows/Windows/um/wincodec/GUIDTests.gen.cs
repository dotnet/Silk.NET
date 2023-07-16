// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.GUID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "GUID"/> class.</summary>
public static partial class GUIDTests
{
    /// <summary>Validates that the value of the <see cref = "GUID_VendorMicrosoft"/> property is correct.</summary>
    [Test]
    public static void GUID_VendorMicrosoftTest()
    {
        Assert.That(GUID_VendorMicrosoft, Is.EqualTo(new Guid(0xf0e749ca, 0xedef, 0x4589, 0xa7, 0x3a, 0xee, 0xe, 0x62, 0x6a, 0x2a, 0x2b)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_VendorMicrosoftBuiltIn"/> property is correct.</summary>
    [Test]
    public static void GUID_VendorMicrosoftBuiltInTest()
    {
        Assert.That(GUID_VendorMicrosoftBuiltIn, Is.EqualTo(new Guid(0x257a30fd, 0x6b6, 0x462b, 0xae, 0xa4, 0x63, 0xf7, 0xb, 0x86, 0xe5, 0x33)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ContainerFormatBmp"/> property is correct.</summary>
    [Test]
    public static void GUID_ContainerFormatBmpTest()
    {
        Assert.That(GUID_ContainerFormatBmp, Is.EqualTo(new Guid(0x0af1d87e, 0xfcfe, 0x4188, 0xbd, 0xeb, 0xa7, 0x90, 0x64, 0x71, 0xcb, 0xe3)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ContainerFormatPng"/> property is correct.</summary>
    [Test]
    public static void GUID_ContainerFormatPngTest()
    {
        Assert.That(GUID_ContainerFormatPng, Is.EqualTo(new Guid(0x1b7cfaf4, 0x713f, 0x473c, 0xbb, 0xcd, 0x61, 0x37, 0x42, 0x5f, 0xae, 0xaf)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ContainerFormatIco"/> property is correct.</summary>
    [Test]
    public static void GUID_ContainerFormatIcoTest()
    {
        Assert.That(GUID_ContainerFormatIco, Is.EqualTo(new Guid(0xa3a860c4, 0x338f, 0x4c17, 0x91, 0x9a, 0xfb, 0xa4, 0xb5, 0x62, 0x8f, 0x21)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ContainerFormatJpeg"/> property is correct.</summary>
    [Test]
    public static void GUID_ContainerFormatJpegTest()
    {
        Assert.That(GUID_ContainerFormatJpeg, Is.EqualTo(new Guid(0x19e4a5aa, 0x5662, 0x4fc5, 0xa0, 0xc0, 0x17, 0x58, 0x02, 0x8e, 0x10, 0x57)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ContainerFormatTiff"/> property is correct.</summary>
    [Test]
    public static void GUID_ContainerFormatTiffTest()
    {
        Assert.That(GUID_ContainerFormatTiff, Is.EqualTo(new Guid(0x163bcc30, 0xe2e9, 0x4f0b, 0x96, 0x1d, 0xa3, 0xe9, 0xfd, 0xb7, 0x88, 0xa3)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ContainerFormatGif"/> property is correct.</summary>
    [Test]
    public static void GUID_ContainerFormatGifTest()
    {
        Assert.That(GUID_ContainerFormatGif, Is.EqualTo(new Guid(0x1f8a5601, 0x7d4d, 0x4cbd, 0x9c, 0x82, 0x1b, 0xc8, 0xd4, 0xee, 0xb9, 0xa5)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ContainerFormatWmp"/> property is correct.</summary>
    [Test]
    public static void GUID_ContainerFormatWmpTest()
    {
        Assert.That(GUID_ContainerFormatWmp, Is.EqualTo(new Guid(0x57a37caa, 0x367a, 0x4540, 0x91, 0x6b, 0xf1, 0x83, 0xc5, 0x09, 0x3a, 0x4b)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ContainerFormatDds"/> property is correct.</summary>
    [Test]
    public static void GUID_ContainerFormatDdsTest()
    {
        Assert.That(GUID_ContainerFormatDds, Is.EqualTo(new Guid(0x9967cb95, 0x2e85, 0x4ac8, 0x8c, 0xa2, 0x83, 0xd7, 0xcc, 0xd4, 0x25, 0xc9)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ContainerFormatAdng"/> property is correct.</summary>
    [Test]
    public static void GUID_ContainerFormatAdngTest()
    {
        Assert.That(GUID_ContainerFormatAdng, Is.EqualTo(new Guid(0xf3ff6d0d, 0x38c0, 0x41c4, 0xb1, 0xfe, 0x1f, 0x38, 0x24, 0xf1, 0x7b, 0x84)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ContainerFormatHeif"/> property is correct.</summary>
    [Test]
    public static void GUID_ContainerFormatHeifTest()
    {
        Assert.That(GUID_ContainerFormatHeif, Is.EqualTo(new Guid(0xe1e62521, 0x6787, 0x405b, 0xa3, 0x39, 0x50, 0x07, 0x15, 0xb5, 0x76, 0x3f)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ContainerFormatWebp"/> property is correct.</summary>
    [Test]
    public static void GUID_ContainerFormatWebpTest()
    {
        Assert.That(GUID_ContainerFormatWebp, Is.EqualTo(new Guid(0xe094b0e2, 0x67f2, 0x45b3, 0xb0, 0xea, 0x11, 0x53, 0x37, 0xca, 0x7c, 0xf3)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ContainerFormatRaw"/> property is correct.</summary>
    [Test]
    public static void GUID_ContainerFormatRawTest()
    {
        Assert.That(GUID_ContainerFormatRaw, Is.EqualTo(new Guid(0xfe99ce60, 0xf19c, 0x433c, 0xa3, 0xae, 0x00, 0xac, 0xef, 0xa9, 0xca, 0x21)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormatDontCare"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormatDontCareTest()
    {
        Assert.That(GUID_WICPixelFormatDontCare, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat1bppIndexed"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat1bppIndexedTest()
    {
        Assert.That(GUID_WICPixelFormat1bppIndexed, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x01)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat2bppIndexed"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat2bppIndexedTest()
    {
        Assert.That(GUID_WICPixelFormat2bppIndexed, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x02)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat4bppIndexed"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat4bppIndexedTest()
    {
        Assert.That(GUID_WICPixelFormat4bppIndexed, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x03)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat8bppIndexed"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat8bppIndexedTest()
    {
        Assert.That(GUID_WICPixelFormat8bppIndexed, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x04)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormatBlackWhite"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormatBlackWhiteTest()
    {
        Assert.That(GUID_WICPixelFormatBlackWhite, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x05)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat2bppGray"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat2bppGrayTest()
    {
        Assert.That(GUID_WICPixelFormat2bppGray, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x06)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat4bppGray"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat4bppGrayTest()
    {
        Assert.That(GUID_WICPixelFormat4bppGray, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x07)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat8bppGray"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat8bppGrayTest()
    {
        Assert.That(GUID_WICPixelFormat8bppGray, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x08)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat8bppAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat8bppAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat8bppAlpha, Is.EqualTo(new Guid(0xe6cd0116, 0xeeba, 0x4161, 0xaa, 0x85, 0x27, 0xdd, 0x9f, 0xb3, 0xa8, 0x95)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat16bppBGR555"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat16bppBGR555Test()
    {
        Assert.That(GUID_WICPixelFormat16bppBGR555, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x09)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat16bppBGR565"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat16bppBGR565Test()
    {
        Assert.That(GUID_WICPixelFormat16bppBGR565, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0a)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat16bppBGRA5551"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat16bppBGRA5551Test()
    {
        Assert.That(GUID_WICPixelFormat16bppBGRA5551, Is.EqualTo(new Guid(0x05ec7c2b, 0xf1e6, 0x4961, 0xad, 0x46, 0xe1, 0xcc, 0x81, 0x0a, 0x87, 0xd2)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat16bppGray"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat16bppGrayTest()
    {
        Assert.That(GUID_WICPixelFormat16bppGray, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0b)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat24bppBGR"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat24bppBGRTest()
    {
        Assert.That(GUID_WICPixelFormat24bppBGR, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0c)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat24bppRGB"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat24bppRGBTest()
    {
        Assert.That(GUID_WICPixelFormat24bppRGB, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0d)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppBGR"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppBGRTest()
    {
        Assert.That(GUID_WICPixelFormat32bppBGR, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0e)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppBGRA"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppBGRATest()
    {
        Assert.That(GUID_WICPixelFormat32bppBGRA, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x0f)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppPBGRA"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppPBGRATest()
    {
        Assert.That(GUID_WICPixelFormat32bppPBGRA, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x10)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppGrayFloat"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppGrayFloatTest()
    {
        Assert.That(GUID_WICPixelFormat32bppGrayFloat, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x11)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppRGB"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppRGBTest()
    {
        Assert.That(GUID_WICPixelFormat32bppRGB, Is.EqualTo(new Guid(0xd98c6b95, 0x3efe, 0x47d6, 0xbb, 0x25, 0xeb, 0x17, 0x48, 0xab, 0x0c, 0xf1)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppRGBA"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppRGBATest()
    {
        Assert.That(GUID_WICPixelFormat32bppRGBA, Is.EqualTo(new Guid(0xf5c7ad2d, 0x6a8d, 0x43dd, 0xa7, 0xa8, 0xa2, 0x99, 0x35, 0x26, 0x1a, 0xe9)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppPRGBA"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppPRGBATest()
    {
        Assert.That(GUID_WICPixelFormat32bppPRGBA, Is.EqualTo(new Guid(0x3cc4a650, 0xa527, 0x4d37, 0xa9, 0x16, 0x31, 0x42, 0xc7, 0xeb, 0xed, 0xba)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat48bppRGB"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat48bppRGBTest()
    {
        Assert.That(GUID_WICPixelFormat48bppRGB, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x15)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat48bppBGR"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat48bppBGRTest()
    {
        Assert.That(GUID_WICPixelFormat48bppBGR, Is.EqualTo(new Guid(0xe605a384, 0xb468, 0x46ce, 0xbb, 0x2e, 0x36, 0xf1, 0x80, 0xe6, 0x43, 0x13)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bppRGB"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bppRGBTest()
    {
        Assert.That(GUID_WICPixelFormat64bppRGB, Is.EqualTo(new Guid(0xa1182111, 0x186d, 0x4d42, 0xbc, 0x6a, 0x9c, 0x83, 0x03, 0xa8, 0xdf, 0xf9)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bppRGBA"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bppRGBATest()
    {
        Assert.That(GUID_WICPixelFormat64bppRGBA, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x16)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bppBGRA"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bppBGRATest()
    {
        Assert.That(GUID_WICPixelFormat64bppBGRA, Is.EqualTo(new Guid(0x1562ff7c, 0xd352, 0x46f9, 0x97, 0x9e, 0x42, 0x97, 0x6b, 0x79, 0x22, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bppPRGBA"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bppPRGBATest()
    {
        Assert.That(GUID_WICPixelFormat64bppPRGBA, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x17)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bppPBGRA"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bppPBGRATest()
    {
        Assert.That(GUID_WICPixelFormat64bppPBGRA, Is.EqualTo(new Guid(0x8c518e8e, 0xa4ec, 0x468b, 0xae, 0x70, 0xc9, 0xa3, 0x5a, 0x9c, 0x55, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat16bppGrayFixedPoint"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat16bppGrayFixedPointTest()
    {
        Assert.That(GUID_WICPixelFormat16bppGrayFixedPoint, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x13)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppBGR101010"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppBGR101010Test()
    {
        Assert.That(GUID_WICPixelFormat32bppBGR101010, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x14)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat48bppRGBFixedPoint"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat48bppRGBFixedPointTest()
    {
        Assert.That(GUID_WICPixelFormat48bppRGBFixedPoint, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x12)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat48bppBGRFixedPoint"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat48bppBGRFixedPointTest()
    {
        Assert.That(GUID_WICPixelFormat48bppBGRFixedPoint, Is.EqualTo(new Guid(0x49ca140e, 0xcab6, 0x493b, 0x9d, 0xdf, 0x60, 0x18, 0x7c, 0x37, 0x53, 0x2a)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat96bppRGBFixedPoint"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat96bppRGBFixedPointTest()
    {
        Assert.That(GUID_WICPixelFormat96bppRGBFixedPoint, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x18)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat96bppRGBFloat"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat96bppRGBFloatTest()
    {
        Assert.That(GUID_WICPixelFormat96bppRGBFloat, Is.EqualTo(new Guid(0xe3fed78f, 0xe8db, 0x4acf, 0x84, 0xc1, 0xe9, 0x7f, 0x61, 0x36, 0xb3, 0x27)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat128bppRGBAFloat"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat128bppRGBAFloatTest()
    {
        Assert.That(GUID_WICPixelFormat128bppRGBAFloat, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x19)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat128bppPRGBAFloat"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat128bppPRGBAFloatTest()
    {
        Assert.That(GUID_WICPixelFormat128bppPRGBAFloat, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1a)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat128bppRGBFloat"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat128bppRGBFloatTest()
    {
        Assert.That(GUID_WICPixelFormat128bppRGBFloat, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1b)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppCMYK"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppCMYKTest()
    {
        Assert.That(GUID_WICPixelFormat32bppCMYK, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1c)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bppRGBAFixedPoint"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bppRGBAFixedPointTest()
    {
        Assert.That(GUID_WICPixelFormat64bppRGBAFixedPoint, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1d)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bppBGRAFixedPoint"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bppBGRAFixedPointTest()
    {
        Assert.That(GUID_WICPixelFormat64bppBGRAFixedPoint, Is.EqualTo(new Guid(0x356de33c, 0x54d2, 0x4a23, 0xbb, 0x4, 0x9b, 0x7b, 0xf9, 0xb1, 0xd4, 0x2d)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bppRGBFixedPoint"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bppRGBFixedPointTest()
    {
        Assert.That(GUID_WICPixelFormat64bppRGBFixedPoint, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x40)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat128bppRGBAFixedPoint"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat128bppRGBAFixedPointTest()
    {
        Assert.That(GUID_WICPixelFormat128bppRGBAFixedPoint, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1e)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat128bppRGBFixedPoint"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat128bppRGBFixedPointTest()
    {
        Assert.That(GUID_WICPixelFormat128bppRGBFixedPoint, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x41)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bppRGBAHalf"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bppRGBAHalfTest()
    {
        Assert.That(GUID_WICPixelFormat64bppRGBAHalf, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3a)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bppPRGBAHalf"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bppPRGBAHalfTest()
    {
        Assert.That(GUID_WICPixelFormat64bppPRGBAHalf, Is.EqualTo(new Guid(0x58ad26c2, 0xc623, 0x4d9d, 0xb3, 0x20, 0x38, 0x7e, 0x49, 0xf8, 0xc4, 0x42)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bppRGBHalf"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bppRGBHalfTest()
    {
        Assert.That(GUID_WICPixelFormat64bppRGBHalf, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x42)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat48bppRGBHalf"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat48bppRGBHalfTest()
    {
        Assert.That(GUID_WICPixelFormat48bppRGBHalf, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3b)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppRGBE"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppRGBETest()
    {
        Assert.That(GUID_WICPixelFormat32bppRGBE, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3d)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat16bppGrayHalf"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat16bppGrayHalfTest()
    {
        Assert.That(GUID_WICPixelFormat16bppGrayHalf, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3e)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppGrayFixedPoint"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppGrayFixedPointTest()
    {
        Assert.That(GUID_WICPixelFormat32bppGrayFixedPoint, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x3f)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppRGBA1010102"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppRGBA1010102Test()
    {
        Assert.That(GUID_WICPixelFormat32bppRGBA1010102, Is.EqualTo(new Guid(0x25238D72, 0xFCF9, 0x4522, 0xb5, 0x14, 0x55, 0x78, 0xe5, 0xad, 0x55, 0xe0)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppRGBA1010102XR"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppRGBA1010102XRTest()
    {
        Assert.That(GUID_WICPixelFormat32bppRGBA1010102XR, Is.EqualTo(new Guid(0x00DE6B9A, 0xC101, 0x434b, 0xb5, 0x02, 0xd0, 0x16, 0x5e, 0xe1, 0x12, 0x2c)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppR10G10B10A2"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppR10G10B10A2Test()
    {
        Assert.That(GUID_WICPixelFormat32bppR10G10B10A2, Is.EqualTo(new Guid(0x604e1bb5, 0x8a3c, 0x4b65, 0xb1, 0x1c, 0xbc, 0x0b, 0x8d, 0xd7, 0x5b, 0x7f)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bppR10G10B10A2HDR10"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bppR10G10B10A2HDR10Test()
    {
        Assert.That(GUID_WICPixelFormat32bppR10G10B10A2HDR10, Is.EqualTo(new Guid(0x9c215c5d, 0x1acc, 0x4f0e, 0xa4, 0xbc, 0x70, 0xfb, 0x3a, 0xe8, 0xfd, 0x28)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bppCMYK"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bppCMYKTest()
    {
        Assert.That(GUID_WICPixelFormat64bppCMYK, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x1f)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat24bpp3Channels"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat24bpp3ChannelsTest()
    {
        Assert.That(GUID_WICPixelFormat24bpp3Channels, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x20)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bpp4Channels"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bpp4ChannelsTest()
    {
        Assert.That(GUID_WICPixelFormat32bpp4Channels, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x21)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat40bpp5Channels"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat40bpp5ChannelsTest()
    {
        Assert.That(GUID_WICPixelFormat40bpp5Channels, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x22)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat48bpp6Channels"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat48bpp6ChannelsTest()
    {
        Assert.That(GUID_WICPixelFormat48bpp6Channels, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x23)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat56bpp7Channels"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat56bpp7ChannelsTest()
    {
        Assert.That(GUID_WICPixelFormat56bpp7Channels, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x24)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bpp8Channels"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bpp8ChannelsTest()
    {
        Assert.That(GUID_WICPixelFormat64bpp8Channels, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x25)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat48bpp3Channels"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat48bpp3ChannelsTest()
    {
        Assert.That(GUID_WICPixelFormat48bpp3Channels, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x26)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bpp4Channels"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bpp4ChannelsTest()
    {
        Assert.That(GUID_WICPixelFormat64bpp4Channels, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x27)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat80bpp5Channels"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat80bpp5ChannelsTest()
    {
        Assert.That(GUID_WICPixelFormat80bpp5Channels, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x28)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat96bpp6Channels"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat96bpp6ChannelsTest()
    {
        Assert.That(GUID_WICPixelFormat96bpp6Channels, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x29)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat112bpp7Channels"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat112bpp7ChannelsTest()
    {
        Assert.That(GUID_WICPixelFormat112bpp7Channels, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2a)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat128bpp8Channels"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat128bpp8ChannelsTest()
    {
        Assert.That(GUID_WICPixelFormat128bpp8Channels, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2b)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat40bppCMYKAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat40bppCMYKAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat40bppCMYKAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2c)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat80bppCMYKAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat80bppCMYKAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat80bppCMYKAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2d)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat32bpp3ChannelsAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat32bpp3ChannelsAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat32bpp3ChannelsAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat40bpp4ChannelsAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat40bpp4ChannelsAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat40bpp4ChannelsAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x2f)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat48bpp5ChannelsAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat48bpp5ChannelsAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat48bpp5ChannelsAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat56bpp6ChannelsAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat56bpp6ChannelsAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat56bpp6ChannelsAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x31)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bpp7ChannelsAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bpp7ChannelsAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat64bpp7ChannelsAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x32)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat72bpp8ChannelsAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat72bpp8ChannelsAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat72bpp8ChannelsAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x33)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat64bpp3ChannelsAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat64bpp3ChannelsAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat64bpp3ChannelsAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x34)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat80bpp4ChannelsAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat80bpp4ChannelsAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat80bpp4ChannelsAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat96bpp5ChannelsAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat96bpp5ChannelsAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat96bpp5ChannelsAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x36)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat112bpp6ChannelsAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat112bpp6ChannelsAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat112bpp6ChannelsAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x37)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat128bpp7ChannelsAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat128bpp7ChannelsAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat128bpp7ChannelsAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x38)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat144bpp8ChannelsAlpha"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat144bpp8ChannelsAlphaTest()
    {
        Assert.That(GUID_WICPixelFormat144bpp8ChannelsAlpha, Is.EqualTo(new Guid(0x6fddc324, 0x4e03, 0x4bfe, 0xb1, 0x85, 0x3d, 0x77, 0x76, 0x8d, 0xc9, 0x39)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat8bppY"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat8bppYTest()
    {
        Assert.That(GUID_WICPixelFormat8bppY, Is.EqualTo(new Guid(0x91B4DB54, 0x2DF9, 0x42F0, 0xB4, 0x49, 0x29, 0x09, 0xBB, 0x3D, 0xF8, 0x8E)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat8bppCb"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat8bppCbTest()
    {
        Assert.That(GUID_WICPixelFormat8bppCb, Is.EqualTo(new Guid(0x1339F224, 0x6BFE, 0x4C3E, 0x93, 0x02, 0xE4, 0xF3, 0xA6, 0xD0, 0xCA, 0x2A)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat8bppCr"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat8bppCrTest()
    {
        Assert.That(GUID_WICPixelFormat8bppCr, Is.EqualTo(new Guid(0xB8145053, 0x2116, 0x49F0, 0x88, 0x35, 0xED, 0x84, 0x4B, 0x20, 0x5C, 0x51)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat16bppCbCr"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat16bppCbCrTest()
    {
        Assert.That(GUID_WICPixelFormat16bppCbCr, Is.EqualTo(new Guid(0xFF95BA6E, 0x11E0, 0x4263, 0xBB, 0x45, 0x01, 0x72, 0x1F, 0x34, 0x60, 0xA4)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat16bppYQuantizedDctCoefficients"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat16bppYQuantizedDctCoefficientsTest()
    {
        Assert.That(GUID_WICPixelFormat16bppYQuantizedDctCoefficients, Is.EqualTo(new Guid(0xA355F433, 0x48E8, 0x4A42, 0x84, 0xD8, 0xE2, 0xAA, 0x26, 0xCA, 0x80, 0xA4)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat16bppCbQuantizedDctCoefficients"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat16bppCbQuantizedDctCoefficientsTest()
    {
        Assert.That(GUID_WICPixelFormat16bppCbQuantizedDctCoefficients, Is.EqualTo(new Guid(0xD2C4FF61, 0x56A5, 0x49C2, 0x8B, 0x5C, 0x4C, 0x19, 0x25, 0x96, 0x48, 0x37)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_WICPixelFormat16bppCrQuantizedDctCoefficients"/> property is correct.</summary>
    [Test]
    public static void GUID_WICPixelFormat16bppCrQuantizedDctCoefficientsTest()
    {
        Assert.That(GUID_WICPixelFormat16bppCrQuantizedDctCoefficients, Is.EqualTo(new Guid(0x2FE354F0, 0x1680, 0x42D8, 0x92, 0x31, 0xE7, 0x3C, 0x05, 0x65, 0xBF, 0xC1)));
    }
}