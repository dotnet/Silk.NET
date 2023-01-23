// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ConditionalRenderMode")]
    public enum ConditionalRenderMode : int
    {
        [Obsolete("Deprecated in favour of \"Wait\"")]
        [NativeName("Name", "GL_QUERY_WAIT")]
        QueryWait = 0x8E13,
        [Obsolete("Deprecated in favour of \"NoWait\"")]
        [NativeName("Name", "GL_QUERY_NO_WAIT")]
        QueryNoWait = 0x8E14,
        [Obsolete("Deprecated in favour of \"ByRegionWait\"")]
        [NativeName("Name", "GL_QUERY_BY_REGION_WAIT")]
        QueryByRegionWait = 0x8E15,
        [Obsolete("Deprecated in favour of \"ByRegionNoWait\"")]
        [NativeName("Name", "GL_QUERY_BY_REGION_NO_WAIT")]
        QueryByRegionNoWait = 0x8E16,
        [Obsolete("Deprecated in favour of \"WaitInverted\"")]
        [NativeName("Name", "GL_QUERY_WAIT_INVERTED")]
        QueryWaitInverted = 0x8E17,
        [Obsolete("Deprecated in favour of \"NoWaitInverted\"")]
        [NativeName("Name", "GL_QUERY_NO_WAIT_INVERTED")]
        QueryNoWaitInverted = 0x8E18,
        [Obsolete("Deprecated in favour of \"ByRegionWaitInverted\"")]
        [NativeName("Name", "GL_QUERY_BY_REGION_WAIT_INVERTED")]
        QueryByRegionWaitInverted = 0x8E19,
        [Obsolete("Deprecated in favour of \"ByRegionNoWaitInverted\"")]
        [NativeName("Name", "GL_QUERY_BY_REGION_NO_WAIT_INVERTED")]
        QueryByRegionNoWaitInverted = 0x8E1A,
        [NativeName("Name", "GL_QUERY_WAIT")]
        Wait = 0x8E13,
        [NativeName("Name", "GL_QUERY_NO_WAIT")]
        NoWait = 0x8E14,
        [NativeName("Name", "GL_QUERY_BY_REGION_WAIT")]
        ByRegionWait = 0x8E15,
        [NativeName("Name", "GL_QUERY_BY_REGION_NO_WAIT")]
        ByRegionNoWait = 0x8E16,
        [NativeName("Name", "GL_QUERY_WAIT_INVERTED")]
        WaitInverted = 0x8E17,
        [NativeName("Name", "GL_QUERY_NO_WAIT_INVERTED")]
        NoWaitInverted = 0x8E18,
        [NativeName("Name", "GL_QUERY_BY_REGION_WAIT_INVERTED")]
        ByRegionWaitInverted = 0x8E19,
        [NativeName("Name", "GL_QUERY_BY_REGION_NO_WAIT_INVERTED")]
        ByRegionNoWaitInverted = 0x8E1A,
    }
}
