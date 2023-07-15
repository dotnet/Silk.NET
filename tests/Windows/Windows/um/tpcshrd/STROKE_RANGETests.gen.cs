// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "STROKE_RANGE"/> struct.</summary>
public static unsafe partial class STROKE_RANGETests
{
    /// <summary>Validates that the <see cref = "STROKE_RANGE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STROKE_RANGE>(), Is.EqualTo(sizeof(STROKE_RANGE)));
    }

    /// <summary>Validates that the <see cref = "STROKE_RANGE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STROKE_RANGE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STROKE_RANGE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STROKE_RANGE), Is.EqualTo(8));
    }
}