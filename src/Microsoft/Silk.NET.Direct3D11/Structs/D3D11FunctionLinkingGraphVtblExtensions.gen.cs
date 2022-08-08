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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateModuleInstance<TThis>(this TThis thisVtbl, ID3D11ModuleInstance** ppModuleInstance, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, ppModuleInstance, ppErrorBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateModuleInstance<TThis>(this TThis thisVtbl, ID3D11ModuleInstance** ppModuleInstance, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, ppModuleInstance, ppErrorBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateModuleInstance<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance* ppModuleInstance, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, ppModuleInstancePtr, ppErrorBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateModuleInstance<TThis>(this TThis thisVtbl, ref ID3D11ModuleInstance* ppModuleInstance, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int SetInputSignature<TThis>(this TThis thisVtbl, ParameterDesc* pInputParameters, uint cInputParameters, ID3D11LinkingNode** ppInputNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[4])(@this, pInputParameters, cInputParameters, ppInputNode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInputSignature<TThis>(this TThis thisVtbl, ParameterDesc* pInputParameters, uint cInputParameters, ref ID3D11LinkingNode* ppInputNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11LinkingNode** ppInputNodePtr = &ppInputNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[4])(@this, pInputParameters, cInputParameters, ppInputNodePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInputSignature<TThis>(this TThis thisVtbl, ref ParameterDesc pInputParameters, uint cInputParameters, ID3D11LinkingNode** ppInputNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ParameterDesc* pInputParametersPtr = &pInputParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[4])(@this, pInputParametersPtr, cInputParameters, ppInputNode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInputSignature<TThis>(this TThis thisVtbl, ref ParameterDesc pInputParameters, uint cInputParameters, ref ID3D11LinkingNode* ppInputNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int SetOutputSignature<TThis>(this TThis thisVtbl, ParameterDesc* pOutputParameters, uint cOutputParameters, ID3D11LinkingNode** ppOutputNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[5])(@this, pOutputParameters, cOutputParameters, ppOutputNode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputSignature<TThis>(this TThis thisVtbl, ParameterDesc* pOutputParameters, uint cOutputParameters, ref ID3D11LinkingNode* ppOutputNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11LinkingNode** ppOutputNodePtr = &ppOutputNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[5])(@this, pOutputParameters, cOutputParameters, ppOutputNodePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputSignature<TThis>(this TThis thisVtbl, ref ParameterDesc pOutputParameters, uint cOutputParameters, ID3D11LinkingNode** ppOutputNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ParameterDesc* pOutputParametersPtr = &pOutputParameters)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[5])(@this, pOutputParametersPtr, cOutputParameters, ppOutputNode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputSignature<TThis>(this TThis thisVtbl, ref ParameterDesc pOutputParameters, uint cOutputParameters, ref ID3D11LinkingNode* ppOutputNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, ref byte pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pFunctionNamePtr = &pFunctionName)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, ref byte pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
        SilkMarshal.Free((nint)pFunctionNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, ref byte pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, ref byte pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, ref byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, ref byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, ref byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, ref byte pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, ref byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, ref byte pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, ref byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, ref byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, ref byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, ref byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, ref byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, ref byte pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, ref byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, ref byte pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, ref byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, ref byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, ref byte pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, ref byte pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
        var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
        SilkMarshal.Free((nint)pFunctionNamePtr);
        SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, ref byte pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, ref byte pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValue<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ID3D11LinkingNode* pDstNode, int DstParameterIndex) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)@this->LpVtbl[7])(@this, pSrcNode, SrcParameterIndex, pDstNode, DstParameterIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValue<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref ID3D11LinkingNode pDstNode, int DstParameterIndex) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)@this->LpVtbl[7])(@this, pSrcNode, SrcParameterIndex, pDstNodePtr, DstParameterIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValue<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ID3D11LinkingNode* pDstNode, int DstParameterIndex) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)@this->LpVtbl[7])(@this, pSrcNodePtr, SrcParameterIndex, pDstNode, DstParameterIndex);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int PassValue<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref ID3D11LinkingNode pDstNode, int DstParameterIndex) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, ref byte pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, ref byte pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, ref byte pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, ref byte pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, ref byte pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
        var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
        SilkMarshal.Free((nint)pDstSwizzlePtr);
        SilkMarshal.Free((nint)pSrcSwizzlePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, ref byte pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, ref byte pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, ref byte pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, ref byte pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, ref byte pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, ref byte pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, ref byte pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
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
    public static unsafe int GetLastError<TThis>(this TThis thisVtbl, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[9])(@this, ppErrorBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLastError<TThis>(this TThis thisVtbl, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[9])(@this, ppErrorBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GenerateHlsl<TThis>(this TThis thisVtbl, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppBuffer) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[10])(@this, uFlags, ppBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GenerateHlsl<TThis>(this TThis thisVtbl, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppBuffer) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Silk.NET.Core.Native.ID3D10Blob** ppBufferPtr = &ppBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[10])(@this, uFlags, ppBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInputSignature<TThis>(this TThis thisVtbl, Span<ParameterDesc> pInputParameters, uint cInputParameters, ID3D11LinkingNode** ppInputNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetInputSignature(ref pInputParameters.GetPinnableReference(), cInputParameters, ppInputNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInputSignature<TThis>(this TThis thisVtbl, Span<ParameterDesc> pInputParameters, uint cInputParameters, ref ID3D11LinkingNode* ppInputNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetInputSignature(ref pInputParameters.GetPinnableReference(), cInputParameters, ref ppInputNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputSignature<TThis>(this TThis thisVtbl, Span<ParameterDesc> pOutputParameters, uint cOutputParameters, ID3D11LinkingNode** ppOutputNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetOutputSignature(ref pOutputParameters.GetPinnableReference(), cOutputParameters, ppOutputNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetOutputSignature<TThis>(this TThis thisVtbl, Span<ParameterDesc> pOutputParameters, uint cOutputParameters, ref ID3D11LinkingNode* ppOutputNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->SetOutputSignature(ref pOutputParameters.GetPinnableReference(), cOutputParameters, ref ppOutputNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, Span<byte> pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, pModuleWithFunctionPrototype, ref pFunctionName.GetPinnableReference(), ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, Span<byte> pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, pModuleWithFunctionPrototype, ref pFunctionName.GetPinnableReference(), ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, Span<byte> pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), ref pFunctionName.GetPinnableReference(), ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, Span<byte> pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), ref pFunctionName.GetPinnableReference(), ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, byte* pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, Span<byte> pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(ref pModuleInstanceNamespace.GetPinnableReference(), pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, Span<byte> pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(ref pModuleInstanceNamespace.GetPinnableReference(), pModuleWithFunctionPrototype, pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, Span<byte> pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, Span<byte> pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(ref pModuleInstanceNamespace.GetPinnableReference(), pModuleWithFunctionPrototype, ref pFunctionName.GetPinnableReference(), ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, Span<byte> pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, Span<byte> pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(ref pModuleInstanceNamespace.GetPinnableReference(), pModuleWithFunctionPrototype, ref pFunctionName.GetPinnableReference(), ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, Span<byte> pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(ref pModuleInstanceNamespace.GetPinnableReference(), pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, Span<byte> pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(ref pModuleInstanceNamespace.GetPinnableReference(), pModuleWithFunctionPrototype, pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, Span<byte> pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(ref pModuleInstanceNamespace.GetPinnableReference(), ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, Span<byte> pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(ref pModuleInstanceNamespace.GetPinnableReference(), ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, Span<byte> pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, Span<byte> pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(ref pModuleInstanceNamespace.GetPinnableReference(), ref pModuleWithFunctionPrototype.GetPinnableReference(), ref pFunctionName.GetPinnableReference(), ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, Span<byte> pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, Span<byte> pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(ref pModuleInstanceNamespace.GetPinnableReference(), ref pModuleWithFunctionPrototype.GetPinnableReference(), ref pFunctionName.GetPinnableReference(), ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, Span<byte> pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(ref pModuleInstanceNamespace.GetPinnableReference(), ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, Span<byte> pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(ref pModuleInstanceNamespace.GetPinnableReference(), ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, Span<byte> pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, pModuleWithFunctionPrototype, ref pFunctionName.GetPinnableReference(), ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, Span<byte> pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, pModuleWithFunctionPrototype, ref pFunctionName.GetPinnableReference(), ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, Span<byte> pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), ref pFunctionName.GetPinnableReference(), ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, Span<byte> pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), ref pFunctionName.GetPinnableReference(), ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CallFunction<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, Span<ID3D11Module> pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->CallFunction(pModuleInstanceNamespace, ref pModuleWithFunctionPrototype.GetPinnableReference(), pFunctionName, ref ppCallNode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValue<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValue(pSrcNode, SrcParameterIndex, ref pDstNode.GetPinnableReference(), DstParameterIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValue<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, ID3D11LinkingNode* pDstNode, int DstParameterIndex) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValue(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pDstNode, DstParameterIndex);
    }

    /// <summary>To be documented.</summary>
    public static int PassValue<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValue(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, ref pDstNode.GetPinnableReference(), DstParameterIndex);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, Span<byte> pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, ref pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, Span<byte> pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, ref pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, Span<byte> pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, ref pSrcSwizzle.GetPinnableReference(), pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, Span<byte> pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, Span<byte> pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, ref pSrcSwizzle.GetPinnableReference(), pDstNode, DstParameterIndex, ref pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, Span<byte> pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, ref pSrcSwizzle.GetPinnableReference(), pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, Span<byte> pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, ref pSrcSwizzle.GetPinnableReference(), ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, Span<byte> pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, Span<byte> pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, ref pSrcSwizzle.GetPinnableReference(), ref pDstNode.GetPinnableReference(), DstParameterIndex, ref pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, Span<byte> pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, ref pSrcSwizzle.GetPinnableReference(), ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, Span<byte> pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, ref pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, Span<byte> pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, ref pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(pSrcNode, SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, Span<byte> pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, ref pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, Span<byte> pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, ref pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, Span<byte> pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, ref pSrcSwizzle.GetPinnableReference(), pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, Span<byte> pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, Span<byte> pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, ref pSrcSwizzle.GetPinnableReference(), pDstNode, DstParameterIndex, ref pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, Span<byte> pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, ref pSrcSwizzle.GetPinnableReference(), pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, Span<byte> pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, ref pSrcSwizzle.GetPinnableReference(), ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, Span<byte> pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, Span<byte> pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, ref pSrcSwizzle.GetPinnableReference(), ref pDstNode.GetPinnableReference(), DstParameterIndex, ref pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, Span<byte> pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, ref pSrcSwizzle.GetPinnableReference(), ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, Span<byte> pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, ref pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, byte* pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, Span<byte> pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, ref pDstSwizzle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int PassValueWithSwizzle<TThis>(this TThis thisVtbl, Span<ID3D11LinkingNode> pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, Span<ID3D11LinkingNode> pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle) where TThis : IComVtbl<ID3D11FunctionLinkingGraph>
    {
        var @this = (ID3D11FunctionLinkingGraph*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->PassValueWithSwizzle(ref pSrcNode.GetPinnableReference(), SrcParameterIndex, pSrcSwizzle, ref pDstNode.GetPinnableReference(), DstParameterIndex, pDstSwizzle);
    }

}
