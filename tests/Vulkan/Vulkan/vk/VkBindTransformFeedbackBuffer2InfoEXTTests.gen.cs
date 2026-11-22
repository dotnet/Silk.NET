// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "BindTransformFeedbackBuffer2InfoEXT"/> struct.</summary>
public static unsafe partial class VkBindTransformFeedbackBuffer2InfoEXTTests
{
    /// <summary>Validates that the <see cref = "BindTransformFeedbackBuffer2InfoEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<BindTransformFeedbackBuffer2InfoEXT>(),
            Is.EqualTo(sizeof(BindTransformFeedbackBuffer2InfoEXT))
        );
    }

    /// <summary>Validates that the <see cref = "BindTransformFeedbackBuffer2InfoEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BindTransformFeedbackBuffer2InfoEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BindTransformFeedbackBuffer2InfoEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BindTransformFeedbackBuffer2InfoEXT), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(BindTransformFeedbackBuffer2InfoEXT), Is.EqualTo(32));
        }
    }
}
