// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3D12ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer"]/*'/>
[Guid("C59598B4-48B3-4869-B9B1-B1618B14A8B7")]
public unsafe partial struct ID3D12ShaderReflectionConstantBuffer : ID3D12ShaderReflectionConstantBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12ShaderReflectionConstantBuffer));

    public void** lpVtbl;
    /// <include file='ID3D12ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetDesc(D3D12_SHADER_BUFFER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionConstantBuffer*, D3D12_SHADER_BUFFER_DESC*, int> )(lpVtbl[0]))((ID3D12ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D12ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer.GetVariableByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public ID3D12ShaderReflectionVariable* GetVariableByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionConstantBuffer*, uint, ID3D12ShaderReflectionVariable*> )(lpVtbl[1]))((ID3D12ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D12ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D12ShaderReflectionConstantBuffer.GetVariableByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D12ShaderReflectionConstantBuffer*, sbyte*, ID3D12ShaderReflectionVariable*> )(lpVtbl[2]))((ID3D12ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Name);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetDesc(D3D12_SHADER_BUFFER_DESC* pDesc);
        [VtblIndex(1)]
        ID3D12ShaderReflectionVariable* GetVariableByIndex(uint Index);
        [VtblIndex(2)]
        ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (D3D12_SHADER_BUFFER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_SHADER_BUFFER_DESC*, int> GetDesc;
        [NativeTypeName("ID3D12ShaderReflectionVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D12ShaderReflectionVariable*> GetVariableByIndex;
        [NativeTypeName("ID3D12ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D12ShaderReflectionVariable*> GetVariableByName;
    }
}