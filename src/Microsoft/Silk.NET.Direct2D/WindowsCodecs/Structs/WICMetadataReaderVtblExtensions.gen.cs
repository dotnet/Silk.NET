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

public unsafe static class WICMetadataReaderVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataReader> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataReader> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataReader> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataReader> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICMetadataReader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICMetadataReader> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataFormat(this ComPtr<IWICMetadataReader> thisVtbl, Guid* pguidMetadataFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Guid*, int>)@this->LpVtbl[3])(@this, pguidMetadataFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataFormat(this ComPtr<IWICMetadataReader> thisVtbl, ref Guid pguidMetadataFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidMetadataFormatPtr = &pguidMetadataFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Guid*, int>)@this->LpVtbl[3])(@this, pguidMetadataFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataHandlerInfo(this ComPtr<IWICMetadataReader> thisVtbl, IWICMetadataHandlerInfo** ppIHandler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, IWICMetadataHandlerInfo**, int>)@this->LpVtbl[4])(@this, ppIHandler);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataHandlerInfo(this ComPtr<IWICMetadataReader> thisVtbl, ref IWICMetadataHandlerInfo* ppIHandler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataHandlerInfo** ppIHandlerPtr = &ppIHandler)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, IWICMetadataHandlerInfo**, int>)@this->LpVtbl[4])(@this, ppIHandlerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCount(this ComPtr<IWICMetadataReader> thisVtbl, uint* pcCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint*, int>)@this->LpVtbl[5])(@this, pcCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCount(this ComPtr<IWICMetadataReader> thisVtbl, ref uint pcCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcCountPtr = &pcCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint*, int>)@this->LpVtbl[5])(@this, pcCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, Silk.NET.Core.Win32Extras.PropVariant* pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchema, pvarId, pvarValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, Silk.NET.Core.Win32Extras.PropVariant* pvarId, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchema, pvarId, pvarValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, ref Silk.NET.Core.Win32Extras.PropVariant pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarIdPtr = &pvarId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchema, pvarIdPtr, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, ref Silk.NET.Core.Win32Extras.PropVariant pvarId, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarIdPtr = &pvarId)
        {
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchema, pvarIdPtr, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, ref Silk.NET.Core.Win32Extras.PropVariant pvarSchema, Silk.NET.Core.Win32Extras.PropVariant* pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarSchemaPtr = &pvarSchema)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchemaPtr, pvarId, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, ref Silk.NET.Core.Win32Extras.PropVariant pvarSchema, Silk.NET.Core.Win32Extras.PropVariant* pvarId, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarSchemaPtr = &pvarSchema)
        {
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchemaPtr, pvarId, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, ref Silk.NET.Core.Win32Extras.PropVariant pvarSchema, ref Silk.NET.Core.Win32Extras.PropVariant pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarSchemaPtr = &pvarSchema)
        {
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarIdPtr = &pvarId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchemaPtr, pvarIdPtr, pvarValue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, ref Silk.NET.Core.Win32Extras.PropVariant pvarSchema, ref Silk.NET.Core.Win32Extras.PropVariant pvarId, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarSchemaPtr = &pvarSchema)
        {
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarIdPtr = &pvarId)
            {
                fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, uint, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchemaPtr, pvarIdPtr, pvarValuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, pvarSchema, pvarId, pvarValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarId, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, pvarSchema, pvarId, pvarValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.PropVariant pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarIdPtr = &pvarId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, pvarSchema, pvarIdPtr, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.PropVariant pvarId, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarIdPtr = &pvarId)
        {
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, pvarSchema, pvarIdPtr, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.PropVariant pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarSchemaPtr = &pvarSchema)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, pvarSchemaPtr, pvarId, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.PropVariant pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarId, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarSchemaPtr = &pvarSchema)
        {
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, pvarSchemaPtr, pvarId, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.PropVariant pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.PropVariant pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarSchemaPtr = &pvarSchema)
        {
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarIdPtr = &pvarId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, pvarSchemaPtr, pvarIdPtr, pvarValue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.PropVariant pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Win32Extras.PropVariant pvarId, ref Silk.NET.Core.Win32Extras.PropVariant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarSchemaPtr = &pvarSchema)
        {
            fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarIdPtr = &pvarId)
            {
                fixed (Silk.NET.Core.Win32Extras.PropVariant* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, Silk.NET.Core.Win32Extras.PropVariant*, int>)@this->LpVtbl[7])(@this, pvarSchemaPtr, pvarIdPtr, pvarValuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEnumerator(this ComPtr<IWICMetadataReader> thisVtbl, IWICEnumMetadataItem** ppIEnumMetadata)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, IWICEnumMetadataItem**, int>)@this->LpVtbl[8])(@this, ppIEnumMetadata);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEnumerator(this ComPtr<IWICMetadataReader> thisVtbl, ref IWICEnumMetadataItem* ppIEnumMetadata)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICEnumMetadataItem** ppIEnumMetadataPtr = &ppIEnumMetadata)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReader*, IWICEnumMetadataItem**, int>)@this->LpVtbl[8])(@this, ppIEnumMetadataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICMetadataReader> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataReader> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataReader> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataFormat(this ComPtr<IWICMetadataReader> thisVtbl, Span<Guid> pguidMetadataFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMetadataFormat(ref pguidMetadataFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataHandlerInfo<TI0>(this ComPtr<IWICMetadataReader> thisVtbl, ref ComPtr<TI0> ppIHandler) where TI0 : unmanaged, IComVtbl<IWICMetadataHandlerInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMetadataHandlerInfo((IWICMetadataHandlerInfo**) ppIHandler.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetCount(this ComPtr<IWICMetadataReader> thisVtbl, Span<uint> pcCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCount(ref pcCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, Silk.NET.Core.Win32Extras.PropVariant* pvarId, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, pvarSchema, pvarId, ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, pvarSchema, ref pvarId.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarId, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, pvarSchema, ref pvarId.GetPinnableReference(), ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarSchema, Silk.NET.Core.Win32Extras.PropVariant* pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, ref pvarSchema.GetPinnableReference(), pvarId, pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarSchema, Silk.NET.Core.Win32Extras.PropVariant* pvarId, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, ref pvarSchema.GetPinnableReference(), pvarId, ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarSchema, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, ref pvarSchema.GetPinnableReference(), ref pvarId.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetValueByIndex(this ComPtr<IWICMetadataReader> thisVtbl, uint nIndex, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarSchema, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarId, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, ref pvarSchema.GetPinnableReference(), ref pvarId.GetPinnableReference(), ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarId, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(pvarSchema, pvarId, ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.PropVariant> pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(pvarSchema, in pvarId.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.PropVariant> pvarId, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(pvarSchema, in pvarId.GetPinnableReference(), ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.PropVariant> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(in pvarSchema.GetPinnableReference(), pvarId, pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.PropVariant> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.PropVariant* pvarId, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(in pvarSchema.GetPinnableReference(), pvarId, ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.PropVariant> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.PropVariant> pvarId, Silk.NET.Core.Win32Extras.PropVariant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(in pvarSchema.GetPinnableReference(), in pvarId.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetValue(this ComPtr<IWICMetadataReader> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.PropVariant> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Core.Win32Extras.PropVariant> pvarId, Span<Silk.NET.Core.Win32Extras.PropVariant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(in pvarSchema.GetPinnableReference(), in pvarId.GetPinnableReference(), ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetEnumerator<TI0>(this ComPtr<IWICMetadataReader> thisVtbl, ref ComPtr<TI0> ppIEnumMetadata) where TI0 : unmanaged, IComVtbl<IWICEnumMetadataItem>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEnumerator((IWICEnumMetadataItem**) ppIEnumMetadata.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICMetadataReader> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
