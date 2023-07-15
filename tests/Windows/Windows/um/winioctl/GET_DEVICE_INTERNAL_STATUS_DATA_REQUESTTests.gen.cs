// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST"/> struct.</summary>
public static unsafe partial class GET_DEVICE_INTERNAL_STATUS_DATA_REQUESTTests
{
    /// <summary>Validates that the <see cref = "GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST>(), Is.EqualTo(sizeof(GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST)));
    }

    /// <summary>Validates that the <see cref = "GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST), Is.EqualTo(16));
    }
}