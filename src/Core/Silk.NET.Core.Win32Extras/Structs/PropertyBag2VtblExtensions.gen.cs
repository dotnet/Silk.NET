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

public unsafe static class PropertyBag2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyBag2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyBag2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyBag2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyBag2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IPropertyBag2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IPropertyBag2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, IErrorLog* pErrLog, Variant* pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLog, pvarValue, phrError);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, IErrorLog* pErrLog, Variant* pvarValue, ref int phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* phrErrorPtr = &phrError)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLog, pvarValue, phrErrorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, IErrorLog* pErrLog, ref Variant pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pvarValuePtr = &pvarValue)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLog, pvarValuePtr, phrError);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, IErrorLog* pErrLog, ref Variant pvarValue, ref int phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pvarValuePtr = &pvarValue)
        {
            fixed (int* phrErrorPtr = &phrError)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLog, pvarValuePtr, phrErrorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, ref IErrorLog pErrLog, Variant* pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IErrorLog* pErrLogPtr = &pErrLog)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLogPtr, pvarValue, phrError);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, ref IErrorLog pErrLog, Variant* pvarValue, ref int phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IErrorLog* pErrLogPtr = &pErrLog)
        {
            fixed (int* phrErrorPtr = &phrError)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLogPtr, pvarValue, phrErrorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, ref IErrorLog pErrLog, ref Variant pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IErrorLog* pErrLogPtr = &pErrLog)
        {
            fixed (Variant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLogPtr, pvarValuePtr, phrError);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, ref IErrorLog pErrLog, ref Variant pvarValue, ref int phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IErrorLog* pErrLogPtr = &pErrLog)
        {
            fixed (Variant* pvarValuePtr = &pvarValue)
            {
                fixed (int* phrErrorPtr = &phrError)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBag, pErrLogPtr, pvarValuePtr, phrErrorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, IErrorLog* pErrLog, Variant* pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropBag2* pPropBagPtr = &pPropBag)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLog, pvarValue, phrError);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, IErrorLog* pErrLog, Variant* pvarValue, ref int phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropBag2* pPropBagPtr = &pPropBag)
        {
            fixed (int* phrErrorPtr = &phrError)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLog, pvarValue, phrErrorPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, IErrorLog* pErrLog, ref Variant pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropBag2* pPropBagPtr = &pPropBag)
        {
            fixed (Variant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLog, pvarValuePtr, phrError);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, IErrorLog* pErrLog, ref Variant pvarValue, ref int phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropBag2* pPropBagPtr = &pPropBag)
        {
            fixed (Variant* pvarValuePtr = &pvarValue)
            {
                fixed (int* phrErrorPtr = &phrError)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLog, pvarValuePtr, phrErrorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, ref IErrorLog pErrLog, Variant* pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropBag2* pPropBagPtr = &pPropBag)
        {
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLogPtr, pvarValue, phrError);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, ref IErrorLog pErrLog, Variant* pvarValue, ref int phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropBag2* pPropBagPtr = &pPropBag)
        {
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                fixed (int* phrErrorPtr = &phrError)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLogPtr, pvarValue, phrErrorPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, ref IErrorLog pErrLog, ref Variant pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropBag2* pPropBagPtr = &pPropBag)
        {
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                fixed (Variant* pvarValuePtr = &pvarValue)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLogPtr, pvarValuePtr, phrError);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, ref IErrorLog pErrLog, ref Variant pvarValue, ref int phrError)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropBag2* pPropBagPtr = &pPropBag)
        {
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                fixed (Variant* pvarValuePtr = &pvarValue)
                {
                    fixed (int* phrErrorPtr = &phrError)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, IErrorLog*, Variant*, int*, int>)@this->LpVtbl[3])(@this, cProperties, pPropBagPtr, pErrLogPtr, pvarValuePtr, phrErrorPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, Variant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, Variant*, int>)@this->LpVtbl[4])(@this, cProperties, pPropBag, pvarValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, ref Variant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Variant* pvarValuePtr = &pvarValue)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, Variant*, int>)@this->LpVtbl[4])(@this, cProperties, pPropBag, pvarValuePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, Variant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropBag2* pPropBagPtr = &pPropBag)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, Variant*, int>)@this->LpVtbl[4])(@this, cProperties, pPropBagPtr, pvarValue);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Write(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, ref Variant pvarValue)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropBag2* pPropBagPtr = &pPropBag)
        {
            fixed (Variant* pvarValuePtr = &pvarValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, PropBag2*, Variant*, int>)@this->LpVtbl[4])(@this, cProperties, pPropBagPtr, pvarValuePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CountProperties(this ComPtr<IPropertyBag2> thisVtbl, uint* pcProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint*, int>)@this->LpVtbl[5])(@this, pcProperties);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int CountProperties(this ComPtr<IPropertyBag2> thisVtbl, ref uint pcProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcPropertiesPtr = &pcProperties)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint*, int>)@this->LpVtbl[5])(@this, pcPropertiesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyInfo(this ComPtr<IPropertyBag2> thisVtbl, uint iProperty, uint cProperties, PropBag2* pPropBag, uint* pcProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, uint, PropBag2*, uint*, int>)@this->LpVtbl[6])(@this, iProperty, cProperties, pPropBag, pcProperties);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyInfo(this ComPtr<IPropertyBag2> thisVtbl, uint iProperty, uint cProperties, PropBag2* pPropBag, ref uint pcProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pcPropertiesPtr = &pcProperties)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, uint, PropBag2*, uint*, int>)@this->LpVtbl[6])(@this, iProperty, cProperties, pPropBag, pcPropertiesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyInfo(this ComPtr<IPropertyBag2> thisVtbl, uint iProperty, uint cProperties, ref PropBag2 pPropBag, uint* pcProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropBag2* pPropBagPtr = &pPropBag)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, uint, PropBag2*, uint*, int>)@this->LpVtbl[6])(@this, iProperty, cProperties, pPropBagPtr, pcProperties);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPropertyInfo(this ComPtr<IPropertyBag2> thisVtbl, uint iProperty, uint cProperties, ref PropBag2 pPropBag, ref uint pcProperties)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (PropBag2* pPropBagPtr = &pPropBag)
        {
            fixed (uint* pcPropertiesPtr = &pcProperties)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, uint, uint, PropBag2*, uint*, int>)@this->LpVtbl[6])(@this, iProperty, cProperties, pPropBagPtr, pcPropertiesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, IErrorLog* pErrLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrName, dwHint, pUnkObject, pErrLog);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, ref IErrorLog pErrLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IErrorLog* pErrLogPtr = &pErrLog)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrName, dwHint, pUnkObject, pErrLogPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, IErrorLog* pErrLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkObjectPtr = &pUnkObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrName, dwHint, pUnkObjectPtr, pErrLog);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, ref IErrorLog pErrLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkObjectPtr = &pUnkObject)
        {
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrName, dwHint, pUnkObjectPtr, pErrLogPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, IErrorLog* pErrLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pstrNamePtr = &pstrName)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObject, pErrLog);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, ref IErrorLog pErrLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pstrNamePtr = &pstrName)
        {
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObject, pErrLogPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, IErrorLog* pErrLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pstrNamePtr = &pstrName)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnkObjectPtr = &pUnkObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObjectPtr, pErrLog);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, ref IErrorLog pErrLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* pstrNamePtr = &pstrName)
        {
            fixed (Silk.NET.Core.Native.IUnknown* pUnkObjectPtr = &pUnkObject)
            {
                fixed (IErrorLog* pErrLogPtr = &pErrLog)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, char*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObjectPtr, pErrLogPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, IErrorLog* pErrLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pstrNamePtr = (byte*) SilkMarshal.StringToPtr(pstrName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, byte*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObject, pErrLog);
        SilkMarshal.Free((nint)pstrNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, ref IErrorLog pErrLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pstrNamePtr = (byte*) SilkMarshal.StringToPtr(pstrName, NativeStringEncoding.UTF8);
        fixed (IErrorLog* pErrLogPtr = &pErrLog)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, byte*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObject, pErrLogPtr);
        }
        SilkMarshal.Free((nint)pstrNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, IErrorLog* pErrLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pstrNamePtr = (byte*) SilkMarshal.StringToPtr(pstrName, NativeStringEncoding.UTF8);
        fixed (Silk.NET.Core.Native.IUnknown* pUnkObjectPtr = &pUnkObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, byte*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObjectPtr, pErrLog);
        }
        SilkMarshal.Free((nint)pstrNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, ref IErrorLog pErrLog)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var pstrNamePtr = (byte*) SilkMarshal.StringToPtr(pstrName, NativeStringEncoding.UTF8);
        fixed (Silk.NET.Core.Native.IUnknown* pUnkObjectPtr = &pUnkObject)
        {
            fixed (IErrorLog* pErrLogPtr = &pErrLog)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPropertyBag2*, byte*, uint, Silk.NET.Core.Native.IUnknown*, IErrorLog*, int>)@this->LpVtbl[7])(@this, pstrNamePtr, dwHint, pUnkObjectPtr, pErrLogPtr);
            }
        }
        SilkMarshal.Free((nint)pstrNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IPropertyBag2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyBag2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IPropertyBag2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<TI0>(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, ComPtr<TI0> pErrLog, Variant* pvarValue, int* phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(cProperties, pPropBag, (IErrorLog*) pErrLog.Handle, pvarValue, phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, IErrorLog* pErrLog, Variant* pvarValue, Span<int> phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, pPropBag, pErrLog, pvarValue, ref phrError.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<TI0>(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, ComPtr<TI0> pErrLog, Variant* pvarValue, ref int phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(cProperties, pPropBag, (IErrorLog*) pErrLog.Handle, pvarValue, ref phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, IErrorLog* pErrLog, Span<Variant> pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, pPropBag, pErrLog, ref pvarValue.GetPinnableReference(), phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<TI0>(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, ComPtr<TI0> pErrLog, ref Variant pvarValue, int* phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(cProperties, pPropBag, (IErrorLog*) pErrLog.Handle, ref pvarValue, phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, IErrorLog* pErrLog, Span<Variant> pvarValue, Span<int> phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, pPropBag, pErrLog, ref pvarValue.GetPinnableReference(), ref phrError.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<TI0>(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, ComPtr<TI0> pErrLog, ref Variant pvarValue, ref int phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(cProperties, pPropBag, (IErrorLog*) pErrLog.Handle, ref pvarValue, ref phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, Span<IErrorLog> pErrLog, Variant* pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, pPropBag, ref pErrLog.GetPinnableReference(), pvarValue, phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, Span<IErrorLog> pErrLog, Variant* pvarValue, Span<int> phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, pPropBag, ref pErrLog.GetPinnableReference(), pvarValue, ref phrError.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, Span<IErrorLog> pErrLog, Span<Variant> pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, pPropBag, ref pErrLog.GetPinnableReference(), ref pvarValue.GetPinnableReference(), phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, Span<IErrorLog> pErrLog, Span<Variant> pvarValue, Span<int> phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, pPropBag, ref pErrLog.GetPinnableReference(), ref pvarValue.GetPinnableReference(), ref phrError.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, Span<PropBag2> pPropBag, IErrorLog* pErrLog, Variant* pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, ref pPropBag.GetPinnableReference(), pErrLog, pvarValue, phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<TI0>(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, ComPtr<TI0> pErrLog, Variant* pvarValue, int* phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(cProperties, ref pPropBag, (IErrorLog*) pErrLog.Handle, pvarValue, phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, Span<PropBag2> pPropBag, IErrorLog* pErrLog, Variant* pvarValue, Span<int> phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, ref pPropBag.GetPinnableReference(), pErrLog, pvarValue, ref phrError.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<TI0>(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, ComPtr<TI0> pErrLog, Variant* pvarValue, ref int phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(cProperties, ref pPropBag, (IErrorLog*) pErrLog.Handle, pvarValue, ref phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, Span<PropBag2> pPropBag, IErrorLog* pErrLog, Span<Variant> pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, ref pPropBag.GetPinnableReference(), pErrLog, ref pvarValue.GetPinnableReference(), phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read<TI0>(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, ComPtr<TI0> pErrLog, ref Variant pvarValue, int* phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(cProperties, ref pPropBag, (IErrorLog*) pErrLog.Handle, ref pvarValue, phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, Span<PropBag2> pPropBag, IErrorLog* pErrLog, Span<Variant> pvarValue, Span<int> phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, ref pPropBag.GetPinnableReference(), pErrLog, ref pvarValue.GetPinnableReference(), ref phrError.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Read<TI0>(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, ref PropBag2 pPropBag, ComPtr<TI0> pErrLog, ref Variant pvarValue, ref int phrError) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Read(cProperties, ref pPropBag, (IErrorLog*) pErrLog.Handle, ref pvarValue, ref phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, Span<PropBag2> pPropBag, Span<IErrorLog> pErrLog, Variant* pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, ref pPropBag.GetPinnableReference(), ref pErrLog.GetPinnableReference(), pvarValue, phrError);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, Span<PropBag2> pPropBag, Span<IErrorLog> pErrLog, Variant* pvarValue, Span<int> phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, ref pPropBag.GetPinnableReference(), ref pErrLog.GetPinnableReference(), pvarValue, ref phrError.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, Span<PropBag2> pPropBag, Span<IErrorLog> pErrLog, Span<Variant> pvarValue, int* phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, ref pPropBag.GetPinnableReference(), ref pErrLog.GetPinnableReference(), ref pvarValue.GetPinnableReference(), phrError);
    }

    /// <summary>To be documented.</summary>
    public static int Read(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, Span<PropBag2> pPropBag, Span<IErrorLog> pErrLog, Span<Variant> pvarValue, Span<int> phrError)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Read(cProperties, ref pPropBag.GetPinnableReference(), ref pErrLog.GetPinnableReference(), ref pvarValue.GetPinnableReference(), ref phrError.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, PropBag2* pPropBag, Span<Variant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(cProperties, pPropBag, ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Write(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, Span<PropBag2> pPropBag, Variant* pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(cProperties, ref pPropBag.GetPinnableReference(), pvarValue);
    }

    /// <summary>To be documented.</summary>
    public static int Write(this ComPtr<IPropertyBag2> thisVtbl, uint cProperties, Span<PropBag2> pPropBag, Span<Variant> pvarValue)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Write(cProperties, ref pPropBag.GetPinnableReference(), ref pvarValue.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CountProperties(this ComPtr<IPropertyBag2> thisVtbl, Span<uint> pcProperties)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CountProperties(ref pcProperties.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyInfo(this ComPtr<IPropertyBag2> thisVtbl, uint iProperty, uint cProperties, PropBag2* pPropBag, Span<uint> pcProperties)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPropertyInfo(iProperty, cProperties, pPropBag, ref pcProperties.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyInfo(this ComPtr<IPropertyBag2> thisVtbl, uint iProperty, uint cProperties, Span<PropBag2> pPropBag, uint* pcProperties)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPropertyInfo(iProperty, cProperties, ref pPropBag.GetPinnableReference(), pcProperties);
    }

    /// <summary>To be documented.</summary>
    public static int GetPropertyInfo(this ComPtr<IPropertyBag2> thisVtbl, uint iProperty, uint cProperties, Span<PropBag2> pPropBag, Span<uint> pcProperties)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPropertyInfo(iProperty, cProperties, ref pPropBag.GetPinnableReference(), ref pcProperties.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject<TI0, TI1>(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, ComPtr<TI0> pUnkObject, ComPtr<TI1> pErrLog) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadObject(pstrName, dwHint, (Silk.NET.Core.Native.IUnknown*) pUnkObject.Handle, (IErrorLog*) pErrLog.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, Span<IErrorLog> pErrLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadObject(pstrName, dwHint, pUnkObject, ref pErrLog.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject<TI0>(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, ComPtr<TI0> pUnkObject, ref IErrorLog pErrLog) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadObject(pstrName, dwHint, (Silk.NET.Core.Native.IUnknown*) pUnkObject.Handle, ref pErrLog);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, Span<Silk.NET.Core.Native.IUnknown> pUnkObject, IErrorLog* pErrLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadObject(pstrName, dwHint, ref pUnkObject.GetPinnableReference(), pErrLog);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject<TI0>(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, ComPtr<TI0> pErrLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadObject(pstrName, dwHint, ref pUnkObject, (IErrorLog*) pErrLog.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pstrName, uint dwHint, Span<Silk.NET.Core.Native.IUnknown> pUnkObject, Span<IErrorLog> pErrLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadObject(pstrName, dwHint, ref pUnkObject.GetPinnableReference(), ref pErrLog.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, IErrorLog* pErrLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadObject(in pstrName.GetPinnableReference(), dwHint, pUnkObject, pErrLog);
    }

    /// <summary>To be documented.</summary>
    public static int LoadObject<TI0, TI1>(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, ComPtr<TI0> pUnkObject, ComPtr<TI1> pErrLog) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadObject(in pstrName, dwHint, (Silk.NET.Core.Native.IUnknown*) pUnkObject.Handle, (IErrorLog*) pErrLog.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, Span<IErrorLog> pErrLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadObject(in pstrName.GetPinnableReference(), dwHint, pUnkObject, ref pErrLog.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int LoadObject<TI0>(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, ComPtr<TI0> pUnkObject, ref IErrorLog pErrLog) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadObject(in pstrName, dwHint, (Silk.NET.Core.Native.IUnknown*) pUnkObject.Handle, ref pErrLog);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pstrName, uint dwHint, Span<Silk.NET.Core.Native.IUnknown> pUnkObject, IErrorLog* pErrLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadObject(in pstrName.GetPinnableReference(), dwHint, ref pUnkObject.GetPinnableReference(), pErrLog);
    }

    /// <summary>To be documented.</summary>
    public static int LoadObject<TI0>(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, ComPtr<TI0> pErrLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadObject(in pstrName, dwHint, ref pUnkObject, (IErrorLog*) pErrLog.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> pstrName, uint dwHint, Span<Silk.NET.Core.Native.IUnknown> pUnkObject, Span<IErrorLog> pErrLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadObject(in pstrName.GetPinnableReference(), dwHint, ref pUnkObject.GetPinnableReference(), ref pErrLog.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int LoadObject<TI0, TI1>(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, ComPtr<TI0> pUnkObject, ComPtr<TI1> pErrLog) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadObject(pstrName, dwHint, (Silk.NET.Core.Native.IUnknown*) pUnkObject.Handle, (IErrorLog*) pErrLog.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, Silk.NET.Core.Native.IUnknown* pUnkObject, Span<IErrorLog> pErrLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadObject(pstrName, dwHint, pUnkObject, ref pErrLog.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int LoadObject<TI0>(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, ComPtr<TI0> pUnkObject, ref IErrorLog pErrLog) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadObject(pstrName, dwHint, (Silk.NET.Core.Native.IUnknown*) pUnkObject.Handle, ref pErrLog);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, Span<Silk.NET.Core.Native.IUnknown> pUnkObject, IErrorLog* pErrLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadObject(pstrName, dwHint, ref pUnkObject.GetPinnableReference(), pErrLog);
    }

    /// <summary>To be documented.</summary>
    public static int LoadObject<TI0>(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, ref Silk.NET.Core.Native.IUnknown pUnkObject, ComPtr<TI0> pErrLog) where TI0 : unmanaged, IComVtbl<IErrorLog>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->LoadObject(pstrName, dwHint, ref pUnkObject, (IErrorLog*) pErrLog.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int LoadObject(this ComPtr<IPropertyBag2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pstrName, uint dwHint, Span<Silk.NET.Core.Native.IUnknown> pUnkObject, Span<IErrorLog> pErrLog)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->LoadObject(pstrName, dwHint, ref pUnkObject.GetPinnableReference(), ref pErrLog.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IPropertyBag2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
