using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using ClangSharp;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Emitter;
using Silk.NET.SilkTouch.Scraper;
using Silk.NET.SilkTouch.Symbols;
using Silk.NET.SilkTouch.TypeResolution;
using Symbol=Silk.NET.SilkTouch.Symbols.Symbol;
using Type=System.Type;

namespace Silk.NET.SilkTouch.DotnetTool
{
    internal class Program
    {
        static async Task<int> Main(string[] args)
        {
            var logLevel = new Option<LogLevel>(new[] { "log-level", "l" }, () => LogLevel.Information);
            var useStandardIncludes = new Option<bool>(new[] { "standard-includes", "si" }, () => true);
            var extraIncludedDirectories = new Option<string[]>
                (new[] { "extra-included-directories", "exd" }, Array.Empty<string>)
                {
                    AllowMultipleArgumentsPerToken = true
                };
            var includedNames = new Option<string[]>
                (new[] { "included-names" }, Array.Empty<string>)
                {
                    AllowMultipleArgumentsPerToken = true
                };
            var excludedNames = new Option<string[]>
                (new[] { "excluded-names" }, Array.Empty<string>)
                {
                    AllowMultipleArgumentsPerToken = true
                };
            var definedMacros = new Option<string[]>
                (new[] { "defined-macros" }, Array.Empty<string>)
                {
                    AllowMultipleArgumentsPerToken = true
                };
            var headerFile = new Option<FileInfo>(new[] { "header-file" })
            {
                IsRequired = true
            };

            var usedSymbolVisitors = new Option<AvailableSymbolVisitors>
            (
                new[] { "used-symbol-visitors", "vs" },
                () => AvailableSymbolVisitors.AllTypeResolvers,
                "The symbol visitors called to process the raw symbols into those used to emit C#." +
                " Generally includes most type resolvers and overloaders as appropriate."
            );

            var xmlFile = new Option<FileInfo?>(new[] { "xml-file", "xf" }, "The File to read/write XML from/to");
            var rawSymbolsFile = new Option<FileInfo?>
                (new[] { "raw-symbols-file", "rsf" }, "The File to read/write Raw Symbols from/to");
            var processedSymbolsFile = new Option<FileInfo?>
                (new[] { "processed-symbols-file", "psf" }, "The File to read/write Processed Symbols from/to");
            var csharpDir = new Option<DirectoryInfo?>
                (new[] { "csharp-directory", "csharp-dir", "csd" }, "The Directory to read/write C# files from/to");

            var generateBindings = new Command("bindings")
            {
                logLevel,
                xmlFile,
                rawSymbolsFile,
                processedSymbolsFile,
                csharpDir,
                extraIncludedDirectories,
                includedNames,
                excludedNames,
                definedMacros,
                headerFile,
                usedSymbolVisitors
            };
            generateBindings.SetHandler
            (
               
                (async (context) =>
                {
                    var serviceProvider = CreateServiceProvider(context.ParseResult.GetValueForOption(logLevel));
                    XmlDocument xmlDoc = GetXml
                    (
                        serviceProvider,
                        context.ParseResult.GetValueForOption(useStandardIncludes),
                        context.ParseResult.GetValueForOption(extraIncludedDirectories)!,
                        context.ParseResult.GetValueForOption(headerFile)!.FullName,
                        context.ParseResult.GetValueForOption(includedNames)!,
                        context.ParseResult.GetValueForOption(excludedNames)!,
                        context.ParseResult.GetValueForOption(definedMacros)!
                    );
                    var xmlFileRes = context.ParseResult.GetValueForOption(xmlFile);
                    if (xmlFileRes is not null)
                    {
                        if (xmlFileRes.Exists) xmlFileRes.Delete();
                        await using var stream = xmlFileRes.OpenWrite();
                        await using var writer = new XmlTextWriter(stream, Encoding.UTF8);
                        xmlDoc.WriteTo(writer);
                    }
                    
                    var (rawSymbols, typeStore) = GetSymbols(serviceProvider, xmlDoc);
                    var rawSymbolsFileRes = context.ParseResult.GetValueForOption(rawSymbolsFile);
                    if (rawSymbolsFileRes is not null)
                    {
                        if (rawSymbolsFileRes.Exists) rawSymbolsFileRes.Delete();
                        await using var stream = rawSymbolsFileRes.OpenWrite();
                        await JsonSerializer.SerializeAsync(stream, rawSymbols, GetJsonOptions());
                    }

                    var processedSymbols = ProcessSymbols
                    (
                        serviceProvider,
                        rawSymbols,
                        typeStore,
                        context.ParseResult.GetValueForOption(usedSymbolVisitors)
                    );
                    var processedSymbolsFileRes = context.ParseResult.GetValueForOption(processedSymbolsFile);
                    if (processedSymbolsFileRes is not null)
                    {
                        if (processedSymbolsFileRes.Exists) processedSymbolsFileRes.Delete();
                        await using var stream = processedSymbolsFileRes.OpenWrite();
                        await JsonSerializer.SerializeAsync(stream, processedSymbols, GetJsonOptions());
                    }

                    var csharp = GetCSharp(serviceProvider, processedSymbols, typeStore).Select(x => x.ToFullString())
                        .Select((x, i) => (x, i.ToString() + ".cs"));
                    var csharpDirRes = context.ParseResult.GetValueForOption(csharpDir);
                    if (csharpDirRes is not null)
                    {
                        foreach (var (contents, fileName) in csharp)
                        {
                            var path = Path.Combine(csharpDirRes.FullName, fileName);
                            await File.WriteAllTextAsync(path, contents);
                        }
                    }
                })
            );

            var generateCSharp = new Command("csharp")
            {
                processedSymbolsFile, csharpDir, logLevel
            };
            generateCSharp.SetHandler
            (
                (async static (processedSymbolsFile, csharpDir, logLevel) =>
                {
                    var serviceProvider = CreateServiceProvider(logLevel);
                    Symbol[] symbols;
                    TypeStore typeStore;
                    if (processedSymbolsFile is null)
                    {
                        symbols = Array.Empty<Symbol>();
                        typeStore = new TypeStore();
                    }
                    else
                    {
                        var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
                        logger.LogInformation("Loading Symbols from File...");
                        await using var stream = processedSymbolsFile.OpenRead();
                        symbols = await JsonSerializer.DeserializeAsync<Symbol[]>(stream, GetJsonOptions()) ?? Array.Empty<Symbol>();
                        logger.LogInformation("Loaded {count} Symbols from Disk. Restoring Type Store...", symbols.Length);
                        typeStore = RestoreTypeStore(symbols);
                        logger.LogInformation("Type Store Restored");
                    }

                    var csharp = GetCSharp(serviceProvider, symbols, typeStore).Select(x => x.ToFullString())
                        .Select((x, i) => (x, i.ToString() + ".cs"));
                    if (csharpDir is not null)
                    {
                        foreach (var (contents, fileName) in csharp)
                        {
                            var path = Path.Combine(csharpDir.FullName, fileName);
                            await File.WriteAllTextAsync(path, contents);
                        }
                    }
                }),
                processedSymbolsFile,
                csharpDir,
                logLevel
            );
            
            var generateRawSymbols = new Command("raw-symbols")
            {
                xmlFile,
                rawSymbolsFile,
                logLevel
            };
            generateRawSymbols.SetHandler(
                (Func<FileInfo?, FileInfo?, LogLevel, Task>)
                (async static (xmlFile, rawSymbolsFile, logLevel) =>
                {
                    var serviceProvider = CreateServiceProvider(logLevel);
                    Symbol[] symbols;
                    TypeStore typeStore;
                    if (xmlFile is null)
                    {
                        symbols = Array.Empty<Symbol>();
                        typeStore = new TypeStore();
                    }
                    else
                    {
                        var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
                        var xmlDoc = new XmlDocument();
                        await using var stream = xmlFile.OpenRead();
                        xmlDoc.Load(stream);
                        (symbols, typeStore) = GetSymbols(serviceProvider, xmlDoc);
                        logger.LogTrace("{count} Symbols Scraped from XML", symbols.Length);
                    }
                    
                    if (rawSymbolsFile is not null)
                    {
                        if (rawSymbolsFile.Exists) rawSymbolsFile.Delete();
                        await using var stream = rawSymbolsFile.OpenWrite();
                        await JsonSerializer.SerializeAsync(stream, symbols, GetJsonOptions());
                    }
                }), xmlFile, rawSymbolsFile, logLevel);

            var generateXML = new Command("xml")
            {
                xmlFile,
                logLevel,
                useStandardIncludes,
                extraIncludedDirectories,
                includedNames,
                excludedNames,
                definedMacros,
                headerFile
            };
            generateXML.SetHandler
            (
                (async static (xmlFile, logLevel, useStandardIncludes, extraIncludedDirectories,
                    includedNames, excludedNames, definedMacros, headerFile) =>
                {
                    var serviceProvider = CreateServiceProvider(logLevel);
                    XmlDocument xmlDoc = GetXml
                    (
                        serviceProvider,
                        useStandardIncludes,
                        extraIncludedDirectories,
                        headerFile.FullName,
                        includedNames,
                        excludedNames,
                        definedMacros
                    );
                    if (xmlFile is not null)
                    {
                        if (xmlFile.Exists) xmlFile.Delete();
                        await using var stream = xmlFile.OpenWrite();
                        await using var writer = new XmlTextWriter(stream, Encoding.UTF8);
                        xmlDoc.WriteTo(writer);
                    }
                }),
                xmlFile,
                logLevel,
                useStandardIncludes,
                extraIncludedDirectories,
                includedNames,
                excludedNames,
                definedMacros,
                headerFile
            );

            var processSymbols = new Command("process-symbols")
            {
                logLevel,
                rawSymbolsFile,
                processedSymbolsFile,
                usedSymbolVisitors
            };
            processSymbols.SetHandler(
                async static (logLevel, rawSymbolsFile, processedSymbolsFile, usedSymbolVisitors) =>
                {
                    var serviceProvider = CreateServiceProvider(logLevel);
                    
                    Symbol[] rawSymbols;
                    TypeStore typeStore;
                    if (rawSymbolsFile is null)
                    {
                        rawSymbols = Array.Empty<Symbol>();
                        typeStore = new TypeStore();
                    }
                    else
                    {
                        var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
                        logger.LogInformation("Loading Symbols from File...");
                        await using var stream = rawSymbolsFile.OpenRead();
                        rawSymbols = await JsonSerializer.DeserializeAsync<Symbol[]>(stream, GetJsonOptions()) ?? Array.Empty<Symbol>();
                        logger.LogInformation("Loaded {count} Symbols from Disk. Restoring Type Store...", rawSymbols.Length);
                        typeStore = RestoreTypeStore(rawSymbols);
                        logger.LogInformation("Type Store Restored");
                    }
                    
                    var processedSymbols = ProcessSymbols(serviceProvider, rawSymbols, typeStore, usedSymbolVisitors);
                    if (processedSymbolsFile is not null)
                    {
                        if (processedSymbolsFile.Exists) processedSymbolsFile.Delete();
                        await using var stream = processedSymbolsFile.OpenWrite();
                        await JsonSerializer.SerializeAsync(stream, processedSymbols, GetJsonOptions());
                    }
                    
                }, logLevel, rawSymbolsFile, processedSymbolsFile, usedSymbolVisitors);

            var generate = new Command("generate")
            {
                generateBindings,
                generateCSharp,
                generateRawSymbols,
                generateXML,
                processSymbols
            };
            
            var rootCommand = new RootCommand
                ("SilkTouch dotnet tool. Use to generate the silkiest bindings you've ever seen!")
                {
                    generate
                };
            
            return await rootCommand.InvokeAsync(args);
        }

