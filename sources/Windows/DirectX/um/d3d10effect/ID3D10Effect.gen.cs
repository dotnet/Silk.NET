// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect"]/*'/>
[Guid("51B0CA8B-EC0B-4519-870D-8EE1CB5017C7")]
[NativeTypeName("struct ID3D10Effect : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D10Effect : ID3D10Effect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10Effect));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10Effect*, Guid*, void**, int> )(lpVtbl[0]))((ID3D10Effect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D10Effect*, uint> )(lpVtbl[1]))((ID3D10Effect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10Effect*, uint> )(lpVtbl[2]))((ID3D10Effect*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.IsValid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL IsValid()
    {
        return ((delegate* unmanaged<ID3D10Effect*, int> )(lpVtbl[3]))((ID3D10Effect*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.IsPool"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public BOOL IsPool()
    {
        return ((delegate* unmanaged<ID3D10Effect*, int> )(lpVtbl[4]))((ID3D10Effect*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.GetDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDevice(ID3D10Device** ppDevice)
    {
        return ((delegate* unmanaged<ID3D10Effect*, ID3D10Device**, int> )(lpVtbl[5]))((ID3D10Effect*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDesc(D3D10_EFFECT_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D10Effect*, D3D10_EFFECT_DESC*, int> )(lpVtbl[6]))((ID3D10Effect*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.GetConstantBufferByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public ID3D10EffectConstantBuffer* GetConstantBufferByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10Effect*, uint, ID3D10EffectConstantBuffer*> )(lpVtbl[7]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.GetConstantBufferByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public ID3D10EffectConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10Effect*, sbyte*, ID3D10EffectConstantBuffer*> )(lpVtbl[8]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.GetVariableByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public ID3D10EffectVariable* GetVariableByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10Effect*, uint, ID3D10EffectVariable*> )(lpVtbl[9]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.GetVariableByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public ID3D10EffectVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10Effect*, sbyte*, ID3D10EffectVariable*> )(lpVtbl[10]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.GetVariableBySemantic"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public ID3D10EffectVariable* GetVariableBySemantic([NativeTypeName("LPCSTR")] sbyte* Semantic)
    {
        return ((delegate* unmanaged<ID3D10Effect*, sbyte*, ID3D10EffectVariable*> )(lpVtbl[11]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Semantic);
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.GetTechniqueByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public ID3D10EffectTechnique* GetTechniqueByIndex(uint Index)
    {
        return ((delegate* unmanaged<ID3D10Effect*, uint, ID3D10EffectTechnique*> )(lpVtbl[12]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.GetTechniqueByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public ID3D10EffectTechnique* GetTechniqueByName([NativeTypeName("LPCSTR")] sbyte* Name)
    {
        return ((delegate* unmanaged<ID3D10Effect*, sbyte*, ID3D10EffectTechnique*> )(lpVtbl[13]))((ID3D10Effect*)Unsafe.AsPointer(ref this), Name);
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.Optimize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Optimize()
    {
        return ((delegate* unmanaged<ID3D10Effect*, int> )(lpVtbl[14]))((ID3D10Effect*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10Effect.xml' path='doc/member[@name="ID3D10Effect.IsOptimized"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public BOOL IsOptimized()
    {
        return ((delegate* unmanaged<ID3D10Effect*, int> )(lpVtbl[15]))((ID3D10Effect*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        BOOL IsValid();
        [VtblIndex(4)]
        BOOL IsPool();
        [VtblIndex(5)]
        HRESULT GetDevice(ID3D10Device** ppDevice);
        [VtblIndex(6)]
        HRESULT GetDesc(D3D10_EFFECT_DESC* pDesc);
        [VtblIndex(7)]
        ID3D10EffectConstantBuffer* GetConstantBufferByIndex(uint Index);
        [VtblIndex(8)]
        ID3D10EffectConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(9)]
        ID3D10EffectVariable* GetVariableByIndex(uint Index);
        [VtblIndex(10)]
        ID3D10EffectVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(11)]
        ID3D10EffectVariable* GetVariableBySemantic([NativeTypeName("LPCSTR")] sbyte* Semantic);
        [VtblIndex(12)]
        ID3D10EffectTechnique* GetTechniqueByIndex(uint Index);
        [VtblIndex(13)]
        ID3D10EffectTechnique* GetTechniqueByName([NativeTypeName("LPCSTR")] sbyte* Name);
        [VtblIndex(14)]
        HRESULT Optimize();
        [VtblIndex(15)]
        BOOL IsOptimized();
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
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsValid;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsPool;
        [NativeTypeName("HRESULT (ID3D10Device **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D10Device**, int> GetDevice;
        [NativeTypeName("HRESULT (D3D10_EFFECT_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_EFFECT_DESC*, int> GetDesc;
        [NativeTypeName("ID3D10EffectConstantBuffer *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10EffectConstantBuffer*> GetConstantBufferByIndex;
        [NativeTypeName("ID3D10EffectConstantBuffer *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectConstantBuffer*> GetConstantBufferByName;
        [NativeTypeName("ID3D10EffectVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10EffectVariable*> GetVariableByIndex;
        [NativeTypeName("ID3D10EffectVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectVariable*> GetVariableByName;
        [NativeTypeName("ID3D10EffectVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectVariable*> GetVariableBySemantic;
        [NativeTypeName("ID3D10EffectTechnique *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ID3D10EffectTechnique*> GetTechniqueByIndex;
        [NativeTypeName("ID3D10EffectTechnique *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, ID3D10EffectTechnique*> GetTechniqueByName;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Optimize;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsOptimized;
    }
}