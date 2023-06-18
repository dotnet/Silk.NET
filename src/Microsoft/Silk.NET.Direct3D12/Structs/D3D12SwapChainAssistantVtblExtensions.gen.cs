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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12SwapChainAssistantVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12SwapChainAssistant> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12SwapChainAssistant> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Luid GetLUID(this ComPtr<ID3D12SwapChainAssistant> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Luid silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        Luid* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Luid*, Luid*>)@this->LpVtbl[3])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSwapChainObject(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentResourceAndCommandQueue(this ComPtr<ID3D12SwapChainAssistant> thisVtbl, Guid* riidResource, void** ppvResource, Guid* riidQueue, void** ppvQueue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, Guid*, void**, Guid*, void**, int>)@this->LpVtbl[5])(@this, riidResource, ppvResource, riidQueue, ppvQueue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InsertImplicitSync(this ComPtr<ID3D12SwapChainAssistant> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12SwapChainAssistant*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

}
