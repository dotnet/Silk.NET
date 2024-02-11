using System;
using System.Collections.Generic;
using NUnit.Framework;
using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

[TestFixture]
public class NameTests : NameTrimmer
{
    [Test]
    public void SimpleGlfwTestDetermination()
    {
        var test = new Dictionary<string, (string, List<string>?)> {
            { "GLFWallocator", ("GLFWallocator", null) },
            { "GLFWgammaramp", ("GLFWgammaramp", null) },
            { "GLFWgamepadstate", ("GLFWgamepadstate", null) },
            { "GLFWvidmode", ("GLFWvidmode", null) },
            { "GLFWimage", ("GLFWimage", null) },
            { "Glfw", ("Glfw", null) },
            { "GLFWcursor", ("GLFWcursor", null) },
            { "GLFWmonitor", ("GLFWmonitor", null) },
            { "GLFWwindow", ("GLFWwindow", null) }
        };
        Assert.That(GetPrefix(null, null, test, null, false, true)?.Prefix, Is.EqualTo("GLFW"));
        string? identifiedPrefix = null;
        Trim(null, null, "GLFW", test, null, ref identifiedPrefix);
        var expected = new Dictionary<string, string> {
            { "GLFWallocator", "Allocator" },
            { "GLFWgammaramp", "Gammaramp" },
            { "GLFWgamepadstate", "Gamepadstate" },
            { "GLFWvidmode", "Vidmode" },
            { "GLFWimage", "Image" },
            { "Glfw", "Glfw" },
            { "GLFWcursor", "Cursor" },
            { "GLFWmonitor", "Monitor" },
            { "GLFWwindow", "Window" }
        };
        foreach (var (key, (trimmed, _)) in test)
        {
            Assert.That(trimmed.Prettify(new NameUtils.NameTransformer(4)), Is.EqualTo(expected[key]));
        }
    }
}
