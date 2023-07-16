// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FS_BPIO_RESULTS"/> struct.</summary>
public static unsafe partial class FS_BPIO_RESULTSTests
{
    /// <summary>Validates that the <see cref = "FS_BPIO_RESULTS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FS_BPIO_RESULTS>(), Is.EqualTo(sizeof(FS_BPIO_RESULTS)));
    }

    /// <summary>Validates that the <see cref = "FS_BPIO_RESULTS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FS_BPIO_RESULTS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FS_BPIO_RESULTS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FS_BPIO_RESULTS), Is.EqualTo(328));
    }
}