// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "FsiDirectoryItem"/> struct.</summary>
public static unsafe partial class FsiDirectoryItemTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "FsiDirectoryItem"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(FsiDirectoryItem).GUID, Is.EqualTo(CLSID_FsiDirectoryItem));
    }

    /// <summary>Validates that the <see cref = "FsiDirectoryItem"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FsiDirectoryItem>(), Is.EqualTo(sizeof(FsiDirectoryItem)));
    }

    /// <summary>Validates that the <see cref = "FsiDirectoryItem"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FsiDirectoryItem).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FsiDirectoryItem"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FsiDirectoryItem), Is.EqualTo(1));
    }
}
