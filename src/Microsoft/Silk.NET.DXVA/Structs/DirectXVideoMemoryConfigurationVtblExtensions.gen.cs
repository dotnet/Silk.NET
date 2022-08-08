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

namespace Silk.NET.DXVA;

public unsafe static class DirectXVideoMemoryConfigurationVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoMemoryConfiguration>
    {
        var @this = (IDirectXVideoMemoryConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoMemoryConfiguration>
    {
        var @this = (IDirectXVideoMemoryConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoMemoryConfiguration>
    {
        var @this = (IDirectXVideoMemoryConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoMemoryConfiguration>
    {
        var @this = (IDirectXVideoMemoryConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirectXVideoMemoryConfiguration>
    {
        var @this = (IDirectXVideoMemoryConfiguration*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDirectXVideoMemoryConfiguration>
    {
        var @this = (IDirectXVideoMemoryConfiguration*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableSurfaceTypeByIndex<TThis>(this TThis thisVtbl, uint dwTypeIndex, MIDLMIDLItfDxva2api000000060001* pdwType) where TThis : IComVtbl<IDirectXVideoMemoryConfiguration>
    {
        var @this = (IDirectXVideoMemoryConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, uint, MIDLMIDLItfDxva2api000000060001*, int>)@this->LpVtbl[3])(@this, dwTypeIndex, pdwType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetAvailableSurfaceTypeByIndex<TThis>(this TThis thisVtbl, uint dwTypeIndex, ref MIDLMIDLItfDxva2api000000060001 pdwType) where TThis : IComVtbl<IDirectXVideoMemoryConfiguration>
    {
        var @this = (IDirectXVideoMemoryConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (MIDLMIDLItfDxva2api000000060001* pdwTypePtr = &pdwType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, uint, MIDLMIDLItfDxva2api000000060001*, int>)@this->LpVtbl[3])(@this, dwTypeIndex, pdwTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSurfaceType<TThis>(this TThis thisVtbl, MIDLMIDLItfDxva2api000000060001 dwType) where TThis : IComVtbl<IDirectXVideoMemoryConfiguration>
    {
        var @this = (IDirectXVideoMemoryConfiguration*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoMemoryConfiguration*, MIDLMIDLItfDxva2api000000060001, int>)@this->LpVtbl[4])(@this, dwType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<IDirectXVideoMemoryConfiguration>
    {
        var @this = (IDirectXVideoMemoryConfiguration*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<IDirectXVideoMemoryConfiguration>
    {
        var @this = (IDirectXVideoMemoryConfiguration*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetAvailableSurfaceTypeByIndex<TThis>(this TThis thisVtbl, uint dwTypeIndex, Span<MIDLMIDLItfDxva2api000000060001> pdwType) where TThis : IComVtbl<IDirectXVideoMemoryConfiguration>
    {
        var @this = (IDirectXVideoMemoryConfiguration*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetAvailableSurfaceTypeByIndex(dwTypeIndex, ref pdwType.GetPinnableReference());
    }

}
