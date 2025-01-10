// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IGyrometer"/> struct.</summary>
public static unsafe partial class IGyrometerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IGyrometer"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IGyrometer).GUID, Is.EqualTo(IID_IGyrometer));
    }

    /// <summary>Validates that the <see cref = "IGyrometer"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IGyrometer>(), Is.EqualTo(sizeof(IGyrometer)));
    }

    /// <summary>Validates that the <see cref = "IGyrometer"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IGyrometer).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IGyrometer"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IGyrometer), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IGyrometer), Is.EqualTo(4));
        }
    }
}
