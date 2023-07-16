// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDirectManipulationDeferContactService.xml' path='doc/member[@name="IDirectManipulationDeferContactService"]/*'/>
[Guid("652D5C71-FE60-4A98-BE70-E5F21291E7F1")]
[NativeTypeName("struct IDirectManipulationDeferContactService : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IDirectManipulationDeferContactService : IDirectManipulationDeferContactService.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationDeferContactService));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService*, Guid*, void**, int> )(lpVtbl[0]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService*, uint> )(lpVtbl[1]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService*, uint> )(lpVtbl[2]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectManipulationDeferContactService.xml' path='doc/member[@name="IDirectManipulationDeferContactService.DeferContact"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DeferContact([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint timeout)
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService*, uint, uint, int> )(lpVtbl[3]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this), pointerId, timeout);
    }

    /// <include file='IDirectManipulationDeferContactService.xml' path='doc/member[@name="IDirectManipulationDeferContactService.CancelContact"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CancelContact([NativeTypeName("UINT32")] uint pointerId)
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService*, uint, int> )(lpVtbl[4]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this), pointerId);
    }

    /// <include file='IDirectManipulationDeferContactService.xml' path='doc/member[@name="IDirectManipulationDeferContactService.CancelDeferral"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CancelDeferral([NativeTypeName("UINT32")] uint pointerId)
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService*, uint, int> )(lpVtbl[5]))((IDirectManipulationDeferContactService*)Unsafe.AsPointer(ref this), pointerId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DeferContact([NativeTypeName("UINT32")] uint pointerId, [NativeTypeName("UINT32")] uint timeout);
        [VtblIndex(4)]
        HRESULT CancelContact([NativeTypeName("UINT32")] uint pointerId);
        [VtblIndex(5)]
        HRESULT CancelDeferral([NativeTypeName("UINT32")] uint pointerId);
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
        [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> DeferContact;
        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> CancelContact;
        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> CancelDeferral;
    }
}