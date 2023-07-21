// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D10ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D10ShaderReflectionConstantBuffer"]/*' />
[Guid("66C66A94-DDDD-4B62-A66A-F0DA33C2B4D0")]
public unsafe partial struct ID3D10ShaderReflectionConstantBuffer : ID3D10ShaderReflectionConstantBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10ShaderReflectionConstantBuffer));

    public void** lpVtbl;

    /// <include file='ID3D10ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D10ShaderReflectionConstantBuffer.GetDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetDesc(D3D10_SHADER_BUFFER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflectionConstantBuffer*, D3D10_SHADER_BUFFER_DESC*, int>)(lpVtbl[0]))((ID3D10ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D10ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D10ShaderReflectionConstantBuffer.GetVariableByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public ID3D10ShaderReflectionVariable* GetVariableByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflectionConstantBuffer*, uint, ID3D10ShaderReflectionVariable*>)(lpVtbl[1]))((ID3D10ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D10ShaderReflectionConstantBuffer.xml' path='doc/member[@name="ID3D10ShaderReflectionConstantBuffer.GetVariableByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D10ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflectionConstantBuffer*, sbyte*, ID3D10ShaderReflectionVariable*>)(lpVtbl[2]))((ID3D10ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Name);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetDesc(D3D10_SHADER_BUFFER_DESC* pDesc);

        [VtblIndex(1)]
        ID3D10ShaderReflectionVariable* GetVariableByIndex(uint Index);

        [VtblIndex(2)]
        ID3D10ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (D3D10_SHADER_BUFFER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_SHADER_BUFFER_DESC*, int> GetDesc;

        [NativeTypeName("ID3D10ShaderReflectionVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10ShaderReflectionVariable*> GetVariableByIndex;

        [NativeTypeName("ID3D10ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10ShaderReflectionVariable*> GetVariableByName;
    }
}
