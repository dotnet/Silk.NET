// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Windows.Devices.Display.Core.Interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IDisplayDeviceInterop"/> struct.</summary>
public static unsafe partial class IDisplayDeviceInteropTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDisplayDeviceInterop"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDisplayDeviceInterop).GUID, Is.EqualTo(IID_IDisplayDeviceInterop));
    }

    /// <summary>Validates that the <see cref = "IDisplayDeviceInterop"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDisplayDeviceInterop>(), Is.EqualTo(sizeof(IDisplayDeviceInterop)));
    }

    /// <summary>Validates that the <see cref = "IDisplayDeviceInterop"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDisplayDeviceInterop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDisplayDeviceInterop"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDisplayDeviceInterop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDisplayDeviceInterop), Is.EqualTo(4));
        }
    }
}