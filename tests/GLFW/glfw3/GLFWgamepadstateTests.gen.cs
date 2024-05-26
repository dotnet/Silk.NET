// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.GLFW.UnitTests;

/// <summary>Provides validation of the <see cref = "GLFWgamepadstate"/> struct.</summary>
public static unsafe partial class GLFWgamepadstateTests
{
    /// <summary>Validates that the <see cref = "GLFWgamepadstate"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GLFWgamepadstate>(), Is.EqualTo(sizeof(Gamepadstate)));
    }

    /// <summary>Validates that the <see cref = "GLFWgamepadstate"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(Gamepadstate).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GLFWgamepadstate"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(Gamepadstate), Is.EqualTo(40));
    }
}
