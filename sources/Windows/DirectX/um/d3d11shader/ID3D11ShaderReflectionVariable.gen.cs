// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D11ShaderReflectionVariable.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable"]/*'/>
[Guid("51F23923-F3E5-4BD1-91CB-606177D8DB4C")]
public unsafe partial struct ID3D11ShaderReflectionVariable : ID3D11ShaderReflectionVariable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ShaderReflectionVariable));

    public void** lpVtbl;
    /// <include file='ID3D11ShaderReflectionVariable.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetDesc(D3D11_SHADER_VARIABLE_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionVariable*, D3D11_SHADER_VARIABLE_DESC*, int> )(lpVtbl[0]))((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D11ShaderReflectionVariable.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable.GetType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public new ID3D11ShaderReflectionType* GetType()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionVariable*, ID3D11ShaderReflectionType*> )(lpVtbl[1]))((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflectionVariable.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable.GetBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D11ShaderReflectionConstantBuffer* GetBuffer()
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionVariable*, ID3D11ShaderReflectionConstantBuffer*> )(lpVtbl[2]))((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D11ShaderReflectionVariable.xml' path='doc/member[@name="ID3D11ShaderReflectionVariable.GetInterfaceSlot"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public uint GetInterfaceSlot(uint uArrayIndex)
    {
        return ((delegate* unmanaged<ID3D11ShaderReflectionVariable*, uint, uint> )(lpVtbl[3]))((ID3D11ShaderReflectionVariable*)Unsafe.AsPointer(ref this), uArrayIndex);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetDesc(D3D11_SHADER_VARIABLE_DESC* pDesc);
        [VtblIndex(1)]
        ID3D11ShaderReflectionType* GetType();
        [VtblIndex(2)]
        ID3D11ShaderReflectionConstantBuffer* GetBuffer();
        [VtblIndex(3)]
        uint GetInterfaceSlot(uint uArrayIndex);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (D3D11_SHADER_VARIABLE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_SHADER_VARIABLE_DESC*, int> GetDesc;
        [NativeTypeName("ID3D11ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, ID3D11ShaderReflectionType*> GetType;
        [NativeTypeName("ID3D11ShaderReflectionConstantBuffer *() __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11ShaderReflectionConstantBuffer*> GetBuffer;
        [NativeTypeName("UINT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint> GetInterfaceSlot;
    }
}