// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IDeviceUnpairingResult"/> struct.</summary>
public static unsafe partial class IDeviceUnpairingResultTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDeviceUnpairingResult"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDeviceUnpairingResult).GUID, Is.EqualTo(IID_IDeviceUnpairingResult));
    }

    /// <summary>Validates that the <see cref = "IDeviceUnpairingResult"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IDeviceUnpairingResult>(),
            Is.EqualTo(sizeof(IDeviceUnpairingResult))
        );
    }

    /// <summary>Validates that the <see cref = "IDeviceUnpairingResult"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDeviceUnpairingResult).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDeviceUnpairingResult"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDeviceUnpairingResult), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDeviceUnpairingResult), Is.EqualTo(4));
        }
    }
}
