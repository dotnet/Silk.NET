// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SOCKET_PROCESSOR_AFFINITY"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class SOCKET_PROCESSOR_AFFINITYTests
{
    /// <summary>Validates that the <see cref = "SOCKET_PROCESSOR_AFFINITY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SOCKET_PROCESSOR_AFFINITY>(), Is.EqualTo(sizeof(SOCKET_PROCESSOR_AFFINITY)));
    }

    /// <summary>Validates that the <see cref = "SOCKET_PROCESSOR_AFFINITY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SOCKET_PROCESSOR_AFFINITY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SOCKET_PROCESSOR_AFFINITY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SOCKET_PROCESSOR_AFFINITY), Is.EqualTo(8));
    }
}