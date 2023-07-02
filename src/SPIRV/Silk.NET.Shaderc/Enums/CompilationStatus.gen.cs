// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Shaderc
{
    [NativeName("AnonymousName", "__AnonymousEnum_status_L23_C9")]
    [NativeName("Name", "shaderc_compilation_status")]
    public enum CompilationStatus : int
    {
        [NativeName("Name", "shaderc_compilation_status_success")]
        Success = 0x0,
        [NativeName("Name", "shaderc_compilation_status_invalid_stage")]
        InvalidStage = 0x1,
        [NativeName("Name", "shaderc_compilation_status_compilation_error")]
        CompilationError = 0x2,
        [NativeName("Name", "shaderc_compilation_status_internal_error")]
        InternalError = 0x3,
        [NativeName("Name", "shaderc_compilation_status_null_result_object")]
        NullResultObject = 0x4,
        [NativeName("Name", "shaderc_compilation_status_invalid_assembly")]
        InvalidAssembly = 0x5,
        [NativeName("Name", "shaderc_compilation_status_validation_error")]
        ValidationError = 0x6,
        [NativeName("Name", "shaderc_compilation_status_transformation_error")]
        TransformationError = 0x7,
        [NativeName("Name", "shaderc_compilation_status_configuration_error")]
        ConfigurationError = 0x8,
    }
}
