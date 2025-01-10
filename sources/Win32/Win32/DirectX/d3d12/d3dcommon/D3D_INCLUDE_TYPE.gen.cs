// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D_INCLUDE_TYPE
{
    D3D_INCLUDE_LOCAL = 0,
    D3D_INCLUDE_SYSTEM = (D3D_INCLUDE_LOCAL + 1),
    D3D10_INCLUDE_LOCAL = D3D_INCLUDE_LOCAL,
    D3D10_INCLUDE_SYSTEM = D3D_INCLUDE_SYSTEM,
    D3D_INCLUDE_FORCE_DWORD = 0x7fffffff,
}
