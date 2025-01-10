// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DEVICE_DATA_SET_LB_PROVISIONING_STATE"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class DEVICE_DATA_SET_LB_PROVISIONING_STATETests
{
    /// <summary>Validates that the <see cref = "DEVICE_DATA_SET_LB_PROVISIONING_STATE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DEVICE_DATA_SET_LB_PROVISIONING_STATE>(),
            Is.EqualTo(sizeof(DEVICE_DATA_SET_LB_PROVISIONING_STATE))
        );
    }

    /// <summary>Validates that the <see cref = "DEVICE_DATA_SET_LB_PROVISIONING_STATE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DEVICE_DATA_SET_LB_PROVISIONING_STATE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DEVICE_DATA_SET_LB_PROVISIONING_STATE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DEVICE_DATA_SET_LB_PROVISIONING_STATE), Is.EqualTo(32));
    }
}
