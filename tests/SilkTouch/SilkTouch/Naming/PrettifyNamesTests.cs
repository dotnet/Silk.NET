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
    public async Task PrettifyNames_TrimsSharedPrefix()
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

        var context = new DummyModContext() { JobKey = "OpenGL", SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(
                new PrettifyNames.Configuration() { GlobalPrefixHints = ["gl"] }
            ),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // The prefix shared by the member names should be trimmed
        // The type name should not be modified
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task PrettifyNames_TrimsSharedPrefix2()
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

        var context = new DummyModContext() { JobKey = "OpenAL", SourceProject = project };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(
                new PrettifyNames.Configuration() { GlobalPrefixHints = ["al"] }
            ),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await prettifyNames.ExecuteAsync(context);

        // The prefix shared by the member names should be trimmed
        // The type name should not be modified
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task PrettifyNames_TrimsSharedPrefix_AfterRemovalOf_VendorSuffixes()
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

        var context = new DummyModContext() { JobKey = "OpenGL", SourceProject = project };

        var mixKhronosData = new MixKhronosData(NullLogger<MixKhronosData>.Instance, null!)
        {
            Jobs =
            {
                ["OpenGL"] = new MixKhronosData.JobData
                {
                    Configuration = new MixKhronosData.Configuration(),
                    Vendors = ["NV"],
                },
            },
        };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(
                new PrettifyNames.Configuration()
                {
                    GlobalPrefixHints = ["gl"],
                    Affixes =
                    {
                        {
                            "KhronosVendor",
                            new PrettifyNames.NameAffixConfiguration() { Remove = true }
                        },
                    },
                }
            ),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await mixKhronosData.ExecuteAsync(context);
        await prettifyNames.ExecuteAsync(context);

        // The removal of the 3 NV suffixes should make PrettifyNames trim less of the member name
        // The type name should remain unchanged except for the removal of the NV suffix
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }

    [Test]
    public async Task PrettifyNames_TrimsSharedPrefix_AfterRemovalOf_VendorSuffixes_AndShortenedNamesConflict()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "OcclusionQueryParameterNameNV.gen.cs",
                """
                public enum VkPresentModeKHR
                {
                    VK_PRESENT_MODE_FIFO_LATEST_READY_KHR = 1000361000,
                    VK_PRESENT_MODE_FIFO_LATEST_READY_EXT = VK_PRESENT_MODE_FIFO_LATEST_READY_KHR,
                }
                """
            )
            .Project;

        var context = new DummyModContext() { JobKey = "Vulkan", SourceProject = project };

        var mixKhronosData = new MixKhronosData(NullLogger<MixKhronosData>.Instance, null!)
        {
            Jobs =
            {
                ["Vulkan"] = new MixKhronosData.JobData
                {
                    Configuration = new MixKhronosData.Configuration(),
                    Vendors = ["KHR", "EXT"],
                },
            },
        };

        var prettifyNames = new PrettifyNames(
            NullLogger<PrettifyNames>.Instance,
            new DummyOptions<PrettifyNames.Configuration>(new PrettifyNames.Configuration()),
            [new DummyJobDependency<INameTrimmer>([new NameTrimmer()])]
        );

        await mixKhronosData.ExecuteAsync(context);
        await prettifyNames.ExecuteAsync(context);

        // The removal of the 3 NV suffixes should make PrettifyNames trim less of the member name
        // The type name should remain unchanged except for the removal of the NV suffix
        var result = await context.SourceProject.Documents.First().GetSyntaxRootAsync();
        await Verify(result!.NormalizeWhitespace().ToString());
    }
}
