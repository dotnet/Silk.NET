// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.GLFW.UnitTests;

/// <summary>Provides validation of the <see cref = "GLFWgammaramp"/> struct.</summary>
public static unsafe partial class GLFWgammarampTests
{
    /// <summary>Validates that the <see cref = "GLFWgammaramp"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GLFWgammaramp>(), Is.EqualTo(sizeof(Gammaramp)));
    }

    /// <summary>Validates that the <see cref = "GLFWgammaramp"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Gammaramp).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GLFWgammaramp"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(Gammaramp), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(Gammaramp), Is.EqualTo(16));
        }
    }
}
