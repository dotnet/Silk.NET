// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SpatialAudioHrtfDirectivityCone"/> struct.</summary>
public static unsafe partial class SpatialAudioHrtfDirectivityConeTests
{
    /// <summary>Validates that the <see cref = "SpatialAudioHrtfDirectivityCone"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SpatialAudioHrtfDirectivityCone>(),
            Is.EqualTo(sizeof(SpatialAudioHrtfDirectivityCone))
        );
    }

    /// <summary>Validates that the <see cref = "SpatialAudioHrtfDirectivityCone"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpatialAudioHrtfDirectivityCone).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpatialAudioHrtfDirectivityCone"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SpatialAudioHrtfDirectivityCone), Is.EqualTo(16));
    }
}
