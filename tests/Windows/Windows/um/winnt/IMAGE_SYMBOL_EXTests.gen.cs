// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMAGE_SYMBOL_EX"/> struct.</summary>
public static unsafe partial class IMAGE_SYMBOL_EXTests
{
    /// <summary>Validates that the <see cref = "IMAGE_SYMBOL_EX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMAGE_SYMBOL_EX>(), Is.EqualTo(sizeof(IMAGE_SYMBOL_EX)));
    }

    /// <summary>Validates that the <see cref = "IMAGE_SYMBOL_EX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGE_SYMBOL_EX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMAGE_SYMBOL_EX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGE_SYMBOL_EX), Is.EqualTo(20));
    }
}