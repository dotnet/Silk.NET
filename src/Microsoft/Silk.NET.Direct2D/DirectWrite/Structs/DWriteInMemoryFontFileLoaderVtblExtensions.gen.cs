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

public unsafe static class DWriteInMemoryFontFileLoaderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileStream* fontFileStream)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFileStream** fontFileStreamPtr = &fontFileStream)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStreamPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileStream);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileStream* fontFileStream) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
        {
            fixed (IDWriteFontFileStream** fontFileStreamPtr = &fontFileStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileStreamPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontData, fontDataSize, ownerObject, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile** fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontData, fontDataSize, ownerObject, fontFilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontData, fontDataSize, ownerObjectPtr, fontFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
        {
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontData, fontDataSize, ownerObjectPtr, fontFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontDataPtr = &fontData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontDataPtr, fontDataSize, ownerObject, fontFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontDataPtr = &fontData)
        {
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontDataPtr, fontDataSize, ownerObject, fontFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, IDWriteFontFile** fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontDataPtr = &fontData)
        {
            fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontDataPtr, fontDataSize, ownerObjectPtr, fontFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* fontDataPtr = &fontData)
        {
            fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontDataPtr, fontDataSize, ownerObjectPtr, fontFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontData, fontDataSize, ownerObject, fontFile);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontData, fontDataSize, ownerObject, fontFilePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontData, fontDataSize, ownerObjectPtr, fontFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontData, fontDataSize, ownerObjectPtr, fontFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (void* fontDataPtr = &fontData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontDataPtr, fontDataSize, ownerObject, fontFile);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (void* fontDataPtr = &fontData)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontDataPtr, fontDataSize, ownerObject, fontFilePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, IDWriteFontFile** fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (void* fontDataPtr = &fontData)
            {
                fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontDataPtr, fontDataSize, ownerObjectPtr, fontFile);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFactory* factoryPtr = &factory)
        {
            fixed (void* fontDataPtr = &fontData)
            {
                fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
                {
                    fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontDataPtr, fontDataSize, ownerObjectPtr, fontFilePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFileCount(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey<TI0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref ComPtr<TI0> fontFileStream) where TI0 : unmanaged, IComVtbl<IDWriteFontFileStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStreamFromKey(fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileStream**) fontFileStream.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStreamFromKey(in fontFileReferenceKey.GetPinnableReference(), fontFileReferenceKeySize, fontFileStream);
    }

    /// <summary>To be documented.</summary>
    public static int CreateStreamFromKey<T0, TI0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref ComPtr<TI0> fontFileStream) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateStreamFromKey(in fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileStream**) fontFileStream.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateStreamFromKey<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileStream* fontFileStream) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateStreamFromKey(in fontFileReferenceKey.GetPinnableReference(), fontFileReferenceKeySize, ref fontFileStream);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<TI0, TI1, TI2>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ComPtr<TI1> ownerObject, ref ComPtr<TI2> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<TI0, TI1>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ComPtr<TI1> ownerObject, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Span<Silk.NET.Core.Native.IUnknown> ownerObject, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(factory, fontData, fontDataSize, ref ownerObject.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<TI0, TI1>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, fontData, fontDataSize, ref ownerObject, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Span<Silk.NET.Core.Native.IUnknown> ownerObject, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(factory, fontData, fontDataSize, ref ownerObject.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<TI0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, fontData, fontDataSize, ref ownerObject, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(factory, in fontData.GetPinnableReference(), fontDataSize, ownerObject, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateInMemoryFontFileReference<T0, TI0, TI1, TI2>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ComPtr<TI1> ownerObject, ref ComPtr<TI2> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, in fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(factory, in fontData.GetPinnableReference(), fontDataSize, ownerObject, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0, TI0, TI1>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ComPtr<TI1> ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, in fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontData, uint fontDataSize, Span<Silk.NET.Core.Native.IUnknown> ownerObject, IDWriteFontFile** fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(factory, in fontData.GetPinnableReference(), fontDataSize, ref ownerObject.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateInMemoryFontFileReference<T0, TI0, TI1>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref ComPtr<TI1> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, in fontData, fontDataSize, ref ownerObject, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontData, uint fontDataSize, Span<Silk.NET.Core.Native.IUnknown> ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(factory, in fontData.GetPinnableReference(), fontDataSize, ref ownerObject.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0, TI0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, in fontData, fontDataSize, ref ownerObject, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(ref factory.GetPinnableReference(), fontData, fontDataSize, ownerObject, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<TI0, TI1>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ComPtr<TI0> ownerObject, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference(ref factory, fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(ref factory.GetPinnableReference(), fontData, fontDataSize, ownerObject, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<TI0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ComPtr<TI0> ownerObject, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference(ref factory, fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Span<Silk.NET.Core.Native.IUnknown> ownerObject, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(ref factory.GetPinnableReference(), fontData, fontDataSize, ref ownerObject.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<TI0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference(ref factory, fontData, fontDataSize, ref ownerObject, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Span<Silk.NET.Core.Native.IUnknown> ownerObject, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(ref factory.GetPinnableReference(), fontData, fontDataSize, ref ownerObject.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(ref factory.GetPinnableReference(), in fontData.GetPinnableReference(), fontDataSize, ownerObject, fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateInMemoryFontFileReference<T0, TI0, TI1>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ComPtr<TI0> ownerObject, ref ComPtr<TI1> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference(ref factory, in fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(ref factory.GetPinnableReference(), in fontData.GetPinnableReference(), fontDataSize, ownerObject, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0, TI0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ComPtr<TI0> ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference(ref factory, in fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontData, uint fontDataSize, Span<Silk.NET.Core.Native.IUnknown> ownerObject, IDWriteFontFile** fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(ref factory.GetPinnableReference(), in fontData.GetPinnableReference(), fontDataSize, ref ownerObject.GetPinnableReference(), fontFile);
    }

    /// <summary>To be documented.</summary>
    public static int CreateInMemoryFontFileReference<T0, TI0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref ComPtr<TI0> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateInMemoryFontFileReference(ref factory, in fontData, fontDataSize, ref ownerObject, (IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateInMemoryFontFileReference<T0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl, Span<IDWriteFactory> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> fontData, uint fontDataSize, Span<Silk.NET.Core.Native.IUnknown> ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateInMemoryFontFileReference(ref factory.GetPinnableReference(), in fontData.GetPinnableReference(), fontDataSize, ref ownerObject.GetPinnableReference(), ref fontFile);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteInMemoryFontFileLoader> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
