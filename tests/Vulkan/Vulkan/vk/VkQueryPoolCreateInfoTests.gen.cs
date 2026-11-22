// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "QueryPoolCreateInfo"/> struct.</summary>
public static unsafe partial class VkQueryPoolCreateInfoTests
{
    /// <summary>Validates that the <see cref = "QueryPoolCreateInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<QueryPoolCreateInfo>(), Is.EqualTo(sizeof(QueryPoolCreateInfo)));
    }

    /// <summary>Validates that the <see cref = "QueryPoolCreateInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(QueryPoolCreateInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "QueryPoolCreateInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(QueryPoolCreateInfo), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(QueryPoolCreateInfo), Is.EqualTo(24));
        }
    }
}
