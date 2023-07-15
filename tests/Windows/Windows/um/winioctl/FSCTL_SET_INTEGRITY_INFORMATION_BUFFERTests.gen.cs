// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FSCTL_SET_INTEGRITY_INFORMATION_BUFFER"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class FSCTL_SET_INTEGRITY_INFORMATION_BUFFERTests
{
    /// <summary>Validates that the <see cref = "FSCTL_SET_INTEGRITY_INFORMATION_BUFFER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FSCTL_SET_INTEGRITY_INFORMATION_BUFFER>(), Is.EqualTo(sizeof(FSCTL_SET_INTEGRITY_INFORMATION_BUFFER)));
    }

    /// <summary>Validates that the <see cref = "FSCTL_SET_INTEGRITY_INFORMATION_BUFFER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FSCTL_SET_INTEGRITY_INFORMATION_BUFFER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FSCTL_SET_INTEGRITY_INFORMATION_BUFFER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FSCTL_SET_INTEGRITY_INFORMATION_BUFFER), Is.EqualTo(8));
    }
}