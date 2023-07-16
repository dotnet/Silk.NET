// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.EVRConfig;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EVRConfig"/> class.</summary>
public static partial class EVRConfigTests
{
    /// <summary>Validates that the value of the <see cref = "EVRConfig_ForceBob"/> property is correct.</summary>
    [Test]
    public static void EVRConfig_ForceBobTest()
    {
        Assert.That(EVRConfig_ForceBob, Is.EqualTo(new Guid(0xe447df01, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "EVRConfig_AllowDropToBob"/> property is correct.</summary>
    [Test]
    public static void EVRConfig_AllowDropToBobTest()
    {
        Assert.That(EVRConfig_AllowDropToBob, Is.EqualTo(new Guid(0xe447df02, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "EVRConfig_ForceThrottle"/> property is correct.</summary>
    [Test]
    public static void EVRConfig_ForceThrottleTest()
    {
        Assert.That(EVRConfig_ForceThrottle, Is.EqualTo(new Guid(0xe447df03, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "EVRConfig_AllowDropToThrottle"/> property is correct.</summary>
    [Test]
    public static void EVRConfig_AllowDropToThrottleTest()
    {
        Assert.That(EVRConfig_AllowDropToThrottle, Is.EqualTo(new Guid(0xe447df04, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "EVRConfig_ForceHalfInterlace"/> property is correct.</summary>
    [Test]
    public static void EVRConfig_ForceHalfInterlaceTest()
    {
        Assert.That(EVRConfig_ForceHalfInterlace, Is.EqualTo(new Guid(0xe447df05, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "EVRConfig_AllowDropToHalfInterlace"/> property is correct.</summary>
    [Test]
    public static void EVRConfig_AllowDropToHalfInterlaceTest()
    {
        Assert.That(EVRConfig_AllowDropToHalfInterlace, Is.EqualTo(new Guid(0xe447df06, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "EVRConfig_ForceScaling"/> property is correct.</summary>
    [Test]
    public static void EVRConfig_ForceScalingTest()
    {
        Assert.That(EVRConfig_ForceScaling, Is.EqualTo(new Guid(0xe447df07, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "EVRConfig_AllowScaling"/> property is correct.</summary>
    [Test]
    public static void EVRConfig_AllowScalingTest()
    {
        Assert.That(EVRConfig_AllowScaling, Is.EqualTo(new Guid(0xe447df08, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "EVRConfig_ForceBatching"/> property is correct.</summary>
    [Test]
    public static void EVRConfig_ForceBatchingTest()
    {
        Assert.That(EVRConfig_ForceBatching, Is.EqualTo(new Guid(0xe447df09, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "EVRConfig_AllowBatching"/> property is correct.</summary>
    [Test]
    public static void EVRConfig_AllowBatchingTest()
    {
        Assert.That(EVRConfig_AllowBatching, Is.EqualTo(new Guid(0xe447df0a, 0x10ca, 0x4d17, 0xb1, 0x7e, 0x6a, 0x84, 0x0f, 0x8a, 0x3a, 0x4c)));
    }
}