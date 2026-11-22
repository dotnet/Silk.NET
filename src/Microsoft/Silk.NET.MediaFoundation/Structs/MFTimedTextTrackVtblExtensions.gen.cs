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

public unsafe static class MFTimedTextTrackVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextTrack> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextTrack> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextTrack> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextTrack> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFTimedTextTrack> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFTimedTextTrack> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetId(this ComPtr<IMFTimedTextTrack> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLabel(this ComPtr<IMFTimedTextTrack> thisVtbl, char** label)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char**, int>)@this->LpVtbl[4])(@this, label);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLabel(this ComPtr<IMFTimedTextTrack> thisVtbl, ref char* label)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** labelPtr = &label)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char**, int>)@this->LpVtbl[4])(@this, labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetLabel(this ComPtr<IMFTimedTextTrack> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* label)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char*, int>)@this->LpVtbl[5])(@this, label);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLabel(this ComPtr<IMFTimedTextTrack> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char label)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* labelPtr = &label)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char*, int>)@this->LpVtbl[5])(@this, labelPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLabel(this ComPtr<IMFTimedTextTrack> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string label)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var labelPtr = (byte*) SilkMarshal.StringToPtr(label, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, byte*, int>)@this->LpVtbl[5])(@this, labelPtr);
        SilkMarshal.Free((nint)labelPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLanguage(this ComPtr<IMFTimedTextTrack> thisVtbl, char** language)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char**, int>)@this->LpVtbl[6])(@this, language);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLanguage(this ComPtr<IMFTimedTextTrack> thisVtbl, ref char* language)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** languagePtr = &language)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char**, int>)@this->LpVtbl[6])(@this, languagePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static TimedTextTrackKind GetTrackKind(this ComPtr<IMFTimedTextTrack> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TimedTextTrackKind ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, TimedTextTrackKind>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsInBand(this ComPtr<IMFTimedTextTrack> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Silk.NET.Core.Bool32>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInBandMetadataTrackDispatchType(this ComPtr<IMFTimedTextTrack> thisVtbl, char** dispatchType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char**, int>)@this->LpVtbl[9])(@this, dispatchType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInBandMetadataTrackDispatchType(this ComPtr<IMFTimedTextTrack> thisVtbl, ref char* dispatchType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** dispatchTypePtr = &dispatchType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, char**, int>)@this->LpVtbl[9])(@this, dispatchTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsActive(this ComPtr<IMFTimedTextTrack> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Silk.NET.Core.Bool32>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static TimedTextErrorCode GetErrorCode(this ComPtr<IMFTimedTextTrack> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TimedTextErrorCode ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, TimedTextErrorCode>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetExtendedErrorCode(this ComPtr<IMFTimedTextTrack> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, int>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDataFormat(this ComPtr<IMFTimedTextTrack> thisVtbl, Guid* format)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, int>)@this->LpVtbl[13])(@this, format);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDataFormat(this ComPtr<IMFTimedTextTrack> thisVtbl, ref Guid format)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* formatPtr = &format)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, Guid*, int>)@this->LpVtbl[13])(@this, formatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static TimedTextTrackReadyState GetReadyState(this ComPtr<IMFTimedTextTrack> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TimedTextTrackReadyState ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, TimedTextTrackReadyState>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueList(this ComPtr<IMFTimedTextTrack> thisVtbl, IMFTimedTextCueList** cues)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, IMFTimedTextCueList**, int>)@this->LpVtbl[15])(@this, cues);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueList(this ComPtr<IMFTimedTextTrack> thisVtbl, ref IMFTimedTextCueList* cues)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextCueList** cuesPtr = &cues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextTrack*, IMFTimedTextCueList**, int>)@this->LpVtbl[15])(@this, cuesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFTimedTextTrack> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextTrack> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextTrack> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetLabel(this ComPtr<IMFTimedTextTrack> thisVtbl, string[] labelSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var label = (char**) SilkMarshal.StringArrayToPtr(labelSa);
        var ret = @this->GetLabel(label);
        SilkMarshal.CopyPtrToStringArray((nint) label, labelSa);
        SilkMarshal.Free((nint) label);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLabel(this ComPtr<IMFTimedTextTrack> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> label)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetLabel(in label.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLanguage(this ComPtr<IMFTimedTextTrack> thisVtbl, string[] languageSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var language = (char**) SilkMarshal.StringArrayToPtr(languageSa);
        var ret = @this->GetLanguage(language);
        SilkMarshal.CopyPtrToStringArray((nint) language, languageSa);
        SilkMarshal.Free((nint) language);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetInBandMetadataTrackDispatchType(this ComPtr<IMFTimedTextTrack> thisVtbl, string[] dispatchTypeSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var dispatchType = (char**) SilkMarshal.StringArrayToPtr(dispatchTypeSa);
        var ret = @this->GetInBandMetadataTrackDispatchType(dispatchType);
        SilkMarshal.CopyPtrToStringArray((nint) dispatchType, dispatchTypeSa);
        SilkMarshal.Free((nint) dispatchType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDataFormat(this ComPtr<IMFTimedTextTrack> thisVtbl, Span<Guid> format)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDataFormat(ref format.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetCueList<TI0>(this ComPtr<IMFTimedTextTrack> thisVtbl, ref ComPtr<TI0> cues) where TI0 : unmanaged, IComVtbl<IMFTimedTextCueList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetCueList((IMFTimedTextCueList**) cues.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFTimedTextTrack> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
