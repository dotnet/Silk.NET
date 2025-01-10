// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DReadFileToBlob(
        [NativeTypeName("LPCWSTR")] ushort* pFileName,
        ID3DBlob* ppContents
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DWriteBlobToFile(
        ID3DBlob pBlob,
        [NativeTypeName("LPCWSTR")] ushort* pFileName,
        BOOL bOverwrite
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCompile(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        [NativeTypeName("LPCSTR")] sbyte* pSourceName,
        [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines,
        ID3DInclude* pInclude,
        [NativeTypeName("LPCSTR")] sbyte* pEntrypoint,
        [NativeTypeName("LPCSTR")] sbyte* pTarget,
        uint Flags1,
        uint Flags2,
        ID3DBlob* ppCode,
        ID3DBlob* ppErrorMsgs
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCompile2(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        [NativeTypeName("LPCSTR")] sbyte* pSourceName,
        [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines,
        ID3DInclude* pInclude,
        [NativeTypeName("LPCSTR")] sbyte* pEntrypoint,
        [NativeTypeName("LPCSTR")] sbyte* pTarget,
        uint Flags1,
        uint Flags2,
        uint SecondaryDataFlags,
        [NativeTypeName("LPCVOID")] void* pSecondaryData,
        [NativeTypeName("SIZE_T")] nuint SecondaryDataSize,
        ID3DBlob* ppCode,
        ID3DBlob* ppErrorMsgs
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCompileFromFile(
        [NativeTypeName("LPCWSTR")] ushort* pFileName,
        [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines,
        ID3DInclude* pInclude,
        [NativeTypeName("LPCSTR")] sbyte* pEntrypoint,
        [NativeTypeName("LPCSTR")] sbyte* pTarget,
        uint Flags1,
        uint Flags2,
        ID3DBlob* ppCode,
        ID3DBlob* ppErrorMsgs
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DPreprocess(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        [NativeTypeName("LPCSTR")] sbyte* pSourceName,
        [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines,
        ID3DInclude* pInclude,
        ID3DBlob* ppCodeText,
        ID3DBlob* ppErrorMsgs
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DGetDebugInfo(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        ID3DBlob* ppDebugInfo
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DReflect(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        [NativeTypeName("const IID &")] Guid* pInterface,
        void** ppReflector
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DReflectLibrary(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppReflector
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DDisassemble(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        uint Flags,
        [NativeTypeName("LPCSTR")] sbyte* szComments,
        ID3DBlob* ppDisassembly
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DDisassembleRegion(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        uint Flags,
        [NativeTypeName("LPCSTR")] sbyte* szComments,
        [NativeTypeName("SIZE_T")] nuint StartByteOffset,
        [NativeTypeName("SIZE_T")] nuint NumInsts,
        [NativeTypeName("SIZE_T *")] nuint* pFinishByteOffset,
        ID3DBlob* ppDisassembly
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCreateLinker(
        [NativeTypeName("struct ID3D11Linker **")] ID3D11Linker* ppLinker
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DLoadModule(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint cbSrcDataSize,
        [NativeTypeName("struct ID3D11Module **")] ID3D11Module* ppModule
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCreateFunctionLinkingGraph(
        uint uFlags,
        [NativeTypeName("struct ID3D11FunctionLinkingGraph **")]
            ID3D11FunctionLinkingGraph* ppFunctionLinkingGraph
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DGetTraceInstructionOffsets(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        uint Flags,
        [NativeTypeName("SIZE_T")] nuint StartInstIndex,
        [NativeTypeName("SIZE_T")] nuint NumInsts,
        [NativeTypeName("SIZE_T *")] nuint* pOffsets,
        [NativeTypeName("SIZE_T *")] nuint* pTotalInsts
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DGetInputSignatureBlob(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        ID3DBlob* ppSignatureBlob
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DGetOutputSignatureBlob(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        ID3DBlob* ppSignatureBlob
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DGetInputAndOutputSignatureBlob(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        ID3DBlob* ppSignatureBlob
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DStripShader(
        [NativeTypeName("LPCVOID")] void* pShaderBytecode,
        [NativeTypeName("SIZE_T")] nuint BytecodeLength,
        uint uStripFlags,
        ID3DBlob* ppStrippedBlob
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DGetBlobPart(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        D3D_BLOB_PART Part,
        uint Flags,
        ID3DBlob* ppPart
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DSetBlobPart(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        D3D_BLOB_PART Part,
        uint Flags,
        [NativeTypeName("LPCVOID")] void* pPart,
        [NativeTypeName("SIZE_T")] nuint PartSize,
        ID3DBlob* ppNewShader
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCreateBlob(
        [NativeTypeName("SIZE_T")] nuint Size,
        ID3DBlob* ppBlob
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCompressShaders(
        uint uNumShaders,
        D3D_SHADER_DATA* pShaderData,
        uint uFlags,
        ID3DBlob* ppCompressedData
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DDecompressShaders(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        uint uNumShaders,
        uint uStartIndex,
        uint* pIndices,
        uint uFlags,
        ID3DBlob* ppShaders,
        uint* pTotalShaders
    );

    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DDisassemble10Effect(
        [NativeTypeName("struct ID3D10Effect *")] ID3D10Effect pEffect,
        uint Flags,
        ID3DBlob* ppDisassembly
    );
}
