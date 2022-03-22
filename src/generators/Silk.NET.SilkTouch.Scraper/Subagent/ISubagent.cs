// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Silk.NET.SilkTouch.Scraper.Subagent
{
    /// <summary>
    /// A class capable of creating ClangSharp subprocesses/subagents.
    /// </summary>
    public interface ISubagent
    {
        /// <summary>
        /// Runs a ClangSharp subprocess with the given options. 
        /// </summary>
        /// <param name="opts">The options to run the subagent with.</param>
        /// <param name="errors">A list in which, if provided, errors posted by the subagent will be stored.</param>
        /// <returns>An asynchronous task which, when <c>await</c>ed, yields the exit code of the subprocess.</returns>
        Task<int> RunClangSharpAsync(SubagentOptions opts, List<string>? errors = null);
    }
}
