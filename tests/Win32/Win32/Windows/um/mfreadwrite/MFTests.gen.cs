// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.MF;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MF"/> class.</summary>
public static partial class MFTests
{
    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_READER_ASYNC_CALLBACK"/> property is correct.</summary>

    [Test]
    public static void MF_SOURCE_READER_ASYNC_CALLBACKTest()
    {
        Assert.That(
            MF_SOURCE_READER_ASYNC_CALLBACK,
            Is.EqualTo(
                new Guid(0x1e3dbeac, 0xbb43, 0x4c35, 0xb5, 0x07, 0xcd, 0x64, 0x44, 0x64, 0xc9, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_READER_D3D_MANAGER"/> property is correct.</summary>

    [Test]
    public static void MF_SOURCE_READER_D3D_MANAGERTest()
    {
        Assert.That(
            MF_SOURCE_READER_D3D_MANAGER,
            Is.EqualTo(
                new Guid(0xec822da2, 0xe1e9, 0x4b29, 0xa0, 0xd8, 0x56, 0x3c, 0x71, 0x9f, 0x52, 0x69)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_READER_DISABLE_DXVA"/> property is correct.</summary>

    [Test]
    public static void MF_SOURCE_READER_DISABLE_DXVATest()
    {
        Assert.That(
            MF_SOURCE_READER_DISABLE_DXVA,
            Is.EqualTo(
                new Guid(0xaa456cfd, 0x3943, 0x4a1e, 0xa7, 0x7d, 0x18, 0x38, 0xc0, 0xea, 0x2e, 0x35)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_READER_MEDIASOURCE_CONFIG"/> property is correct.</summary>

    [Test]
    public static void MF_SOURCE_READER_MEDIASOURCE_CONFIGTest()
    {
        Assert.That(
            MF_SOURCE_READER_MEDIASOURCE_CONFIG,
            Is.EqualTo(
                new Guid(0x9085abeb, 0x0354, 0x48f9, 0xab, 0xb5, 0x20, 0x0d, 0xf8, 0x38, 0xc6, 0x8e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_READER_MEDIASOURCE_CHARACTERISTICS"/> property is correct.</summary>

    [Test]
    public static void MF_SOURCE_READER_MEDIASOURCE_CHARACTERISTICSTest()
    {
        Assert.That(
            MF_SOURCE_READER_MEDIASOURCE_CHARACTERISTICS,
            Is.EqualTo(
                new Guid(0x6d23f5c8, 0xc5d7, 0x4a9b, 0x99, 0x71, 0x5d, 0x11, 0xf8, 0xbc, 0xa8, 0x80)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_READER_ENABLE_VIDEO_PROCESSING"/> property is correct.</summary>

    [Test]
    public static void MF_SOURCE_READER_ENABLE_VIDEO_PROCESSINGTest()
    {
        Assert.That(
            MF_SOURCE_READER_ENABLE_VIDEO_PROCESSING,
            Is.EqualTo(
                new Guid(0xfb394f3d, 0xccf1, 0x42ee, 0xbb, 0xb3, 0xf9, 0xb8, 0x45, 0xd5, 0x68, 0x1d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_READER_ENABLE_ADVANCED_VIDEO_PROCESSING"/> property is correct.</summary>

    [Test]
    public static void MF_SOURCE_READER_ENABLE_ADVANCED_VIDEO_PROCESSINGTest()
    {
        Assert.That(
            MF_SOURCE_READER_ENABLE_ADVANCED_VIDEO_PROCESSING,
            Is.EqualTo(
                new Guid(0xf81da2c, 0xb537, 0x4672, 0xa8, 0xb2, 0xa6, 0x81, 0xb1, 0x73, 0x7, 0xa3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_READER_DISABLE_CAMERA_PLUGINS"/> property is correct.</summary>

    [Test]
    public static void MF_SOURCE_READER_DISABLE_CAMERA_PLUGINSTest()
    {
        Assert.That(
            MF_SOURCE_READER_DISABLE_CAMERA_PLUGINS,
            Is.EqualTo(
                new Guid(0x9d3365dd, 0x58f, 0x4cfb, 0x9f, 0x97, 0xb3, 0x14, 0xcc, 0x99, 0xc8, 0xad)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_READER_DISCONNECT_MEDIASOURCE_ON_SHUTDOWN"/> property is correct.</summary>

    [Test]
    public static void MF_SOURCE_READER_DISCONNECT_MEDIASOURCE_ON_SHUTDOWNTest()
    {
        Assert.That(
            MF_SOURCE_READER_DISCONNECT_MEDIASOURCE_ON_SHUTDOWN,
            Is.EqualTo(
                new Guid(0x56b67165, 0x219e, 0x456d, 0xa2, 0x2e, 0x2d, 0x30, 0x04, 0xc7, 0xfe, 0x56)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_READER_ENABLE_TRANSCODE_ONLY_TRANSFORMS"/> property is correct.</summary>

    [Test]
    public static void MF_SOURCE_READER_ENABLE_TRANSCODE_ONLY_TRANSFORMSTest()
    {
        Assert.That(
            MF_SOURCE_READER_ENABLE_TRANSCODE_ONLY_TRANSFORMS,
            Is.EqualTo(
                new Guid(0xdfd4f008, 0xb5fd, 0x4e78, 0xae, 0x44, 0x62, 0xa1, 0xe6, 0x7b, 0xbe, 0x27)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_READER_D3D11_BIND_FLAGS"/> property is correct.</summary>

    [Test]
    public static void MF_SOURCE_READER_D3D11_BIND_FLAGSTest()
    {
        Assert.That(
            MF_SOURCE_READER_D3D11_BIND_FLAGS,
            Is.EqualTo(
                new Guid(0x33f3197b, 0xf73a, 0x4e14, 0x8d, 0x85, 0xe, 0x4c, 0x43, 0x68, 0x78, 0x8d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_READER_PASSTHROUGH_MODE"/> property is correct.</summary>

    [Test]
    public static void MF_SOURCE_READER_PASSTHROUGH_MODETest()
    {
        Assert.That(
            MF_SOURCE_READER_PASSTHROUGH_MODE,
            Is.EqualTo(
                new Guid(0x43ff126, 0xfe2c, 0x4708, 0xa0, 0x9b, 0xda, 0x2a, 0xb4, 0x35, 0xce, 0xd9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SINK_WRITER_ASYNC_CALLBACK"/> property is correct.</summary>

    [Test]
    public static void MF_SINK_WRITER_ASYNC_CALLBACKTest()
    {
        Assert.That(
            MF_SINK_WRITER_ASYNC_CALLBACK,
            Is.EqualTo(
                new Guid(0x48cb183e, 0x7b0b, 0x46f4, 0x82, 0x2e, 0x5e, 0x1d, 0x2d, 0xda, 0x43, 0x54)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SINK_WRITER_DISABLE_THROTTLING"/> property is correct.</summary>

    [Test]
    public static void MF_SINK_WRITER_DISABLE_THROTTLINGTest()
    {
        Assert.That(
            MF_SINK_WRITER_DISABLE_THROTTLING,
            Is.EqualTo(
                new Guid(0x08b845d8, 0x2b74, 0x4afe, 0x9d, 0x53, 0xbe, 0x16, 0xd2, 0xd5, 0xae, 0x4f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SINK_WRITER_D3D_MANAGER"/> property is correct.</summary>

    [Test]
    public static void MF_SINK_WRITER_D3D_MANAGERTest()
    {
        Assert.That(
            MF_SINK_WRITER_D3D_MANAGER,
            Is.EqualTo(
                new Guid(0xec822da2, 0xe1e9, 0x4b29, 0xa0, 0xd8, 0x56, 0x3c, 0x71, 0x9f, 0x52, 0x69)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SINK_WRITER_ENCODER_CONFIG"/> property is correct.</summary>

    [Test]
    public static void MF_SINK_WRITER_ENCODER_CONFIGTest()
    {
        Assert.That(
            MF_SINK_WRITER_ENCODER_CONFIG,
            Is.EqualTo(
                new Guid(0xad91cd04, 0xa7cc, 0x4ac7, 0x99, 0xb6, 0xa5, 0x7b, 0x9a, 0x4a, 0x7c, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_READWRITE_DISABLE_CONVERTERS"/> property is correct.</summary>

    [Test]
    public static void MF_READWRITE_DISABLE_CONVERTERSTest()
    {
        Assert.That(
            MF_READWRITE_DISABLE_CONVERTERS,
            Is.EqualTo(
                new Guid(0x98d5b065, 0x1374, 0x4847, 0x8d, 0x5d, 0x31, 0x52, 0x0f, 0xee, 0x71, 0x56)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_READWRITE_ENABLE_HARDWARE_TRANSFORMS"/> property is correct.</summary>

    [Test]
    public static void MF_READWRITE_ENABLE_HARDWARE_TRANSFORMSTest()
    {
        Assert.That(
            MF_READWRITE_ENABLE_HARDWARE_TRANSFORMS,
            Is.EqualTo(
                new Guid(0xa634a91c, 0x822b, 0x41b9, 0xa4, 0x94, 0x4d, 0xe4, 0x64, 0x36, 0x12, 0xb0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_READWRITE_MMCSS_CLASS"/> property is correct.</summary>

    [Test]
    public static void MF_READWRITE_MMCSS_CLASSTest()
    {
        Assert.That(
            MF_READWRITE_MMCSS_CLASS,
            Is.EqualTo(
                new Guid(0x39384300, 0xd0eb, 0x40b1, 0x87, 0xa0, 0x33, 0x18, 0x87, 0x1b, 0x5a, 0x53)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_READWRITE_MMCSS_PRIORITY"/> property is correct.</summary>

    [Test]
    public static void MF_READWRITE_MMCSS_PRIORITYTest()
    {
        Assert.That(
            MF_READWRITE_MMCSS_PRIORITY,
            Is.EqualTo(
                new Guid(0x43ad19ce, 0xf33f, 0x4ba9, 0xa5, 0x80, 0xe4, 0xcd, 0x12, 0xf2, 0xd1, 0x44)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_READWRITE_MMCSS_CLASS_AUDIO"/> property is correct.</summary>

    [Test]
    public static void MF_READWRITE_MMCSS_CLASS_AUDIOTest()
    {
        Assert.That(
            MF_READWRITE_MMCSS_CLASS_AUDIO,
            Is.EqualTo(
                new Guid(0x430847da, 0x0890, 0x4b0e, 0x93, 0x8c, 0x05, 0x43, 0x32, 0xc5, 0x47, 0xe1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_READWRITE_MMCSS_PRIORITY_AUDIO"/> property is correct.</summary>

    [Test]
    public static void MF_READWRITE_MMCSS_PRIORITY_AUDIOTest()
    {
        Assert.That(
            MF_READWRITE_MMCSS_PRIORITY_AUDIO,
            Is.EqualTo(
                new Guid(0x273db885, 0x2de2, 0x4db2, 0xa6, 0xa7, 0xfd, 0xb6, 0x6f, 0xb4, 0x0b, 0x61)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_READWRITE_D3D_OPTIONAL"/> property is correct.</summary>

    [Test]
    public static void MF_READWRITE_D3D_OPTIONALTest()
    {
        Assert.That(
            MF_READWRITE_D3D_OPTIONAL,
            Is.EqualTo(
                new Guid(0x216479d9, 0x3071, 0x42ca, 0xbb, 0x6c, 0x4c, 0x22, 0x10, 0x2e, 0x1d, 0x18)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_MEDIASINK_AUTOFINALIZE_SUPPORTED"/> property is correct.</summary>

    [Test]
    public static void MF_MEDIASINK_AUTOFINALIZE_SUPPORTEDTest()
    {
        Assert.That(
            MF_MEDIASINK_AUTOFINALIZE_SUPPORTED,
            Is.EqualTo(
                new Guid(0x48c131be, 0x135a, 0x41cb, 0x82, 0x90, 0x3, 0x65, 0x25, 0x9, 0xc9, 0x99)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_MEDIASINK_ENABLE_AUTOFINALIZE"/> property is correct.</summary>

    [Test]
    public static void MF_MEDIASINK_ENABLE_AUTOFINALIZETest()
    {
        Assert.That(
            MF_MEDIASINK_ENABLE_AUTOFINALIZE,
            Is.EqualTo(
                new Guid(0x34014265, 0xcb7e, 0x4cde, 0xac, 0x7c, 0xef, 0xfd, 0x3b, 0x3c, 0x25, 0x30)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_READWRITE_ENABLE_AUTOFINALIZE"/> property is correct.</summary>

    [Test]
    public static void MF_READWRITE_ENABLE_AUTOFINALIZETest()
    {
        Assert.That(
            MF_READWRITE_ENABLE_AUTOFINALIZE,
            Is.EqualTo(
                new Guid(0xdd7ca129, 0x8cd1, 0x4dc5, 0x9d, 0xde, 0xce, 0x16, 0x86, 0x75, 0xde, 0x61)
            )
        );
    }
}
