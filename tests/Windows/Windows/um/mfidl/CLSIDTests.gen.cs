// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_CreateMediaExtensionObject"/> property is correct.</summary>
    [Test]
    public static void CLSID_CreateMediaExtensionObjectTest()
    {
        Assert.That(CLSID_CreateMediaExtensionObject, Is.EqualTo(new Guid(0xef65a54d, 0x0788, 0x45b8, 0x8b, 0x14, 0xbc, 0x0f, 0x6a, 0x6b, 0x51, 0x37)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_HttpSchemePlugin"/> property is correct.</summary>
    [Test]
    public static void CLSID_HttpSchemePluginTest()
    {
        Assert.That(CLSID_HttpSchemePlugin, Is.EqualTo(new Guid(0x44cb442b, 0x9da9, 0x49df, 0xb3, 0xfd, 0x2, 0x37, 0x77, 0xb1, 0x6e, 0x50)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_UrlmonSchemePlugin"/> property is correct.</summary>
    [Test]
    public static void CLSID_UrlmonSchemePluginTest()
    {
        Assert.That(CLSID_UrlmonSchemePlugin, Is.EqualTo(new Guid(0x9ec4b4f9, 0x3029, 0x45ad, 0x94, 0x7b, 0x34, 0x4d, 0xe2, 0xa2, 0x49, 0xe2)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_NetSchemePlugin"/> property is correct.</summary>
    [Test]
    public static void CLSID_NetSchemePluginTest()
    {
        Assert.That(CLSID_NetSchemePlugin, Is.EqualTo(new Guid(0xe9f4ebab, 0xd97b, 0x463e, 0xa2, 0xb1, 0xc5, 0x4e, 0xe3, 0xf9, 0x41, 0x4d)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FrameServerNetworkCameraSource"/> property is correct.</summary>
    [Test]
    public static void CLSID_FrameServerNetworkCameraSourceTest()
    {
        Assert.That(CLSID_FrameServerNetworkCameraSource, Is.EqualTo(new Guid(0x7a213aa7, 0x866f, 0x414a, 0x8c, 0x1a, 0x27, 0x5c, 0x72, 0x83, 0xa3, 0x95)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MPEG2ByteStreamPlugin"/> property is correct.</summary>
    [Test]
    public static void CLSID_MPEG2ByteStreamPluginTest()
    {
        Assert.That(CLSID_MPEG2ByteStreamPlugin, Is.EqualTo(new Guid(0x40871c59, 0xab40, 0x471f, 0x8d, 0xc3, 0x1f, 0x25, 0x9d, 0x86, 0x24, 0x79)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MSH264DecoderMFT"/> property is correct.</summary>
    [Test]
    public static void CLSID_MSH264DecoderMFTTest()
    {
        Assert.That(CLSID_MSH264DecoderMFT, Is.EqualTo(new Guid(0x62CE7E72, 0x4C71, 0x4d20, 0xB1, 0x5D, 0x45, 0x28, 0x31, 0xA8, 0x7D, 0x9D)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MSH264EncoderMFT"/> property is correct.</summary>
    [Test]
    public static void CLSID_MSH264EncoderMFTTest()
    {
        Assert.That(CLSID_MSH264EncoderMFT, Is.EqualTo(new Guid(0x6ca50344, 0x051a, 0x4ded, 0x97, 0x79, 0xa4, 0x33, 0x05, 0x16, 0x5e, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MSDDPlusDecMFT"/> property is correct.</summary>
    [Test]
    public static void CLSID_MSDDPlusDecMFTTest()
    {
        Assert.That(CLSID_MSDDPlusDecMFT, Is.EqualTo(new Guid(0x177C0AFE, 0x900B, 0x48d4, 0x9E, 0x4C, 0x57, 0xAD, 0xD2, 0x50, 0xB3, 0xD4)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MP3DecMediaObject"/> property is correct.</summary>
    [Test]
    public static void CLSID_MP3DecMediaObjectTest()
    {
        Assert.That(CLSID_MP3DecMediaObject, Is.EqualTo(new Guid(0xbbeea841, 0x0a63, 0x4f52, 0xa7, 0xab, 0xa9, 0xb3, 0xa8, 0x4e, 0xd3, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MSAACDecMFT"/> property is correct.</summary>
    [Test]
    public static void CLSID_MSAACDecMFTTest()
    {
        Assert.That(CLSID_MSAACDecMFT, Is.EqualTo(new Guid(0x32d186a7, 0x218f, 0x4c75, 0x88, 0x76, 0xdd, 0x77, 0x27, 0x3a, 0x89, 0x99)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MSH265DecoderMFT"/> property is correct.</summary>
    [Test]
    public static void CLSID_MSH265DecoderMFTTest()
    {
        Assert.That(CLSID_MSH265DecoderMFT, Is.EqualTo(new Guid(0x420A51A3, 0xD605, 0x430C, 0xB4, 0xFC, 0x45, 0x27, 0x4F, 0xA6, 0xC5, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WMVDecoderMFT"/> property is correct.</summary>
    [Test]
    public static void CLSID_WMVDecoderMFTTest()
    {
        Assert.That(CLSID_WMVDecoderMFT, Is.EqualTo(new Guid(0x82d353df, 0x90bd, 0x4382, 0x8b, 0xc2, 0x3f, 0x61, 0x92, 0xb7, 0x6e, 0x34)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WMADecMediaObject"/> property is correct.</summary>
    [Test]
    public static void CLSID_WMADecMediaObjectTest()
    {
        Assert.That(CLSID_WMADecMediaObject, Is.EqualTo(new Guid(0x2eeb4adf, 0x4578, 0x4d10, 0xbc, 0xa7, 0xbb, 0x95, 0x5f, 0x56, 0x32, 0x0a)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MSMPEGAudDecMFT"/> property is correct.</summary>
    [Test]
    public static void CLSID_MSMPEGAudDecMFTTest()
    {
        Assert.That(CLSID_MSMPEGAudDecMFT, Is.EqualTo(new Guid(0x70707B39, 0xB2CA, 0x4015, 0xAB, 0xEA, 0xF8, 0x44, 0x7D, 0x22, 0xD8, 0x8B)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MSMPEGDecoderMFT"/> property is correct.</summary>
    [Test]
    public static void CLSID_MSMPEGDecoderMFTTest()
    {
        Assert.That(CLSID_MSMPEGDecoderMFT, Is.EqualTo(new Guid(0x2D709E52, 0x123F, 0x49b5, 0x9C, 0xBC, 0x9A, 0xF5, 0xCD, 0xE2, 0x8F, 0xB9)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AudioResamplerMediaObject"/> property is correct.</summary>
    [Test]
    public static void CLSID_AudioResamplerMediaObjectTest()
    {
        Assert.That(CLSID_AudioResamplerMediaObject, Is.EqualTo(new Guid(0xf447b69e, 0x1884, 0x4a7e, 0x80, 0x55, 0x34, 0x6f, 0x74, 0xd6, 0xed, 0xb3)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MSVPxDecoder"/> property is correct.</summary>
    [Test]
    public static void CLSID_MSVPxDecoderTest()
    {
        Assert.That(CLSID_MSVPxDecoder, Is.EqualTo(new Guid(0xE3AAF548, 0xC9A4, 0x4C6E, 0x23, 0x4D, 0x5A, 0xDA, 0x37, 0x4B, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MSOpusDecoder"/> property is correct.</summary>
    [Test]
    public static void CLSID_MSOpusDecoderTest()
    {
        Assert.That(CLSID_MSOpusDecoder, Is.EqualTo(new Guid(0x63e17c10, 0x2d43, 0x4c42, 0x8f, 0xe3, 0x8d, 0x8b, 0x63, 0xe4, 0x6a, 0x6a)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VideoProcessorMFT"/> property is correct.</summary>
    [Test]
    public static void CLSID_VideoProcessorMFTTest()
    {
        Assert.That(CLSID_VideoProcessorMFT, Is.EqualTo(new Guid(0x88753b26, 0x5b24, 0x49bd, 0xb2, 0xe7, 0xc, 0x44, 0x5c, 0x78, 0xc9, 0x82)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CameraConfigurationManager"/> property is correct.</summary>
    [Test]
    public static void CLSID_CameraConfigurationManagerTest()
    {
        Assert.That(CLSID_CameraConfigurationManager, Is.EqualTo(new Guid(0x6C92B540, 0x5854, 0x4A17, 0x92, 0xB6, 0xAC, 0x89, 0xC9, 0x6E, 0x96, 0x83)));
    }
}