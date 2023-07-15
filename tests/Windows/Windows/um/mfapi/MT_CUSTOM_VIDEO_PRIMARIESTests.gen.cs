// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MT_CUSTOM_VIDEO_PRIMARIES"/> struct.</summary>
public static unsafe partial class MT_CUSTOM_VIDEO_PRIMARIESTests
{
    /// <summary>Validates that the <see cref = "MT_CUSTOM_VIDEO_PRIMARIES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MT_CUSTOM_VIDEO_PRIMARIES>(), Is.EqualTo(sizeof(MT_CUSTOM_VIDEO_PRIMARIES)));
    }

    /// <summary>Validates that the <see cref = "MT_CUSTOM_VIDEO_PRIMARIES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MT_CUSTOM_VIDEO_PRIMARIES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MT_CUSTOM_VIDEO_PRIMARIES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MT_CUSTOM_VIDEO_PRIMARIES), Is.EqualTo(32));
    }
}