// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ISystemMemoryUsageReport"/> struct.</summary>
public static unsafe partial class ISystemMemoryUsageReportTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISystemMemoryUsageReport"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ISystemMemoryUsageReport).GUID,
            Is.EqualTo(IID_ISystemMemoryUsageReport)
        );
    }

    /// <summary>Validates that the <see cref = "ISystemMemoryUsageReport"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ISystemMemoryUsageReport>(),
            Is.EqualTo(sizeof(ISystemMemoryUsageReport))
        );
    }

    /// <summary>Validates that the <see cref = "ISystemMemoryUsageReport"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISystemMemoryUsageReport).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISystemMemoryUsageReport"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISystemMemoryUsageReport), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISystemMemoryUsageReport), Is.EqualTo(4));
        }
    }
}
