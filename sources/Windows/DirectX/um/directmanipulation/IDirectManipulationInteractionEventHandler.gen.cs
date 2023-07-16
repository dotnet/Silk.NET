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
/// <include file='IDirectManipulationInteractionEventHandler.xml' path='doc/member[@name="IDirectManipulationInteractionEventHandler"]/*'/>
[Guid("E43F45B8-42B4-403E-B1F2-273B8F510830")]
[NativeTypeName("struct IDirectManipulationInteractionEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDirectManipulationInteractionEventHandler : IDirectManipulationInteractionEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationInteractionEventHandler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectManipulationInteractionEventHandler*, Guid*, void**, int> )(lpVtbl[0]))((IDirectManipulationInteractionEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationInteractionEventHandler*, uint> )(lpVtbl[1]))((IDirectManipulationInteractionEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationInteractionEventHandler*, uint> )(lpVtbl[2]))((IDirectManipulationInteractionEventHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectManipulationInteractionEventHandler.xml' path='doc/member[@name="IDirectManipulationInteractionEventHandler.OnInteraction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnInteraction(IDirectManipulationViewport2* viewport, DIRECTMANIPULATION_INTERACTION_TYPE interaction)
    {
        return ((delegate* unmanaged<IDirectManipulationInteractionEventHandler*, IDirectManipulationViewport2*, DIRECTMANIPULATION_INTERACTION_TYPE, int> )(lpVtbl[3]))((IDirectManipulationInteractionEventHandler*)Unsafe.AsPointer(ref this), viewport, interaction);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnInteraction(IDirectManipulationViewport2* viewport, DIRECTMANIPULATION_INTERACTION_TYPE interaction);
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
        [NativeTypeName("HRESULT (IDirectManipulationViewport2 *, DIRECTMANIPULATION_INTERACTION_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationViewport2*, DIRECTMANIPULATION_INTERACTION_TYPE, int> OnInteraction;
    }
}