// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.AMD
{
    [NativeName("Name", "GLenum")]
    public enum AMD
    {
        [NativeName("Name", "GL_RENDERBUFFER_STORAGE_SAMPLES_AMD")]
        RenderbufferStorageSamplesAmd = 0x91B2,
        [NativeName("Name", "GL_MAX_COLOR_FRAMEBUFFER_SAMPLES_AMD")]
        MaxColorFramebufferSamplesAmd = 0x91B3,
        [NativeName("Name", "GL_MAX_COLOR_FRAMEBUFFER_STORAGE_SAMPLES_AMD")]
        MaxColorFramebufferStorageSamplesAmd = 0x91B4,
        [NativeName("Name", "GL_MAX_DEPTH_STENCIL_FRAMEBUFFER_SAMPLES_AMD")]
        MaxDepthStencilFramebufferSamplesAmd = 0x91B5,
        [NativeName("Name", "GL_NUM_SUPPORTED_MULTISAMPLE_MODES_AMD")]
        NumSupportedMultisampleModesAmd = 0x91B6,
        [NativeName("Name", "GL_SUPPORTED_MULTISAMPLE_MODES_AMD")]
        SupportedMultisampleModesAmd = 0x91B7,
        [NativeName("Name", "GL_COUNTER_TYPE_AMD")]
        CounterTypeAmd = 0x8BC0,
        [NativeName("Name", "GL_COUNTER_RANGE_AMD")]
        CounterRangeAmd = 0x8BC1,
        [NativeName("Name", "GL_UNSIGNED_INT64_AMD")]
        UnsignedInt64Amd = 0x8BC2,
        [NativeName("Name", "GL_PERCENTAGE_AMD")]
        PercentageAmd = 0x8BC3,
        [NativeName("Name", "GL_PERFMON_RESULT_AVAILABLE_AMD")]
        PerfmonResultAvailableAmd = 0x8BC4,
        [NativeName("Name", "GL_PERFMON_RESULT_SIZE_AMD")]
        PerfmonResultSizeAmd = 0x8BC5,
        [NativeName("Name", "GL_PERFMON_RESULT_AMD")]
        PerfmonResultAmd = 0x8BC6,
    }
}
