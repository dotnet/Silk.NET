using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using NUnit.Framework;
using Silk.NET.BuildTools.Common;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Mods.Metadata;
using VerifyNUnit;
using VerifyTests;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.UnitTests.Khronos;

[TestFixture]
public class MixKhronosDataTests
{
    struct Options : IOptionsSnapshot<MixKhronosData.Configuration>
    {
        public required MixKhronosData.Configuration Value { get; init; }

        public MixKhronosData.Configuration Get(string? name) => Value;
    }

    [ModuleInitializer]
    public static void Initialize() => VerifyDiffPlex.Initialize();

    public static string TestFile(string name, [CallerFilePath] string? fPath = null) =>
        Path.Combine(
            Path.GetDirectoryName(fPath)
                ?? throw new InvalidOperationException("Expected to get directory name of test."),
            $"test{name}"
        );

    public static IEnumerable<string> TestFiles(
        Regex regex,
        [CallerFilePath] string? fPath = null
    ) =>
        Directory
            .GetFiles(
                Path.GetDirectoryName(fPath)
                    ?? throw new InvalidOperationException("Expected to get directory name of test")
            )
            .Where(x => regex.IsMatch(x));

    private static IAsyncEnumerable<object[]> TestCases()
    {
        IEnumerable<string> files = ["gl.xml", "wgl.xml", "glx.xml", "cl.xml", "vk.xml"];
        return files
            .ToAsyncEnumerable()
            .SelectAwait(async x =>
            {
                var mod = new MixKhronosData(
                    new NullLogger<MixKhronosData>(),
                    new Options
                    {
                        Value = new MixKhronosData.Configuration { SpecPath = TestFile(x) },
                    }
                );
                await mod.InitializeAsync(new DummyModContext());
                return (object[])[x, mod.Jobs[""]];
            });
    }

    private static IAsyncEnumerable<object[]> EnumTestCases() =>
        TestCases().Where(x => x[0] is "gl.xml" or "wgl.xml" or "glx.xml" or "cl.xml");

    private static IAsyncEnumerable<object[]> RegressionTestCases() =>
        TestCases()
            .SelectAwait(async s =>
                s[0] is "gl.xml" or "cl.xml"
                    ? (object[])
                        [
                            s[0],
                            s[1],
                            await Task.WhenAll(
                                TestFiles(
                                        new Regex(
                                            $@"regression\.2\.21\.{((string)s[0])[..^4]}.*\.json\.gz"
                                        )
                                    )
                                    .Select(ReadProfile)
                            ),
                        ]
                    : null
            )
            .OfType<object[]>();

    private static async Task<Profile> ReadProfile(string fPath)
    {
        await using var fs = File.OpenRead(fPath);
        await using var gz = new GZipStream(fs, CompressionMode.Decompress);
        using var sr = new StreamReader(gz);
        return JsonConvert.DeserializeObject<Profile>(await sr.ReadToEndAsync())
            ?? throw new InvalidDataException("Deserialization returned null");
    }

    [Test, TestCaseSource(nameof(EnumTestCases))]
    public Task EnumsToGroups(string file, object data) =>
        Verifier
            .Verify(
                string.Join(
                    '\n',
                    ((MixKhronosData.JobData)data)
                        .EnumsToGroups.OrderBy(x => x.Key)
                        .Select(x => $"{x.Key} = {string.Join(", ", x.Value.Order())}")
                )
            )
            .UseFileName($"{nameof(MixKhronosDataTests)}.{nameof(EnumsToGroups)}.{file}");

    [Test, TestCaseSource(nameof(TestCases))]
    public Task ApiSets(string file, object data) =>
        Verifier
            .Verify(
                string.Join(
                    '\n',
                    ((MixKhronosData.JobData)data)
                        .ApiSets.OrderBy(x => x.Key)
                        .Select(x =>
                            string.Join(
                                '\n',
                                x.Value.Dependencies.Select(y =>
                                    $"[{y.Key}] {(x.Value.IsExtension ? $"{x.Key} (extension)" : x.Key)} = "
                                    + string.Join(", ", y.Value.Order())
                                )
                            )
                        )
                )
            )
            .UseFileName($"{nameof(MixKhronosDataTests)}.{nameof(ApiSets)}.{file}");

