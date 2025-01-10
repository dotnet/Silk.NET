// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS21
{
    public D3D12_WORK_GRAPHS_TIER WorkGraphsTier;
    public D3D12_EXECUTE_INDIRECT_TIER ExecuteIndirectTier;
    public BOOL SampleCmpGradientAndBiasSupported;
    public BOOL ExtendedCommandInfoSupported;
}
