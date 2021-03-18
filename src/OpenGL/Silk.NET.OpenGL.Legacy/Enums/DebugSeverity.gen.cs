// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "DebugSeverity")]
    public enum DebugSeverity : int
    {
        [NativeName("Name", "GL_DONT_CARE")]
        DontCare = 0x1100,
        [NativeName("Name", "GL_DEBUG_SEVERITY_NOTIFICATION")]
        DebugSeverityNotification = 0x826B,
        [NativeName("Name", "GL_DEBUG_SEVERITY_HIGH")]
        DebugSeverityHigh = 0x9146,
        [NativeName("Name", "GL_DEBUG_SEVERITY_MEDIUM")]
        DebugSeverityMedium = 0x9147,
        [NativeName("Name", "GL_DEBUG_SEVERITY_LOW")]
        DebugSeverityLow = 0x9148,
    }
}
