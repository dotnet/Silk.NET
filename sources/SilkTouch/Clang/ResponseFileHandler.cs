using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Parsing;
using System.IO;
using System.IO.Hashing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using ClangSharp;
using ClangSharp.Abstractions;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.Logging;
using static ClangSharp.Interop.CXTranslationUnit_Flags;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// Reads a response file (rsp) containing ClangSharpPInvokeGenerator command line arguments.
/// </summary>
public class ResponseFileHandler
{
    private static readonly RootCommand _rootCommand;

    private static readonly Option<bool> _versionOption;
    private static readonly Option<string[]> _additionalOption;
    private static readonly Option<string[]> _configOption;
    private static readonly Option<string[]> _defineMacros;
    private static readonly Option<string[]> _excludedNames;
    private static readonly Option<string[]> _files;
    private static readonly Option<string> _fileDirectory;
    private static readonly Option<string> _headerFile;
    private static readonly Option<string[]> _includedNames;
    private static readonly Option<string[]> _includeDirectories;
    private static readonly Option<string> _language;
    private static readonly Option<string> _libraryPath;
    private static readonly Option<string> _methodClassName;
    private static readonly Option<string> _methodPrefixToStrip;
    private static readonly Option<string[]> _nativeTypeNamesToStrip;
    private static readonly Option<string> _namespaceName;
    private static readonly Option<string> _outputLocation;
    private static readonly Option<PInvokeGeneratorOutputMode> _outputMode;
    private static readonly Option<string[]> _remappedNameValuePairs;
    private static readonly Option<string> _std;
    private static readonly Option<string> _testOutputLocation;
    private static readonly Option<string[]> _traversalNames;
    private static readonly Option<string[]> _withAccessSpecifierNameValuePairs;
    private static readonly Option<string[]> _withAttributeNameValuePairs;
    private static readonly Option<string[]> _withCallConvNameValuePairs;
    private static readonly Option<string[]> _withClassNameValuePairs;
    private static readonly Option<string[]> _withGuidNameValuePairs;
    private static readonly Option<string[]> _withLibraryPathNameValuePairs;
    private static readonly Option<string[]> _withManualImports;
    private static readonly Option<string[]> _withNamespaceNameValuePairs;
    private static readonly Option<string[]> _withSetLastErrors;
    private static readonly Option<string[]> _withSuppressGCTransitions;
    private static readonly Option<string[]> _withTransparentStructNameValuePairs;
    private static readonly Option<string[]> _withTypeNameValuePairs;
    private static readonly Option<string[]> _withUsingNameValuePairs;
    private static readonly Option<string[]> _withPackingNameValuePairs;

    private static readonly string[] _additionalOptionAliases = new string[]
    {
        "--additional",
        "-a"
    };
    private static readonly string[] _configOptionAliases = new string[] { "--config", "-c" };
    private static readonly string[] _defineMacroOptionAliases = new string[]
    {
        "--define-macro",
        "-D"
    };
    private static readonly string[] _excludeOptionAliases = new string[] { "--exclude", "-e" };
    private static readonly string[] _fileOptionAliases = new string[] { "--file", "-f" };
    private static readonly string[] _fileDirectionOptionAliases = new string[]
    {
        "--file-directory",
        "-F"
    };
    private static readonly string[] _headerOptionAliases = new string[] { "--headerFile", "-h" };
    private static readonly string[] _includeOptionAliases = new string[] { "--include", "-i" };
    private static readonly string[] _includeDirectoryOptionAliases = new string[]
    {
        "--include-directory",
        "-I"
    };
    private static readonly string[] _languageOptionAliases = new string[] { "--language", "-x" };
    private static readonly string[] _libraryOptionAliases = new string[] { "--libraryPath", "-l" };
    private static readonly string[] _methodClassNameOptionAliases = new string[]
    {
        "--methodClassName",
        "-m"
    };
    private static readonly string[] _namespaceOptionAliases = new string[] { "--namespace", "-n" };
    private static readonly string[] _nativeTypeNamesStripOptionAliases = new string[]
    {
        "--nativeTypeNamesToStrip"
    };
    private static readonly string[] _outputModeOptionAliases = new string[]
    {
        "--output-mode",
        "-om"
    };
    private static readonly string[] _outputOptionAliases = new string[] { "--output", "-o" };
    private static readonly string[] _prefixStripOptionAliases = new string[]
    {
        "--prefixStrip",
        "-p"
    };
    private static readonly string[] _remapOptionAliases = new string[] { "--remap", "-r" };
    private static readonly string[] _stdOptionAliases = new string[] { "--std", "-std" };
    private static readonly string[] _testOutputOptionAliases = new string[]
    {
        "--test-output",
        "-to"
    };
    private static readonly string[] _versionOptionAliases = new string[] { "--version", "-v" };
    private static readonly string[] _traverseOptionAliases = new string[] { "--traverse", "-t" };
    private static readonly string[] _withAccessSpecifierOptionAliases = new string[]
    {
        "--with-access-specifier",
        "-was"
    };
    private static readonly string[] _withAttributeOptionAliases = new string[]
    {
        "--with-attribute",
        "-wa"
    };
    private static readonly string[] _withCallConvOptionAliases = new string[]
    {
        "--with-callconv",
        "-wcc"
    };
    private static readonly string[] _withClassOptionAliases = new string[]
    {
        "--with-class",
        "-wc"
    };
    private static readonly string[] _withGuidOptionAliases = new string[] { "--with-guid", "-wg" };
    private static readonly string[] _withLibraryPathOptionAliases = new string[]
    {
        "--with-librarypath",
        "-wlb"
    };
    private static readonly string[] _withManualImportOptionAliases = new string[]
    {
        "--with-manual-import",
        "-wmi"
    };
    private static readonly string[] _withNamespaceOptionAliases = new string[]
    {
        "--with-namespace",
        "-wn"
    };
    private static readonly string[] _withSetLastErrorOptionAliases = new string[]
    {
        "--with-setlasterror",
        "-wsle"
    };
    private static readonly string[] _withSuppressGCTransitionOptionAliases = new string[]
    {
        "--with-suppressgctransition",
        "-wsgct"
    };
    private static readonly string[] _withTransparentStructOptionAliases = new string[]
    {
        "--with-transparent-struct",
        "-wts"
    };
    private static readonly string[] _withTypeOptionAliases = new string[] { "--with-type", "-wt" };
    private static readonly string[] _withUsingOptionAliases = new string[]
    {
        "--with-using",
        "-wu"
    };
    private static readonly string[] _withPackingOptionAliases = new string[]
    {
        "--with-packing",
        "-wp"
    };
    private readonly ILogger<ResponseFileHandler> _logger;

