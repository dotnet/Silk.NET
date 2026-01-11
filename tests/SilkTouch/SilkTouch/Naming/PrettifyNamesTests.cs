// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging.Abstractions;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.UnitTests.Naming;

public class PrettifyNamesTests
{
    static PrettifyNamesTests()
    {
        if (!VerifyDiffPlex.Initialized)
        {
            VerifyDiffPlex.Initialize();
        }
    }

    [Test]
    public async Task TrimsSharedPrefix()
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

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration()),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // The prefix shared by the member names should be trimmed
        // The type name should not be modified
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task TrimsSharedPrefix2()
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

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration()),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // The prefix shared by the member names should be trimmed
        // The type name should not be modified
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task TrimsSharedPrefix_ForTypes()
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

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration()),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // The type names should be trimmed as ModeKHR and IdKHR
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task TrimsSharedPrefix_WhenAffixesDeclared()
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

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration()),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // The declaration of the 2 NV member suffixes should make PrettifyNames trim less of the member name
        // This is because NameTrimmer only sees the name without the suffixes
        // The type name should remain unchanged except for the removal of the NV suffix
        //
        // Note: When this test was first added, the names were not being trimmed at all.
        // The fix was to ensure NameTrimmer.GetTrimmingName trimmed the trailing underscore.
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task HintShouldNotAffectSharedPrefixTrimming()
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

            var prettifyNames = new PrettifyNames(
                NullLogger<PrettifyNames>.Instance,
                new DummyOptions<PrettifyNames.Configuration>(
                    new PrettifyNames.Configuration() { GlobalPrefixHints = ["gl"] }
                ),
                [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
            );

            await prettifyNames.ExecuteAsync(context);

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

            var prettifyNames = new PrettifyNames(
                NullLogger<PrettifyNames>.Instance,
                new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration()),
                [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
            );

            await prettifyNames.ExecuteAsync(context);

            var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
            result2 = result!.NormalizeWhitespace().ToString();
        }

        // The two results should match because member names share prefixes in both cases, regardless of what the hint is
        // The NameAffix attributes are also required to cause the regression back when this test was first added
        Assert.That(result1, Is.EqualTo(result2));
    }

    [Test]
    public async Task HintShouldNotAffectSharedPrefixTrimming_WhenAffixesDeclared()
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

            var prettifyNames = new PrettifyNames(
                NullLogger<PrettifyNames>.Instance,
                new DummyOptions<PrettifyNames.Configuration>(
                    new PrettifyNames.Configuration() { GlobalPrefixHints = ["gl"] }
                ),
                [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
            );

            await prettifyNames.ExecuteAsync(context);

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

            var prettifyNames = new PrettifyNames(
                NullLogger<PrettifyNames>.Instance,
                new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration()),
                [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
            );

            await prettifyNames.ExecuteAsync(context);

            var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
            result2 = result!.NormalizeWhitespace().ToString();
        }

        // The two results should match because member names share prefixes in both cases, regardless of what the hint is
        // The NameAffix attributes are also required to cause the regression back when this test was first added
        Assert.That(result1, Is.EqualTo(result2));
    }

    [Test]
    public async Task TrimsSharedPrefix_WhenAffixesDeclared_AndNamesWithoutAffixesConflict()
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

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration()),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // This test should run without erroring
        // This is to catch a regression where NameTrimmer would error
        // since the names with the affixes removed would conflict
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task TrimsPrefix_WhenMatchingHint()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument("VkPresentModeKHR.gen.cs", "public enum VkPresentModeKHR { }")
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(
                new PrettifyNames.Configuration() { GlobalPrefixHints = ["vk"] }
            ),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // The type name should be trimmed as PresentModeKHR
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task DoesNotTrimTypeName_WhenNotMatchingHint_AndOnlyOneType()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "OcclusionQueryParameterNameNV.gen.cs",
                "public enum OcclusionQueryParameterNameNV { }"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(
                new PrettifyNames.Configuration() { GlobalPrefixHints = ["gl"] }
            ),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // The type name should remain as OcclusionQueryParameterNameNV
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task Regression_UnexpectedCasingChangesInFormatEnums()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "InternalFormat.gen.cs",
                """
                public enum InternalFormat
                {
                    [NameAffix("Suffix", "KhronosVendor", "ARB")]
                    GL_RGBA32F_ARB = 34836,

                    [NameAffix("Suffix", "KhronosVendor", "ARB")]
                    GL_RGB32F_ARB = 34837,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(
                new PrettifyNames.Configuration() { LongAcronymThreshold = 3 }
            ),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // This is to catch a bug revealed by changing NameTrimmer to be executed after affix removal by NameAffixerEarlyTrimmer
        // The underlying reason is actually unrelated and was an issue that existed long before
        // NameUtilsTests.Prettify_IsNotAffectedBy_TrailingUnderscore tests for the underlying issue
        //
        // While the core issue is already covered by another test,
        // this test is kept because the format enums tend to be a bit sensitive to codebase changes
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task InconsistentCasing_LettersFollowingNumbers_WhenAffixesDeclared()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "Test.gen.cs",
                """
                public enum GLEnum
                {
                    [NameAffix("Suffix", "KhronosVendor", "EXT")]
                    GL_RGB16_EXT = 32852,

                    [NameAffix("Suffix", "KhronosVendor", "EXT")]
                    GL_RGB16F_EXT = 34843,
                }

                public enum ALEnum
                {
                    [NameAffix("Suffix", "KhronosVendor", "SOFT")]
                    AL_MONO16_SOFT = 4353,

                    [NameAffix("Suffix", "KhronosVendor", "SOFT")]
                    AL_MONO32F_SOFT = 65552,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(
                new PrettifyNames.Configuration() { LongAcronymThreshold = 4 }
            ),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // This is to catch an inconsistency related to how letters following numbers are handled
        // In both cases, MONO should be prettified as Mono
        // NameUtilsTests.Prettify_Capital_AfterNumber_DoesNotAffect_PreviousWord tests for the underlying issue
        //
        // Note that the NameAffix attributes do affect the output
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task Regression_IncorrectSecondary_ChosenAsFallback()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "AL.gen.cs",
                """
                public class AL
                {
                    [NameAffix("Suffix", "KhronosNonVendorSuffix", "Direct")]
                    [NameAffix("Suffix", "KhronosVendor", "SOFT")]
                    public void alGetBufferPtrDirectSOFT() { }

                    [NameAffix("Suffix", "KhronosFunctionDataType", "v")]
                    [NameAffix("Suffix", "KhronosNonVendorSuffix", "Direct")]
                    [NameAffix("Suffix", "KhronosVendor", "SOFT")]
                    public void alGetBufferPtrvDirectSOFT() { }

                    // This is to ensure that prefix identification doesn't trim too much
                    [NameAffix("Suffix", "KhronosFunctionDataType", "i")]
                    public void alFilteri() { }
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(
                new PrettifyNames.Configuration()
                {
                    LongAcronymThreshold = 4,
                    GlobalPrefixHints = ["al"],
                    Affixes =
                    {
                        {
                            "KhronosFunctionDataType",
                            new PrettifyNames.NameAffixConfiguration() { IsDiscriminator = true }
                        },
                    },
                }
            ),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // This is to catch a regression where choosing the shortest secondary available is not always correct
        // The second method (with the -v suffix) should not have the global prefix restored
        // Eg: We don't want AlGetBufferPtr
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

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(
                new PrettifyNames.Configuration() { GlobalPrefixHints = ["gl"] }
            ),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // The presence of the NameAffix attribute should prevent the GL- prefix of GLEnum from being removed
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }
}
