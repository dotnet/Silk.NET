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

namespace Silk.NET.Direct3D11;

public unsafe static class D3D11ShaderReflectionTypeVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int GetDesc<TThis>(this TThis thisVtbl, ShaderTypeDesc* pDesc) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ShaderTypeDesc*, int>)@this->LpVtbl[0])(@this, pDesc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, ref ShaderTypeDesc pDesc) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ShaderTypeDesc* pDescPtr = &pDesc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ShaderTypeDesc*, int>)@this->LpVtbl[0])(@this, pDescPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionType* GetMemberTypeByIndex<TThis>(this TThis thisVtbl, uint Index) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*>)@this->LpVtbl[1])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionType* GetMemberTypeByName<TThis>(this TThis thisVtbl, byte* Name) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, byte*, ID3D11ShaderReflectionType*>)@this->LpVtbl[2])(@this, Name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionType* GetMemberTypeByName<TThis>(this TThis thisVtbl, ref byte Name) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionType* ret = default;
        fixed (byte* NamePtr = &Name)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, byte*, ID3D11ShaderReflectionType*>)@this->LpVtbl[2])(@this, NamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionType* GetMemberTypeByName<TThis>(this TThis thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionType* ret = default;
        var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, byte*, ID3D11ShaderReflectionType*>)@this->LpVtbl[2])(@this, NamePtr);
        SilkMarshal.Free((nint)NamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe byte* GetMemberTypeName<TThis>(this TThis thisVtbl, uint Index) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        byte* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, uint, byte*>)@this->LpVtbl[3])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)]
    public static string GetMemberTypeNameS<TThis>(this TThis thisVtbl, uint Index) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        string ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, uint, string>)@this->LpVtbl[3])(@this, Index);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsEqual<TThis>(this TThis thisVtbl, ID3D11ShaderReflectionType* pType) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)@this->LpVtbl[4])(@this, pType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsEqual<TThis>(this TThis thisVtbl, ref ID3D11ShaderReflectionType pType) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ShaderReflectionType* pTypePtr = &pType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)@this->LpVtbl[4])(@this, pTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionType* GetSubType<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionType* GetBaseClass<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetNumInterfaces<TThis>(this TThis thisVtbl) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, uint>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionType* GetInterfaceByIndex<TThis>(this TThis thisVtbl, uint uIndex) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        ID3D11ShaderReflectionType* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*>)@this->LpVtbl[8])(@this, uIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsOfType<TThis>(this TThis thisVtbl, ID3D11ShaderReflectionType* pType) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)@this->LpVtbl[9])(@this, pType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int IsOfType<TThis>(this TThis thisVtbl, ref ID3D11ShaderReflectionType pType) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ShaderReflectionType* pTypePtr = &pType)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)@this->LpVtbl[9])(@this, pTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ImplementsInterface<TThis>(this TThis thisVtbl, ID3D11ShaderReflectionType* pBase) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)@this->LpVtbl[10])(@this, pBase);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ImplementsInterface<TThis>(this TThis thisVtbl, ref ID3D11ShaderReflectionType pBase) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        int ret = default;
        fixed (ID3D11ShaderReflectionType* pBasePtr = &pBase)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)@this->LpVtbl[10])(@this, pBasePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesc<TThis>(this TThis thisVtbl, Span<ShaderTypeDesc> pDesc) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetDesc(ref pDesc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe ID3D11ShaderReflectionType* GetMemberTypeByName<TThis>(this TThis thisVtbl, Span<byte> Name) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->GetMemberTypeByName(ref Name.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsEqual<TThis>(this TThis thisVtbl, Span<ID3D11ShaderReflectionType> pType) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->IsEqual(ref pType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int IsOfType<TThis>(this TThis thisVtbl, Span<ID3D11ShaderReflectionType> pType) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->IsOfType(ref pType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ImplementsInterface<TThis>(this TThis thisVtbl, Span<ID3D11ShaderReflectionType> pBase) where TThis : IComVtbl<ID3D11ShaderReflectionType>
    {
        var @this = (ID3D11ShaderReflectionType*) thisVtbl.AsVtblPtr();
        // SpanOverloader
        return @this->ImplementsInterface(ref pBase.GetPinnableReference());
    }

}
