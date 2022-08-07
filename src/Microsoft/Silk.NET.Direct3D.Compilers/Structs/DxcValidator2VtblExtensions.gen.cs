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

public unsafe static class DxcValidator2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, void** ppvObject) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, Guid* riid, ref void* ppvObject) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, void** ppvObject) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface<TThis>(this TThis thisVtbl, ref Guid riid, ref void* ppvObject) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release<TThis>(this TThis thisVtbl) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate<TThis>(this TThis thisVtbl, IDxcBlob* pShader, uint Flags, IDxcOperationResult** ppResult) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, Flags, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate<TThis>(this TThis thisVtbl, IDxcBlob* pShader, uint Flags, ref IDxcOperationResult* ppResult) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, Flags, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate<TThis>(this TThis thisVtbl, ref IDxcBlob pShader, uint Flags, IDxcOperationResult** ppResult) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShaderPtr, Flags, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Validate<TThis>(this TThis thisVtbl, ref IDxcBlob pShader, uint Flags, ref IDxcOperationResult* ppResult) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShaderPtr, Flags, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug<TThis>(this TThis thisVtbl, IDxcBlob* pShader, uint Flags, Buffer* pOptDebugBitcode, IDxcOperationResult** ppResult) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResult);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug<TThis>(this TThis thisVtbl, IDxcBlob* pShader, uint Flags, Buffer* pOptDebugBitcode, ref IDxcOperationResult* ppResult) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcOperationResult** ppResultPtr = &ppResult)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResultPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug<TThis>(this TThis thisVtbl, IDxcBlob* pShader, uint Flags, ref Buffer pOptDebugBitcode, IDxcOperationResult** ppResult) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Buffer* pOptDebugBitcodePtr = &pOptDebugBitcode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcodePtr, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug<TThis>(this TThis thisVtbl, IDxcBlob* pShader, uint Flags, ref Buffer pOptDebugBitcode, ref IDxcOperationResult* ppResult) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (Buffer* pOptDebugBitcodePtr = &pOptDebugBitcode)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcodePtr, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug<TThis>(this TThis thisVtbl, ref IDxcBlob pShader, uint Flags, Buffer* pOptDebugBitcode, IDxcOperationResult** ppResult) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcode, ppResult);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug<TThis>(this TThis thisVtbl, ref IDxcBlob pShader, uint Flags, Buffer* pOptDebugBitcode, ref IDxcOperationResult* ppResult) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcode, ppResultPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug<TThis>(this TThis thisVtbl, ref IDxcBlob pShader, uint Flags, ref Buffer pOptDebugBitcode, IDxcOperationResult** ppResult) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            fixed (Buffer* pOptDebugBitcodePtr = &pOptDebugBitcode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcodePtr, ppResult);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ValidateWithDebug<TThis>(this TThis thisVtbl, ref IDxcBlob pShader, uint Flags, ref Buffer pOptDebugBitcode, ref IDxcOperationResult* ppResult) where TThis : IComVtbl<IDxcValidator2>
    {
        var @this = (IDxcValidator2*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (IDxcBlob* pShaderPtr = &pShader)
        {
            fixed (Buffer* pOptDebugBitcodePtr = &pOptDebugBitcode)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcodePtr, ppResultPtr);
                }
            }
        }
        return ret;
    }

}
