// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "EventDataColocationDiscoveryResultMETA"/> struct.</summary>
public static unsafe partial class XrEventDataColocationDiscoveryResultMETATests
{
    /// <summary>Validates that the <see cref = "EventDataColocationDiscoveryResultMETA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<EventDataColocationDiscoveryResultMETA>(),
            Is.EqualTo(sizeof(EventDataColocationDiscoveryResultMETA))
        );
    }

    /// <summary>Validates that the <see cref = "EventDataColocationDiscoveryResultMETA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EventDataColocationDiscoveryResultMETA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EventDataColocationDiscoveryResultMETA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(EventDataColocationDiscoveryResultMETA), Is.EqualTo(1072));
        }
        else
        {
            Assert.That(sizeof(EventDataColocationDiscoveryResultMETA), Is.EqualTo(1064));
        }
    }
}
