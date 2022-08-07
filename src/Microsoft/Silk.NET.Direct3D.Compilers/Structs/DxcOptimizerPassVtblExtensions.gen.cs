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

namespace Silk.NET.Direct3D.Compilers;

public unsafe static class DxcOptimizerPassVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionName<TThis>(this TThis thisVtbl, char** ppResult) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)@this->LpVtbl[3])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionName<TThis>(this TThis thisVtbl, ref char* ppResult) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)@this->LpVtbl[3])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDescription<TThis>(this TThis thisVtbl, char** ppResult) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)@this->LpVtbl[4])(@this, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDescription<TThis>(this TThis thisVtbl, ref char* ppResult) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)@this->LpVtbl[4])(@this, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionArgCount<TThis>(this TThis thisVtbl, uint* pCount) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint*, int>)@this->LpVtbl[5])(@this, pCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetOptionArgCount<TThis>(this TThis thisVtbl, ref uint pCount) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (uint* pCountPtr = &pCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint*, int>)@this->LpVtbl[5])(@this, pCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionArgName<TThis>(this TThis thisVtbl, uint argIndex, char** ppResult) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)@this->LpVtbl[6])(@this, argIndex, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionArgName<TThis>(this TThis thisVtbl, uint argIndex, ref char* ppResult) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)@this->LpVtbl[6])(@this, argIndex, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionArgDescription<TThis>(this TThis thisVtbl, uint argIndex, char** ppResult) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)@this->LpVtbl[7])(@this, argIndex, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOptionArgDescription<TThis>(this TThis thisVtbl, uint argIndex, ref char* ppResult) where TThis : IComVtbl<IDxcOptimizerPass>
    {
        var @this = (IDxcOptimizerPass*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (char** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)@this->LpVtbl[7])(@this, argIndex, ppResultPtr);
        }
        return ret;
    }

}
