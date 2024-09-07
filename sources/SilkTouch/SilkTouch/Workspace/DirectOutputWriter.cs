using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.IO.Hashing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
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
        IEnumerable<string>? existingFiles = null;
        if (syntax.Files.Keys.Any(x => x.StartsWith("sources/")))
        {
            if (!Directory.Exists(job.OutputSourceRoot!))
            {
                Directory.CreateDirectory(job.OutputSourceRoot!);
            }
            else
            {
                existingFiles = Directory.GetFiles(
                    job.OutputSourceRoot!,
                    "*.gen.cs",
                    SearchOption.AllDirectories
                );
            }
        }
        if (syntax.Files.Keys.Any(x => x.StartsWith("tests/")))
        {
            if (!Directory.Exists(job.OutputTestRoot!))
            {
                Directory.CreateDirectory(job.OutputTestRoot!);
            }
            else
            {
                existingFiles =
                    Directory.GetFiles(job.OutputTestRoot!, "*.gen.cs", SearchOption.AllDirectories)
                        is var f
                    && existingFiles is null
                        ? f
                        : f.Concat(existingFiles);
            }
        }

        var existingFileSet = new HashSet<string>(existingFiles ?? Enumerable.Empty<string>());
        var pool = ArrayPool<byte>.Create();
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

                    existingFileSet.Remove(fname);
                    await DiffWriteAsync(fname, kvp.Value, pool, token);
                }
                else if (kvp.Key.StartsWith("tests/"))
                {
                    var fname = Path.Join(job.OutputTestRoot, kvp.Key[6..]);
                    var dir = Path.GetDirectoryName(fname);
                    if (dir is not null && !Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }

                    existingFileSet.Remove(fname);
                    await DiffWriteAsync(fname, kvp.Value, pool, token);
                }
                else
                {
                    // TODO log
                }
            }
        );

        // Delete any stray .gen.cs files.
        foreach (var existing in existingFileSet)
        {
            File.Delete(existing);
        }
    }

    private async Task DiffWriteAsync(
        string fname,
        SyntaxNode node,
        ArrayPool<byte> pool,
        CancellationToken ct
    )
    {
        // SilkTouch thrashes write IO which is slower than just reading and hashing in most cases.
        // It also results in IDE thinking there are changes for unchanged files which also thrashes IO.
        // For this and a slew of other reasons, essentially in 2.X BuildTools was changed to only touch the disk if we
        // actually needed to, which this is the 3.0 equivalent of. This is improved beyond BuildTools as this uses XXH3
        // instead of SHA, which should be faster.
        byte[]? hashBuffer = null;
        Task? existingTask = null;
        if (File.Exists(fname))
        {
            hashBuffer = pool.Rent(16);

            // Fire off the slow existing file hashing as a background task.
            existingTask = File.Exists(fname)
                ? Task.Run(
                    async () =>
                        XxHash3.Hash(
                            await File.ReadAllBytesAsync(fname, ct),
                            hashBuffer.AsSpan()[..8]
                        ),
                    ct
                )
                : Task.CompletedTask;
        }

        // Convert our syntax node to a UTF-8 byte array using CSharpier
        var outputString = await node.ToNormalisedString(ct);
        var byteCount = Encoding.UTF8.GetByteCount(outputString);
        var outputArray = pool.Rent(byteCount);
        Encoding.UTF8.GetBytes(outputString, outputArray);
        if (hashBuffer is not null)
        {
            // Compute the hash of our proposed output
            XxHash3.Hash(outputArray.AsSpan()[..byteCount], hashBuffer.AsSpan()[8..16]);
            await existingTask!; // <-- make sure the background task has finished
        }

        // Output if the hashes differ
        if (
            hashBuffer is null
            || !hashBuffer[..8].AsSpan().SequenceEqual(hashBuffer.AsSpan()[8..16])
        )
        {
            await using var fs = File.Open(fname, FileMode.Create);
            await fs.WriteAsync(outputArray.AsMemory()[..byteCount], ct);
            await fs.FlushAsync(ct);
        }

        // No memory leaks here!
        if (hashBuffer is not null)
        {
            pool.Return(hashBuffer);
        }

        pool.Return(outputArray);
    }
}
