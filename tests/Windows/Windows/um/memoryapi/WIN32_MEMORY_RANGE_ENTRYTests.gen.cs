// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WIN32_MEMORY_RANGE_ENTRY"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class WIN32_MEMORY_RANGE_ENTRYTests
{
    /// <summary>Validates that the <see cref = "WIN32_MEMORY_RANGE_ENTRY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WIN32_MEMORY_RANGE_ENTRY>(), Is.EqualTo(sizeof(WIN32_MEMORY_RANGE_ENTRY)));
    }

    /// <summary>Validates that the <see cref = "WIN32_MEMORY_RANGE_ENTRY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WIN32_MEMORY_RANGE_ENTRY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WIN32_MEMORY_RANGE_ENTRY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WIN32_MEMORY_RANGE_ENTRY), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(WIN32_MEMORY_RANGE_ENTRY), Is.EqualTo(8));
        }
    }
}