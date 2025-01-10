// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "FPODATA"/> struct.</summary>
public static unsafe partial class FPODATATests
{
    /// <summary>Validates that the <see cref = "FPODATA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FPODATA>(), Is.EqualTo(sizeof(FPODATA)));
    }

    /// <summary>Validates that the <see cref = "FPODATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FPODATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FPODATA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FPODATA), Is.EqualTo(16));
    }
}
