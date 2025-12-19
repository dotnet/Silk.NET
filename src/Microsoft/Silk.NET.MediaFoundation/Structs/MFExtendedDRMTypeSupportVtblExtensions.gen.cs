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

public unsafe static class MFExtendedDRMTypeSupportVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, char* type, char* keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, type, keySystem, pAnswer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, char* type, char* keySystem, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, type, keySystem, pAnswerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, char* type, ref char keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, type, keySystemPtr, pAnswer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, char* type, ref char keySystem, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, type, keySystemPtr, pAnswerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, char* type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, type, keySystemPtr, pAnswer);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, char* type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, type, keySystemPtr, pAnswerPtr);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, ref char type, char* keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystem, pAnswer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, ref char type, char* keySystem, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystem, pAnswerPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, ref char type, ref char keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            fixed (char* keySystemPtr = &keySystem)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, ref char type, ref char keySystem, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            fixed (char* keySystemPtr = &keySystem)
            {
                fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswerPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, ref char type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswer);
        SilkMarshal.Free((nint)keySystemPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, ref char type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, char*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswerPtr);
            }
        SilkMarshal.Free((nint)keySystemPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, char* keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, byte*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystem, pAnswer);
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, char* keySystem, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, byte*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystem, pAnswerPtr);
        }
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref char keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        fixed (char* keySystemPtr = &keySystem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, byte*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswer);
        }
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref char keySystem, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, byte*, char*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswerPtr);
            }
        }
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, byte*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswer);
        SilkMarshal.Free((nint)keySystemPtr);
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, ref MediaEngineCanPlay pAnswer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.BStr);
        fixed (MediaEngineCanPlay* pAnswerPtr = &pAnswer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFExtendedDRMTypeSupport*, byte*, byte*, MediaEngineCanPlay*, int>)@this->LpVtbl[3])(@this, typePtr, keySystemPtr, pAnswerPtr);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, char* type, char* keySystem, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(type, keySystem, ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, char* type, Span<char> keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(type, ref keySystem.GetPinnableReference(), pAnswer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, char* type, Span<char> keySystem, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(type, ref keySystem.GetPinnableReference(), ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, char* type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(type, keySystem, ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, Span<char> type, char* keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(ref type.GetPinnableReference(), keySystem, pAnswer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, Span<char> type, char* keySystem, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(ref type.GetPinnableReference(), keySystem, ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, Span<char> type, Span<char> keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(ref type.GetPinnableReference(), ref keySystem.GetPinnableReference(), pAnswer);
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, Span<char> type, Span<char> keySystem, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(ref type.GetPinnableReference(), ref keySystem.GetPinnableReference(), ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, Span<char> type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(ref type.GetPinnableReference(), keySystem, pAnswer);
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, Span<char> type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(ref type.GetPinnableReference(), keySystem, ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, char* keySystem, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(type, keySystem, ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, Span<char> keySystem, MediaEngineCanPlay* pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(type, ref keySystem.GetPinnableReference(), pAnswer);
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, Span<char> keySystem, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(type, ref keySystem.GetPinnableReference(), ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsTypeSupportedEx(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string keySystem, Span<MediaEngineCanPlay> pAnswer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupportedEx(type, keySystem, ref pAnswer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFExtendedDRMTypeSupport> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
