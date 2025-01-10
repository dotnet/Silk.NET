// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "UMS_SCHEDULER_STARTUP_INFO"/> struct.</summary>
public static unsafe partial class UMS_SCHEDULER_STARTUP_INFOTests
{
    /// <summary>Validates that the <see cref = "UMS_SCHEDULER_STARTUP_INFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<UMS_SCHEDULER_STARTUP_INFO>(),
            Is.EqualTo(sizeof(UMS_SCHEDULER_STARTUP_INFO))
        );
    }

    /// <summary>Validates that the <see cref = "UMS_SCHEDULER_STARTUP_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(UMS_SCHEDULER_STARTUP_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "UMS_SCHEDULER_STARTUP_INFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(UMS_SCHEDULER_STARTUP_INFO), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(UMS_SCHEDULER_STARTUP_INFO), Is.EqualTo(16));
        }
    }
}
