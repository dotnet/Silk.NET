// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE"/> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGETests
{
    /// <summary>Validates that the <see cref = "PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE>(),
            Is.EqualTo(sizeof(PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE))
        );
    }

    /// <summary>Validates that the <see cref = "PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(PROCESS_DYNAMIC_ENFORCED_ADDRESS_RANGE), Is.EqualTo(12));
        }
    }
}
