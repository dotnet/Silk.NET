// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/compressapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "COMPRESS_ALLOCATION_ROUTINES"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class COMPRESS_ALLOCATION_ROUTINESTests
{
    /// <summary>Validates that the <see cref = "COMPRESS_ALLOCATION_ROUTINES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<COMPRESS_ALLOCATION_ROUTINES>(), Is.EqualTo(sizeof(COMPRESS_ALLOCATION_ROUTINES)));
    }

    /// <summary>Validates that the <see cref = "COMPRESS_ALLOCATION_ROUTINES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COMPRESS_ALLOCATION_ROUTINES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "COMPRESS_ALLOCATION_ROUTINES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(COMPRESS_ALLOCATION_ROUTINES), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(COMPRESS_ALLOCATION_ROUTINES), Is.EqualTo(12));
        }
    }
}