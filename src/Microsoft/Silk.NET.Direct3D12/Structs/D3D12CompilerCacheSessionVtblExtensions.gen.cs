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

public unsafe static class D3D12CompilerCacheSessionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3D12CompilerCacheSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3D12CompilerCacheSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFactory(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, Guid* riid, void** ppCompilerFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppCompilerFactory);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFactory(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, Guid* riid, ref void* ppCompilerFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppCompilerFactoryPtr = &ppCompilerFactory)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppCompilerFactoryPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFactory(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, ref Guid riid, void** ppCompilerFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppCompilerFactory);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFactory(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, ref Guid riid, ref void* ppCompilerFactory)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppCompilerFactoryPtr = &ppCompilerFactory)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppCompilerFactoryPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroup(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint* pGroupVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, int>)@this->LpVtbl[4])(@this, pGroupKey, pGroupVersion);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroup(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, ref uint pGroupVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pGroupVersionPtr = &pGroupVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, int>)@this->LpVtbl[4])(@this, pGroupKey, pGroupVersionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroup(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint* pGroupVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, int>)@this->LpVtbl[4])(@this, pGroupKeyPtr, pGroupVersion);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindGroup(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, ref uint pGroupVersion)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
        {
            fixed (uint* pGroupVersionPtr = &pGroupVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, int>)@this->LpVtbl[4])(@this, pGroupKeyPtr, pGroupVersionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKey, pExpectedGroupVersion, CallbackFunc, pContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pContextPtr = &pContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKey, pExpectedGroupVersion, CallbackFunc, pContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKey, pExpectedGroupVersionPtr, CallbackFunc, pContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
        {
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKey, pExpectedGroupVersionPtr, CallbackFunc, pContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, pExpectedGroupVersion, CallbackFunc, pContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
        {
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, pExpectedGroupVersion, CallbackFunc, pContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
        {
            fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, pExpectedGroupVersionPtr, CallbackFunc, pContext);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindGroupValueKeys<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
        {
            fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
            {
                fixed (void* pContextPtr = &pContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, pExpectedGroupVersionPtr, CallbackFunc, pContextPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKey, pExpectedGroupVersion, ValueTypeFlags, CallbackFunc, pContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pContextPtr = &pContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKey, pExpectedGroupVersion, ValueTypeFlags, CallbackFunc, pContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKey, pExpectedGroupVersionPtr, ValueTypeFlags, CallbackFunc, pContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
        {
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKey, pExpectedGroupVersionPtr, ValueTypeFlags, CallbackFunc, pContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, pExpectedGroupVersion, ValueTypeFlags, CallbackFunc, pContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
        {
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, pExpectedGroupVersion, ValueTypeFlags, CallbackFunc, pContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
        {
            fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, pExpectedGroupVersionPtr, ValueTypeFlags, CallbackFunc, pContext);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindGroupValues<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
        {
            fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
            {
                fixed (void* pContextPtr = &pContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, pExpectedGroupVersionPtr, ValueTypeFlags, CallbackFunc, pContextPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, CompilerCacheTypedValue* pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKey, pTypedValues, NumTypedValues, pCallbackFunc, pContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, CompilerCacheTypedValue* pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pContextPtr = &pContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKey, pTypedValues, NumTypedValues, pCallbackFunc, pContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, ref CompilerCacheTypedValue pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheTypedValue* pTypedValuesPtr = &pTypedValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKey, pTypedValuesPtr, NumTypedValues, pCallbackFunc, pContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, ref CompilerCacheTypedValue pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheTypedValue* pTypedValuesPtr = &pTypedValues)
        {
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKey, pTypedValuesPtr, NumTypedValues, pCallbackFunc, pContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKey, CompilerCacheTypedValue* pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheValueKey* pValueKeyPtr = &pValueKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKeyPtr, pTypedValues, NumTypedValues, pCallbackFunc, pContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKey, CompilerCacheTypedValue* pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheValueKey* pValueKeyPtr = &pValueKey)
        {
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKeyPtr, pTypedValues, NumTypedValues, pCallbackFunc, pContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKey, ref CompilerCacheTypedValue pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheValueKey* pValueKeyPtr = &pValueKey)
        {
            fixed (CompilerCacheTypedValue* pTypedValuesPtr = &pTypedValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKeyPtr, pTypedValuesPtr, NumTypedValues, pCallbackFunc, pContext);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindValue<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKey, ref CompilerCacheTypedValue pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, ref T0 pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheValueKey* pValueKeyPtr = &pValueKey)
        {
            fixed (CompilerCacheTypedValue* pTypedValuesPtr = &pTypedValues)
            {
                fixed (void* pContextPtr = &pContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKeyPtr, pTypedValuesPtr, NumTypedValues, pCallbackFunc, pContextPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ApplicationDesc* GetApplicationDesc(this ComPtr<ID3D12CompilerCacheSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ApplicationDesc* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, ApplicationDesc*>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CompilerTarget GetCompilerTarget(this ComPtr<ID3D12CompilerCacheSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        CompilerTarget silkDotNetReturnFixupResult;
        var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
        CompilerTarget* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerTarget*, CompilerTarget*>)@this->LpVtbl[9])(@this, pSilkDotNetReturnFixupResult);
        return *ret;
    }

    /// <summary>To be documented.</summary>
    public static CompilerValueTypeFlags GetValueTypes(this ComPtr<ID3D12CompilerCacheSession> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        CompilerValueTypeFlags ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerValueTypeFlags>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKeys, uint NumValueKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint, CompilerCacheValueKey*, uint, int>)@this->LpVtbl[11])(@this, pGroupKey, GroupVersion, pValueKeys, NumValueKeys);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKeys, uint NumValueKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheValueKey* pValueKeysPtr = &pValueKeys)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint, CompilerCacheValueKey*, uint, int>)@this->LpVtbl[11])(@this, pGroupKey, GroupVersion, pValueKeysPtr, NumValueKeys);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKeys, uint NumValueKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint, CompilerCacheValueKey*, uint, int>)@this->LpVtbl[11])(@this, pGroupKeyPtr, GroupVersion, pValueKeys, NumValueKeys);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StoreGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKeys, uint NumValueKeys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
        {
            fixed (CompilerCacheValueKey* pValueKeysPtr = &pValueKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint, CompilerCacheValueKey*, uint, int>)@this->LpVtbl[11])(@this, pGroupKeyPtr, GroupVersion, pValueKeysPtr, NumValueKeys);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheTypedConstValue* pTypedValues, uint NumTypedValues)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedConstValue*, uint, int>)@this->LpVtbl[12])(@this, pValueKey, pTypedValues, NumTypedValues);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheTypedConstValue pTypedValues, uint NumTypedValues)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheTypedConstValue* pTypedValuesPtr = &pTypedValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedConstValue*, uint, int>)@this->LpVtbl[12])(@this, pValueKey, pTypedValuesPtr, NumTypedValues);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheTypedConstValue* pTypedValues, uint NumTypedValues)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheValueKey* pValueKeyPtr = &pValueKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedConstValue*, uint, int>)@this->LpVtbl[12])(@this, pValueKeyPtr, pTypedValues, NumTypedValues);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int StoreValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheTypedConstValue pTypedValues, uint NumTypedValues)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (CompilerCacheValueKey* pValueKeyPtr = &pValueKey)
        {
            fixed (CompilerCacheTypedConstValue* pTypedValuesPtr = &pTypedValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedConstValue*, uint, int>)@this->LpVtbl[12])(@this, pValueKeyPtr, pTypedValuesPtr, NumTypedValues);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetFactory<TI0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, out ComPtr<TI0> ppCompilerFactory) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppCompilerFactory = default;
        return @this->GetFactory(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerFactory.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFactory(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, Span<Guid> riid, void** ppCompilerFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFactory(ref riid.GetPinnableReference(), ppCompilerFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFactory(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, Span<Guid> riid, ref void* ppCompilerFactory)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFactory(ref riid.GetPinnableReference(), ref ppCompilerFactory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroup(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, Span<uint> pGroupVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroup(pGroupKey, ref pGroupVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroup(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheGroupKey> pGroupKey, uint* pGroupVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroup(in pGroupKey.GetPinnableReference(), pGroupVersion);
    }

    /// <summary>To be documented.</summary>
    public static int FindGroup(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheGroupKey> pGroupKey, Span<uint> pGroupVersion)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroup(in pGroupKey.GetPinnableReference(), ref pGroupVersion.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValueKeys(pGroupKey, pExpectedGroupVersion, CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValueKeys(pGroupKey, in pExpectedGroupVersion.GetPinnableReference(), CallbackFunc, pContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValueKeys(pGroupKey, in pExpectedGroupVersion.GetPinnableReference(), CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheGroupKey> pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValueKeys(in pGroupKey.GetPinnableReference(), pExpectedGroupVersion, CallbackFunc, pContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheGroupKey> pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValueKeys(in pGroupKey.GetPinnableReference(), pExpectedGroupVersion, CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheGroupKey> pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValueKeys(in pGroupKey.GetPinnableReference(), in pExpectedGroupVersion.GetPinnableReference(), CallbackFunc, pContext);
    }

    /// <summary>To be documented.</summary>
    public static int FindGroupValueKeys<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheGroupKey> pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValueKeys(in pGroupKey.GetPinnableReference(), in pExpectedGroupVersion.GetPinnableReference(), CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValues(pGroupKey, pExpectedGroupVersion, ValueTypeFlags, CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValues(pGroupKey, in pExpectedGroupVersion.GetPinnableReference(), ValueTypeFlags, CallbackFunc, pContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValues(pGroupKey, in pExpectedGroupVersion.GetPinnableReference(), ValueTypeFlags, CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheGroupKey> pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValues(in pGroupKey.GetPinnableReference(), pExpectedGroupVersion, ValueTypeFlags, CallbackFunc, pContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheGroupKey> pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValues(in pGroupKey.GetPinnableReference(), pExpectedGroupVersion, ValueTypeFlags, CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindGroupValues(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheGroupKey> pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValues(in pGroupKey.GetPinnableReference(), in pExpectedGroupVersion.GetPinnableReference(), ValueTypeFlags, CallbackFunc, pContext);
    }

    /// <summary>To be documented.</summary>
    public static int FindGroupValues<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheGroupKey> pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindGroupValues(in pGroupKey.GetPinnableReference(), in pExpectedGroupVersion.GetPinnableReference(), ValueTypeFlags, CallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, CompilerCacheTypedValue* pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindValue(pValueKey, pTypedValues, NumTypedValues, pCallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, Span<CompilerCacheTypedValue> pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindValue(pValueKey, ref pTypedValues.GetPinnableReference(), NumTypedValues, pCallbackFunc, pContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, Span<CompilerCacheTypedValue> pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindValue(pValueKey, ref pTypedValues.GetPinnableReference(), NumTypedValues, pCallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheValueKey> pValueKey, CompilerCacheTypedValue* pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindValue(in pValueKey.GetPinnableReference(), pTypedValues, NumTypedValues, pCallbackFunc, pContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheValueKey> pValueKey, CompilerCacheTypedValue* pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindValue(in pValueKey.GetPinnableReference(), pTypedValues, NumTypedValues, pCallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheValueKey> pValueKey, Span<CompilerCacheTypedValue> pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, void* pContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindValue(in pValueKey.GetPinnableReference(), ref pTypedValues.GetPinnableReference(), NumTypedValues, pCallbackFunc, pContext);
    }

    /// <summary>To be documented.</summary>
    public static int FindValue<T0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheValueKey> pValueKey, Span<CompilerCacheTypedValue> pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, Span<T0> pContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindValue(in pValueKey.GetPinnableReference(), ref pTypedValues.GetPinnableReference(), NumTypedValues, pCallbackFunc, ref pContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheValueKey> pValueKeys, uint NumValueKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreGroupValueKeys(pGroupKey, GroupVersion, in pValueKeys.GetPinnableReference(), NumValueKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheGroupKey> pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKeys, uint NumValueKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreGroupValueKeys(in pGroupKey.GetPinnableReference(), GroupVersion, pValueKeys, NumValueKeys);
    }

    /// <summary>To be documented.</summary>
    public static int StoreGroupValueKeys(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheGroupKey> pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheValueKey> pValueKeys, uint NumValueKeys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreGroupValueKeys(in pGroupKey.GetPinnableReference(), GroupVersion, in pValueKeys.GetPinnableReference(), NumValueKeys);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheTypedConstValue> pTypedValues, uint NumTypedValues)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreValue(pValueKey, in pTypedValues.GetPinnableReference(), NumTypedValues);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int StoreValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheValueKey> pValueKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheTypedConstValue* pTypedValues, uint NumTypedValues)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreValue(in pValueKey.GetPinnableReference(), pTypedValues, NumTypedValues);
    }

    /// <summary>To be documented.</summary>
    public static int StoreValue(this ComPtr<ID3D12CompilerCacheSession> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheValueKey> pValueKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompilerCacheTypedConstValue> pTypedValues, uint NumTypedValues)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->StoreValue(in pValueKey.GetPinnableReference(), in pTypedValues.GetPinnableReference(), NumTypedValues);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetFactory<TI0>(this ComPtr<ID3D12CompilerCacheSession> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetFactory(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
