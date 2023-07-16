// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FILE_PREFETCH_EX"/> struct.</summary>
public static unsafe partial class FILE_PREFETCH_EXTests
{
    /// <summary>Validates that the <see cref = "FILE_PREFETCH_EX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FILE_PREFETCH_EX>(), Is.EqualTo(sizeof(FILE_PREFETCH_EX)));
    }

    /// <summary>Validates that the <see cref = "FILE_PREFETCH_EX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FILE_PREFETCH_EX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FILE_PREFETCH_EX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FILE_PREFETCH_EX), Is.EqualTo(24));
    }
}