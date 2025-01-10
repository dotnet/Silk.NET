// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CODECAPI_AVEncStatHardwareBandwidthUtilitization"/> struct.</summary>
public static unsafe partial class CODECAPI_AVEncStatHardwareBandwidthUtilitizationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "CODECAPI_AVEncStatHardwareBandwidthUtilitization"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(CODECAPI_AVEncStatHardwareBandwidthUtilitization).GUID,
            Is.EqualTo(IID_CODECAPI_AVEncStatHardwareBandwidthUtilitization)
        );
    }

    /// <summary>Validates that the <see cref = "CODECAPI_AVEncStatHardwareBandwidthUtilitization"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CODECAPI_AVEncStatHardwareBandwidthUtilitization>(),
            Is.EqualTo(sizeof(CODECAPI_AVEncStatHardwareBandwidthUtilitization))
        );
    }

    /// <summary>Validates that the <see cref = "CODECAPI_AVEncStatHardwareBandwidthUtilitization"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(CODECAPI_AVEncStatHardwareBandwidthUtilitization).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "CODECAPI_AVEncStatHardwareBandwidthUtilitization"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CODECAPI_AVEncStatHardwareBandwidthUtilitization), Is.EqualTo(1));
    }
}
