// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging.Abstractions;
using Silk.NET.SilkTouch.Mods;

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
    public async Task Regression_UnexpectedCasingChangesInFormatEnums()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "InternalFormat.gen.cs",
                """
                public enum InternalFormat
                {
                    [NameAffix("Prefix", "SharedPrefix", "GL")]
                    [NameAffix("Suffix", "KhronosVendor", "ARB")]
                    GL_RGBA32F_ARB = 34836,

                    [NameAffix("Prefix", "SharedPrefix", "GL")]
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
                new PrettifyNames.Configuration()
                {
                    LongAcronymThreshold = 3,
                    Affixes =
                    {
                        {
                            "SharedPrefix",
                            new PrettifyNames.NameAffixConfiguration() { Remove = true }
                        },
                    },
                }
            )
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
                    [NameAffix("Prefix", "SharedPrefix", "GL")]
                    [NameAffix("Suffix", "KhronosVendor", "EXT")]
                    GL_RGB16_EXT = 32852,

                    [NameAffix("Prefix", "SharedPrefix", "GL")]
                    [NameAffix("Suffix", "KhronosVendor", "EXT")]
                    GL_RGB16F_EXT = 34843,
                }

                public enum ALEnum
                {
                    [NameAffix("Prefix", "SharedPrefix", "AL")]
                    [NameAffix("Suffix", "KhronosVendor", "SOFT")]
                    AL_MONO16_SOFT = 4353,

                    [NameAffix("Prefix", "SharedPrefix", "AL")]
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
                new PrettifyNames.Configuration()
                {
                    LongAcronymThreshold = 4,
                    Affixes =
                    {
                        {
                            "SharedPrefix",
                            new PrettifyNames.NameAffixConfiguration() { Remove = true }
                        },
                    },
                }
            )
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
    public async Task FallbackIsChosenCorrectly()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "AL.gen.cs",
                """
                public class AL
                {
                    [NameAffix("Prefix", "SharedPrefix", "al")]
                    [NameAffix("Suffix", "KhronosNonVendorSuffix", "Direct")]
                    [NameAffix("Suffix", "KhronosVendor", "SOFT")]
                    public void alGetBufferPtrDirectSOFT() { }

                    [NameAffix("Prefix", "SharedPrefix", "al")]
                    [NameAffix("Suffix", "KhronosFunctionDataType", "v")]
                    [NameAffix("Suffix", "KhronosNonVendorSuffix", "Direct")]
                    [NameAffix("Suffix", "KhronosVendor", "SOFT")]
                    public void alGetBufferPtrvDirectSOFT() { }
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
                    Affixes =
                    {
                        {
                            "SharedPrefix",
                            new PrettifyNames.NameAffixConfiguration()
                            {
                                DiscriminatorPriority = 0,
                                IsDiscriminator = true,
                            }
                        },
                        {
                            "KhronosFunctionDataType",
                            new PrettifyNames.NameAffixConfiguration()
                            {
                                DiscriminatorPriority = 1,
                                IsDiscriminator = true,
                            }
                        },
                    },
                }
            )
        );

        await prettifyNames.ExecuteAsync(context);

        // This is to catch a regression where choosing the shortest secondary available is not always correct
        // The second method (with the -v suffix) should not have the shared prefix restored
        // Eg: We don't want AlGetBufferPtr
        //
        // The expected output is:
        // GetBufferPtrDirectSOFT
        // GetBufferPtrvDirectSOFT
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task FallbackIsChosenCorrectly_ReversedPriority()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "AL.gen.cs",
                """
                public class AL
                {
                    [NameAffix("Prefix", "SharedPrefix", "al")]
                    [NameAffix("Suffix", "KhronosNonVendorSuffix", "Direct")]
                    [NameAffix("Suffix", "KhronosVendor", "SOFT")]
                    public void alGetBufferPtrDirectSOFT() { }

                    [NameAffix("Prefix", "SharedPrefix", "al")]
                    [NameAffix("Suffix", "KhronosFunctionDataType", "v")]
                    [NameAffix("Suffix", "KhronosNonVendorSuffix", "Direct")]
                    [NameAffix("Suffix", "KhronosVendor", "SOFT")]
                    public void alGetBufferPtrvDirectSOFT() { }
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
                    Affixes =
                    {
                        {
                            "SharedPrefix",
                            new PrettifyNames.NameAffixConfiguration()
                            {
                                DiscriminatorPriority = 1,
                                IsDiscriminator = true,
                            }
                        },
                        {
                            "KhronosFunctionDataType",
                            new PrettifyNames.NameAffixConfiguration()
                            {
                                DiscriminatorPriority = 0,
                                IsDiscriminator = true,
                            }
                        },
                    },
                }
            )
        );

        await prettifyNames.ExecuteAsync(context);

        // This ensures that the config is respected
        //
        // The expected output is:
        // GetBufferPtrDirectSOFT
        // alGetBufferPtrDirectSOFT (affixes are not prettified by default)
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task SuccessfullyUsesReferencedAffixes()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "SDL.gen.cs",
                """
                [NameAffix("Suffix", "Test", "ShouldBeInOutputName")]
                public struct GamepadBinding { }

                [NameAffix("Prefix", "NestedStructParent", nameof(GamepadBinding))]
                public struct GamepadBindingInput { }

                [NameAffix("Prefix", "NestedStructParent", nameof(GamepadBindingInput))]
                public struct GamepadBindingInputAxis { }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration())
        );

        await prettifyNames.ExecuteAsync(context);

        // All names should start with GamepadBindingShouldBeInOutputName
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task SuccessfullyUsesReferencedAffixes_FromParentScope()
    {
        // Note that at time of writing, no nested scopes are supported
        // This means that the only valid scope is the global scope
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "Test.gen.cs",
                """
                [NameAffix("Suffix", "Test", "Suffix")]
                public struct A
                {
                    [NameAffix("Suffix", "Test", nameof(A))]
                    public static int B;
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration())
        );

        await prettifyNames.ExecuteAsync(context);

        // A should become ASuffix
        // B should become BASuffix
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task SuccessfullyUsesReferencedAffixes_WhenOverridden()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "AL.gen.cs",
                """
                public struct ALBUFFERCALLBACKTYPESOFT;

                [NameAffix("Prefix", "FunctionPointerParent", nameof(ALBUFFERCALLBACKTYPESOFT))]
                [NameAffix("Suffix", "FunctionPointerDelegateType", "Delegate")]
                public delegate int ALBUFFERCALLBACKTYPESOFTDelegate();
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(
                new PrettifyNames.Configuration()
                {
                    NameOverrides = { { "ALBUFFERCALLBACKTYPESOFT", "BufferCallbackSOFT" } },
                }
            )
        );

        await prettifyNames.ExecuteAsync(context);

        // Both names should be affected by the override
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public void CycleInReferencedAffixes_Throws()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "Test.gen.cs",
                """
                [NameAffix("Suffix", "Test", nameof(B))]
                public struct A { }

                [NameAffix("Suffix", "Test", nameof(A))]
                public struct B { }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration())
        );

        Assert.ThrowsAsync<InvalidOperationException>(async () =>
        {
            await prettifyNames.ExecuteAsync(context);
        });
    }

    [Test]
    public void MissingReferencedAffix_Throws()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "Test.gen.cs",
                """
                [NameAffix("Suffix", "Test", nameof(B))]
                public struct A { }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration())
        );

        Assert.ThrowsAsync<InvalidOperationException>(async () =>
        {
            await prettifyNames.ExecuteAsync(context);
        });
    }

    [Test]
    public async Task ConflictsAreResolved_ForMethodsAndConstants()
    {
        // This test focuses on an edge case where method conflicts might be resolved while
        // ignoring the fact that a constant also wants to have the same output name
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "Sdl.gen.cs",
                """
                public class Sdl
                {
                    public static delegate* <int, sbyte**, int> main => &SDL_main;

                    [NameAffix("Prefix", "SharedPrefix", "SDL")]
                    public static extern int SDL_main(int argc, sbyte** argv);
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration())
            {
                Value =
                {
                    Affixes =
                    {
                        {
                            "SharedPrefix",
                            new PrettifyNames.NameAffixConfiguration()
                            {
                                DiscriminatorPriority = 0,
                                IsDiscriminator = true,
                            }
                        },
                    },
                },
            }
        );

        await prettifyNames.ExecuteAsync(context);

        // The two members should not be output as the same name
        // Expected:
        // Property is named "MainValue"
        // Method is named "Main"
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }
}
