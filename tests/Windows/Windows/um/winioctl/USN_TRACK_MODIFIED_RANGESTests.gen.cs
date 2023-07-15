// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "USN_TRACK_MODIFIED_RANGES"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class USN_TRACK_MODIFIED_RANGESTests
{
    /// <summary>Validates that the <see cref = "USN_TRACK_MODIFIED_RANGES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<USN_TRACK_MODIFIED_RANGES>(), Is.EqualTo(sizeof(USN_TRACK_MODIFIED_RANGES)));
    }

    /// <summary>Validates that the <see cref = "USN_TRACK_MODIFIED_RANGES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(USN_TRACK_MODIFIED_RANGES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "USN_TRACK_MODIFIED_RANGES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(USN_TRACK_MODIFIED_RANGES), Is.EqualTo(24));
    }
}