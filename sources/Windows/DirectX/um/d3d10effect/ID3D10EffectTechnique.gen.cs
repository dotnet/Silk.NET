// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System.Runtime.CompilerServices;

namespace Silk.NET.DirectX;

/// <include file='ID3D10EffectTechnique.xml' path='doc/member[@name="ID3D10EffectTechnique"]/*' />
public unsafe partial struct ID3D10EffectTechnique : ID3D10EffectTechnique.Interface
{
    public void** lpVtbl;

    /// <include file='ID3D10EffectTechnique.xml' path='doc/member[@name="ID3D10EffectTechnique.IsValid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public BOOL IsValid()
    {
        return ((delegate* unmanaged<ID3D10EffectTechnique*, int>)(lpVtbl[0]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10EffectTechnique.xml' path='doc/member[@name="ID3D10EffectTechnique.GetDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT GetDesc(D3D10_TECHNIQUE_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10EffectTechnique*, D3D10_TECHNIQUE_DESC*, int>)(lpVtbl[1]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D10EffectTechnique.xml' path='doc/member[@name="ID3D10EffectTechnique.GetAnnotationByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public ID3D10EffectVariable* GetAnnotationByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10EffectTechnique*, uint, ID3D10EffectVariable*>)(lpVtbl[2]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D10EffectTechnique.xml' path='doc/member[@name="ID3D10EffectTechnique.GetAnnotationByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public ID3D10EffectVariable* GetAnnotationByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10EffectTechnique*, sbyte*, ID3D10EffectVariable*>)(lpVtbl[3]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D10EffectTechnique.xml' path='doc/member[@name="ID3D10EffectTechnique.GetPassByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D10EffectPass* GetPassByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10EffectTechnique*, uint, ID3D10EffectPass*>)(lpVtbl[4]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D10EffectTechnique.xml' path='doc/member[@name="ID3D10EffectTechnique.GetPassByName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public ID3D10EffectPass* GetPassByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10EffectTechnique*, sbyte*, ID3D10EffectPass*>)(lpVtbl[5]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D10EffectTechnique.xml' path='doc/member[@name="ID3D10EffectTechnique.ComputeStateBlockMask"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ComputeStateBlockMask(D3D10_STATE_BLOCK_MASK* pStateBlockMask)
    {
        return ((delegate* unmanaged<ID3D10EffectTechnique*, D3D10_STATE_BLOCK_MASK*, int>)(lpVtbl[6]))((ID3D10EffectTechnique*)Unsafe.AsPointer(ref this), pStateBlockMask);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        BOOL IsValid();

        [VtblIndex(1)]
        HRESULT GetDesc(D3D10_TECHNIQUE_DESC* pDesc);

        [VtblIndex(2)]
        ID3D10EffectVariable* GetAnnotationByIndex(uint Index);

        [VtblIndex(3)]
        ID3D10EffectVariable* GetAnnotationByName([NativeTypeName("LPCSTR")] sbyte* Name);

        [VtblIndex(4)]
        ID3D10EffectPass* GetPassByIndex(uint Index);

        [VtblIndex(5)]
        ID3D10EffectPass* GetPassByName([NativeTypeName("LPCSTR")] sbyte* Name);

        [VtblIndex(6)]
        HRESULT ComputeStateBlockMask(D3D10_STATE_BLOCK_MASK* pStateBlockMask);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsValid;

        [NativeTypeName("HRESULT (D3D10_TECHNIQUE_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_TECHNIQUE_DESC*, int> GetDesc;

        [NativeTypeName("ID3D10EffectVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10EffectVariable*> GetAnnotationByIndex;

        [NativeTypeName("ID3D10EffectVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectVariable*> GetAnnotationByName;

        [NativeTypeName("ID3D10EffectPass *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10EffectPass*> GetPassByIndex;

        [NativeTypeName("ID3D10EffectPass *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectPass*> GetPassByName;

        [NativeTypeName("HRESULT (D3D10_STATE_BLOCK_MASK *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_STATE_BLOCK_MASK*, int> ComputeStateBlockMask;
    }
}
