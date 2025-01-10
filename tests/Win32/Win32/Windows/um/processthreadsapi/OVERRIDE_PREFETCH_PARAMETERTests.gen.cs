// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "OVERRIDE_PREFETCH_PARAMETER"/> struct.</summary>
public static unsafe partial class OVERRIDE_PREFETCH_PARAMETERTests
{
    /// <summary>Validates that the <see cref = "OVERRIDE_PREFETCH_PARAMETER"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<OVERRIDE_PREFETCH_PARAMETER>(),
            Is.EqualTo(sizeof(OVERRIDE_PREFETCH_PARAMETER))
        );
    }

    /// <summary>Validates that the <see cref = "OVERRIDE_PREFETCH_PARAMETER"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OVERRIDE_PREFETCH_PARAMETER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "OVERRIDE_PREFETCH_PARAMETER"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(OVERRIDE_PREFETCH_PARAMETER), Is.EqualTo(4));
    }
}
