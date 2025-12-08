using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Silk.NET.SilkTouch;

internal class JobDependencies(Dictionary<string, Type> loadedMods, IServiceProvider sp)
{
    private Dictionary<string, Type> Loaded { get; } = loadedMods;
    private IServiceProvider Services { get; } = sp;

    public class Global<T>(IEnumerable<T> diProvidedInstances) : IJobDependency<T>
    {
        public IEnumerable<T> Get(string? key) => diProvidedInstances;
    }

    public class Mod<T>(JobDependencies deps, IOptionsSnapshot<SilkTouchConfiguration> job)
        : IJobDependency<T>
    {
        public IEnumerable<T> Get(string? key) =>
            job.Get(key).Mods is { Length: > 0 } applicable
                ? applicable
                    .Select(x =>
                        deps.Loaded.TryGetValue(x, out var m) && m.IsAssignableTo(typeof(T))
                            ? deps.Services.GetRequiredService(m)
                            : null
                    )
                    .OfType<T>()
                : [];
    }
}
