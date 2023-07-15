// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ICMP_ERROR_INFO"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class ICMP_ERROR_INFOTests
{
    /// <summary>Validates that the <see cref = "ICMP_ERROR_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICMP_ERROR_INFO>(), Is.EqualTo(sizeof(ICMP_ERROR_INFO)));
    }

    /// <summary>Validates that the <see cref = "ICMP_ERROR_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICMP_ERROR_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICMP_ERROR_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ICMP_ERROR_INFO), Is.EqualTo(36));
    }
}