    static ResponseFileHandler()
    {
        _additionalOption = GetAdditionalOption();
        _configOption = GetConfigOption();
        _defineMacros = GetDefineMacroOption();
        _excludedNames = GetExcludeOption();
        _files = GetFileOption();
        _fileDirectory = GetFileDirectoryOption();
        _headerFile = GetHeaderOption();
        _includedNames = GetIncludeOption();
        _includeDirectories = GetIncludeDirectoryOption();
        _language = GetLanguageOption();
        _libraryPath = GetLibraryOption();
        _methodClassName = GetMethodClassNameOption();
        _namespaceName = GetNamespaceOption();
        _outputMode = GetOutputModeOption();
        _outputLocation = GetOutputOption();
        _methodPrefixToStrip = GetPrefixStripOption();
        _nativeTypeNamesToStrip = GetNativeTypeNamesStripOption();
        _remappedNameValuePairs = GetRemapOption();
        _std = GetStdOption();
        _testOutputLocation = GetTestOutputOption();
        _traversalNames = GetTraverseOption();
        _versionOption = GetVersionOption();
        _withAccessSpecifierNameValuePairs = GetWithAccessSpecifierOption();
        _withAttributeNameValuePairs = GetWithAttributeOption();
        _withCallConvNameValuePairs = GetWithCallConvOption();
        _withClassNameValuePairs = GetWithClassOption();
        _withGuidNameValuePairs = GetWithGuidOption();
        _withLibraryPathNameValuePairs = GetWithLibraryPathOption();
        _withManualImports = GetWithManualImportOption();
        _withNamespaceNameValuePairs = GetWithNamespaceOption();
        _withSetLastErrors = GetWithSetLastErrorOption();
        _withSuppressGCTransitions = GetWithSuppressGCTransitionOption();
        _withTransparentStructNameValuePairs = GetWithTransparentStructOption();
        _withTypeNameValuePairs = GetWithTypeOption();
        _withUsingNameValuePairs = GetWithUsingOption();
        _withPackingNameValuePairs = GetWithPackingOption();

        _rootCommand = new RootCommand("ClangSharp P/Invoke Binding Generator")
        {
            _additionalOption,
            _configOption,
            _defineMacros,
            _excludedNames,
            _files,
            _fileDirectory,
            _headerFile,
            _includedNames,
            _includeDirectories,
            _language,
            _libraryPath,
            _methodClassName,
            _namespaceName,
            _outputMode,
            _outputLocation,
            _methodPrefixToStrip,
            _nativeTypeNamesToStrip,
            _remappedNameValuePairs,
            _std,
            _testOutputLocation,
            _traversalNames,
            _versionOption,
            _withAccessSpecifierNameValuePairs,
            _withAttributeNameValuePairs,
            _withCallConvNameValuePairs,
            _withClassNameValuePairs,
            _withGuidNameValuePairs,
            _withLibraryPathNameValuePairs,
            _withManualImports,
            _withNamespaceNameValuePairs,
            _withSetLastErrors,
            _withSuppressGCTransitions,
            _withTransparentStructNameValuePairs,
            _withTypeNameValuePairs,
            _withUsingNameValuePairs,
            _withPackingNameValuePairs
        };
    }

    /// <summary>
    /// Creates a response file handler with the given logger.
    /// </summary>
    /// <param name="logger">The logger to use.</param>
    public ResponseFileHandler(ILogger<ResponseFileHandler> logger)
    {
        _logger = logger;
    }

    private static void ParseKeyValuePairs(
        IEnumerable<string> keyValuePairs,
        List<string> errorList,
        out Dictionary<string, string> result
    )
    {
        result = new Dictionary<string, string>();

        foreach (var keyValuePair in keyValuePairs)
        {
            var parts = keyValuePair.Split('=');

            if (parts.Length != 2)
            {
                errorList.Add(
                    $"Error: Invalid key/value pair argument: {keyValuePair}. Expected 'name=value'"
                );
                continue;
            }

            var key = parts[0].TrimEnd();

            if (result.TryGetValue(key, out var value))
            {
                errorList.Add(
                    $"Error: A key with the given name already exists: {key}. Existing: {value}"
                );
                continue;
            }

            result.Add(key, parts[1].TrimStart());
        }
    }

