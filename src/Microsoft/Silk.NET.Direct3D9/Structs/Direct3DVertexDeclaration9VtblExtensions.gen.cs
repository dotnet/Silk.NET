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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, IDirect3DDevice9** ppDevice) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevice);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDevice<TThis>(this TThis thisVtbl, ref IDirect3DDevice9* ppDevice) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)@this->LpVtbl[3])(@this, ppDevicePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeclaration<TThis>(this TThis thisVtbl, Vertexelement9* pElement, uint* pNumElements) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)@this->LpVtbl[4])(@this, pElement, pNumElements);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeclaration<TThis>(this TThis thisVtbl, Vertexelement9* pElement, ref uint pNumElements) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pNumElementsPtr = &pNumElements)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)@this->LpVtbl[4])(@this, pElement, pNumElementsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeclaration<TThis>(this TThis thisVtbl, ref Vertexelement9 pElement, uint* pNumElements) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Vertexelement9* pElementPtr = &pElement)
        {
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVertexDeclaration9*, Vertexelement9*, uint*, int>)@this->LpVtbl[4])(@this, pElementPtr, pNumElements);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDeclaration<TThis>(this TThis thisVtbl, ref Vertexelement9 pElement, ref uint pNumElements) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeclaration<TThis>(this TThis thisVtbl, Vertexelement9* pElement, Span<uint> pNumElements) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDeclaration(pElement, ref pNumElements.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDeclaration<TThis>(this TThis thisVtbl, Span<Vertexelement9> pElement, uint* pNumElements) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDeclaration(ref pElement.GetPinnableReference(), pNumElements);
    }

    /// <summary>To be documented.</summary>
    public static int GetDeclaration<TThis>(this TThis thisVtbl, Span<Vertexelement9> pElement, Span<uint> pNumElements) where TThis : IComVtbl<IDirect3DVertexDeclaration9>
    {
        var @this = (IDirect3DVertexDeclaration9*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDeclaration(ref pElement.GetPinnableReference(), ref pNumElements.GetPinnableReference());
    }

}