        private static IEnumerable<Symbol> ProcessSymbols
            (IServiceProvider serviceProvider, IEnumerable<Symbol> symbols, TypeStore typeStore, AvailableSymbolVisitors usedSymbolVisitors)
        {
            var visitors = new List<SymbolVisitor>();

            if ((usedSymbolVisitors & AvailableSymbolVisitors.PointerTypeResolver) != 0)
            {
                visitors.Add(ActivatorUtilities.CreateInstance<PointerTypeResolver>(serviceProvider, typeStore));
            }

            if ((usedSymbolVisitors & AvailableSymbolVisitors.FunctionPointerTypeResolver) != 0)
            {
                visitors.Add(ActivatorUtilities.CreateInstance<FunctionPointerTypeResolver>(serviceProvider, typeStore));
            }

            if ((usedSymbolVisitors & AvailableSymbolVisitors.InternalTypeResolver) != 0)
            {
                var typeScopeSymbolVisitor = ActivatorUtilities.CreateInstance<TypeScopeSymbolVisitor>
                    (serviceProvider, typeStore);
                visitors.Add(typeScopeSymbolVisitor);
                visitors.Add
                (
                    ActivatorUtilities.CreateInstance<NameResolverSymbolVisitor>
                        (serviceProvider, typeScopeSymbolVisitor.RootScope, typeStore)
                );
            }

            if ((usedSymbolVisitors & AvailableSymbolVisitors.PrimitiveTypeResolver) != 0)
            {
                visitors.Add(ActivatorUtilities.CreateInstance<PrimitiveTypeResolver>(serviceProvider, typeStore));
            }
            

            foreach (var visitor in visitors)
            {
                symbols = symbols.Select(visitor.Visit);
            }

            return symbols;
        }

