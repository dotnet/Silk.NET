// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10CompileShader(
        [NativeTypeName("LPCSTR")] sbyte* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        [NativeTypeName("LPCSTR")] sbyte* pFileName,
        [NativeTypeName("const D3D10_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines,
        [NativeTypeName("LPD3D10INCLUDE")] ID3DInclude* pInclude,
        [NativeTypeName("LPCSTR")] sbyte* pFunctionName,
        [NativeTypeName("LPCSTR")] sbyte* pProfile,
        uint Flags,
        [NativeTypeName("ID3D10Blob **")] ID3DBlob* ppShader,
        [NativeTypeName("ID3D10Blob **")] ID3DBlob* ppErrorMsgs
    );

    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10DisassembleShader(
        [NativeTypeName("const void *")] void* pShader,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        BOOL EnableColorCode,
        [NativeTypeName("LPCSTR")] sbyte* pComments,
        [NativeTypeName("ID3D10Blob **")] ID3DBlob* ppDisassembly
    );

    [DllImport("d3d10", ExactSpelling = true)]
    [return: NativeTypeName("LPCSTR")]
    public static extern sbyte* D3D10GetPixelShaderProfile(ID3D10Device pDevice);

    [DllImport("d3d10", ExactSpelling = true)]
    [return: NativeTypeName("LPCSTR")]
    public static extern sbyte* D3D10GetVertexShaderProfile(ID3D10Device pDevice);

    [DllImport("d3d10", ExactSpelling = true)]
    [return: NativeTypeName("LPCSTR")]
    public static extern sbyte* D3D10GetGeometryShaderProfile(ID3D10Device pDevice);

    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10ReflectShader(
        [NativeTypeName("const void *")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        ID3D10ShaderReflection* ppReflector
    );

    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10PreprocessShader(
        [NativeTypeName("LPCSTR")] sbyte* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        [NativeTypeName("LPCSTR")] sbyte* pFileName,
        [NativeTypeName("const D3D10_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines,
        [NativeTypeName("LPD3D10INCLUDE")] ID3DInclude* pInclude,
        [NativeTypeName("ID3D10Blob **")] ID3DBlob* ppShaderText,
        [NativeTypeName("ID3D10Blob **")] ID3DBlob* ppErrorMsgs
    );

    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10GetInputSignatureBlob(
        [NativeTypeName("const void *")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        [NativeTypeName("ID3D10Blob **")] ID3DBlob* ppSignatureBlob
    );

    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10GetOutputSignatureBlob(
        [NativeTypeName("const void *")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        [NativeTypeName("ID3D10Blob **")] ID3DBlob* ppSignatureBlob
    );

    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10GetInputAndOutputSignatureBlob(
        [NativeTypeName("const void *")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        [NativeTypeName("ID3D10Blob **")] ID3DBlob* ppSignatureBlob
    );

    [DllImport("d3d10", ExactSpelling = true)]
    public static extern HRESULT D3D10GetShaderDebugInfo(
        [NativeTypeName("const void *")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        [NativeTypeName("ID3D10Blob **")] ID3DBlob* ppDebugInfo
    );
}
