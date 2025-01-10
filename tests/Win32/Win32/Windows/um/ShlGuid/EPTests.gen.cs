// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.EP;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "EP"/> class.</summary>
public static partial class EPTests
{
    /// <summary>Validates that the value of the <see cref = "EP_NavPane"/> property is correct.</summary>

    [Test]
    public static void EP_NavPaneTest()
    {
        Assert.That(
            EP_NavPane,
            Is.EqualTo(
                new Guid(0xcb316b22, 0x25f7, 0x42b8, 0x8a, 0x09, 0x54, 0x0d, 0x23, 0xa4, 0x3c, 0x2f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "EP_Commands"/> property is correct.</summary>

    [Test]
    public static void EP_CommandsTest()
    {
        Assert.That(
            EP_Commands,
            Is.EqualTo(
                new Guid(0xd9745868, 0xca5f, 0x4a76, 0x91, 0xcd, 0xf5, 0xa1, 0x29, 0xfb, 0xb0, 0x76)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "EP_Commands_Organize"/> property is correct.</summary>

    [Test]
    public static void EP_Commands_OrganizeTest()
    {
        Assert.That(
            EP_Commands_Organize,
            Is.EqualTo(
                new Guid(0x72e81700, 0xe3ec, 0x4660, 0xbf, 0x24, 0x3c, 0x3b, 0x7b, 0x64, 0x88, 0x06)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "EP_Commands_View"/> property is correct.</summary>

    [Test]
    public static void EP_Commands_ViewTest()
    {
        Assert.That(
            EP_Commands_View,
            Is.EqualTo(
                new Guid(0x21f7c32d, 0xeeaa, 0x439b, 0xbb, 0x51, 0x37, 0xb9, 0x6f, 0xd6, 0xa9, 0x43)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "EP_DetailsPane"/> property is correct.</summary>

    [Test]
    public static void EP_DetailsPaneTest()
    {
        Assert.That(
            EP_DetailsPane,
            Is.EqualTo(
                new Guid(0x43abf98b, 0x89b8, 0x472d, 0xb9, 0xce, 0xe6, 0x9b, 0x82, 0x29, 0xf0, 0x19)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "EP_PreviewPane"/> property is correct.</summary>

    [Test]
    public static void EP_PreviewPaneTest()
    {
        Assert.That(
            EP_PreviewPane,
            Is.EqualTo(
                new Guid(0x893c63d1, 0x45c8, 0x4d17, 0xbe, 0x19, 0x22, 0x3b, 0xe7, 0x1b, 0xe3, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "EP_QueryPane"/> property is correct.</summary>

    [Test]
    public static void EP_QueryPaneTest()
    {
        Assert.That(
            EP_QueryPane,
            Is.EqualTo(
                new Guid(0x65bcde4f, 0x4f07, 0x4f27, 0x83, 0xa7, 0x1a, 0xfc, 0xa4, 0xdf, 0x7d, 0xdd)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "EP_AdvQueryPane"/> property is correct.</summary>

    [Test]
    public static void EP_AdvQueryPaneTest()
    {
        Assert.That(
            EP_AdvQueryPane,
            Is.EqualTo(
                new Guid(0xb4e9db8b, 0x34ba, 0x4c39, 0xb5, 0xcc, 0x16, 0xa1, 0xbd, 0x2c, 0x41, 0x1c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "EP_StatusBar"/> property is correct.</summary>

    [Test]
    public static void EP_StatusBarTest()
    {
        Assert.That(
            EP_StatusBar,
            Is.EqualTo(
                new Guid(0x65fe56ce, 0x5cfe, 0x4bc4, 0xad, 0x8a, 0x7a, 0xe3, 0xfe, 0x7e, 0x8f, 0x7c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "EP_Ribbon"/> property is correct.</summary>

    [Test]
    public static void EP_RibbonTest()
    {
        Assert.That(
            EP_Ribbon,
            Is.EqualTo(
                new Guid(0xd27524a8, 0xc9f2, 0x4834, 0xa1, 0x6, 0xdf, 0x88, 0x89, 0xfd, 0x4f, 0x37)
            )
        );
    }
}
