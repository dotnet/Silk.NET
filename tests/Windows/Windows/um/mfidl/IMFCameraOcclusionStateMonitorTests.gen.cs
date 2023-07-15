// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFCameraOcclusionStateMonitor"/> struct.</summary>
public static unsafe partial class IMFCameraOcclusionStateMonitorTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFCameraOcclusionStateMonitor"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFCameraOcclusionStateMonitor).GUID, Is.EqualTo(IID_IMFCameraOcclusionStateMonitor));
    }

    /// <summary>Validates that the <see cref = "IMFCameraOcclusionStateMonitor"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFCameraOcclusionStateMonitor>(), Is.EqualTo(sizeof(IMFCameraOcclusionStateMonitor)));
    }

    /// <summary>Validates that the <see cref = "IMFCameraOcclusionStateMonitor"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFCameraOcclusionStateMonitor).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFCameraOcclusionStateMonitor"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFCameraOcclusionStateMonitor), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFCameraOcclusionStateMonitor), Is.EqualTo(4));
        }
    }
}