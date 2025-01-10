// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CV_modifier_e
{
    CV_MOD_INVALID = 0x0000,
    CV_MOD_CONST = 0x0001,
    CV_MOD_VOLATILE = 0x0002,
    CV_MOD_UNALIGNED = 0x0003,
    CV_MOD_HLSL_UNIFORM = 0x0200,
    CV_MOD_HLSL_LINE = 0x0201,
    CV_MOD_HLSL_TRIANGLE = 0x0202,
    CV_MOD_HLSL_LINEADJ = 0x0203,
    CV_MOD_HLSL_TRIANGLEADJ = 0x0204,
    CV_MOD_HLSL_LINEAR = 0x0205,
    CV_MOD_HLSL_CENTROID = 0x0206,
    CV_MOD_HLSL_CONSTINTERP = 0x0207,
    CV_MOD_HLSL_NOPERSPECTIVE = 0x0208,
    CV_MOD_HLSL_SAMPLE = 0x0209,
    CV_MOD_HLSL_CENTER = 0x020a,
    CV_MOD_HLSL_SNORM = 0x020b,
    CV_MOD_HLSL_UNORM = 0x020c,
    CV_MOD_HLSL_PRECISE = 0x020d,
    CV_MOD_HLSL_UAV_GLOBALLY_COHERENT = 0x020e,
}
