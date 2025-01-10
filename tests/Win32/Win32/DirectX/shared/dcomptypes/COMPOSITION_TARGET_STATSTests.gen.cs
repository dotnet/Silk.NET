// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "COMPOSITION_TARGET_STATS"/> struct.</summary>
public static unsafe partial class COMPOSITION_TARGET_STATSTests
{
    /// <summary>Validates that the <see cref = "COMPOSITION_TARGET_STATS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<COMPOSITION_TARGET_STATS>(),
            Is.EqualTo(sizeof(COMPOSITION_TARGET_STATS))
        );
    }

    /// <summary>Validates that the <see cref = "COMPOSITION_TARGET_STATS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COMPOSITION_TARGET_STATS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "COMPOSITION_TARGET_STATS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(COMPOSITION_TARGET_STATS), Is.EqualTo(72));
    }
}
