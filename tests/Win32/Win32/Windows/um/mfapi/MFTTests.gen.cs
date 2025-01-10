// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.MFT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MFT"/> class.</summary>
public static partial class MFTTests
{
    /// <summary>Validates that the value of the <see cref = "MFT_ENCODER_ERROR"/> property is correct.</summary>

    [Test]
    public static void MFT_ENCODER_ERRORTest()
    {
        Assert.That(
            MFT_ENCODER_ERROR,
            Is.EqualTo(
                new Guid(0xc8d1eda4, 0x98e4, 0x41d5, 0x92, 0x97, 0x44, 0xf5, 0x38, 0x52, 0xf9, 0x0e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_GFX_DRIVER_VERSION_ID_Attribute"/> property is correct.</summary>

    [Test]
    public static void MFT_GFX_DRIVER_VERSION_ID_AttributeTest()
    {
        Assert.That(
            MFT_GFX_DRIVER_VERSION_ID_Attribute,
            Is.EqualTo(
                new Guid(0xf34b9093, 0x05e0, 0x4b16, 0x99, 0x3d, 0x3e, 0x2a, 0x2c, 0xde, 0x6a, 0xd3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CATEGORY_VIDEO_DECODER"/> property is correct.</summary>

    [Test]
    public static void MFT_CATEGORY_VIDEO_DECODERTest()
    {
        Assert.That(
            MFT_CATEGORY_VIDEO_DECODER,
            Is.EqualTo(
                new Guid(0xd6c02d4b, 0x6833, 0x45b4, 0x97, 0x1a, 0x05, 0xa4, 0xb0, 0x4b, 0xab, 0x91)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CATEGORY_VIDEO_ENCODER"/> property is correct.</summary>

    [Test]
    public static void MFT_CATEGORY_VIDEO_ENCODERTest()
    {
        Assert.That(
            MFT_CATEGORY_VIDEO_ENCODER,
            Is.EqualTo(
                new Guid(0xf79eac7d, 0xe545, 0x4387, 0xbd, 0xee, 0xd6, 0x47, 0xd7, 0xbd, 0xe4, 0x2a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CATEGORY_VIDEO_EFFECT"/> property is correct.</summary>

    [Test]
    public static void MFT_CATEGORY_VIDEO_EFFECTTest()
    {
        Assert.That(
            MFT_CATEGORY_VIDEO_EFFECT,
            Is.EqualTo(
                new Guid(0x12e17c21, 0x532c, 0x4a6e, 0x8a, 0x1c, 0x40, 0x82, 0x5a, 0x73, 0x63, 0x97)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CATEGORY_MULTIPLEXER"/> property is correct.</summary>

    [Test]
    public static void MFT_CATEGORY_MULTIPLEXERTest()
    {
        Assert.That(
            MFT_CATEGORY_MULTIPLEXER,
            Is.EqualTo(
                new Guid(0x059c561e, 0x05ae, 0x4b61, 0xb6, 0x9d, 0x55, 0xb6, 0x1e, 0xe5, 0x4a, 0x7b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CATEGORY_DEMULTIPLEXER"/> property is correct.</summary>

    [Test]
    public static void MFT_CATEGORY_DEMULTIPLEXERTest()
    {
        Assert.That(
            MFT_CATEGORY_DEMULTIPLEXER,
            Is.EqualTo(
                new Guid(0xa8700a7a, 0x939b, 0x44c5, 0x99, 0xd7, 0x76, 0x22, 0x6b, 0x23, 0xb3, 0xf1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CATEGORY_AUDIO_DECODER"/> property is correct.</summary>

    [Test]
    public static void MFT_CATEGORY_AUDIO_DECODERTest()
    {
        Assert.That(
            MFT_CATEGORY_AUDIO_DECODER,
            Is.EqualTo(
                new Guid(0x9ea73fb4, 0xef7a, 0x4559, 0x8d, 0x5d, 0x71, 0x9d, 0x8f, 0x04, 0x26, 0xc7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CATEGORY_AUDIO_ENCODER"/> property is correct.</summary>

    [Test]
    public static void MFT_CATEGORY_AUDIO_ENCODERTest()
    {
        Assert.That(
            MFT_CATEGORY_AUDIO_ENCODER,
            Is.EqualTo(
                new Guid(0x91c64bd0, 0xf91e, 0x4d8c, 0x92, 0x76, 0xdb, 0x24, 0x82, 0x79, 0xd9, 0x75)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CATEGORY_AUDIO_EFFECT"/> property is correct.</summary>

    [Test]
    public static void MFT_CATEGORY_AUDIO_EFFECTTest()
    {
        Assert.That(
            MFT_CATEGORY_AUDIO_EFFECT,
            Is.EqualTo(
                new Guid(0x11064c48, 0x3648, 0x4ed0, 0x93, 0x2e, 0x05, 0xce, 0x8a, 0xc8, 0x11, 0xb7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CATEGORY_VIDEO_PROCESSOR"/> property is correct.</summary>

    [Test]
    public static void MFT_CATEGORY_VIDEO_PROCESSORTest()
    {
        Assert.That(
            MFT_CATEGORY_VIDEO_PROCESSOR,
            Is.EqualTo(
                new Guid(0x302ea3fc, 0xaa5f, 0x47f9, 0x9f, 0x7a, 0xc2, 0x18, 0x8b, 0xb1, 0x63, 0x2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CATEGORY_OTHER"/> property is correct.</summary>

    [Test]
    public static void MFT_CATEGORY_OTHERTest()
    {
        Assert.That(
            MFT_CATEGORY_OTHER,
            Is.EqualTo(
                new Guid(0x90175d57, 0xb7ea, 0x4901, 0xae, 0xb3, 0x93, 0x3a, 0x87, 0x47, 0x75, 0x6f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CATEGORY_ENCRYPTOR"/> property is correct.</summary>

    [Test]
    public static void MFT_CATEGORY_ENCRYPTORTest()
    {
        Assert.That(
            MFT_CATEGORY_ENCRYPTOR,
            Is.EqualTo(
                new Guid(0xb0c687be, 0x01cd, 0x44b5, 0xb8, 0xb2, 0x7c, 0x1d, 0x7e, 0x05, 0x8b, 0x1f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CATEGORY_VIDEO_RENDERER_EFFECT"/> property is correct.</summary>

    [Test]
    public static void MFT_CATEGORY_VIDEO_RENDERER_EFFECTTest()
    {
        Assert.That(
            MFT_CATEGORY_VIDEO_RENDERER_EFFECT,
            Is.EqualTo(
                new Guid(0x145cd8b4, 0x92f4, 0x4b23, 0x8a, 0xe7, 0xe0, 0xdf, 0x6, 0xc2, 0xda, 0x95)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_ENUM_VIDEO_RENDERER_EXTENSION_PROFILE"/> property is correct.</summary>

    [Test]
    public static void MFT_ENUM_VIDEO_RENDERER_EXTENSION_PROFILETest()
    {
        Assert.That(
            MFT_ENUM_VIDEO_RENDERER_EXTENSION_PROFILE,
            Is.EqualTo(
                new Guid(0x62c56928, 0x9a4e, 0x443b, 0xb9, 0xdc, 0xca, 0xc8, 0x30, 0xc2, 0x41, 0x0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_ENUM_ADAPTER_LUID"/> property is correct.</summary>

    [Test]
    public static void MFT_ENUM_ADAPTER_LUIDTest()
    {
        Assert.That(
            MFT_ENUM_ADAPTER_LUID,
            Is.EqualTo(
                new Guid(0x1d39518c, 0xe220, 0x4da8, 0xa0, 0x7f, 0xba, 0x17, 0x25, 0x52, 0xd6, 0xb1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_SUPPORT_DYNAMIC_FORMAT_CHANGE"/> property is correct.</summary>

    [Test]
    public static void MFT_SUPPORT_DYNAMIC_FORMAT_CHANGETest()
    {
        Assert.That(
            MFT_SUPPORT_DYNAMIC_FORMAT_CHANGE,
            Is.EqualTo(
                new Guid(0x53476a11, 0x3f13, 0x49fb, 0xac, 0x42, 0xee, 0x27, 0x33, 0xc9, 0x67, 0x41)
            )
        );
    }
}
