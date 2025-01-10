// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.MF;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MF"/> class.</summary>
public static partial class MFTests
{
    /// <summary>Validates that the value of the <see cref = "MF_SA_D3D_AWARE"/> property is correct.</summary>

    [Test]
    public static void MF_SA_D3D_AWARETest()
    {
        Assert.That(
            MF_SA_D3D_AWARE,
            Is.EqualTo(
                new Guid(0xeaa35c29, 0x775e, 0x488e, 0x9b, 0x61, 0xb3, 0x28, 0x3e, 0x49, 0x58, 0x3b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_REQUIRED_SAMPLE_COUNT"/> property is correct.</summary>

    [Test]
    public static void MF_SA_REQUIRED_SAMPLE_COUNTTest()
    {
        Assert.That(
            MF_SA_REQUIRED_SAMPLE_COUNT,
            Is.EqualTo(
                new Guid(0x18802c61, 0x324b, 0x4952, 0xab, 0xd0, 0x17, 0x6f, 0xf5, 0xc6, 0x96, 0xff)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_AUDIO_ENDPOINT_AWARE"/> property is correct.</summary>

    [Test]
    public static void MF_SA_AUDIO_ENDPOINT_AWARETest()
    {
        Assert.That(
            MF_SA_AUDIO_ENDPOINT_AWARE,
            Is.EqualTo(
                new Guid(0xc0381701, 0x805c, 0x42b2, 0xac, 0x8d, 0xe2, 0xb4, 0xbf, 0x21, 0xf4, 0xf8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_DMFT_FRAME_BUFFER_INFO"/> property is correct.</summary>

    [Test]
    public static void MF_DMFT_FRAME_BUFFER_INFOTest()
    {
        Assert.That(
            MF_DMFT_FRAME_BUFFER_INFO,
            Is.EqualTo(
                new Guid(0x396CE1C9, 0x67A9, 0x454C, 0x87, 0x97, 0x95, 0xA4, 0x57, 0x99, 0xD8, 0x04)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_REQUIRED_SAMPLE_COUNT_PROGRESSIVE"/> property is correct.</summary>

    [Test]
    public static void MF_SA_REQUIRED_SAMPLE_COUNT_PROGRESSIVETest()
    {
        Assert.That(
            MF_SA_REQUIRED_SAMPLE_COUNT_PROGRESSIVE,
            Is.EqualTo(
                new Guid(0xb172d58e, 0xfa77, 0x4e48, 0x8d, 0x2a, 0x1d, 0xf2, 0xd8, 0x50, 0xea, 0xc2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT"/> property is correct.</summary>

    [Test]
    public static void MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNTTest()
    {
        Assert.That(
            MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT,
            Is.EqualTo(
                new Guid(0x851745d5, 0xc3d6, 0x476d, 0x95, 0x27, 0x49, 0x8e, 0xf2, 0xd1, 0xd, 0x18)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT_PROGRESSIVE"/> property is correct.</summary>

    [Test]
    public static void MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT_PROGRESSIVETest()
    {
        Assert.That(
            MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT_PROGRESSIVE,
            Is.EqualTo(
                new Guid(0xf5523a5, 0x1cb2, 0x47c5, 0xa5, 0x50, 0x2e, 0xeb, 0x84, 0xb4, 0xd1, 0x4a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_ENABLE_3DVIDEO_OUTPUT"/> property is correct.</summary>

    [Test]
    public static void MF_ENABLE_3DVIDEO_OUTPUTTest()
    {
        Assert.That(
            MF_ENABLE_3DVIDEO_OUTPUT,
            Is.EqualTo(
                new Guid(0xbdad7bca, 0xe5f, 0x4b10, 0xab, 0x16, 0x26, 0xde, 0x38, 0x1b, 0x62, 0x93)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_D3D11_BINDFLAGS"/> property is correct.</summary>

    [Test]
    public static void MF_SA_D3D11_BINDFLAGSTest()
    {
        Assert.That(
            MF_SA_D3D11_BINDFLAGS,
            Is.EqualTo(
                new Guid(0xeacf97ad, 0x065c, 0x4408, 0xbe, 0xe3, 0xfd, 0xcb, 0xfd, 0x12, 0x8b, 0xe2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_D3D11_USAGE"/> property is correct.</summary>

    [Test]
    public static void MF_SA_D3D11_USAGETest()
    {
        Assert.That(
            MF_SA_D3D11_USAGE,
            Is.EqualTo(
                new Guid(0xe85fe442, 0x2ca3, 0x486e, 0xa9, 0xc7, 0x10, 0x9d, 0xda, 0x60, 0x98, 0x80)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_D3D11_AWARE"/> property is correct.</summary>

    [Test]
    public static void MF_SA_D3D11_AWARETest()
    {
        Assert.That(
            MF_SA_D3D11_AWARE,
            Is.EqualTo(
                new Guid(0x206b4fc8, 0xfcf9, 0x4c51, 0xaf, 0xe3, 0x97, 0x64, 0x36, 0x9e, 0x33, 0xa0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_D3D11_SHARED"/> property is correct.</summary>

    [Test]
    public static void MF_SA_D3D11_SHAREDTest()
    {
        Assert.That(
            MF_SA_D3D11_SHARED,
            Is.EqualTo(
                new Guid(0x7b8f32c3, 0x6d96, 0x4b89, 0x92, 0x3, 0xdd, 0x38, 0xb6, 0x14, 0x14, 0xf3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_D3D11_SHARED_WITHOUT_MUTEX"/> property is correct.</summary>

    [Test]
    public static void MF_SA_D3D11_SHARED_WITHOUT_MUTEXTest()
    {
        Assert.That(
            MF_SA_D3D11_SHARED_WITHOUT_MUTEX,
            Is.EqualTo(
                new Guid(0x39dbd44d, 0x2e44, 0x4931, 0xa4, 0xc8, 0x35, 0x2d, 0x3d, 0xc4, 0x21, 0x15)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_D3D11_ALLOW_DYNAMIC_YUV_TEXTURE"/> property is correct.</summary>

    [Test]
    public static void MF_SA_D3D11_ALLOW_DYNAMIC_YUV_TEXTURETest()
    {
        Assert.That(
            MF_SA_D3D11_ALLOW_DYNAMIC_YUV_TEXTURE,
            Is.EqualTo(
                new Guid(0xce06d49f, 0x613, 0x4b9d, 0x86, 0xa6, 0xd8, 0xc4, 0xf9, 0xc1, 0x0, 0x75)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_D3D11_HW_PROTECTED"/> property is correct.</summary>

    [Test]
    public static void MF_SA_D3D11_HW_PROTECTEDTest()
    {
        Assert.That(
            MF_SA_D3D11_HW_PROTECTED,
            Is.EqualTo(
                new Guid(0x3a8ba9d9, 0x92ca, 0x4307, 0xa3, 0x91, 0x69, 0x99, 0xdb, 0xf3, 0xb6, 0xce)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_BUFFERS_PER_SAMPLE"/> property is correct.</summary>

    [Test]
    public static void MF_SA_BUFFERS_PER_SAMPLETest()
    {
        Assert.That(
            MF_SA_BUFFERS_PER_SAMPLE,
            Is.EqualTo(
                new Guid(0x873c5171, 0x1e3d, 0x4e25, 0x98, 0x8d, 0xb4, 0x33, 0xce, 0x04, 0x19, 0x83)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SA_D3D11_ALLOCATE_DISPLAYABLE_RESOURCES"/> property is correct.</summary>

    [Test]
    public static void MF_SA_D3D11_ALLOCATE_DISPLAYABLE_RESOURCESTest()
    {
        Assert.That(
            MF_SA_D3D11_ALLOCATE_DISPLAYABLE_RESOURCES,
            Is.EqualTo(
                new Guid(0xeeface6d, 0x2ea9, 0x4adf, 0xbb, 0xdf, 0x7b, 0xbc, 0x48, 0x2a, 0x1b, 0x6d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_TRANSFORM_ASYNC"/> property is correct.</summary>

    [Test]
    public static void MF_TRANSFORM_ASYNCTest()
    {
        Assert.That(
            MF_TRANSFORM_ASYNC,
            Is.EqualTo(
                new Guid(0xf81a699a, 0x649a, 0x497d, 0x8c, 0x73, 0x29, 0xf8, 0xfe, 0xd6, 0xad, 0x7a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_TRANSFORM_ASYNC_UNLOCK"/> property is correct.</summary>

    [Test]
    public static void MF_TRANSFORM_ASYNC_UNLOCKTest()
    {
        Assert.That(
            MF_TRANSFORM_ASYNC_UNLOCK,
            Is.EqualTo(
                new Guid(0xe5666d6b, 0x3422, 0x4eb6, 0xa4, 0x21, 0xda, 0x7d, 0xb1, 0xf8, 0xe2, 0x7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_TRANSFORM_FLAGS_Attribute"/> property is correct.</summary>

    [Test]
    public static void MF_TRANSFORM_FLAGS_AttributeTest()
    {
        Assert.That(
            MF_TRANSFORM_FLAGS_Attribute,
            Is.EqualTo(
                new Guid(0x9359bb7e, 0x6275, 0x46c4, 0xa0, 0x25, 0x1c, 0x1, 0xe4, 0x5f, 0x1a, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_TRANSFORM_CATEGORY_Attribute"/> property is correct.</summary>

    [Test]
    public static void MF_TRANSFORM_CATEGORY_AttributeTest()
    {
        Assert.That(
            MF_TRANSFORM_CATEGORY_Attribute,
            Is.EqualTo(
                new Guid(0xceabba49, 0x506d, 0x4757, 0xa6, 0xff, 0x66, 0xc1, 0x84, 0x98, 0x7e, 0x4e)
            )
        );
    }
}
