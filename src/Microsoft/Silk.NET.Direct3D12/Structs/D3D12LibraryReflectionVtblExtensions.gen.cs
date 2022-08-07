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

public unsafe static class D3D12LibraryReflectionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3D12LibraryReflection>
    {
        var @this = (ID3D12LibraryReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12LibraryReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12LibraryReflection>
    {
        var @this = (ID3D12LibraryReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12LibraryReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3D12LibraryReflection>
    {
        var @this = (ID3D12LibraryReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12LibraryReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3D12LibraryReflection>
    {
        var @this = (ID3D12LibraryReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12LibraryReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12LibraryReflection>
    {
        var @this = (ID3D12LibraryReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12LibraryReflection*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12LibraryReflection>
    {
        var @this = (ID3D12LibraryReflection*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12LibraryReflection*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, LibraryDesc* pDesc) where TThis : IComVtbl<ID3D12LibraryReflection>
    {
        var @this = (ID3D12LibraryReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12LibraryReflection*, LibraryDesc*, int>)@this->LpVtbl[3])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref LibraryDesc pDesc) where TThis : IComVtbl<ID3D12LibraryReflection>
    {
        var @this = (ID3D12LibraryReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (LibraryDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12LibraryReflection*, LibraryDesc*, int>)@this->LpVtbl[3])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12FunctionReflection* GetFunctionByIndex<TThis>(this TThis thisVtbl, int FunctionIndex) where TThis : IComVtbl<ID3D12LibraryReflection>
    {
        var @this = (ID3D12LibraryReflection*) thisVtbl.AsVtblPtr();
        ID3D12FunctionReflection* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12LibraryReflection*, int, ID3D12FunctionReflection*>)@this->LpVtbl[4])(@this, FunctionIndex);
        return ret;
    }

}
