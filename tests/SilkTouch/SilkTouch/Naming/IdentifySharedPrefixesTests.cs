// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

public class IdentifySharedPrefixesTests
{
    static IdentifySharedPrefixesTests()
    {
        if (!VerifyDiffPlex.Initialized)
        {
            VerifyDiffPlex.Initialize();
        }
    }

    [Test]
    public async Task IdentifiesSharedPrefix()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "OcclusionQueryParameterNameNV.gen.cs",
                """
                public enum OcclusionQueryParameterNameNV
                {
                    GL_PIXEL_COUNT_NV = 34918,
                    GL_PIXEL_COUNT_AVAILABLE_NV = 34919,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration()
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // The prefix shared by the member names should be identified (GL_PIXEL_COUNT)
        // The type itself should be left untouched
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task IdentifiesSharedPrefix2()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "VocalMorpherPhoneme.gen.cs",
                """
                public enum VocalMorpherPhoneme
                {
                    AL_VOCAL_MORPHER_PHONEME_A = 0,
                    AL_VOCAL_MORPHER_PHONEME_E = 1,
                    AL_VOCAL_MORPHER_PHONEME_I = 2,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration()
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // The prefix shared by the member names should be identified (AL_VOCAL_MORPHER_PHONEME)
        // The type itself should be left untouched
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    [TestCase(null)]
    [TestCase("glfw")]
    public async Task IdentifiesSharedPrefixGlfw(string? hint)
    {
        // This is ported from the old NameTrimmerTests
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "VocalMorpherPhoneme.gen.cs",
                """
                public struct Glfw;
                public struct GLFWallocator;
                public struct GLFWcursor;
                public struct GLFWgamepadstate;
                public struct GLFWgammaramp;
                public struct GLFWimage;
                public struct GLFWmonitor;
                public struct GLFWvidmode;
                public struct GLFWwindow;
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration()
                {
                    GlobalPrefixHints = hint is null ? [] : [hint],
                }
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // The hint should not affect the output because the shared prefix is shared by most of the names
        // Glfw should not have a prefix
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task IdentifiesSharedPrefix_ForTypes()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "Vk.gen.cs",
                """
                public enum VkPresentModeKHR { }
                public enum VkPresentIdKHR { }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration()
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // The prefixes should be identified as "VkPresent", not "Vk"
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task IdentifiesSharedPrefix_WhenSuffixesDeclared()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "OcclusionQueryParameterNameNV.gen.cs",
                """
                public enum OcclusionQueryParameterNameNV
                {
                    [NameAffix("Suffix", "KhronosVendor", "NV")]
                    GL_PIXEL_COUNT_NV = 34918,

                    [NameAffix("Suffix", "KhronosVendor", "NV")]
                    GL_PIXEL_COUNT_AVAILABLE_NV = 34919,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration()
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // The declaration of the 2 NV member suffixes should make PrettifyNames trim less of the member name
        // IdentifySharedPrefixes should only use the unaffixed name for prefix identification
        // The shared prefix should be "GL_PIXEL"
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task HintShouldNotAffectSharedPrefixIdentification()
    {
        string result1;
        string result2;

        {
            var project = TestUtils
                .CreateTestProject()
                .AddDocument(
                    "OcclusionQueryParameterNameNV.gen.cs",
                    """
                    public enum OcclusionQueryParameterNameNV
                    {
                        GL_PIXEL_COUNT_NV = 34918,
                        GL_PIXEL_COUNT_AVAILABLE_NV = 34919,
                    }
                    """
                )
                .Project;

            var context = new DummyModContext() { SourceProject = project };

            var identifySharedPrefixes = new IdentifySharedPrefixes(
                new DummyOptions<IdentifySharedPrefixes.Configuration>(
                    new IdentifySharedPrefixes.Configuration() { GlobalPrefixHints = ["gl"] }
                )
            );

            await identifySharedPrefixes.ExecuteAsync(context);

            var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
            result1 = result!.NormalizeWhitespace().ToString();
        }

        {
            var project = TestUtils
                .CreateTestProject()
                .AddDocument(
                    "OcclusionQueryParameterNameNV.gen.cs",
                    """
                    public enum OcclusionQueryParameterNameNV
                    {
                        GL_PIXEL_COUNT_NV = 34918,
                        GL_PIXEL_COUNT_AVAILABLE_NV = 34919,
                    }
                    """
                )
                .Project;

            var context = new DummyModContext() { SourceProject = project };

            var identifySharedPrefixes = new IdentifySharedPrefixes(
                new DummyOptions<IdentifySharedPrefixes.Configuration>(
                    new IdentifySharedPrefixes.Configuration()
                )
            );

            await identifySharedPrefixes.ExecuteAsync(context);

            var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
            result2 = result!.NormalizeWhitespace().ToString();
        }

        // The two results should match because member names share prefixes in both cases, regardless of what the hint is
        // The NameAffix attributes are also required to cause the regression back when this test was first added
        Assert.That(result1, Is.EqualTo(result2));
    }

    [Test]
    public async Task HintShouldNotAffectSharedPrefixIdentification_WhenAffixesDeclared()
    {
        string result1;
        string result2;

        {
            var project = TestUtils
                .CreateTestProject()
                .AddDocument(
                    "OcclusionQueryParameterNameNV.gen.cs",
                    """
                    public enum OcclusionQueryParameterNameNV
                    {
                        [NameAffix("Suffix", "KhronosVendor", "NV")]
                        GL_PIXEL_COUNT_NV = 34918,

                        [NameAffix("Suffix", "KhronosVendor", "NV")]
                        GL_PIXEL_COUNT_AVAILABLE_NV = 34919,
                    }
                    """
                )
                .Project;

            var context = new DummyModContext() { SourceProject = project };

            var identifySharedPrefixes = new IdentifySharedPrefixes(
                new DummyOptions<IdentifySharedPrefixes.Configuration>(
                    new IdentifySharedPrefixes.Configuration() { GlobalPrefixHints = ["gl"] }
                )
            );

            await identifySharedPrefixes.ExecuteAsync(context);

            var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
            result1 = result!.NormalizeWhitespace().ToString();
        }

        {
            var project = TestUtils
                .CreateTestProject()
                .AddDocument(
                    "OcclusionQueryParameterNameNV.gen.cs",
                    """
                    public enum OcclusionQueryParameterNameNV
                    {
                        [NameAffix("Suffix", "KhronosVendor", "NV")]
                        GL_PIXEL_COUNT_NV = 34918,

                        [NameAffix("Suffix", "KhronosVendor", "NV")]
                        GL_PIXEL_COUNT_AVAILABLE_NV = 34919,
                    }
                    """
                )
                .Project;

            var context = new DummyModContext() { SourceProject = project };

            var identifySharedPrefixes = new IdentifySharedPrefixes(
                new DummyOptions<IdentifySharedPrefixes.Configuration>(
                    new IdentifySharedPrefixes.Configuration()
                )
            );

            await identifySharedPrefixes.ExecuteAsync(context);

            var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
            result2 = result!.NormalizeWhitespace().ToString();
        }

        // The two results should match because member names share prefixes in both cases, regardless of what the hint is
        // The NameAffix attributes are also required to cause the regression back when this test was first added
        Assert.That(result1, Is.EqualTo(result2));
    }

    [Test]
    public async Task IdentifiesSharedPrefix_WhenAffixesDeclared_AndNamesWithoutAffixesConflict()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "VkPresentModeKHR.gen.cs",
                """
                [NameAffix("Suffix", "KhronosVendor", "KHR")]
                public enum VkPresentModeKHR
                {
                    [NameAffix("Suffix", "KhronosVendor", "KHR")]
                    VK_PRESENT_MODE_FIFO_LATEST_READY_KHR = 1000361000,

                    [NameAffix("Suffix", "KhronosVendor", "EXT")]
                    VK_PRESENT_MODE_FIFO_LATEST_READY_EXT = VK_PRESENT_MODE_FIFO_LATEST_READY_KHR,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration()
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // This test should run without erroring
        // This is to catch potential regressions
        // where the names without affixes would conflict
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task IdentifiesPrefix_WhenMatchingHint()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument("VkPresentModeKHR.gen.cs", "public enum VkPresentModeKHR { }")
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration() { GlobalPrefixHints = ["vk"] }
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // The type prefix should be identified as Vk
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task DoesNotIdentifyPrefix_WhenSingleName_WithNoHint()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument("VkPresentModeKHR.gen.cs", "public enum VkPresentModeKHR { }")
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration()
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // No prefix should be identified
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task DoesNotIdentifyPrefix_WhenSingleName_WithNonMatchingHint()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "OcclusionQueryParameterNameNV.gen.cs",
                "public enum OcclusionQueryParameterNameNV { }"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration() { GlobalPrefixHints = ["gl"] }
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // No prefix should be identified
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task PreserveKhronosNamespaceEnumPrefix()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "GLEnum.gen.cs",
                """
                [NameAffix("Prefix", "KhronosNamespaceEnum", "GL")]
                public enum GLEnum { }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration() { GlobalPrefixHints = ["gl"] }
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // The presence of the NameAffix attribute should prevent the GL- prefix of GLEnum from being identified as a shared prefix
        // This is because IdentifySharedPrefixes should only use the unaffixed name for prefix identification
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task RegressionFragmentShaderColorModMaskATI()
    {
        // This is ported from the old NameTrimmerTests
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "FragmentShaderDestModMask.gen.cs",
                """
                public enum FragmentShaderDestModMask
                {
                    GL_2X_BIT_ATI,
                    GL_COMP_BIT_ATI,
                    GL_NEGATE_BIT_ATI,
                    GL_BIAS_BIT_ATI,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration() { GlobalPrefixHints = ["gl"] }
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // The identified prefix should be "GL"
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task RegressionEvalTargetNV()
    {
        // This is ported from the old NameTrimmerTests
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "EvalTargetNV.gen.cs",
                """
                public enum EvalTargetNV
                {
                    GL_EVAL_2D_NV,
                    GL_EVAL_TRIANGULAR_2D_NV,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration() { GlobalPrefixHints = ["gl"] }
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // The identified prefix should be "GL"
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task RegressionSingleMemberEnumUsesGlobalPrefixHint()
    {
        // This is ported from the old NameTrimmerTests
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "EvalMapsModeNV.gen.cs",
                """
                public enum EvalMapsModeNV
                {
                    GL_FILL_NV,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration() { GlobalPrefixHints = ["gl"] }
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // The identified prefix should be "GL"
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task MultipleGlobalPrefixHints()
    {
        // This is ported from the old NameTrimmerTests
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "ContextFlagsEXT.gen.cs",
                """
                public enum ContextFlagsEXT
                {
                    ALC_CONTEXT_DEBUG_BIT_EXT,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var identifySharedPrefixes = new IdentifySharedPrefixes(
            new DummyOptions<IdentifySharedPrefixes.Configuration>(
                new IdentifySharedPrefixes.Configuration() { GlobalPrefixHints = ["alc", "al"] }
            )
        );

        await identifySharedPrefixes.ExecuteAsync(context);

        // The identified prefix should be "ALC"
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }
}