    private static void ParseKeyValuePairs(
        IEnumerable<string> keyValuePairs,
        List<string> errorList,
        out Dictionary<string, AccessSpecifier> result
    )
    {
        result = new Dictionary<string, AccessSpecifier>();

        foreach (var keyValuePair in keyValuePairs)
        {
            var parts = keyValuePair.Split('=');

            if (parts.Length != 2)
            {
                errorList.Add(
                    $"Error: Invalid key/value pair argument: {keyValuePair}. Expected 'name=value'"
                );
                continue;
            }

            var key = parts[0].TrimEnd();

            if (result.TryGetValue(key, out var value))
            {
                errorList.Add(
                    $"Error: A key with the given name already exists: {key}. Existing: {value}"
                );
                continue;
            }

            result.Add(
                key,
                PInvokeGeneratorConfiguration.ConvertStringToAccessSpecifier(parts[1].TrimStart())
            );
        }
    }

    private static void ParseKeyValuePairs(
        IEnumerable<string> keyValuePairs,
        List<string> errorList,
        out Dictionary<string, Guid> result
    )
    {
        result = new Dictionary<string, Guid>();

        foreach (var keyValuePair in keyValuePairs)
        {
            var parts = keyValuePair.Split('=');

            if (parts.Length != 2)
            {
                errorList.Add(
                    $"Error: Invalid key/value pair argument: {keyValuePair}. Expected 'name=value'"
                );
                continue;
            }

            var key = parts[0].TrimEnd();

            if (result.TryGetValue(key, out var value))
            {
                errorList.Add(
                    $"Error: A key with the given name already exists: {key}. Existing: {value}"
                );
                continue;
            }

            if (!Guid.TryParse(parts[1].TrimStart(), out var guid))
            {
                errorList.Add($"Error: Failed to parse guid: {parts[1]}");
                continue;
            }

            result.Add(key, guid);
        }
    }

    private static void ParseKeyValuePairs(
        IEnumerable<string> keyValuePairs,
        List<string> errorList,
        out Dictionary<string, (string, PInvokeGeneratorTransparentStructKind)> result
    )
    {
        result = new Dictionary<string, (string, PInvokeGeneratorTransparentStructKind)>();

        foreach (var keyValuePair in keyValuePairs)
        {
            var parts = keyValuePair.Split('=');

            if (parts.Length != 2)
            {
                errorList.Add(
                    $"Error: Invalid key/value pair argument: {keyValuePair}. Expected 'name=value' or 'name=value;kind'"
                );
                continue;
            }

            var key = parts[0].TrimEnd();

            if (result.TryGetValue(key, out var value))
            {
                errorList.Add(
                    $"Error: A key with the given name already exists: {key}. Existing: {value}"
                );
                continue;
            }

            parts = parts[1].Split(';');

            if (parts.Length == 1)
            {
                result.Add(key, (parts[0], PInvokeGeneratorTransparentStructKind.Unknown));
            }
            else if (
                parts.Length == 2
                && Enum.TryParse<PInvokeGeneratorTransparentStructKind>(
                    parts[1],
                    out var transparentStructKind
                )
            )
            {
                result.Add(key, (parts[0], transparentStructKind));
            }
            else
            {
                errorList.Add(
                    $"Error: Invalid key/value pair argument: {keyValuePair}. Expected 'name=value' or 'name=value;kind'"
                );
                continue;
            }
        }
    }

    private static void ParseKeyValuePairs(
        IEnumerable<string> keyValuePairs,
        List<string> errorList,
        out Dictionary<string, IReadOnlyList<string>> result
    )
    {
        result = new Dictionary<string, IReadOnlyList<string>>();

        foreach (var keyValuePair in keyValuePairs)
        {
            var parts = keyValuePair.Split('=');

            if (parts.Length != 2)
            {
                errorList.Add(
                    $"Error: Invalid key/value pair argument: {keyValuePair}. Expected 'name=value'"
                );
                continue;
            }

            var key = parts[0].TrimEnd();

            if (!result.TryGetValue(key, out var value))
            {
                value = new List<string>();
                result.Add(key, value);
            }

            var list = (List<string>)value;
            list.Add(parts[1].TrimStart());
        }
    }

