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

public unsafe static class ProvideMultipleClassInfoVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IProvideMultipleClassInfo> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IProvideMultipleClassInfo> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IProvideMultipleClassInfo> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IProvideMultipleClassInfo> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IProvideMultipleClassInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IProvideMultipleClassInfo> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassInfoA(this ComPtr<IProvideMultipleClassInfo> thisVtbl, ITypeInfo** ppTI)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, ITypeInfo**, int>)@this->LpVtbl[3])(@this, ppTI);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassInfoA(this ComPtr<IProvideMultipleClassInfo> thisVtbl, ref ITypeInfo* ppTI)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** ppTIPtr = &ppTI)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, ITypeInfo**, int>)@this->LpVtbl[3])(@this, ppTIPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGUID(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint dwGuidKind, Guid* pGUID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, Guid*, int>)@this->LpVtbl[4])(@this, dwGuidKind, pGUID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGUID(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint dwGuidKind, ref Guid pGUID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pGUIDPtr = &pGUID)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, Guid*, int>)@this->LpVtbl[4])(@this, dwGuidKind, pGUIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMultiTypeInfoCount(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint* pcti)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint*, int>)@this->LpVtbl[5])(@this, pcti);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMultiTypeInfoCount(this ComPtr<IProvideMultipleClassInfo> thisVtbl, ref uint pcti)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pctiPtr = &pcti)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint*, int>)@this->LpVtbl[5])(@this, pctiPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* piidSourcePtr = &piidSource)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimary, piidSourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* piidPrimaryPtr = &piidPrimary)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimaryPtr, piidSource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* piidPrimaryPtr = &piidPrimary)
        {
            fixed (Guid* piidSourcePtr = &piidSource)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimaryPtr, piidSourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReservedPtr, piidPrimary, piidSource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
        {
            fixed (Guid* piidSourcePtr = &piidSource)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReservedPtr, piidPrimary, piidSourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
        {
            fixed (Guid* piidPrimaryPtr = &piidPrimary)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReservedPtr, piidPrimaryPtr, piidSource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
        {
            fixed (Guid* piidPrimaryPtr = &piidPrimary)
            {
                fixed (Guid* piidSourcePtr = &piidSource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReservedPtr, piidPrimaryPtr, piidSourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReserved, piidPrimary, piidSource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
        {
            fixed (Guid* piidSourcePtr = &piidSource)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReserved, piidPrimary, piidSourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
        {
            fixed (Guid* piidPrimaryPtr = &piidPrimary)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReserved, piidPrimaryPtr, piidSource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
        {
            fixed (Guid* piidPrimaryPtr = &piidPrimary)
            {
                fixed (Guid* piidSourcePtr = &piidSource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReserved, piidPrimaryPtr, piidSourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
        {
            fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimary, piidSource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
        {
            fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
            {
                fixed (Guid* piidSourcePtr = &piidSource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimary, piidSourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
        {
            fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
            {
                fixed (Guid* piidPrimaryPtr = &piidPrimary)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimaryPtr, piidSource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
        {
            fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
            {
                fixed (Guid* piidPrimaryPtr = &piidPrimary)
                {
                    fixed (Guid* piidSourcePtr = &piidSource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClass, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimaryPtr, piidSourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (Guid* piidSourcePtr = &piidSource)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReserved, piidPrimary, piidSourcePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (Guid* piidPrimaryPtr = &piidPrimary)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReserved, piidPrimaryPtr, piidSource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (Guid* piidPrimaryPtr = &piidPrimary)
            {
                fixed (Guid* piidSourcePtr = &piidSource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReserved, piidPrimaryPtr, piidSourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReservedPtr, piidPrimary, piidSource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
            {
                fixed (Guid* piidSourcePtr = &piidSource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReservedPtr, piidPrimary, piidSourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
            {
                fixed (Guid* piidPrimaryPtr = &piidPrimary)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReservedPtr, piidPrimaryPtr, piidSource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
            {
                fixed (Guid* piidPrimaryPtr = &piidPrimary)
                {
                    fixed (Guid* piidSourcePtr = &piidSource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlags, pcdispidReservedPtr, piidPrimaryPtr, piidSourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReserved, piidPrimary, piidSource);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (Guid* piidSourcePtr = &piidSource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReserved, piidPrimary, piidSourcePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (Guid* piidPrimaryPtr = &piidPrimary)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReserved, piidPrimaryPtr, piidSource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (Guid* piidPrimaryPtr = &piidPrimary)
                {
                    fixed (Guid* piidSourcePtr = &piidSource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReserved, piidPrimaryPtr, piidSourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimary, piidSource);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                {
                    fixed (Guid* piidSourcePtr = &piidSource)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimary, piidSourcePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                {
                    fixed (Guid* piidPrimaryPtr = &piidPrimary)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimaryPtr, piidSource);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ITypeInfo** pptiCoClassPtr = &pptiCoClass)
        {
            fixed (uint* pdwTIFlagsPtr = &pdwTIFlags)
            {
                fixed (uint* pcdispidReservedPtr = &pcdispidReserved)
                {
                    fixed (Guid* piidPrimaryPtr = &piidPrimary)
                    {
                        fixed (Guid* piidSourcePtr = &piidSource)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IProvideMultipleClassInfo*, uint, uint, ITypeInfo**, uint*, uint*, Guid*, Guid*, int>)@this->LpVtbl[6])(@this, iti, dwFlags, pptiCoClassPtr, pdwTIFlagsPtr, pcdispidReservedPtr, piidPrimaryPtr, piidSourcePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IProvideMultipleClassInfo> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IProvideMultipleClassInfo> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetClassInfoA<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, ref ComPtr<TI0> ppTI) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetClassInfoA((ITypeInfo**) ppTI.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetGUID(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint dwGuidKind, Span<Guid> pGUID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGUID(dwGuidKind, ref pGUID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMultiTypeInfoCount(this ComPtr<IProvideMultipleClassInfo> thisVtbl, Span<uint> pcti)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMultiTypeInfoCount(ref pcti.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimary, ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, pcdispidReserved, piidPrimary, ref piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Span<Guid> piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, ref piidPrimary.GetPinnableReference(), piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, pcdispidReserved, ref piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Span<Guid> piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, pdwTIFlags, pcdispidReserved, ref piidPrimary.GetPinnableReference(), ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, pcdispidReserved, ref piidPrimary, ref piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, Span<uint> pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, pdwTIFlags, ref pcdispidReserved.GetPinnableReference(), piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, ref pcdispidReserved, piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, Span<uint> pcdispidReserved, Guid* piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, pdwTIFlags, ref pcdispidReserved.GetPinnableReference(), piidPrimary, ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, ref pcdispidReserved, piidPrimary, ref piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, Span<uint> pcdispidReserved, Span<Guid> piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, pdwTIFlags, ref pcdispidReserved.GetPinnableReference(), ref piidPrimary.GetPinnableReference(), piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, ref pcdispidReserved, ref piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, uint* pdwTIFlags, Span<uint> pcdispidReserved, Span<Guid> piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, pdwTIFlags, ref pcdispidReserved.GetPinnableReference(), ref piidPrimary.GetPinnableReference(), ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, uint* pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), pdwTIFlags, ref pcdispidReserved, ref piidPrimary, ref piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, Span<uint> pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, ref pdwTIFlags.GetPinnableReference(), pcdispidReserved, piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, pcdispidReserved, piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, Span<uint> pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, ref pdwTIFlags.GetPinnableReference(), pcdispidReserved, piidPrimary, ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, pcdispidReserved, piidPrimary, ref piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, Span<uint> pdwTIFlags, uint* pcdispidReserved, Span<Guid> piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, ref pdwTIFlags.GetPinnableReference(), pcdispidReserved, ref piidPrimary.GetPinnableReference(), piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, pcdispidReserved, ref piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, Span<uint> pdwTIFlags, uint* pcdispidReserved, Span<Guid> piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, ref pdwTIFlags.GetPinnableReference(), pcdispidReserved, ref piidPrimary.GetPinnableReference(), ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, uint* pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, pcdispidReserved, ref piidPrimary, ref piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, Span<uint> pdwTIFlags, Span<uint> pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, ref pdwTIFlags.GetPinnableReference(), ref pcdispidReserved.GetPinnableReference(), piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, ref pcdispidReserved, piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, Span<uint> pdwTIFlags, Span<uint> pcdispidReserved, Guid* piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, ref pdwTIFlags.GetPinnableReference(), ref pcdispidReserved.GetPinnableReference(), piidPrimary, ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, Guid* piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, ref pcdispidReserved, piidPrimary, ref piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, Span<uint> pdwTIFlags, Span<uint> pcdispidReserved, Span<Guid> piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, ref pdwTIFlags.GetPinnableReference(), ref pcdispidReserved.GetPinnableReference(), ref piidPrimary.GetPinnableReference(), piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, Guid* piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, ref pcdispidReserved, ref piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ITypeInfo** pptiCoClass, Span<uint> pdwTIFlags, Span<uint> pcdispidReserved, Span<Guid> piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, pptiCoClass, ref pdwTIFlags.GetPinnableReference(), ref pcdispidReserved.GetPinnableReference(), ref piidPrimary.GetPinnableReference(), ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetInfoOfIndex<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ComPtr<TI0> pptiCoClass, ref uint pdwTIFlags, ref uint pcdispidReserved, ref Guid piidPrimary, ref Guid piidSource) where TI0 : unmanaged, IComVtbl<ITypeInfo>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, (ITypeInfo**) pptiCoClass.GetAddressOf(), ref pdwTIFlags, ref pcdispidReserved, ref piidPrimary, ref piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, pdwTIFlags, pcdispidReserved, piidPrimary, ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Span<Guid> piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, pdwTIFlags, pcdispidReserved, ref piidPrimary.GetPinnableReference(), piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, uint* pcdispidReserved, Span<Guid> piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, pdwTIFlags, pcdispidReserved, ref piidPrimary.GetPinnableReference(), ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, Span<uint> pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, pdwTIFlags, ref pcdispidReserved.GetPinnableReference(), piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, Span<uint> pcdispidReserved, Guid* piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, pdwTIFlags, ref pcdispidReserved.GetPinnableReference(), piidPrimary, ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, Span<uint> pcdispidReserved, Span<Guid> piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, pdwTIFlags, ref pcdispidReserved.GetPinnableReference(), ref piidPrimary.GetPinnableReference(), piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, uint* pdwTIFlags, Span<uint> pcdispidReserved, Span<Guid> piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, pdwTIFlags, ref pcdispidReserved.GetPinnableReference(), ref piidPrimary.GetPinnableReference(), ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, Span<uint> pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, ref pdwTIFlags.GetPinnableReference(), pcdispidReserved, piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, Span<uint> pdwTIFlags, uint* pcdispidReserved, Guid* piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, ref pdwTIFlags.GetPinnableReference(), pcdispidReserved, piidPrimary, ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, Span<uint> pdwTIFlags, uint* pcdispidReserved, Span<Guid> piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, ref pdwTIFlags.GetPinnableReference(), pcdispidReserved, ref piidPrimary.GetPinnableReference(), piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, Span<uint> pdwTIFlags, uint* pcdispidReserved, Span<Guid> piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, ref pdwTIFlags.GetPinnableReference(), pcdispidReserved, ref piidPrimary.GetPinnableReference(), ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, Span<uint> pdwTIFlags, Span<uint> pcdispidReserved, Guid* piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, ref pdwTIFlags.GetPinnableReference(), ref pcdispidReserved.GetPinnableReference(), piidPrimary, piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, Span<uint> pdwTIFlags, Span<uint> pcdispidReserved, Guid* piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, ref pdwTIFlags.GetPinnableReference(), ref pcdispidReserved.GetPinnableReference(), piidPrimary, ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, Span<uint> pdwTIFlags, Span<uint> pcdispidReserved, Span<Guid> piidPrimary, Guid* piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, ref pdwTIFlags.GetPinnableReference(), ref pcdispidReserved.GetPinnableReference(), ref piidPrimary.GetPinnableReference(), piidSource);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInfoOfIndex(this ComPtr<IProvideMultipleClassInfo> thisVtbl, uint iti, uint dwFlags, ref ITypeInfo* pptiCoClass, Span<uint> pdwTIFlags, Span<uint> pcdispidReserved, Span<Guid> piidPrimary, Span<Guid> piidSource)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInfoOfIndex(iti, dwFlags, ref pptiCoClass, ref pdwTIFlags.GetPinnableReference(), ref pcdispidReserved.GetPinnableReference(), ref piidPrimary.GetPinnableReference(), ref piidSource.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IProvideMultipleClassInfo> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
