using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Silk.NET.SilkTouch.Clang;

namespace Silk.NET.SilkTouch.Workspace;

/// <summary>
/// An <see cref="IOutputWriter"/> that outputs directly to disk.
/// </summary>
public class DirectOutputWriter : IOutputWriter
{
    /// <inheritdoc />
    public async Task OutputAsync(
        string key,
        SilkTouchConfiguration job,
        GeneratedSyntax syntax,
        CancellationToken ct = default
    )
    {
        if (
            !Directory.Exists(job.OutputSourceRoot!)
            && syntax.Files.Keys.Any(x => x.StartsWith("sources/"))
        )
        {
            Directory.CreateDirectory(job.OutputSourceRoot!);
        }
        if (
            !Directory.Exists(job.OutputTestRoot!)
            && syntax.Files.Keys.Any(x => x.StartsWith("tests/"))
        )
        {
            Directory.CreateDirectory(job.OutputTestRoot!);
        }
        foreach (
            var file in Directory.GetFiles(
                job.OutputSourceRoot!,
                "*.gen.cs",
                SearchOption.AllDirectories
            )
        )
        {
            File.Delete(file);
        }
        foreach (
            var file in Directory.GetFiles(
                job.OutputTestRoot!,
                "*.gen.cs",
                SearchOption.AllDirectories
            )
        )
        {
            File.Delete(file);
        }
        await Parallel.ForEachAsync(
            syntax.Files,
            ct,
            async (kvp, token) =>
            {
                if (kvp.Key.StartsWith("sources/"))
                {
                    var fname = Path.Join(job.OutputSourceRoot, kvp.Key[8..]);
                    var dir = Path.GetDirectoryName(fname);
                    if (dir is not null && !Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    await File.WriteAllTextAsync(
                        fname,
                        await kvp.Value.ToNormalisedString(token),
                        token
                    );
                }
                else if (kvp.Key.StartsWith("tests/"))
                {
                    var fname = Path.Join(job.OutputTestRoot, kvp.Key[6..]);
                    var dir = Path.GetDirectoryName(fname);
                    if (dir is not null && !Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    await File.WriteAllTextAsync(
                        fname,
                        await kvp.Value.ToNormalisedString(token),
                        token
                    );
                }
                else
                {
                    // TODO log
                }
            }
        );
    }
}
