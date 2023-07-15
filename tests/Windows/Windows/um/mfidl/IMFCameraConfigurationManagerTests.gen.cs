// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFCameraConfigurationManager"/> struct.</summary>
public static unsafe partial class IMFCameraConfigurationManagerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFCameraConfigurationManager"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFCameraConfigurationManager).GUID, Is.EqualTo(IID_IMFCameraConfigurationManager));
    }

    /// <summary>Validates that the <see cref = "IMFCameraConfigurationManager"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFCameraConfigurationManager>(), Is.EqualTo(sizeof(IMFCameraConfigurationManager)));
    }

    /// <summary>Validates that the <see cref = "IMFCameraConfigurationManager"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFCameraConfigurationManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFCameraConfigurationManager"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFCameraConfigurationManager), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFCameraConfigurationManager), Is.EqualTo(4));
        }
    }
}