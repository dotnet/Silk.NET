using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods.Metadata;
using Silk.NET.SilkTouch.Mods.Transformation;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A mod that reads Khronos specifications to influence codegen.
/// </summary>
/// <param name="logger">The logger.</param>
/// <param name="cfg">The configuration.</param>
[ModConfiguration<Configuration>]
public partial class MixKhronosData(
    ILogger<MixKhronosData> logger,
    IOptionsSnapshot<MixKhronosData.Configuration> cfg
)
    : IMod,
        IResponseFileMod,
        INameTrimmer,
        IFunctionTransformer,
        IApiMetadataProvider<SymbolConstraints>,
        IApiMetadataProvider<IEnumerable<SupportedApiProfileAttribute>>
{
    internal ConcurrentDictionary<string, JobData> Jobs = new();
    private static readonly char[] _listSeparators = { ',', '|', '+' };

    private static readonly Dictionary<string, string> _defaultEnumNativeTypeNameMaps =
        new()
        {
            { "GLenum", "GLEnum" },
            { "EGLenum", "EGLEnum" },
            { "GLbitfield", "GLEnum" },
        };

    internal class JobData
    {
        /// <summary>
        /// The job configuration.
        /// </summary>
        public required Configuration Configuration { get; init; }

        /// <summary>
        /// A mapping of enum native names to group names.
        /// </summary>
        /// <remarks>
        /// This is OpenGL and OpenCL specific.
        /// </remarks>
        public Dictionary<string, HashSet<string>> EnumsToGroups { get; } = [];

        /// <summary>
        /// A mapping of group names to constant declarators.
        /// </summary>
        /// <remarks>
        /// This is OpenGL and OpenCL specific.
        /// </remarks>
        public Dictionary<string, EnumGroup> Groups { get; } = [];

        /// <summary>
        /// A mapping of feature/extension names to whether they're a feature or not and their API set dependencies for
        /// each profile/variant.
        /// </summary>
        /// <remarks>
        /// Note that feature names refer specifically to <c>GL_VERSION_1_0</c> and <c>VK_VERSION_1_0</c> and not the
        /// profile names such as <c>gl</c> or <c>vulkan</c>. Extension names are in the obvious format i.e.
        /// <c>GL_EXT_direct_state_access</c>.
        /// </remarks>
        public Dictionary<
            string,
            (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
        > ApiSets { get; set; } = [];

        /// <summary>
        /// A mapping of native names to their supported API profile attributes.
        /// </summary>
        public Dictionary<
            string,
            List<SupportedApiProfileAttribute>
        >? SupportedApiProfiles { get; set; }

        /// <summary>
        /// The vendors contributing to the specification. This is in extension form e.g. Microsoft is MSFT.
        /// </summary>
        public HashSet<string>? Vendors { get; set; }

        /// <summary>
        /// A map of containing symbol names (i.e. function or struct) and applicable symbol names (i.e. field name,
        /// parameter name, or <c>:return</c>)
        /// </summary>
        public Dictionary<
            (string ContainingSymbol, string ApplicableSymbol),
            (string? Group, string? Handle, SymbolConstraints? Usage)
        > Annotations { get; set; } = [];

        /// <summary>
        /// A map of native type names to C# type names. This contains the contents of
        /// <see cref="Configuration.TypeMap"/> in addition to some default contents i.e. it is a copy to avoid
        /// modifying the original configuration object. It is used in the same way.
        /// </summary>
        public Dictionary<string, string> TypeMap { get; init; } = [];

        /// <summary>
        /// This tracks a set of enum members marked with the deprecated="aliased" attribute.
        /// These are removed from the generated bindings.
        /// </summary>
        /// <remarks>
        /// At the time this was added, only Vulkan seems to use the deprecated="aliased" attribute.
        /// These names tend to cause name collisions after names are prettified so removing these
        /// prevents these issues. This can cause API breakages, but because these are aliases,
        /// these are easily solvable breakages.
        /// </remarks>
        public HashSet<string> DeprecatedAliases = [];

        /// <summary>
        /// Additional type remappings to pass to ClangSharp.
        /// </summary>
        /// <remarks>
        /// This was added for Vulkan Flags/FlagBits remappings.
        /// </remarks>
        public Dictionary<string, string> AdditionalTypeRemappings = [];
    }

    /// <summary>
    /// Khronos mod configuration.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// The path to the XML specification file.
        /// </summary>
        /// <remarks>
        /// Can be null, in which case this is equivalent to just using OpenGL style trimmings on non-OpenGL bindings
        /// which we do want to do in some cases (like OpenAL)
        /// </remarks>
        public string? SpecPath { get; init; }

        /// <summary>
        /// Whether OpenGL-style data type suffixes should be trimmed.
        /// </summary>
        public bool UseDataTypeTrimmings { get; init; }

        /// <summary>
        /// A map of native type names to group names.
        /// </summary>
        public Dictionary<string, string> EnumNativeTypeNames { get; init; } =
            _defaultEnumNativeTypeNameMaps;

        /// <summary>
        /// A map of native type names to C# type names. This is mostly used for determining enum backing types.
        /// </summary>
        public Dictionary<string, string>? TypeMap { get; init; }

        /// <summary>
        /// Default namespace for enums.
        /// </summary>
        public string? Namespace { get; init; }

        /// <summary>
        /// The base type used for flags/bitmask enums.
        /// For example, VkFlags and VkFlags64 for Vulkan.
        /// </summary>
        /// <remarks>
        /// This mainly affects remappings.
        /// If some flags types are showing as integral types instead of their proper type, make sure this property is configured.
        /// </remarks>
        public string[] FlagsTypes { get; init; } = [];

        /// <summary>
        /// Whether Khronos-style extension naming conventions are not applicable here (e.g. OpenAL).
        /// </summary>
        public bool NonStandardExtensionNomenclature { get; init; }

        /// <summary>
        /// Additional extension vendors to recognise, typically used in conjunction with
        /// <see cref="NonStandardExtensionNomenclature"/>.
        /// </summary>
        public List<string>? Vendors { get; init; }

        /// <summary>
        /// Additional suffixes that may follow a data type suffix but precede a vendor suffix that should be ignored
        /// when determining a data type suffix to trim when <see cref="UseDataTypeTrimmings"/> is on. For example,
        /// <c>Direct</c> for OpenAL.
        /// </summary>
        public List<string>? IgnoreNonVendorSuffixes { get; init; }

        /// <summary>
        /// The priority with which vendor suffixes are applied.
        /// </summary>
        public int VendorSuffixPriority { get; init; } = 0;

        /// <summary>
        /// The set of identifiers that should be excluded from vendor suffix identification.
        /// </summary>
        /// <remarks>
        /// See <see cref="RewriterPhase3"/>.
        /// </remarks>
        public HashSet<string> VendorSuffixIdentificationExclusions { get; init; } = [];
    }

    /// <inheritdoc />
    // non-versioned trimmer (and needs to be a big number to come after the default trimmers)
    public Version Version { get; } = new(42, 42, 42, 42);

    /// <inheritdoc />
    public async Task InitializeAsync(IModContext ctx, CancellationToken ct = default)
    {
        var currentConfig = cfg.Get(ctx.JobKey);
        var specPath = currentConfig.SpecPath;
        var job = Jobs[ctx.JobKey] = new JobData
        {
            Configuration = currentConfig,
            TypeMap = currentConfig.TypeMap is not null
                ? new Dictionary<string, string>(currentConfig.TypeMap)
                : [],
        };
        job.TypeMap.TryAdd("int8_t", "sbyte");
        job.TypeMap.TryAdd("uint8_t", "byte");
        job.TypeMap.TryAdd("int16_t", "short");
        job.TypeMap.TryAdd("uint16_t", "ushort");
        job.TypeMap.TryAdd("int32_t", "int");
        job.TypeMap.TryAdd("uint32_t", "uint");
        job.TypeMap.TryAdd("int64_t", "long");
        job.TypeMap.TryAdd("uint64_t", "ulong");
        job.TypeMap.TryAdd("GLenum", "uint");
        job.TypeMap.TryAdd("GLbitfield", "uint");
        if (specPath is null)
        {
            // No metadata, can't continue. It'd be odd if the Khronos mod is being used in this case. There was once
            // actually a use case for it, but the ArrayParameterTransformer (once Khronos-specific) is no longer
            // Khronos-specific.
            return;
        }

        logger.LogInformation("Reading Khronos XML from \"{}\"...", specPath);
        await using var fs = File.OpenRead(specPath);
        var xml = await XDocument.LoadAsync(fs, LoadOptions.None, CancellationToken.None);

        var (apiSets, supportedApiProfiles) = EvaluateProfiles(xml);
        job.ApiSets = apiSets;
        job.SupportedApiProfiles = supportedApiProfiles;

        var profiles = supportedApiProfiles.SelectMany(x => x.Value).Select(x => x.Profile).ToHashSet();

        job.Vendors =
        [
            .. xml.Element("registry")
                ?.Element("tags")
                ?.Elements("tag")
                .Attributes("name")
                .Select(x => x.Value) ?? [],
            .. currentConfig.NonStandardExtensionNomenclature
                ? []
                : xml.Element("registry")
                    ?.Element("extensions")
                    ?.Elements("extension")
                    // Only include vendors who have extensions that match a declared profile
                    // This is mainly to exclude extensions that are declared as supported="disabled"
                    .Where(ext =>
                    {
                        var supportedProfiles = ext.Attribute("supported")?.Value.Split("|") ?? [];
                        return profiles.Intersect(supportedProfiles).Any();
                    })
                    .Attributes("name")
                    // Extract the second part from the extension name
                    // Eg: GL_NV_command_list -> NV
                    .Select(name => name.Value.Split('_')[1].ToUpper()) ?? [],
            .. currentConfig.Vendors ?? [],
        ];

        job.DeprecatedAliases = xml.Descendants()
            .Where(x => x.Attribute("deprecated")?.Value == "aliased" && x.Attribute("name") != null)
            .Select(x => x.Attribute("name")!.Value).ToHashSet();

        ReadGroups(xml, job, job.Vendors);

        foreach (var typeElement in xml.Elements("registry").Elements("types").Elements("type"))
        {
            var type = typeElement.Element("name")?.Value;
            var baseType = typeElement.Element("type")?.Value;
            if (type is null || baseType is null)
            {
                continue;
            }

            job.TypeMap.TryAdd(type, baseType);
        }

        // Add mappings from Flags storage types to FlagBits enums types
        // We want Flags as the output, but in order to generate everything correctly,
        // we need to first map Flags to FlagBits, then rename FlagBits back to Flags (this is done in the rewriters).
        // Without this, ClangSharp will output the Flags types as the integral storage type instead of the enum
        var flagsTypesSet = currentConfig.FlagsTypes.ToHashSet();
        foreach (var typeElement in xml.Elements("registry").Elements("types").Elements("type"))
        {
            var typedef = typeElement.Element("type")?.Value;
            var isFlagsType = typedef != null && flagsTypesSet.Contains(typedef);
            if (!isFlagsType)
            {
                continue;
            }

            var mapFrom = typeElement.Element("name")?.Value;
            var mapTo = typeElement.Attribute("requires")?.Value;
            if (mapFrom == null || mapTo == null)
            {
                continue;
            }

            job.AdditionalTypeRemappings[mapFrom] = mapTo;
        }
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var currentConfig = cfg.Get(ctx.JobKey);
        var jobData = Jobs[ctx.JobKey];
        var proj = ctx.SourceProject;

        if (proj == null)
        {
            return;
        }

        // Rewrite phase 1
        var rewriter1 = new RewriterPhase1(jobData, logger);
        foreach (var docId in proj.DocumentIds)
        {
            var doc = proj.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            proj = doc.WithSyntaxRoot(
                rewriter1.Visit(await doc.GetSyntaxRootAsync(ct))?.NormalizeWhitespace()
                ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        // Add missing enum types
        foreach (var (filePath, node) in rewriter1.GetMissingEnums())
        {
            proj = proj
                .AddDocument(
                    Path.GetFileName(filePath),
                    node.NormalizeWhitespace(),
                    filePath: proj.FullPath(filePath)
                )
                .Project;
        }

        // Rewrite phase 2
        var rewriter2 = new RewriterPhase2(jobData, rewriter1);
        foreach (var docId in proj.DocumentIds)
        {
            var doc = proj.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            proj = doc.WithSyntaxRoot(
                rewriter2.Visit(await doc.GetSyntaxRootAsync(ct))?.NormalizeWhitespace()
                ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        // Rewrite phase 3
        if (jobData.Vendors != null)
        {
            foreach (var docId in proj.DocumentIds)
            {
                var doc = proj.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
                var syntaxTree = await doc.GetSyntaxTreeAsync(ct);
                if (syntaxTree == null)
                {
                    continue;
                }

                var rewriter3 = new RewriterPhase3(jobData.Vendors, currentConfig.VendorSuffixIdentificationExclusions, currentConfig.VendorSuffixPriority);
                proj = doc.WithSyntaxRoot(
                    rewriter3.Visit(await doc.GetSyntaxRootAsync(ct))?.NormalizeWhitespace()
                    ?? throw new InvalidOperationException("Visit returned null.")
                ).Project;
            }
        }

        // Rename documents to account for FlagBits/Flags differences
        foreach (var docId in proj.DocumentIds)
        {
            var doc = proj.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            if (doc.FilePath == null)
            {
                continue;
            }

            proj = doc.ReplaceNameAndPath("FlagBits", "Flags").Project;
        }

        ctx.SourceProject = proj;
    }

    /// <inheritdoc />
    public Task<List<ResponseFile>> BeforeScrapeAsync(string key, List<ResponseFile> rsps)
    {
        var job = Jobs[key];

        rsps = rsps.Select(rsp => rsp with
        {
            GeneratorConfiguration = rsp.GeneratorConfiguration.ToWrapper() with {
                RemappedNames = rsp.GeneratorConfiguration.RemappedNames.Concat(job.AdditionalTypeRemappings).ToDictionary(),
            },
        }).ToList();

        return Task.FromResult(rsps);
    }

    /// <param name="Name">The name of the group. This is the name used for the C# enum.</param>
    /// <param name="NativeName">The native name of the group, if available. This is the name used for the [NativeName] attribute.</param>
    /// <param name="Type"></param>
    /// <param name="Enums"></param>
    /// <param name="KnownBitmask"></param>
    /// <param name="ExclusiveVendor"></param>
    /// <param name="Namespace"></param>
    internal record EnumGroup(
        string Name,
        string? NativeName,
        string? Type,
        List<VariableDeclaratorSyntax> Enums,
        bool KnownBitmask,
        string? ExclusiveVendor,
        string? Namespace
    );

    private record ProfileEvaluation(
        Version? StartVersion,
        Version? EndVersion,
        HashSet<string> ApiSets,
        HashSet<string>? ImpliedSets = null,
        bool RequireAll = false
    )
    {
        public SupportedApiProfileAttribute ToAttribute(string profile) =>
            new(profile, ApiSets.ToArray())
            {
                ImpliesSets = ImpliedSets?.ToArray(),
                MaxVersion = EndVersion?.ToString(),
                MinVersion = StartVersion?.ToString(),
                RequireAll = RequireAll,
            };
    }

    private (
        Dictionary<
            string,
            (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
        > ApiSets,
        Dictionary<string, List<SupportedApiProfileAttribute>> SupportedApiProfiles
    ) EvaluateProfiles(XDocument xml)
    {
        // A map of native names to profile names to versions
        var profile = new Dictionary<string, Dictionary<string, List<ProfileEvaluation>>>();

        // A map of API set names (feature/extension names) to whether they're an extension and the other sets they are
        // dependent upon.
        var apiSets =
            new Dictionary<
                string,
                (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
            >();

        EvaluateFeatures(xml, profile, apiSets);
        EvaluateExtensions(xml, profile, apiSets);

        // Create attributes for the evaluations.
        return (
            apiSets,
            profile.ToDictionary(
                x => x.Key,
                x => x.Value.SelectMany(y => y.Value.Select(z => z.ToAttribute(y.Key))).ToList()
            )
        );
    }

    private class VersionComparer : IComparer<string?>
    {
        public static VersionComparer Instance { get; } = new();

        public int Compare(string? x, string? y) =>
            Version.TryParse(x, out var left) && Version.TryParse(y, out var right)
                ? Comparer<Version>.Default.Compare(left, right)
                : Comparer<string>.Default.Compare(x, y);
    }

    private void EvaluateFeatures(
        XDocument xml,
        Dictionary<string, Dictionary<string, List<ProfileEvaluation>>> profile,
        Dictionary<
            string,
            (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
        > apiSets
    )
    {
        // A map of -EITHER- API set names -OR- profile names to native names to include from other profiles.
        // - If the API set name is used, this allows the "depends" attribute (read on) to resolve dependencies of a
        // feature.
        // - If the profile name is used, this allows the "pending inheritance" logic described below to work (and also
        // allows resolution of implicit version dependencies where the "depends" attribute is not used e.g. v1.1
        // depends on v1.0)
        //
        // Note that the "pending inheritance" concept is an extrapolation of the current Vulkan XML schema, the XML
        // schema hasn't formally defined how one profile includes another profile as strongly as OpenGL has.
        // Issue: https://github.com/KhronosGroup/Vulkan-Docs/issues/2326
        //
        // Essentially, the problem is Vulkan 1.0 through 1.2 now have api="vulkan,vulkansc", with a later
        // <feature api="vulkansc"> that <remove>s features from the vulkan profiles. Today we can assume that all
        // <feature>s tagged with api="vulkan,vulkansc" are inherited into the following <feature api="vulkansc">,
        // however this doesn't work should there be a SC profile of Vulkan 1.3. Note that we don't actually care about
        // this, as it's impossible for C# to be used in a safety critical context anyway, but this is nonetheless
        // something we have to account for in a generic Khronos XML parser.
        //
        // Currently this sticks with the current assumptions, though work is underway with Khronos to better define how
        // this should work.
        //
        // Jon Leech's preferred approach to resolving this (as of writing 17/03/2024) is to add a "depends" attribute
        // as they believe that the "number" attribute is an unintentional implementation detail leaking out that spec
        // editors typically just filled in to be the version number out of ease (it was actually just a sorting number
        // to define the order in which the features are applied), which will allow us to resolve it to actual
        // inheritance (as per the set in this dictionary) immediately instead of needing the pending step. We
        // handle both for posterity.
        //
        // Aside from this, we can resolve actual inheritance quite easily given that we can assume that 1.1 includes
        // 1.0 etc, removals notwithstanding (which we'll of course handle)
        var inheritance = new Dictionary<string, HashSet<string>>();

        // Another oddity with "pending inheritance" is removals - we need to keep track of what is removed where an API
        // is a secondary API so that we can remember to populate the EndVersion tag.
        var pendingRemovals = new Dictionary<string, HashSet<string>>();

        // Get all profile elements.
        // TODO topological sort based on "depends"?
        var profileElements =
            xml.Element("registry")
                ?.Elements("feature")
                .OrderBy(x =>
                    x.Attribute("api")
                        ?.Value.Split(
                            _listSeparators,
                            StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                        )[0]
                )
                .ThenBy(x => x.Attribute("number")?.Value, VersionComparer.Instance)
                .ToArray() ?? [];

        // Record the variations declared within those elements (OpenGL only atm)
        var profileVariations = new Dictionary<string, HashSet<string>>();

        // Whether we use explicit dependencies (Vulkan only atm)
        var explicitDependencies = profileElements.Attributes("depends").Any();

        // Get all variations of the profiles.
        foreach (var profileElement in profileElements)
        {
            // Get the API name.
            if (profileElement.Attribute("api") is not { Value: { Length: > 0 } name })
            {
                continue;
            }

            // glcore is a variation of gl
            foreach (
                var variant in name.Split(
                    _listSeparators,
                    StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                )
            )
            {
                profileVariations[variant] =
                [
                    variant,
                    .. profileElement
                        .Elements()
                        .Attributes("profile")
                        .SelectMany(x =>
                            x.Value.Split(
                                _listSeparators,
                                StringSplitOptions.RemoveEmptyEntries
                                    | StringSplitOptions.TrimEntries
                            )
                        ) // <-- future proofing
                        .Where(x => x != "compatibility") // <-- assuming default "gl" is "glcompatibility"
                        .Select(x => $"{variant}{x}"),
                    .. profileVariations.TryGetValue(variant, out var v) ? v : [],
                ];
            }
        }

        // Now we've done that, we reiterate such that we populate the profile dictionary for all variations, filtering
        // APIs as necessary.
        foreach (var profileElement in profileElements)
        {
            // Get the API name.
            if (
                profileElement.Attribute("api")?.Value is not { Length: > 0 } name
                || profileElement.Attribute("name")?.Value is not { Length: > 0 } apiSet
            )
            {
                continue;
            }

            // See the "pending inheritance" concept in the Vulkan XML schema described above.
            var allApis = name.Split(_listSeparators);

            // Get the version number.
            var number = profileElement.Attribute("number")?.Value is { } ver
                ? Version.Parse(ver)
                : null;

            // Get the depends attribute. Note that if this is present, this should have already been identified and
            // explicitDependencies set to true.
            var depends =
                profileElement
                    .Attribute("depends")
                    ?.Value.Split(
                        _listSeparators,
                        StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries
                    ) ?? [];

            // Evaluate all of the elements.
            for (var i = 0; i < allApis.Length; i++)
            {
                foreach (var variant in profileVariations[allApis[i]])
                {
                    EvaluateFeature(
                        variant,
                        apiSet,
                        allApis[i],
                        depends,
                        number,
                        i > 0,
                        profileElement.Elements(),
                        explicitDependencies,
                        inheritance,
                        profile,
                        pendingRemovals,
                        apiSets
                    );
                }
            }
        }

        // Remove temporary entries in the apiSets dictionary used for secondary API resolution.
        // This should never do anything!
        if (explicitDependencies)
        {
            return;
        }

        // inheritance.Keys are profile/variant names unless we're using explicit dependencies, in which case they're
        // feature names.
        foreach (var profileName in inheritance.Keys)
        {
            if (apiSets.TryGetValue(profileName, out var unresolved))
            {
                logger?.LogWarning(
                    "The following features for secondary API \"{}\" were never resolved to a feature wherein "
                        + "\"{}\" is a primary API: {}",
                    profileName,
                    profileName,
                    string.Join(
                        ", ",
                        unresolved.Dependencies.TryGetValue(profileName, out var v) ? v : []
                    )
                );
                apiSets.Remove(profileName);
            }
        }
    }

    private void EvaluateFeature(
        string variant,
        string apiSet,
        string name,
        string[] depends,
        Version? number,
        bool isSecondary,
        IEnumerable<XElement> actions,
        bool explicitDependencies,
        Dictionary<string, HashSet<string>> inheritance,
        Dictionary<string, Dictionary<string, List<ProfileEvaluation>>> profile,
        Dictionary<string, HashSet<string>> pendingRemovals,
        Dictionary<
            string,
            (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
        > apiSets
    )
    {
        // If explicit dependencies are used, the whole concept of implicit dependencies becomes meaningless and
        // potentially damaging to our understanding of the schema if we try to use both in tandem.
        if (isSecondary && explicitDependencies)
        {
            return;
        }

        // Refuse to evaluate disabled variants.
        if (variant == "disabled")
        {
            return;
        }

        // Create a HashSet to store all the symbols in this feature.
        // If we're not using explicit dependencies, then we track the profile-wide symbol list. We assume that the
        // "number" order is being respected.
        var symbols =
            explicitDependencies ? inheritance[apiSet] = []
            : inheritance.TryGetValue(variant, out var syms) ? syms
            : inheritance[variant] = [];

        // If we're using implicit dependencies in the form of secondary APIs, the symbol changes we explicitly need to
        // inherit are contained in the pendingChanges dictionary for this variant.
        var removedSymbols = pendingRemovals.TryGetValue(variant, out var cs)
            ? cs
            : pendingRemovals[variant] = [];
        if (!isSecondary)
        {
            // If we're the primary API we should reset our pending changes for the next iteration.
            pendingRemovals[variant] = [];
        }

        // If we're using explicit dependencies, we need to build up our symbol list (which is unique to this
        // feature), inheriting everything from the dependent features.
        foreach (var dependency in depends)
        {
            if (!inheritance.TryGetValue(dependency, out var toInherit))
            {
                // TODO a topological sort would solve this
                throw new InvalidOperationException(
                    $"Feature \"{apiSet}\" references another feature \"{dependency}\" that is "
                        + $"either missing or declared after \"{apiSet}\". Note that SilkTouch currently does not "
                        + $"topological sort based on the \"depends\" attribute in the latter case."
                );
            }

            foreach (var s in toInherit)
            {
                symbols.Add(s);
            }
        }

        // Process all of the additions/removals
        foreach (var action in actions)
        {
            // If the profile attribute is present, and this is the default variant or is otherwise not the
            // specific variant this action applies to, skip.
            if (
                action.Attribute("profile")?.Value is { } v
                && ((variant == name && v != "compatibility") || v != variant[name.Length..])
            )
            {
                continue;
            }

            foreach (var applicableTo in action.Elements())
            {
                if (applicableTo.Attribute("name")?.Value is not { } nativeName)
                {
                    continue;
                }

                switch (action.Name.LocalName)
                {
                    // Adding a new symbol to the profile. We are assuming that these are not duplicated unless
                    // they are removed beforehand, in which case they'll need a new evaluation anyway.
                    case "require":
                    {
                        symbols.Add(nativeName);
                        break;
                    }

                    // Removing the symbol from the profile. We are assuming that the API was added before it
                    // was removed.
                    case "remove":
                    {
                        removedSymbols.Add(nativeName);
                        symbols.Remove(nativeName);
                        break;
                    }
                }
            }
        }

        // Mark the existing symbols as being present in this API set as well.
        if (isSecondary) // we don't have the canonical API set yet
        {
            DeclareSet(apiSets, variant, apiSet, variant, false, depends);
            return;
        }

        DeclareSet(apiSets, apiSet, apiSet, variant, false, depends);

        // ReSharper disable once ForeachCanBePartlyConvertedToQueryUsingAnotherGetEnumerator
        foreach (
            var (present, symbol) in symbols
                .Select(x => (true, x))
                .Concat(removedSymbols.Select(x => (false, x)))
        )
        {
            if (!profile.TryGetValue(symbol, out var profileNamesToEvals))
            {
                profileNamesToEvals = profile[symbol] = [];
            }

            if (!profileNamesToEvals.TryGetValue(variant, out var evals))
            {
                evals = profileNamesToEvals[variant] = [];
            }

            if (present)
            {
                // Do we have an open evaluation for this symbol already?
                if (
                    evals.FindLastIndex(x => x.EndVersion is null && !x.RequireAll)
                    is >= 0
                        and var idx
                )
                {
                    // Append to the existing evaluation.
                    evals[idx].ApiSets.Add(apiSet);
                }
                else
                {
                    // Create a new evaluation if not.
                    evals.Add(new ProfileEvaluation(number, null, [apiSet]));
                }
            }
            else if (
                evals.FindLastIndex(x => x.EndVersion is null && !x.RequireAll) is >= 0 and var idx
            )
            {
                // The symbol has been removed, mark it with the end version.
                evals[idx] = evals[idx] with
                {
                    EndVersion = number,
                };
            }
        }
    }

    private static void DeclareSet(
        Dictionary<
            string,
            (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
        > apiSets,
        string declaration,
        string apiSet,
        string variant,
        bool isExtension,
        string[] depends
    )
    {
        var otherDeps =
            apiSet == declaration
            && !isExtension
            && apiSets.TryGetValue(variant, out var pendingDep)
            && pendingDep.Dependencies.TryGetValue(variant, out var pend)
                ? pend
                : [];
        if (!apiSets.TryGetValue(declaration, out var unresolved))
        {
            unresolved = apiSets[declaration] = (isExtension, []);
        }

        if (!unresolved.Dependencies.TryGetValue(variant, out var deps))
        {
            deps = unresolved.Dependencies[variant] = [];
        }

        foreach (var dep in depends.Concat(otherDeps))
        {
            deps.Add(dep);
        }

        if (apiSet != declaration)
        {
            deps.Add(apiSet);
        }
    }

    // Read the SupportedApiProfileAttribute.ImpliedSets docs, Vulkan is silly here.
    // Method for parsing strings like:
    // ((VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)+VK_KHR_depth_stencil_resolve),VK_VERSION_1_2
    // and enumerating the cartesian product of the various dependency "options".
    // i.e.
    // (VK_VERSION_1_2,VK_EXT_my_cool_ext)+(VK_NV_my_vendor_ext,VK_KHR_my_other_ext)
    // returns (not necessarily in this order):
    // VK_VERSION_1_2+VK_NV_my_vendor_ext
    // VK_VERSION_1_2+VK_KHR_my_other_ext
    // VK_EXT_my_cool_ext+VK_NV_my_vendor_ext
    // VK_EXT_my_cool_ext+VK_KHR_my_other_ext
    // Note that the RequireAll functionality is so if we have a simple string like "VK_VERSION_1_2+VK_EXT_my_cool_ext"
    // instead of enumerating just one string, we can split it up at the + into:
    // VK_VERSION_1_2
    // VK_EXT_my_cool_ext
    // And, if this is for the ApiSets attribute value (rather than ImpliedSets, which codifies in its documentation the
    // rules around dependency paths), we can set the RequireAll attribute value to true.
    internal static (bool RequireAll, IEnumerable<string> Options) ParseDependencyOptions(
        ReadOnlySpan<char> dependencyString,
        string? topLevelAddReq = null,
        bool allowRequireAll = false,
        string? implicationContext = null
    )
    {
        var bracketDepth = 0;
        var firstBracketIdx = -1;
        var nextBaseIdx = 0;
        var adding = true;
        List<string>? options = null;
        static void Act(
            ref List<string>? options,
            ReadOnlySpan<char> dependencyString,
            int nextBaseIdx,
            int i,
            bool adding,
            ref string? topLevelAddReq
        )
        {
            if (nextBaseIdx >= i)
            {
                return;
            }

            // Is this is an additional requirement?
            if (adding)
            {
                topLevelAddReq = topLevelAddReq is null or { Length: 0 }
                    ? dependencyString[nextBaseIdx..i].ToString()
                    : $"{topLevelAddReq}+{dependencyString[nextBaseIdx..i]}";
            }
            else
            {
                (options ??= []).Add(dependencyString[nextBaseIdx..i].ToString());
            }
        }
        for (var i = 0; i < dependencyString.Length; i++)
        {
            switch (dependencyString[i])
            {
                // Do we have a parenthesised dependency string we need to recurse into?
                case '(' when bracketDepth++ == 0:
                {
                    firstBracketIdx = i;
                    break;
                }
                case ')' when --bracketDepth == 0:
                {
                    // Recurse into the parentheses to handle the inner options.
                    var innerOptions = ParseDependencyOptions(
                        dependencyString[(firstBracketIdx + 1)..i]
                    );

                    // Produce the cartesian product of our existing options.
                    if (options is null or { Count: 0 })
                    {
                        options = innerOptions.Options as List<string> ?? [.. innerOptions.Options];
                    }
                    else
                    {
                        var countBefore = options.Count;
                        foreach (var innerOption in innerOptions.Options)
                        {
                            for (var k = 0; k < countBefore; k++)
                            {
                                options.Add($"{options[k]}+{innerOption}");
                            }
                        }

                        options.RemoveRange(0, countBefore);
                    }

                    firstBracketIdx = -1;
                    nextBaseIdx = i + 1;
                    break;
                }
                case ',' when firstBracketIdx == -1:
                {
                    Act(
                        ref options,
                        dependencyString,
                        nextBaseIdx,
                        i,
                        adding = false,
                        ref topLevelAddReq
                    );
                    nextBaseIdx = i + 1;
                    break;
                }
                case '+' when firstBracketIdx == -1:
                {
                    Act(
                        ref options,
                        dependencyString,
                        nextBaseIdx,
                        i,
                        adding = true,
                        ref topLevelAddReq
                    );
                    nextBaseIdx = i + 1;
                    break;
                }
            }
        }

        Act(
            ref options,
            dependencyString,
            nextBaseIdx,
            dependencyString.Length,
            adding,
            ref topLevelAddReq
        );

        if (options is null or { Count: 0 })
        {
            if (topLevelAddReq is null)
            {
                return (allowRequireAll, []);
            }
            options = [topLevelAddReq];
        }
        else if (topLevelAddReq is not null)
        {
            for (var i = 0; i < options.Count; i++)
            {
                options[i] = $"{topLevelAddReq}+{options[i]}";
            }
        }

        if (allowRequireAll && options is { Count: 1 })
        {
            return (
                true,
                options[0]
                    .Split(
                        '+',
                        StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                    )
            );
        }

        if (implicationContext is not null && options.All(x => !x.Contains('+')))
        {
            // See the ImpliedSets attribute value documentation. ["VK_EXT_one", "VK_EXT_two"] for
            // "VK_EXT_one,VK_EXT_two" will be interpreted to mean "both VK_EXT_one and VK_EXT_two are implied" instead
            // of either/or, so we declare a redundant implication to make sure this isn't the case.
            // You might think that this would just work the same as for the ApiSets attribute, as indeed I did
            // originally, but after thinking it through we don't get a top-level pre-populated "topLevelAddReq" with
            // the extension name in the implied sets case, which means that "VK_EXT_one,VK_EXT_two" isn't automatically
            // prefilled to be ["VK_EXT_dependent+VK_EXT_one", "VK_EXT_dependent+VK_EXT_two"]. Because at this point we
            // know RequireAll will be returned as false, and we know the implications won't be interpreted as options
            // (i.e. as "one of" instead of "all"), we need to append the context to make sure this is indeed the case.
            for (var i = 0; i < options.Count; i++)
            {
                options[i] = $"{implicationContext}+{options[i]}";
            }
        }

        return (false, options);
    }

    private void EvaluateExtensions(
        XDocument xml,
        Dictionary<string, Dictionary<string, List<ProfileEvaluation>>> profile,
        Dictionary<
            string,
            (bool IsExtension, Dictionary<string, HashSet<string>> Dependencies)
        > apiSets
    )
    {
        foreach (
            var ext in xml.Element("registry")?.Element("extensions")?.Elements("extension") ?? []
        )
        {
            var name =
                ext.Attribute("name")?.Value
                ?? throw new InvalidOperationException("Extension has no name.");

            // Note that we assume that if an extension is reported to be supported, then at least one of its dependency
            // options is supported. The reason why we can use allowRequireAll is because this is codified in the
            // SupportedApiProfileAttribute documentation - if any one of the reported implications has a +, then you
            // can make only AT LEAST ONE implication. Otherwise, you can imply that all implications are implied.
            var (_, impliedSets) = ext.Attribute("depends")?.Value is { } imp
                ? ParseDependencyOptions(imp, allowRequireAll: true, implicationContext: name)
                : (false, null);

            var supportedApis =
                ext.Attribute("supported")
                    ?.Value.Split(
                        _listSeparators,
                        StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                    ) ?? [];

            foreach (var supportedApi in supportedApis)
            {
                if (supportedApi == "disabled")
                {
                    continue;
                }

                DeclareSet(
                    apiSets,
                    name,
                    name,
                    supportedApi,
                    true,
                    (impliedSets = impliedSets?.ToArray()) as string[] ?? []
                );
            }

            // We're assuming that an extension can't remove stuff because that'd be stupid.
            foreach (var req in ext.Elements("require"))
            {
                var (requireAll, additionalDeps) = req.Attribute("depends")?.Value
                    is { Length: > 0 } add
                    ? ParseDependencyOptions(add, name, true)
                    : (false, null);
                foreach (var api in supportedApis)
                {
                    if (api == "disabled")
                    {
                        continue;
                    }

                    foreach (var symbol in req.Elements().Attributes("name"))
                    {
                        if (!profile.TryGetValue(symbol.Value, out var profileNamesToEvals))
                        {
                            profileNamesToEvals = profile[symbol.Value] = [];
                        }

                        if (!profileNamesToEvals.TryGetValue(api, out var evals))
                        {
                            evals = profileNamesToEvals[api] = [];
                        }

                        // If this is a basic extension with no other dependencies or implications, then let's just
                        // append the extension name to the existing API set list given that there's no side effects.
                        var handled = false;
                        if (impliedSets is null && additionalDeps is null)
                        {
                            foreach (var extantEval in evals)
                            {
                                if (
                                    extantEval.RequireAll
                                    || extantEval.ImpliedSets is { Count: > 0 }
                                )
                                {
                                    continue;
                                }

                                extantEval.ApiSets.Add(name);
                                handled = true;
                                break;
                            }
                        }

                        // Add a new evaluation.
                        if (!handled)
                        {
                            evals.Add(
                                new ProfileEvaluation(
                                    null,
                                    null,
                                    // ReSharper disable once PossibleMultipleEnumeration
                                    additionalDeps?.ToHashSet() ?? [name],
                                    // ReSharper disable once PossibleMultipleEnumeration
                                    impliedSets?.ToHashSet(),
                                    requireAll
                                )
                            );
                        }
                    }
                }
            }
        }
    }

    private bool _outputVendorInformationWarning = false;

    /// <inheritdoc />
    public void Trim(NameTrimmerContext context)
    {
        if (context.JobKey is null)
        {
            return;
        }

        if (!Jobs.TryGetValue(context.JobKey, out var job))
        {
            throw new InvalidOperationException(
                "BeforeJobAsync has not run yet! MixKhronosData must come before PrettifyNames in the mod list."
            );
        }

        if (job.Vendors?.Count is 0 or null && !_outputVendorInformationWarning)
        {
            _outputVendorInformationWarning = true;
            logger.LogWarning(
                "No vendor information present, assuming no XML was provided? Extension trimming will be skipped."
            );
        }

        // NameTrimmer trims member names by looking for a common prefix and removing it
        // This sometimes trims too much and leads to only the vendor suffix remaining
        // This is bad because the next block of code removes the vendor suffix, leaving only an empty string or underscore
        // This means we have to rewind back to the previous name (minus the prefix, such as GL_)
        var rewind = false;
        if (context.Container is not null && job.Groups.ContainsKey(context.Container))
        {
            foreach (var (_, (current, previous)) in context.Names)
            {
                var prev = previous?.FirstOrDefault();
                if (prev is not null && (job.Vendors?.Contains(current.Trim('_')) ?? false)
                )
                {
                    rewind = true;

                    break;
                }
            }
        }

        if (rewind)
        {
            foreach (var (original, (_, previous)) in context.Names)
            {
                var prev = previous?.FirstOrDefault() ?? original;
                var prevList = previous ?? [];
                var next = prev[(prev.IndexOf('_') + 1)..];
                if (next == prev)
                {
                    prevList.Remove(prev);
                }
                else if (!prevList.Contains(prev))
                {
                    prevList.Add(prev);
                }

                context.Names[original] = new CandidateNames(prev[(prev.IndexOf('_') + 1)..], prevList);
            }
        }

        // OpenGL has a problem where an enum starts out as ARB but never gets promoted, and then contains other vendor
        // enums or even core enums. This removes the vendor suffix where it is not necessary e.g. BufferUsageARB
        // becomes BufferUsage.
        if (context.Container is null && job.Vendors is not null)
        {
            foreach (var (original, (current, previous)) in context.Names)
            {
                if (job.Groups.TryGetValue(current, out var groupInfo))
                {
                    var vendorSuffix =
                        groupInfo.ExclusiveVendor ?? job.Vendors.FirstOrDefault(current.EndsWith);
                    vendorSuffix = vendorSuffix?[(vendorSuffix.LastIndexOf('_') + 1)..];
                    var notSafeToTrim =
                        job.Groups.Count(x =>
                            x.Key.StartsWith(current[..^(vendorSuffix?.Length ?? 0)])
                        ) > 1;
                    if (
                        vendorSuffix is null
                        || !job.Vendors.Contains(vendorSuffix)
                        || !current.EndsWith(vendorSuffix)
                        || !groupInfo.Enums.All(x => x.Identifier.ToString().EndsWith(vendorSuffix))
                    )
                    {
                        vendorSuffix = null;
                    }

                    job.Groups[current] = groupInfo = groupInfo with
                    {
                        ExclusiveVendor = vendorSuffix,
                    };

                    if (notSafeToTrim)
                    {
                        continue;
                    }

                    // If the vendor suffix is not equal to our exclusive vendor, then it must not be exclusive
                    // therefore we should remove the suffix.
                    foreach (var vendor in job.Vendors)
                    {
                        if (current.EndsWith(vendor) && groupInfo.ExclusiveVendor != vendor)
                        {
                            var sec = previous ?? [];
                            sec.Add(current);
                            context.Names[original] = new CandidateNames(current[..^vendor.Length], sec);
                            break;
                        }
                    }
                }
            }
        }

        // Trim the extension vendor names
        foreach (var (original, (current, previous)) in context.Names)
        {
            // GLEnum is obviously trimmed, and we don't really want to do that.
            if (context.Container is null)
            {
                var changed = false;
                foreach (var name in (IEnumerable<string>)[current, .. previous ?? []])
                {
                    if (
                        job.Groups.TryGetValue(name, out var group)
                        && name == $"{group.Namespace}Enum"
                    )
                    {
                        context.Names[original] = new CandidateNames(name, null);
                        changed = true;
                        break;
                    }
                }

                if (changed)
                {
                    continue;
                }
            }

            var newCurrent = current;
            List<string>? newPrev = null;
            string? identifiedVendor = null;
            var trimVendor = false;
            foreach (var vendor in job.Vendors ?? [])
            {
                if (!current.EndsWith(vendor))
                {
                    continue;
                }

                newCurrent = current[..^vendor.Length];
                var newOriginal = original[..^vendor.Length];
                // Sometimes we should keep the vendor prefix so we prefer the promoted functions.
                // ----------vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv--------------------------------------
                trimVendor =
                    !context.Names.ContainsKey(newOriginal)
                    && context.Container is not null
                    && job.Groups.TryGetValue(context.Container, out var group)
                    && group.ExclusiveVendor == vendor;
                if (trimVendor)
                {
                    newPrev ??= previous ?? [];
                    newPrev.Add(current);
                    context.Names[original] = new CandidateNames(newCurrent, newPrev);
                }

                identifiedVendor = vendor;
                break;
            }

            // If we have an additional non-vendor suffix (e.g. al*Direct) then let's trim it before we try to do the
            // data type trimming
            string? identifiedSuffix = null;
            foreach (var suffix in job.Configuration.IgnoreNonVendorSuffixes ?? [])
            {
                if (newCurrent.EndsWith(suffix, StringComparison.OrdinalIgnoreCase))
                {
                    identifiedSuffix = suffix;
                    newCurrent = newCurrent[..^suffix.Length];
                    break;
                }
            }

            if (
                !job.Configuration.UseDataTypeTrimmings // don't trim data types
                || context.Container is null // don't trim type names
                || newCurrent.Count(x => x == '_') > 1 // is probably an enum
                || EndingsToTrim().Match(newCurrent) is not { Success: true } match // we don't have a data type suffix
                || EndingsNotToTrim().IsMatch(newCurrent) // we need to keep it
            )
            {
                continue;
            }

            newPrev ??= previous ?? [];
            var newPrim = newCurrent.Remove(match.Index);
            newPrim += identifiedSuffix;
            if (identifiedVendor is not null && trimVendor)
            {
                // If the only difference between this function and other functions that could conflict is the vendor,
                // it would be extremely confusing if the difference between e.g. a NV function and a non-NV function
                // was one had data type suffixes and the other didn't. Therefore, let's add the new name but with the
                // vendor added as the first secondary (e.g. for glVertex2bOES we first try Vertex2OES). If that doesn't
                // work, we still have the original one (modulo GL prefix) that we added to the secondary list when
                // originally trimming the vendor.
                newPrev.Add(newPrim + identifiedVendor);
            }
            else
            {
                // If trimVendor is false, add the vendor back. We're not trimming vendors so the only other secondary
                // we have is the original current name i.e. primary = glVertex2OES, secondary = glVertex2bOES, which
                // WOULDN'T be in the secondary list already per the if trimVendor above. If we're hitting this else
                // because we haven't identified a vendor, then we're just appending null to this string which does
                // nothing and is effectively equivalent to us having primary = glVertex2, secondary = glVertex2b
                newPrim += identifiedVendor;
                newPrev.Add(current);
            }

            context.Names[original] = new CandidateNames(newPrim, newPrev);
        }
    }

    /// <inheritdoc />
    public void Transform(
        MethodDeclarationSyntax current,
        ITransformationContext ctx,
        Action<MethodDeclarationSyntax> next
    )
    {
        if (ctx.JobKey is null)
        {
            next(current);
            return;
        }

        current.AttributeLists.GetNativeFunctionInfo(out _, out var entryPoint, out _);
        entryPoint ??= current.Identifier.ToString();
        foreach (var meth in TransformToConstants(current, ctx, entryPoint))
        {
            // TODO more transformations
            next(meth);
        }
    }

    private IEnumerable<MethodDeclarationSyntax> TransformToConstants(
        MethodDeclarationSyntax current,
        ITransformationContext ctx,
        string entryPoint
    )
    {
        Debug.Assert(ctx.JobKey is not null);

        // This will contain the changed parameters. Note that the changes from the previous passes (see below) are kept
        // in this list so that we don't create differences between fully grouped pointer overloads vs partially grouped
        // pointer overloads. In addition, we want to keep things like the Constant DSL type even if we're overloading
        // pointer types.
        var @params = new List<ParameterSyntax>(current.ParameterList.Parameters);

        // We may generate up to three transformations if there are any non-trivial types (e.g. group pointers).
        // These are: native type, ungrouped enum, and grouped enum. Each transformation transforms the trivial types.
        var anyNonTrivialParameters = false;
        for (var pass = 0; pass < 3; pass++)
        {
            var ret = current.ReturnType;
            var anyChange = false;

            // Is the return type transformable?
            var newRet = GetTypeTransformation(
                entryPoint,
                ":return",
                Jobs[ctx.JobKey],
                ret,
                pass,
                ref anyNonTrivialParameters
            );
            if (newRet is not null)
            {
                ret = newRet;
                anyChange = true;
            }

            // Are the parameters transformable?
            for (var i = 0; i < @params.Count; i++)
            {
                var param = current.ParameterList.Parameters[i];
                if (
                    param.Type is null
                    || GetTypeTransformation(
                        entryPoint,
                        param.Identifier.ToString(),
                        Jobs[ctx.JobKey],
                        param.Type,
                        pass,
                        ref anyNonTrivialParameters
                    )
                        is not { } newType
                )
                {
                    continue;
                }

                if (
                    logger.IsEnabled(LogLevel.Debug)
                    && !param
                        .Type.DescendantTokens()
                        .Any(x => x.Kind() is SyntaxKind.IntKeyword or SyntaxKind.UIntKeyword)
                )
                {
                    logger.LogDebug(
                        "Transforming {}'s non-(u)int parameter {} from {} to {} (pass = {})",
                        current.Identifier,
                        param.Identifier,
                        param.Type,
                        newType,
                        pass
                    );
                }
                @params[i] = param.WithType(newType);
                anyChange = true;
            }

            if (!anyChange)
            {
                // We can't transform ANYTHING! pass it through the pipeline as is.
                if (pass == 0)
                {
                    yield return current;
                }

                // !anyNonTrivialParameters = No pointers to transform in the next pass(es).
                // pass > 0 = We're trying to transform pointers, but we didn't transform anything. Usually this happens
                // on pass == 2 if there are no otherGroups.
                if (!anyNonTrivialParameters || pass > 0)
                {
                    yield break;
                }

                continue;
            }

            var retMeth = current
                .WithReturnType(ret)
                .WithParameterList(ParameterList(SeparatedList(@params)));
            yield return retMeth
                .WithBody(
                    current.Body?.CastFunctionCalls(
                        ctx.Original!,
                        newRet,
                        retMeth.ParameterList.Parameters
                    ) as BlockSyntax
                )
                .WithExpressionBody(
                    current.ExpressionBody?.CastFunctionCalls(
                        ctx.Original!,
                        newRet,
                        retMeth.ParameterList.Parameters
                    ) as ArrowExpressionClauseSyntax
                );
        }

        static TypeSyntax PointerToGroupPointer(TypeSyntax original, string group) =>
            original switch
            {
                PointerTypeSyntax ptr => ptr.WithElementType(
                    PointerToGroupPointer(ptr.ElementType, group)
                ),
                PredefinedTypeSyntax or IdentifierNameSyntax => IdentifierName(group),
                _ => throw new ArgumentOutOfRangeException(nameof(original)),
            };

        TypeSyntax? GetTypeTransformation(
            string symbolName,
            string paramName,
            JobData job,
            TypeSyntax type,
            int pass,
            ref bool anyNonTrivialParams
        )
        {
            if (
                !job.Annotations.TryGetValue((symbolName, paramName), out var annotes)
                || annotes.Group is not { Length: > 0 } group
            )
            {
                return null;
            }

            var otherGroup =
                type.ToString().Contains("int") && job.Groups[group].Namespace is { Length: > 0 } ns
                    ? $"{ns}Enum"
                    : null;
            if (otherGroup == group)
            {
                // Nevermind then.
                otherGroup = null;
            }

            if (type is PointerTypeSyntax)
            {
                if (paramName == ":return" && pass > 0 && !anyNonTrivialParams)
                {
                    logger.LogWarning(
                        "Cannot transform return type for \"{}\" as it is a pointer, and there are no "
                            + "other \"group pointer\" transformations to be made meaning that the return type would "
                            + "be the only transformation, which is illegal in C#. No Khronos-specific transformations "
                            + "shall be applied to the return type for this function.",
                        symbolName
                    );
                    return null;
                }

                anyNonTrivialParams = paramName != ":return";
                return pass switch
                {
                    // Note: we flip so the more general group comes first. that way if we have parameters that are only
                    // general, you can use general groups throughout the whole function.
                    2 when otherGroup is not null => PointerToGroupPointer(type, group),
                    1 when otherGroup is not null => PointerToGroupPointer(type, otherGroup),
                    1 => PointerToGroupPointer(type, group),
                    _ => null,
                };
            }

            return pass == 0
                ? GenericName(
                    Identifier("Constant"),
                    TypeArgumentList(
                        SeparatedList(
                            otherGroup is not null
                                // ReSharper disable once RedundantCast <-- false positive
                                // Note: we apply the same flip as above here too. It makes no difference for the
                                // constant type, but is done for consistency.
                                ? (IEnumerable<TypeSyntax>)
                                    [type, IdentifierName(otherGroup), IdentifierName(group)]
                                : [type, IdentifierName(group)]
                        )
                    )
                )
                : null;
        }
    }

    /// <inheritdoc />
    public bool TryGetChildSymbolMetadata(
        string? jobKey,
        string nativeName,
        string childNativeName,
        [NotNullWhen(true)] out SymbolConstraints? metadata
    )
    {
        if (
            jobKey is not null
            && Jobs[jobKey]
                .Annotations.TryGetValue((nativeName, childNativeName), out var annotation)
            && annotation.Usage is not null
        )
        {
            metadata = annotation.Usage;
            return true;
        }

        metadata = null;
        return false;
    }

    /// <inheritdoc />
    public bool TryGetChildSymbolMetadata(
        string? jobKey,
        string nativeName,
        string childNativeName,
        [NotNullWhen(true)] out IEnumerable<SupportedApiProfileAttribute>? metadata
    ) => TryGetSymbolMetadata(jobKey, childNativeName, out metadata);

    /// <inheritdoc />
    public bool TryGetSymbolMetadata(
        string? jobKey,
        string nativeName,
        [NotNullWhen(true)] out IEnumerable<SupportedApiProfileAttribute>? metadata
    )
    {
        if (jobKey is null || !Jobs.TryGetValue(jobKey, out var job) || job.SupportedApiProfiles is null)
        {
            metadata = null;
            return false;
        }

        if (!job.SupportedApiProfiles.TryGetValue(nativeName, out var mdList))
        {
            metadata = null;
            return false;
        }

        metadata = mdList;
        return true;
    }

    /// <summary>
    /// This regex matches against known OpenGL function endings, picking them out from function names.
    /// It is comprised of two parts - the main matching set (here, the main capturing group), and a negative
    /// lookbehind workaround for difficult-to-match names. The primary set matches the actual function ending,
    /// while the lookbehind asserts that the ending match will not overreach into the end of a word.
    /// </summary>
    // NOTE: LET THIS BE A LESSON! Do NOT add x (fixed) here, these will frequently conflict with integer overloads.
    [GeneratedRegex("(?<!xe)([fdh]v?|u?[isb](64)?v?|v|i_v|fi|hi)$")]
    private static partial Regex EndingsToTrim();

    /// <summary>
    /// This regex acts like a whitelist for endings that could have been matched in some way by the main
    /// expression, but should be exempt from trimming altogether.
    /// </summary>
    [GeneratedRegex(
        "(sh|ib|[tdrey]s|(?<![A-Z])[eE]n[vd]|bled|Attrib|Access|Boolean|Coord|Depth|Feedbacks|Finish|Flag|"
            + "Groups|IDs|Indexed|Instanced|Pixels|Queries|Status|Tess|Through|Uniforms|Varyings|Weight|Width|Bias|Id|"
            + "Fixed|Pass|Address|Configs|Thread|Subpass|Deferred|Extended|Affix|Annex|Box|Aux|Ex|Index|Vertex|Path|"
            + "Arch|Arith|Afresh|Both|High|Math|Mesh|Sinh|Bench|Brush|Bunch|Crash|Flush|Depth|Latch|Morph|Pinch|"
            + "Pitch|Stretch|Smooth|Matrix|Radix|Sound|Rewind|Supported)$"
    )]
    private static partial Regex EndingsNotToTrim();

    /// <summary>
    /// This rewriter focuses on adding missing enums.
    /// <para/>
    /// Extracts enum constants that are defined as fields and moves them to their actual enum types.
    /// Begins renaming FlagBits enums to Flags.
    /// </summary>
    /// <remarks>
    /// This rewriter is split into two phases because NamespaceFromSyntaxNode breaks due to
    /// the FieldDeclarationSyntax being modified.
    /// </remarks>
    private class RewriterPhase1(JobData job, ILogger logger) : CSharpSyntaxRewriter
    {
        /// <summary>
        /// Tracks enum groups that already exist in the project, prior to the generation of missing enums.
        /// </summary>
        public HashSet<string> AlreadyPresentGroups { get; } = [];

        /// <summary>
        /// Tracks enums that exist in the project.
        /// Note that this includes any enum, including enums not present in <see cref="MixKhronosData.JobData.Groups"/>.
        /// </summary>
        public HashSet<string> AllKnownEnums { get; } = [];

        public IEnumerable<(string FilePath, SyntaxNode Node)> GetMissingEnums()
        {
            var results = new List<(string FilePath, SyntaxNode Node)>();

            // Generate initial syntax trees
            foreach (var (groupName, groupInfo) in job.Groups)
            {
                if (!AlreadyPresentGroups.Contains(groupName))
                {
                    var baseType = groupInfo.Type ?? groupName;
                    while (job.TypeMap.TryGetValue(baseType, out var ty))
                    {
                        baseType = ty;
                    }

                    if (baseType == groupName)
                    {
                        logger?.LogError(
                            "Enum \"{}\" has no base type. Please add TypeMap entry to the configuration. "
                                + "This enum group will be skipped.",
                            groupName
                        );
                        continue;
                    }

                    var ns = groupInfo
                        .Enums.Select(x => x.NamespaceFromSyntaxNode())
                        .Distinct()
                        .Select((x, i) => (x, i))
                        .LastOrDefault()
                        is
                        (var n, 0)
                        ? n
                        : null;

                    ns ??= job.Configuration.Namespace;
                    if (ns is null)
                    {
                        logger?.LogError(
                            "Enum \"{}\" has no namespace. Please add Namespace to the configuration. "
                                + "This enum group will be skipped.",
                            groupName
                        );
                        continue;
                    }

                    AllKnownEnums.Add(groupName);

                    var attributes = SingletonList(
                        AttributeList(
                            [Attribute(IdentifierName("Transformed"))]));

                    if (groupInfo.NativeName != null)
                    {
                        attributes = attributes.WithNativeName(groupInfo.NativeName);
                    }

                    results.Add((
                        $"Enums/{groupName}.gen.cs",
                        CompilationUnit()
                            .WithMembers(
                                SingletonList<MemberDeclarationSyntax>(
                                    FileScopedNamespaceDeclaration(
                                            ModUtils.NamespaceIntoIdentifierName(ns)
                                        )
                                        .WithMembers(
                                            SingletonList<MemberDeclarationSyntax>(
                                                EnumDeclaration(groupName)
                                                    .WithModifiers(
                                                        TokenList(Token(SyntaxKind.PublicKeyword))
                                                    )
                                                    .WithAttributeLists(attributes)
                                                    .WithBaseList(
                                                        BaseList(
                                                            SingletonSeparatedList<BaseTypeSyntax>(
                                                                SimpleBaseType(IdentifierName(baseType))
                                                            )
                                                        )
                                                    )
                                                    .WithMembers(
                                                        SeparatedList(
                                                            groupInfo.Enums.Select(x =>
                                                                EnumMemberDeclaration(x.Identifier.ToString())
                                                                    .WithAttributeLists(new SyntaxList<AttributeListSyntax>()
                                                                        .WithNativeName(x.Identifier.Text))
                                                                    .WithEqualsValue(
                                                                        x.Initializer?.WithValue(
                                                                            CheckedExpression(
                                                                                SyntaxKind.UncheckedExpression,
                                                                                CastExpression(
                                                                                    IdentifierName(
                                                                                        baseType
                                                                                    ),
                                                                                    x.Initializer.Value
                                                                                )
                                                                            )
                                                                        )
                                                                    )
                                                            )
                                                        )
                                                    )
                                            )
                                        )
                                )
                            )
                    ));
                }
            }

            return results;
        }

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            // Remove empty classes
            var ret = base.VisitClassDeclaration(node);
            return ret is ClassDeclarationSyntax { Members.Count: 0 } ? null : ret;
        }

        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            // Track which enums already exist
            var identifier = node.Identifier.ToString();
            identifier = identifier.Replace("FlagBits", "Flags");

            AllKnownEnums.Add(identifier);

            if (job.Groups.TryGetValue(identifier, out _)
                && !node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any())
            {
                AlreadyPresentGroups.Add(identifier);
            }

            return base.VisitEnumDeclaration(node.WithIdentifier(Identifier(identifier)));
        }

        public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            // Only match constant fields
            if (node.Declaration.Variables.Count != 1
                || !node.Modifiers.Any(SyntaxKind.ConstKeyword))
            {
                return base.VisitFieldDeclaration(node);
            }

            if (node.AttributeLists.TryParseNativeTypeName(out var info) && info.IsConst)
            {
                var name = info.Name.Replace("FlagBits", "Flags");
                if (info.IsDefine)
                {
                    // Remove defines that match an API set name
                    // Eg: #define GL_VERSION_1_0 1
                    if (job.ApiSets.ContainsKey(name))
                    {
                        return null;
                    }

                    // Remove constants that match an enum member name
                    // We save these constants so we can move them to the actual enum
                    if (job.EnumsToGroups.TryGetValue(name, out var groups))
                    {
                        foreach (var group in groups)
                        {
                            job.Groups[group].Enums.Add(node.Declaration.Variables[0]);
                        }

                        return null;
                    }
                }
                else
                {
                    // Remove constants that match an enum group name
                    // We save these constants so we can move them to the actual enum
                    if (job.Groups.TryGetValue(name, out var group))
                    {
                        job.Groups[group.Name].Enums.Add(node.Declaration.Variables[0]);

                        return null;
                    }
                }
            }

            return base.VisitFieldDeclaration(node);
        }
    }

    /// <summary>
    /// Finishes renaming FlagBits enums to Flags.
    /// Marks bitmask enums with the [Flags] attribute.
    /// Replaces uint/ulong with the actual enum type for FlagBits/Flags types.
    /// Removes deprecated aliases.
    /// </summary>
    private class RewriterPhase2(JobData job, RewriterPhase1 phase1) : CSharpSyntaxRewriter(true)
    {
        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node) => IdentifierName(node.Identifier.ToString().Replace("FlagBits", "Flags"));

        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            var identifier = node.Identifier.ToString();

            if (node.Members.Any(m => job.DeprecatedAliases.Contains(m.Identifier.ValueText)))
            {
                // Remove deprecated aliases
                node = node.WithMembers([
                    ..node.Members.Where(m => !job.DeprecatedAliases.Contains(m.Identifier.ValueText)),
                ]);
            }

            if (job.Groups.TryGetValue(identifier, out var group) && group.KnownBitmask)
            {
                // Add [Flags] attribute
                var flagsAttribute = AttributeList(
                    SingletonSeparatedList(
                        Attribute(IdentifierName("Flags"))));

                node = node.WithAttributeLists(node.AttributeLists.Add(flagsAttribute));
            }

            return base.VisitEnumDeclaration(node);
        }

        public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            if (node.Declaration.Variables.Any(v => job.DeprecatedAliases.Contains(v.Identifier.ValueText)))
            {
                // Remove deprecated aliases
                node = node.WithDeclaration(node.Declaration.WithVariables([
                    ..node.Declaration.Variables.Where(v => !job.DeprecatedAliases.Contains(v.Identifier.ValueText)),
                ]));

                if (node.Declaration.Variables.Count == 0)
                {
                    return null;
                }
            }

            if (TryGetManagedEnumType(node.AttributeLists, out var managedName))
            {
                node = node.WithDeclaration(node.Declaration.WithType(ParseTypeName(managedName)));
            }

            return base.VisitFieldDeclaration(node);
        }

        public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            if (job.DeprecatedAliases.Contains(node.Identifier.ValueText))
            {
                return null;
            }

            return base.VisitPropertyDeclaration(node);
        }

        public override SyntaxNode? VisitParameter(ParameterSyntax node)
        {
            if (TryGetManagedEnumType(node.AttributeLists, out var managedName))
            {
                node = node.WithType(ParseTypeName(managedName));
            }

            return base.VisitParameter(node);
        }

        /// <summary>
        /// Parses the attribute list and uses the [NativeTypeName] attribute to determine the correct enum type.
        /// </summary>
        /// <remarks>
        /// This method is intentionally implemented in a naive manner to keep things simple.
        /// </remarks>
        private bool TryGetManagedEnumType(SyntaxList<AttributeListSyntax> attributes, [NotNullWhen(true)] out string? managedName)
        {
            managedName = null;

            // ClangSharp does not know how to handle FlagBits and Flags types
            // Because of this ClangSharp outputs Flags types as uints or ulongs
            // We have to look at the NativeTypeName in order to determine the correct type
            if (!attributes.TryParseNativeTypeName(out var info))
            {
                return false;
            }

            var nativeName = info.Name.Replace("FlagBits", "Flags");
            if (!nativeName.Contains("Flags"))
            {
                return false;
            }

            if (!phase1.AllKnownEnums.Contains(nativeName))
            {
                return false;
            }

            managedName = nativeName + new string('*', info.IndirectionLevels);

            return true;
        }
    }

    /// <summary>
    /// This rewriter identifies and extracts vendor extension suffixes into [NameSuffix] attributes.
    /// </summary>
    /// <remarks>
    /// Yes, this is a 3rd rewriter.
    /// </remarks>
    private class RewriterPhase3(HashSet<string> vendors, HashSet<string> excludedIdentifiers, int vendorSuffixPriority) : CSharpSyntaxRewriter
    {
        private SyntaxList<AttributeListSyntax> ProcessAndGetNewAttributes(SyntaxList<AttributeListSyntax> attributeLists, SyntaxToken identifier)
        {
            var name = attributeLists.TryGetNativeName(out var nativeName) ? nativeName : identifier.Text;

            var handleSuffix = "_T";
            if (name.EndsWith(handleSuffix))
            {
                name = name[..^handleSuffix.Length];
                attributeLists = attributeLists
                    .AddNameSuffix(handleSuffix, -1)
                    .WithNativeName(name);
            }

            if (excludedIdentifiers.Contains(name))
            {
                return attributeLists;
            }

            foreach (var vendor in vendors)
            {
                if (name.EndsWith(vendor))
                {
                    attributeLists = attributeLists.AddNameSuffix(vendor, vendorSuffixPriority);

                    break;
                }
            }

            return attributeLists;
        }

        // ----- Types -----

        public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
        {
            node = (StructDeclarationSyntax)base.VisitStructDeclaration(node)!;
            return node.WithAttributeLists(ProcessAndGetNewAttributes(node.AttributeLists, node.Identifier));
        }

        public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            var variable = node.Declaration.Variables.First();
            return node.WithAttributeLists(ProcessAndGetNewAttributes(node.AttributeLists, variable.Identifier));
        }

        public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            node = (EnumDeclarationSyntax)base.VisitEnumDeclaration(node)!;
            return node.WithAttributeLists(ProcessAndGetNewAttributes(node.AttributeLists, node.Identifier));
        }

        public override SyntaxNode VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
            node.WithAttributeLists(ProcessAndGetNewAttributes(node.AttributeLists, node.Identifier));

        // ----- Members -----

        public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node) =>
            node.WithAttributeLists(ProcessAndGetNewAttributes(node.AttributeLists, node.Identifier));

        public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node) =>
            node.WithAttributeLists(ProcessAndGetNewAttributes(node.AttributeLists, node.Identifier));

        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node) =>
            node.WithAttributeLists(ProcessAndGetNewAttributes(node.AttributeLists, node.Identifier));
    }

    [SuppressMessage("ReSharper", "MoveLocalFunctionAfterJumpStatement")]
    internal void ReadGroups(XDocument doc, JobData data, HashSet<string> vendors)
    {
        // Designed to be compatible with OpenGL, EGL, WGL, GLX, and OpenCL.
        // This will work for Vulkan as well, but for Vulkan the enums are actually "typedef enum"s in the headers and
        // therefore the result of this function will go mostly ignored.
        var anyNamespaced =
            doc.Element("registry")?.Elements("enums").Attributes("namespace").Any() ?? false;
        var anyGLStyleGroups =
            doc.Element("registry")?.Elements("enums").Elements("enum").Attributes("group").Any()
            ?? false;
        var likelyOpenCL = false; // OpenCL specific
        var topLevelIntentionalExclusions = new HashSet<string>(); // OpenCL specific
        foreach (var block in doc.Element("registry")?.Elements("enums") ?? [])
        {
            // Is it a bitmask?
            var isBitmask = block.Attribute("type")?.Value == "bitmask";

            // OpenGL/EGL/WGL/GLX namespace
            var enumNamespace = block.Attribute("namespace")?.Value;
            var groupName =
                enumNamespace is not null && !enumNamespace.All(char.IsUpper)
                    ? enumNamespace
                    : null;
            var nativeName = groupName;

            // Create an ungrouped group as well i.e. GLEnum, WGLEnum, etc
            if (enumNamespace is not null)
            {
                groupName ??= $"{enumNamespace}Enum";
                nativeName ??= enumNamespace;
            }

            // OpenCL enum name
            if (!anyNamespaced)
            {
                groupName ??= block.Attribute("name")?.Value;
            }

            // Vulkan/OpenXR enum name
            nativeName ??= groupName;
            groupName = groupName?.Replace("FlagBits", "Flags");

            // Skip Vulkan API Constants since it is not an enum
            if (block.Attribute("type")?.Value == "constants")
            {
                continue;
            }

            // Special cases for OpenCL contributed by @Alexx999 for 2.X and ported to 3.0 from:
            // https://github.com/dotnet/Silk.NET/blob/d8919600/src/Core/Silk.NET.BuildTools/Converters/Readers/OpenCLReader.cs#L842-L845
            // Note that this has actually been split into two cases: top-level intentional exclusions and just a silent
            // skip over the block. We continue on in the top-level case to permanently prevent any group operations
            // from occurring on the top-level intentional exclusions because they're special numbers/constants.
            var topLevelIntentionalExclusion =
                groupName is not null && IsIntentionalExclusion(groupName);
            static bool IsIntentionalExclusion(string groupName) =>
                groupName.StartsWith("Constants") // these are constants
                || groupName is "MiscNumbers" or "SpecialNumbers";
            static bool IsUngroupable(string groupName) =>
                IsIntentionalExclusion(groupName)
                || groupName.StartsWith("enums") // these are unnamed
                || groupName is "cl_device_info"; // bug in cl.xml - see https://github.com/KhronosGroup/OpenCL-Docs/pull/779

            // ...continued from:
            // https://github.com/dotnet/Silk.NET/blob/d8919600/src/Core/Silk.NET.BuildTools/Converters/Readers/OpenCLReader.cs#L855-L870
            if (!anyNamespaced && groupName is not null && !topLevelIntentionalExclusion)
            {
                FixupGroupNameForOpenCL(ref groupName, ref likelyOpenCL, ref isBitmask);
            }

            // Mark the enums
            foreach (var @enum in block.Elements("enum"))
            {
                var enumName =
                    @enum.Attribute("name")?.Value
                    ?? throw new InvalidDataException("Expected \"name\" attribute on <enum>.");
                if (topLevelIntentionalExclusion)
                {
                    topLevelIntentionalExclusions.Add(enumName);
                    continue;
                }

                // Get the group hash set for this enum.
                if (!data.EnumsToGroups.TryGetValue(enumName, out var enumToGroups))
                {
                    data.EnumsToGroups[enumName] = enumToGroups = [];
                }

                // OpenGL-style groups
                var glGroups = @enum
                    .Attribute("group")
                    ?.Value.Split(
                        _listSeparators,
                        StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                    );

                // Get the vendor (if the enum name ends with a vendor that is).
                var thisVendor = VendorFromString(enumName, vendors);

                foreach (
                    var group in (groupName is null ? Enumerable.Empty<string>() : [groupName])
                        .Concat(glGroups ?? [])
                        .Concat(block.Attribute("group")?.Value is { Length: > 0 } g ? [g] : [])
                        .Distinct()
                )
                {
                    if (IsUngroupable(group))
                    {
                        continue;
                    }

                    // Update the group info.
                    data.Groups[group] = data.Groups.TryGetValue(group, out var groupInfo)
                        ? groupInfo with
                        {
                            KnownBitmask = isBitmask && groupInfo.KnownBitmask,
                            ExclusiveVendor =
                                thisVendor is not null && groupInfo.ExclusiveVendor == thisVendor
                                    ? thisVendor
                                    : null,
                            Namespace =
                                enumNamespace is not null && groupInfo.Namespace == enumNamespace
                                    ? enumNamespace
                                    : null,
                        }
                        : new EnumGroup(
                            group,
                            group,
                            anyGLStyleGroups ? "GLenum" : null,
                            [],
                            isBitmask,
                            thisVendor,
                            enumNamespace
                        );

                    // Mark this enum.
                    enumToGroups.Add(group);
                }
            }

            // Some enum groups don't have members, meaning that the code above won't catch them
            if (groupName != null && !data.Groups.ContainsKey(groupName))
            {
                data.Groups[groupName] = new EnumGroup(
                    groupName,
                    nativeName,
                    null,
                    [],
                    isBitmask,
                    VendorFromString(groupName, vendors),
                    enumNamespace
                );
            }
        }

        var allHandles = doc.Elements("registry")
            .Elements("types")
            .Elements("type")
            .Where(x => x.Attribute("category")?.Value is "handle")
            .SelectMany(x =>
                x.Elements("name")
                    .Select(y => y.Value)
                    .Concat(x.Attribute("name")?.Value is { Length: > 0 } alias ? [alias] : [])
            )
            .ToHashSet();

        // Read the annotations from the functions
        foreach (var func in doc.Elements("registry").Elements("commands").Elements("command"))
        {
            var funcName = func.Element("proto")?.Element("name")?.Value;
            if (funcName is null)
            {
                if (
                    func.Attribute("alias")?.Value is { Length: > 0 } aliasedFunc
                    && (funcName = func.Attribute("name")?.Value) is not null
                )
                {
                    // Handle the alias case
                    foreach (
                        var ((_, applicable), value) in data
                            .Annotations.Where(x => x.Key.ContainingSymbol == aliasedFunc)
                            .ToArray() // <-- Required to avoid modification while enumerating errors
                    )
                    {
                        data.Annotations[(funcName, applicable)] = value;
                    }

                    continue;
                }

                throw new InvalidDataException("command with no name");
            }

            void AddData(XElement? element, string applicableSymbol)
            {
                // Get the group attribute
                var grp = element?.Attribute("group")?.Value;
                var handle =
                    element?.Attribute("class")?.Value
                    ?? (
                        element?.Element("type")?.Value is { Length: > 0 } pty
                        && allHandles.Contains(pty)
                            ? pty
                            : null
                    );
                var lenStr =
                    element?.Attribute("len")?.Value
                    ?? (element?.Attribute("kind")?.Value is "String" ? "null-terminated" : null);
                var compSize = lenStr?.StartsWith("COMPSIZE(") ?? false;
                var len = compSize
                    ? lenStr!
                        [9..^1]
                        .Split(
                            ',',
                            StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                        )
                    : lenStr?.Split(
                        ',',
                        StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                    );

                // Get information from the type signature
                var indirection = element?.Value.AsSpan().GetIndirectionLevels() ?? 0;
                Span<bool> mutability = stackalloc bool[indirection + 1];
                var outerCount = 0;
                element?.Value.AsSpan().GetTypeDetails(mutability, out outerCount);
                if (
                    (grp is not null && data.Groups.ContainsKey(grp))
                    || handle is not null
                    || len is not null
                    || outerCount != 0
                )
                {
                    data.Annotations[(funcName, applicableSymbol)] = (
                        grp,
                        handle,
                        MetadataUtils.CreateBasicSymbolConstraints(
                            len,
                            mutability,
                            compSize,
                            element?.Attribute("optional")?.Value is "true",
                            outerCount
                        )
                    );
                }
            }

            // Add the return type annotations
            if (func.Element("proto") is { } proto)
            {
                AddData(proto, ":return");
            }

            // Get the parameter group attributes
            foreach (var (paramIdx, param) in func.Elements("param").Select((x, i) => (i, x)))
            {
                var paramName =
                    param.Element("name")?.Value
                    ?? throw new InvalidDataException("param with no name");

                // TODO ClangSharp currently erroneously renames "param" to "param<idx>"
                // TODO Once fixed upstream, remove this hack.
                // https://discord.com/channels/521092042781229087/587346162802229298/1437503858849878037
                if (paramName == "param")
                {
                    paramName = $"{paramName}{paramIdx}";
                }

                AddData(param, paramName);
            }
        }

        // The relative sanity of the other specs stops here.
        if (!likelyOpenCL)
        {
            return;
        }

        // Add empty enums that are defined in the C headers but have no members (yet).
        // This is also used as a type hinting stage.
        foreach (
            var @enum in doc.Elements("registry")
                .Elements("types")
                .Elements("type")
                .Where(e =>
                    e.Elements("type").SingleOrDefault()?.Value is "cl_bitfield" or "cl_properties"
                )
                .Elements("name")
        )
        {
            // We don't have to do horrible string manipulation here because this ends up in the actual C header, so
            // it's actually correct for once.
            if (!data.Groups.ContainsKey(@enum.Value))
            {
                data.Groups[@enum.Value] = new EnumGroup(
                    @enum.Value,
                    @enum.Value,
                    // cl_properties and cl_bitfield are both cl_ulong which is ulong
                    "ulong",
                    [],
                    @enum.Parent?.Element("type")?.Value == "cl_bitfield",
                    VendorFromString(@enum.Value, vendors),
                    null
                );
            }
        }

        void FixupGroupNameForOpenCL(
            ref string groupName,
            ref bool isLikelyOpenCL,
            ref bool isBitmask
        )
        {
            if (groupName.StartsWith("ErrorCodes") && groupName.Contains('.'))
            {
                groupName = "ErrorCodes";
                isLikelyOpenCL = true;
            }
            else if (groupName.EndsWith(".flags"))
            {
                // NOTE: I've actually gone ahead and disagreed with the original code here because why do we want to
                // strip flags out of the name? There are only three instances of this in the spec currently:
                // cl_arm_svm_alloc.flags, cl_arm_device_svm_capabilities.flags, and
                // cl_intel_advanced_motion_estimation.flags
                //groupName = groupName[..^".flags".Length];
                isBitmask = true;
                isLikelyOpenCL = true;
            }

            if (groupName.Contains('.'))
            {
                logger.LogDebug(
                    "OpenCL-style group name syntax: \"{}\" (replacing '.' with '_')",
                    groupName
                );
                groupName = groupName.Replace('.', '_');
                isLikelyOpenCL = true;
            }
        }

        // Okay so this bit is absolutely freaking bonkers. We're using the <require comment="..."> attribute for
        // meaningful data, which you should literally never do, but in lieu of OpenCL actually annotating their groups
        // properly this will have to do. If there's only human-readable information, we shall automate reading like
        // human!
        // Original code, further comments have line markers where they map into the original code:
        // https://github.com/dotnet/Silk.NET/blob/d8919600/src/Core/Silk.NET.BuildTools/Converters/Readers/OpenCLReader.cs#L878
        foreach (
            var enumRequirement in (doc.Element("registry")?.Elements("feature") ?? [])
                .Concat(doc.Element("registry")?.Elements("extensions").Elements("extension") ?? [])
                .Elements("require")
                .Elements("enum")
        )
        {
            var enumName =
                enumRequirement.Attribute("name")?.Value
                ?? throw new InvalidDataException(
                    "Expected \"name\" attribute on <enum> in <require> tag."
                );

            var thisVendor = VendorFromString(enumName, vendors);

            // If we've already intentionally excluded this enum, don't change that now. L880
            if (topLevelIntentionalExclusions.Contains(enumName))
            {
                continue;
            }

            // TODO we may want to add some NativeNameOverride logic akin to BuildTools' "rename" element in 2.X.
            // This was removed because all of the corner cases for OpenCL specifically no longer apply. L882/L884
            var typeStr = enumRequirement.Parent?.Attribute("comment")?.Value;
            IEnumerable<string>? allTypes = null;

            // Is this a human-readable comment or a verbatim type name? L886
            // NOTE: Adjusted to be !IsAsciiLetterOrDigit instead of just ' ' because of the weird _?? case that should
            // not exist.
            if (
                string.IsNullOrWhiteSpace(typeStr)
                || typeStr.Any(x => !char.IsAsciiLetterOrDigit(x) && x is not ('.' or '_'))
            )
            {
                if (!string.IsNullOrWhiteSpace(typeStr))
                {
                    // If the human comment indicates these are error code enums, put them in the ErrorCode group
                    // already established. L894
                    if (typeStr.Equals("Error codes", StringComparison.OrdinalIgnoreCase))
                    {
                        typeStr = "ErrorCodes";
                    }
                    else if (
                        typeStr.StartsWith("OpenCL ", StringComparison.OrdinalIgnoreCase)
                        && typeStr.Contains("deprecated", StringComparison.OrdinalIgnoreCase)
                    )
                    {
                        // Core spec deprecation notices. L897
                        var typeNameStart = typeStr.IndexOf(' ', startIndex: "OpenCL ".Length) + 1;
                        var typeNameEnd = typeStr.IndexOf(' ', typeNameStart + 1);
                        typeStr = typeStr[typeNameStart..typeNameEnd];
                    }
                    else if (
                        typeStr.StartsWith("cl_uint ", StringComparison.OrdinalIgnoreCase)
                        && !data.EnumsToGroups[enumName].Any(x => x.StartsWith("cl_")) // <-- last resort only
                    )
                    {
                        // QCOM extensions. L902
                        typeStr = typeStr["cl_uint ".Length..];
                    }
                    // @Perksey: New special case for "cl_mem_flags and cl_svm_mem_flags - bitfield".
                    // Essentially we check whether the comment is a grammatical list.
                    else if (
                        typeStr[..(typeStr.IndexOf('-') is >= 0 and var i ? i : ^0)].Trim()
                            is var andList
                        && andList.All(x =>
                            char.IsAsciiLetterOrDigit(x) || x is '.' or ' ' or ',' or '_'
                        )
                        && andList.Split(
                            ' ',
                            StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
                        )
                            is var splitList
                        && splitList
                            .Select((x, j) => (x, j))
                            .All(x =>
                                x.x.StartsWith("cl_")
                                || (x.x == "and" && x.j == splitList.Length - 2)
                            )
                    )
                    {
                        allTypes = splitList
                            .Where(x => x is not "and" && x.StartsWith("cl_"))
                            .Select(x => x.Trim(','));
                    }
                    else
                    {
                        // Didn't match one of our special cases exactly, so let's not do anything. L903
                        typeStr = null;
                    }
                }
                else // we don't want to do anything if we have an entirely whitespace string...
                {
                    typeStr = null;
                }
            }

            foreach (var group in allTypes ?? (typeStr is null ? [] : [typeStr]))
            {
                // Just in case.
                var tempVar = false;
                var groupStr = group;
                FixupGroupNameForOpenCL(ref groupStr, ref likelyOpenCL, ref tempVar);

                // Update the group info if it doesn't exist.
                if (data.Groups.TryGetValue(groupStr, out var groupInfo))
                {
                    if (thisVendor is not null && groupInfo.ExclusiveVendor != thisVendor)
                    {
                        data.Groups[groupStr] = groupInfo with { ExclusiveVendor = null };
                    }
                }
                else
                {
                    data.Groups[groupStr] = new EnumGroup(
                        groupStr,
                        groupStr,
                        null,
                        [],
                        (typeStr is not null && typeStr.Contains("bitfield"))
                            || group.Contains("flags"),
                        thisVendor,
                        null
                    );
                }

                // Get the group hash set for this enum.
                if (!data.EnumsToGroups.TryGetValue(enumName, out var enumToGroups))
                {
                    data.EnumsToGroups[enumName] = enumToGroups = [];
                }

                // Mark this enum.
                enumToGroups.Add(groupStr);
            }
        }
    }

    private static string? VendorFromString(string str, HashSet<string> vendors) =>
        str.LastIndexOf('_') is > 0 and var idx
        && idx < str.Length
        && str[idx..].ToUpper() is var vend
        && vendors.Contains(vend)
            ? vend
            : null;
}
