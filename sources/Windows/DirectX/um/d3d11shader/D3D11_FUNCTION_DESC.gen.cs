// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;

namespace Silk.NET.DirectX;

/// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC"]/*' />
public unsafe partial struct D3D11_FUNCTION_DESC
{
    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.Version"]/*' />
    public uint Version;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.Creator"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* Creator;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.Flags"]/*' />
    public uint Flags;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.ConstantBuffers"]/*' />
    public uint ConstantBuffers;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.BoundResources"]/*' />
    public uint BoundResources;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.InstructionCount"]/*' />
    public uint InstructionCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TempRegisterCount"]/*' />
    public uint TempRegisterCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TempArrayCount"]/*' />
    public uint TempArrayCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.DefCount"]/*' />
    public uint DefCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.DclCount"]/*' />
    public uint DclCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TextureNormalInstructions"]/*' />
    public uint TextureNormalInstructions;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TextureLoadInstructions"]/*' />
    public uint TextureLoadInstructions;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TextureCompInstructions"]/*' />
    public uint TextureCompInstructions;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TextureBiasInstructions"]/*' />
    public uint TextureBiasInstructions;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.TextureGradientInstructions"]/*' />
    public uint TextureGradientInstructions;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.FloatInstructionCount"]/*' />
    public uint FloatInstructionCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.IntInstructionCount"]/*' />
    public uint IntInstructionCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.UintInstructionCount"]/*' />
    public uint UintInstructionCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.StaticFlowControlCount"]/*' />
    public uint StaticFlowControlCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.DynamicFlowControlCount"]/*' />
    public uint DynamicFlowControlCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.MacroInstructionCount"]/*' />
    public uint MacroInstructionCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.ArrayInstructionCount"]/*' />
    public uint ArrayInstructionCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.MovInstructionCount"]/*' />
    public uint MovInstructionCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.MovcInstructionCount"]/*' />
    public uint MovcInstructionCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.ConversionInstructionCount"]/*' />
    public uint ConversionInstructionCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.BitwiseInstructionCount"]/*' />
    public uint BitwiseInstructionCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.MinFeatureLevel"]/*' />
    public D3D_FEATURE_LEVEL MinFeatureLevel;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.RequiredFeatureFlags"]/*' />
    [NativeTypeName("UINT64")]
    public ulong RequiredFeatureFlags;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.Name"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.FunctionParameterCount"]/*' />
    public int FunctionParameterCount;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.HasReturn"]/*' />
    public BOOL HasReturn;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.Has10Level9VertexShader"]/*' />
    public BOOL Has10Level9VertexShader;

    /// <include file='D3D11_FUNCTION_DESC.xml' path='doc/member[@name="D3D11_FUNCTION_DESC.Has10Level9PixelShader"]/*' />
    public BOOL Has10Level9PixelShader;
}
