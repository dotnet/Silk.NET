// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DReadFileToBlob"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DReadFileToBlob([NativeTypeName("LPCWSTR")] ushort* pFileName, ID3DBlob** ppContents);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DWriteBlobToFile"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DWriteBlobToFile(ID3DBlob* pBlob, [NativeTypeName("LPCWSTR")] ushort* pFileName, BOOL bOverwrite);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCompile"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCompile([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pSourceName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, uint Flags1, uint Flags2, ID3DBlob** ppCode, ID3DBlob** ppErrorMsgs);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCompile2"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCompile2([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pSourceName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, uint Flags1, uint Flags2, uint SecondaryDataFlags, [NativeTypeName("LPCVOID")] void* pSecondaryData, [NativeTypeName("SIZE_T")] nuint SecondaryDataSize, ID3DBlob** ppCode, ID3DBlob** ppErrorMsgs);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCompileFromFile"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCompileFromFile([NativeTypeName("LPCWSTR")] ushort* pFileName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, ID3DInclude* pInclude, [NativeTypeName("LPCSTR")] sbyte* pEntrypoint, [NativeTypeName("LPCSTR")] sbyte* pTarget, uint Flags1, uint Flags2, ID3DBlob** ppCode, ID3DBlob** ppErrorMsgs);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPreprocess"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DPreprocess([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("LPCSTR")] sbyte* pSourceName, [NativeTypeName("const D3D_SHADER_MACRO *")] D3D_SHADER_MACRO* pDefines, ID3DInclude* pInclude, ID3DBlob** ppCodeText, ID3DBlob** ppErrorMsgs);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DGetDebugInfo"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DGetDebugInfo([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, ID3DBlob** ppDebugInfo);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DReflect"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DReflect([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("const IID &")] Guid* pInterface, void** ppReflector);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DReflectLibrary"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DReflectLibrary([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppReflector);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DDisassemble"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DDisassemble([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, uint Flags, [NativeTypeName("LPCSTR")] sbyte* szComments, ID3DBlob** ppDisassembly);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DDisassembleRegion"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DDisassembleRegion([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, uint Flags, [NativeTypeName("LPCSTR")] sbyte* szComments, [NativeTypeName("SIZE_T")] nuint StartByteOffset, [NativeTypeName("SIZE_T")] nuint NumInsts, [NativeTypeName("SIZE_T *")] nuint* pFinishByteOffset, ID3DBlob** ppDisassembly);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCreateLinker"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCreateLinker([NativeTypeName("struct ID3D11Linker **")] ID3D11Linker** ppLinker);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DLoadModule"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DLoadModule([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint cbSrcDataSize, [NativeTypeName("struct ID3D11Module **")] ID3D11Module** ppModule);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCreateFunctionLinkingGraph"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCreateFunctionLinkingGraph(uint uFlags, [NativeTypeName("struct ID3D11FunctionLinkingGraph **")] ID3D11FunctionLinkingGraph** ppFunctionLinkingGraph);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DGetTraceInstructionOffsets"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DGetTraceInstructionOffsets([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, uint Flags, [NativeTypeName("SIZE_T")] nuint StartInstIndex, [NativeTypeName("SIZE_T")] nuint NumInsts, [NativeTypeName("SIZE_T *")] nuint* pOffsets, [NativeTypeName("SIZE_T *")] nuint* pTotalInsts);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DGetInputSignatureBlob"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DGetInputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, ID3DBlob** ppSignatureBlob);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DGetOutputSignatureBlob"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DGetOutputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, ID3DBlob** ppSignatureBlob);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DGetInputAndOutputSignatureBlob"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DGetInputAndOutputSignatureBlob([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, ID3DBlob** ppSignatureBlob);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DStripShader"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DStripShader([NativeTypeName("LPCVOID")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, uint uStripFlags, ID3DBlob** ppStrippedBlob);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DGetBlobPart"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DGetBlobPart([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, D3D_BLOB_PART Part, uint Flags, ID3DBlob** ppPart);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DSetBlobPart"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DSetBlobPart([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, D3D_BLOB_PART Part, uint Flags, [NativeTypeName("LPCVOID")] void* pPart, [NativeTypeName("SIZE_T")] nuint PartSize, ID3DBlob** ppNewShader);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCreateBlob"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCreateBlob([NativeTypeName("SIZE_T")] nuint Size, ID3DBlob** ppBlob);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DCompressShaders"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DCompressShaders(uint uNumShaders, D3D_SHADER_DATA* pShaderData, uint uFlags, ID3DBlob** ppCompressedData);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DDecompressShaders"]/*' />
    [DllImport("d3dcompiler_47", ExactSpelling = true)]
    public static extern HRESULT D3DDecompressShaders([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] nuint SrcDataSize, uint uNumShaders, uint uStartIndex, uint* pIndices, uint uFlags, ID3DBlob** ppShaders, uint* pTotalShaders);
}
