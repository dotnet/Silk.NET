// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PROCESS_POWER_THROTTLING_STATE"/> struct.</summary>
public static unsafe partial class PROCESS_POWER_THROTTLING_STATETests
{
    /// <summary>Validates that the <see cref = "PROCESS_POWER_THROTTLING_STATE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PROCESS_POWER_THROTTLING_STATE>(), Is.EqualTo(sizeof(PROCESS_POWER_THROTTLING_STATE)));
    }

    /// <summary>Validates that the <see cref = "PROCESS_POWER_THROTTLING_STATE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PROCESS_POWER_THROTTLING_STATE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PROCESS_POWER_THROTTLING_STATE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PROCESS_POWER_THROTTLING_STATE), Is.EqualTo(12));
    }
}