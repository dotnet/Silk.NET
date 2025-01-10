// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmp2dlna.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.MF;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MF"/> class.</summary>
public static partial class MFTests
{
    /// <summary>Validates that the value of the <see cref = "MF_MP2DLNA_USE_MMCSS"/> property is correct.</summary>

    [Test]
    public static void MF_MP2DLNA_USE_MMCSSTest()
    {
        Assert.That(
            MF_MP2DLNA_USE_MMCSS,
            Is.EqualTo(
                new Guid(0x54f3e2ee, 0xa2a2, 0x497d, 0x98, 0x34, 0x97, 0x3a, 0xfd, 0xe5, 0x21, 0xeb)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_MP2DLNA_VIDEO_BIT_RATE"/> property is correct.</summary>

    [Test]
    public static void MF_MP2DLNA_VIDEO_BIT_RATETest()
    {
        Assert.That(
            MF_MP2DLNA_VIDEO_BIT_RATE,
            Is.EqualTo(
                new Guid(0xe88548de, 0x73b4, 0x42d7, 0x9c, 0x75, 0xad, 0xfa, 0xa, 0x2a, 0x6e, 0x4c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_MP2DLNA_AUDIO_BIT_RATE"/> property is correct.</summary>

    [Test]
    public static void MF_MP2DLNA_AUDIO_BIT_RATETest()
    {
        Assert.That(
            MF_MP2DLNA_AUDIO_BIT_RATE,
            Is.EqualTo(
                new Guid(0x2d1c070e, 0x2b5f, 0x4ab3, 0xa7, 0xe6, 0x8d, 0x94, 0x3b, 0xa8, 0xd0, 0x0a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_MP2DLNA_ENCODE_QUALITY"/> property is correct.</summary>

    [Test]
    public static void MF_MP2DLNA_ENCODE_QUALITYTest()
    {
        Assert.That(
            MF_MP2DLNA_ENCODE_QUALITY,
            Is.EqualTo(
                new Guid(0xb52379d7, 0x1d46, 0x4fb6, 0xa3, 0x17, 0xa4, 0xa5, 0xf6, 0x09, 0x59, 0xf8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_MP2DLNA_STATISTICS"/> property is correct.</summary>

    [Test]
    public static void MF_MP2DLNA_STATISTICSTest()
    {
        Assert.That(
            MF_MP2DLNA_STATISTICS,
            Is.EqualTo(
                new Guid(0x75e488a3, 0xd5ad, 0x4898, 0x85, 0xe0, 0xbc, 0xce, 0x24, 0xa7, 0x22, 0xd7)
            )
        );
    }
}
