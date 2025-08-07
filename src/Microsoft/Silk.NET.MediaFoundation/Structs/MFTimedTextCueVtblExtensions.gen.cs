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

public unsafe static class MFTimedTextCueVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextCue> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextCue> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextCue> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextCue> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFTimedTextCue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFTimedTextCue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetId(this ComPtr<IMFTimedTextCue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOriginalId(this ComPtr<IMFTimedTextCue> thisVtbl, char** originalId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, char**, int>)@this->LpVtbl[4])(@this, originalId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOriginalId(this ComPtr<IMFTimedTextCue> thisVtbl, ref char* originalId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** originalIdPtr = &originalId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, char**, int>)@this->LpVtbl[4])(@this, originalIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static TimedTextTrackKind GetCueKind(this ComPtr<IMFTimedTextCue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TimedTextTrackKind ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, TimedTextTrackKind>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetStartTime(this ComPtr<IMFTimedTextCue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, double>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetDuration(this ComPtr<IMFTimedTextCue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, double>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetTrackId(this ComPtr<IMFTimedTextCue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IMFTimedTextCue> thisVtbl, IMFTimedTextBinary** data)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextBinary**, int>)@this->LpVtbl[9])(@this, data);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetData(this ComPtr<IMFTimedTextCue> thisVtbl, ref IMFTimedTextBinary* data)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextBinary** dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextBinary**, int>)@this->LpVtbl[9])(@this, dataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegion(this ComPtr<IMFTimedTextCue> thisVtbl, IMFTimedTextRegion** region)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextRegion**, int>)@this->LpVtbl[10])(@this, region);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRegion(this ComPtr<IMFTimedTextCue> thisVtbl, ref IMFTimedTextRegion* region)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextRegion** regionPtr = &region)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextRegion**, int>)@this->LpVtbl[10])(@this, regionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStyle(this ComPtr<IMFTimedTextCue> thisVtbl, IMFTimedTextStyle** style)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextStyle**, int>)@this->LpVtbl[11])(@this, style);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStyle(this ComPtr<IMFTimedTextCue> thisVtbl, ref IMFTimedTextStyle* style)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextStyle** stylePtr = &style)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, IMFTimedTextStyle**, int>)@this->LpVtbl[11])(@this, stylePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLineCount(this ComPtr<IMFTimedTextCue> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLine(this ComPtr<IMFTimedTextCue> thisVtbl, uint index, IMFTimedTextFormattedText** line)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint, IMFTimedTextFormattedText**, int>)@this->LpVtbl[13])(@this, index, line);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLine(this ComPtr<IMFTimedTextCue> thisVtbl, uint index, ref IMFTimedTextFormattedText* line)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextFormattedText** linePtr = &line)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCue*, uint, IMFTimedTextFormattedText**, int>)@this->LpVtbl[13])(@this, index, linePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFTimedTextCue> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextCue> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextCue> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetOriginalId(this ComPtr<IMFTimedTextCue> thisVtbl, string[] originalIdSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var originalId = (char**) SilkMarshal.StringArrayToPtr(originalIdSa);
        var ret = @this->GetOriginalId(originalId);
        SilkMarshal.CopyPtrToStringArray((nint) originalId, originalIdSa);
        SilkMarshal.Free((nint) originalId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetData<TI0>(this ComPtr<IMFTimedTextCue> thisVtbl, ref ComPtr<TI0> data) where TI0 : unmanaged, IComVtbl<IMFTimedTextBinary>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetData((IMFTimedTextBinary**) data.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetRegion<TI0>(this ComPtr<IMFTimedTextCue> thisVtbl, ref ComPtr<TI0> region) where TI0 : unmanaged, IComVtbl<IMFTimedTextRegion>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRegion((IMFTimedTextRegion**) region.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetStyle<TI0>(this ComPtr<IMFTimedTextCue> thisVtbl, ref ComPtr<TI0> style) where TI0 : unmanaged, IComVtbl<IMFTimedTextStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetStyle((IMFTimedTextStyle**) style.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetLine<TI0>(this ComPtr<IMFTimedTextCue> thisVtbl, uint index, ref ComPtr<TI0> line) where TI0 : unmanaged, IComVtbl<IMFTimedTextFormattedText>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetLine(index, (IMFTimedTextFormattedText**) line.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFTimedTextCue> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
