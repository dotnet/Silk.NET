// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluscolor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "Color"/> struct.</summary>
public static unsafe partial class ColorTests
{
    /// <summary>Validates that the <see cref = "Color"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<Color>(), Is.EqualTo(sizeof(Color)));
    }

    /// <summary>Validates that the <see cref = "Color"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Color).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "Color"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Color), Is.EqualTo(4));
    }
}