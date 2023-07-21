// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12FunctionParameterReflection.xml' path='doc/member[@name="ID3D12FunctionParameterReflection"]/*' />
[Guid("EC25F42D-7006-4F2B-B33E-02CC3375733F")]
public unsafe partial struct ID3D12FunctionParameterReflection : ID3D12FunctionParameterReflection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12FunctionParameterReflection));

    public void** lpVtbl;

    /// <include file='ID3D12FunctionParameterReflection.xml' path='doc/member[@name="ID3D12FunctionParameterReflection.GetDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetDesc(D3D12_PARAMETER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D12FunctionParameterReflection*, D3D12_PARAMETER_DESC*, int>)(lpVtbl[0]))((ID3D12FunctionParameterReflection*)Unsafe.AsPointer(ref this), pDesc);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetDesc(D3D12_PARAMETER_DESC* pDesc);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (D3D12_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_PARAMETER_DESC*, int> GetDesc;
    }
}
