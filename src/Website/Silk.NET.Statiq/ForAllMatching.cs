// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Statiq.Common;
using Statiq.Core;

namespace Silk.NET.Statiq
{
    /// <summary>
    /// Similar to a <see cref="ForAllDocuments"/> and <see cref="FilterSources"/> combo, only this keeps the
    /// not applicable documents in the pipeline
    /// </summary>
    public class ForAllMatching : Module
    {
        private readonly List<IModule> _filterModules;
        private readonly List<IModule> _executeModules;
        public ForAllMatching()
        {
            _filterModules = new();
            _executeModules = new();
        }

        public ForAllMatching WithFilterModules(params IModule[] modules)
        {
            _filterModules.AddRange(modules);
            return this;
        }

        public ForAllMatching WithFilterPatterns(params string[] patterns)
            => WithFilterModules(new FilterSources(patterns));

        public ForAllMatching WithExecuteModules(params IModule[] modules)
        {
            _executeModules.AddRange(modules);
            return this;
        }

        protected override async Task<IEnumerable<IDocument>> ExecuteContextAsync(IExecutionContext context)
        {
            var applicable = await context.ExecuteModulesAsync(_filterModules, context.Inputs);
            var notApplicable = context.Inputs.Where(x => !applicable.Contains(x));
            return notApplicable.Concat(await context.ExecuteModulesAsync(_executeModules, applicable));
        }
    }
}
