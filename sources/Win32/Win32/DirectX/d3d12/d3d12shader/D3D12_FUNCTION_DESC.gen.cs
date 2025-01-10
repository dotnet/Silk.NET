// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_FUNCTION_DESC
{
    public uint Version;

    [NativeTypeName("LPCSTR")]
    public sbyte* Creator;
    public uint Flags;
    public uint ConstantBuffers;
    public uint BoundResources;
    public uint InstructionCount;
    public uint TempRegisterCount;
    public uint TempArrayCount;
    public uint DefCount;
    public uint DclCount;
    public uint TextureNormalInstructions;
    public uint TextureLoadInstructions;
    public uint TextureCompInstructions;
    public uint TextureBiasInstructions;
    public uint TextureGradientInstructions;
    public uint FloatInstructionCount;
    public uint IntInstructionCount;
    public uint UintInstructionCount;
    public uint StaticFlowControlCount;
    public uint DynamicFlowControlCount;
    public uint MacroInstructionCount;
    public uint ArrayInstructionCount;
    public uint MovInstructionCount;
    public uint MovcInstructionCount;
    public uint ConversionInstructionCount;
    public uint BitwiseInstructionCount;
    public D3D_FEATURE_LEVEL MinFeatureLevel;

    [NativeTypeName("UINT64")]
    public ulong RequiredFeatureFlags;

    [NativeTypeName("LPCSTR")]
    public sbyte* Name;
    public int FunctionParameterCount;
    public BOOL HasReturn;
    public BOOL Has10Level9VertexShader;
    public BOOL Has10Level9PixelShader;
}
