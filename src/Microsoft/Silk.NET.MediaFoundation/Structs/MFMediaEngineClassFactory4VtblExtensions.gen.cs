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

public unsafe static class MFMediaEngineClassFactory4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystem, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystem, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystem, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystem, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char keySystem, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riid, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char keySystem, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riid, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char keySystem, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riidPtr, ppvObject);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char keySystem, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* keySystemPtr = &keySystem)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, char*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riidPtr, ppvObjectPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riid, ppvObject);
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.LPWStr);
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riid, ppvObjectPtr);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riidPtr, ppvObject);
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var keySystemPtr = (byte*) SilkMarshal.StringToPtr(keySystem, NativeStringEncoding.LPWStr);
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFMediaEngineClassFactory4*, byte*, Guid*, void**, int>)@this->LpVtbl[3])(@this, keySystemPtr, riidPtr, ppvObjectPtr);
            }
        }
        SilkMarshal.Free((nint)keySystemPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory<TI0>(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->CreateContentDecryptionModuleFactory(keySystem, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateContentDecryptionModuleFactory(keySystem, ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateContentDecryptionModuleFactory(keySystem, ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> keySystem, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateContentDecryptionModuleFactory(in keySystem.GetPinnableReference(), riid, ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int CreateContentDecryptionModuleFactory<TI0>(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char keySystem, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->CreateContentDecryptionModuleFactory(in keySystem, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> keySystem, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateContentDecryptionModuleFactory(in keySystem.GetPinnableReference(), riid, ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> keySystem, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateContentDecryptionModuleFactory(in keySystem.GetPinnableReference(), ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> keySystem, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateContentDecryptionModuleFactory(in keySystem.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int CreateContentDecryptionModuleFactory<TI0>(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->CreateContentDecryptionModuleFactory(keySystem, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateContentDecryptionModuleFactory(keySystem, ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateContentDecryptionModuleFactory(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateContentDecryptionModuleFactory(keySystem, ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> CreateContentDecryptionModuleFactory<TI0>(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* keySystem) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateContentDecryptionModuleFactory(keySystem, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateContentDecryptionModuleFactory<TI0>(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char keySystem) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateContentDecryptionModuleFactory(in keySystem, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> CreateContentDecryptionModuleFactory<TI0>(this ComPtr<IMFMediaEngineClassFactory4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string keySystem) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->CreateContentDecryptionModuleFactory(keySystem, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
