// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [Flags]
    [NativeName("Name", "PerformanceQueryCapsMaskINTEL")]
    public enum PerformanceQueryCapsMaskINTEL : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SingleContextIntel\"")]
        [NativeName("Name", "GL_PERFQUERY_SINGLE_CONTEXT_INTEL")]
        PerfquerySingleContextIntel = 0x0,
        [Obsolete("Deprecated in favour of \"GlobalContextIntel\"")]
        [NativeName("Name", "GL_PERFQUERY_GLOBAL_CONTEXT_INTEL")]
        PerfqueryGlobalContextIntel = 0x1,
        [NativeName("Name", "GL_PERFQUERY_SINGLE_CONTEXT_INTEL")]
        SingleContextIntel = 0x0,
        [NativeName("Name", "GL_PERFQUERY_GLOBAL_CONTEXT_INTEL")]
        GlobalContextIntel = 0x1,
    }
}
