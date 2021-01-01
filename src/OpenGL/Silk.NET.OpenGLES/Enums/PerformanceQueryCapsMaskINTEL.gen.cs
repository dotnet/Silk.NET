// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PerformanceQueryCapsMaskINTEL")]
    public enum PerformanceQueryCapsMaskINTEL : int
    {
        [NativeName("Name", "GL_PERFQUERY_SINGLE_CONTEXT_INTEL")]
        PerfquerySingleContextIntel = 0x0,
        [NativeName("Name", "GL_PERFQUERY_GLOBAL_CONTEXT_INTEL")]
        PerfqueryGlobalContextIntel = 0x1,
    }
}
