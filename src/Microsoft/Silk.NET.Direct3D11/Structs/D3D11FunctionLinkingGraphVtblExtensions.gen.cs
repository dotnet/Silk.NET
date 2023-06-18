// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11FunctionLinkingGraphVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateModuleInstance(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11ModuleInstance** ppModuleInstance, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, ppModuleInstance, ppErrorBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInputSignature(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ParameterDesc* pInputParameters, uint cInputParameters, ID3D11LinkingNode** ppInputNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[4])(@this, pInputParameters, cInputParameters, ppInputNode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputSignature(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ParameterDesc* pOutputParameters, uint cOutputParameters, ID3D11LinkingNode** ppOutputNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[5])(@this, pOutputParameters, cOutputParameters, ppOutputNode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValue(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ID3D11LinkingNode* pDstNode, int DstParameterIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)@this->LpVtbl[7])(@this, pSrcNode, SrcParameterIndex, pDstNode, DstParameterIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastError(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[9])(@this, ppErrorBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GenerateHlsl(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[10])(@this, uFlags, ppBuffer);
        return ret;
    }

}
