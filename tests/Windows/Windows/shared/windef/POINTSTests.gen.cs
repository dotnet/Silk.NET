// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/windef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "POINTS"/> struct.</summary>
public static unsafe partial class POINTSTests
{
    /// <summary>Validates that the <see cref = "POINTS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<POINTS>(), Is.EqualTo(sizeof(POINTS)));
    }

    /// <summary>Validates that the <see cref = "POINTS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(POINTS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "POINTS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(POINTS), Is.EqualTo(4));
    }
}