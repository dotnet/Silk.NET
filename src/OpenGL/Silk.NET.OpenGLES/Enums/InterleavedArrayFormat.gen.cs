// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "InterleavedArrayFormat")]
    public enum InterleavedArrayFormat : int
    {
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_V2F")]
        V2f = 0x2A20,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_V3F")]
        V3f = 0x2A21,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_C4UB_V2F")]
        C4UBV2f = 0x2A22,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_C4UB_V3F")]
        C4UBV3f = 0x2A23,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_C3F_V3F")]
        C3fV3f = 0x2A24,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_N3F_V3F")]
        N3fV3f = 0x2A25,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_C4F_N3F_V3F")]
        C4fN3fV3f = 0x2A26,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_T2F_V3F")]
        T2fV3f = 0x2A27,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_T4F_V4F")]
        T4fV4f = 0x2A28,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_T2F_C4UB_V3F")]
        T2fC4UBV3f = 0x2A29,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_T2F_C3F_V3F")]
        T2fC3fV3f = 0x2A2A,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_T2F_N3F_V3F")]
        T2fN3fV3f = 0x2A2B,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_T2F_C4F_N3F_V3F")]
        T2fC4fN3fV3f = 0x2A2C,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_T4F_C4F_N3F_V4F")]
        T4fC4fN3fV4f = 0x2A2D,
    }
}