    private static Option<string[]> GetAdditionalOption()
    {
        return new Option<string[]>(
            aliases: _additionalOptionAliases,
            description: "An argument to pass to Clang when parsing the input files.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetConfigOption()
    {
        return new Option<string[]>(
            aliases: _configOptionAliases,
            description: "A configuration option that controls how the bindings are generated. Specify 'help' to see the available options.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetDefineMacroOption()
    {
        return new Option<string[]>(
            aliases: _defineMacroOptionAliases,
            description: "Define <macro> to <value> (or 1 if <value> omitted).",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetExcludeOption()
    {
        return new Option<string[]>(
            aliases: _excludeOptionAliases,
            description: "A declaration name to exclude from binding generation.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetFileOption()
    {
        return new Option<string[]>(
            aliases: _fileOptionAliases,
            description: "A file to parse and generate bindings for.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string> GetFileDirectoryOption()
    {
        return new Option<string>(
            aliases: _fileDirectionOptionAliases,
            description: "The base path for files to parse.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<string> GetHeaderOption()
    {
        return new Option<string>(
            aliases: _headerOptionAliases,
            description: "A file which contains the header to prefix every generated file with.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<string[]> GetIncludeOption()
    {
        return new Option<string[]>(
            aliases: _includeOptionAliases,
            description: "A declaration name to include in binding generation.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetIncludeDirectoryOption()
    {
        return new Option<string[]>(
            aliases: _includeDirectoryOptionAliases,
            description: "Add directory to include search path.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string> GetLanguageOption()
    {
        return new Option<string>(
            aliases: _languageOptionAliases,
            description: "Treat subsequent input files as having type <language>.",
            getDefaultValue: () => "c++"
        ).FromAmong("c", "c++");
    }

    private static Option<string> GetLibraryOption()
    {
        return new Option<string>(
            aliases: _libraryOptionAliases,
            description: "The string to use in the DllImport attribute used when generating bindings.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<string> GetMethodClassNameOption()
    {
        return new Option<string>(
            aliases: _methodClassNameOptionAliases,
            description: "The name of the static class that will contain the generated method bindings.",
            getDefaultValue: () => "Methods"
        );
    }

    private static Option<string> GetNamespaceOption()
    {
        return new Option<string>(
            aliases: _namespaceOptionAliases,
            description: "The namespace in which to place the generated bindings.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<string[]> GetNativeTypeNamesStripOption()
    {
        return new Option<string[]>(
            aliases: _nativeTypeNamesStripOptionAliases,
            description: "The contents to strip from the generated NativeTypeName attributes.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<PInvokeGeneratorOutputMode> GetOutputModeOption()
    {
        return new Option<PInvokeGeneratorOutputMode>(
            aliases: _outputModeOptionAliases,
            description: "The mode describing how the information collected from the headers are presented in the resultant bindings.",
            getDefaultValue: () => PInvokeGeneratorOutputMode.CSharp
        );
    }

    private static Option<string> GetOutputOption()
    {
        return new Option<string>(
            aliases: _outputOptionAliases,
            description: "The output location to write the generated bindings to.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<string> GetPrefixStripOption()
    {
        return new Option<string>(
            aliases: _prefixStripOptionAliases,
            description: "The prefix to strip from the generated method bindings.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<string[]> GetRemapOption()
    {
        return new Option<string[]>(
            aliases: _remapOptionAliases,
            description: "A declaration name to be remapped to another name during binding generation.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string> GetStdOption()
    {
        return new Option<string>(
            aliases: _stdOptionAliases,
            description: "Language standard to compile for.",
            getDefaultValue: () => ""
        );
    }

    private static Option<string> GetTestOutputOption()
    {
        return new Option<string>(
            aliases: _testOutputOptionAliases,
            description: "The output location to write the generated tests to.",
            getDefaultValue: () => string.Empty
        );
    }

    private static Option<bool> GetVersionOption()
    {
        return new Option<bool>(
            aliases: _versionOptionAliases,
            description: "Prints the current version information for the tool and its native dependencies."
        )
        {
            Arity = ArgumentArity.Zero
        };
    }

    private static Option<string[]> GetTraverseOption()
    {
        return new Option<string[]>(
            aliases: _traverseOptionAliases,
            description: "A file name included either directly or indirectly by -f that should be traversed during binding generation.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithAccessSpecifierOption()
    {
        return new Option<string[]>(
            aliases: _withAccessSpecifierOptionAliases,
            description: "An access specifier to be used with the given qualified or remapped declaration name during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithAttributeOption()
    {
        return new Option<string[]>(
            aliases: _withAttributeOptionAliases,
            description: "An attribute to be added to the given remapped declaration name during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithCallConvOption()
    {
        return new Option<string[]>(
            aliases: _withCallConvOptionAliases,
            description: "A calling convention to be used for the given declaration during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithClassOption()
    {
        return new Option<string[]>(
            aliases: _withClassOptionAliases,
            description: "A class to be used for the given remapped constant or function declaration name during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithGuidOption()
    {
        return new Option<string[]>(
            aliases: _withGuidOptionAliases,
            description: "A GUID to be used for the given declaration during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithLibraryPathOption()
    {
        return new Option<string[]>(
            aliases: _withLibraryPathOptionAliases,
            description: "A library path to be used for the given declaration during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithManualImportOption()
    {
        return new Option<string[]>(
            aliases: _withManualImportOptionAliases,
            description: "A remapped function name to be treated as a manual import during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithNamespaceOption()
    {
        return new Option<string[]>(
            aliases: _withNamespaceOptionAliases,
            description: "A namespace to be used for the given remapped declaration name during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithSetLastErrorOption()
    {
        return new Option<string[]>(
            aliases: _withSetLastErrorOptionAliases,
            description: "Add the SetLastError=true modifier or SetsSystemLastError attribute to a given DllImport or UnmanagedFunctionPointer. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithSuppressGCTransitionOption()
    {
        return new Option<string[]>(
            aliases: _withSuppressGCTransitionOptionAliases,
            description: "Add the SuppressGCTransition calling convention to a given DllImport or UnmanagedFunctionPointer. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithTransparentStructOption()
    {
        return new Option<string[]>(
            aliases: _withTransparentStructOptionAliases,
            description: "A remapped type name to be treated as a transparent wrapper during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithTypeOption()
    {
        return new Option<string[]>(
            aliases: _withTypeOptionAliases,
            description: "A type to be used for the given enum declaration during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithUsingOption()
    {
        return new Option<string[]>(
            aliases: _withUsingOptionAliases,
            description: "A using directive to be included for the given remapped declaration name during binding generation. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    private static Option<string[]> GetWithPackingOption()
    {
        return new Option<string[]>(
            aliases: _withPackingOptionAliases,
            description: "Overrides the StructLayoutAttribute.Pack property for the given type. Supports wildcards.",
            getDefaultValue: Array.Empty<string>
        )
        {
            AllowMultipleArgumentsPerToken = true
        };
    }

    /// <summary>
    /// Reads the given string array as ClangSharpPInvokeGenerator arguments from a response file.
    /// </summary>
    /// <param name="args">The arguments read from the rsp file.</param>
    /// <param name="directory">The directory in which the rsp file resides.</param>
    /// <returns></returns>
    public ResponseFile ReadResponseFile(IReadOnlyList<string> args, string? directory = null)
    {
        _logger.LogDebug("ClangSharp command line arguments: {0}", string.Join(" ", args));
        var parseResult = new Parser(_rootCommand).Parse(args);
        var additionalArgs =
            parseResult.GetValueForOption(_additionalOption) ?? Array.Empty<string>();
        var configSwitches = parseResult.GetValueForOption(_configOption) ?? Array.Empty<string>();
        var defineMacros = parseResult.GetValueForOption(_defineMacros) ?? Array.Empty<string>();
        var excludedNames = parseResult.GetValueForOption(_excludedNames) ?? Array.Empty<string>();
        var files = parseResult.GetValueForOption(_files) ?? Array.Empty<string>();
        var fileDirectory = parseResult.GetValueForOption(_fileDirectory) ?? "";
        var headerFile = parseResult.GetValueForOption(_headerFile) ?? "";
        var includedNames = parseResult.GetValueForOption(_includedNames) ?? Array.Empty<string>();
        var includeDirectories =
            parseResult.GetValueForOption(_includeDirectories) ?? Array.Empty<string>();
        var language = parseResult.GetValueForOption(_language) ?? "";
        var libraryPath = parseResult.GetValueForOption(_libraryPath) ?? "";
        var methodClassName = parseResult.GetValueForOption(_methodClassName) ?? "";
        var methodPrefixToStrip = parseResult.GetValueForOption(_methodPrefixToStrip) ?? "";
        var nativeTypeNamesToStrip =
            parseResult.GetValueForOption(_nativeTypeNamesToStrip) ?? Array.Empty<string>();
        var namespaceName = parseResult.GetValueForOption(_namespaceName) ?? "";
        var outputLocation = parseResult.GetValueForOption(_outputLocation) ?? "";
        var outputMode = parseResult.GetValueForOption(_outputMode);
        var remappedNameValuePairs =
            parseResult.GetValueForOption(_remappedNameValuePairs) ?? Array.Empty<string>();
        var std = parseResult.GetValueForOption(_std) ?? "";
        var testOutputLocation = parseResult.GetValueForOption(_testOutputLocation) ?? "";
        var traversalNames =
            parseResult.GetValueForOption(_traversalNames) ?? Array.Empty<string>();
        var withAccessSpecifierNameValuePairs =
            parseResult.GetValueForOption(_withAccessSpecifierNameValuePairs)
            ?? Array.Empty<string>();
        var withAttributeNameValuePairs =
            parseResult.GetValueForOption(_withAttributeNameValuePairs) ?? Array.Empty<string>();
        var withCallConvNameValuePairs =
            parseResult.GetValueForOption(_withCallConvNameValuePairs) ?? Array.Empty<string>();
        var withClassNameValuePairs =
            parseResult.GetValueForOption(_withClassNameValuePairs) ?? Array.Empty<string>();
        var withGuidNameValuePairs =
            parseResult.GetValueForOption(_withGuidNameValuePairs) ?? Array.Empty<string>();
        var withLibraryPathNameValuePairs =
            parseResult.GetValueForOption(_withLibraryPathNameValuePairs) ?? Array.Empty<string>();
        var withManualImports =
            parseResult.GetValueForOption(_withManualImports) ?? Array.Empty<string>();
        var withNamespaceNameValuePairs =
            parseResult.GetValueForOption(_withNamespaceNameValuePairs) ?? Array.Empty<string>();
        var withSetLastErrors =
            parseResult.GetValueForOption(_withSetLastErrors) ?? Array.Empty<string>();
        var withSuppressGCTransitions =
            parseResult.GetValueForOption(_withSuppressGCTransitions) ?? Array.Empty<string>();
        var withTransparentStructNameValuePairs =
            parseResult.GetValueForOption(_withTransparentStructNameValuePairs)
            ?? Array.Empty<string>();
        var withTypeNameValuePairs =
            parseResult.GetValueForOption(_withTypeNameValuePairs) ?? Array.Empty<string>();
        var withUsingNameValuePairs =
            parseResult.GetValueForOption(_withUsingNameValuePairs) ?? Array.Empty<string>();
        var withPackingNameValuePairs =
            parseResult.GetValueForOption(_withPackingNameValuePairs) ?? Array.Empty<string>();

        var errorList = new List<string>(parseResult.Errors.Select(x => x.ToString()));

        if (files.Length == 0)
        {
            errorList.Add("Error: No input C/C++ files provided. Use --file or -f");
        }

        if (string.IsNullOrWhiteSpace(namespaceName))
        {
            errorList.Add("Error: No namespace provided. Use --namespace or -n");
        }

        if (string.IsNullOrWhiteSpace(outputLocation))
        {
            errorList.Add("Error: No output file location provided. Use --output or -o");
        }

        ParseKeyValuePairs(
            remappedNameValuePairs,
            errorList,
            out Dictionary<string, string> remappedNames
        );
        ParseKeyValuePairs(
            withAccessSpecifierNameValuePairs,
            errorList,
            out Dictionary<string, AccessSpecifier> withAccessSpecifiers
        );
        ParseKeyValuePairs(
            withAttributeNameValuePairs,
            errorList,
            out Dictionary<string, IReadOnlyList<string>> withAttributes
        );
        ParseKeyValuePairs(
            withCallConvNameValuePairs,
            errorList,
            out Dictionary<string, string> withCallConvs
        );
        ParseKeyValuePairs(
            withClassNameValuePairs,
            errorList,
            out Dictionary<string, string> withClasses
        );
        ParseKeyValuePairs(
            withGuidNameValuePairs,
            errorList,
            out Dictionary<string, Guid> withGuids
        );
        ParseKeyValuePairs(
            withLibraryPathNameValuePairs,
            errorList,
            out Dictionary<string, string> withLibraryPaths
        );
        ParseKeyValuePairs(
            withNamespaceNameValuePairs,
            errorList,
            out Dictionary<string, string> withNamespaces
        );
        ParseKeyValuePairs(
            withTransparentStructNameValuePairs,
            errorList,
            out Dictionary<
                string,
                (string, PInvokeGeneratorTransparentStructKind)
            > withTransparentStructs
        );
        ParseKeyValuePairs(
            withTypeNameValuePairs,
            errorList,
            out Dictionary<string, string> withTypes
        );
        ParseKeyValuePairs(
            withUsingNameValuePairs,
            errorList,
            out Dictionary<string, IReadOnlyList<string>> withUsings
        );
        ParseKeyValuePairs(
            withPackingNameValuePairs,
            errorList,
            out Dictionary<string, string> withPackings
        );

        foreach (var key in withTransparentStructs.Keys)
        {
            remappedNames.Add(key, key);
        }

        var configOptions = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? PInvokeGeneratorConfigurationOptions.None
            : PInvokeGeneratorConfigurationOptions.GenerateUnixTypes;
        var printConfigHelp = false;

        foreach (var configSwitch in configSwitches)
        {
            switch (configSwitch)
            {
                case "?":
                case "h":
                case "help":
                {
                    printConfigHelp = true;
                    break;
                }

                // Codegen Options

                case "compatible-codegen":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GeneratePreviewCode;
                    break;
                }

                case "default-codegen":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GeneratePreviewCode;
                    break;
                }

                case "latest-codegen":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode;
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GeneratePreviewCode;
                    break;
                }

                case "preview-codegen":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateCompatibleCode;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateLatestCode;
                    configOptions |= PInvokeGeneratorConfigurationOptions.GeneratePreviewCode;
                    break;
                }

                // File Options

                case "single-file":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateMultipleFiles;
                    break;
                }

                case "multi-file":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateMultipleFiles;
                    break;
                }

                // Type Options

                case "unix-types":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateUnixTypes;
                    break;
                }

                case "windows-types":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateUnixTypes;
                    break;
                }

                // Exclusion Options

                case "exclude-anonymous-field-helpers":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.ExcludeAnonymousFieldHelpers;
                    break;
                }

                case "exclude-com-proxies":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.ExcludeComProxies;
                    break;
                }

                case "exclude-default-remappings":
                case "no-default-remappings":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.NoDefaultRemappings;
                    break;
                }

                case "exclude-empty-records":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.ExcludeEmptyRecords;
                    break;
                }

                case "exclude-enum-operators":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.ExcludeEnumOperators;
                    break;
                }

                case "exclude-fnptr-codegen":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.ExcludeFnptrCodegen;
                    break;
                }

                case "exclude-funcs-with-body":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.ExcludeFunctionsWithBody;
                    break;
                }

                case "exclude-nint-codegen":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.ExcludeNIntCodegen;
                    break;
                }

                case "exclude-using-statics-for-enums":
                case "dont-use-using-statics-for-enums":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.DontUseUsingStaticsForEnums;
                    break;
                }

                // VTBL Options

                case "explicit-vtbls":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateExplicitVtbls;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateTrimmableVtbls;
                    break;
                }

                case "implicit-vtbls":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateExplicitVtbls;
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateTrimmableVtbls;
                    break;
                }

                case "trimmable-vtbls":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.GenerateExplicitVtbls;
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateTrimmableVtbls;
                    break;
                }

                // Test Options

                case "generate-tests-nunit":
                {
                    if (string.IsNullOrWhiteSpace(testOutputLocation))
                    {
                        errorList.Add(
                            "Error: No test output file location provided. Use --test-output or -to"
                        );
                    }

                    if (
                        configOptions.HasFlag(
                            PInvokeGeneratorConfigurationOptions.GenerateTestsXUnit
                        )
                    )
                    {
                        errorList.Add("Cannot generate both NUnit and XUnit tests.");
                    }
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateTestsNUnit;
                    break;
                }

                case "generate-tests-xunit":
                {
                    if (string.IsNullOrWhiteSpace(testOutputLocation))
                    {
                        errorList.Add(
                            "Error: No test output file location provided. Use --test-output or -to"
                        );
                    }

                    if (
                        configOptions.HasFlag(
                            PInvokeGeneratorConfigurationOptions.GenerateTestsNUnit
                        )
                    )
                    {
                        errorList.Add("Cannot generate both NUnit and XUnit tests.");
                    }
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateTestsXUnit;
                    break;
                }

                // Generation Options

                case "generate-aggressive-inlining":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateAggressiveInlining;
                    break;
                }

                case "generate-cpp-attributes":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateCppAttributes;
                    break;
                }

                case "generate-doc-includes":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateDocIncludes;
                    break;
                }

                case "generate-file-scoped-namespaces":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateFileScopedNamespaces;
                    break;
                }

                case "generate-guid-member":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateGuidMember;
                    break;
                }

                case "generate-helper-types":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateHelperTypes;
                    break;
                }

                case "generate-macro-bindings":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateMacroBindings;
                    break;
                }

                case "generate-marker-interfaces":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateMarkerInterfaces;
                    break;
                }

                case "generate-native-bitfield-attribute":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateNativeBitfieldAttribute;
                    break;
                }

                case "generate-native-inheritance-attribute":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateNativeInheritanceAttribute;
                    break;
                }

                case "generate-setslastsystemerror-attribute":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateSetsLastSystemErrorAttribute;
                    break;
                }

                case "generate-template-bindings":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.GenerateTemplateBindings;
                    break;
                }

                case "generate-unmanaged-constants":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateUnmanagedConstants;
                    break;
                }

                case "generate-vtbl-index-attribute":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.GenerateVtblIndexAttribute;
                    break;
                }

                // Logging Options

                case "log-exclusions":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.LogExclusions;
                    break;
                }

                case "log-potential-typedef-remappings":
                {
                    configOptions |=
                        PInvokeGeneratorConfigurationOptions.LogPotentialTypedefRemappings;
                    break;
                }

                case "log-visited-files":
                {
                    configOptions |= PInvokeGeneratorConfigurationOptions.LogVisitedFiles;
                    break;
                }

                // Legacy Options

                case "default-remappings":
                {
                    configOptions &= ~PInvokeGeneratorConfigurationOptions.NoDefaultRemappings;
                    break;
                }

                default:
                {
                    errorList.Add($"Error: Unrecognized config switch: {configSwitch}.");
                    break;
                }
            }
        }

        if (
            !string.IsNullOrWhiteSpace(testOutputLocation)
            && !configOptions.HasFlag(PInvokeGeneratorConfigurationOptions.GenerateTestsNUnit)
            && !configOptions.HasFlag(PInvokeGeneratorConfigurationOptions.GenerateTestsXUnit)
        )
        {
            errorList.Add(
                "Error: No test format provided. Use --config generate-tests-nunit or --config generate-tests-xunit"
            );
        }

        if (printConfigHelp)
        {
            errorList.Add(
                "Response file contained config ?/h/help option, please consult ClangSharp documentation."
            );
        }

        if (errorList.Count != 0)
        {
            foreach (var error in errorList)
            {
                _logger.LogError($"Error in args for '{files.FirstOrDefault()}': {error}");
            }
        }

        headerFile = Path.GetFullPath(headerFile, directory ?? Environment.CurrentDirectory);
        testOutputLocation = Path.GetFullPath(
            testOutputLocation,
            directory ?? Environment.CurrentDirectory
        );
        outputLocation = Path.GetFullPath(
            outputLocation,
            directory ?? Environment.CurrentDirectory
        );
        for (var i = 0; i < traversalNames.Length; i++)
        {
            traversalNames[i] = Path.GetFullPath(
                traversalNames[i],
                directory ?? Environment.CurrentDirectory
            );
        }

        for (var i = 0; i < includeDirectories.Length; i++)
        {
            includeDirectories[i] = Path.GetFullPath(
                includeDirectories[i],
                directory ?? Environment.CurrentDirectory
            );
        }

        var clangCommandLineArgs = string.IsNullOrWhiteSpace(std)
            ? new string[]
            {
                $"--language={language}", // Treat subsequent input files as having type <language>
                "-Wno-pragma-once-outside-header" // We are processing files which may be header files
            }
            : new string[]
            {
                $"--language={language}", // Treat subsequent input files as having type <language>
                $"--std={std}", // Language standard to compile for
                "-Wno-pragma-once-outside-header" // We are processing files which may be header files
            };

        clangCommandLineArgs = clangCommandLineArgs
            .Concat(includeDirectories.Select(x => "--include-directory=" + x))
            .ToArray();
        clangCommandLineArgs = clangCommandLineArgs
            .Concat(defineMacros.Select(x => "--define-macro=" + x))
            .ToArray();
        clangCommandLineArgs = clangCommandLineArgs.Concat(additionalArgs).ToArray();

        var translationFlags = CXTranslationUnit_None;

        translationFlags |= CXTranslationUnit_IncludeAttributedTypes; // Include attributed types in CXType
        translationFlags |= CXTranslationUnit_VisitImplicitAttributes; // Implicit attributes should be visited

        var config = new PInvokeGeneratorConfiguration(
            language,
            std,
            namespaceName,
            outputLocation,
            headerFile,
            outputMode,
            configOptions
        )
        {
            DefaultClass = methodClassName,
            ExcludedNames = excludedNames,
            IncludedNames = includedNames,
            LibraryPath = libraryPath,
            MethodPrefixToStrip = methodPrefixToStrip,
            NativeTypeNamesToStrip = nativeTypeNamesToStrip,
            RemappedNames = remappedNames,
            TraversalNames = traversalNames,
            TestOutputLocation = testOutputLocation,
            WithAccessSpecifiers = withAccessSpecifiers,
            WithAttributes = withAttributes,
            WithCallConvs = withCallConvs,
            WithClasses = withClasses,
            WithGuids = withGuids,
            WithLibraryPaths = withLibraryPaths,
            WithManualImports = withManualImports,
            WithNamespaces = withNamespaces,
            WithSetLastErrors = withSetLastErrors,
            WithSuppressGCTransitions = withSuppressGCTransitions,
            WithTransparentStructs = withTransparentStructs,
            WithTypes = withTypes,
            WithUsings = withUsings,
            WithPackings = withPackings,
        };

        if (config.GenerateMacroBindings)
        {
            translationFlags |= CXTranslationUnit_DetailedPreprocessingRecord;
        }

        return new ResponseFile(
            errorList,
            config,
            files,
            fileDirectory,
            clangCommandLineArgs,
            translationFlags,
            XxHash64.HashToUInt64(Encoding.UTF8.GetBytes(string.Join('\n',
                args.Select(x => x.Trim().ToLower().Replace('\\', '/')).Where(x => x.Length > 0))))
        );
    }

    /// <summary>
    /// Reads the response files matching the given pattern(s) in the given directory.
    /// </summary>
    /// <param name="directory">The directory in which the patterns are applied.</param>
    /// <param name="globs">The glob patterns used to match rsp files.</param>
    /// <returns>The read response files.</returns>
    /// <exception cref="InvalidOperationException">
    /// If the directory name of the file could not be determined.
    /// </exception>
    public IEnumerable<ResponseFile> ReadResponseFiles(
        string directory,
        IReadOnlyList<string> globs
    )
    {
        _logger.LogDebug(
            "Looking for response files in {0} (we are in {1})",
            directory,
            Environment.CurrentDirectory
        );
        foreach (var rsp in Glob(globs))
        {
            _logger.LogDebug("Reading found file: {0}", rsp);
            var dir =
                Path.GetDirectoryName(rsp)
                ?? throw new InvalidOperationException("Couldn't get directory name of path");
            var read = ReadResponseFile(RspRelativeTo(dir, rsp).ToArray(), dir);
            yield return read with
            {
                FileDirectory = dir
            };
        }
    }

    private IEnumerable<string> RspRelativeTo(string directory, string fullPath)
    {
        _logger.LogTrace("Reading {0}", fullPath);
        foreach (var arg in File.ReadAllLines(fullPath))
        {
            if (string.IsNullOrWhiteSpace(arg))
            {
                continue;
            }

            if (arg[0] == '@')
            {
                var innerRsp = Path.GetFullPath(arg[1..], directory);
                _logger.LogTrace("{0} includes {1}", fullPath, innerRsp);
                foreach (var inner in RspRelativeTo(directory, innerRsp))
                {
                    yield return inner;
                }
            }
            else
            {
                yield return arg;
            }
        }
    }

    internal static IEnumerable<string> Glob(IReadOnlyCollection<string> paths, string? cd = null)
    {
        cd ??= Environment.CurrentDirectory;
        var matcher = new Matcher();
        static string PathFixup(string path)
        {
            if (Path.IsPathFullyQualified(path))
            {
                path = Path.GetRelativePath(Path.GetPathRoot(path)!, path);
            }

            return path.Replace('\\', '/');
        }

        matcher.AddIncludePatterns(paths.Where(x => !x.StartsWith("!")).Select(PathFixup));
        matcher.AddExcludePatterns(
            paths.Where(x => x.StartsWith("!")).Select(x => x[1..]).Select(PathFixup)
        );

        return matcher
            .GetResultsInFullPath(cd)
            .Concat(
                paths
                    .Select(x => x.StartsWith('!') ? x[1..] : x)
                    .Where(Path.IsPathFullyQualified)
                    .Select(Path.GetPathRoot)
                    .Where(x => x is not null)
                    .Distinct()
                    .SelectMany(x => matcher.GetResultsInFullPath(x!))
            )
            .Concat(paths.Where(File.Exists))
            .Select(x => Path.GetFullPath(x).Replace('\\', '/'))
            .Distinct()
            .ToArray();
    }
}
