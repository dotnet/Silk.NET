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
    public static unsafe int QueryInterface(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
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
    public static unsafe int CreateModuleInstance(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11ModuleInstance** ppModuleInstance, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, ppModuleInstance, ppErrorBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateModuleInstance(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11ModuleInstance* ppModuleInstance, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, ppModuleInstancePtr, ppErrorBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateModuleInstance(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11ModuleInstance* ppModuleInstance, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
        {
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, ppModuleInstancePtr, ppErrorBufferPtr);
            }
        }
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
    public static unsafe int SetInputSignature(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ParameterDesc* pInputParameters, uint cInputParameters, ref ID3D11LinkingNode* ppInputNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode** ppInputNodePtr = &ppInputNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[4])(@this, pInputParameters, cInputParameters, ppInputNodePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInputSignature(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ParameterDesc pInputParameters, uint cInputParameters, ID3D11LinkingNode** ppInputNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ParameterDesc* pInputParametersPtr = &pInputParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[4])(@this, pInputParametersPtr, cInputParameters, ppInputNode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInputSignature(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ParameterDesc pInputParameters, uint cInputParameters, ref ID3D11LinkingNode* ppInputNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ParameterDesc* pInputParametersPtr = &pInputParameters)
        {
            fixed (ID3D11LinkingNode** ppInputNodePtr = &ppInputNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[4])(@this, pInputParametersPtr, cInputParameters, ppInputNodePtr);
            }
        }
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
    public static unsafe int SetOutputSignature(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ParameterDesc* pOutputParameters, uint cOutputParameters, ref ID3D11LinkingNode* ppOutputNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode** ppOutputNodePtr = &ppOutputNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[5])(@this, pOutputParameters, cOutputParameters, ppOutputNodePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputSignature(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ParameterDesc pOutputParameters, uint cOutputParameters, ID3D11LinkingNode** ppOutputNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ParameterDesc* pOutputParametersPtr = &pOutputParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[5])(@this, pOutputParametersPtr, cOutputParameters, ppOutputNode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputSignature(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ParameterDesc pOutputParameters, uint cOutputParameters, ref ID3D11LinkingNode* ppOutputNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ParameterDesc* pOutputParametersPtr = &pOutputParameters)
        {
            fixed (ID3D11LinkingNode** ppOutputNodePtr = &ppOutputNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[5])(@this, pOutputParametersPtr, cOutputParameters, ppOutputNodePtr);
            }
        }
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
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFunctionNamePtr = &pFunctionName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pFunctionNamePtr = &pFunctionName)
        {
            fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
        SilkMarshal.Free((nint)pFunctionNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
        fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
        }
        SilkMarshal.Free((nint)pFunctionNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
            fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNodePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
            fixed (byte* pFunctionNamePtr = &pFunctionName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
            fixed (byte* pFunctionNamePtr = &pFunctionName)
            {
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
        SilkMarshal.Free((nint)pFunctionNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
            }
        SilkMarshal.Free((nint)pFunctionNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
            fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
            fixed (byte* pFunctionNamePtr = &pFunctionName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
            fixed (byte* pFunctionNamePtr = &pFunctionName)
            {
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
        SilkMarshal.Free((nint)pFunctionNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
            }
        SilkMarshal.Free((nint)pFunctionNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNodePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
                fixed (byte* pFunctionNamePtr = &pFunctionName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
                fixed (byte* pFunctionNamePtr = &pFunctionName)
                {
                    fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
        SilkMarshal.Free((nint)pFunctionNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                }
        SilkMarshal.Free((nint)pFunctionNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
        }
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        fixed (byte* pFunctionNamePtr = &pFunctionName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
        }
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        fixed (byte* pFunctionNamePtr = &pFunctionName)
        {
            fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
            }
        }
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
        SilkMarshal.Free((nint)pFunctionNamePtr);
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
        fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
        }
        SilkMarshal.Free((nint)pFunctionNamePtr);
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
        }
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
            fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNodePtr);
            }
        }
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
            fixed (byte* pFunctionNamePtr = &pFunctionName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
            }
        }
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
            fixed (byte* pFunctionNamePtr = &pFunctionName)
            {
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                }
            }
        }
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
        SilkMarshal.Free((nint)pFunctionNamePtr);
        }
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
            }
        SilkMarshal.Free((nint)pFunctionNamePtr);
        }
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
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
    public static unsafe int PassValue(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref ID3D11LinkingNode pDstNode, int DstParameterIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)@this->LpVtbl[7])(@this, pSrcNode, SrcParameterIndex, pDstNodePtr, DstParameterIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValue(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ID3D11LinkingNode* pDstNode, int DstParameterIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)@this->LpVtbl[7])(@this, pSrcNodePtr, SrcParameterIndex, pDstNode, DstParameterIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PassValue(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref ID3D11LinkingNode pDstNode, int DstParameterIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)@this->LpVtbl[7])(@this, pSrcNodePtr, SrcParameterIndex, pDstNodePtr, DstParameterIndex);
            }
        }
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
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
        {
            fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
        {
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
        {
            fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
        {
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
        {
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
        {
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
                fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
        {
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
        fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
        }
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
        fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
        }
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
        fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
        {
            fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            }
        }
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
        fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
        {
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
        }
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
                fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
            {
                fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
            {
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
            {
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
            {
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
                    fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
            {
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            }
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
            }
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
                fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                }
            }
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
            }
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        }
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
    public static unsafe int GetLastError(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[9])(@this, ppErrorBufferPtr);
        }
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

    /// <summary>To be documented.</summary>
    public static unsafe int GenerateHlsl(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppBufferPtr = &ppBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[10])(@this, uFlags, ppBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int CreateModuleInstance<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ComPtr<TI0> ppModuleInstance, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateModuleInstance((ID3D11ModuleInstance**) ppModuleInstance.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateModuleInstance<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ComPtr<TI0> ppModuleInstance, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateModuleInstance((ID3D11ModuleInstance**) ppModuleInstance.GetAddressOf(), ref ppErrorBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateModuleInstance<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11ModuleInstance* ppModuleInstance, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateModuleInstance(ref ppModuleInstance, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInputSignature<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ParameterDesc* pInputParameters, uint cInputParameters, ref ComPtr<TI0> ppInputNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetInputSignature(pInputParameters, cInputParameters, (ID3D11LinkingNode**) ppInputNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInputSignature(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ParameterDesc> pInputParameters, uint cInputParameters, ID3D11LinkingNode** ppInputNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetInputSignature(in pInputParameters.GetPinnableReference(), cInputParameters, ppInputNode);
    }

    /// <summary>To be documented.</summary>
    public static int SetInputSignature<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ParameterDesc pInputParameters, uint cInputParameters, ref ComPtr<TI0> ppInputNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetInputSignature(in pInputParameters, cInputParameters, (ID3D11LinkingNode**) ppInputNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInputSignature(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ParameterDesc> pInputParameters, uint cInputParameters, ref ID3D11LinkingNode* ppInputNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetInputSignature(in pInputParameters.GetPinnableReference(), cInputParameters, ref ppInputNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputSignature<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ParameterDesc* pOutputParameters, uint cOutputParameters, ref ComPtr<TI0> ppOutputNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetOutputSignature(pOutputParameters, cOutputParameters, (ID3D11LinkingNode**) ppOutputNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputSignature(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ParameterDesc> pOutputParameters, uint cOutputParameters, ID3D11LinkingNode** ppOutputNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetOutputSignature(in pOutputParameters.GetPinnableReference(), cOutputParameters, ppOutputNode);
    }

    /// <summary>To be documented.</summary>
    public static int SetOutputSignature<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ParameterDesc pOutputParameters, uint cOutputParameters, ref ComPtr<TI0> ppOutputNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetOutputSignature(in pOutputParameters, cOutputParameters, (ID3D11LinkingNode**) ppOutputNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputSignature(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ParameterDesc> pOutputParameters, uint cOutputParameters, ref ID3D11LinkingNode* ppOutputNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetOutputSignature(in pOutputParameters.GetPinnableReference(), cOutputParameters, ref ppOutputNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ComPtr<TI1> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, pModuleWithFunctionPrototype, in pFunctionName.GetPinnableReference(), ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ComPtr<TI1> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, in pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, pModuleWithFunctionPrototype, in pFunctionName.GetPinnableReference(), ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, in pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ComPtr<TI1> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ComPtr<TI0> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype, pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), in pFunctionName.GetPinnableReference(), ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ComPtr<TI0> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype, in pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), in pFunctionName.GetPinnableReference(), ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ComPtr<TI0> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype, pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(in pModuleInstanceNamespace.GetPinnableReference(), pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ComPtr<TI1> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(in pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(in pModuleInstanceNamespace.GetPinnableReference(), pModuleWithFunctionPrototype, pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(in pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(in pModuleInstanceNamespace.GetPinnableReference(), pModuleWithFunctionPrototype, in pFunctionName.GetPinnableReference(), ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static int CallFunction<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ComPtr<TI1> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(in pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, in pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(in pModuleInstanceNamespace.GetPinnableReference(), pModuleWithFunctionPrototype, in pFunctionName.GetPinnableReference(), ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(in pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, in pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(in pModuleInstanceNamespace.GetPinnableReference(), pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static int CallFunction<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ComPtr<TI1> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(in pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(in pModuleInstanceNamespace.GetPinnableReference(), pModuleWithFunctionPrototype, pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(in pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(in pModuleInstanceNamespace.GetPinnableReference(), ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ComPtr<TI0> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(in pModuleInstanceNamespace, ref pModuleWithFunctionPrototype, pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(in pModuleInstanceNamespace.GetPinnableReference(), ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(in pModuleInstanceNamespace.GetPinnableReference(), ref pModuleWithFunctionPrototype.GetPinnableReference(), in pFunctionName.GetPinnableReference(), ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ComPtr<TI0> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(in pModuleInstanceNamespace, ref pModuleWithFunctionPrototype, in pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(in pModuleInstanceNamespace.GetPinnableReference(), ref pModuleWithFunctionPrototype.GetPinnableReference(), in pFunctionName.GetPinnableReference(), ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(in pModuleInstanceNamespace.GetPinnableReference(), ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ComPtr<TI0> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(in pModuleInstanceNamespace, ref pModuleWithFunctionPrototype, pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(in pModuleInstanceNamespace.GetPinnableReference(), ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ComPtr<TI1> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, pModuleWithFunctionPrototype, in pFunctionName.GetPinnableReference(), ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static int CallFunction<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ComPtr<TI1> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, in pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, pModuleWithFunctionPrototype, in pFunctionName.GetPinnableReference(), ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, in pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static int CallFunction<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ComPtr<TI1> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ComPtr<TI0> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11Module>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, (ID3D11Module*) pModuleWithFunctionPrototype.Handle, pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ComPtr<TI0> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype, pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), in pFunctionName.GetPinnableReference(), ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pFunctionName, ref ComPtr<TI0> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype, in pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), in pFunctionName.GetPinnableReference(), ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static int CallFunction<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ComPtr<TI0> ppCallNode) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype, pFunctionName, (ID3D11LinkingNode**) ppCallNode.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static int PassValue<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, ComPtr<TI1> pDstNode, int DstParameterIndex) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValue((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValue(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValue(pSrcNode, SrcParameterIndex, ref pDstNode.GetPinnableReference(), DstParameterIndex);
    }

    /// <summary>To be documented.</summary>
    public static int PassValue<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, ref ID3D11LinkingNode pDstNode, int DstParameterIndex) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValue((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, ref pDstNode, DstParameterIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValue(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, ID3D11LinkingNode* pDstNode, int DstParameterIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValue(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pDstNode, DstParameterIndex);
    }

    /// <summary>To be documented.</summary>
    public static int PassValue<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ComPtr<TI0> pDstNode, int DstParameterIndex) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValue(ref pSrcNode, SrcParameterIndex, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex);
    }

    /// <summary>To be documented.</summary>
    public static int PassValue(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValue(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, ref pDstNode.GetPinnableReference(), DstParameterIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ComPtr<TI1> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, in pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ComPtr<TI1> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, in pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ComPtr<TI1> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, pSrcSwizzle, ref pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, in pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, pSrcSwizzle, ref pDstNode, DstParameterIndex, in pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, pSrcSwizzle, ref pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, in pSrcSwizzle.GetPinnableReference(), pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ComPtr<TI1> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, in pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, in pSrcSwizzle.GetPinnableReference(), pDstNode, DstParameterIndex, in pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ComPtr<TI1> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, in pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, in pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, in pSrcSwizzle.GetPinnableReference(), pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ComPtr<TI1> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, in pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, in pSrcSwizzle.GetPinnableReference(), ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, in pSrcSwizzle, ref pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, in pSrcSwizzle.GetPinnableReference(), ref pDstNode.GetPinnableReference(), DstParameterIndex, in pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, in pSrcSwizzle, ref pDstNode, DstParameterIndex, in pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, in pSrcSwizzle.GetPinnableReference(), ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, in pSrcSwizzle, ref pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ComPtr<TI1> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, in pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ComPtr<TI1> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, in pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TI0, TI1>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ComPtr<TI1> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, pSrcSwizzle, ref pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, in pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, pSrcSwizzle, ref pDstNode, DstParameterIndex, in pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ComPtr<TI0> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle((ID3D11LinkingNode*) pSrcNode.Handle, SrcParameterIndex, pSrcSwizzle, ref pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ComPtr<TI0> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode, SrcParameterIndex, pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, in pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ComPtr<TI0> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode, SrcParameterIndex, pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, in pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ComPtr<TI0> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode, SrcParameterIndex, pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, in pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, in pSrcSwizzle.GetPinnableReference(), pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ComPtr<TI0> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode, SrcParameterIndex, in pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, in pSrcSwizzle.GetPinnableReference(), pDstNode, DstParameterIndex, in pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ComPtr<TI0> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode, SrcParameterIndex, in pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, in pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, in pSrcSwizzle.GetPinnableReference(), pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrcSwizzle, ComPtr<TI0> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode, SrcParameterIndex, in pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, in pSrcSwizzle.GetPinnableReference(), ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, in pSrcSwizzle.GetPinnableReference(), ref pDstNode.GetPinnableReference(), DstParameterIndex, in pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, in pSrcSwizzle.GetPinnableReference(), ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ComPtr<TI0> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode, SrcParameterIndex, pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, in pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ComPtr<TI0> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode, SrcParameterIndex, pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, in pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ComPtr<TI0> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TI0 : unmanaged, IComVtbl<ID3D11LinkingNode>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode, SrcParameterIndex, pSrcSwizzle, (ID3D11LinkingNode*) pDstNode.Handle, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, in pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static int GetLastError<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetLastError((Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GenerateHlsl<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl, uint uFlags, ref ComPtr<TI0> ppBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GenerateHlsl(uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D11FunctionLinkingGraph> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
