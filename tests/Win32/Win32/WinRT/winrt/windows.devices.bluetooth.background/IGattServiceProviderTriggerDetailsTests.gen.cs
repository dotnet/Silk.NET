// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IGattServiceProviderTriggerDetails"/> struct.</summary>
public static unsafe partial class IGattServiceProviderTriggerDetailsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IGattServiceProviderTriggerDetails"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IGattServiceProviderTriggerDetails).GUID,
            Is.EqualTo(IID_IGattServiceProviderTriggerDetails)
        );
    }

    /// <summary>Validates that the <see cref = "IGattServiceProviderTriggerDetails"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IGattServiceProviderTriggerDetails>(),
            Is.EqualTo(sizeof(IGattServiceProviderTriggerDetails))
        );
    }

    /// <summary>Validates that the <see cref = "IGattServiceProviderTriggerDetails"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IGattServiceProviderTriggerDetails).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IGattServiceProviderTriggerDetails"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IGattServiceProviderTriggerDetails), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IGattServiceProviderTriggerDetails), Is.EqualTo(4));
        }
    }
}
