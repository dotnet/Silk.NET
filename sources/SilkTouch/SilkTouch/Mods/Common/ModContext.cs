// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Silk.NET.SilkTouch.Mods;

internal class ModContext : IModContext
{
    public required IMod Mod { get; init; }
    public required Task InitGate { get; init; }

    // TODO Parallelize the enumeration of awaitable enumerables instead of using a channel.
    // Essentially, make an IAsyncEnumerable<T> that joins multiple IAsyncEnumerable<T>s and does a WaitAny on all
    // constituents but otherwise acts the same way as the channel currently does, rather than process one enumerable at
    // a time.
    internal abstract record ArtifactDescriptor(
        object? EnumerableOrChannelWriter,
        ModArtifactAccess Mode
    )
    {
        public abstract (object Enumerable, object ChannelWriter) CreateChannel(
            bool manyEnumerable
        );
    }

    internal record ArtifactDescriptor<T>(object? EnumerableOrChannelWriter, ModArtifactAccess Mode)
        : ArtifactDescriptor(EnumerableOrChannelWriter, Mode)
    {
        public override (object Enumerable, object ChannelWriter) CreateChannel(bool manyEnumerable)
        {
            var channel = Channel.CreateUnbounded<IAsyncEnumerable<T>>();
            return (
                manyEnumerable
                    ? new OneToManyArtifactCollection<T>(channel)
                    : OneToOneArtifactCollection(channel),
                channel.Writer
            );
        }
    }

    public static async IAsyncEnumerable<T> OneToOneArtifactCollection<T>(
        Channel<IAsyncEnumerable<T>> artifacts,
        [EnumeratorCancellation] CancellationToken ct = default
    )
    {
        await foreach (var enumerable in artifacts.Reader.ReadAllAsync(ct))
        {
            await foreach (var artifact in enumerable.WithCancellation(ct))
            {
                yield return artifact;
            }
        }
    }

    public class OneToManyArtifactCollection<T>(Channel<IAsyncEnumerable<T>> artifacts)
        : IAsyncEnumerable<T>
    {
        // TODO Actually parallelize the lazy delivery of artifacts to many consumers.
        // This is a dumb implementation that has the first enumerator enumerate the enumerable in its entirety into a
        // list, which is then accessed by all enumerators. Realistically we want a way that:
        // - The underlying channel and its enumerables are only enumerated when one of the enumerators enumerates it.
        // - When the enumeration does happen, it happens on whatever synchronization context that first invoked the
        //   enumeration.
        //     - This is so if ever this framework is reused for a source generator form factor (for more info read the
        //       old 63304c46 version of Proposal - Generation of Library Sources and PInvoke Mechanisms) we can execute
        //       in a way that plays ball with Roslyn's "no threading in a source generator" rule.
        // - When the enumeration is in progress, any additional enumerators that attempt to enumerate will wait for the
        //   first enumeration to conclude, and also return the result generated for that enumeration. i.e. all
        //   enumerators get the same results, even if they're not the one that called the underlying enumerator.
        // So essentially a "broadcast channel" but where the reader executes the channel writing logic if it detects
        // it's not running already. You can see why I didn't do this for the initial release.

        private TaskCompletionSource _tcs = new();
        private int _gate;
        private List<T>? _artifacts;

        public async IAsyncEnumerator<T> GetAsyncEnumerator(
            CancellationToken cancellationToken = default
        )
        {
            if (Interlocked.CompareExchange(ref _gate, 1, 0) == 0)
            {
                _artifacts = [];
                // TODO make a more cancellation-friendly impl
                await foreach (
                    var enumerable in artifacts.Reader.ReadAllAsync(CancellationToken.None)
                )
                {
                    await foreach (
                        var artifact in enumerable.WithCancellation(CancellationToken.None)
                    )
                    {
                        _artifacts.Add(artifact);
                    }
                }

                _tcs.SetResult();
            }

            await _tcs.Task.WaitAsync(cancellationToken);
            foreach (var artifact in _artifacts!)
            {
                yield return artifact;
            }
        }
    }

    public Dictionary<
        Type,
        (ArtifactDescriptor? Inbound, ArtifactDescriptor? Outbound)
    > Artifacts { get; set; } = [];

    public required string JobKey { get; init; }

    public void ProducesArtifacts<T>(
        ModArtifactAccess allowedModes =
            ModArtifactAccess.Exclusive | ModArtifactAccess.Take | ModArtifactAccess.Shared
    )
    {
        ArtifactDescriptor? ib = null,
            ob = null;
        if (Artifacts.TryGetValue(typeof(T), out var desc))
        {
            (ib, ob) = desc;
        }

        if (ob is null)
        {
            if (InitGate.IsCompleted)
            {
                throw new InvalidOperationException(
                    "Cannot make artifact declaration as the mod has already progressed past initialisation."
                );
            }
        }
        else if ((ob.Mode & allowedModes) != allowedModes)
        {
            throw new ArgumentException(
                "Artifact type has already been declared and one or more of the allowed modes was not part of the original declaration.",
                nameof(allowedModes)
            );
        }
        else
        {
            return;
        }

        Artifacts[typeof(T)] = (ib, new ArtifactDescriptor<T>(null, allowedModes));
    }

