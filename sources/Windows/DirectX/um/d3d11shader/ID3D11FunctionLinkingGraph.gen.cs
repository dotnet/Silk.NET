// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph"]/*' />
[Guid("54133220-1CE8-43D3-8236-9855C5CEECFF")]
[NativeTypeName("struct ID3D11FunctionLinkingGraph : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11FunctionLinkingGraph : ID3D11FunctionLinkingGraph.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11FunctionLinkingGraph));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, uint>)(lpVtbl[1]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, uint>)(lpVtbl[2]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.CreateModuleInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateModuleInstance([NativeTypeName("struct ID3D11ModuleInstance **")] ID3D11ModuleInstance** ppModuleInstance, ID3DBlob** ppErrorBuffer)
    {
        return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, ID3DBlob**, int>)(lpVtbl[3]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), ppModuleInstance, ppErrorBuffer);
    }

    /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.SetInputSignature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetInputSignature([NativeTypeName("const D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pInputParameters, uint cInputParameters, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppInputNode)
    {
        return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, D3D11_PARAMETER_DESC*, uint, ID3D11LinkingNode**, int>)(lpVtbl[4]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pInputParameters, cInputParameters, ppInputNode);
    }

    /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.SetOutputSignature"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOutputSignature([NativeTypeName("const D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pOutputParameters, uint cOutputParameters, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppOutputNode)
    {
        return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, D3D11_PARAMETER_DESC*, uint, ID3D11LinkingNode**, int>)(lpVtbl[5]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pOutputParameters, cOutputParameters, ppOutputNode);
    }

    /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.CallFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CallFunction([NativeTypeName("LPCSTR")] sbyte* pModuleInstanceNamespace, [NativeTypeName("struct ID3D11Module *")] ID3D11Module* pModuleWithFunctionPrototype, [NativeTypeName("LPCSTR")] sbyte* pFunctionName, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppCallNode)
    {
        return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, sbyte*, ID3D11Module*, sbyte*, ID3D11LinkingNode**, int>)(lpVtbl[6]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
    }

    /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.PassValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT PassValue([NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pDstNode, int DstParameterIndex)
    {
        return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)(lpVtbl[7]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pSrcNode, SrcParameterIndex, pDstNode, DstParameterIndex);
    }

    /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.PassValueWithSwizzle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT PassValueWithSwizzle([NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [NativeTypeName("LPCSTR")] sbyte* pSrcSwizzle, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pDstNode, int DstParameterIndex, [NativeTypeName("LPCSTR")] sbyte* pDstSwizzle)
    {
        return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, sbyte*, ID3D11LinkingNode*, int, sbyte*, int>)(lpVtbl[8]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.GetLastError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetLastError(ID3DBlob** ppErrorBuffer)
    {
        return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3DBlob**, int>)(lpVtbl[9]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), ppErrorBuffer);
    }

    /// <include file='ID3D11FunctionLinkingGraph.xml' path='doc/member[@name="ID3D11FunctionLinkingGraph.GenerateHlsl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GenerateHlsl(uint uFlags, ID3DBlob** ppBuffer)
    {
        return ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, uint, ID3DBlob**, int>)(lpVtbl[10]))((ID3D11FunctionLinkingGraph*)Unsafe.AsPointer(ref this), uFlags, ppBuffer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateModuleInstance([NativeTypeName("struct ID3D11ModuleInstance **")] ID3D11ModuleInstance** ppModuleInstance, ID3DBlob** ppErrorBuffer);

        [VtblIndex(4)]
        HRESULT SetInputSignature([NativeTypeName("const D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pInputParameters, uint cInputParameters, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppInputNode);

        [VtblIndex(5)]
        HRESULT SetOutputSignature([NativeTypeName("const D3D11_PARAMETER_DESC *")] D3D11_PARAMETER_DESC* pOutputParameters, uint cOutputParameters, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppOutputNode);

        [VtblIndex(6)]
        HRESULT CallFunction([NativeTypeName("LPCSTR")] sbyte* pModuleInstanceNamespace, [NativeTypeName("struct ID3D11Module *")] ID3D11Module* pModuleWithFunctionPrototype, [NativeTypeName("LPCSTR")] sbyte* pFunctionName, [NativeTypeName("struct ID3D11LinkingNode **")] ID3D11LinkingNode** ppCallNode);

        [VtblIndex(7)]
        HRESULT PassValue([NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pDstNode, int DstParameterIndex);

        [VtblIndex(8)]
        HRESULT PassValueWithSwizzle([NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [NativeTypeName("LPCSTR")] sbyte* pSrcSwizzle, [NativeTypeName("struct ID3D11LinkingNode *")] ID3D11LinkingNode* pDstNode, int DstParameterIndex, [NativeTypeName("LPCSTR")] sbyte* pDstSwizzle);

        [VtblIndex(9)]
        HRESULT GetLastError(ID3DBlob** ppErrorBuffer);

        [VtblIndex(10)]
        HRESULT GenerateHlsl(uint uFlags, ID3DBlob** ppBuffer);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (struct ID3D11ModuleInstance **, ID3DBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11ModuleInstance**, ID3DBlob**, int> CreateModuleInstance;

        [NativeTypeName("HRESULT (const D3D11_PARAMETER_DESC *, UINT, struct ID3D11LinkingNode **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_PARAMETER_DESC*, uint, ID3D11LinkingNode**, int> SetInputSignature;

        [NativeTypeName("HRESULT (const D3D11_PARAMETER_DESC *, UINT, struct ID3D11LinkingNode **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_PARAMETER_DESC*, uint, ID3D11LinkingNode**, int> SetOutputSignature;

        [NativeTypeName("HRESULT (LPCSTR, struct ID3D11Module *, LPCSTR, struct ID3D11LinkingNode **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D11Module*, sbyte*, ID3D11LinkingNode**, int> CallFunction;

        [NativeTypeName("HRESULT (struct ID3D11LinkingNode *, INT, struct ID3D11LinkingNode *, INT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int> PassValue;

        [NativeTypeName("HRESULT (struct ID3D11LinkingNode *, INT, LPCSTR, struct ID3D11LinkingNode *, INT, LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11LinkingNode*, int, sbyte*, ID3D11LinkingNode*, int, sbyte*, int> PassValueWithSwizzle;

        [NativeTypeName("HRESULT (ID3DBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3DBlob**, int> GetLastError;

        [NativeTypeName("HRESULT (UINT, ID3DBlob **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3DBlob**, int> GenerateHlsl;
    }
}
