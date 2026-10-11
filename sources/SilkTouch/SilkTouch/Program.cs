// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.CommandLine;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Build.Locator;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Silk.NET.SilkTouch.Caching;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Mods.Bakery;
using Silk.NET.SilkTouch.Sources;

namespace Silk.NET.SilkTouch;

internal static class Program
{
    private static Option<LogLevel> LoggingOption { get; } =
        new(["--log-level", "-l"], () => LogLevel.Information);

    private static Option<string[]> SkipOption { get; } =
        new(["--skip", "-s"], Array.Empty<string>)
        {
            Description = "A list of job names to skip. Takes precedence over --only.",
            Arity = ArgumentArity.ZeroOrMore,
        };

    private static Option<string[]> OnlyOption { get; } =
        new(["--only", "-o"], Array.Empty<string>)
        {
            Description = "A list of job names to run.",
            Arity = ArgumentArity.ZeroOrMore,
        };

    private static Option<int> JobsOption { get; } =
        new(["--max-jobs", "-j"], () => Environment.ProcessorCount)
        {
            Description = "Maximum number of parallel jobs.",
        };

    public static async Task Main(string[] args)
    {
        var rootCommand = new RootCommand { LoggingOption, SkipOption, OnlyOption, JobsOption };

        rootCommand.SetHandler(async ctx =>
        {
            // Register MSBuild
            MSBuildLocator.RegisterDefaults();

            // TODO: Cleanup. Probably move into a SilkTouchHost class.
            ILifetimeScope container;
            {
                var services = new ServiceCollection()
                    .AddLogging(builder =>
                    {
                        builder.AddSimpleConsole(opts =>
                        {
                            opts.SingleLine = true;
                            opts.ColorBehavior = Console.IsOutputRedirected
                                ? LoggerColorBehavior.Disabled
                                : LoggerColorBehavior.Default;
                            opts.IncludeScopes = false;
                        });
                        builder.SetMinimumLevel(ctx.ParseResult.GetValueForOption(LoggingOption));
                    })
                    .AddOptions();

                var builder = new ContainerBuilder();
                builder.Populate(services);

                {
                    builder
                        .RegisterType<MSBuildModContextFactory>()
                        .As<IModContextFactory>()
                        .SingleInstance();

                    builder.RegisterType<ResponseFileHandler>().SingleInstance();

                    builder
                        .RegisterType<DefaultBakeStrategy>()
                        .AsSelf()
                        .AsImplementedInterfaces()
                        .SingleInstance();

                    builder
                        .RegisterType<FileSystemCacheProvider>()
                        .As<ICacheProvider>()
                        .SingleInstance();

                    builder.RegisterType<GitInputSource>().As<IInputSource>().SingleInstance();

                    builder.RegisterType<NuGetInputSource>().As<IInputSource>().SingleInstance();

                    builder
                        .RegisterType<UriBasedInputResolver>()
                        .As<IInputResolver>()
                        .SingleInstance();

                    if (OperatingSystem.IsWindows())
                    {
                        builder
                            .RegisterType<WindowsStdIncludeResolver>()
                            .As<IStdIncludeResolver>()
                            .SingleInstance();
                    }
                    else if (OperatingSystem.IsMacOS())
                    {
                        builder
                            .RegisterType<MacOSStdIncludeResolver>()
                            .As<IStdIncludeResolver>()
                            .SingleInstance();
                    }
                    else
                    {
                        builder
                            .RegisterType<UnixStdIncludeResolver>()
                            .As<IStdIncludeResolver>()
                            .SingleInstance();
                    }
                }

                container = builder.Build();
            }

            var jobKeysToRun = new HashSet<string>(
                ctx.ParseResult.GetValueForOption(OnlyOption) ?? [],
                StringComparer.OrdinalIgnoreCase
            );

            var jobKeysToSkip = new HashSet<string>(
                ctx.ParseResult.GetValueForOption(SkipOption) ?? [],
                StringComparer.OrdinalIgnoreCase
            );

            // TODO: Move to separate project/single file app
            var allJobs = new List<SilkTouchJob>()
            {
                new(
                    "Vulkan",
                    new SilkTouchConfiguration
                    {
                        Solution = "Silk.NET.slnx",
                        SourceProject = "sources/Vulkan/Vulkan/Silk.NET.Vulkan.csproj",
                        DefaultLicenseHeader = "eng/silktouch/header.txt",
                    },
                    container,
                    builder =>
                    {
                        builder
                            .SilkTouch()
                            .Mods(context =>
                                context
                                    .AddIncludes(new())
                                    .ClangScraper(
                                        new()
                                        {
                                            ClangSharpResponseFiles =
                                            [
                                                "eng/silktouch/vulkan/**/generate.rsp",
                                            ],
                                            InputSourceRoot = "sources/Vulkan",
                                            InputTestRoot = "tests/Vulkan",
                                        }
                                    )
                                    .MarkNativeNames()
                                    .ExtractHandles()
                                    .ExtractNestedTypes()
                                    .ExtractFunctionPointers()
                                    .TransformHandles(new() { UseDsl = true })
                                    .MixKhronosData(
                                        new()
                                        {
                                            SpecPath = "eng/submodules/vulkan-docs/xml/vk.xml",
                                            Namespace = "Silk.NET.Vulkan",
                                            StructureTypes = ["VkStructureType"],
                                            FlagsTypes = ["VkFlags", "VkFlags64"],
                                            ExcludeVendorSuffixIdentification =
                                            [
                                                "VK_VENDOR_ID_VIV",
                                                "VK_VENDOR_ID_VSI",
                                                "VK_VENDOR_ID_MESA",
                                            ],
                                            IdentifyEnumMemberImpliedVendors = true,
                                        }
                                    )
                                    .AddApiProfiles(
                                        new()
                                        {
                                            Profiles =
                                            [
                                                new()
                                                {
                                                    Profile = "vulkan",
                                                    SourceSubdirectory = "vulkan",
                                                },
                                            ],
                                        }
                                    )
                                    .InterceptNativeFunctions(
                                        new()
                                        {
                                            NativeFunctionNames =
                                            [
                                                "vkCreateInstance",
                                                "vkCreateDevice",
                                            ],
                                        }
                                    )
                                    .TransformFunctions(
                                        new() { BoolTypes = new() { ["VkBool32"] = null } }
                                    )
                                    .TransformProperties(
                                        new() { BoolTypes = new() { ["VkBool32"] = null } }
                                    )
                                    .IdentifySharedPrefixes(
                                        new()
                                        {
                                            GlobalPrefixHints = ["PFN_vk", "vk"],
                                            PrefixOverrides = new()
                                            {
                                                ["VkImageCreateFlags2KHR"] = "VK_IMAGE_CREATE_2",
                                                ["VkPipelineCreateFlags2"] = "VK_PIPELINE_CREATE_2",
                                                ["VkMemoryDecompressionMethodFlagsEXT"] =
                                                    "VK_MEMORY_DECOMPRESSION_METHOD",
                                            },
                                        }
                                    )
                                    .PrettifyNames(
                                        new()
                                        {
                                            NameOverrides = new() { ["numAABBs"] = "NumAabbs" },
                                            Affixes = new()
                                            {
                                                ["HandleType"] = new() { Order = 1 },
                                                ["FunctionPointerDelegateType"] = new()
                                                {
                                                    Order = 1,
                                                },
                                                ["KhronosVendor"] = new() { Order = -1 },
                                                ["KhronosImpliedVendor"] = new() { Remove = true },
                                                ["KhronosHandleType"] = new() { Remove = true },
                                                ["SharedPrefix"] = new() { Remove = true },
                                            },
                                        }
                                    )
                                    .TransformEnums(
                                        new()
                                        {
                                            AddNoneMemberToFlags = true,
                                            RemoveMembers =
                                            [
                                                new()
                                                {
                                                    MemberName = "MaxEnum",
                                                    MemberValue = "0x7FFFFFFF",
                                                },
                                                new()
                                                {
                                                    MemberName = "Invalid",
                                                    MemberValue = "0x7FFFFFFF",
                                                },
                                            ],
                                            CoerceBackingTypes = TransformEnums
                                                .EnumBackingTypePreference
                                                .PreferUnsigned,
                                            RewriteMemberValues = true,
                                        }
                                    )
                                    .AddVTables(
                                        new()
                                        {
                                            VTables =
                                            [
                                                new AddVTables.DllImport(),
                                                new AddVTables.StaticWrapper(),
                                                new AddVTables.ThisThread()
                                                {
                                                    IsDefault = true,
                                                    GenerateFactoryPartial = true,
                                                },
                                            ],
                                        }
                                    )
                                    .StripAttributes(
                                        new()
                                        {
                                            Remove = ["NativeTypeName", "NameAffix", "Transformed"],
                                        }
                                    )
                            );
                    }
                ),
            };

            var jobsToRun = allJobs.Where(job =>
            {
                if (jobKeysToSkip.Contains(job.Key))
                {
                    return false;
                }

                return jobKeysToRun.Count == 0 || jobKeysToRun.Contains(job.Key);
            });

            await Parallel.ForEachAsync(
                jobsToRun,
                new ParallelOptions
                {
                    MaxDegreeOfParallelism = ctx.ParseResult.GetValueForOption(JobsOption),
                },
                async (job, ct) =>
                {
                    await job.RunAsync(ct);
                }
            );

            // Workaround for dangling logging/socket engine threads
            Environment.Exit(0);
        });

        await rootCommand.InvokeAsync(args);
    }
}
