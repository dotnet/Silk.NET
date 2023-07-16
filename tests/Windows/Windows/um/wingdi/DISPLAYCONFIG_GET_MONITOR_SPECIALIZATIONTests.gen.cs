// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION"/> struct.</summary>
public static unsafe partial class DISPLAYCONFIG_GET_MONITOR_SPECIALIZATIONTests
{
    /// <summary>Validates that the <see cref = "DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION>(), Is.EqualTo(sizeof(DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION)));
    }

    /// <summary>Validates that the <see cref = "DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DISPLAYCONFIG_GET_MONITOR_SPECIALIZATION), Is.EqualTo(24));
    }
}