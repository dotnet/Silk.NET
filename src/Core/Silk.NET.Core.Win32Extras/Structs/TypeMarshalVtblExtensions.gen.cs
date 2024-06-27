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

public unsafe static class TypeMarshalVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeMarshal> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeMarshal> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeMarshal> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeMarshal> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ITypeMarshal> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ITypeMarshal> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, uint* pSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvType, dwDestContext, pvDestContext, pSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, ref uint pSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pSizePtr = &pSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvType, dwDestContext, pvDestContext, pSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, ref T0 pvDestContext, uint* pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvType, dwDestContext, pvDestContextPtr, pSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, ref T0 pvDestContext, ref uint pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            fixed (uint* pSizePtr = &pSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvType, dwDestContext, pvDestContextPtr, pSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, void* pvDestContext, uint* pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvTypePtr, dwDestContext, pvDestContext, pSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, void* pvDestContext, ref uint pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (uint* pSizePtr = &pSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvTypePtr, dwDestContext, pvDestContext, pSizePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint* pSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, pSize);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Size<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, ref uint pSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (uint* pSizePtr = &pSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, pSizePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, byte* pBuffer, uint* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWritten);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, byte* pBuffer, ref uint pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbWrittenPtr = &pcbWritten)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWrittenPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, ref byte pBuffer, uint* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pBufferPtr = &pBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWritten);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, ref byte pBuffer, ref uint pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pBufferPtr = &pBuffer)
        {
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWrittenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWritten);
        SilkMarshal.Free((nint)pBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, ref uint pcbWritten)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
        fixed (uint* pcbWrittenPtr = &pcbWritten)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWrittenPtr);
        }
        SilkMarshal.Free((nint)pBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, ref T0 pvDestContext, uint cbBufferLength, byte* pBuffer, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContextPtr, cbBufferLength, pBuffer, pcbWritten);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, ref T0 pvDestContext, uint cbBufferLength, byte* pBuffer, ref uint pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContextPtr, cbBufferLength, pBuffer, pcbWrittenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, ref T0 pvDestContext, uint cbBufferLength, ref byte pBuffer, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            fixed (byte* pBufferPtr = &pBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWritten);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, ref T0 pvDestContext, uint cbBufferLength, ref byte pBuffer, ref uint pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
            fixed (byte* pBufferPtr = &pBuffer)
            {
                fixed (uint* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWrittenPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, ref T0 pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
        var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWritten);
        SilkMarshal.Free((nint)pBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, ref T0 pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, ref uint pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvDestContextPtr = &pvDestContext)
        {
        var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWrittenPtr);
            }
        SilkMarshal.Free((nint)pBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, byte* pBuffer, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWritten);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, byte* pBuffer, ref uint pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWrittenPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, ref byte pBuffer, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (byte* pBufferPtr = &pBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWritten);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, ref byte pBuffer, ref uint pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (byte* pBufferPtr = &pBuffer)
            {
                fixed (uint* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWrittenPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
        var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWritten);
        SilkMarshal.Free((nint)pBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, ref uint pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
        var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWrittenPtr);
            }
        SilkMarshal.Free((nint)pBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint cbBufferLength, byte* pBuffer, uint* pcbWritten) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, cbBufferLength, pBuffer, pcbWritten);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint cbBufferLength, byte* pBuffer, ref uint pcbWritten) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (uint* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, cbBufferLength, pBuffer, pcbWrittenPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint cbBufferLength, ref byte pBuffer, uint* pcbWritten) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (byte* pBufferPtr = &pBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWritten);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Marshal<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint cbBufferLength, ref byte pBuffer, ref uint pcbWritten) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (byte* pBufferPtr = &pBuffer)
                {
                    fixed (uint* pcbWrittenPtr = &pcbWritten)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWrittenPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbWritten) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
        var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWritten);
        SilkMarshal.Free((nint)pBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Marshal<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, ref uint pcbWritten) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
        var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
                fixed (uint* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWrittenPtr);
                }
        SilkMarshal.Free((nint)pBufferPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwFlags, uint cbBufferLength, byte* pBuffer, uint* pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvType, dwFlags, cbBufferLength, pBuffer, pcbRead);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwFlags, uint cbBufferLength, byte* pBuffer, ref uint pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcbReadPtr = &pcbRead)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvType, dwFlags, cbBufferLength, pBuffer, pcbReadPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwFlags, uint cbBufferLength, ref byte pBuffer, uint* pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pBufferPtr = &pBuffer)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvType, dwFlags, cbBufferLength, pBufferPtr, pcbRead);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwFlags, uint cbBufferLength, ref byte pBuffer, ref uint pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (byte* pBufferPtr = &pBuffer)
        {
            fixed (uint* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvType, dwFlags, cbBufferLength, pBufferPtr, pcbReadPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwFlags, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvType, dwFlags, cbBufferLength, pBufferPtr, pcbRead);
        SilkMarshal.Free((nint)pBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwFlags, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, ref uint pcbRead)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
        fixed (uint* pcbReadPtr = &pcbRead)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvType, dwFlags, cbBufferLength, pBufferPtr, pcbReadPtr);
        }
        SilkMarshal.Free((nint)pBufferPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwFlags, uint cbBufferLength, byte* pBuffer, uint* pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvTypePtr, dwFlags, cbBufferLength, pBuffer, pcbRead);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwFlags, uint cbBufferLength, byte* pBuffer, ref uint pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (uint* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvTypePtr, dwFlags, cbBufferLength, pBuffer, pcbReadPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwFlags, uint cbBufferLength, ref byte pBuffer, uint* pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (byte* pBufferPtr = &pBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvTypePtr, dwFlags, cbBufferLength, pBufferPtr, pcbRead);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Unmarshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwFlags, uint cbBufferLength, ref byte pBuffer, ref uint pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            fixed (byte* pBufferPtr = &pBuffer)
            {
                fixed (uint* pcbReadPtr = &pcbRead)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvTypePtr, dwFlags, cbBufferLength, pBufferPtr, pcbReadPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwFlags, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
        var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvTypePtr, dwFlags, cbBufferLength, pBufferPtr, pcbRead);
        SilkMarshal.Free((nint)pBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Unmarshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType, uint dwFlags, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, ref uint pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
        var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
            fixed (uint* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvTypePtr, dwFlags, cbBufferLength, pBufferPtr, pcbReadPtr);
            }
        SilkMarshal.Free((nint)pBufferPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Free(this ComPtr<ITypeMarshal> thisVtbl, void* pvType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, int>)@this->LpVtbl[6])(@this, pvType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Free<T0>(this ComPtr<ITypeMarshal> thisVtbl, ref T0 pvType) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* pvTypePtr = &pvType)
        {
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, int>)@this->LpVtbl[6])(@this, pvTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ITypeMarshal> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeMarshal> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ITypeMarshal> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, Span<uint> pSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Size(pvType, dwDestContext, pvDestContext, ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, Span<T0> pvDestContext, uint* pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Size(pvType, dwDestContext, ref pvDestContext.GetPinnableReference(), pSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, Span<T0> pvDestContext, Span<uint> pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Size(pvType, dwDestContext, ref pvDestContext.GetPinnableReference(), ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, void* pvDestContext, uint* pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Size(ref pvType.GetPinnableReference(), dwDestContext, pvDestContext, pSize);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, void* pvDestContext, Span<uint> pSize) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Size(ref pvType.GetPinnableReference(), dwDestContext, pvDestContext, ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Size<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, Span<T1> pvDestContext, uint* pSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Size(ref pvType.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), pSize);
    }

    /// <summary>To be documented.</summary>
    public static int Size<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, Span<T1> pvDestContext, Span<uint> pSize) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Size(ref pvType.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), ref pSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, byte* pBuffer, Span<uint> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(pvType, dwDestContext, pvDestContext, cbBufferLength, pBuffer, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, Span<byte> pBuffer, uint* pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(pvType, dwDestContext, pvDestContext, cbBufferLength, ref pBuffer.GetPinnableReference(), pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, Span<byte> pBuffer, Span<uint> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(pvType, dwDestContext, pvDestContext, cbBufferLength, ref pBuffer.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, Span<uint> pcbWritten)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(pvType, dwDestContext, pvDestContext, cbBufferLength, pBuffer, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, Span<T0> pvDestContext, uint cbBufferLength, byte* pBuffer, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(pvType, dwDestContext, ref pvDestContext.GetPinnableReference(), cbBufferLength, pBuffer, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, Span<T0> pvDestContext, uint cbBufferLength, byte* pBuffer, Span<uint> pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(pvType, dwDestContext, ref pvDestContext.GetPinnableReference(), cbBufferLength, pBuffer, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, Span<T0> pvDestContext, uint cbBufferLength, Span<byte> pBuffer, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(pvType, dwDestContext, ref pvDestContext.GetPinnableReference(), cbBufferLength, ref pBuffer.GetPinnableReference(), pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, Span<T0> pvDestContext, uint cbBufferLength, Span<byte> pBuffer, Span<uint> pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(pvType, dwDestContext, ref pvDestContext.GetPinnableReference(), cbBufferLength, ref pBuffer.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, Span<T0> pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(pvType, dwDestContext, ref pvDestContext.GetPinnableReference(), cbBufferLength, pBuffer, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwDestContext, Span<T0> pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, Span<uint> pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(pvType, dwDestContext, ref pvDestContext.GetPinnableReference(), cbBufferLength, pBuffer, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, byte* pBuffer, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(ref pvType.GetPinnableReference(), dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, byte* pBuffer, Span<uint> pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(ref pvType.GetPinnableReference(), dwDestContext, pvDestContext, cbBufferLength, pBuffer, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, Span<byte> pBuffer, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(ref pvType.GetPinnableReference(), dwDestContext, pvDestContext, cbBufferLength, ref pBuffer.GetPinnableReference(), pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, Span<byte> pBuffer, Span<uint> pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(ref pvType.GetPinnableReference(), dwDestContext, pvDestContext, cbBufferLength, ref pBuffer.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(ref pvType.GetPinnableReference(), dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, Span<uint> pcbWritten) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(ref pvType.GetPinnableReference(), dwDestContext, pvDestContext, cbBufferLength, pBuffer, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, Span<T1> pvDestContext, uint cbBufferLength, byte* pBuffer, uint* pcbWritten) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(ref pvType.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), cbBufferLength, pBuffer, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, Span<T1> pvDestContext, uint cbBufferLength, byte* pBuffer, Span<uint> pcbWritten) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(ref pvType.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), cbBufferLength, pBuffer, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, Span<T1> pvDestContext, uint cbBufferLength, Span<byte> pBuffer, uint* pcbWritten) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(ref pvType.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), cbBufferLength, ref pBuffer.GetPinnableReference(), pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static int Marshal<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, Span<T1> pvDestContext, uint cbBufferLength, Span<byte> pBuffer, Span<uint> pcbWritten) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(ref pvType.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), cbBufferLength, ref pBuffer.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Marshal<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, Span<T1> pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbWritten) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(ref pvType.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), cbBufferLength, pBuffer, pcbWritten);
    }

    /// <summary>To be documented.</summary>
    public static int Marshal<T0, T1>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwDestContext, Span<T1> pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, Span<uint> pcbWritten) where T0 : unmanaged where T1 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Marshal(ref pvType.GetPinnableReference(), dwDestContext, ref pvDestContext.GetPinnableReference(), cbBufferLength, pBuffer, ref pcbWritten.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwFlags, uint cbBufferLength, byte* pBuffer, Span<uint> pcbRead)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Unmarshal(pvType, dwFlags, cbBufferLength, pBuffer, ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwFlags, uint cbBufferLength, Span<byte> pBuffer, uint* pcbRead)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Unmarshal(pvType, dwFlags, cbBufferLength, ref pBuffer.GetPinnableReference(), pcbRead);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwFlags, uint cbBufferLength, Span<byte> pBuffer, Span<uint> pcbRead)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Unmarshal(pvType, dwFlags, cbBufferLength, ref pBuffer.GetPinnableReference(), ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal(this ComPtr<ITypeMarshal> thisVtbl, void* pvType, uint dwFlags, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, Span<uint> pcbRead)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Unmarshal(pvType, dwFlags, cbBufferLength, pBuffer, ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwFlags, uint cbBufferLength, byte* pBuffer, uint* pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Unmarshal(ref pvType.GetPinnableReference(), dwFlags, cbBufferLength, pBuffer, pcbRead);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwFlags, uint cbBufferLength, byte* pBuffer, Span<uint> pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Unmarshal(ref pvType.GetPinnableReference(), dwFlags, cbBufferLength, pBuffer, ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwFlags, uint cbBufferLength, Span<byte> pBuffer, uint* pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Unmarshal(ref pvType.GetPinnableReference(), dwFlags, cbBufferLength, ref pBuffer.GetPinnableReference(), pcbRead);
    }

    /// <summary>To be documented.</summary>
    public static int Unmarshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwFlags, uint cbBufferLength, Span<byte> pBuffer, Span<uint> pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Unmarshal(ref pvType.GetPinnableReference(), dwFlags, cbBufferLength, ref pBuffer.GetPinnableReference(), ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Unmarshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwFlags, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Unmarshal(ref pvType.GetPinnableReference(), dwFlags, cbBufferLength, pBuffer, pcbRead);
    }

    /// <summary>To be documented.</summary>
    public static int Unmarshal<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType, uint dwFlags, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, Span<uint> pcbRead) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Unmarshal(ref pvType.GetPinnableReference(), dwFlags, cbBufferLength, pBuffer, ref pcbRead.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Free<T0>(this ComPtr<ITypeMarshal> thisVtbl, Span<T0> pvType) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Free(ref pvType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ITypeMarshal> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
