// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from cvconst.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CV_HLSLMemorySpace_e
{
    CV_HLSL_MEMSPACE_DATA = 0x00,
    CV_HLSL_MEMSPACE_SAMPLER = 0x01,
    CV_HLSL_MEMSPACE_RESOURCE = 0x02,
    CV_HLSL_MEMSPACE_RWRESOURCE = 0x03,
    CV_HLSL_MEMSPACE_MAX = 0x0F,
}
