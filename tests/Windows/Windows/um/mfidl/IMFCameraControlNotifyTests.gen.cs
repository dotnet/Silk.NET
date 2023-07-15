// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFCameraControlNotify"/> struct.</summary>
public static unsafe partial class IMFCameraControlNotifyTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFCameraControlNotify"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFCameraControlNotify).GUID, Is.EqualTo(IID_IMFCameraControlNotify));
    }

    /// <summary>Validates that the <see cref = "IMFCameraControlNotify"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFCameraControlNotify>(), Is.EqualTo(sizeof(IMFCameraControlNotify)));
    }

    /// <summary>Validates that the <see cref = "IMFCameraControlNotify"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFCameraControlNotify).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFCameraControlNotify"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFCameraControlNotify), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFCameraControlNotify), Is.EqualTo(4));
        }
    }
}