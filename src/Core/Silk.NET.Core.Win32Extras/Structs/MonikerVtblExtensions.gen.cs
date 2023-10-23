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

public unsafe static class MonikerVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMoniker> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMoniker> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMoniker> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMoniker> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMoniker> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMoniker> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClassID(this ComPtr<IMoniker> thisVtbl, Guid* pClassID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Guid*, int>)@this->LpVtbl[3])(@this, pClassID);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClassID(this ComPtr<IMoniker> thisVtbl, ref Guid pClassID)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pClassIDPtr = &pClassID)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Guid*, int>)@this->LpVtbl[3])(@this, pClassIDPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsDirty(this ComPtr<IMoniker> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, int>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Load(this ComPtr<IMoniker> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[5])(@this, pStm);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IMoniker> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[5])(@this, pStmPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Save(this ComPtr<IMoniker> thisVtbl, Silk.NET.Core.Win32Extras.IStream* pStm, Silk.NET.Core.Bool32 fClearDirty)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pStm, fClearDirty);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Save(this ComPtr<IMoniker> thisVtbl, ref Silk.NET.Core.Win32Extras.IStream pStm, Silk.NET.Core.Bool32 fClearDirty)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.IStream* pStmPtr = &pStm)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[6])(@this, pStmPtr, fClearDirty);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSizeMax(this ComPtr<IMoniker> thisVtbl, ulong* pcbSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, ulong*, int>)@this->LpVtbl[7])(@this, pcbSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetSizeMax(this ComPtr<IMoniker> thisVtbl, ref ulong pcbSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* pcbSizePtr = &pcbSize)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, ulong*, int>)@this->LpVtbl[7])(@this, pcbSizePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Guid* riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeft, riidResult, ppvResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Guid* riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvResultPtr = &ppvResult)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeft, riidResult, ppvResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, ref Guid riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResultPtr = &riidResult)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeft, riidResultPtr, ppvResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, ref Guid riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidResultPtr = &riidResult)
        {
            fixed (void** ppvResultPtr = &ppvResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeft, riidResultPtr, ppvResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, Guid* riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeftPtr, riidResult, ppvResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, Guid* riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (void** ppvResultPtr = &ppvResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeftPtr, riidResult, ppvResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, ref Guid riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (Guid* riidResultPtr = &riidResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeftPtr, riidResultPtr, ppvResult);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, ref Guid riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (Guid* riidResultPtr = &riidResult)
            {
                fixed (void** ppvResultPtr = &ppvResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbc, pmkToLeftPtr, riidResultPtr, ppvResultPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, Guid* riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeft, riidResult, ppvResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, Guid* riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (void** ppvResultPtr = &ppvResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeft, riidResult, ppvResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, ref Guid riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (Guid* riidResultPtr = &riidResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeft, riidResultPtr, ppvResult);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, ref Guid riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (Guid* riidResultPtr = &riidResult)
            {
                fixed (void** ppvResultPtr = &ppvResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeft, riidResultPtr, ppvResultPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, Guid* riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeftPtr, riidResult, ppvResult);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, Guid* riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (void** ppvResultPtr = &ppvResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeftPtr, riidResult, ppvResultPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref Guid riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (Guid* riidResultPtr = &riidResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeftPtr, riidResultPtr, ppvResult);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref Guid riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (Guid* riidResultPtr = &riidResult)
                {
                    fixed (void** ppvResultPtr = &ppvResult)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pbcPtr, pmkToLeftPtr, riidResultPtr, ppvResultPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeft, riid, ppvObj);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjPtr = &ppvObj)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeft, riid, ppvObjPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, ref Guid riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeft, riidPtr, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, ref Guid riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeft, riidPtr, ppvObjPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeftPtr, riid, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeftPtr, riid, ppvObjPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, ref Guid riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeftPtr, riidPtr, ppvObj);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, ref Guid riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbc, pmkToLeftPtr, riidPtr, ppvObjPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeft, riid, ppvObj);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (void** ppvObjPtr = &ppvObj)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeft, riid, ppvObjPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, ref Guid riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeft, riidPtr, ppvObj);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, ref Guid riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeft, riidPtr, ppvObjPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeftPtr, riid, ppvObj);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (void** ppvObjPtr = &ppvObj)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeftPtr, riid, ppvObjPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref Guid riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeftPtr, riidPtr, ppvObj);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref Guid riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjPtr = &ppvObj)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pbcPtr, pmkToLeftPtr, riidPtr, ppvObjPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, uint dwReduceHowFar, IMoniker** ppmkToLeft, IMoniker** ppmkReduced)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbc, dwReduceHowFar, ppmkToLeft, ppmkReduced);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, uint dwReduceHowFar, IMoniker** ppmkToLeft, ref IMoniker* ppmkReduced)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker** ppmkReducedPtr = &ppmkReduced)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbc, dwReduceHowFar, ppmkToLeft, ppmkReducedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, IMoniker** ppmkReduced)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker** ppmkToLeftPtr = &ppmkToLeft)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbc, dwReduceHowFar, ppmkToLeftPtr, ppmkReduced);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, ref IMoniker* ppmkReduced)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker** ppmkToLeftPtr = &ppmkToLeft)
        {
            fixed (IMoniker** ppmkReducedPtr = &ppmkReduced)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbc, dwReduceHowFar, ppmkToLeftPtr, ppmkReducedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, uint dwReduceHowFar, IMoniker** ppmkToLeft, IMoniker** ppmkReduced)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbcPtr, dwReduceHowFar, ppmkToLeft, ppmkReduced);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, uint dwReduceHowFar, IMoniker** ppmkToLeft, ref IMoniker* ppmkReduced)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker** ppmkReducedPtr = &ppmkReduced)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbcPtr, dwReduceHowFar, ppmkToLeft, ppmkReducedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, IMoniker** ppmkReduced)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker** ppmkToLeftPtr = &ppmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbcPtr, dwReduceHowFar, ppmkToLeftPtr, ppmkReduced);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, ref IMoniker* ppmkReduced)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker** ppmkToLeftPtr = &ppmkToLeft)
            {
                fixed (IMoniker** ppmkReducedPtr = &ppmkReduced)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, uint, IMoniker**, IMoniker**, int>)@this->LpVtbl[10])(@this, pbcPtr, dwReduceHowFar, ppmkToLeftPtr, ppmkReducedPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeWith(this ComPtr<IMoniker> thisVtbl, IMoniker* pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, IMoniker** ppmkComposite)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, Silk.NET.Core.Bool32, IMoniker**, int>)@this->LpVtbl[11])(@this, pmkRight, fOnlyIfNotGeneric, ppmkComposite);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeWith(this ComPtr<IMoniker> thisVtbl, IMoniker* pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, ref IMoniker* ppmkComposite)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker** ppmkCompositePtr = &ppmkComposite)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, Silk.NET.Core.Bool32, IMoniker**, int>)@this->LpVtbl[11])(@this, pmkRight, fOnlyIfNotGeneric, ppmkCompositePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeWith(this ComPtr<IMoniker> thisVtbl, ref IMoniker pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, IMoniker** ppmkComposite)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkRightPtr = &pmkRight)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, Silk.NET.Core.Bool32, IMoniker**, int>)@this->LpVtbl[11])(@this, pmkRightPtr, fOnlyIfNotGeneric, ppmkComposite);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeWith(this ComPtr<IMoniker> thisVtbl, ref IMoniker pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, ref IMoniker* ppmkComposite)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkRightPtr = &pmkRight)
        {
            fixed (IMoniker** ppmkCompositePtr = &ppmkComposite)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, Silk.NET.Core.Bool32, IMoniker**, int>)@this->LpVtbl[11])(@this, pmkRightPtr, fOnlyIfNotGeneric, ppmkCompositePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Enum(this ComPtr<IMoniker> thisVtbl, Silk.NET.Core.Bool32 fForward, IEnumMoniker** ppenumMoniker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Silk.NET.Core.Bool32, IEnumMoniker**, int>)@this->LpVtbl[12])(@this, fForward, ppenumMoniker);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Enum(this ComPtr<IMoniker> thisVtbl, Silk.NET.Core.Bool32 fForward, ref IEnumMoniker* ppenumMoniker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumMoniker** ppenumMonikerPtr = &ppenumMoniker)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, Silk.NET.Core.Bool32, IEnumMoniker**, int>)@this->LpVtbl[12])(@this, fForward, ppenumMonikerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsEqual(this ComPtr<IMoniker> thisVtbl, IMoniker* pmkOtherMoniker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, int>)@this->LpVtbl[13])(@this, pmkOtherMoniker);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsEqual(this ComPtr<IMoniker> thisVtbl, ref IMoniker pmkOtherMoniker)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkOtherMonikerPtr = &pmkOtherMoniker)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, int>)@this->LpVtbl[13])(@this, pmkOtherMonikerPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Hash(this ComPtr<IMoniker> thisVtbl, uint* pdwHash)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, uint*, int>)@this->LpVtbl[14])(@this, pdwHash);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Hash(this ComPtr<IMoniker> thisVtbl, ref uint pdwHash)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwHashPtr = &pdwHash)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, uint*, int>)@this->LpVtbl[14])(@this, pdwHashPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, IMoniker* pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbc, pmkToLeft, pmkNewlyRunning);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, ref IMoniker pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkNewlyRunningPtr = &pmkNewlyRunning)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbc, pmkToLeft, pmkNewlyRunningPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, IMoniker* pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbc, pmkToLeftPtr, pmkNewlyRunning);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, ref IMoniker pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (IMoniker* pmkNewlyRunningPtr = &pmkNewlyRunning)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbc, pmkToLeftPtr, pmkNewlyRunningPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, IMoniker* pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbcPtr, pmkToLeft, pmkNewlyRunning);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, ref IMoniker pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkNewlyRunningPtr = &pmkNewlyRunning)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbcPtr, pmkToLeft, pmkNewlyRunningPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, IMoniker* pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbcPtr, pmkToLeftPtr, pmkNewlyRunning);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsRunning(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref IMoniker pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (IMoniker* pmkNewlyRunningPtr = &pmkNewlyRunning)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, IMoniker*, int>)@this->LpVtbl[15])(@this, pbcPtr, pmkToLeftPtr, pmkNewlyRunningPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Filetime* pFileTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbc, pmkToLeft, pFileTime);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, ref Filetime pFileTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Filetime* pFileTimePtr = &pFileTime)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbc, pmkToLeft, pFileTimePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, Filetime* pFileTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbc, pmkToLeftPtr, pFileTime);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, ref Filetime pFileTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (Filetime* pFileTimePtr = &pFileTime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbc, pmkToLeftPtr, pFileTimePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, Filetime* pFileTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbcPtr, pmkToLeft, pFileTime);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, ref Filetime pFileTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (Filetime* pFileTimePtr = &pFileTime)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbcPtr, pmkToLeft, pFileTimePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, Filetime* pFileTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbcPtr, pmkToLeftPtr, pFileTime);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref Filetime pFileTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (Filetime* pFileTimePtr = &pFileTime)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, Filetime*, int>)@this->LpVtbl[16])(@this, pbcPtr, pmkToLeftPtr, pFileTimePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Inverse(this ComPtr<IMoniker> thisVtbl, IMoniker** ppmk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker**, int>)@this->LpVtbl[17])(@this, ppmk);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Inverse(this ComPtr<IMoniker> thisVtbl, ref IMoniker* ppmk)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker** ppmkPtr = &ppmk)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker**, int>)@this->LpVtbl[17])(@this, ppmkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CommonPrefixWith(this ComPtr<IMoniker> thisVtbl, IMoniker* pmkOther, IMoniker** ppmkPrefix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[18])(@this, pmkOther, ppmkPrefix);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CommonPrefixWith(this ComPtr<IMoniker> thisVtbl, IMoniker* pmkOther, ref IMoniker* ppmkPrefix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker** ppmkPrefixPtr = &ppmkPrefix)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[18])(@this, pmkOther, ppmkPrefixPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CommonPrefixWith(this ComPtr<IMoniker> thisVtbl, ref IMoniker pmkOther, IMoniker** ppmkPrefix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkOtherPtr = &pmkOther)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[18])(@this, pmkOtherPtr, ppmkPrefix);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CommonPrefixWith(this ComPtr<IMoniker> thisVtbl, ref IMoniker pmkOther, ref IMoniker* ppmkPrefix)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkOtherPtr = &pmkOther)
        {
            fixed (IMoniker** ppmkPrefixPtr = &ppmkPrefix)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[18])(@this, pmkOtherPtr, ppmkPrefixPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RelativePathTo(this ComPtr<IMoniker> thisVtbl, IMoniker* pmkOther, IMoniker** ppmkRelPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[19])(@this, pmkOther, ppmkRelPath);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RelativePathTo(this ComPtr<IMoniker> thisVtbl, IMoniker* pmkOther, ref IMoniker* ppmkRelPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker** ppmkRelPathPtr = &ppmkRelPath)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[19])(@this, pmkOther, ppmkRelPathPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RelativePathTo(this ComPtr<IMoniker> thisVtbl, ref IMoniker pmkOther, IMoniker** ppmkRelPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkOtherPtr = &pmkOther)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[19])(@this, pmkOtherPtr, ppmkRelPath);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RelativePathTo(this ComPtr<IMoniker> thisVtbl, ref IMoniker pmkOther, ref IMoniker* ppmkRelPath)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkOtherPtr = &pmkOther)
        {
            fixed (IMoniker** ppmkRelPathPtr = &ppmkRelPath)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IMoniker*, IMoniker**, int>)@this->LpVtbl[19])(@this, pmkOtherPtr, ppmkRelPathPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, char** ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbc, pmkToLeft, ppszDisplayName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, ref char* ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** ppszDisplayNamePtr = &ppszDisplayName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbc, pmkToLeft, ppszDisplayNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, char** ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbc, pmkToLeftPtr, ppszDisplayName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, ref char* ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (char** ppszDisplayNamePtr = &ppszDisplayName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbc, pmkToLeftPtr, ppszDisplayNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, char** ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbcPtr, pmkToLeft, ppszDisplayName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, ref char* ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (char** ppszDisplayNamePtr = &ppszDisplayName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbcPtr, pmkToLeft, ppszDisplayNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, char** ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbcPtr, pmkToLeftPtr, ppszDisplayName);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char* ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (char** ppszDisplayNamePtr = &ppszDisplayName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char**, int>)@this->LpVtbl[20])(@this, pbcPtr, pmkToLeftPtr, ppszDisplayNamePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, char* pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayName, pchEaten, ppmkOut);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker** ppmkOutPtr = &ppmkOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayName, pchEaten, ppmkOutPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, char* pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pchEatenPtr = &pchEaten)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayName, pchEatenPtr, ppmkOut);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pchEatenPtr = &pchEaten)
        {
            fixed (IMoniker** ppmkOutPtr = &ppmkOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayName, pchEatenPtr, ppmkOutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, ref char pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszDisplayNamePtr = &pszDisplayName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOut);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszDisplayNamePtr = &pszDisplayName)
        {
            fixed (IMoniker** ppmkOutPtr = &ppmkOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, ref char pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszDisplayNamePtr = &pszDisplayName)
        {
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pszDisplayNamePtr = &pszDisplayName)
        {
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOut);
        SilkMarshal.Free((nint)pszDisplayNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
        fixed (IMoniker** ppmkOutPtr = &ppmkOut)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
        }
        SilkMarshal.Free((nint)pszDisplayNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
        fixed (uint* pchEatenPtr = &pchEaten)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
        }
        SilkMarshal.Free((nint)pszDisplayNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
        fixed (uint* pchEatenPtr = &pchEaten)
        {
            fixed (IMoniker** ppmkOutPtr = &ppmkOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
            }
        }
        SilkMarshal.Free((nint)pszDisplayNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayName, pchEaten, ppmkOut);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (IMoniker** ppmkOutPtr = &ppmkOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayName, pchEaten, ppmkOutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayName, pchEatenPtr, ppmkOut);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayName, pchEatenPtr, ppmkOutPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (char* pszDisplayNamePtr = &pszDisplayName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOut);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (char* pszDisplayNamePtr = &pszDisplayName)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (char* pszDisplayNamePtr = &pszDisplayName)
            {
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
            fixed (char* pszDisplayNamePtr = &pszDisplayName)
            {
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOut);
        SilkMarshal.Free((nint)pszDisplayNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
            fixed (IMoniker** ppmkOutPtr = &ppmkOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
            }
        SilkMarshal.Free((nint)pszDisplayNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
            }
        SilkMarshal.Free((nint)pszDisplayNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
        {
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbc, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                }
            }
        SilkMarshal.Free((nint)pszDisplayNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, char* pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayName, pchEaten, ppmkOut);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker** ppmkOutPtr = &ppmkOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayName, pchEaten, ppmkOutPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, char* pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayName, pchEatenPtr, ppmkOut);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayName, pchEatenPtr, ppmkOutPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, ref char pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (char* pszDisplayNamePtr = &pszDisplayName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOut);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (char* pszDisplayNamePtr = &pszDisplayName)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, ref char pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (char* pszDisplayNamePtr = &pszDisplayName)
            {
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (char* pszDisplayNamePtr = &pszDisplayName)
            {
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOut);
        SilkMarshal.Free((nint)pszDisplayNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
            fixed (IMoniker** ppmkOutPtr = &ppmkOut)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
            }
        SilkMarshal.Free((nint)pszDisplayNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
            }
        SilkMarshal.Free((nint)pszDisplayNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
            fixed (uint* pchEatenPtr = &pchEaten)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeft, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                }
            }
        SilkMarshal.Free((nint)pszDisplayNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayName, pchEaten, ppmkOut);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayName, pchEaten, ppmkOutPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayName, pchEatenPtr, ppmkOut);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayName, pchEatenPtr, ppmkOutPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (char* pszDisplayNamePtr = &pszDisplayName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOut);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (char* pszDisplayNamePtr = &pszDisplayName)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (char* pszDisplayNamePtr = &pszDisplayName)
                {
                    fixed (uint* pchEatenPtr = &pchEaten)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
                fixed (char* pszDisplayNamePtr = &pszDisplayName)
                {
                    fixed (uint* pchEatenPtr = &pchEaten)
                    {
                        fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, char*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOut);
        SilkMarshal.Free((nint)pszDisplayNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEaten, ppmkOutPtr);
                }
        SilkMarshal.Free((nint)pszDisplayNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOut);
                }
        SilkMarshal.Free((nint)pszDisplayNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IBindCtx* pbcPtr = &pbc)
        {
            fixed (IMoniker* pmkToLeftPtr = &pmkToLeft)
            {
        var pszDisplayNamePtr = (byte*) SilkMarshal.StringToPtr(pszDisplayName, NativeStringEncoding.UTF8);
                fixed (uint* pchEatenPtr = &pchEaten)
                {
                    fixed (IMoniker** ppmkOutPtr = &ppmkOut)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, IBindCtx*, IMoniker*, byte*, uint*, IMoniker**, int>)@this->LpVtbl[21])(@this, pbcPtr, pmkToLeftPtr, pszDisplayNamePtr, pchEatenPtr, ppmkOutPtr);
                    }
                }
        SilkMarshal.Free((nint)pszDisplayNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsSystemMoniker(this ComPtr<IMoniker> thisVtbl, uint* pdwMksys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IMoniker*, uint*, int>)@this->LpVtbl[22])(@this, pdwMksys);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsSystemMoniker(this ComPtr<IMoniker> thisVtbl, ref uint pdwMksys)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pdwMksysPtr = &pdwMksys)
        {
            ret = ((delegate* unmanaged[Cdecl]<IMoniker*, uint*, int>)@this->LpVtbl[22])(@this, pdwMksysPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMoniker> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMoniker> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMoniker> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetClassID(this ComPtr<IMoniker> thisVtbl, Span<Guid> pClassID)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClassID(ref pClassID.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Load<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pStm) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Load((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int Load(this ComPtr<IMoniker> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Load(ref pStm.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Save<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pStm, Silk.NET.Core.Bool32 fClearDirty) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Save((Silk.NET.Core.Win32Extras.IStream*) pStm.Handle, fClearDirty);
    }

    /// <summary>To be documented.</summary>
    public static int Save(this ComPtr<IMoniker> thisVtbl, Span<Silk.NET.Core.Win32Extras.IStream> pStm, Silk.NET.Core.Bool32 fClearDirty)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Save(ref pStm.GetPinnableReference(), fClearDirty);
    }

    /// <summary>To be documented.</summary>
    public static int GetSizeMax(this ComPtr<IMoniker> thisVtbl, Span<ulong> pcbSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSizeMax(ref pcbSize.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int BindToObject<TI0, TI1, TI2>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, out ComPtr<TI2> ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResult = default;
        return @this->BindToObject((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, SilkMarshal.GuidPtrOf<TI2>(), (void**) ppvResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, Guid* riidResult, ref void* ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToObject((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, riidResult, ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Span<Guid> riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(pbc, pmkToLeft, ref riidResult.GetPinnableReference(), ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref Guid riidResult, void** ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToObject((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref riidResult, ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Span<Guid> riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(pbc, pmkToLeft, ref riidResult.GetPinnableReference(), ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref Guid riidResult, ref void* ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToObject((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref riidResult, ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Guid* riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(pbc, ref pmkToLeft.GetPinnableReference(), riidResult, ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static int BindToObject<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, out ComPtr<TI1> ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResult = default;
        return @this->BindToObject((IBindCtx*) pbc.Handle, ref pmkToLeft, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Guid* riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(pbc, ref pmkToLeft.GetPinnableReference(), riidResult, ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, Guid* riidResult, ref void* ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToObject((IBindCtx*) pbc.Handle, ref pmkToLeft, riidResult, ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Span<Guid> riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(pbc, ref pmkToLeft.GetPinnableReference(), ref riidResult.GetPinnableReference(), ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref Guid riidResult, void** ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToObject((IBindCtx*) pbc.Handle, ref pmkToLeft, ref riidResult, ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Span<Guid> riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(pbc, ref pmkToLeft.GetPinnableReference(), ref riidResult.GetPinnableReference(), ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref Guid riidResult, ref void* ppvResult) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToObject((IBindCtx*) pbc.Handle, ref pmkToLeft, ref riidResult, ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Guid* riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(ref pbc.GetPinnableReference(), pmkToLeft, riidResult, ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static int BindToObject<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, out ComPtr<TI1> ppvResult) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResult = default;
        return @this->BindToObject(ref pbc, (IMoniker*) pmkToLeft.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Guid* riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(ref pbc.GetPinnableReference(), pmkToLeft, riidResult, ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, Guid* riidResult, ref void* ppvResult) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToObject(ref pbc, (IMoniker*) pmkToLeft.Handle, riidResult, ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Span<Guid> riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(ref pbc.GetPinnableReference(), pmkToLeft, ref riidResult.GetPinnableReference(), ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref Guid riidResult, void** ppvResult) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToObject(ref pbc, (IMoniker*) pmkToLeft.Handle, ref riidResult, ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Span<Guid> riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(ref pbc.GetPinnableReference(), pmkToLeft, ref riidResult.GetPinnableReference(), ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref Guid riidResult, ref void* ppvResult) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToObject(ref pbc, (IMoniker*) pmkToLeft.Handle, ref riidResult, ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Guid* riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), riidResult, ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static int BindToObject<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, out ComPtr<TI0> ppvResult) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvResult = default;
        return @this->BindToObject(ref pbc, ref pmkToLeft, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvResult.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Guid* riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), riidResult, ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Span<Guid> riidResult, void** ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), ref riidResult.GetPinnableReference(), ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToObject(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Span<Guid> riidResult, ref void* ppvResult)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToObject(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), ref riidResult.GetPinnableReference(), ref ppvResult);
    }

    /// <summary>To be documented.</summary>
    public static int BindToStorage<TI0, TI1, TI2>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, out ComPtr<TI2> ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObj = default;
        return @this->BindToStorage((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, SilkMarshal.GuidPtrOf<TI2>(), (void**) ppvObj.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, Guid* riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToStorage((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Span<Guid> riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(pbc, pmkToLeft, ref riid.GetPinnableReference(), ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref Guid riid, void** ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToStorage((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref riid, ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Span<Guid> riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(pbc, pmkToLeft, ref riid.GetPinnableReference(), ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref Guid riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToStorage((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(pbc, ref pmkToLeft.GetPinnableReference(), riid, ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static int BindToStorage<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, out ComPtr<TI1> ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObj = default;
        return @this->BindToStorage((IBindCtx*) pbc.Handle, ref pmkToLeft, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvObj.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(pbc, ref pmkToLeft.GetPinnableReference(), riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, Guid* riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToStorage((IBindCtx*) pbc.Handle, ref pmkToLeft, riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Span<Guid> riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(pbc, ref pmkToLeft.GetPinnableReference(), ref riid.GetPinnableReference(), ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref Guid riid, void** ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToStorage((IBindCtx*) pbc.Handle, ref pmkToLeft, ref riid, ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Span<Guid> riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(pbc, ref pmkToLeft.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref Guid riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToStorage((IBindCtx*) pbc.Handle, ref pmkToLeft, ref riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(ref pbc.GetPinnableReference(), pmkToLeft, riid, ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static int BindToStorage<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, out ComPtr<TI1> ppvObj) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObj = default;
        return @this->BindToStorage(ref pbc, (IMoniker*) pmkToLeft.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvObj.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(ref pbc.GetPinnableReference(), pmkToLeft, riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, Guid* riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToStorage(ref pbc, (IMoniker*) pmkToLeft.Handle, riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Span<Guid> riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(ref pbc.GetPinnableReference(), pmkToLeft, ref riid.GetPinnableReference(), ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref Guid riid, void** ppvObj) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToStorage(ref pbc, (IMoniker*) pmkToLeft.Handle, ref riid, ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Span<Guid> riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(ref pbc.GetPinnableReference(), pmkToLeft, ref riid.GetPinnableReference(), ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref Guid riid, ref void* ppvObj) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->BindToStorage(ref pbc, (IMoniker*) pmkToLeft.Handle, ref riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Guid* riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), riid, ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static int BindToStorage<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, out ComPtr<TI0> ppvObj) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObj = default;
        return @this->BindToStorage(ref pbc, ref pmkToLeft, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObj.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Guid* riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), riid, ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Span<Guid> riid, void** ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), ref riid.GetPinnableReference(), ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int BindToStorage(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Span<Guid> riid, ref void* ppvObj)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->BindToStorage(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), ref riid.GetPinnableReference(), ref ppvObj);
    }

    /// <summary>To be documented.</summary>
    public static int Reduce<TI0, TI1, TI2>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, uint dwReduceHowFar, ref ComPtr<TI1> ppmkToLeft, ref ComPtr<TI2> ppmkReduced) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Reduce((IBindCtx*) pbc.Handle, dwReduceHowFar, (IMoniker**) ppmkToLeft.GetAddressOf(), (IMoniker**) ppmkReduced.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, uint dwReduceHowFar, ref ComPtr<TI1> ppmkToLeft, ref IMoniker* ppmkReduced) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Reduce((IBindCtx*) pbc.Handle, dwReduceHowFar, (IMoniker**) ppmkToLeft.GetAddressOf(), ref ppmkReduced);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, ref ComPtr<TI1> ppmkReduced) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Reduce((IBindCtx*) pbc.Handle, dwReduceHowFar, ref ppmkToLeft, (IMoniker**) ppmkReduced.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, ref IMoniker* ppmkReduced) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Reduce((IBindCtx*) pbc.Handle, dwReduceHowFar, ref ppmkToLeft, ref ppmkReduced);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, uint dwReduceHowFar, IMoniker** ppmkToLeft, IMoniker** ppmkReduced)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Reduce(ref pbc.GetPinnableReference(), dwReduceHowFar, ppmkToLeft, ppmkReduced);
    }

    /// <summary>To be documented.</summary>
    public static int Reduce<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, uint dwReduceHowFar, ref ComPtr<TI0> ppmkToLeft, ref ComPtr<TI1> ppmkReduced) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Reduce(ref pbc, dwReduceHowFar, (IMoniker**) ppmkToLeft.GetAddressOf(), (IMoniker**) ppmkReduced.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, uint dwReduceHowFar, IMoniker** ppmkToLeft, ref IMoniker* ppmkReduced)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Reduce(ref pbc.GetPinnableReference(), dwReduceHowFar, ppmkToLeft, ref ppmkReduced);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, uint dwReduceHowFar, ref ComPtr<TI0> ppmkToLeft, ref IMoniker* ppmkReduced) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Reduce(ref pbc, dwReduceHowFar, (IMoniker**) ppmkToLeft.GetAddressOf(), ref ppmkReduced);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, IMoniker** ppmkReduced)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Reduce(ref pbc.GetPinnableReference(), dwReduceHowFar, ref ppmkToLeft, ppmkReduced);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, ref ComPtr<TI0> ppmkReduced) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Reduce(ref pbc, dwReduceHowFar, ref ppmkToLeft, (IMoniker**) ppmkReduced.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Reduce(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, uint dwReduceHowFar, ref IMoniker* ppmkToLeft, ref IMoniker* ppmkReduced)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Reduce(ref pbc.GetPinnableReference(), dwReduceHowFar, ref ppmkToLeft, ref ppmkReduced);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeWith<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, ref ComPtr<TI1> ppmkComposite) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeWith((IMoniker*) pmkRight.Handle, fOnlyIfNotGeneric, (IMoniker**) ppmkComposite.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeWith<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, ref IMoniker* ppmkComposite) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeWith((IMoniker*) pmkRight.Handle, fOnlyIfNotGeneric, ref ppmkComposite);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeWith(this ComPtr<IMoniker> thisVtbl, Span<IMoniker> pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, IMoniker** ppmkComposite)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeWith(ref pmkRight.GetPinnableReference(), fOnlyIfNotGeneric, ppmkComposite);
    }

    /// <summary>To be documented.</summary>
    public static int ComposeWith<TI0>(this ComPtr<IMoniker> thisVtbl, ref IMoniker pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, ref ComPtr<TI0> ppmkComposite) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ComposeWith(ref pmkRight, fOnlyIfNotGeneric, (IMoniker**) ppmkComposite.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ComposeWith(this ComPtr<IMoniker> thisVtbl, Span<IMoniker> pmkRight, Silk.NET.Core.Bool32 fOnlyIfNotGeneric, ref IMoniker* ppmkComposite)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ComposeWith(ref pmkRight.GetPinnableReference(), fOnlyIfNotGeneric, ref ppmkComposite);
    }

    /// <summary>To be documented.</summary>
    public static int Enum<TI0>(this ComPtr<IMoniker> thisVtbl, Silk.NET.Core.Bool32 fForward, ref ComPtr<TI0> ppenumMoniker) where TI0 : unmanaged, IComVtbl<IEnumMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Enum(fForward, (IEnumMoniker**) ppenumMoniker.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int IsEqual<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pmkOtherMoniker) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->IsEqual((IMoniker*) pmkOtherMoniker.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int IsEqual(this ComPtr<IMoniker> thisVtbl, Span<IMoniker> pmkOtherMoniker)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsEqual(ref pmkOtherMoniker.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Hash(this ComPtr<IMoniker> thisVtbl, Span<uint> pdwHash)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Hash(ref pdwHash.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsRunning<TI0, TI1, TI2>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ComPtr<TI2> pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->IsRunning((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, (IMoniker*) pmkNewlyRunning.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Span<IMoniker> pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsRunning(pbc, pmkToLeft, ref pmkNewlyRunning.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsRunning<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref IMoniker pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->IsRunning((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref pmkNewlyRunning);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, IMoniker* pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsRunning(pbc, ref pmkToLeft.GetPinnableReference(), pmkNewlyRunning);
    }

    /// <summary>To be documented.</summary>
    public static int IsRunning<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ComPtr<TI1> pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->IsRunning((IBindCtx*) pbc.Handle, ref pmkToLeft, (IMoniker*) pmkNewlyRunning.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Span<IMoniker> pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsRunning(pbc, ref pmkToLeft.GetPinnableReference(), ref pmkNewlyRunning.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsRunning<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref IMoniker pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->IsRunning((IBindCtx*) pbc.Handle, ref pmkToLeft, ref pmkNewlyRunning);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, IMoniker* pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsRunning(ref pbc.GetPinnableReference(), pmkToLeft, pmkNewlyRunning);
    }

    /// <summary>To be documented.</summary>
    public static int IsRunning<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ComPtr<TI1> pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->IsRunning(ref pbc, (IMoniker*) pmkToLeft.Handle, (IMoniker*) pmkNewlyRunning.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Span<IMoniker> pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsRunning(ref pbc.GetPinnableReference(), pmkToLeft, ref pmkNewlyRunning.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsRunning<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref IMoniker pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->IsRunning(ref pbc, (IMoniker*) pmkToLeft.Handle, ref pmkNewlyRunning);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsRunning(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, IMoniker* pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsRunning(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), pmkNewlyRunning);
    }

    /// <summary>To be documented.</summary>
    public static int IsRunning<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ComPtr<TI0> pmkNewlyRunning) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->IsRunning(ref pbc, ref pmkToLeft, (IMoniker*) pmkNewlyRunning.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int IsRunning(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Span<IMoniker> pmkNewlyRunning)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsRunning(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), ref pmkNewlyRunning.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, Filetime* pFileTime) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTimeOfLastChange((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pFileTime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Span<Filetime> pFileTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTimeOfLastChange(pbc, pmkToLeft, ref pFileTime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTimeOfLastChange<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref Filetime pFileTime) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTimeOfLastChange((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref pFileTime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Filetime* pFileTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTimeOfLastChange(pbc, ref pmkToLeft.GetPinnableReference(), pFileTime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, Filetime* pFileTime) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTimeOfLastChange((IBindCtx*) pbc.Handle, ref pmkToLeft, pFileTime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Span<Filetime> pFileTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTimeOfLastChange(pbc, ref pmkToLeft.GetPinnableReference(), ref pFileTime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTimeOfLastChange<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref Filetime pFileTime) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTimeOfLastChange((IBindCtx*) pbc.Handle, ref pmkToLeft, ref pFileTime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Filetime* pFileTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTimeOfLastChange(ref pbc.GetPinnableReference(), pmkToLeft, pFileTime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, Filetime* pFileTime) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTimeOfLastChange(ref pbc, (IMoniker*) pmkToLeft.Handle, pFileTime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Span<Filetime> pFileTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTimeOfLastChange(ref pbc.GetPinnableReference(), pmkToLeft, ref pFileTime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTimeOfLastChange<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref Filetime pFileTime) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTimeOfLastChange(ref pbc, (IMoniker*) pmkToLeft.Handle, ref pFileTime);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Filetime* pFileTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTimeOfLastChange(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), pFileTime);
    }

    /// <summary>To be documented.</summary>
    public static int GetTimeOfLastChange(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Span<Filetime> pFileTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTimeOfLastChange(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), ref pFileTime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Inverse<TI0>(this ComPtr<IMoniker> thisVtbl, ref ComPtr<TI0> ppmk) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Inverse((IMoniker**) ppmk.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CommonPrefixWith<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pmkOther, ref ComPtr<TI1> ppmkPrefix) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CommonPrefixWith((IMoniker*) pmkOther.Handle, (IMoniker**) ppmkPrefix.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CommonPrefixWith<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pmkOther, ref IMoniker* ppmkPrefix) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CommonPrefixWith((IMoniker*) pmkOther.Handle, ref ppmkPrefix);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CommonPrefixWith(this ComPtr<IMoniker> thisVtbl, Span<IMoniker> pmkOther, IMoniker** ppmkPrefix)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CommonPrefixWith(ref pmkOther.GetPinnableReference(), ppmkPrefix);
    }

    /// <summary>To be documented.</summary>
    public static int CommonPrefixWith<TI0>(this ComPtr<IMoniker> thisVtbl, ref IMoniker pmkOther, ref ComPtr<TI0> ppmkPrefix) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CommonPrefixWith(ref pmkOther, (IMoniker**) ppmkPrefix.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CommonPrefixWith(this ComPtr<IMoniker> thisVtbl, Span<IMoniker> pmkOther, ref IMoniker* ppmkPrefix)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CommonPrefixWith(ref pmkOther.GetPinnableReference(), ref ppmkPrefix);
    }

    /// <summary>To be documented.</summary>
    public static int RelativePathTo<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pmkOther, ref ComPtr<TI1> ppmkRelPath) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RelativePathTo((IMoniker*) pmkOther.Handle, (IMoniker**) ppmkRelPath.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RelativePathTo<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pmkOther, ref IMoniker* ppmkRelPath) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RelativePathTo((IMoniker*) pmkOther.Handle, ref ppmkRelPath);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RelativePathTo(this ComPtr<IMoniker> thisVtbl, Span<IMoniker> pmkOther, IMoniker** ppmkRelPath)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RelativePathTo(ref pmkOther.GetPinnableReference(), ppmkRelPath);
    }

    /// <summary>To be documented.</summary>
    public static int RelativePathTo<TI0>(this ComPtr<IMoniker> thisVtbl, ref IMoniker pmkOther, ref ComPtr<TI0> ppmkRelPath) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->RelativePathTo(ref pmkOther, (IMoniker**) ppmkRelPath.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int RelativePathTo(this ComPtr<IMoniker> thisVtbl, Span<IMoniker> pmkOther, ref IMoniker* ppmkRelPath)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->RelativePathTo(ref pmkOther.GetPinnableReference(), ref ppmkRelPath);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, string[] ppszDisplayNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppszDisplayName = (char**) SilkMarshal.StringArrayToPtr(ppszDisplayNameSa);
        var ret = @this->GetDisplayName(pbc, pmkToLeft, ppszDisplayName);
        SilkMarshal.CopyPtrToStringArray((nint) ppszDisplayName, ppszDisplayNameSa);
        SilkMarshal.Free((nint) ppszDisplayName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, char** ppszDisplayName) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ppszDisplayName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref char* ppszDisplayName) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref ppszDisplayName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, ref IMoniker pmkToLeft, string[] ppszDisplayNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppszDisplayName = (char**) SilkMarshal.StringArrayToPtr(ppszDisplayNameSa);
        var ret = @this->GetDisplayName(pbc, ref pmkToLeft, ppszDisplayName);
        SilkMarshal.CopyPtrToStringArray((nint) ppszDisplayName, ppszDisplayNameSa);
        SilkMarshal.Free((nint) ppszDisplayName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, char** ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), ppszDisplayName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, char** ppszDisplayName) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, ppszDisplayName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, ref char* ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), ref ppszDisplayName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref char* ppszDisplayName) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, ref ppszDisplayName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, IMoniker* pmkToLeft, string[] ppszDisplayNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppszDisplayName = (char**) SilkMarshal.StringArrayToPtr(ppszDisplayNameSa);
        var ret = @this->GetDisplayName(ref pbc, pmkToLeft, ppszDisplayName);
        SilkMarshal.CopyPtrToStringArray((nint) ppszDisplayName, ppszDisplayNameSa);
        SilkMarshal.Free((nint) ppszDisplayName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, char** ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, ppszDisplayName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, char** ppszDisplayName) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, ppszDisplayName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, ref char* ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, ref ppszDisplayName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref char* ppszDisplayName) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, ref ppszDisplayName);
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayName(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, string[] ppszDisplayNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var ppszDisplayName = (char**) SilkMarshal.StringArrayToPtr(ppszDisplayNameSa);
        var ret = @this->GetDisplayName(ref pbc, ref pmkToLeft, ppszDisplayName);
        SilkMarshal.CopyPtrToStringArray((nint) ppszDisplayName, ppszDisplayNameSa);
        SilkMarshal.Free((nint) ppszDisplayName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, char** ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), ppszDisplayName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, ref char* ppszDisplayName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), ref ppszDisplayName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1, TI2>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, char* pszDisplayName, uint* pchEaten, ref ComPtr<TI2> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, char* pszDisplayName, Span<uint> pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, pmkToLeft, pszDisplayName, ref pchEaten.GetPinnableReference(), ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1, TI2>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref ComPtr<TI2> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, char* pszDisplayName, Span<uint> pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, pmkToLeft, pszDisplayName, ref pchEaten.GetPinnableReference(), ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Span<char> pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, pmkToLeft, ref pszDisplayName.GetPinnableReference(), pchEaten, ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1, TI2>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref ComPtr<TI2> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Span<char> pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, pmkToLeft, ref pszDisplayName.GetPinnableReference(), pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Span<char> pszDisplayName, Span<uint> pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, pmkToLeft, ref pszDisplayName.GetPinnableReference(), ref pchEaten.GetPinnableReference(), ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static int ParseDisplayName<TI0, TI1, TI2>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref ComPtr<TI2> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, Span<char> pszDisplayName, Span<uint> pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, pmkToLeft, ref pszDisplayName.GetPinnableReference(), ref pchEaten.GetPinnableReference(), ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, ref pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1, TI2>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref ComPtr<TI2> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, Span<uint> pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, pmkToLeft, pszDisplayName, ref pchEaten.GetPinnableReference(), ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static int ParseDisplayName<TI0, TI1, TI2>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref ComPtr<TI2> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, Span<uint> pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, pmkToLeft, pszDisplayName, ref pchEaten.GetPinnableReference(), ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, char* pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), pszDisplayName, pchEaten, ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, char* pszDisplayName, Span<uint> pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), pszDisplayName, ref pchEaten.GetPinnableReference(), ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, char* pszDisplayName, Span<uint> pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), pszDisplayName, ref pchEaten.GetPinnableReference(), ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, ref pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Span<char> pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), ref pszDisplayName.GetPinnableReference(), pchEaten, ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, ref pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Span<char> pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), ref pszDisplayName.GetPinnableReference(), pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, ref pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Span<char> pszDisplayName, Span<uint> pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), ref pszDisplayName.GetPinnableReference(), ref pchEaten.GetPinnableReference(), ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, ref pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, Span<char> pszDisplayName, Span<uint> pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), ref pszDisplayName.GetPinnableReference(), ref pchEaten.GetPinnableReference(), ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, ref pszDisplayName, ref pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), pszDisplayName, pchEaten, ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, Span<uint> pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), pszDisplayName, ref pchEaten.GetPinnableReference(), ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, IBindCtx* pbc, Span<IMoniker> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, Span<uint> pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(pbc, ref pmkToLeft.GetPinnableReference(), pszDisplayName, ref pchEaten.GetPinnableReference(), ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName((IBindCtx*) pbc.Handle, ref pmkToLeft, pszDisplayName, ref pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, char* pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, pszDisplayName, pchEaten, ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, char* pszDisplayName, uint* pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, char* pszDisplayName, Span<uint> pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, pszDisplayName, ref pchEaten.GetPinnableReference(), ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, char* pszDisplayName, Span<uint> pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, pszDisplayName, ref pchEaten.GetPinnableReference(), ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Span<char> pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, ref pszDisplayName.GetPinnableReference(), pchEaten, ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Span<char> pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, ref pszDisplayName.GetPinnableReference(), pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Span<char> pszDisplayName, Span<uint> pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, ref pszDisplayName.GetPinnableReference(), ref pchEaten.GetPinnableReference(), ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, Span<char> pszDisplayName, Span<uint> pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, ref pszDisplayName.GetPinnableReference(), ref pchEaten.GetPinnableReference(), ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, ref pszDisplayName, ref pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, pszDisplayName, pchEaten, ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, Span<uint> pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, pszDisplayName, ref pchEaten.GetPinnableReference(), ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static int ParseDisplayName<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref ComPtr<TI1> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, IMoniker* pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, Span<uint> pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), pmkToLeft, pszDisplayName, ref pchEaten.GetPinnableReference(), ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref IMoniker* ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, (IMoniker*) pmkToLeft.Handle, pszDisplayName, ref pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, char* pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), pszDisplayName, pchEaten, ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, char* pszDisplayName, uint* pchEaten, ref ComPtr<TI0> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, ref pmkToLeft, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, char* pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, char* pszDisplayName, Span<uint> pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), pszDisplayName, ref pchEaten.GetPinnableReference(), ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, char* pszDisplayName, ref uint pchEaten, ref ComPtr<TI0> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, ref pmkToLeft, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, char* pszDisplayName, Span<uint> pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), pszDisplayName, ref pchEaten.GetPinnableReference(), ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Span<char> pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), ref pszDisplayName.GetPinnableReference(), pchEaten, ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, uint* pchEaten, ref ComPtr<TI0> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, ref pmkToLeft, ref pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Span<char> pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), ref pszDisplayName.GetPinnableReference(), pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Span<char> pszDisplayName, Span<uint> pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), ref pszDisplayName.GetPinnableReference(), ref pchEaten.GetPinnableReference(), ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, ref char pszDisplayName, ref uint pchEaten, ref ComPtr<TI0> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, ref pmkToLeft, ref pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, Span<char> pszDisplayName, Span<uint> pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), ref pszDisplayName.GetPinnableReference(), ref pchEaten.GetPinnableReference(), ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), pszDisplayName, pchEaten, ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref ComPtr<TI0> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, ref pmkToLeft, pszDisplayName, pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, uint* pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), pszDisplayName, pchEaten, ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, Span<uint> pchEaten, IMoniker** ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), pszDisplayName, ref pchEaten.GetPinnableReference(), ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static int ParseDisplayName<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, ref uint pchEaten, ref ComPtr<TI0> ppmkOut) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->ParseDisplayName(ref pbc, ref pmkToLeft, pszDisplayName, ref pchEaten, (IMoniker**) ppmkOut.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ParseDisplayName(this ComPtr<IMoniker> thisVtbl, Span<IBindCtx> pbc, Span<IMoniker> pmkToLeft, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pszDisplayName, Span<uint> pchEaten, ref IMoniker* ppmkOut)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ParseDisplayName(ref pbc.GetPinnableReference(), ref pmkToLeft.GetPinnableReference(), pszDisplayName, ref pchEaten.GetPinnableReference(), ref ppmkOut);
    }

    /// <summary>To be documented.</summary>
    public static int IsSystemMoniker(this ComPtr<IMoniker> thisVtbl, Span<uint> pdwMksys)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->IsSystemMoniker(ref pdwMksys.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMoniker> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI2> BindToObject<TI0, TI1, TI2>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->BindToObject(pbc, pmkToLeft, out ComPtr<TI2> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> BindToObject<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->BindToObject(pbc, ref pmkToLeft, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> BindToObject<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->BindToObject(ref pbc, pmkToLeft, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> BindToObject<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->BindToObject(ref pbc, ref pmkToLeft, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI2> BindToStorage<TI0, TI1, TI2>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ComPtr<TI1> pmkToLeft) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->BindToStorage(pbc, pmkToLeft, out ComPtr<TI2> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> BindToStorage<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ComPtr<TI0> pbc, ref IMoniker pmkToLeft) where TI0 : unmanaged, IComVtbl<IBindCtx>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->BindToStorage(pbc, ref pmkToLeft, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI1> BindToStorage<TI0, TI1>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ComPtr<TI0> pmkToLeft) where TI0 : unmanaged, IComVtbl<IMoniker>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->BindToStorage(ref pbc, pmkToLeft, out ComPtr<TI1> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> BindToStorage<TI0>(this ComPtr<IMoniker> thisVtbl, ref IBindCtx pbc, ref IMoniker pmkToLeft) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->BindToStorage(ref pbc, ref pmkToLeft, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
