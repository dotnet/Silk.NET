// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D10ShaderReflection.xml' path='doc/member[@name="ID3D10ShaderReflection"]/*'/>
[Guid("D40E20B6-F8F7-42AD-AB20-4BAF8F15DFAA")]
[NativeTypeName("struct ID3D10ShaderReflection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D10ShaderReflection : ID3D10ShaderReflection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10ShaderReflection));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection*, Guid*, void**, int> )(lpVtbl[0]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection*, uint> )(lpVtbl[1]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection*, uint> )(lpVtbl[2]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10ShaderReflection.xml' path='doc/member[@name="ID3D10ShaderReflection.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDesc(D3D10_SHADER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection*, D3D10_SHADER_DESC*, int> )(lpVtbl[3]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D10ShaderReflection.xml' path='doc/member[@name="ID3D10ShaderReflection.GetConstantBufferByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection*, uint, ID3D10ShaderReflectionConstantBuffer*> )(lpVtbl[4]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D10ShaderReflection.xml' path='doc/member[@name="ID3D10ShaderReflection.GetConstantBufferByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection*, sbyte*, ID3D10ShaderReflectionConstantBuffer*> )(lpVtbl[5]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D10ShaderReflection.xml' path='doc/member[@name="ID3D10ShaderReflection.GetResourceBindingDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetResourceBindingDesc(uint ResourceIndex, D3D10_SHADER_INPUT_BIND_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection*, uint, D3D10_SHADER_INPUT_BIND_DESC*, int> )(lpVtbl[6]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
    }

    /// <include file='ID3D10ShaderReflection.xml' path='doc/member[@name="ID3D10ShaderReflection.GetInputParameterDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetInputParameterDesc(uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection*, uint, D3D10_SIGNATURE_PARAMETER_DESC*, int> )(lpVtbl[7]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
    }

    /// <include file='ID3D10ShaderReflection.xml' path='doc/member[@name="ID3D10ShaderReflection.GetOutputParameterDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetOutputParameterDesc(uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10ShaderReflection*, uint, D3D10_SIGNATURE_PARAMETER_DESC*, int> )(lpVtbl[8]))((ID3D10ShaderReflection*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDesc(D3D10_SHADER_DESC* pDesc);
        [VtblIndex(4)]
        ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint Index);
        [VtblIndex(5)]
        ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(6)]
        HRESULT GetResourceBindingDesc(uint ResourceIndex, D3D10_SHADER_INPUT_BIND_DESC* pDesc);
        [VtblIndex(7)]
        HRESULT GetInputParameterDesc(uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc);
        [VtblIndex(8)]
        HRESULT GetOutputParameterDesc(uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT (D3D10_SHADER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_SHADER_DESC*, int> GetDesc;
        [NativeTypeName("ID3D10ShaderReflectionConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10ShaderReflectionConstantBuffer*> GetConstantBufferByIndex;
        [NativeTypeName("ID3D10ShaderReflectionConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10ShaderReflectionConstantBuffer*> GetConstantBufferByName;
        [NativeTypeName("HRESULT (UINT, D3D10_SHADER_INPUT_BIND_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D10_SHADER_INPUT_BIND_DESC*, int> GetResourceBindingDesc;
        [NativeTypeName("HRESULT (UINT, D3D10_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D10_SIGNATURE_PARAMETER_DESC*, int> GetInputParameterDesc;
        [NativeTypeName("HRESULT (UINT, D3D10_SIGNATURE_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D10_SIGNATURE_PARAMETER_DESC*, int> GetOutputParameterDesc;
    }
}