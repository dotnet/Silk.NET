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

public unsafe static class D3D12DeviceRemovedExtendedDataSettingsVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedDataSettings>
    {
        var @this = (ID3D12DeviceRemovedExtendedDataSettings*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedDataSettings>
    {
        var @this = (ID3D12DeviceRemovedExtendedDataSettings*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedDataSettings>
    {
        var @this = (ID3D12DeviceRemovedExtendedDataSettings*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedDataSettings>
    {
        var @this = (ID3D12DeviceRemovedExtendedDataSettings*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedDataSettings>
    {
        var @this = (ID3D12DeviceRemovedExtendedDataSettings*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedDataSettings>
    {
        var @this = (ID3D12DeviceRemovedExtendedDataSettings*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static void SetAutoBreadcrumbsEnablement<TThis>(this TThis thisVtbl, DredEnablement Enablement) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedDataSettings>
    {
        var @this = (ID3D12DeviceRemovedExtendedDataSettings*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, DredEnablement, void>)@this->LpVtbl[3])(@this, Enablement);
    }

    /// <summary>To be documented.</summary>
    public static void SetPageFaultEnablement<TThis>(this TThis thisVtbl, DredEnablement Enablement) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedDataSettings>
    {
        var @this = (ID3D12DeviceRemovedExtendedDataSettings*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, DredEnablement, void>)@this->LpVtbl[4])(@this, Enablement);
    }

    /// <summary>To be documented.</summary>
    public static void SetWatsonDumpEnablement<TThis>(this TThis thisVtbl, DredEnablement Enablement) where TThis : IComVtbl<ID3D12DeviceRemovedExtendedDataSettings>
    {
        var @this = (ID3D12DeviceRemovedExtendedDataSettings*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings*, DredEnablement, void>)@this->LpVtbl[5])(@this, Enablement);
    }

}
