// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDirectInputDeviceA"/> struct.</summary>
public static unsafe partial class IDirectInputDeviceATests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDirectInputDeviceA"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectInputDeviceA).GUID, Is.EqualTo(IID_IDirectInputDeviceA));
    }

    /// <summary>Validates that the <see cref = "IDirectInputDeviceA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDirectInputDeviceA>(), Is.EqualTo(sizeof(IDirectInputDeviceA)));
    }

    /// <summary>Validates that the <see cref = "IDirectInputDeviceA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirectInputDeviceA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDirectInputDeviceA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirectInputDeviceA), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirectInputDeviceA), Is.EqualTo(4));
        }
    }
}