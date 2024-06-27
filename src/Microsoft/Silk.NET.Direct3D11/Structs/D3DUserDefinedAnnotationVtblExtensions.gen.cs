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

namespace Silk.NET.Direct3D11;

public unsafe static class D3DUserDefinedAnnotationVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginEvent(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, int>)@this->LpVtbl[3])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginEvent(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, int>)@this->LpVtbl[3])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginEvent(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, byte*, int>)@this->LpVtbl[3])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndEvent(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarker(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, void>)@this->LpVtbl[5])(@this, Name);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char Name)
    {
        var @this = thisVtbl.Handle;
        fixed (char* NamePtr = &Name)
        {
            ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, void>)@this->LpVtbl[5])(@this, NamePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
    {
        var @this = thisVtbl.Handle;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, byte*, void>)@this->LpVtbl[5])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 GetStatus(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Silk.NET.Core.Bool32>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int BeginEvent(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BeginEvent(in Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> Name)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->SetMarker(in Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID3DUserDefinedAnnotation> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
