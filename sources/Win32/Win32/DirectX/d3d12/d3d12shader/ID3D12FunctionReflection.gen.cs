// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("1108795C-2772-4BA9-B2A8-D464DC7E2799")]
public unsafe partial struct ID3D12FunctionReflection
    : ID3D12FunctionReflection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12FunctionReflection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetDesc(D3D12_FUNCTION_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<ID3D12FunctionReflection*, D3D12_FUNCTION_DESC*, int>)(
                (*lpVtbl)[0]
            )
        )((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint BufferIndex)
    {
        return (
            (delegate* unmanaged<
                ID3D12FunctionReflection*,
                uint,
                ID3D12ShaderReflectionConstantBuffer*>)((*lpVtbl)[1])
        )((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), BufferIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(
        [NativeTypeName("LPCSTR")] sbyte* Name
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12FunctionReflection*,
                sbyte*,
                ID3D12ShaderReflectionConstantBuffer*>)((*lpVtbl)[2])
        )((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetResourceBindingDesc(uint ResourceIndex, D3D12_SHADER_INPUT_BIND_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<
                ID3D12FunctionReflection*,
                uint,
                D3D12_SHADER_INPUT_BIND_DESC*,
                int>)((*lpVtbl)[3])
        )((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return (
            (delegate* unmanaged<
                ID3D12FunctionReflection*,
                sbyte*,
                ID3D12ShaderReflectionVariable*>)((*lpVtbl)[4])
        )((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetResourceBindingDescByName(
        [NativeTypeName("LPCSTR")] sbyte* Name,
        D3D12_SHADER_INPUT_BIND_DESC* pDesc
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12FunctionReflection*,
                sbyte*,
                D3D12_SHADER_INPUT_BIND_DESC*,
                int>)((*lpVtbl)[5])
        )((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public ID3D12FunctionParameterReflection* GetFunctionParameter(int ParameterIndex)
    {
        return (
            (delegate* unmanaged<
                ID3D12FunctionReflection*,
                int,
                ID3D12FunctionParameterReflection*>)((*lpVtbl)[6])
        )((ID3D12FunctionReflection*)Unsafe.AsPointer(ref this), ParameterIndex);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetDesc(D3D12_FUNCTION_DESC* pDesc);

        [VtblIndex(1)]
        ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint BufferIndex);

        [VtblIndex(2)]
        ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(
            [NativeTypeName("LPCSTR")] sbyte* Name
        );

        [VtblIndex(3)]
        HRESULT GetResourceBindingDesc(uint ResourceIndex, D3D12_SHADER_INPUT_BIND_DESC* pDesc);

        [VtblIndex(4)]
        ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name);

        [VtblIndex(5)]
        HRESULT GetResourceBindingDescByName(
            [NativeTypeName("LPCSTR")] sbyte* Name,
            D3D12_SHADER_INPUT_BIND_DESC* pDesc
        );

        [VtblIndex(6)]
        ID3D12FunctionParameterReflection* GetFunctionParameter(int ParameterIndex);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName(
            "HRESULT (D3D12_FUNCTION_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3D12_FUNCTION_DESC*, int> GetDesc;

        [NativeTypeName(
            "ID3D12ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ID3D12ShaderReflectionConstantBuffer*> GetConstantBufferByIndex;

        [NativeTypeName(
            "ID3D12ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            sbyte*,
            ID3D12ShaderReflectionConstantBuffer*> GetConstantBufferByName;

        [NativeTypeName(
            "HRESULT (UINT, D3D12_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_SHADER_INPUT_BIND_DESC*,
            int> GetResourceBindingDesc;

        [NativeTypeName(
            "ID3D12ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            sbyte*,
            ID3D12ShaderReflectionVariable*> GetVariableByName;

        [NativeTypeName(
            "HRESULT (LPCSTR, D3D12_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            sbyte*,
            D3D12_SHADER_INPUT_BIND_DESC*,
            int> GetResourceBindingDescByName;

        [NativeTypeName(
            "ID3D12FunctionParameterReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            ID3D12FunctionParameterReflection*> GetFunctionParameter;
    }
}
