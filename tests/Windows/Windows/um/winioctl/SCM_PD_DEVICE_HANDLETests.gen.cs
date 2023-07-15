// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SCM_PD_DEVICE_HANDLE"/> struct.</summary>
public static unsafe partial class SCM_PD_DEVICE_HANDLETests
{
    /// <summary>Validates that the <see cref = "SCM_PD_DEVICE_HANDLE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SCM_PD_DEVICE_HANDLE>(), Is.EqualTo(sizeof(SCM_PD_DEVICE_HANDLE)));
    }

    /// <summary>Validates that the <see cref = "SCM_PD_DEVICE_HANDLE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SCM_PD_DEVICE_HANDLE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SCM_PD_DEVICE_HANDLE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SCM_PD_DEVICE_HANDLE), Is.EqualTo(28));
    }
}