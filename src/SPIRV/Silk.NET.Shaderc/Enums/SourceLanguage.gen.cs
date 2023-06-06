// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Shaderc
{
    [NativeName("AnonymousName", "__AnonymousEnum_shaderc_L31_C9")]
    [NativeName("Name", "shaderc_source_language")]
    public enum SourceLanguage : int
    {
        [NativeName("Name", "shaderc_source_language_glsl")]
        Glsl = 0x0,
        [NativeName("Name", "shaderc_source_language_hlsl")]
        Hlsl = 0x1,
    }
}
