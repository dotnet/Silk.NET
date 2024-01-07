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

public unsafe static class WICMetadataWriterVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataWriter> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataWriter> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataWriter> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataWriter> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IWICMetadataWriter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IWICMetadataWriter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataFormat(this ComPtr<IWICMetadataWriter> thisVtbl, Guid* pguidMetadataFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, Guid*, int>)@this->LpVtbl[3])(@this, pguidMetadataFormat);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataFormat(this ComPtr<IWICMetadataWriter> thisVtbl, ref Guid pguidMetadataFormat)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pguidMetadataFormatPtr = &pguidMetadataFormat)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, Guid*, int>)@this->LpVtbl[3])(@this, pguidMetadataFormatPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataHandlerInfo(this ComPtr<IWICMetadataWriter> thisVtbl, IWICMetadataHandlerInfo** ppIHandler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, IWICMetadataHandlerInfo**, int>)@this->LpVtbl[4])(@this, ppIHandler);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetadataHandlerInfo(this ComPtr<IWICMetadataWriter> thisVtbl, ref IWICMetadataHandlerInfo* ppIHandler)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICMetadataHandlerInfo** ppIHandlerPtr = &ppIHandler)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, IWICMetadataHandlerInfo**, int>)@this->LpVtbl[4])(@this, ppIHandlerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCount(this ComPtr<IWICMetadataWriter> thisVtbl, uint* pcCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint*, int>)@this->LpVtbl[5])(@this, pcCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetCount(this ComPtr<IWICMetadataWriter> thisVtbl, ref uint pcCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcCountPtr = &pcCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint*, int>)@this->LpVtbl[5])(@this, pcCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, void* pvarSchema, void* pvarId, void* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchema, pvarId, pvarValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, void* pvarSchema, void* pvarId, ref T0 pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarValuePtr = &pvarValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchema, pvarId, pvarValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, void* pvarSchema, ref T0 pvarId, void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarIdPtr = &pvarId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchema, pvarIdPtr, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, void* pvarSchema, ref T0 pvarId, ref T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarIdPtr = &pvarId)
        {
            fixed (void* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchema, pvarIdPtr, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, ref T0 pvarSchema, void* pvarId, void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchemaPtr, pvarId, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, ref T0 pvarSchema, void* pvarId, ref T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchemaPtr, pvarId, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, ref T0 pvarSchema, ref T1 pvarId, void* pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarIdPtr = &pvarId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchemaPtr, pvarIdPtr, pvarValue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetValueByIndex<T0, T1, T2>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, ref T0 pvarSchema, ref T1 pvarId, ref T2 pvarValue) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarIdPtr = &pvarId)
            {
                fixed (void* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[6])(@this, nIndex, pvarSchemaPtr, pvarIdPtr, pvarValuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, void* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchema, pvarId, pvarValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, ref T0 pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarValuePtr = &pvarValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchema, pvarId, pvarValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarId, void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarIdPtr = &pvarId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchema, pvarIdPtr, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarId, ref T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarIdPtr = &pvarId)
        {
            fixed (void* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchema, pvarIdPtr, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchemaPtr, pvarId, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, ref T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchemaPtr, pvarId, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pvarId, void* pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarIdPtr = &pvarId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchemaPtr, pvarIdPtr, pvarValue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetValue<T0, T1, T2>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pvarId, ref T2 pvarValue) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarIdPtr = &pvarId)
            {
                fixed (void* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[7])(@this, pvarSchemaPtr, pvarIdPtr, pvarValuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEnumerator(this ComPtr<IWICMetadataWriter> thisVtbl, IWICEnumMetadataItem** ppIEnumMetadata)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, IWICEnumMetadataItem**, int>)@this->LpVtbl[8])(@this, ppIEnumMetadata);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetEnumerator(this ComPtr<IWICMetadataWriter> thisVtbl, ref IWICEnumMetadataItem* ppIEnumMetadata)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IWICEnumMetadataItem** ppIEnumMetadataPtr = &ppIEnumMetadata)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, IWICEnumMetadataItem**, int>)@this->LpVtbl[8])(@this, ppIEnumMetadataPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchema, pvarId, pvarValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarValuePtr = &pvarValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchema, pvarId, pvarValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarIdPtr = &pvarId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchema, pvarIdPtr, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarIdPtr = &pvarId)
        {
            fixed (void* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchema, pvarIdPtr, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchemaPtr, pvarId, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchemaPtr, pvarId, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarIdPtr = &pvarId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchemaPtr, pvarIdPtr, pvarValue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetValue<T0, T1, T2>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T2 pvarValue) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarIdPtr = &pvarId)
            {
                fixed (void* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, void*, int>)@this->LpVtbl[9])(@this, pvarSchemaPtr, pvarIdPtr, pvarValuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchema, pvarId, pvarValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarValuePtr = &pvarValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchema, pvarId, pvarValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarIdPtr = &pvarId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchema, pvarIdPtr, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarIdPtr = &pvarId)
        {
            fixed (void* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchema, pvarIdPtr, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchemaPtr, pvarId, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchemaPtr, pvarId, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarIdPtr = &pvarId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchemaPtr, pvarIdPtr, pvarValue);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetValueByIndex<T0, T1, T2>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T2 pvarValue) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarIdPtr = &pvarId)
            {
                fixed (void* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, void*, void*, void*, int>)@this->LpVtbl[10])(@this, nIndex, pvarSchemaPtr, pvarIdPtr, pvarValuePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveValue(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, int>)@this->LpVtbl[11])(@this, pvarSchema, pvarId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarId) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarIdPtr = &pvarId)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, int>)@this->LpVtbl[11])(@this, pvarSchema, pvarIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, int>)@this->LpVtbl[11])(@this, pvarSchemaPtr, pvarId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 pvarId) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvarSchemaPtr = &pvarSchema)
        {
            fixed (void* pvarIdPtr = &pvarId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, void*, void*, int>)@this->LpVtbl[11])(@this, pvarSchemaPtr, pvarIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int RemoveValueByIndex(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataWriter*, uint, int>)@this->LpVtbl[12])(@this, nIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IWICMetadataWriter> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataWriter> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IWICMetadataWriter> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataFormat(this ComPtr<IWICMetadataWriter> thisVtbl, Span<Guid> pguidMetadataFormat)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMetadataFormat(ref pguidMetadataFormat.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMetadataHandlerInfo<TI0>(this ComPtr<IWICMetadataWriter> thisVtbl, ref ComPtr<TI0> ppIHandler) where TI0 : unmanaged, IComVtbl<IWICMetadataHandlerInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMetadataHandlerInfo((IWICMetadataHandlerInfo**) ppIHandler.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetCount(this ComPtr<IWICMetadataWriter> thisVtbl, Span<uint> pcCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetCount(ref pcCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, void* pvarSchema, void* pvarId, Span<T0> pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, pvarSchema, pvarId, ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, void* pvarSchema, Span<T0> pvarId, void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, pvarSchema, ref pvarId.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, void* pvarSchema, Span<T0> pvarId, Span<T1> pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, pvarSchema, ref pvarId.GetPinnableReference(), ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, Span<T0> pvarSchema, void* pvarId, void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, ref pvarSchema.GetPinnableReference(), pvarId, pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, Span<T0> pvarSchema, void* pvarId, Span<T1> pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, ref pvarSchema.GetPinnableReference(), pvarId, ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValueByIndex<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, Span<T0> pvarSchema, Span<T1> pvarId, void* pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, ref pvarSchema.GetPinnableReference(), ref pvarId.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetValueByIndex<T0, T1, T2>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, Span<T0> pvarSchema, Span<T1> pvarId, Span<T2> pvarValue) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValueByIndex(nIndex, ref pvarSchema.GetPinnableReference(), ref pvarId.GetPinnableReference(), ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, Span<T0> pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(pvarSchema, pvarId, ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarId, void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(pvarSchema, in pvarId.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarId, Span<T1> pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(pvarSchema, in pvarId.GetPinnableReference(), ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(in pvarSchema.GetPinnableReference(), pvarId, pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, Span<T1> pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(in pvarSchema.GetPinnableReference(), pvarId, ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pvarId, void* pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(in pvarSchema.GetPinnableReference(), in pvarId.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static int GetValue<T0, T1, T2>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pvarId, Span<T2> pvarValue) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetValue(in pvarSchema.GetPinnableReference(), in pvarId.GetPinnableReference(), ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetEnumerator<TI0>(this ComPtr<IWICMetadataWriter> thisVtbl, ref ComPtr<TI0> ppIEnumMetadata) where TI0 : unmanaged, IComVtbl<IWICEnumMetadataItem>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetEnumerator((IWICEnumMetadataItem**) ppIEnumMetadata.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValue(pvarSchema, pvarId, in pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValue(pvarSchema, in pvarId.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValue(pvarSchema, in pvarId.GetPinnableReference(), in pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValue(in pvarSchema.GetPinnableReference(), pvarId, pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValue(in pvarSchema.GetPinnableReference(), pvarId, in pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValue(in pvarSchema.GetPinnableReference(), in pvarId.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static int SetValue<T0, T1, T2>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T2> pvarValue) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValue(in pvarSchema.GetPinnableReference(), in pvarId.GetPinnableReference(), in pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValueByIndex(nIndex, pvarSchema, pvarId, in pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValueByIndex(nIndex, pvarSchema, in pvarId.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValueByIndex(nIndex, pvarSchema, in pvarId.GetPinnableReference(), in pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValueByIndex(nIndex, in pvarSchema.GetPinnableReference(), pvarId, pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValueByIndex(nIndex, in pvarSchema.GetPinnableReference(), pvarId, in pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetValueByIndex<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarValue) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValueByIndex(nIndex, in pvarSchema.GetPinnableReference(), in pvarId.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static int SetValueByIndex<T0, T1, T2>(this ComPtr<IWICMetadataWriter> thisVtbl, uint nIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pvarId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T2> pvarValue) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetValueByIndex(nIndex, in pvarSchema.GetPinnableReference(), in pvarId.GetPinnableReference(), in pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarId) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RemoveValue(pvarSchema, in pvarId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RemoveValue<T0>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pvarId) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RemoveValue(in pvarSchema.GetPinnableReference(), pvarId);
    }

    /// <summary>To be documented.</summary>
    public static int RemoveValue<T0, T1>(this ComPtr<IWICMetadataWriter> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pvarSchema, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T1> pvarId) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RemoveValue(in pvarSchema.GetPinnableReference(), in pvarId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IWICMetadataWriter> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
