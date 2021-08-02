// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;
using Silk.NET.SilkTouch.Configuration.Json;

namespace Silk.NET.SilkTouch.Configuration
{
    public static class Config
    {
        /// <summary>
        /// Loads the given SilkTouch JSON Configuration into a dictionary of per-project configurations.
        /// </summary>
        /// <param name="json">The SilkTouch JSON Configuration.</param>
        /// <returns>A dictionary containing project-specific configuration.</returns>
        /// <exception cref="DataException">If the data yielded a null configuration.</exception>
        public static Dictionary<string, ProjectConfiguration> Load(string json)
            => JsonSerializer.Deserialize<Dictionary<string, ProjectConfiguration>>(json) ??
               throw new DataException("JSON deserialization of SilkTouch Configuration yielded null.");

        /// <summary>
        /// Saves the given per-project configuration dictionary into JSON.
        /// </summary>
        /// <param name="projects">A dictionary containing per-project configuration.</param>
        /// <returns></returns>
        public static string Save(Dictionary<string, ProjectConfiguration> projects)
            => JsonSerializer.Serialize(projects);
    }

    public record RootConfiguration
    (
        [property: JsonPropertyName("fileHeader")] string[]? FileHeaderLines,
        [property: JsonPropertyName("projects")] Dictionary<string, ProjectConfiguration> Projects
    );

    /// <summary>
    /// The root project configuration structure.
    /// </summary>
    /// <param name="Emitter">SilkTouch Emitter specific configuration for this project.</param>
    /// <param name="Overloader">SilkTouch Overloader specific configuration for this project.</param>
    /// <param name="Scraper">SilkTouch Scraper specific configuration for this project.</param>
    public record ProjectConfiguration
    (
        [property: JsonPropertyName("emitter")] EmitterConfiguration Emitter,
        [property: JsonPropertyName("overloader")] OverloaderConfiguration Overloader,
        [property: JsonPropertyName("scraper")] ScraperConfiguration Scraper
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
        [property: JsonPropertyName("text")] string[]? HeaderText,
        [property: JsonPropertyName("include")] string[]? IncludeDirectories,
        [property: JsonPropertyName("traverse")] string[]? Traverse,
        [property: JsonPropertyName("unixMode")] bool? UnixMode,
        [property: JsonPropertyName("exclude")] string[]? Exclude,
        [property: JsonPropertyName("mods")] string[]? Mods,
        [property: JsonPropertyName("modOptions")] Dictionary<string, string>? Properties,
        [property: JsonPropertyName("libraryNames")] string[]? LibraryNames,
        [property: JsonPropertyName("namespace")] string? Namespace
    );
    
    public record Excludes
    (
        HashSet<string> Identifiers,
        ExclusionHint Hints
    );
}
