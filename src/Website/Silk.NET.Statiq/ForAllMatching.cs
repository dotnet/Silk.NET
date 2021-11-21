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
        private readonly bool _preserve;
        private readonly List<IModule> _filterModules;
        private readonly List<IModule> _executeModules;
        
        /// <summary>
        /// Instantiates the <see cref="ForAllMatching"/> process module.
        /// </summary>
        /// <param name="preserve">
        /// Whether to keep the original documents in the pipeline alongside the output of the executed modules.
        /// </param>
        public ForAllMatching(bool preserve = false)
        {
            _preserve = preserve;
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
            if (_preserve)
            {
                notApplicable = notApplicable.Concat(applicable); // just go with it
            }

            return notApplicable.Concat(await context.ExecuteModulesAsync(_executeModules, applicable));
        }
    }
}
