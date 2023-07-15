// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID3D12Debug1.xml' path='doc/member[@name="ID3D12Debug1"]/*'/>
[Guid("AFFAA4CA-63FE-4D8E-B8AD-159000AF4304")]
[NativeTypeName("struct ID3D12Debug1 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12Debug1 : ID3D12Debug1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12Debug1*, Guid*, void**, int> )(lpVtbl[0]))((ID3D12Debug1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12Debug1*, uint> )(lpVtbl[1]))((ID3D12Debug1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12Debug1*, uint> )(lpVtbl[2]))((ID3D12Debug1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12Debug1.xml' path='doc/member[@name="ID3D12Debug1.EnableDebugLayer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void EnableDebugLayer()
    {
        ((delegate* unmanaged<ID3D12Debug1*, void> )(lpVtbl[3]))((ID3D12Debug1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12Debug1.xml' path='doc/member[@name="ID3D12Debug1.SetEnableGPUBasedValidation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetEnableGPUBasedValidation(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug1*, BOOL, void> )(lpVtbl[4]))((ID3D12Debug1*)Unsafe.AsPointer(ref this), Enable);
    }

    /// <include file='ID3D12Debug1.xml' path='doc/member[@name="ID3D12Debug1.SetEnableSynchronizedCommandQueueValidation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetEnableSynchronizedCommandQueueValidation(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug1*, BOOL, void> )(lpVtbl[5]))((ID3D12Debug1*)Unsafe.AsPointer(ref this), Enable);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void EnableDebugLayer();
        [VtblIndex(4)]
        void SetEnableGPUBasedValidation(BOOL Enable);
        [VtblIndex(5)]
        void SetEnableSynchronizedCommandQueueValidation(BOOL Enable);
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
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> EnableDebugLayer;
        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetEnableGPUBasedValidation;
        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetEnableSynchronizedCommandQueueValidation;
    }
}