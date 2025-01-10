// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ICoreWindowResizeManagerLayoutCapability"/> struct.</summary>
public static unsafe partial class ICoreWindowResizeManagerLayoutCapabilityTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICoreWindowResizeManagerLayoutCapability"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ICoreWindowResizeManagerLayoutCapability).GUID,
            Is.EqualTo(IID_ICoreWindowResizeManagerLayoutCapability)
        );
    }

    /// <summary>Validates that the <see cref = "ICoreWindowResizeManagerLayoutCapability"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ICoreWindowResizeManagerLayoutCapability>(),
            Is.EqualTo(sizeof(ICoreWindowResizeManagerLayoutCapability))
        );
    }

    /// <summary>Validates that the <see cref = "ICoreWindowResizeManagerLayoutCapability"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICoreWindowResizeManagerLayoutCapability).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICoreWindowResizeManagerLayoutCapability"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICoreWindowResizeManagerLayoutCapability), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICoreWindowResizeManagerLayoutCapability), Is.EqualTo(4));
        }
    }
}
