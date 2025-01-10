// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IGattDeviceServicesResult"/> struct.</summary>
public static unsafe partial class IGattDeviceServicesResultTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IGattDeviceServicesResult"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IGattDeviceServicesResult).GUID,
            Is.EqualTo(IID_IGattDeviceServicesResult)
        );
    }

    /// <summary>Validates that the <see cref = "IGattDeviceServicesResult"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IGattDeviceServicesResult>(),
            Is.EqualTo(sizeof(IGattDeviceServicesResult))
        );
    }

    /// <summary>Validates that the <see cref = "IGattDeviceServicesResult"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IGattDeviceServicesResult).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IGattDeviceServicesResult"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IGattDeviceServicesResult), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IGattDeviceServicesResult), Is.EqualTo(4));
        }
    }
}
