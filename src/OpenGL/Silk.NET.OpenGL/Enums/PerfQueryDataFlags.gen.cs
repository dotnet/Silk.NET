// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PerfQueryDataFlags")]
    public enum PerfQueryDataFlags : int
    {
        [Obsolete("Deprecated in favour of \"DonotFlushIntel\"")]
        [NativeName("Name", "GL_PERFQUERY_DONOT_FLUSH_INTEL")]
        PerfqueryDonotFlushIntel = 0x83F9,
        [Obsolete("Deprecated in favour of \"FlushIntel\"")]
        [NativeName("Name", "GL_PERFQUERY_FLUSH_INTEL")]
        PerfqueryFlushIntel = 0x83FA,
        [Obsolete("Deprecated in favour of \"WaitIntel\"")]
        [NativeName("Name", "GL_PERFQUERY_WAIT_INTEL")]
        PerfqueryWaitIntel = 0x83FB,
        [NativeName("Name", "GL_PERFQUERY_DONOT_FLUSH_INTEL")]
        DonotFlushIntel = 0x83F9,
        [NativeName("Name", "GL_PERFQUERY_FLUSH_INTEL")]
        FlushIntel = 0x83FA,
        [NativeName("Name", "GL_PERFQUERY_WAIT_INTEL")]
        WaitIntel = 0x83FB,
    }
}
