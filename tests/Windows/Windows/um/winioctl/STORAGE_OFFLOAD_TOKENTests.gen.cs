// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "STORAGE_OFFLOAD_TOKEN"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class STORAGE_OFFLOAD_TOKENTests
{
    /// <summary>Validates that the <see cref = "STORAGE_OFFLOAD_TOKEN"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STORAGE_OFFLOAD_TOKEN>(), Is.EqualTo(sizeof(STORAGE_OFFLOAD_TOKEN)));
    }

    /// <summary>Validates that the <see cref = "STORAGE_OFFLOAD_TOKEN"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_OFFLOAD_TOKEN).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_OFFLOAD_TOKEN"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_OFFLOAD_TOKEN), Is.EqualTo(512));
    }
}