    public void ReceivesArtifacts<T>(ModArtifactAccess accessMode)
    {
        if (BitOperations.PopCount((uint)accessMode) != 1)
        {
            throw new ArgumentException(
                "Must only use one mode for artifact access.",
                nameof(accessMode)
            );
        }

        ArtifactDescriptor? ib = null,
            ob = null;
        if (Artifacts.TryGetValue(typeof(T), out var desc))
        {
            (ib, ob) = desc;
        }

        if (ib is null)
        {
            if (InitGate.IsCompleted)
            {
                throw new InvalidOperationException(
                    "Cannot make artifact declaration as the mod has already progressed past initialisation."
                );
            }
        }
        else if (ib.Mode != accessMode)
        {
            throw new ArgumentException(
                "Access mode differs from the mode used at declaration time.",
                nameof(accessMode)
            );
        }
        else
        {
            return;
        }

        Artifacts[typeof(T)] = (new ArtifactDescriptor<T>(null, accessMode), ob);
    }

    public async IAsyncEnumerable<T> GetArtifacts<T>(ModArtifactAccess accessMode)
    {
        ReceivesArtifacts<T>(accessMode);
        await InitGate;
        if (
            Artifacts[typeof(T)].Inbound?.EnumerableOrChannelWriter
            is not IAsyncEnumerable<T> enumerable
        )
        {
            yield break;
        }

        var unborrowChannel =
            accessMode == ModArtifactAccess.Exclusive ? Channel.CreateUnbounded<T>() : null;
        if (
            unborrowChannel is not null
            && Artifacts[typeof(T)].Outbound?.EnumerableOrChannelWriter
                is ChannelWriter<IAsyncEnumerable<T>> cw
        )
        {
            await cw.WriteAsync(unborrowChannel.Reader.ReadAllAsync());
        }

        await foreach (var artifact in enumerable)
        {
            yield return artifact;
            if (unborrowChannel is not null)
            {
                await unborrowChannel.Writer.WriteAsync(artifact);
            }
        }
    }

    public void AddArtifacts<T>(
        IAsyncEnumerable<T> artifacts,
        ModArtifactAccess allowedModes =
            ModArtifactAccess.Exclusive | ModArtifactAccess.Take | ModArtifactAccess.Shared
    )
    {
        ProducesArtifacts<T>(allowedModes);
        (
            Artifacts[typeof(T)].Outbound?.EnumerableOrChannelWriter
            as ChannelWriter<IAsyncEnumerable<T>>
        )?.TryWrite(artifacts);
    }
}

class ModPipeline
{
    private TaskCompletionSource _initGate = new();
    public ModContext[] Mods { get; }

    public ModPipeline(string job, IEnumerable<IMod> mods) =>
        Mods = [
            .. mods.Select(x => new ModContext
            {
                Mod = x,
                InitGate = _initGate.Task,
                JobKey = job
            })
        ];

    public async Task ExecuteAsync()
    {
        if (_initGate.Task.IsCompleted)
        {
            throw new InvalidOperationException("This pipeline has already executed.");
        }

        // First, let's initialize all the mods
        foreach (var mod in Mods)
        {
            mod.Mod.Initialize(mod);
        }

        // Now we need to create all the channels between the mods to pass artifacts around.
        // We work backwards i.e. to create the channels and configure the receiving end first, rather than the sending
        // end. This is primarily to make the cases where there are multiple producers before a single consumer easier,
        // as we can just pass those producers the same channel.
        var artifactReceivers =
            new Dictionary<Type, (object ChannelWriter, ModArtifactAccess Mode, ModContext Mod)>();
        for (var i = Mods.Length - 1; i >= 0; i--)
        {
            var mod = Mods[i];
            foreach (var (artifactType, (ib, ob)) in mod.Artifacts)
            {
                // If this mod produces artifacts and we have a receiver for the next mod, then assign that descriptor.
                var (newIb, newOb) = (ib, ob);
                if (ob is not null && artifactReceivers.TryGetValue(artifactType, out var recv))
                {
                    if ((ob.Mode & recv.Mode) != recv.Mode)
                    {
                        throw new NotSupportedException(
                            $"\"{recv.Mod}\" is accessing artifact \"{artifactType.FullName}\" with mode "
                                + $"\"{recv.Mode}\" whereas \"{mod.Mod.GetType().FullName}\" is sending it with "
                                + $"allowable modes \"{ob.Mode}\". These modes are expected to be consistent for a "
                                + $"given artifact type."
                        );
                    }

                    newOb = ob with { EnumerableOrChannelWriter = recv.ChannelWriter };
                }
            }
        }
    }
}
