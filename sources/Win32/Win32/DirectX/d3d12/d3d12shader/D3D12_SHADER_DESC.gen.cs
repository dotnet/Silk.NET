// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_SHADER_DESC
{
    public uint Version;

    [NativeTypeName("LPCSTR")]
    public sbyte* Creator;
    public uint Flags;
    public uint ConstantBuffers;
    public uint BoundResources;
    public uint InputParameters;
    public uint OutputParameters;
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
    public uint CutInstructionCount;
    public uint EmitInstructionCount;
    public D3D_PRIMITIVE_TOPOLOGY GSOutputTopology;
    public uint GSMaxOutputVertexCount;
    public D3D_PRIMITIVE InputPrimitive;
    public uint PatchConstantParameters;
    public uint cGSInstanceCount;
    public uint cControlPoints;
    public D3D_TESSELLATOR_OUTPUT_PRIMITIVE HSOutputPrimitive;
    public D3D_TESSELLATOR_PARTITIONING HSPartitioning;
    public D3D_TESSELLATOR_DOMAIN TessellatorDomain;
    public uint cBarrierInstructions;
    public uint cInterlockedInstructions;
    public uint cTextureStoreInstructions;
}
