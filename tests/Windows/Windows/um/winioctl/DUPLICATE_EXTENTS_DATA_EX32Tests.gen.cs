// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DUPLICATE_EXTENTS_DATA_EX32"/> struct.</summary>
public static unsafe partial class DUPLICATE_EXTENTS_DATA_EX32Tests
{
    /// <summary>Validates that the <see cref = "DUPLICATE_EXTENTS_DATA_EX32"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DUPLICATE_EXTENTS_DATA_EX32>(), Is.EqualTo(sizeof(DUPLICATE_EXTENTS_DATA_EX32)));
    }

    /// <summary>Validates that the <see cref = "DUPLICATE_EXTENTS_DATA_EX32"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DUPLICATE_EXTENTS_DATA_EX32).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DUPLICATE_EXTENTS_DATA_EX32"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DUPLICATE_EXTENTS_DATA_EX32), Is.EqualTo(40));
    }
}