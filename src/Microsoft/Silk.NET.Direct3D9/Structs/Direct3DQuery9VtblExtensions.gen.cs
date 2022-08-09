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

namespace Silk.NET.Direct3D9;

public unsafe static class Direct3DQuery9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, IDirect3DDevice9** ppDevice) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref IDirect3DDevice9* ppDevice) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Querytype GetType<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        Querytype ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, Querytype>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetDataSize<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, uint>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Issue<TThis>(this TThis thisVtbl, uint dwIssueFlags) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, uint, int>)@this->LpVtbl[6])(@this, dwIssueFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData<TThis>(this TThis thisVtbl, void* pData, uint dwSize, uint dwGetDataFlags) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, void*, uint, uint, int>)@this->LpVtbl[7])(@this, pData, dwSize, dwGetDataFlags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetData<T0, TThis>(this TThis thisVtbl, ref T0 pData, uint dwSize, uint dwGetDataFlags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void* pDataPtr = &pData)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DQuery9*, void*, uint, uint, int>)@this->LpVtbl[7])(@this, pDataPtr, dwSize, dwGetDataFlags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0, TThis>(this TThis thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0> where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0, TThis>(this TThis thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0> where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        // ComPtrOverloader
        return @this->GetDevice((IDirect3DDevice9**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetData<T0, TThis>(this TThis thisVtbl, Span<T0> pData, uint dwSize, uint dwGetDataFlags) where T0 : unmanaged where TThis : IComVtbl<IDirect3DQuery9>
    {
        var @this = (IDirect3DQuery9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetData(ref pData.GetPinnableReference(), dwSize, dwGetDataFlags);
    }

}
