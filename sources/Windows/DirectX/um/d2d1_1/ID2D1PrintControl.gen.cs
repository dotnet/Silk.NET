// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1PrintControl.xml' path='doc/member[@name="ID2D1PrintControl"]/*'/>
[Guid("2C1D867D-C290-41C8-AE7E-34A98702E9A5")]
[NativeTypeName("struct ID2D1PrintControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1PrintControl : ID2D1PrintControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1PrintControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1PrintControl*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1PrintControl*, uint> )(lpVtbl[1]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1PrintControl*, uint> )(lpVtbl[2]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1PrintControl.xml' path='doc/member[@name="ID2D1PrintControl.AddPage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPage(ID2D1CommandList* commandList, D2D_SIZE_F pageSize, IStream* pagePrintTicketStream, [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
    {
        return ((delegate* unmanaged<ID2D1PrintControl*, ID2D1CommandList*, D2D_SIZE_F, IStream*, ulong*, ulong*, int> )(lpVtbl[3]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this), commandList, pageSize, pagePrintTicketStream, tag1, tag2);
    }

    /// <include file='ID2D1PrintControl.xml' path='doc/member[@name="ID2D1PrintControl.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ID2D1PrintControl*, int> )(lpVtbl[4]))((ID2D1PrintControl*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddPage(ID2D1CommandList* commandList, D2D_SIZE_F pageSize, IStream* pagePrintTicketStream, [NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null);
        [VtblIndex(4)]
        HRESULT Close();
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
        [NativeTypeName("HRESULT (ID2D1CommandList *, D2D_SIZE_F, IStream *, D2D1_TAG *, D2D1_TAG *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1CommandList*, D2D_SIZE_F, IStream*, ulong*, ulong*, int> AddPage;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }
}