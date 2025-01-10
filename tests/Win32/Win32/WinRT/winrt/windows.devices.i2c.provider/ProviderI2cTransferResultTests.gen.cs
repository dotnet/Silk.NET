// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.i2c.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ProviderI2cTransferResult"/> struct.</summary>
public static unsafe partial class ProviderI2cTransferResultTests
{
    /// <summary>Validates that the <see cref = "ProviderI2cTransferResult"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ProviderI2cTransferResult>(),
            Is.EqualTo(sizeof(ProviderI2cTransferResult))
        );
    }

    /// <summary>Validates that the <see cref = "ProviderI2cTransferResult"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ProviderI2cTransferResult).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ProviderI2cTransferResult"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ProviderI2cTransferResult), Is.EqualTo(8));
    }
}
