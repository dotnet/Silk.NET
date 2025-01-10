// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D3D12_RESOLVE_MODE
{
    D3D12_RESOLVE_MODE_DECOMPRESS = 0,
    D3D12_RESOLVE_MODE_MIN = 1,
    D3D12_RESOLVE_MODE_MAX = 2,
    D3D12_RESOLVE_MODE_AVERAGE = 3,
    D3D12_RESOLVE_MODE_ENCODE_SAMPLER_FEEDBACK = 4,
    D3D12_RESOLVE_MODE_DECODE_SAMPLER_FEEDBACK = 5,
}
