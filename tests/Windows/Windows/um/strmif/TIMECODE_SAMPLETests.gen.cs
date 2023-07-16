// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TIMECODE_SAMPLE"/> struct.</summary>
public static unsafe partial class TIMECODE_SAMPLETests
{
    /// <summary>Validates that the <see cref = "TIMECODE_SAMPLE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TIMECODE_SAMPLE>(), Is.EqualTo(sizeof(TIMECODE_SAMPLE)));
    }

    /// <summary>Validates that the <see cref = "TIMECODE_SAMPLE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TIMECODE_SAMPLE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TIMECODE_SAMPLE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TIMECODE_SAMPLE), Is.EqualTo(24));
    }
}