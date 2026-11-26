// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenCL.UnitTests;

/// <summary>Provides validation of the <see cref = "MemAndroidNativeBufferHostPtr"/> struct.</summary>
public static unsafe partial class _cl_mem_android_native_buffer_host_ptrTests
{
    /// <summary>Validates that the <see cref = "MemAndroidNativeBufferHostPtr"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MemAndroidNativeBufferHostPtr>(),
            Is.EqualTo(sizeof(MemAndroidNativeBufferHostPtr))
        );
    }

    /// <summary>Validates that the <see cref = "MemAndroidNativeBufferHostPtr"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MemAndroidNativeBufferHostPtr).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MemAndroidNativeBufferHostPtr"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MemAndroidNativeBufferHostPtr), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(MemAndroidNativeBufferHostPtr), Is.EqualTo(12));
        }
    }
}
