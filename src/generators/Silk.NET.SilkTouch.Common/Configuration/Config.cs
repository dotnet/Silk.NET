// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Silk.NET.SilkTouch.Configuration.Json;
using Ultz.Extensions.Logging;

namespace Silk.NET.SilkTouch.Configuration
{
    public static class Config
    {
        /// <summary>
        /// Loads the given SilkTouch JSON Configuration as a <see cref="RootConfiguration"/> record.
        /// </summary>
        /// <param name="json">The SilkTouch JSON Configuration.</param>
        /// <returns>The <see cref="RootConfiguration"/> record representation of the JSON.</returns>
        /// <exception cref="DataException">If the data yielded a null configuration.</exception>
        public static RootConfiguration Load(string json)
            => JsonSerializer.Deserialize<RootConfiguration>(json) ??
               throw new DataException("JSON deserialization of SilkTouch Configuration yielded null.");

        public static Diagnostic? Load
        (
            AnalyzerConfigOptionsProvider provider,
            ImmutableArray<AdditionalText> additionalFiles,
            out RootConfiguration? config,
            out AdditionalText? usedText
        )
        {
            // Get the config file name. Uses silktouch.json unless overridden in .editorconfig.
            var configFileName = "silktouch.json";
            if (provider.GlobalOptions
                .TryGetValue(Constants.ConfigFileEditorconfigOption, out var file))
            {
                Log.Debug($"User has overriden \"{configFileName}\" to \"{file}\"");
                configFileName = file;
            }

            // Try and find an AdditionalFiles entry for the SilkTouch config.
            usedText = null;
            foreach (var additionalFile in additionalFiles)
            {
                Log.Debug($"Testing \"{additionalFile.Path}\" (expecting \"{configFileName}\")...");
                if (additionalFile.Path == configFileName || Path.GetFileName(additionalFile.Path) == configFileName)
                {
                    Log.Debug($"\"{additionalFile.Path}\" is a good match.");
                    if (usedText is not null)
                    {
                        Log.Debug($"We've already found \"{usedText.Path}\" though!");
                        config = null;
                        var ret = Diagnostic.Create
                        (
                            Diagnostics.MultipleConfigFiles,
                            Location.Create(additionalFile.Path, TextSpan.FromBounds(0, 0), default),
                            usedText.Path,
                            additionalFile.Path
                        );

                        usedText = null;
                        return ret;
                    }

                    usedText = additionalFile;
                }
            }
            
            if (usedText is null)
            {
                Log.Debug("No config.");
                config = null;
                usedText = null;
                return Diagnostic.Create(Diagnostics.NoConfigFile, Location.None);
            }

            Log.Debug("Good config.");
            config = Load(File.ReadAllText(usedText.Path)); // was gonna use usedText.GetText() until I saw their code.
            return null;
        }

        /// <summary>
        /// Saves the given <see cref="RootConfiguration"/> record into JSON.
        /// </summary>
        /// <param name="config">The <see cref="RootConfiguration"/> record representation of the configuration.</param>
        /// <returns>The JSON representation of the projects.</returns>
        public static string Save(RootConfiguration config)
            => JsonSerializer.Serialize(config);
    }

    /// <summary>
    /// The root configuration structure.
    /// </summary>
    /// <param name="Global"></param>
    /// <param name="Projects"></param>
    public record RootConfiguration
    (
        [property: JsonPropertyName("global")] GlobalConfiguration Global,
        [property: JsonPropertyName("projects")] Dictionary<string, ProjectConfiguration>? Projects
    );

    /// <summary>
    /// Common configuration across all projects.
    /// </summary>
    /// <param name="FileHeaderLines">The file header to add to all files.</param>
    public record GlobalConfiguration
    (
        [property: JsonPropertyName("fileHeader")] string[]? FileHeaderLines
    );

    /// <summary>
    /// The root project configuration structure.
    /// </summary>
    /// <param name="Emitter">SilkTouch Emitter specific configuration for this project.</param>
    /// <param name="Overloader">SilkTouch Overloader specific configuration for this project.</param>
    /// <param name="Scraper">SilkTouch Scraper specific configuration for this project.</param>
    public record ProjectConfiguration
    (
        [property: JsonPropertyName("emitter")] EmitterConfiguration? Emitter,
        [property: JsonPropertyName("overloader")] OverloaderConfiguration? Overloader,
        [property: JsonPropertyName("scraper")] ScraperConfiguration? Scraper,
        [property: JsonPropertyName("skipIf")] string[]? SkipIf
    );

    /// <summary>
    /// SilkTouch Emitter specific configuration.
    /// </summary>
    /// <param name="FormFactors">
    /// The form factors in which the Emitter should run. If null, defaults to just Roslyn.
    /// </param>
    public record EmitterConfiguration
    (
        [property: JsonPropertyName("mode"), JsonConverter(typeof(FormFactorsJsonConverter))]
        FormFactors? FormFactors
    );

    /// <summary>
    /// SilkTouch Emitter specific configuration.
    /// </summary>
    /// <param name="FormFactors">
    /// The form factors in which the Emitter should run. If null, defaults to just Roslyn.
    /// </param>
    public record OverloaderConfiguration
    (
        [property: JsonPropertyName("mode"), JsonConverter(typeof(FormFactorsJsonConverter))]
        FormFactors? FormFactors
    );

    /// <summary>
    /// SilkTouch Scraper specific configuration.
    /// </summary>
    public record ScraperConfiguration
    (
        [property: JsonPropertyName("headerText")] string[]? HeaderText,
        [property: JsonPropertyName("include")] string[]? IncludeDirectories,
        [property: JsonPropertyName("traverse")] string[]? Traverse,
        [property: JsonPropertyName("unixMode")] bool? UnixMode,
        [property: JsonPropertyName("exclude"), JsonConverter(typeof(ExcludesJsonConverter))] Excludes? Exclude,
        [property: JsonPropertyName("mods")] string[]? Mods,
        [property: JsonPropertyName("modOptions")] Dictionary<string, string>? Properties,
        [property: JsonPropertyName("libraryNames")] string[]? LibraryNames,
        [property: JsonPropertyName("namespace")] string? Namespace,
        [property: JsonPropertyName("language")] string? Language,
        [property: JsonPropertyName("std")] string? Standard,
        [property: JsonPropertyName("clangArgs")] string[]? AdditionalClangArguments,
        [property: JsonPropertyName("define")] string[]? DefineMacros,
        [property: JsonPropertyName("className")] string? ClassName,
        [property: JsonPropertyName("methodPrefix")] string? MethodPrefixToStrip,
        [property: JsonPropertyName("remappingFiles")] string[]? RemappingFiles,
        [property: JsonPropertyName("conventions")] Dictionary<string, string>? CallingConventions
    );
    
    public record Excludes
    (
        string[] Identifiers,
        ExclusionHint Hints
    );
}
