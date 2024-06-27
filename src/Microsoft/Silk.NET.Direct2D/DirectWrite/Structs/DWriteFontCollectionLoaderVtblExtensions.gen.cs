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

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteFontCollectionLoaderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontCollectionLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontCollectionLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factory, collectionKey, collectionKeySize, fontFileEnumerator);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFileEnumerator** fontFileEnumeratorPtr = &fontFileEnumerator)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factory, collectionKey, collectionKeySize, fontFileEnumeratorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey<T0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* collectionKeyPtr = &collectionKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factory, collectionKeyPtr, collectionKeySize, fontFileEnumerator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey<T0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* collectionKeyPtr = &collectionKey)
        {
            fixed (IDWriteFontFileEnumerator** fontFileEnumeratorPtr = &fontFileEnumerator)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factory, collectionKeyPtr, collectionKeySize, fontFileEnumeratorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factoryPtr, collectionKey, collectionKeySize, fontFileEnumerator);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (IDWriteFontFileEnumerator** fontFileEnumeratorPtr = &fontFileEnumerator)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factoryPtr, collectionKey, collectionKeySize, fontFileEnumeratorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey<T0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (void* collectionKeyPtr = &collectionKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factoryPtr, collectionKeyPtr, collectionKeySize, fontFileEnumerator);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey<T0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (void* collectionKeyPtr = &collectionKey)
            {
                fixed (IDWriteFontFileEnumerator** fontFileEnumeratorPtr = &fontFileEnumerator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factoryPtr, collectionKeyPtr, collectionKeySize, fontFileEnumeratorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey<TI0, TI1>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref ComPtr<TI1> fontFileEnumerator) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFileEnumerator>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEnumeratorFromKey((IDWriteFactory*) factory.Handle, collectionKey, collectionKeySize, (IDWriteFontFileEnumerator**) fontFileEnumerator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey<TI0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEnumeratorFromKey((IDWriteFactory*) factory.Handle, collectionKey, collectionKeySize, ref fontFileEnumerator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey<T0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEnumeratorFromKey(factory, in collectionKey.GetPinnableReference(), collectionKeySize, fontFileEnumerator);
    }

    /// <summary>To be documented.</summary>
    public static int CreateEnumeratorFromKey<T0, TI0, TI1>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref ComPtr<TI1> fontFileEnumerator) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFileEnumerator>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEnumeratorFromKey((IDWriteFactory*) factory.Handle, in collectionKey, collectionKeySize, (IDWriteFontFileEnumerator**) fontFileEnumerator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey<T0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEnumeratorFromKey(factory, in collectionKey.GetPinnableReference(), collectionKeySize, ref fontFileEnumerator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey<T0, TI0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEnumeratorFromKey((IDWriteFactory*) factory.Handle, in collectionKey, collectionKeySize, ref fontFileEnumerator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEnumeratorFromKey(ref factory.GetPinnableReference(), collectionKey, collectionKeySize, fontFileEnumerator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey<TI0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref ComPtr<TI0> fontFileEnumerator) where TI0 : unmanaged, IComVtbl<IDWriteFontFileEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEnumeratorFromKey(ref factory, collectionKey, collectionKeySize, (IDWriteFontFileEnumerator**) fontFileEnumerator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEnumeratorFromKey(ref factory.GetPinnableReference(), collectionKey, collectionKeySize, ref fontFileEnumerator);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey<T0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEnumeratorFromKey(ref factory.GetPinnableReference(), in collectionKey.GetPinnableReference(), collectionKeySize, fontFileEnumerator);
    }

    /// <summary>To be documented.</summary>
    public static int CreateEnumeratorFromKey<T0, TI0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref ComPtr<TI0> fontFileEnumerator) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileEnumerator>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateEnumeratorFromKey(ref factory, in collectionKey, collectionKeySize, (IDWriteFontFileEnumerator**) fontFileEnumerator.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateEnumeratorFromKey<T0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateEnumeratorFromKey(ref factory.GetPinnableReference(), in collectionKey.GetPinnableReference(), collectionKeySize, ref fontFileEnumerator);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontCollectionLoader> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
