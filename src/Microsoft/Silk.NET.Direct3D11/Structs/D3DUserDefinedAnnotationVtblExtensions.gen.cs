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
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
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
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BeginEvent<TThis>(this TThis thisVtbl, char* Name) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, int>)@this->LpVtbl[3])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginEvent<TThis>(this TThis thisVtbl, ref char Name) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, int>)@this->LpVtbl[3])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int BeginEvent<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, byte*, int>)@this->LpVtbl[3])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EndEvent<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void SetMarker<TThis>(this TThis thisVtbl, char* Name) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, void>)@this->LpVtbl[5])(@this, Name);
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<TThis>(this TThis thisVtbl, ref char Name) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        fixed (char* NamePtr = &Name)
        {
            ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, void>)@this->LpVtbl[5])(@this, NamePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
        ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, byte*, void>)@this->LpVtbl[5])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
    }

    /// <summary>To be documented.</summary>
    public static int GetStatus<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, int>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, void** ppvObject) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Span<Guid> riid, ref void* ppvObject) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int BeginEvent<TThis>(this TThis thisVtbl, Span<char> Name) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->BeginEvent(ref Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void SetMarker<TThis>(this TThis thisVtbl, Span<char> Name) where TThis : IComVtbl<ID3DUserDefinedAnnotation>
    {
        var @this = (ID3DUserDefinedAnnotation*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        @this->SetMarker(ref Name.GetPinnableReference());
    }

}