        private static XmlDocument GetXml
        (
            IServiceProvider serviceProvider,
            bool useStandardIncludes,
            string[] extraIncludedDirectories,
            string headerFile,
            string[] includedNames,
            string[] excludedNames,
            string[] definedMacros
        )
        {
            var scraper = ActivatorUtilities.GetServiceOrCreateInstance<ClangScraper>(serviceProvider);
            var includedDirectories = new List<string>();
            if (useStandardIncludes)
            {
                includedDirectories.AddRange(scraper.ResolveStandardIncludes());
            }
            includedDirectories.AddRange(extraIncludedDirectories);

            var xml = scraper.GenerateXML(headerFile, includedNames, excludedNames, includedDirectories.ToArray(), definedMacros);

            return xml ?? new XmlDocument();
        }

        private static (Symbol[], TypeStore) GetSymbols(IServiceProvider serviceProvider, XmlDocument xml)
        {
            var scraper = ActivatorUtilities.GetServiceOrCreateInstance<ClangScraper>(serviceProvider);
            var typeStore = new TypeStore();
            var symbols = scraper.ScrapeXML(xml, typeStore).ToArray();

            return (symbols, typeStore);
        }

        private static TypeStore RestoreTypeStore(IEnumerable<Symbol> symbols)
        {
            var typeStore = new TypeStore();
            var visitor = new TypeStoreRestoreVisitor(typeStore);

            foreach (var symbol in symbols)
            {
                visitor.Visit(symbol); // discard, we don't care
            }

            return typeStore;
        }

