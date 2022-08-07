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

namespace Silk.NET.Direct3D12;

public unsafe static class D3D12FunctionReflectionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, FunctionDesc* pDesc) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, FunctionDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref FunctionDesc pDesc) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (FunctionDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, FunctionDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex<TThis>(this TThis thisVtbl, uint BufferIndex) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionConstantBuffer* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[1])(@this, BufferIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName<TThis>(this TThis thisVtbl, byte* Name) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionConstantBuffer* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName<TThis>(this TThis thisVtbl, ref byte Name) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionConstantBuffer* ret = default;
        fixed (byte* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionConstantBuffer* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)@this->LpVtbl[2])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDesc<TThis>(this TThis thisVtbl, uint ResourceIndex, ShaderInputBindDesc* pDesc) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[3])(@this, ResourceIndex, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDesc<TThis>(this TThis thisVtbl, uint ResourceIndex, ref ShaderInputBindDesc pDesc) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)@this->LpVtbl[3])(@this, ResourceIndex, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionVariable* GetVariableByName<TThis>(this TThis thisVtbl, byte* Name) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionVariable* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[4])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionVariable* GetVariableByName<TThis>(this TThis thisVtbl, ref byte Name) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionVariable* ret = default;
        fixed (byte* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[4])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionVariable* GetVariableByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionVariable* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)@this->LpVtbl[4])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName<TThis>(this TThis thisVtbl, byte* Name, ShaderInputBindDesc* pDesc) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, Name, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName<TThis>(this TThis thisVtbl, byte* Name, ref ShaderInputBindDesc pDesc) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, Name, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName<TThis>(this TThis thisVtbl, ref byte Name, ShaderInputBindDesc* pDesc) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePtr, pDesc);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDescByName<TThis>(this TThis thisVtbl, ref byte Name, ref ShaderInputBindDesc pDesc) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (byte* NamePtr = &Name)
        {
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePtr, pDescPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetResourceBindingDescByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ShaderInputBindDesc* pDesc) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePtr, pDesc);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetResourceBindingDescByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ref ShaderInputBindDesc pDesc) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        int ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)@this->LpVtbl[5])(@this, NamePtr, pDescPtr);
        }
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12FunctionParameterReflection* GetFunctionParameter<TThis>(this TThis thisVtbl, int ParameterIndex) where TThis : IComVtbl<ID3D12FunctionReflection>
    {
        var @this = (ID3D12FunctionReflection*) thisVtbl.AsVtblPtr();
        ID3D12FunctionParameterReflection* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, int, ID3D12FunctionParameterReflection*>)@this->LpVtbl[6])(@this, ParameterIndex);
        return ret;
    }

}
