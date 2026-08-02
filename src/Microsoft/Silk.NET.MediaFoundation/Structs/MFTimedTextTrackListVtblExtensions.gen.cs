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

namespace Silk.NET.MediaFoundation;

public unsafe static class MFTimedTextTrackListVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextTrackList> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextTrackList> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextTrackList> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextTrackList> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFTimedTextTrackList> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFTimedTextTrackList> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLength(this ComPtr<IMFTimedTextTrackList> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrack(this ComPtr<IMFTimedTextTrackList> thisVtbl, uint index, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, uint, IMFTimedTextTrack**, int>)@this->LpVtbl[4])(@this, index, track);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrack(this ComPtr<IMFTimedTextTrackList> thisVtbl, uint index, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextTrack** trackPtr = &track)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, uint, IMFTimedTextTrack**, int>)@this->LpVtbl[4])(@this, index, trackPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrackById(this ComPtr<IMFTimedTextTrackList> thisVtbl, uint trackId, IMFTimedTextTrack** track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, uint, IMFTimedTextTrack**, int>)@this->LpVtbl[5])(@this, trackId, track);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrackById(this ComPtr<IMFTimedTextTrackList> thisVtbl, uint trackId, ref IMFTimedTextTrack* track)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextTrack** trackPtr = &track)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrackList*, uint, IMFTimedTextTrack**, int>)@this->LpVtbl[5])(@this, trackId, trackPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFTimedTextTrackList> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextTrackList> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextTrackList> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetTrack<TI0>(this ComPtr<IMFTimedTextTrackList> thisVtbl, uint index, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTrack(index, (IMFTimedTextTrack**) track.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetTrackById<TI0>(this ComPtr<IMFTimedTextTrackList> thisVtbl, uint trackId, ref ComPtr<TI0> track) where TI0 : unmanaged, IComVtbl<IMFTimedTextTrack>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTrackById(trackId, (IMFTimedTextTrack**) track.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFTimedTextTrackList> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
