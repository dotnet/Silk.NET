// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IPanelBasedOptimizationControl"/> struct.</summary>
public static unsafe partial class IPanelBasedOptimizationControlTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPanelBasedOptimizationControl"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IPanelBasedOptimizationControl).GUID,
            Is.EqualTo(IID_IPanelBasedOptimizationControl)
        );
    }

    /// <summary>Validates that the <see cref = "IPanelBasedOptimizationControl"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IPanelBasedOptimizationControl>(),
            Is.EqualTo(sizeof(IPanelBasedOptimizationControl))
        );
    }

    /// <summary>Validates that the <see cref = "IPanelBasedOptimizationControl"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPanelBasedOptimizationControl).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPanelBasedOptimizationControl"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPanelBasedOptimizationControl), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPanelBasedOptimizationControl), Is.EqualTo(4));
        }
    }
}
