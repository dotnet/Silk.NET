// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_DEBUG_DEVICE_GPU_BASED_VALIDATION_SETTINGS
{
    public uint MaxMessagesPerCommandList;
    public D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE DefaultShaderPatchMode;
    public D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS PipelineStateCreateFlags;
}
