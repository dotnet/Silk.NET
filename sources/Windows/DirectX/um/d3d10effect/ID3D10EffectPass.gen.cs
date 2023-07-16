// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;
/// <include file='ID3D10EffectPass.xml' path='doc/member[@name="ID3D10EffectPass"]/*'/>
public unsafe partial struct ID3D10EffectPass : ID3D10EffectPass.Interface
{
    public void** lpVtbl;
    /// <include file='ID3D10EffectPass.xml' path='doc/member[@name="ID3D10EffectPass.IsValid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public BOOL IsValid()
    {
        return ((delegate* unmanaged<ID3D10EffectPass*, int> )(lpVtbl[0]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10EffectPass.xml' path='doc/member[@name="ID3D10EffectPass.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT GetDesc(D3D10_PASS_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10EffectPass*, D3D10_PASS_DESC*, int> )(lpVtbl[1]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D10EffectPass.xml' path='doc/member[@name="ID3D10EffectPass.GetVertexShaderDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT GetVertexShaderDesc(D3D10_PASS_SHADER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10EffectPass*, D3D10_PASS_SHADER_DESC*, int> )(lpVtbl[2]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D10EffectPass.xml' path='doc/member[@name="ID3D10EffectPass.GetGeometryShaderDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetGeometryShaderDesc(D3D10_PASS_SHADER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10EffectPass*, D3D10_PASS_SHADER_DESC*, int> )(lpVtbl[3]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D10EffectPass.xml' path='doc/member[@name="ID3D10EffectPass.GetPixelShaderDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPixelShaderDesc(D3D10_PASS_SHADER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10EffectPass*, D3D10_PASS_SHADER_DESC*, int> )(lpVtbl[4]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D10EffectPass.xml' path='doc/member[@name="ID3D10EffectPass.GetAnnotationByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public ID3D10EffectVariable* GetAnnotationByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10EffectPass*, uint, ID3D10EffectVariable*> )(lpVtbl[5]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D10EffectPass.xml' path='doc/member[@name="ID3D10EffectPass.GetAnnotationByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public ID3D10EffectVariable* GetAnnotationByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10EffectPass*, sbyte*, ID3D10EffectVariable*> )(lpVtbl[6]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D10EffectPass.xml' path='doc/member[@name="ID3D10EffectPass.Apply"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Apply(uint Flags)
    {
        return ((delegate* unmanaged<ID3D10EffectPass*, uint, int> )(lpVtbl[7]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), Flags);
    }

    /// <include file='ID3D10EffectPass.xml' path='doc/member[@name="ID3D10EffectPass.ComputeStateBlockMask"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ComputeStateBlockMask(D3D10_STATE_BLOCK_MASK* pStateBlockMask)
    {
        return ((delegate* unmanaged<ID3D10EffectPass*, D3D10_STATE_BLOCK_MASK*, int> )(lpVtbl[8]))((ID3D10EffectPass*)Unsafe.AsPointer(ref this), pStateBlockMask);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        BOOL IsValid();
        [VtblIndex(1)]
        HRESULT GetDesc(D3D10_PASS_DESC* pDesc);
        [VtblIndex(2)]
        HRESULT GetVertexShaderDesc(D3D10_PASS_SHADER_DESC* pDesc);
        [VtblIndex(3)]
        HRESULT GetGeometryShaderDesc(D3D10_PASS_SHADER_DESC* pDesc);
        [VtblIndex(4)]
        HRESULT GetPixelShaderDesc(D3D10_PASS_SHADER_DESC* pDesc);
        [VtblIndex(5)]
        ID3D10EffectVariable* GetAnnotationByIndex(uint Index);
        [VtblIndex(6)]
        ID3D10EffectVariable* GetAnnotationByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(7)]
        HRESULT Apply(uint Flags);
        [VtblIndex(8)]
        HRESULT ComputeStateBlockMask(D3D10_STATE_BLOCK_MASK* pStateBlockMask);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsValid;
        [NativeTypeName("HRESULT (D3D10_PASS_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_PASS_DESC*, int> GetDesc;
        [NativeTypeName("HRESULT (D3D10_PASS_SHADER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_PASS_SHADER_DESC*, int> GetVertexShaderDesc;
        [NativeTypeName("HRESULT (D3D10_PASS_SHADER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_PASS_SHADER_DESC*, int> GetGeometryShaderDesc;
        [NativeTypeName("HRESULT (D3D10_PASS_SHADER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_PASS_SHADER_DESC*, int> GetPixelShaderDesc;
        [NativeTypeName("ID3D10EffectVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10EffectVariable*> GetAnnotationByIndex;
        [NativeTypeName("ID3D10EffectVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectVariable*> GetAnnotationByName;
        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Apply;
        [NativeTypeName("HRESULT (D3D10_STATE_BLOCK_MASK *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_STATE_BLOCK_MASK*, int> ComputeStateBlockMask;
    }
}