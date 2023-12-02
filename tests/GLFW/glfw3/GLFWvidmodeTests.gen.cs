// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.GLFW.UnitTests;

/// <summary>Provides validation of the <see cref = "GLFWvidmode"/> struct.</summary>
public static unsafe partial class GLFWvidmodeTests
{
    /// <summary>Validates that the <see cref = "GLFWvidmode"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GLFWvidmode>(), Is.EqualTo(sizeof(Vidmode)));
    }

    /// <summary>Validates that the <see cref = "GLFWvidmode"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Vidmode).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GLFWvidmode"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Vidmode), Is.EqualTo(24));
    }
}
