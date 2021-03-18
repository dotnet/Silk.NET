// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "StringName")]
    public enum StringName : int
    {
        [NativeName("Name", "GL_VENDOR")]
        Vendor = 0x1F00,
        [NativeName("Name", "GL_RENDERER")]
        Renderer = 0x1F01,
        [NativeName("Name", "GL_VERSION")]
        Version = 0x1F02,
        [NativeName("Name", "GL_EXTENSIONS")]
        Extensions = 0x1F03,
        [NativeName("Name", "GL_SHADING_LANGUAGE_VERSION")]
        ShadingLanguageVersion = 0x8B8C,
    }
}
