// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum D3D_PARAMETER_FLAGS
{
    D3D_PF_NONE = 0,
    D3D_PF_IN = 0x1,
    D3D_PF_OUT = 0x2,
    D3D_PF_FORCE_DWORD = 0x7fffffff,
}
