// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "StringName")]
    public enum StringName
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
