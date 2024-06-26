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

public unsafe static class WICMetadataQueryReaderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataQueryReader> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataQueryReader> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataQueryReader> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataQueryReader> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICMetadataQueryReader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICMetadataQueryReader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetContainerFormat(this ComPtr<IWICMetadataQueryReader> thisVtbl, Guid* pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, Guid*, int>)@this->LpVtbl[3])(@this, pguidContainerFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetContainerFormat(this ComPtr<IWICMetadataQueryReader> thisVtbl, ref Guid pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidContainerFormatPtr = &pguidContainerFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, Guid*, int>)@this->LpVtbl[3])(@this, pguidContainerFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocation(this ComPtr<IWICMetadataQueryReader> thisVtbl, uint cchMaxLength, char* wzNamespace, uint* pcchActualLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, uint, char*, uint*, int>)@this->LpVtbl[4])(@this, cchMaxLength, wzNamespace, pcchActualLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocation(this ComPtr<IWICMetadataQueryReader> thisVtbl, uint cchMaxLength, char* wzNamespace, ref uint pcchActualLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcchActualLengthPtr = &pcchActualLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, uint, char*, uint*, int>)@this->LpVtbl[4])(@this, cchMaxLength, wzNamespace, pcchActualLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocation(this ComPtr<IWICMetadataQueryReader> thisVtbl, uint cchMaxLength, ref char wzNamespace, uint* pcchActualLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzNamespacePtr = &wzNamespace)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, uint, char*, uint*, int>)@this->LpVtbl[4])(@this, cchMaxLength, wzNamespacePtr, pcchActualLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocation(this ComPtr<IWICMetadataQueryReader> thisVtbl, uint cchMaxLength, ref char wzNamespace, ref uint pcchActualLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzNamespacePtr = &wzNamespace)
        {
            fixed (uint* pcchActualLengthPtr = &pcchActualLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, uint, char*, uint*, int>)@this->LpVtbl[4])(@this, cchMaxLength, wzNamespacePtr, pcchActualLengthPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocation(this ComPtr<IWICMetadataQueryReader> thisVtbl, uint cchMaxLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzNamespace, uint* pcchActualLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzNamespacePtr = (byte*) SilkMarshal.StringToPtr(wzNamespace, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, cchMaxLength, wzNamespacePtr, pcchActualLength);
        SilkMarshal.Free((nint)wzNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocation(this ComPtr<IWICMetadataQueryReader> thisVtbl, uint cchMaxLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzNamespace, ref uint pcchActualLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzNamespacePtr = (byte*) SilkMarshal.StringToPtr(wzNamespace, NativeStringEncoding.UTF8);
        fixed (uint* pcchActualLengthPtr = &pcchActualLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, cchMaxLength, wzNamespacePtr, pcchActualLengthPtr);
        }
        SilkMarshal.Free((nint)wzNamespacePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataByName(this ComPtr<IWICMetadataQueryReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzName, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, char*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[5])(@this, wzName, pvarValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataByName(this ComPtr<IWICMetadataQueryReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzName, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, char*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[5])(@this, wzName, pvarValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataByName(this ComPtr<IWICMetadataQueryReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzName, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzNamePtr = &wzName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, char*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[5])(@this, wzNamePtr, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataByName(this ComPtr<IWICMetadataQueryReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzName, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* wzNamePtr = &wzName)
        {
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, char*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[5])(@this, wzNamePtr, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataByName(this ComPtr<IWICMetadataQueryReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzName, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzNamePtr = (byte*) SilkMarshal.StringToPtr(wzName, NativeStringEncoding.LPWStr);
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, byte*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[5])(@this, wzNamePtr, pvarValue);
        SilkMarshal.Free((nint)wzNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataByName(this ComPtr<IWICMetadataQueryReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzName, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var wzNamePtr = (byte*) SilkMarshal.StringToPtr(wzName, NativeStringEncoding.LPWStr);
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, byte*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[5])(@this, wzNamePtr, pvarValuePtr);
        }
        SilkMarshal.Free((nint)wzNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEnumerator(this ComPtr<IWICMetadataQueryReader> thisVtbl, Silk.NET.Core.Win32Extras.IEnumString** ppIEnumString)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, Silk.NET.Core.Win32Extras.IEnumString**, int>)@this->LpVtbl[6])(@this, ppIEnumString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEnumerator(this ComPtr<IWICMetadataQueryReader> thisVtbl, ref Silk.NET.Core.Win32Extras.IEnumString* ppIEnumString)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IEnumString** ppIEnumStringPtr = &ppIEnumString)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataQueryReader*, Silk.NET.Core.Win32Extras.IEnumString**, int>)@this->LpVtbl[6])(@this, ppIEnumStringPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICMetadataQueryReader> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataQueryReader> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataQueryReader> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetContainerFormat(this ComPtr<IWICMetadataQueryReader> thisVtbl, Span<Guid> pguidContainerFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetContainerFormat(ref pguidContainerFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocation(this ComPtr<IWICMetadataQueryReader> thisVtbl, uint cchMaxLength, char* wzNamespace, Span<uint> pcchActualLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocation(cchMaxLength, wzNamespace, ref pcchActualLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocation(this ComPtr<IWICMetadataQueryReader> thisVtbl, uint cchMaxLength, Span<char> wzNamespace, uint* pcchActualLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocation(cchMaxLength, ref wzNamespace.GetPinnableReference(), pcchActualLength);
    }

    /// <summary>To be documented.</summary>
    public static int GetLocation(this ComPtr<IWICMetadataQueryReader> thisVtbl, uint cchMaxLength, Span<char> wzNamespace, Span<uint> pcchActualLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocation(cchMaxLength, ref wzNamespace.GetPinnableReference(), ref pcchActualLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetLocation(this ComPtr<IWICMetadataQueryReader> thisVtbl, uint cchMaxLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzNamespace, Span<uint> pcchActualLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocation(cchMaxLength, wzNamespace, ref pcchActualLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataByName(this ComPtr<IWICMetadataQueryReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzName, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMetadataByName(wzName, ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataByName(this ComPtr<IWICMetadataQueryReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wzName, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMetadataByName(in wzName.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataByName(this ComPtr<IWICMetadataQueryReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wzName, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMetadataByName(in wzName.GetPinnableReference(), ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataByName(this ComPtr<IWICMetadataQueryReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzName, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMetadataByName(wzName, ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICMetadataQueryReader> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
