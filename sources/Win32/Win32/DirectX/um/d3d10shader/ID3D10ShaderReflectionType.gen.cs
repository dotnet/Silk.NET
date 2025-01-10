// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("C530AD7D-9B16-4395-A979-BA2ECFF83ADD")]
public unsafe partial struct ID3D10ShaderReflectionType
    : ID3D10ShaderReflectionType.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10ShaderReflectionType));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetDesc(D3D10_SHADER_TYPE_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<ID3D10ShaderReflectionType*, D3D10_SHADER_TYPE_DESC*, int>)(
                (*lpVtbl)[0]
            )
        )((ID3D10ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public ID3D10ShaderReflectionType* GetMemberTypeByIndex(uint Index)
    {
        return (
            (delegate* unmanaged<ID3D10ShaderReflectionType*, uint, ID3D10ShaderReflectionType*>)(
                (*lpVtbl)[1]
            )
        )((ID3D10ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D10ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return (
            (delegate* unmanaged<ID3D10ShaderReflectionType*, sbyte*, ID3D10ShaderReflectionType*>)(
                (*lpVtbl)[2]
            )
        )((ID3D10ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPCSTR")]
    public sbyte* GetMemberTypeName(uint Index)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflectionType*, uint, sbyte*>)((*lpVtbl)[3]))(
            (ID3D10ShaderReflectionType*)Unsafe.AsPointer(ref this),
            Index
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetDesc(D3D10_SHADER_TYPE_DESC* pDesc);

        [VtblIndex(1)]
        ID3D10ShaderReflectionType* GetMemberTypeByIndex(uint Index);

        [VtblIndex(2)]
        ID3D10ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name);

        [VtblIndex(3)]
        [return: NativeTypeName("LPCSTR")]
        sbyte* GetMemberTypeName(uint Index);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName(
            "HRESULT (D3D10_SHADER_TYPE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3D10_SHADER_TYPE_DESC*, int> GetDesc;

        [NativeTypeName(
            "ID3D10ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ID3D10ShaderReflectionType*> GetMemberTypeByIndex;

        [NativeTypeName(
            "ID3D10ShaderReflectionType *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10ShaderReflectionType*> GetMemberTypeByName;

        [NativeTypeName("LPCSTR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, sbyte*> GetMemberTypeName;
    }
}