        private static IEnumerable<CSharpSyntaxNode> GetCSharp(IServiceProvider serviceProvider, IEnumerable<Symbol> symbols, TypeStore typeStore)
        {
            var emitter = ActivatorUtilities.GetServiceOrCreateInstance<CSharpEmitter>(serviceProvider);

            return symbols.Select(x => emitter.Transform(x, typeStore));
        }
        
        
        private sealed class TypeStoreRestoreVisitor : SymbolVisitor
        {
            public TypeStoreRestoreVisitor(TypeStore typeStore) : base(typeStore)
            { }

            protected override TypeReference VisitTypeReference(TypeReference typeReference)
            {
                if (typeReference is UnresolvedTypeReference) return typeReference;
                return base.VisitTypeReference(typeReference);
            }
        }


        private static IServiceProvider CreateServiceProvider(LogLevel minimum)
        {
            
            var configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables(source => source.Prefix = "SILK_DOTNET_")
                .Build();
            var serviceProvider = new ServiceCollection()
                .AddLogging(builder =>
                    {
                        builder.AddConsole();
                        builder.SetMinimumLevel(minimum);
                    }
                )
                .Configure<ClangScraperConfiguration>(configuration.GetSection("Scraper"))
                .AddSingleton<ClangScraper>()
                .AddSingleton<CSharpEmitter>()
                .BuildServiceProvider();
            return serviceProvider;
        }

        private static JsonSerializerOptions GetJsonOptions()
        {
            var opts = new JsonSerializerOptions();
            opts.Converters.Add(new SymbolJsonConverterFactory());
            return opts;
        }

        private sealed class SymbolJsonConverterFactory : JsonConverterFactory
        {

            public override bool CanConvert
                (Type typeToConvert) => typeToConvert.IsAbstract && typeToConvert.IsAssignableTo(typeof(Symbol));
            public override JsonConverter? CreateConverter
                (Type typeToConvert, JsonSerializerOptions options) => (JsonConverter?) Activator.CreateInstance
                (typeof(SymbolJsonConverter<>).MakeGenericType(typeToConvert));
        }
        
        private sealed class SymbolJsonConverter<T>
            : JsonConverter<T>
            where T : Symbol
        {
            public override bool CanConvert
                // If a leaf type (non-abstract) is given, serialize as that
                (Type typeToConvert) => typeToConvert.IsAbstract && typeToConvert.IsAssignableTo(typeof(T));

            public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                if (!document.RootElement.TryGetProperty("type", out var typeProp) || typeProp.GetString() is not {} type)
                    throw new InvalidOperationException("Cannot deserialize symbol without \"type\"");
                
                var symbolType = typeof(T).Assembly.GetTypes().First(x => x.Name == type);
                if (symbolType is null)
                    throw new InvalidOperationException($"Could not find type {type}");

                return document.Deserialize(symbolType, options) as T;
            }
            public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            {
                writer.WriteStartObject();

                var type = value.GetType();
                writer.WritePropertyName("type");
                writer.WriteStringValue(type.Name);
                
                var element = JsonSerializer.SerializeToElement(value, type, options);
                foreach (var prop in element.EnumerateObject())
                {
                    writer.WritePropertyName(prop.Name);
                    prop.Value.WriteTo(writer);
                }
                
                writer.WriteEndObject();
            }
        }
        
        [Flags]
        private enum AvailableSymbolVisitors
        {
            None = 0,
            PointerTypeResolver = 1 << 1,
            InternalTypeResolver = 1 << 2,
            PrimitiveTypeResolver = 1 << 3,
            FunctionPointerTypeResolver = 1 << 4,
            AllTypeResolvers = PointerTypeResolver | InternalTypeResolver | PrimitiveTypeResolver | FunctionPointerTypeResolver,
        }
    }
}