    [Test, TestCaseSource(nameof(RegressionTestCases))]
    public Task EnumGroupRegression(string file, object data, Profile[] profiles)
    {
        var baselineGroups = new Dictionary<string, HashSet<string>>();
        foreach (
            var x in profiles
                .SelectMany(x => x.Projects.Values)
                .SelectMany(x => x.Enums)
                .Where(x =>
                    !string.IsNullOrWhiteSpace(x.NativeName) && x.NativeName is not "CLenum"
                )
        )
        {
            var key = (
                x.NativeName is "GLenum" ? "GLEnum"
                : x.NativeName.StartsWith("ErrorCodes") ? "ErrorCodes"
                : x.NativeName
            ).Replace('.', '_').Trim();
            key = key[(key.LastIndexOf(' ') + 1)..];
            if (!baselineGroups.TryGetValue(key, out var constituents))
            {
                constituents = baselineGroups[key] = [];
            }

            foreach (var token in x.Tokens.Where(y => !string.IsNullOrWhiteSpace(y.NativeName)))
            {
                constituents.Add(token.NativeName);
            }
        }
        var newGroups = ((MixKhronosData.JobData)data).Groups.ToDictionary(
            x => x.Key,
            _ => new HashSet<string>()
        );
        foreach (var (enumName, groupNames) in ((MixKhronosData.JobData)data).EnumsToGroups)
        {
            foreach (var groupName in groupNames)
            {
                if (newGroups.TryGetValue(groupName, out var constituents))
                {
                    constituents.Add(enumName);
                }
                else
                {
                    newGroups[groupName] = [enumName];
                }
            }
        }
        var verifyFile = new StringBuilder();
        verifyFile.AppendLine(
            "NOTE: This file lists differences/regressions between 3.0's enum grouping system "
                + "baselined against 2.21's. If this file is non-empty and verified, it means the regressions have "
                + "been justified. Justified differences are usually as a result of a discrepancy between the "
                + "regression baseline JSON and the baseline XML.\n"
        );
        foreach (
            var (groupName, _) in baselineGroups
                .Where(x => !newGroups.ContainsKey(x.Key))
                .OrderBy(x => x.Key)
        )
        {
            verifyFile.AppendLine($"Removed Group: {groupName}");
        }

        var unchanged = new List<string>();
        foreach (var (groupName, constituents) in newGroups.OrderBy(x => x.Key))
        {
            var hasOutputHeader = !baselineGroups.TryGetValue(
                groupName,
                out var baselineConstituents
            );
            if (hasOutputHeader)
            {
                verifyFile.AppendLine($"\nAdded Group: {groupName}");
            }

            foreach (var constituent in baselineConstituents?.Order() ?? Enumerable.Empty<string>())
            {
                if (!constituents.Contains(constituent))
                {
                    if (!hasOutputHeader)
                    {
                        verifyFile.AppendLine($"\nExisting Group: {groupName}");
                        hasOutputHeader = true;
                    }

                    verifyFile.AppendLine($"    Removed: {constituent}");
                }
            }

            foreach (
                var constituent in constituents
                    .Where(x => !(baselineConstituents?.Contains(x) ?? false))
                    .Order()
            )
            {
                if (!hasOutputHeader)
                {
                    verifyFile.AppendLine($"\nExisting Group: {groupName}");
                    hasOutputHeader = true;
                }

                verifyFile.AppendLine($"    Added: {constituent}");
            }

            if (!hasOutputHeader)
            {
                unchanged.Add(groupName);
            }
        }

        verifyFile.AppendLine($"\nUnchanged: {string.Join(", ", unchanged)}");
        return Verifier
            .Verify(verifyFile.ToString())
            .UseFileName($"{nameof(MixKhronosDataTests)}.{nameof(EnumGroupRegression)}.{file}");
    }

    [Test, TestCaseSource(nameof(TestCases))]
    public Task SupportedApiProfiles(string file, object data) =>
        Verifier
            .Verify(
                string.Join(
                    '\n',
                    ((MixKhronosData.JobData)data)
                        .SupportedApiProfiles?.OrderBy(x => x.Key)
                        .Select(x =>
                            $"{x.Key}\n{new string('-', x.Key.Length)}\n{string.Join('\n', x.Value.Select(y => AttributeList(SingletonSeparatedList(y.GetSupportedApiProfileAttribute())).ToString()).Order())}\n"
                        ) ?? []
                )
            )
            .UseFileName($"{nameof(MixKhronosDataTests)}.{nameof(SupportedApiProfiles)}.{file}");

    [Test]
    public void DependsStringParsing1() =>
        Assert.That(
            MixKhronosData
                .ParseDependencyOptions(
                    "((VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)+VK_KHR_depth_stencil_resolve),VK_VERSION_1_2"
                )
                .Options,
            Is.EquivalentTo(
                (IEnumerable<string>)
                    [
                        "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
                        "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
                        "VK_VERSION_1_2",
                    ]
            )
        );

    [Test]
    public void DependsStringParsing2() =>
        Assert.That(
            MixKhronosData
                .ParseDependencyOptions(
                    "((VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation),VK_VERSION_1_1)+VK_EXT_queue_family_foreign"
                )
                .Options,
            Is.EquivalentTo(
                (IEnumerable<string>)
                    [
                        "VK_EXT_queue_family_foreign+VK_KHR_sampler_ycbcr_conversion+VK_KHR_external_memory+VK_KHR_dedicated_allocation",
                        "VK_EXT_queue_family_foreign+VK_VERSION_1_1",
                    ]
            )
        );
}
