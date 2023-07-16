// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "STORAGE_OFFLOAD_READ_OUTPUT"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class STORAGE_OFFLOAD_READ_OUTPUTTests
{
    /// <summary>Validates that the <see cref = "STORAGE_OFFLOAD_READ_OUTPUT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STORAGE_OFFLOAD_READ_OUTPUT>(), Is.EqualTo(sizeof(STORAGE_OFFLOAD_READ_OUTPUT)));
    }

    /// <summary>Validates that the <see cref = "STORAGE_OFFLOAD_READ_OUTPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_OFFLOAD_READ_OUTPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_OFFLOAD_READ_OUTPUT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_OFFLOAD_READ_OUTPUT), Is.EqualTo(536));
    }
}