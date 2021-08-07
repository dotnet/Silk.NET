// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
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
    /// <summary>
    /// A helper class for loading and saving configuration files. Basically just a thin wrapper around
    /// <see cref="JsonSerializer"/> to make your code neater.
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// Loads the given SilkTouch JSON Configuration as a <see cref="ProjectConfiguration"/> record.
        /// </summary>
        /// <param name="json">The SilkTouch JSON Configuration.</param>
        /// <returns>The <see cref="ProjectConfiguration"/> record representation of the JSON.</returns>
        /// <exception cref="DataException">If the data yielded a null configuration.</exception>
        public static ProjectConfiguration Load(string json)
            => JsonSerializer.Deserialize<ProjectConfiguration>(json) ??
               throw new DataException("JSON deserialization of SilkTouch Configuration yielded null.");

        /// <summary>
        /// Attempts to load a configuration file from Roslyn AdditionalFiles.
        /// </summary>
        /// <param name="provider">The editorconfig options provider.</param>
        /// <param name="additionalFiles">The AdditionalFiles.</param>
        /// <param name="config">The project-specific SilkTouch configuration loaded, or null if none loaded.</param>
        /// <param name="usedText">The <see cref="AdditionalText"/> used to load the config.</param>
        /// <param name="reportDiagnostic">
        /// An action which, when called, handles diagnostics generated as part of loading.
        /// </param>
        /// <returns>Whether the overall configuration load was successful or not.</returns>
        public static bool TryLoad
        (
            AnalyzerConfigOptionsProvider provider,
            ImmutableArray<AdditionalText> additionalFiles,
            out ProjectConfiguration? config,
            out AdditionalText? usedText,
            Action<Diagnostic>? reportDiagnostic
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
                        Log.Debug($"We've already found \"{usedText.Path}\" though - using that instead!");
                        config = null;
                        reportDiagnostic?.Invoke(Diagnostic.Create
                        (
                            Diagnostics.MultipleConfigFiles,
                            Location.Create(additionalFile.Path, TextSpan.FromBounds(0, 0), default),
                            usedText.Path,
                            additionalFile.Path
                        ));
                        
                        continue;
                    }

                    usedText = additionalFile;
                }
            }
            
            if (usedText is null)
            {
                Log.Debug("No config.");
                config = null;
                usedText = null;
                reportDiagnostic?.Invoke(Diagnostic.Create(Diagnostics.NoConfigFile, Location.None));
                return false;
            }

            Log.Debug("Good config.");
            config = Load(File.ReadAllText(usedText.Path)); // was gonna use usedText.GetText() until I saw their code.
            return true;
        }

        /// <summary>
        /// Saves the given <see cref="ProjectConfiguration"/> record into JSON.
        /// </summary>
        /// <param name="config">The <see cref="ProjectConfiguration"/> record representation of the configuration.</param>
        /// <returns>The JSON representation of the projects.</returns>
        public static string Save(ProjectConfiguration config)
            => JsonSerializer.Serialize(config);
    }

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
        [property: JsonPropertyName("globalFile")] string? GlobalConfigFile,
        [property: JsonPropertyName("emitter")] EmitterConfiguration? Emitter,
        [property: JsonPropertyName("overloader")] OverloaderConfiguration? Overloader,
        [property: JsonPropertyName("scraper")] ScraperConfiguration? Scraper,
        [property: JsonPropertyName("cliSkipIf")] string[]? CommandLineSkipIf
    )
    {
        /// <summary>Gets the global config stored in <see cref="GlobalConfigFile"/> if provided.</summary>
        /// <param name="baseDir">The base directory to search for files from.</param>
        /// <returns>The global config.</returns>
        public GlobalConfiguration? GetGlobalConfiguration(string baseDir)
        {
            if (GlobalConfigFile is null)
            {
                return null;
            } 
            
            var path = GlobalConfigFile;
            // Poor man's way of doing Path.GetFullPath(a, b) which is unavailable on NS20
            if (Path.GetFullPath(GlobalConfigFile) != GlobalConfigFile)
            {
                path = Path.Combine(baseDir, GlobalConfigFile);
            }

            return JsonSerializer.Deserialize<GlobalConfiguration>(File.ReadAllText(path));
        }
    }

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
        [property: JsonPropertyName("jobs")] ScraperJobConfiguration[]? Jobs
    );

    public record ScraperJobConfiguration
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
