// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.MF;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MF"/> class.</summary>
public static partial class MFTests
{
    /// <summary>Validates that the value of the <see cref = "MF_MEDIA_SHARING_ENGINE_DEVICE_NAME"/> property is correct.</summary>

    [Test]
    public static void MF_MEDIA_SHARING_ENGINE_DEVICE_NAMETest()
    {
        Assert.That(
            MF_MEDIA_SHARING_ENGINE_DEVICE_NAME,
            Is.EqualTo(
                new Guid(0x771e05d1, 0x862f, 0x4299, 0x95, 0xac, 0xae, 0x81, 0xfd, 0x14, 0xf3, 0xe7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_MEDIA_SHARING_ENGINE_DEVICE"/> property is correct.</summary>

    [Test]
    public static void MF_MEDIA_SHARING_ENGINE_DEVICETest()
    {
        Assert.That(
            MF_MEDIA_SHARING_ENGINE_DEVICE,
            Is.EqualTo(
                new Guid(0xb461c58a, 0x7a08, 0x4b98, 0x99, 0xa8, 0x70, 0xfd, 0x5f, 0x3b, 0xad, 0xfd)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_MEDIA_SHARING_ENGINE_INITIAL_SEEK_TIME"/> property is correct.</summary>

    [Test]
    public static void MF_MEDIA_SHARING_ENGINE_INITIAL_SEEK_TIMETest()
    {
        Assert.That(
            MF_MEDIA_SHARING_ENGINE_INITIAL_SEEK_TIME,
            Is.EqualTo(
                new Guid(0x6f3497f5, 0xd528, 0x4a4f, 0x8d, 0xd7, 0xdb, 0x36, 0x65, 0x7e, 0xc4, 0xc9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SHUTDOWN_RENDERER_ON_ENGINE_SHUTDOWN"/> property is correct.</summary>

    [Test]
    public static void MF_SHUTDOWN_RENDERER_ON_ENGINE_SHUTDOWNTest()
    {
        Assert.That(
            MF_SHUTDOWN_RENDERER_ON_ENGINE_SHUTDOWN,
            Is.EqualTo(
                new Guid(0xc112d94d, 0x6b9c, 0x48f8, 0xb6, 0xf9, 0x79, 0x50, 0xff, 0x9a, 0xb7, 0x1e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_PREFERRED_SOURCE_URI"/> property is correct.</summary>

    [Test]
    public static void MF_PREFERRED_SOURCE_URITest()
    {
        Assert.That(
            MF_PREFERRED_SOURCE_URI,
            Is.EqualTo(
                new Guid(0x5fc85488, 0x436a, 0x4db8, 0x90, 0xaf, 0x4d, 0xb4, 0x2, 0xae, 0x5c, 0x57)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SHARING_ENGINE_SHAREDRENDERER"/> property is correct.</summary>

    [Test]
    public static void MF_SHARING_ENGINE_SHAREDRENDERERTest()
    {
        Assert.That(
            MF_SHARING_ENGINE_SHAREDRENDERER,
            Is.EqualTo(
                new Guid(0xefa446a0, 0x73e7, 0x404e, 0x8a, 0xe2, 0xfe, 0xf6, 0x0a, 0xf5, 0xa3, 0x2b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_SHARING_ENGINE_CALLBACK"/> property is correct.</summary>

    [Test]
    public static void MF_SHARING_ENGINE_CALLBACKTest()
    {
        Assert.That(
            MF_SHARING_ENGINE_CALLBACK,
            Is.EqualTo(
                new Guid(0x57dc1e95, 0xd252, 0x43fa, 0x9b, 0xbc, 0x18, 0x0, 0x70, 0xee, 0xfe, 0x6d)
            )
        );
    }
}
