// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvSourceLanguage_")]
    public enum SourceLanguage : int
    {
        [NativeName("Name", "SpvSourceLanguageUnknown")]
        Unknown = 0x0,
        [NativeName("Name", "SpvSourceLanguageESSL")]
        Essl = 0x1,
        [NativeName("Name", "SpvSourceLanguageGLSL")]
        Glsl = 0x2,
        [NativeName("Name", "SpvSourceLanguageOpenCL_C")]
        OpenCLC = 0x3,
        [NativeName("Name", "SpvSourceLanguageOpenCL_CPP")]
        OpenCLCpp = 0x4,
        [NativeName("Name", "SpvSourceLanguageHLSL")]
        Hlsl = 0x5,
        [NativeName("Name", "SpvSourceLanguageCPP_for_OpenCL")]
        CppForOpenCL = 0x6,
        [NativeName("Name", "SpvSourceLanguageSYCL")]
        Sycl = 0x7,
        [NativeName("Name", "SpvSourceLanguageMax")]
        Max = 0x7FFFFFFF,
    }
}
