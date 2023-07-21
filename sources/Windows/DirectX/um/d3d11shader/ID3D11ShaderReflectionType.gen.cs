// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType"]/*' />
[Guid("6E6FFA6A-9BAE-4613-A51E-91652D508C21")]
public unsafe partial struct ID3D11ShaderReflectionType : ID3D11ShaderReflectionType.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderReflectionType));

    public void** lpVtbl;

    /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetDesc(D3D11_SHADER_TYPE_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionType*, D3D11_SHADER_TYPE_DESC*, int>)(lpVtbl[0]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetMemberTypeByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public ID3D11ShaderReflectionType* GetMemberTypeByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*>)(lpVtbl[1]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetMemberTypeByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D11ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionType*, sbyte*, ID3D11ShaderReflectionType*>)(lpVtbl[2]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetMemberTypeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPCSTR")]
    public sbyte* GetMemberTypeName(uint Index)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint, sbyte*>)(lpVtbl[3]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.IsEqual"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsEqual(ID3D11ShaderReflectionType* pType)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)(lpVtbl[4]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
    }

    /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetSubType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public ID3D11ShaderReflectionType* GetSubType()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*>)(lpVtbl[5]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetBaseClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public ID3D11ShaderReflectionType* GetBaseClass()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*>)(lpVtbl[6]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetNumInterfaces"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public uint GetNumInterfaces()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint>)(lpVtbl[7]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.GetInterfaceByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public ID3D11ShaderReflectionType* GetInterfaceByIndex(uint uIndex)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionType*, uint, ID3D11ShaderReflectionType*>)(lpVtbl[8]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), uIndex);
    }

    /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.IsOfType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsOfType(ID3D11ShaderReflectionType* pType)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)(lpVtbl[9]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
    }

    /// <include file='ID3D11ShaderReflectionType.xml' path='doc/member[@name="ID3D11ShaderReflectionType.ImplementsInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ImplementsInterface(ID3D11ShaderReflectionType* pBase)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionType*, ID3D11ShaderReflectionType*, int>)(lpVtbl[10]))((ID3D11ShaderReflectionType*)Unsafe.AsPointer(ref this), pBase);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetDesc(D3D11_SHADER_TYPE_DESC* pDesc);

        [VtblIndex(1)]
        ID3D11ShaderReflectionType* GetMemberTypeByIndex(uint Index);

        [VtblIndex(2)]
        ID3D11ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name);

        [VtblIndex(3)]
        [return: NativeTypeName("LPCSTR")]
        sbyte* GetMemberTypeName(uint Index);

        [VtblIndex(4)]
        HRESULT IsEqual(ID3D11ShaderReflectionType* pType);

        [VtblIndex(5)]
        ID3D11ShaderReflectionType* GetSubType();

        [VtblIndex(6)]
        ID3D11ShaderReflectionType* GetBaseClass();

        [VtblIndex(7)]
        uint GetNumInterfaces();

        [VtblIndex(8)]
        ID3D11ShaderReflectionType* GetInterfaceByIndex(uint uIndex);

        [VtblIndex(9)]
        HRESULT IsOfType(ID3D11ShaderReflectionType* pType);

        [VtblIndex(10)]
        HRESULT ImplementsInterface(ID3D11ShaderReflectionType* pBase);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (D3D11_SHADER_TYPE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_SHADER_TYPE_DESC*, int> GetDesc;

        [NativeTypeName("ID3D11ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D11ShaderReflectionType*> GetMemberTypeByIndex;

        [NativeTypeName("ID3D11ShaderReflectionType *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D11ShaderReflectionType*> GetMemberTypeByName;

        [NativeTypeName("LPCSTR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, sbyte*> GetMemberTypeName;

        [NativeTypeName("HRESULT (ID3D11ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11ShaderReflectionType*, int> IsEqual;

        [NativeTypeName("ID3D11ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11ShaderReflectionType*> GetSubType;

        [NativeTypeName("ID3D11ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11ShaderReflectionType*> GetBaseClass;

        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetNumInterfaces;

        [NativeTypeName("ID3D11ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D11ShaderReflectionType*> GetInterfaceByIndex;

        [NativeTypeName("HRESULT (ID3D11ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11ShaderReflectionType*, int> IsOfType;

        [NativeTypeName("HRESULT (ID3D11ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11ShaderReflectionType*, int> ImplementsInterface;
    }
}
