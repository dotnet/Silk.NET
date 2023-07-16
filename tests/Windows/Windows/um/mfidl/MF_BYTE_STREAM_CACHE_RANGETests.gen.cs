// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MF_BYTE_STREAM_CACHE_RANGE"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class MF_BYTE_STREAM_CACHE_RANGETests
{
    /// <summary>Validates that the <see cref = "MF_BYTE_STREAM_CACHE_RANGE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MF_BYTE_STREAM_CACHE_RANGE>(), Is.EqualTo(sizeof(MF_BYTE_STREAM_CACHE_RANGE)));
    }

    /// <summary>Validates that the <see cref = "MF_BYTE_STREAM_CACHE_RANGE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MF_BYTE_STREAM_CACHE_RANGE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MF_BYTE_STREAM_CACHE_RANGE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MF_BYTE_STREAM_CACHE_RANGE), Is.EqualTo(16));
    }
}