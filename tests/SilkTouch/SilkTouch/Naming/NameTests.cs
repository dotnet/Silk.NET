using System;
using System.Collections.Generic;
using NUnit.Framework;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

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
            { "GLFWwindow", ("GLFWwindow", null) },
        };
        Assert.That(
            GetPrefix(null, hint, test, null, null, false, true)?.Prefix,
            Is.EqualTo("GLFW")
        );
        Trim(
            new NameTrimmerContext
            {
                Configuration = new PrettifyNames.Configuration
                {
                    GlobalPrefixHints = hint is null ? null : [hint],
                },
                Names = test,
                JobKey = "GLFW",
            }
        );
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
            { "GLFWwindow", "Window" },
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
            { "GL_BIAS_BIT_ATI", ("GL_BIAS_BIT_ATI", null) },
        };
        Trim(
            new NameTrimmerContext
            {
                Container = "FragmentShaderColorModMaskATI",
                Configuration = new PrettifyNames.Configuration { GlobalPrefixHints = ["gl"] },
                Names = test,
                JobKey = "OpenGL",
            }
        );
        var expected = new Dictionary<string, string>
        {
            { "GL_2X_BIT_ATI", "X2XBitAti" },
            { "GL_COMP_BIT_ATI", "CompBitAti" },
            { "GL_NEGATE_BIT_ATI", "NegateBitAti" },
            { "GL_BIAS_BIT_ATI", "BiasBitAti" },
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
            { "GL_EVAL_TRIANGULAR_2D_NV", ("GL_EVAL_TRIANGULAR_2D_NV", null) },
        };
        Trim(
            new NameTrimmerContext
            {
                Container = "EvalTargetNV",
                Configuration = new PrettifyNames.Configuration { GlobalPrefixHints = ["gl"] },
                Names = test,
                JobKey = "OpenGL",
            }
        );
        var expected = new Dictionary<string, string>
        {
            { "GL_EVAL_2D_NV", "Eval2DNv" },
            { "GL_EVAL_TRIANGULAR_2D_NV", "EvalTriangular2DNv" },
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

    [Test]
    public void RegressionSingleMemberEnumUsesGlobalPrefixHint()
    {
        var names = new Dictionary<string, (string, List<string>?)>
        {
            { "GL_FILL_NV", ("GL_FILL_NV", null) },
        };
        var ctx = new NameTrimmerContext
        {
            Configuration = new PrettifyNames.Configuration { GlobalPrefixHints = ["gl"] },
            Container = "EvalMapsModeNV",
            JobKey = "OpenGL",
            Names = names,
        };
        var uut = new NameTrimmer();
        uut.Trim(ctx);
        Assert.That(names["GL_FILL_NV"].Item1, Is.EqualTo("FILL_NV"));
    }

    [Test]
    public void MultipleGlobalPrefixHints()
    {
        var names = new Dictionary<string, (string, List<string>?)>
        {
            { "ALC_CONTEXT_DEBUG_BIT_EXT", ("ALC_CONTEXT_DEBUG_BIT_EXT", null) },
        };
        var ctx = new NameTrimmerContext
        {
            Configuration = new PrettifyNames.Configuration { GlobalPrefixHints = ["alc", "al"] },
            Container = "ContextFlagsEXT",
            JobKey = "OpenAL",
            Names = names,
        };
        var uut = new NameTrimmer();
        uut.Trim(ctx);
        Assert.That(names["ALC_CONTEXT_DEBUG_BIT_EXT"].Item1, Is.EqualTo("CONTEXT_DEBUG_BIT_EXT"));
    }
}
