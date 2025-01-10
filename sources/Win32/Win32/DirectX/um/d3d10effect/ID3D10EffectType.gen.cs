// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct ID3D10EffectType : ID3D10EffectType.Interface
{
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public BOOL IsValid()
    {
        return ((delegate* unmanaged<ID3D10EffectType*, int>)((*lpVtbl)[0]))(
            (ID3D10EffectType*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT GetDesc(D3D10_EFFECT_TYPE_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<ID3D10EffectType*, D3D10_EFFECT_TYPE_DESC*, int>)((*lpVtbl)[1])
        )((ID3D10EffectType*)Unsafe.AsPointer(ref this), pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D10EffectType* GetMemberTypeByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10EffectType*, uint, ID3D10EffectType*>)((*lpVtbl)[2]))(
            (ID3D10EffectType*)Unsafe.AsPointer(ref this),
            Index
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public ID3D10EffectType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10EffectType*, sbyte*, ID3D10EffectType*>)((*lpVtbl)[3]))(
            (ID3D10EffectType*)Unsafe.AsPointer(ref this),
            Name
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D10EffectType* GetMemberTypeBySemantic([NativeTypeName("LPCSTR")] sbyte* Semantic)
    {
        return ((delegate* unmanaged<ID3D10EffectType*, sbyte*, ID3D10EffectType*>)((*lpVtbl)[4]))(
            (ID3D10EffectType*)Unsafe.AsPointer(ref this),
            Semantic
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("LPCSTR")]
    public sbyte* GetMemberName(uint Index)
    {
        return ((delegate* unmanaged<ID3D10EffectType*, uint, sbyte*>)((*lpVtbl)[5]))(
            (ID3D10EffectType*)Unsafe.AsPointer(ref this),
            Index
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("LPCSTR")]
    public sbyte* GetMemberSemantic(uint Index)
    {
        return ((delegate* unmanaged<ID3D10EffectType*, uint, sbyte*>)((*lpVtbl)[6]))(
            (ID3D10EffectType*)Unsafe.AsPointer(ref this),
            Index
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        BOOL IsValid();

        [VtblIndex(1)]
        HRESULT GetDesc(D3D10_EFFECT_TYPE_DESC* pDesc);

        [VtblIndex(2)]
        ID3D10EffectType* GetMemberTypeByIndex(uint Index);

        [VtblIndex(3)]
        ID3D10EffectType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name);

        [VtblIndex(4)]
        ID3D10EffectType* GetMemberTypeBySemantic([NativeTypeName("LPCSTR")] sbyte* Semantic);

        [VtblIndex(5)]
        [return: NativeTypeName("LPCSTR")]
        sbyte* GetMemberName(uint Index);

        [VtblIndex(6)]
        [return: NativeTypeName("LPCSTR")]
        sbyte* GetMemberSemantic(uint Index);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsValid;

        [NativeTypeName(
            "HRESULT (D3D10_EFFECT_TYPE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3D10_EFFECT_TYPE_DESC*, int> GetDesc;

        [NativeTypeName(
            "ID3D10EffectType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ID3D10EffectType*> GetMemberTypeByIndex;

        [NativeTypeName(
            "ID3D10EffectType *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectType*> GetMemberTypeByName;

        [NativeTypeName(
            "ID3D10EffectType *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectType*> GetMemberTypeBySemantic;

        [NativeTypeName("LPCSTR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, sbyte*> GetMemberName;

        [NativeTypeName("LPCSTR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, sbyte*> GetMemberSemantic;
    }
}
