// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC"]/*'/>
public unsafe partial struct D3D11_SHADER_DESC
{
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.Version"]/*'/>
    public uint Version;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.Creator"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* Creator;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.Flags"]/*'/>
    public uint Flags;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.ConstantBuffers"]/*'/>
    public uint ConstantBuffers;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.BoundResources"]/*'/>
    public uint BoundResources;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.InputParameters"]/*'/>
    public uint InputParameters;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.OutputParameters"]/*'/>
    public uint OutputParameters;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.InstructionCount"]/*'/>
    public uint InstructionCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TempRegisterCount"]/*'/>
    public uint TempRegisterCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TempArrayCount"]/*'/>
    public uint TempArrayCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.DefCount"]/*'/>
    public uint DefCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.DclCount"]/*'/>
    public uint DclCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TextureNormalInstructions"]/*'/>
    public uint TextureNormalInstructions;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TextureLoadInstructions"]/*'/>
    public uint TextureLoadInstructions;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TextureCompInstructions"]/*'/>
    public uint TextureCompInstructions;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TextureBiasInstructions"]/*'/>
    public uint TextureBiasInstructions;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TextureGradientInstructions"]/*'/>
    public uint TextureGradientInstructions;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.FloatInstructionCount"]/*'/>
    public uint FloatInstructionCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.IntInstructionCount"]/*'/>
    public uint IntInstructionCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.UintInstructionCount"]/*'/>
    public uint UintInstructionCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.StaticFlowControlCount"]/*'/>
    public uint StaticFlowControlCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.DynamicFlowControlCount"]/*'/>
    public uint DynamicFlowControlCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.MacroInstructionCount"]/*'/>
    public uint MacroInstructionCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.ArrayInstructionCount"]/*'/>
    public uint ArrayInstructionCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.CutInstructionCount"]/*'/>
    public uint CutInstructionCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.EmitInstructionCount"]/*'/>
    public uint EmitInstructionCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.GSOutputTopology"]/*'/>
    public D3D_PRIMITIVE_TOPOLOGY GSOutputTopology;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.GSMaxOutputVertexCount"]/*'/>
    public uint GSMaxOutputVertexCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.InputPrimitive"]/*'/>
    public D3D_PRIMITIVE InputPrimitive;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.PatchConstantParameters"]/*'/>
    public uint PatchConstantParameters;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.cGSInstanceCount"]/*'/>
    public uint cGSInstanceCount;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.cControlPoints"]/*'/>
    public uint cControlPoints;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.HSOutputPrimitive"]/*'/>
    public D3D_TESSELLATOR_OUTPUT_PRIMITIVE HSOutputPrimitive;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.HSPartitioning"]/*'/>
    public D3D_TESSELLATOR_PARTITIONING HSPartitioning;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.TessellatorDomain"]/*'/>
    public D3D_TESSELLATOR_DOMAIN TessellatorDomain;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.cBarrierInstructions"]/*'/>
    public uint cBarrierInstructions;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.cInterlockedInstructions"]/*'/>
    public uint cInterlockedInstructions;
    /// <include file='D3D11_SHADER_DESC.xml' path='doc/member[@name="D3D11_SHADER_DESC.cTextureStoreInstructions"]/*'/>
    public uint cTextureStoreInstructions;
}