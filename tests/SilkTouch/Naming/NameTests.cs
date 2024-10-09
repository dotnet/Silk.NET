using System;
using System.Collections.Generic;
using NUnit.Framework;
using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

[TestFixture]
public class NameTests : NameTrimmer
{
    [Test, TestCase(null), TestCase("glfw")]
    public void SimpleGlfwTestDetermination(string? hint)
    {
        var test = new Dictionary<string, (string, List<string>?)>
        {
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
        Assert.That(
            GetPrefix(null, hint, test, null, null, false, true)?.Prefix,
            Is.EqualTo("GLFW")
        );
        string? identifiedPrefix = null;
        Trim(null, hint, "GLFW", test, null, null, ref identifiedPrefix);
        var expected = new Dictionary<string, string>
        {
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
            Assert.That(
                trimmed.Prettify(new NameUtils.NameTransformer(4)),
                Is.EqualTo(expected[key])
            );
        }
    }

    [Test]
    public void RegressionFragmentShaderColorModMaskATI()
    {
        var test = new Dictionary<string, (string, List<string>?)>
        {
            { "GL_2X_BIT_ATI", ("GL_2X_BIT_ATI", null) },
            { "GL_COMP_BIT_ATI", ("GL_COMP_BIT_ATI", null) },
            { "GL_NEGATE_BIT_ATI", ("GL_NEGATE_BIT_ATI", null) },
            { "GL_BIAS_BIT_ATI", ("GL_BIAS_BIT_ATI", null) }
        };
        string? identifiedPrefix = null;
        Trim(
            "FragmentShaderColorModMaskATI",
            "gl",
            "OpenGL",
            test,
            null,
            null,
            ref identifiedPrefix
        );
        var expected = new Dictionary<string, string>
        {
            { "GL_2X_BIT_ATI", "X2XBitAti" },
            { "GL_COMP_BIT_ATI", "CompBitAti" },
            { "GL_NEGATE_BIT_ATI", "NegateBitAti" },
            { "GL_BIAS_BIT_ATI", "BiasBitAti" }
        };
        foreach (var (key, (trimmed, _)) in test)
        {
            Assert.That(
                trimmed.Prettify(new NameUtils.NameTransformer(4)),
                Is.EqualTo(expected[key])
            );
        }
    }

    [Test]
    public void RegressionEvalTargetNV()
    {
        var test = new Dictionary<string, (string, List<string>?)>
        {
            { "GL_EVAL_2D_NV", ("GL_EVAL_2D_NV", null) },
            { "GL_EVAL_TRIANGULAR_2D_NV", ("GL_EVAL_TRIANGULAR_2D_NV", null) }
        };
        string? identifiedPrefix = null;
        Trim("EvalTargetNV", "gl", "OpenGL", test, null, null, ref identifiedPrefix);
        var expected = new Dictionary<string, string>
        {
            { "GL_EVAL_2D_NV", "Eval2DNv" },
            { "GL_EVAL_TRIANGULAR_2D_NV", "EvalTriangular2DNv" }
        };
        foreach (var (key, (trimmed, _)) in test)
        {
            Assert.That(
                trimmed.Prettify(new NameUtils.NameTransformer(4)),
                Is.EqualTo(expected[key])
            );
        }
    }

    [Test]
    public void RegressionNamespacePrefixDetermination() =>
        Assert.That(
            NameUtils.FindCommonPrefix(["Silk.NET.SDL", "Silk.NET.SDL"], true, false, true),
            Is.EqualTo("Silk.NET.SDL")
        );
}
