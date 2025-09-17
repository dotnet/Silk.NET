// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Silk.NET.SilkTouch.Logging
{
    /// <summary>
    /// Default Implementation for ProgressService
    /// </summary>
    internal class ProgressService : IProgressService
    {
        private ConcurrentDictionary<string, (string, string, float)> Progress = [];

#pragma warning disable ST0005 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
        private JobContext _jobContext;

        /// <summary>
        /// creates an instance of <see cref="ProgressService"/>
        /// </summary>
        /// <param name="context">the current job context</param>
        public ProgressService(JobContext context)
        {
            _jobContext = context;
        }
#pragma warning restore ST0005 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.


        /// <inheritdoc/>
        public IEnumerable<KeyValuePair<string, (string, string, float)>> GetAllProgress() => Progress;

        /// <inheritdoc/>
        public (string, string, float) GetCurrentModTaskAndProgress() =>
            Progress.TryGetValue(_jobContext.JobKey ?? string.Empty, out var value)
                ? value
                : (string.Empty, string.Empty, 0);

        /// <inheritdoc/>
        public void RemoveProgress() =>
            Progress.TryRemove(_jobContext.JobKey ?? string.Empty, out _);
        public void SetMod(string mod)
        {
            if (_jobContext.JobKey is null)
            {
                return;
            }

            Progress[_jobContext.JobKey] = (mod, string.Empty, 0);
        }

        /// <inheritdoc/>
        public void SetProgress(float progress)
        {
            if (_jobContext.JobKey is null)
            {
                return;
            }

            if (!Progress.TryGetValue(_jobContext.JobKey, out var value))
            {
                value = (string.Empty,string.Empty, 0);
            }

            Progress[_jobContext.JobKey] = (value.Item1, value.Item2, progress);
        }

        /// <inheritdoc/>
        public void SetTask(string task)
        {
            if (_jobContext.JobKey is null)
            {
                return;
            }

            if (!Progress.TryGetValue(_jobContext.JobKey, out var value))
            {
                value = (string.Empty, string.Empty, 0);
            }

            Progress[_jobContext.JobKey] = (value.Item1, task, 0);
        }
    }
}
