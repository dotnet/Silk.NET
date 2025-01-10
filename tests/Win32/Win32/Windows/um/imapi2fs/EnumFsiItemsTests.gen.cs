// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "EnumFsiItems"/> struct.</summary>
public static unsafe partial class EnumFsiItemsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "EnumFsiItems"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(EnumFsiItems).GUID, Is.EqualTo(CLSID_EnumFsiItems));
    }

    /// <summary>Validates that the <see cref = "EnumFsiItems"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EnumFsiItems>(), Is.EqualTo(sizeof(EnumFsiItems)));
    }

    /// <summary>Validates that the <see cref = "EnumFsiItems"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EnumFsiItems).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EnumFsiItems"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EnumFsiItems), Is.EqualTo(1));
    }
}
