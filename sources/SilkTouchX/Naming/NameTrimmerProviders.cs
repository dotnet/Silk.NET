using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Options;
using SilkTouchX.Mods;

namespace SilkTouchX.Naming;

internal class NameTrimmerProviders
{
    public class Global(
        IEnumerable<INameTrimmer> trimmers,
        IOptionsSnapshot<PrettifyNames.Configuration> cfg
    ) : INameTrimmerProvider
    {
        public IEnumerable<INameTrimmer> GetTrimmers(string? key)
        {
            var baseline = cfg.Get(key).TrimmerBaseline;
            return trimmers.Where(x => x.Version >= baseline);
        }
    }

    public class ModTrimmer<T>(T mod, IOptionsSnapshot<SilkTouchConfiguration> job)
        : INameTrimmerProvider
    {
        public IEnumerable<INameTrimmer> GetTrimmers(string? key) =>
            job.Get(key).Mods?.Contains(typeof(T).Name) ?? false
                ? (
                    mod is INameTrimmer trimmer
                        ? Enumerable.Repeat(trimmer, 1)
                        : Enumerable.Empty<INameTrimmer>()
                )
                    .Concat(
                        mod is INameTrimmerProvider provider
                            ? provider.GetTrimmers(key)
                            : Enumerable.Empty<INameTrimmer>()
                    )
                    .Distinct()
                : Enumerable.Empty<INameTrimmer>();
    }

    public static bool IsModTrimmerApplicable(Type type) =>
        type.IsAssignableTo(typeof(INameTrimmer))
        || type.IsAssignableTo(typeof(INameTrimmerProvider));
}
