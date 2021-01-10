// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.ARM
{
    [NativeName("Name", "GLenum")]
    public enum ARM : int
    {
        [NativeName("Name", "EGL_COLOR_COMPONENT_TYPE_UNSIGNED_INTEGER_ARM")]
        ColorComponentTypeUnsignedIntegerArm = 0x3287,
        [NativeName("Name", "EGL_COLOR_COMPONENT_TYPE_INTEGER_ARM")]
        ColorComponentTypeIntegerArm = 0x3288,
        [NativeName("Name", "EGL_SYNC_PRIOR_COMMANDS_IMPLICIT_EXTERNAL_ARM")]
        SyncPriorCommandsImplicitExternalArm = 0x328A,
        [NativeName("Name", "EGL_DISCARD_SAMPLES_ARM")]
        DiscardSamplesArm = 0x3286,
    }
}
