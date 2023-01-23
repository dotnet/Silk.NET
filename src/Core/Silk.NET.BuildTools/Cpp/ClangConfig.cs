// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;

namespace Silk.NET.BuildTools.Cpp
{
    public static class ClangConfig
    {
        public static string ForwardSlash(string x) => x.Replace('\\', '/').TrimEnd('/');
        public static void SubstituteWindowsSdkPath(ref BindTask task)
        {
            const string dir = "$windowsSdkDir";
            const string inc = "$windowsSdkIncludes";
            const string ver = "$windowsSdkVersion";
            var needsSubstitution = task.Sources.Any(x => x.Contains(dir)) ||
                                    task.ClangOpts.Traverse.Any(x => x.Contains(dir)) ||
                                    task.ClangOpts.ClangArgs.Any(x => x.Contains(dir) || x.Contains(inc));
            if (!needsSubstitution)
            {
                return;
            }
            
            if (!VisualStudioResolver.TryGetVisualStudioInfo(out var info))
            {
                throw new("Unable to locate Visual Studio installation.");
            }
            
            for (var i = 0; i < task.Sources.Length; i++)
            {
                task.Sources[i] = task.Sources[i]
                    .Replace(dir, ForwardSlash(info.UcrtSdkDir))
                    .Replace(ver, info.UcrtVersion.ToString());
            }
            
            for (var i = 0; i < task.ClangOpts.Traverse.Length; i++)
            {
                task.ClangOpts.Traverse[i] = task.ClangOpts.Traverse[i]
                    .Replace(dir, ForwardSlash(info.UcrtSdkDir))
                    .Replace(ver, info.UcrtVersion.ToString());
            }

            var args = new List<string>(task.ClangOpts.ClangArgs);
            for (var i = 0; i < args.Count; i++)
            {
                if (args[i].Contains(inc))
                {
                    var arg = args[i];
                    args.RemoveAt(i);
                    foreach (var includePath in info.UcrtIncludes.Concat(info.MsvcToolsIncludes))
                    {
                        args.Insert(i, arg.Replace(inc, ForwardSlash(includePath)));
                    }
                }

                args[i] = args[i]
                    .Replace(dir, ForwardSlash(info.UcrtSdkDir))
                    .Replace(ver, info.UcrtVersion.ToString());
            }

            task.ClangOpts = task.ClangOpts with { ClangArgs = args.ToArray() };
        }
    }
}
