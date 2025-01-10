// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ICellularApnContext"/> struct.</summary>
public static unsafe partial class ICellularApnContextTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICellularApnContext"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICellularApnContext).GUID, Is.EqualTo(IID_ICellularApnContext));
    }

    /// <summary>Validates that the <see cref = "ICellularApnContext"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICellularApnContext>(), Is.EqualTo(sizeof(ICellularApnContext)));
    }

    /// <summary>Validates that the <see cref = "ICellularApnContext"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICellularApnContext).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICellularApnContext"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICellularApnContext), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICellularApnContext), Is.EqualTo(4));
        }
    }
}
