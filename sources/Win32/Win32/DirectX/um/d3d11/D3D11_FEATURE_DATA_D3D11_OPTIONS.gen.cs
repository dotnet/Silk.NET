// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS
{
    public BOOL OutputMergerLogicOp;
    public BOOL UAVOnlyRenderingForcedSampleCount;
    public BOOL DiscardAPIsSeenByDriver;
    public BOOL FlagsForUpdateAndCopySeenByDriver;
    public BOOL ClearView;
    public BOOL CopyWithOverlap;
    public BOOL ConstantBufferPartialUpdate;
    public BOOL ConstantBufferOffsetting;
    public BOOL MapNoOverwriteOnDynamicConstantBuffer;
    public BOOL MapNoOverwriteOnDynamicBufferSRV;
    public BOOL MultisampleRTVWithForcedSampleCountOne;
    public BOOL SAD4ShaderInstructions;
    public BOOL ExtendedDoublesShaderInstructions;
    public BOOL ExtendedResourceSharing;
}
