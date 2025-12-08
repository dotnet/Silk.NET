using System;
using System.Collections.Generic;
using NUnit.Framework;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

[TestFixture]
public class NameTests : NameTrimmer
{
    [Test, TestCase(null), TestCase("glfw")]
    public void SimpleGlfwTestDetermination(string? hint)
    {
        var test = new Dictionary<string, CandidateNames>
        {
            { "GLFWallocator", new CandidateNames("GLFWallocator", []) },
            { "GLFWgammaramp", new CandidateNames("GLFWgammaramp", []) },
            { "GLFWgamepadstate", new CandidateNames("GLFWgamepadstate", []) },
            { "GLFWvidmode", new CandidateNames("GLFWvidmode", []) },
            { "GLFWimage", new CandidateNames("GLFWimage", []) },
            { "Glfw", new CandidateNames("Glfw", []) },
            { "GLFWcursor", new CandidateNames("GLFWcursor", []) },
            { "GLFWmonitor", new CandidateNames("GLFWmonitor", []) },
            { "GLFWwindow", new CandidateNames("GLFWwindow", []) },
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
            Assert.That(trimmed.Prettify(new NameUtils.NameTransformer(4)), Is.EqualTo(expected[key]));
        }
    }

    [Test]
    public void RegressionFragmentShaderColorModMaskATI()
    {
        var test = new Dictionary<string, CandidateNames>
        {
            { "GL_2X_BIT_ATI", new CandidateNames("GL_2X_BIT_ATI", []) },
            { "GL_COMP_BIT_ATI", new CandidateNames("GL_COMP_BIT_ATI", []) },
            { "GL_NEGATE_BIT_ATI", new CandidateNames("GL_NEGATE_BIT_ATI", []) },
            { "GL_BIAS_BIT_ATI", new CandidateNames("GL_BIAS_BIT_ATI", []) },
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
            Assert.That(trimmed.Prettify(new NameUtils.NameTransformer(4)), Is.EqualTo(expected[key]));
        }
    }

    [Test]
    public void RegressionEvalTargetNV()
    {
        var test = new Dictionary<string, CandidateNames>
        {
            { "GL_EVAL_2D_NV", new CandidateNames("GL_EVAL_2D_NV", []) },
            { "GL_EVAL_TRIANGULAR_2D_NV", new CandidateNames("GL_EVAL_TRIANGULAR_2D_NV", []) },
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
            Assert.That(trimmed.Prettify(new NameUtils.NameTransformer(4)), Is.EqualTo(expected[key]));
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
        var names = new Dictionary<string, CandidateNames>
        {
            { "GL_FILL_NV", new CandidateNames("GL_FILL_NV", []) },
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
        Assert.That(names["GL_FILL_NV"].Primary, Is.EqualTo("FILL_NV"));
    }

    [Test]
    public void MultipleGlobalPrefixHints()
    {
        var names = new Dictionary<string, CandidateNames>
        {
            { "ALC_CONTEXT_DEBUG_BIT_EXT", new CandidateNames("ALC_CONTEXT_DEBUG_BIT_EXT", []) },
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
        Assert.That(names["ALC_CONTEXT_DEBUG_BIT_EXT"].Primary, Is.EqualTo("CONTEXT_DEBUG_BIT_EXT"));
    }
}
