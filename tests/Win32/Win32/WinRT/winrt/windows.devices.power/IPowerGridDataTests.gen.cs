// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.power.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IPowerGridData"/> struct.</summary>
public static unsafe partial class IPowerGridDataTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPowerGridData"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPowerGridData).GUID, Is.EqualTo(IID_IPowerGridData));
    }

    /// <summary>Validates that the <see cref = "IPowerGridData"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPowerGridData>(), Is.EqualTo(sizeof(IPowerGridData)));
    }

    /// <summary>Validates that the <see cref = "IPowerGridData"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPowerGridData).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPowerGridData"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPowerGridData), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPowerGridData), Is.EqualTo(4));
        }
    }
}
