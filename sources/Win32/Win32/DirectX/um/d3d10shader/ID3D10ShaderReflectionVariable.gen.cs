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

[Guid("1BF63C95-2650-405D-99C1-3636BD1DA0A1")]
public unsafe partial struct ID3D10ShaderReflectionVariable
    : ID3D10ShaderReflectionVariable.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10ShaderReflectionVariable));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetDesc(D3D10_SHADER_VARIABLE_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<
                ID3D10ShaderReflectionVariable*,
                D3D10_SHADER_VARIABLE_DESC*,
                int>)((*lpVtbl)[0])
        )((ID3D10ShaderReflectionVariable*)Unsafe.AsPointer(ref this), pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public new ID3D10ShaderReflectionType* GetType()
    {
        return (
            (delegate* unmanaged<ID3D10ShaderReflectionVariable*, ID3D10ShaderReflectionType*>)(
                (*lpVtbl)[1]
            )
        )((ID3D10ShaderReflectionVariable*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetDesc(D3D10_SHADER_VARIABLE_DESC* pDesc);

        [VtblIndex(1)]
        ID3D10ShaderReflectionType* GetType();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName(
            "HRESULT (D3D10_SHADER_VARIABLE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3D10_SHADER_VARIABLE_DESC*, int> GetDesc;

        [NativeTypeName(
            "ID3D10ShaderReflectionType *() __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public new delegate* unmanaged<TSelf*, ID3D10ShaderReflectionType*> GetType;
    }
}
