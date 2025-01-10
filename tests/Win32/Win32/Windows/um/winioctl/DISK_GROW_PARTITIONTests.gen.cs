// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DISK_GROW_PARTITION"/> struct.</summary>
public static unsafe partial class DISK_GROW_PARTITIONTests
{
    /// <summary>Validates that the <see cref = "DISK_GROW_PARTITION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DISK_GROW_PARTITION>(), Is.EqualTo(sizeof(DISK_GROW_PARTITION)));
    }

    /// <summary>Validates that the <see cref = "DISK_GROW_PARTITION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DISK_GROW_PARTITION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DISK_GROW_PARTITION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DISK_GROW_PARTITION), Is.EqualTo(16));
    }
}
