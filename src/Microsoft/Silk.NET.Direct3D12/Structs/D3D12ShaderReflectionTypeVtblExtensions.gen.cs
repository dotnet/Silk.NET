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

public unsafe static class D3D12ShaderReflectionTypeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, ShaderTypeDesc* pDesc) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref ShaderTypeDesc pDesc) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ShaderTypeDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ShaderTypeDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetMemberTypeByIndex<TThis>(this TThis thisVtbl, uint Index) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)@this->LpVtbl[1])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetMemberTypeByName<TThis>(this TThis thisVtbl, byte* Name) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)@this->LpVtbl[2])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetMemberTypeByName<TThis>(this TThis thisVtbl, ref byte Name) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionType* ret = default;
        fixed (byte* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)@this->LpVtbl[2])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetMemberTypeByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionType* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, byte*, ID3D12ShaderReflectionType*>)@this->LpVtbl[2])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe byte* GetMemberTypeName<TThis>(this TThis thisVtbl, uint Index) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        byte* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, byte*>)@this->LpVtbl[3])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)]
    public static string GetMemberTypeNameS<TThis>(this TThis thisVtbl, uint Index) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        string ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, string>)@this->LpVtbl[3])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsEqual<TThis>(this TThis thisVtbl, ID3D12ShaderReflectionType* pType) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[4])(@this, pType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsEqual<TThis>(this TThis thisVtbl, ref ID3D12ShaderReflectionType pType) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ShaderReflectionType* pTypePtr = &pType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[4])(@this, pTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetSubType<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetBaseClass<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNumInterfaces<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetInterfaceByIndex<TThis>(this TThis thisVtbl, uint uIndex) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D12ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)@this->LpVtbl[8])(@this, uIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsOfType<TThis>(this TThis thisVtbl, ID3D12ShaderReflectionType* pType) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[9])(@this, pType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsOfType<TThis>(this TThis thisVtbl, ref ID3D12ShaderReflectionType pType) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ShaderReflectionType* pTypePtr = &pType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[9])(@this, pTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ImplementsInterface<TThis>(this TThis thisVtbl, ID3D12ShaderReflectionType* pBase) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[10])(@this, pBase);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ImplementsInterface<TThis>(this TThis thisVtbl, ref ID3D12ShaderReflectionType pBase) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D12ShaderReflectionType* pBasePtr = &pBase)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)@this->LpVtbl[10])(@this, pBasePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, Span<ShaderTypeDesc> pDesc) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D12ShaderReflectionType* GetMemberTypeByName<TThis>(this TThis thisVtbl, Span<byte> Name) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetMemberTypeByName(ref Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsEqual<TThis>(this TThis thisVtbl, Span<ID3D12ShaderReflectionType> pType) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->IsEqual(ref pType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsOfType<TThis>(this TThis thisVtbl, Span<ID3D12ShaderReflectionType> pType) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->IsOfType(ref pType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ImplementsInterface<TThis>(this TThis thisVtbl, Span<ID3D12ShaderReflectionType> pBase) where TThis : IComVtbl<ID3D12ShaderReflectionType>
    {
        var @this = (ID3D12ShaderReflectionType*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ImplementsInterface(ref pBase.GetPinnableReference());
    }

}
