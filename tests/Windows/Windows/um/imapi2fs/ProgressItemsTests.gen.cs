// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ProgressItems"/> struct.</summary>
public static unsafe partial class ProgressItemsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ProgressItems"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ProgressItems).GUID, Is.EqualTo(CLSID_ProgressItems));
    }

    /// <summary>Validates that the <see cref = "ProgressItems"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ProgressItems>(), Is.EqualTo(sizeof(ProgressItems)));
    }

    /// <summary>Validates that the <see cref = "ProgressItems"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ProgressItems).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ProgressItems"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ProgressItems), Is.EqualTo(1));
    }
}