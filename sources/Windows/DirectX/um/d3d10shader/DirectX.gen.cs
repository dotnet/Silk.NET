// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10CompileShader"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10CompileShader([NativeTypeName("LPCSTR")] sbyte* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("const D3D10_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, [NativeTypeName("LPD3D10INCLUDE")] ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pFunctionName, [NativeTypeName("LPCSTR")] sbyte* pProfile, uint Flags, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppShader, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppErrorMsgs);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10DisassembleShader"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10DisassembleShader([NativeTypeName("const void *")] void* pShader, [NativeTypeName("SIZE_T")] nuint BytecodeLength, BOOL EnableColorCode, [NativeTypeName("LPCSTR")] sbyte* pComments, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppDisassembly);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10GetPixelShaderProfile"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    [return: NativeTypeName("LPCSTR")]
    public static extern sbyte* D3D10GetPixelShaderProfile(ID3D10Device* pDevice);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10GetVertexShaderProfile"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    [return: NativeTypeName("LPCSTR")]
    public static extern sbyte* D3D10GetVertexShaderProfile(ID3D10Device* pDevice);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10GetGeometryShaderProfile"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    [return: NativeTypeName("LPCSTR")]
    public static extern sbyte* D3D10GetGeometryShaderProfile(ID3D10Device* pDevice);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10ReflectShader"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10ReflectShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, ID3D10ShaderReflection** ppReflector);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10PreprocessShader"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10PreprocessShader([NativeTypeName("LPCSTR")] sbyte* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pFileName, [NativeTypeName("const D3D10_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, [NativeTypeName("LPD3D10INCLUDE")] ID3DInclude* pInclude, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppShaderText, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppErrorMsgs);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10GetInputSignatureBlob"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10GetInputSignatureBlob([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppSignatureBlob);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10GetOutputSignatureBlob"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10GetOutputSignatureBlob([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppSignatureBlob);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10GetInputAndOutputSignatureBlob"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10GetInputAndOutputSignatureBlob([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppSignatureBlob);
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D10GetShaderDebugInfo"]/*'/>
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10GetShaderDebugInfo([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D10Blob **")] ID3DBlob** ppDebugInfo);
}