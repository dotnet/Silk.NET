using System.Linq;
using System.Threading.Tasks;
using CSharpier;
using Microsoft.CodeAnalysis.CSharp;
using SilkTouchX.Clang;

namespace SilkTouchX.Mods;

/// <summary>
/// Formats bindings using CSharpier before output.
/// </summary>
public class CSharpier : IMod
{
    /// <inheritdoc />
    public async Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
    {
        await Parallel.ForEachAsync(
            syntax.Files.Keys,
            async (fname, ct) =>
            {
                var result = await CodeFormatter.FormatAsync(
                    syntax.Files[fname].SyntaxTree,
                    new CodeFormatterOptions(),
                    ct
                );
                if (!result.CompilationErrors.Any())
                {
                    syntax.Files[fname] = await CSharpSyntaxTree
                        .ParseText(result.Code, cancellationToken: ct)
                        .GetRootAsync(ct);
                }
            }
        );
        return syntax;
    }
}
