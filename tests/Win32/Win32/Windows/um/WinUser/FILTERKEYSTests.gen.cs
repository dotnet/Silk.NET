// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "FILTERKEYS"/> struct.</summary>
public static unsafe partial class FILTERKEYSTests
{
    /// <summary>Validates that the <see cref = "FILTERKEYS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FILTERKEYS>(), Is.EqualTo(sizeof(FILTERKEYS)));
    }

    /// <summary>Validates that the <see cref = "FILTERKEYS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FILTERKEYS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FILTERKEYS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FILTERKEYS), Is.EqualTo(24));
    }
}
