// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection"]/*'/>
[Guid("207BCECB-D683-4A06-A8A3-9B149B9F73A4")]
public unsafe partial struct ID3D11FunctionReflection : ID3D11FunctionReflection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11FunctionReflection));

    public void** lpVtbl;
    /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetDesc(D3D11_FUNCTION_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D11FunctionReflection*, D3D11_FUNCTION_DESC*, int> )(lpVtbl[0]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetConstantBufferByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint BufferIndex)
    {
        return ((delegate* unmanaged<ID3D11FunctionReflection*, uint, ID3D11ShaderReflectionConstantBuffer*> )(lpVtbl[1]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), BufferIndex);
    }

    /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetConstantBufferByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D11FunctionReflection*, sbyte*, ID3D11ShaderReflectionConstantBuffer*> )(lpVtbl[2]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetResourceBindingDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetResourceBindingDesc(uint ResourceIndex, D3D11_SHADER_INPUT_BIND_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D11FunctionReflection*, uint, D3D11_SHADER_INPUT_BIND_DESC*, int> )(lpVtbl[3]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
    }

    /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetVariableByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D11FunctionReflection*, sbyte*, ID3D11ShaderReflectionVariable*> )(lpVtbl[4]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetResourceBindingDescByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D11_SHADER_INPUT_BIND_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D11FunctionReflection*, sbyte*, D3D11_SHADER_INPUT_BIND_DESC*, int> )(lpVtbl[5]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), Name, pDesc);
    }

    /// <include file='ID3D11FunctionReflection.xml' path='doc/member[@name="ID3D11FunctionReflection.GetFunctionParameter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public ID3D11FunctionParameterReflection* GetFunctionParameter(int ParameterIndex)
    {
        return ((delegate* unmanaged<ID3D11FunctionReflection*, int, ID3D11FunctionParameterReflection*> )(lpVtbl[6]))((ID3D11FunctionReflection*)Unsafe.AsPointer(ref this), ParameterIndex);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetDesc(D3D11_FUNCTION_DESC* pDesc);
        [VtblIndex(1)]
        ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint BufferIndex);
        [VtblIndex(2)]
        ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(3)]
        HRESULT GetResourceBindingDesc(uint ResourceIndex, D3D11_SHADER_INPUT_BIND_DESC* pDesc);
        [VtblIndex(4)]
        ID3D11ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(5)]
        HRESULT GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D11_SHADER_INPUT_BIND_DESC* pDesc);
        [VtblIndex(6)]
        ID3D11FunctionParameterReflection* GetFunctionParameter(int ParameterIndex);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (D3D11_FUNCTION_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_FUNCTION_DESC*, int> GetDesc;
        [NativeTypeName("ID3D11ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D11ShaderReflectionConstantBuffer*> GetConstantBufferByIndex;
        [NativeTypeName("ID3D11ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D11ShaderReflectionConstantBuffer*> GetConstantBufferByName;
        [NativeTypeName("HRESULT (UINT, D3D11_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D11_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDesc;
        [NativeTypeName("ID3D11ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D11ShaderReflectionVariable*> GetVariableByName;
        [NativeTypeName("HRESULT (LPCSTR, D3D11_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, D3D11_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDescByName;
        [NativeTypeName("ID3D11FunctionParameterReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ID3D11FunctionParameterReflection*> GetFunctionParameter;
    }
}