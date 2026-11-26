// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "EventDataEventsLost"/> struct.</summary>
public static unsafe partial class XrEventDataEventsLostTests
{
    /// <summary>Validates that the <see cref = "EventDataEventsLost"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EventDataEventsLost>(), Is.EqualTo(sizeof(EventDataEventsLost)));
    }

    /// <summary>Validates that the <see cref = "EventDataEventsLost"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EventDataEventsLost).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EventDataEventsLost"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(EventDataEventsLost), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(EventDataEventsLost), Is.EqualTo(12));
        }
    }
}
