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

public unsafe static class Direct3DVertexDeclaration9VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, IDirect3DDevice9** ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, ref IDirect3DDevice9* ppDevice)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeclaration(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, Vertexelement9* pElement, uint* pNumElements)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)@this->LpVtbl[4])(@this, pElement, pNumElements);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeclaration(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, Vertexelement9* pElement, ref uint pNumElements)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pNumElementsPtr = &pNumElements)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)@this->LpVtbl[4])(@this, pElement, pNumElementsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeclaration(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, ref Vertexelement9 pElement, uint* pNumElements)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Vertexelement9* pElementPtr = &pElement)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)@this->LpVtbl[4])(@this, pElementPtr, pNumElements);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeclaration(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, ref Vertexelement9 pElement, ref uint pNumElements)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Vertexelement9* pElementPtr = &pElement)
        {
            fixed (uint* pNumElementsPtr = &pNumElements)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)@this->LpVtbl[4])(@this, pElementPtr, pNumElementsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetDevice<TI0>(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, ref ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<IDirect3DDevice9>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDevice((IDirect3DDevice9**) ppDevice.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeclaration(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, Vertexelement9* pElement, Span<uint> pNumElements)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeclaration(pElement, ref pNumElements.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeclaration(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, Span<Vertexelement9> pElement, uint* pNumElements)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeclaration(ref pElement.GetPinnableReference(), pNumElements);
    }

    /// <summary>To be documented.</summary>
    public static int GetDeclaration(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl, Span<Vertexelement9> pElement, Span<uint> pNumElements)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDeclaration(ref pElement.GetPinnableReference(), ref pNumElements.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDirect3DVertexDeclaration9> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
