// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IWakeOnApproachOptions"/> struct.</summary>
public static unsafe partial class IWakeOnApproachOptionsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWakeOnApproachOptions"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWakeOnApproachOptions).GUID, Is.EqualTo(IID_IWakeOnApproachOptions));
    }

    /// <summary>Validates that the <see cref = "IWakeOnApproachOptions"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IWakeOnApproachOptions>(),
            Is.EqualTo(sizeof(IWakeOnApproachOptions))
        );
    }

    /// <summary>Validates that the <see cref = "IWakeOnApproachOptions"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWakeOnApproachOptions).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWakeOnApproachOptions"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWakeOnApproachOptions), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWakeOnApproachOptions), Is.EqualTo(4));
        }
    }
}
