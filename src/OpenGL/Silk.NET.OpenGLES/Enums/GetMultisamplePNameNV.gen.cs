// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "GetMultisamplePNameNV")]
    public enum GetMultisamplePNameNV : int
    {
        [NativeName("Name", "GL_SAMPLE_POSITION")]
        SamplePosition = 0x8E50,
        [NativeName("Name", "GL_SAMPLE_LOCATION_ARB")]
        SampleLocationArb = 0x8E50,
        [NativeName("Name", "GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB")]
        ProgrammableSampleLocationArb = 0x9341,
    }
}
