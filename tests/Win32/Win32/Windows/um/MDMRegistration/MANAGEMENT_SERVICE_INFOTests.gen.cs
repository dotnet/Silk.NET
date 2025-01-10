// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MANAGEMENT_SERVICE_INFO"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class MANAGEMENT_SERVICE_INFOTests
{
    /// <summary>Validates that the <see cref = "MANAGEMENT_SERVICE_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MANAGEMENT_SERVICE_INFO>(),
            Is.EqualTo(sizeof(MANAGEMENT_SERVICE_INFO))
        );
    }

    /// <summary>Validates that the <see cref = "MANAGEMENT_SERVICE_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MANAGEMENT_SERVICE_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MANAGEMENT_SERVICE_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MANAGEMENT_SERVICE_INFO), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(MANAGEMENT_SERVICE_INFO), Is.EqualTo(8));
        }
    }
}
