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

public unsafe static class MFMediaSourceExtensionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaSourceExtension> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaSourceExtension> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaSourceExtension> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaSourceExtension> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaSourceExtension> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaSourceExtension> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IMFSourceBufferList* GetSourceBuffers(this ComPtr<IMFMediaSourceExtension> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        IMFSourceBufferList* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, IMFSourceBufferList*>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IMFSourceBufferList* GetActiveSourceBuffers(this ComPtr<IMFMediaSourceExtension> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        IMFSourceBufferList* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, IMFSourceBufferList*>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static MseReady GetReadyState(this ComPtr<IMFMediaSourceExtension> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        MseReady ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, MseReady>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static double GetDuration(this ComPtr<IMFMediaSourceExtension> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        double ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, double>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDuration(this ComPtr<IMFMediaSourceExtension> thisVtbl, double duration)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, double, int>)@this->LpVtbl[7])(@this, duration);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, char* type, IMFSourceBufferNotify* pNotify, IMFSourceBuffer** ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, type, pNotify, ppSourceBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, char* type, IMFSourceBufferNotify* pNotify, ref IMFSourceBuffer* ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFSourceBuffer** ppSourceBufferPtr = &ppSourceBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, type, pNotify, ppSourceBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, char* type, ref IMFSourceBufferNotify pNotify, IMFSourceBuffer** ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFSourceBufferNotify* pNotifyPtr = &pNotify)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, type, pNotifyPtr, ppSourceBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, char* type, ref IMFSourceBufferNotify pNotify, ref IMFSourceBuffer* ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFSourceBufferNotify* pNotifyPtr = &pNotify)
        {
            fixed (IMFSourceBuffer** ppSourceBufferPtr = &ppSourceBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, type, pNotifyPtr, ppSourceBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, ref char type, IMFSourceBufferNotify* pNotify, IMFSourceBuffer** ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotify, ppSourceBuffer);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, ref char type, IMFSourceBufferNotify* pNotify, ref IMFSourceBuffer* ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            fixed (IMFSourceBuffer** ppSourceBufferPtr = &ppSourceBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotify, ppSourceBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, ref char type, ref IMFSourceBufferNotify pNotify, IMFSourceBuffer** ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            fixed (IMFSourceBufferNotify* pNotifyPtr = &pNotify)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotifyPtr, ppSourceBuffer);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, ref char type, ref IMFSourceBufferNotify pNotify, ref IMFSourceBuffer* ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* typePtr = &type)
        {
            fixed (IMFSourceBufferNotify* pNotifyPtr = &pNotify)
            {
                fixed (IMFSourceBuffer** ppSourceBufferPtr = &ppSourceBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotifyPtr, ppSourceBufferPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, IMFSourceBufferNotify* pNotify, IMFSourceBuffer** ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, byte*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotify, ppSourceBuffer);
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, IMFSourceBufferNotify* pNotify, ref IMFSourceBuffer* ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        fixed (IMFSourceBuffer** ppSourceBufferPtr = &ppSourceBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, byte*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotify, ppSourceBufferPtr);
        }
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref IMFSourceBufferNotify pNotify, IMFSourceBuffer** ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        fixed (IMFSourceBufferNotify* pNotifyPtr = &pNotify)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, byte*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotifyPtr, ppSourceBuffer);
        }
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref IMFSourceBufferNotify pNotify, ref IMFSourceBuffer* ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        fixed (IMFSourceBufferNotify* pNotifyPtr = &pNotify)
        {
            fixed (IMFSourceBuffer** ppSourceBufferPtr = &ppSourceBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, byte*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)@this->LpVtbl[8])(@this, typePtr, pNotifyPtr, ppSourceBufferPtr);
            }
        }
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, IMFSourceBuffer* pSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, IMFSourceBuffer*, int>)@this->LpVtbl[9])(@this, pSourceBuffer);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, ref IMFSourceBuffer pSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFSourceBuffer* pSourceBufferPtr = &pSourceBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, IMFSourceBuffer*, int>)@this->LpVtbl[9])(@this, pSourceBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetEndOfStream(this ComPtr<IMFMediaSourceExtension> thisVtbl, MseError error)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, MseError, int>)@this->LpVtbl[10])(@this, error);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 IsTypeSupported(this ComPtr<IMFMediaSourceExtension> thisVtbl, char* type)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, Silk.NET.Core.Bool32>)@this->LpVtbl[11])(@this, type);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsTypeSupported(this ComPtr<IMFMediaSourceExtension> thisVtbl, ref char type)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        fixed (char* typePtr = &type)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, char*, Silk.NET.Core.Bool32>)@this->LpVtbl[11])(@this, typePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsTypeSupported(this ComPtr<IMFMediaSourceExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        var typePtr = (byte*) SilkMarshal.StringToPtr(type, NativeStringEncoding.BStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, byte*, Silk.NET.Core.Bool32>)@this->LpVtbl[11])(@this, typePtr);
        SilkMarshal.Free((nint)typePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe IMFSourceBuffer* GetSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, uint dwStreamIndex)
    {
        var @this = thisVtbl.Handle;
        IMFSourceBuffer* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaSourceExtension*, uint, IMFSourceBuffer*>)@this->LpVtbl[12])(@this, dwStreamIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaSourceExtension> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaSourceExtension> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaSourceExtension> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer<TI0, TI1>(this ComPtr<IMFMediaSourceExtension> thisVtbl, char* type, ComPtr<TI0> pNotify, ref ComPtr<TI1> ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBufferNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddSourceBuffer(type, (IMFSourceBufferNotify*) pNotify.Handle, (IMFSourceBuffer**) ppSourceBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer<TI0>(this ComPtr<IMFMediaSourceExtension> thisVtbl, char* type, ComPtr<TI0> pNotify, ref IMFSourceBuffer* ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBufferNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddSourceBuffer(type, (IMFSourceBufferNotify*) pNotify.Handle, ref ppSourceBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, char* type, Span<IMFSourceBufferNotify> pNotify, IMFSourceBuffer** ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSourceBuffer(type, ref pNotify.GetPinnableReference(), ppSourceBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer<TI0>(this ComPtr<IMFMediaSourceExtension> thisVtbl, char* type, ref IMFSourceBufferNotify pNotify, ref ComPtr<TI0> ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddSourceBuffer(type, ref pNotify, (IMFSourceBuffer**) ppSourceBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, char* type, Span<IMFSourceBufferNotify> pNotify, ref IMFSourceBuffer* ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSourceBuffer(type, ref pNotify.GetPinnableReference(), ref ppSourceBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, Span<char> type, IMFSourceBufferNotify* pNotify, IMFSourceBuffer** ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSourceBuffer(ref type.GetPinnableReference(), pNotify, ppSourceBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int AddSourceBuffer<TI0, TI1>(this ComPtr<IMFMediaSourceExtension> thisVtbl, ref char type, ComPtr<TI0> pNotify, ref ComPtr<TI1> ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBufferNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddSourceBuffer(ref type, (IMFSourceBufferNotify*) pNotify.Handle, (IMFSourceBuffer**) ppSourceBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, Span<char> type, IMFSourceBufferNotify* pNotify, ref IMFSourceBuffer* ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSourceBuffer(ref type.GetPinnableReference(), pNotify, ref ppSourceBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer<TI0>(this ComPtr<IMFMediaSourceExtension> thisVtbl, ref char type, ComPtr<TI0> pNotify, ref IMFSourceBuffer* ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBufferNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddSourceBuffer(ref type, (IMFSourceBufferNotify*) pNotify.Handle, ref ppSourceBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, Span<char> type, Span<IMFSourceBufferNotify> pNotify, IMFSourceBuffer** ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSourceBuffer(ref type.GetPinnableReference(), ref pNotify.GetPinnableReference(), ppSourceBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int AddSourceBuffer<TI0>(this ComPtr<IMFMediaSourceExtension> thisVtbl, ref char type, ref IMFSourceBufferNotify pNotify, ref ComPtr<TI0> ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddSourceBuffer(ref type, ref pNotify, (IMFSourceBuffer**) ppSourceBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, Span<char> type, Span<IMFSourceBufferNotify> pNotify, ref IMFSourceBuffer* ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSourceBuffer(ref type.GetPinnableReference(), ref pNotify.GetPinnableReference(), ref ppSourceBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int AddSourceBuffer<TI0, TI1>(this ComPtr<IMFMediaSourceExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ComPtr<TI0> pNotify, ref ComPtr<TI1> ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBufferNotify>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddSourceBuffer(type, (IMFSourceBufferNotify*) pNotify.Handle, (IMFSourceBuffer**) ppSourceBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer<TI0>(this ComPtr<IMFMediaSourceExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ComPtr<TI0> pNotify, ref IMFSourceBuffer* ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBufferNotify>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddSourceBuffer(type, (IMFSourceBufferNotify*) pNotify.Handle, ref ppSourceBuffer);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, Span<IMFSourceBufferNotify> pNotify, IMFSourceBuffer** ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSourceBuffer(type, ref pNotify.GetPinnableReference(), ppSourceBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int AddSourceBuffer<TI0>(this ComPtr<IMFMediaSourceExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, ref IMFSourceBufferNotify pNotify, ref ComPtr<TI0> ppSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddSourceBuffer(type, ref pNotify, (IMFSourceBuffer**) ppSourceBuffer.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.BStr)] string type, Span<IMFSourceBufferNotify> pNotify, ref IMFSourceBuffer* ppSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddSourceBuffer(type, ref pNotify.GetPinnableReference(), ref ppSourceBuffer);
    }

    /// <summary>To be documented.</summary>
    public static int RemoveSourceBuffer<TI0>(this ComPtr<IMFMediaSourceExtension> thisVtbl, ComPtr<TI0> pSourceBuffer) where TI0 : unmanaged, IComVtbl<IMFSourceBuffer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RemoveSourceBuffer((IMFSourceBuffer*) pSourceBuffer.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int RemoveSourceBuffer(this ComPtr<IMFMediaSourceExtension> thisVtbl, Span<IMFSourceBuffer> pSourceBuffer)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RemoveSourceBuffer(ref pSourceBuffer.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsTypeSupported(this ComPtr<IMFMediaSourceExtension> thisVtbl, Span<char> type)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsTypeSupported(ref type.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaSourceExtension> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
