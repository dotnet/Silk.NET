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

namespace Silk.NET.WindowsCodecs;

public unsafe static class WICColorContextVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICColorContext> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICColorContext> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICColorContext> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICColorContext> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICColorContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICColorContext> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InitializeFromFilename(this ComPtr<IWICColorContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, char*, int>)@this->LpVtbl[3])(@this, wzFilename);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromFilename(this ComPtr<IWICColorContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzFilenamePtr = &wzFilename)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, char*, int>)@this->LpVtbl[3])(@this, wzFilenamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromFilename(this ComPtr<IWICColorContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, byte*, int>)@this->LpVtbl[3])(@this, wzFilenamePtr);
        SilkMarshal.Free((nint)wzFilenamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int InitializeFromMemory(this ComPtr<IWICColorContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbBuffer, uint cbBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, byte*, uint, int>)@this->LpVtbl[4])(@this, pbBuffer, cbBufferSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromMemory(this ComPtr<IWICColorContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbBuffer, uint cbBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBufferPtr = &pbBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, byte*, uint, int>)@this->LpVtbl[4])(@this, pbBufferPtr, cbBufferSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromMemory(this ComPtr<IWICColorContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, uint cbBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, byte*, uint, int>)@this->LpVtbl[4])(@this, pbBufferPtr, cbBufferSize);
        SilkMarshal.Free((nint)pbBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromExifColorSpace(this ComPtr<IWICColorContext> thisVtbl, uint value)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, int>)@this->LpVtbl[5])(@this, value);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetType(this ComPtr<IWICColorContext> thisVtbl, ColorContextType* pType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, ColorContextType*, int>)@this->LpVtbl[6])(@this, pType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetType(this ComPtr<IWICColorContext> thisVtbl, ref ColorContextType pType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ColorContextType* pTypePtr = &pType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, ColorContextType*, int>)@this->LpVtbl[6])(@this, pTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProfileBytes(this ComPtr<IWICColorContext> thisVtbl, uint cbBuffer, byte* pbBuffer, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)@this->LpVtbl[7])(@this, cbBuffer, pbBuffer, pcbActual);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProfileBytes(this ComPtr<IWICColorContext> thisVtbl, uint cbBuffer, byte* pbBuffer, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbActualPtr = &pcbActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)@this->LpVtbl[7])(@this, cbBuffer, pbBuffer, pcbActualPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProfileBytes(this ComPtr<IWICColorContext> thisVtbl, uint cbBuffer, ref byte pbBuffer, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBufferPtr = &pbBuffer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)@this->LpVtbl[7])(@this, cbBuffer, pbBufferPtr, pcbActual);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetProfileBytes(this ComPtr<IWICColorContext> thisVtbl, uint cbBuffer, ref byte pbBuffer, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pbBufferPtr = &pbBuffer)
        {
            fixed (uint* pcbActualPtr = &pcbActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)@this->LpVtbl[7])(@this, cbBuffer, pbBufferPtr, pcbActualPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProfileBytes(this ComPtr<IWICColorContext> thisVtbl, uint cbBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)@this->LpVtbl[7])(@this, cbBuffer, pbBufferPtr, pcbActual);
        SilkMarshal.Free((nint)pbBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetProfileBytes(this ComPtr<IWICColorContext> thisVtbl, uint cbBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref uint pcbActual)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
        fixed (uint* pcbActualPtr = &pcbActual)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)@this->LpVtbl[7])(@this, cbBuffer, pbBufferPtr, pcbActualPtr);
        }
        SilkMarshal.Free((nint)pbBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExifColorSpace(this ComPtr<IWICColorContext> thisVtbl, uint* pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint*, int>)@this->LpVtbl[8])(@this, pValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetExifColorSpace(this ComPtr<IWICColorContext> thisVtbl, ref uint pValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pValuePtr = &pValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint*, int>)@this->LpVtbl[8])(@this, pValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICColorContext> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICColorContext> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICColorContext> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromFilename(this ComPtr<IWICColorContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wzFilename)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InitializeFromFilename(in wzFilename.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int InitializeFromMemory(this ComPtr<IWICColorContext> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pbBuffer, uint cbBufferSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->InitializeFromMemory(in pbBuffer.GetPinnableReference(), cbBufferSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetType(this ComPtr<IWICColorContext> thisVtbl, Span<ColorContextType> pType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetType(ref pType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProfileBytes(this ComPtr<IWICColorContext> thisVtbl, uint cbBuffer, byte* pbBuffer, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetProfileBytes(cbBuffer, pbBuffer, ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetProfileBytes(this ComPtr<IWICColorContext> thisVtbl, uint cbBuffer, Span<byte> pbBuffer, uint* pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetProfileBytes(cbBuffer, ref pbBuffer.GetPinnableReference(), pcbActual);
    }

    /// <summary>To be documented.</summary>
    public static int GetProfileBytes(this ComPtr<IWICColorContext> thisVtbl, uint cbBuffer, Span<byte> pbBuffer, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetProfileBytes(cbBuffer, ref pbBuffer.GetPinnableReference(), ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetProfileBytes(this ComPtr<IWICColorContext> thisVtbl, uint cbBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, Span<uint> pcbActual)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetProfileBytes(cbBuffer, pbBuffer, ref pcbActual.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetExifColorSpace(this ComPtr<IWICColorContext> thisVtbl, Span<uint> pValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetExifColorSpace(ref pValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICColorContext> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
