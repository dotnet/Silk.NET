// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.CATID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CATID"/> class.</summary>
public static partial class CATIDTests
{
    /// <summary>Validates that the value of the <see cref = "CATID_BrowsableShellExt"/> property is correct.</summary>
    [Test]
    public static void CATID_BrowsableShellExtTest()
    {
        Assert.That(CATID_BrowsableShellExt, Is.EqualTo(new Guid(0x00021490, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_BrowseInPlace"/> property is correct.</summary>
    [Test]
    public static void CATID_BrowseInPlaceTest()
    {
        Assert.That(CATID_BrowseInPlace, Is.EqualTo(new Guid(0x00021491, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_DeskBand"/> property is correct.</summary>
    [Test]
    public static void CATID_DeskBandTest()
    {
        Assert.That(CATID_DeskBand, Is.EqualTo(new Guid(0x00021492, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_InfoBand"/> property is correct.</summary>
    [Test]
    public static void CATID_InfoBandTest()
    {
        Assert.That(CATID_InfoBand, Is.EqualTo(new Guid(0x00021493, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_CommBand"/> property is correct.</summary>
    [Test]
    public static void CATID_CommBandTest()
    {
        Assert.That(CATID_CommBand, Is.EqualTo(new Guid(0x00021494, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_FilePlaceholderMergeHandler"/> property is correct.</summary>
    [Test]
    public static void CATID_FilePlaceholderMergeHandlerTest()
    {
        Assert.That(CATID_FilePlaceholderMergeHandler, Is.EqualTo(new Guid(0x3e9c9a51, 0xd4aa, 0x4870, 0xb4, 0x7c, 0x74, 0x24, 0xb4, 0x91, 0xf1, 0xcc)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_LocationFactory"/> property is correct.</summary>
    [Test]
    public static void CATID_LocationFactoryTest()
    {
        Assert.That(CATID_LocationFactory, Is.EqualTo(new Guid(0x965c4d51, 0x8b76, 0x4e57, 0x80, 0xb7, 0x56, 0x4d, 0x2e, 0xa4, 0xb5, 0x5e)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_LocationProvider"/> property is correct.</summary>
    [Test]
    public static void CATID_LocationProviderTest()
    {
        Assert.That(CATID_LocationProvider, Is.EqualTo(new Guid(0x1b3ca474, 0x2614, 0x414b, 0xb8, 0x13, 0x1a, 0xce, 0xca, 0x3e, 0x3d, 0xd8)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_SearchableApplication"/> property is correct.</summary>
    [Test]
    public static void CATID_SearchableApplicationTest()
    {
        Assert.That(CATID_SearchableApplication, Is.EqualTo(new Guid(0x366c292a, 0xd9b3, 0x4dbf, 0xbb, 0x70, 0xe6, 0x2e, 0xc3, 0xd0, 0xbb, 0xbf)));
    }
}