// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "BIN_RESULTS"/> struct.</summary>
public static unsafe partial class BIN_RESULTSTests
{
    /// <summary>Validates that the <see cref = "BIN_RESULTS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BIN_RESULTS>(), Is.EqualTo(sizeof(BIN_RESULTS)));
    }

    /// <summary>Validates that the <see cref = "BIN_RESULTS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BIN_RESULTS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BIN_RESULTS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BIN_RESULTS), Is.EqualTo(32));
    }
}
