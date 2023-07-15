// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType"]/*'/>
[Guid("E913C351-783D-48CA-A1D1-4F306284AD56")]
public unsafe partial struct ID3D12ShaderReflectionType : ID3D12ShaderReflectionType.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12ShaderReflectionType));

    public void** lpVtbl;
    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetDesc(D3D12_SHADER_TYPE_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionType*, D3D12_SHADER_TYPE_DESC*, int> )(lpVtbl[0]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetMemberTypeByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public ID3D12ShaderReflectionType* GetMemberTypeByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*> )(lpVtbl[1]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetMemberTypeByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D12ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionType*, sbyte*, ID3D12ShaderReflectionType*> )(lpVtbl[2]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetMemberTypeName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPCSTR")]
    public sbyte* GetMemberTypeName(uint Index)
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionType*, uint, sbyte*> )(lpVtbl[3]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.IsEqual"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsEqual(ID3D12ShaderReflectionType* pType)
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int> )(lpVtbl[4]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
    }

    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetSubType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public ID3D12ShaderReflectionType* GetSubType()
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*> )(lpVtbl[5]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetBaseClass"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public ID3D12ShaderReflectionType* GetBaseClass()
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*> )(lpVtbl[6]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetNumInterfaces"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public uint GetNumInterfaces()
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionType*, uint> )(lpVtbl[7]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.GetInterfaceByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public ID3D12ShaderReflectionType* GetInterfaceByIndex(uint uIndex)
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*> )(lpVtbl[8]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), uIndex);
    }

    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.IsOfType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsOfType(ID3D12ShaderReflectionType* pType)
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int> )(lpVtbl[9]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
    }

    /// <include file='ID3D12ShaderReflectionType.xml' path='doc/member[@name="ID3D12ShaderReflectionType.ImplementsInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ImplementsInterface(ID3D12ShaderReflectionType* pBase)
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int> )(lpVtbl[10]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pBase);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetDesc(D3D12_SHADER_TYPE_DESC* pDesc);
        [VtblIndex(1)]
        ID3D12ShaderReflectionType* GetMemberTypeByIndex(uint Index);
        [VtblIndex(2)]
        ID3D12ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(3)]
        [return: NativeTypeName("LPCSTR")]
        sbyte* GetMemberTypeName(uint Index);
        [VtblIndex(4)]
        HRESULT IsEqual(ID3D12ShaderReflectionType* pType);
        [VtblIndex(5)]
        ID3D12ShaderReflectionType* GetSubType();
        [VtblIndex(6)]
        ID3D12ShaderReflectionType* GetBaseClass();
        [VtblIndex(7)]
        uint GetNumInterfaces();
        [VtblIndex(8)]
        ID3D12ShaderReflectionType* GetInterfaceByIndex(uint uIndex);
        [VtblIndex(9)]
        HRESULT IsOfType(ID3D12ShaderReflectionType* pType);
        [VtblIndex(10)]
        HRESULT ImplementsInterface(ID3D12ShaderReflectionType* pBase);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (D3D12_SHADER_TYPE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_SHADER_TYPE_DESC*, int> GetDesc;
        [NativeTypeName("ID3D12ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D12ShaderReflectionType*> GetMemberTypeByIndex;
        [NativeTypeName("ID3D12ShaderReflectionType *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D12ShaderReflectionType*> GetMemberTypeByName;
        [NativeTypeName("LPCSTR (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, sbyte*> GetMemberTypeName;
        [NativeTypeName("HRESULT (ID3D12ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12ShaderReflectionType*, int> IsEqual;
        [NativeTypeName("ID3D12ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12ShaderReflectionType*> GetSubType;
        [NativeTypeName("ID3D12ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12ShaderReflectionType*> GetBaseClass;
        [NativeTypeName("UINT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetNumInterfaces;
        [NativeTypeName("ID3D12ShaderReflectionType *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D12ShaderReflectionType*> GetInterfaceByIndex;
        [NativeTypeName("HRESULT (ID3D12ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12ShaderReflectionType*, int> IsOfType;
        [NativeTypeName("HRESULT (ID3D12ShaderReflectionType *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12ShaderReflectionType*, int> ImplementsInterface;
    }
}