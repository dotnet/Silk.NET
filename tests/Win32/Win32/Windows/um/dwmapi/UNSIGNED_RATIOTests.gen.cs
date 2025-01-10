// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "UNSIGNED_RATIO"/> struct.</summary>
public static unsafe partial class UNSIGNED_RATIOTests
{
    /// <summary>Validates that the <see cref = "UNSIGNED_RATIO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<UNSIGNED_RATIO>(), Is.EqualTo(sizeof(UNSIGNED_RATIO)));
    }

    /// <summary>Validates that the <see cref = "UNSIGNED_RATIO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(UNSIGNED_RATIO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "UNSIGNED_RATIO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(UNSIGNED_RATIO), Is.EqualTo(8));
    }
}
