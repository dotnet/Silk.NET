// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WIN32_MEMORY_PARTITION_INFORMATION"/> struct.</summary>
public static unsafe partial class WIN32_MEMORY_PARTITION_INFORMATIONTests
{
    /// <summary>Validates that the <see cref = "WIN32_MEMORY_PARTITION_INFORMATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WIN32_MEMORY_PARTITION_INFORMATION>(), Is.EqualTo(sizeof(WIN32_MEMORY_PARTITION_INFORMATION)));
    }

    /// <summary>Validates that the <see cref = "WIN32_MEMORY_PARTITION_INFORMATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WIN32_MEMORY_PARTITION_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WIN32_MEMORY_PARTITION_INFORMATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WIN32_MEMORY_PARTITION_INFORMATION), Is.EqualTo(240));
    }
}