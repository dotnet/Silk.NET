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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class Marshal2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMarshal2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMarshal2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMarshal2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pv, dwDestContext, pvDestContext, mshlflags, pCid);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref Guid pCid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pCidPtr = &pCid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pv, dwDestContext, pvDestContext, mshlflags, pCidPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pv, dwDestContext, pvDestContextPtr, mshlflags, pCid);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, ref Guid pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            fixed (Guid* pCidPtr = &pCid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pv, dwDestContext, pvDestContextPtr, mshlflags, pCidPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pvPtr, dwDestContext, pvDestContext, mshlflags, pCid);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref Guid pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (Guid* pCidPtr = &pCid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pvPtr, dwDestContext, pvDestContext, mshlflags, pCidPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pCid);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, ref Guid pCid) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (Guid* pCidPtr = &pCid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pCidPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pv, dwDestContext, pvDestContext, mshlflags, pCid);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref Guid pCid)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (Guid* pCidPtr = &pCid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pv, dwDestContext, pvDestContext, mshlflags, pCidPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pv, dwDestContext, pvDestContextPtr, mshlflags, pCid);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, ref Guid pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (Guid* pCidPtr = &pCid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pv, dwDestContext, pvDestContextPtr, mshlflags, pCidPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pvPtr, dwDestContext, pvDestContext, mshlflags, pCid);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref Guid pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvPtr = &pv)
            {
                fixed (Guid* pCidPtr = &pCid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pvPtr, dwDestContext, pvDestContext, mshlflags, pCidPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0, T1>(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvPtr = &pv)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pCid);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetUnmarshalClass<T0, T1>(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, ref Guid pCid) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvPtr = &pv)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    fixed (Guid* pCidPtr = &pCid)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riidPtr, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pCidPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pv, dwDestContext, pvDestContext, mshlflags, pSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref uint pSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pSizePtr = &pSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pv, dwDestContext, pvDestContext, mshlflags, pSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pv, dwDestContext, pvDestContextPtr, mshlflags, pSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, ref uint pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            fixed (uint* pSizePtr = &pSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pv, dwDestContext, pvDestContextPtr, mshlflags, pSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pvPtr, dwDestContext, pvDestContext, mshlflags, pSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref uint pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (uint* pSizePtr = &pSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pvPtr, dwDestContext, pvDestContext, mshlflags, pSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, ref uint pSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (uint* pSizePtr = &pSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pv, dwDestContext, pvDestContext, mshlflags, pSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref uint pSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (uint* pSizePtr = &pSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pv, dwDestContext, pvDestContext, mshlflags, pSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pv, dwDestContext, pvDestContextPtr, mshlflags, pSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags, ref uint pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (uint* pSizePtr = &pSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pv, dwDestContext, pvDestContextPtr, mshlflags, pSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pvPtr, dwDestContext, pvDestContext, mshlflags, pSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags, ref uint pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvPtr = &pv)
            {
                fixed (uint* pSizePtr = &pSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pvPtr, dwDestContext, pvDestContext, mshlflags, pSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0, T1>(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvPtr = &pv)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pSize);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMarshalSizeMax<T0, T1>(this ComPtr<IMarshal2> thisVtbl, ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags, ref uint pSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvPtr = &pv)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    fixed (uint* pSizePtr = &pSize)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riidPtr, pvPtr, dwDestContext, pvDestContextPtr, mshlflags, pSizePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riid, pv, dwDestContext, pvDestContext, mshlflags);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riid, pv, dwDestContext, pvDestContextPtr, mshlflags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riid, pvPtr, dwDestContext, pvDestContext, mshlflags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvPtr = &pv)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riid, pvPtr, dwDestContext, pvDestContextPtr, mshlflags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riidPtr, pv, dwDestContext, pvDestContext, mshlflags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riidPtr, pv, dwDestContext, pvDestContextPtr, mshlflags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riidPtr, pvPtr, dwDestContext, pvDestContext, mshlflags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void* pvPtr = &pv)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riidPtr, pvPtr, dwDestContext, pvDestContextPtr, mshlflags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riid, pv, dwDestContext, pvDestContext, mshlflags);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riid, pv, dwDestContext, pvDestContextPtr, mshlflags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            fixed (void* pvPtr = &pv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riid, pvPtr, dwDestContext, pvDestContext, mshlflags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0, T1>(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            fixed (void* pvPtr = &pv)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riid, pvPtr, dwDestContext, pvDestContextPtr, mshlflags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riidPtr, pv, dwDestContext, pvDestContext, mshlflags);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riidPtr, pv, dwDestContext, pvDestContextPtr, mshlflags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvPtr = &pv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riidPtr, pvPtr, dwDestContext, pvDestContext, mshlflags);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int MarshalInterface<T0, T1>(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* pvPtr = &pv)
                {
                    fixed (void* pvDestContextPtr = &pvDestContext)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStmPtr, riidPtr, pvPtr, dwDestContext, pvDestContextPtr, mshlflags);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStm, riid, ppv);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvPtr = &ppv)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStm, riid, ppvPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, ref Guid riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStm, riidPtr, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, ref Guid riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStm, riidPtr, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStmPtr, riid, ppv);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStmPtr, riid, ppvPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, ref Guid riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStmPtr, riidPtr, ppv);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, ref Guid riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStmPtr, riidPtr, ppvPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReleaseMarshalData(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[7])(@this, pStm);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseMarshalData(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[7])(@this, pStmPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DisconnectObject(this ComPtr<IMarshal2> thisVtbl, uint dwReserved)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMarshal2*, uint, int>)@this->LpVtbl[8])(@this, dwReserved);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMarshal2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Span<Guid> pCid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(riid, pv, dwDestContext, pvDestContext, mshlflags, ref pCid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, Span<T0> pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(riid, pv, dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, pCid);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, Span<T0> pvDestContext, uint mshlflags, Span<Guid> pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(riid, pv, dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, ref pCid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, Span<T0> pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(riid, ref pv.GetPinnableReference(), dwDestContext, pvDestContext, mshlflags, pCid);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, Span<T0> pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Span<Guid> pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(riid, ref pv.GetPinnableReference(), dwDestContext, pvDestContext, mshlflags, ref pCid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, Span<T0> pv, uint dwDestContext, Span<T1> pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(riid, ref pv.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, pCid);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, Span<T0> pv, uint dwDestContext, Span<T1> pvDestContext, uint mshlflags, Span<Guid> pCid) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(riid, ref pv.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, ref pCid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(ref riid.GetPinnableReference(), pv, dwDestContext, pvDestContext, mshlflags, pCid);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Span<Guid> pCid)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(ref riid.GetPinnableReference(), pv, dwDestContext, pvDestContext, mshlflags, ref pCid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, void* pv, uint dwDestContext, Span<T0> pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(ref riid.GetPinnableReference(), pv, dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, pCid);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, void* pv, uint dwDestContext, Span<T0> pvDestContext, uint mshlflags, Span<Guid> pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(ref riid.GetPinnableReference(), pv, dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, ref pCid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, Span<T0> pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(ref riid.GetPinnableReference(), ref pv.GetPinnableReference(), dwDestContext, pvDestContext, mshlflags, pCid);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0>(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, Span<T0> pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Span<Guid> pCid) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(ref riid.GetPinnableReference(), ref pv.GetPinnableReference(), dwDestContext, pvDestContext, mshlflags, ref pCid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnmarshalClass<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, Span<T0> pv, uint dwDestContext, Span<T1> pvDestContext, uint mshlflags, Guid* pCid) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(ref riid.GetPinnableReference(), ref pv.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, pCid);
    }

    /// <summary>To be documented.</summary>
    public static int GetUnmarshalClass<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, Span<T0> pv, uint dwDestContext, Span<T1> pvDestContext, uint mshlflags, Span<Guid> pCid) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnmarshalClass(ref riid.GetPinnableReference(), ref pv.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, ref pCid.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Span<uint> pSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(riid, pv, dwDestContext, pvDestContext, mshlflags, ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, Span<T0> pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(riid, pv, dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, pSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, void* pv, uint dwDestContext, Span<T0> pvDestContext, uint mshlflags, Span<uint> pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(riid, pv, dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, Span<T0> pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(riid, ref pv.GetPinnableReference(), dwDestContext, pvDestContext, mshlflags, pSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, Span<T0> pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Span<uint> pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(riid, ref pv.GetPinnableReference(), dwDestContext, pvDestContext, mshlflags, ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, Span<T0> pv, uint dwDestContext, Span<T1> pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(riid, ref pv.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, pSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Guid* riid, Span<T0> pv, uint dwDestContext, Span<T1> pvDestContext, uint mshlflags, Span<uint> pSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(riid, ref pv.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(ref riid.GetPinnableReference(), pv, dwDestContext, pvDestContext, mshlflags, pSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Span<uint> pSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(ref riid.GetPinnableReference(), pv, dwDestContext, pvDestContext, mshlflags, ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, void* pv, uint dwDestContext, Span<T0> pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(ref riid.GetPinnableReference(), pv, dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, pSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, void* pv, uint dwDestContext, Span<T0> pvDestContext, uint mshlflags, Span<uint> pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(ref riid.GetPinnableReference(), pv, dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, Span<T0> pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(ref riid.GetPinnableReference(), ref pv.GetPinnableReference(), dwDestContext, pvDestContext, mshlflags, pSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0>(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, Span<T0> pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Span<uint> pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(ref riid.GetPinnableReference(), ref pv.GetPinnableReference(), dwDestContext, pvDestContext, mshlflags, ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMarshalSizeMax<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, Span<T0> pv, uint dwDestContext, Span<T1> pvDestContext, uint mshlflags, uint* pSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(ref riid.GetPinnableReference(), ref pv.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, pSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetMarshalSizeMax<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Span<Guid> riid, Span<T0> pv, uint dwDestContext, Span<T1> pvDestContext, uint mshlflags, Span<uint> pSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMarshalSizeMax(ref riid.GetPinnableReference(), ref pv.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags, ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<TI0>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, riid, pv, dwDestContext, pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, void* pv, uint dwDestContext, Span<T0> pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(pStm, riid, pv, dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0, TI0>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm, Guid* riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, riid, pv, dwDestContext, ref pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, Span<T0> pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(pStm, riid, ref pv.GetPinnableReference(), dwDestContext, pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0, TI0>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm, Guid* riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, riid, ref pv, dwDestContext, pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, Span<T0> pv, uint dwDestContext, Span<T1> pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(pStm, riid, ref pv.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0, T1, TI0>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm, Guid* riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, riid, ref pv, dwDestContext, ref pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Span<Guid> riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(pStm, ref riid.GetPinnableReference(), pv, dwDestContext, pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<TI0>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm, ref Guid riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, ref riid, pv, dwDestContext, pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Span<Guid> riid, void* pv, uint dwDestContext, Span<T0> pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(pStm, ref riid.GetPinnableReference(), pv, dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0, TI0>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm, ref Guid riid, void* pv, uint dwDestContext, ref T0 pvDestContext, uint mshlflags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, ref riid, pv, dwDestContext, ref pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Span<Guid> riid, Span<T0> pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(pStm, ref riid.GetPinnableReference(), ref pv.GetPinnableReference(), dwDestContext, pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0, TI0>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm, ref Guid riid, ref T0 pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, ref riid, ref pv, dwDestContext, pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Span<Guid> riid, Span<T0> pv, uint dwDestContext, Span<T1> pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(pStm, ref riid.GetPinnableReference(), ref pv.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static int MarshalInterface<T0, T1, TI0>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm, ref Guid riid, ref T0 pv, uint dwDestContext, ref T1 pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, ref riid, ref pv, dwDestContext, ref pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(ref pStm.GetPinnableReference(), riid, pv, dwDestContext, pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Guid* riid, void* pv, uint dwDestContext, Span<T0> pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(ref pStm.GetPinnableReference(), riid, pv, dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Guid* riid, Span<T0> pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(ref pStm.GetPinnableReference(), riid, ref pv.GetPinnableReference(), dwDestContext, pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Guid* riid, Span<T0> pv, uint dwDestContext, Span<T1> pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(ref pStm.GetPinnableReference(), riid, ref pv.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Span<Guid> riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(ref pStm.GetPinnableReference(), ref riid.GetPinnableReference(), pv, dwDestContext, pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Span<Guid> riid, void* pv, uint dwDestContext, Span<T0> pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(ref pStm.GetPinnableReference(), ref riid.GetPinnableReference(), pv, dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MarshalInterface<T0>(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Span<Guid> riid, Span<T0> pv, uint dwDestContext, void* pvDestContext, uint mshlflags) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(ref pStm.GetPinnableReference(), ref riid.GetPinnableReference(), ref pv.GetPinnableReference(), dwDestContext, pvDestContext, mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static int MarshalInterface<T0, T1>(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Span<Guid> riid, Span<T0> pv, uint dwDestContext, Span<T1> pvDestContext, uint mshlflags) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MarshalInterface(ref pStm.GetPinnableReference(), ref riid.GetPinnableReference(), ref pv.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), mshlflags);
    }

    /// <summary>To be documented.</summary>
    public static int UnmarshalInterface<TI0, TI1>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm, out ComPtr<TI1> ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->UnmarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface<TI0>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm, Guid* riid, ref void* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UnmarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Span<Guid> riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UnmarshalInterface(pStm, ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface<TI0>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm, ref Guid riid, void** ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UnmarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, ref riid, ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Span<Guid> riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UnmarshalInterface(pStm, ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface<TI0>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm, ref Guid riid, ref void* ppv) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->UnmarshalInterface((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, ref riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Guid* riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UnmarshalInterface(ref pStm.GetPinnableReference(), riid, ppv);
    }

    /// <summary>To be documented.</summary>
    public static int UnmarshalInterface<TI0>(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppv = default;
        return @this->UnmarshalInterface(ref pStm, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Guid* riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UnmarshalInterface(ref pStm.GetPinnableReference(), riid, ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Span<Guid> riid, void** ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UnmarshalInterface(ref pStm.GetPinnableReference(), ref riid.GetPinnableReference(), ppv);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int UnmarshalInterface(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Span<Guid> riid, ref void* ppv)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->UnmarshalInterface(ref pStm.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppv);
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseMarshalData<TI0>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ReleaseMarshalData((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseMarshalData(this ComPtr<IMarshal2> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReleaseMarshalData(ref pStm.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMarshal2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> UnmarshalInterface<TI0, TI1>(this ComPtr<IMarshal2> thisVtbl, ComPtr<TI0> pStm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->UnmarshalInterface(pStm, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> UnmarshalInterface<TI0>(this ComPtr<IMarshal2> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->UnmarshalInterface(ref pStm, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
