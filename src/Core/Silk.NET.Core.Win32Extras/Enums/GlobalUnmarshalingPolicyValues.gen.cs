// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagGLOBALOPT_UNMARSHALING_POLICY_VALUES")]
    public enum GlobalUnmarshalingPolicyValues : int
    {
        [Obsolete("Deprecated in favour of \"Normal\"")]
        [NativeName("Name", "COMGLB_UNMARSHALING_POLICY_NORMAL")]
        ComglbUnmarshalingPolicyNormal = 0x0,
        [Obsolete("Deprecated in favour of \"Strong\"")]
        [NativeName("Name", "COMGLB_UNMARSHALING_POLICY_STRONG")]
        ComglbUnmarshalingPolicyStrong = 0x1,
        [Obsolete("Deprecated in favour of \"Hybrid\"")]
        [NativeName("Name", "COMGLB_UNMARSHALING_POLICY_HYBRID")]
        ComglbUnmarshalingPolicyHybrid = 0x2,
        [NativeName("Name", "COMGLB_UNMARSHALING_POLICY_NORMAL")]
        Normal = 0x0,
        [NativeName("Name", "COMGLB_UNMARSHALING_POLICY_STRONG")]
        Strong = 0x1,
        [NativeName("Name", "COMGLB_UNMARSHALING_POLICY_HYBRID")]
        Hybrid = 0x2,
    }
}
