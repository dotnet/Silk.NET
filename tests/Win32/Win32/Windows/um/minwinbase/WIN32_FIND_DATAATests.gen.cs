// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WIN32_FIND_DATAA"/> struct.</summary>
public static unsafe partial class WIN32_FIND_DATAATests
{
    /// <summary>Validates that the <see cref = "WIN32_FIND_DATAA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WIN32_FIND_DATAA>(), Is.EqualTo(sizeof(WIN32_FIND_DATAA)));
    }

    /// <summary>Validates that the <see cref = "WIN32_FIND_DATAA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WIN32_FIND_DATAA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WIN32_FIND_DATAA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WIN32_FIND_DATAA), Is.EqualTo(320));
    }
}
