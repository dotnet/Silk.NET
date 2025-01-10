// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "PointerDeviceUsage"/> struct.</summary>
public static unsafe partial class PointerDeviceUsageTests
{
    /// <summary>Validates that the <see cref = "PointerDeviceUsage"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PointerDeviceUsage>(), Is.EqualTo(sizeof(PointerDeviceUsage)));
    }

    /// <summary>Validates that the <see cref = "PointerDeviceUsage"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PointerDeviceUsage).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PointerDeviceUsage"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PointerDeviceUsage), Is.EqualTo(32));
    }
}
