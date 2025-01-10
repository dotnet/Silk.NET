// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "AlphabeticalCategorizer"/> struct.</summary>
public static unsafe partial class AlphabeticalCategorizerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "AlphabeticalCategorizer"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(AlphabeticalCategorizer).GUID, Is.EqualTo(IID_AlphabeticalCategorizer));
    }

    /// <summary>Validates that the <see cref = "AlphabeticalCategorizer"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<AlphabeticalCategorizer>(),
            Is.EqualTo(sizeof(AlphabeticalCategorizer))
        );
    }

    /// <summary>Validates that the <see cref = "AlphabeticalCategorizer"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AlphabeticalCategorizer).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AlphabeticalCategorizer"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AlphabeticalCategorizer), Is.EqualTo(1));
    }
}
