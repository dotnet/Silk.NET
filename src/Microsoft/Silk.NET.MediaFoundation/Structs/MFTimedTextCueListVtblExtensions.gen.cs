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

public unsafe static class MFTimedTextCueListVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextCueList> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextCueList> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextCueList> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextCueList> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFTimedTextCueList> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFTimedTextCueList> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLength(this ComPtr<IMFTimedTextCueList> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueByIndex(this ComPtr<IMFTimedTextCueList> thisVtbl, uint index, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[4])(@this, index, cue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueByIndex(this ComPtr<IMFTimedTextCueList> thisVtbl, uint index, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextCue** cuePtr = &cue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[4])(@this, index, cuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueById(this ComPtr<IMFTimedTextCueList> thisVtbl, uint id, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[5])(@this, id, cue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueById(this ComPtr<IMFTimedTextCueList> thisVtbl, uint id, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextCue** cuePtr = &cue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[5])(@this, id, cuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueByOriginalId(this ComPtr<IMFTimedTextCueList> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* originalId, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, char*, IMFTimedTextCue**, int>)@this->LpVtbl[6])(@this, originalId, cue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueByOriginalId(this ComPtr<IMFTimedTextCueList> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* originalId, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextCue** cuePtr = &cue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, char*, IMFTimedTextCue**, int>)@this->LpVtbl[6])(@this, originalId, cuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueByOriginalId(this ComPtr<IMFTimedTextCueList> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char originalId, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* originalIdPtr = &originalId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, char*, IMFTimedTextCue**, int>)@this->LpVtbl[6])(@this, originalIdPtr, cue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueByOriginalId(this ComPtr<IMFTimedTextCueList> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char originalId, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* originalIdPtr = &originalId)
        {
            fixed (IMFTimedTextCue** cuePtr = &cue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, char*, IMFTimedTextCue**, int>)@this->LpVtbl[6])(@this, originalIdPtr, cuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueByOriginalId(this ComPtr<IMFTimedTextCueList> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string originalId, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var originalIdPtr = (byte*) SilkMarshal.StringToPtr(originalId, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, byte*, IMFTimedTextCue**, int>)@this->LpVtbl[6])(@this, originalIdPtr, cue);
        SilkMarshal.Free((nint)originalIdPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueByOriginalId(this ComPtr<IMFTimedTextCueList> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string originalId, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var originalIdPtr = (byte*) SilkMarshal.StringToPtr(originalId, NativeStringEncoding.LPWStr);
        fixed (IMFTimedTextCue** cuePtr = &cue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, byte*, IMFTimedTextCue**, int>)@this->LpVtbl[6])(@this, originalIdPtr, cuePtr);
        }
        SilkMarshal.Free((nint)originalIdPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTextCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* text, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, char*, IMFTimedTextCue**, int>)@this->LpVtbl[7])(@this, start, duration, text, cue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTextCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* text, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextCue** cuePtr = &cue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, char*, IMFTimedTextCue**, int>)@this->LpVtbl[7])(@this, start, duration, text, cuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTextCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char text, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* textPtr = &text)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, char*, IMFTimedTextCue**, int>)@this->LpVtbl[7])(@this, start, duration, textPtr, cue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTextCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char text, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* textPtr = &text)
        {
            fixed (IMFTimedTextCue** cuePtr = &cue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, char*, IMFTimedTextCue**, int>)@this->LpVtbl[7])(@this, start, duration, textPtr, cuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTextCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string text, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textPtr = (byte*) SilkMarshal.StringToPtr(text, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, IMFTimedTextCue**, int>)@this->LpVtbl[7])(@this, start, duration, textPtr, cue);
        SilkMarshal.Free((nint)textPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTextCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string text, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var textPtr = (byte*) SilkMarshal.StringToPtr(text, NativeStringEncoding.LPWStr);
        fixed (IMFTimedTextCue** cuePtr = &cue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, IMFTimedTextCue**, int>)@this->LpVtbl[7])(@this, start, duration, textPtr, cuePtr);
        }
        SilkMarshal.Free((nint)textPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[8])(@this, start, duration, data, dataSize, cue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextCue** cuePtr = &cue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[8])(@this, start, duration, data, dataSize, cuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataSize, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* dataPtr = &data)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[8])(@this, start, duration, dataPtr, dataSize, cue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataSize, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* dataPtr = &data)
        {
            fixed (IMFTimedTextCue** cuePtr = &cue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[8])(@this, start, duration, dataPtr, dataSize, cuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[8])(@this, start, duration, dataPtr, dataSize, cue);
        SilkMarshal.Free((nint)dataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
        fixed (IMFTimedTextCue** cuePtr = &cue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, double, double, byte*, uint, IMFTimedTextCue**, int>)@this->LpVtbl[8])(@this, start, duration, dataPtr, dataSize, cuePtr);
        }
        SilkMarshal.Free((nint)dataPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveCue(this ComPtr<IMFTimedTextCueList> thisVtbl, IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, IMFTimedTextCue*, int>)@this->LpVtbl[9])(@this, cue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveCue(this ComPtr<IMFTimedTextCueList> thisVtbl, ref IMFTimedTextCue cue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextCue* cuePtr = &cue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextCueList*, IMFTimedTextCue*, int>)@this->LpVtbl[9])(@this, cuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextCueList> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextCueList> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetCueByIndex<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, uint index, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetCueByIndex(index, (IMFTimedTextCue**) cue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetCueById<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, uint id, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetCueById(id, (IMFTimedTextCue**) cue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueByOriginalId<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* originalId, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetCueByOriginalId(originalId, (IMFTimedTextCue**) cue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueByOriginalId(this ComPtr<IMFTimedTextCueList> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> originalId, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCueByOriginalId(in originalId.GetPinnableReference(), cue);
    }

    /// <summary>To be documented.</summary>
    public static int GetCueByOriginalId<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char originalId, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetCueByOriginalId(in originalId, (IMFTimedTextCue**) cue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCueByOriginalId(this ComPtr<IMFTimedTextCueList> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> originalId, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCueByOriginalId(in originalId.GetPinnableReference(), ref cue);
    }

    /// <summary>To be documented.</summary>
    public static int GetCueByOriginalId<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string originalId, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetCueByOriginalId(originalId, (IMFTimedTextCue**) cue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTextCue<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* text, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddTextCue(start, duration, text, (IMFTimedTextCue**) cue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTextCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> text, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTextCue(start, duration, in text.GetPinnableReference(), cue);
    }

    /// <summary>To be documented.</summary>
    public static int AddTextCue<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char text, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddTextCue(start, duration, in text, (IMFTimedTextCue**) cue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddTextCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> text, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddTextCue(start, duration, in text.GetPinnableReference(), ref cue);
    }

    /// <summary>To be documented.</summary>
    public static int AddTextCue<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string text, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddTextCue(start, duration, text, (IMFTimedTextCue**) cue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataCue<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddDataCue(start, duration, data, dataSize, (IMFTimedTextCue**) cue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataSize, IMFTimedTextCue** cue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataCue(start, duration, in data.GetPinnableReference(), dataSize, cue);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataCue<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataSize, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddDataCue(start, duration, in data, dataSize, (IMFTimedTextCue**) cue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddDataCue(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint dataSize, ref IMFTimedTextCue* cue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddDataCue(start, duration, in data.GetPinnableReference(), dataSize, ref cue);
    }

    /// <summary>To be documented.</summary>
    public static int AddDataCue<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, double start, double duration, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize, ref ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddDataCue(start, duration, data, dataSize, (IMFTimedTextCue**) cue.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int RemoveCue<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl, ComPtr<TI0> cue) where TI0 : unmanaged, IComVtbl<IMFTimedTextCue>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RemoveCue((IMFTimedTextCue*) cue.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RemoveCue(this ComPtr<IMFTimedTextCueList> thisVtbl, Span<IMFTimedTextCue> cue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RemoveCue(ref cue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFTimedTextCueList> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
