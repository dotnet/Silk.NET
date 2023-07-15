// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IOleControl.xml' path='doc/member[@name="IOleControl"]/*'/>
[Guid("B196B288-BAB4-101A-B69C-00AA00341D07")]
[NativeTypeName("struct IOleControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleControl : IOleControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleControl*, Guid*, void**, int> )(lpVtbl[0]))((IOleControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleControl*, uint> )(lpVtbl[1]))((IOleControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleControl*, uint> )(lpVtbl[2]))((IOleControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleControl.xml' path='doc/member[@name="IOleControl.GetControlInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetControlInfo(CONTROLINFO* pCI)
    {
        return ((delegate* unmanaged<IOleControl*, CONTROLINFO*, int> )(lpVtbl[3]))((IOleControl*)Unsafe.AsPointer(ref this), pCI);
    }

    /// <include file='IOleControl.xml' path='doc/member[@name="IOleControl.OnMnemonic"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnMnemonic(MSG* pMsg)
    {
        return ((delegate* unmanaged<IOleControl*, MSG*, int> )(lpVtbl[4]))((IOleControl*)Unsafe.AsPointer(ref this), pMsg);
    }

    /// <include file='IOleControl.xml' path='doc/member[@name="IOleControl.OnAmbientPropertyChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnAmbientPropertyChange([NativeTypeName("DISPID")] int dispID)
    {
        return ((delegate* unmanaged<IOleControl*, int, int> )(lpVtbl[5]))((IOleControl*)Unsafe.AsPointer(ref this), dispID);
    }

    /// <include file='IOleControl.xml' path='doc/member[@name="IOleControl.FreezeEvents"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FreezeEvents(BOOL bFreeze)
    {
        return ((delegate* unmanaged<IOleControl*, BOOL, int> )(lpVtbl[6]))((IOleControl*)Unsafe.AsPointer(ref this), bFreeze);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetControlInfo(CONTROLINFO* pCI);
        [VtblIndex(4)]
        HRESULT OnMnemonic(MSG* pMsg);
        [VtblIndex(5)]
        HRESULT OnAmbientPropertyChange([NativeTypeName("DISPID")] int dispID);
        [VtblIndex(6)]
        HRESULT FreezeEvents(BOOL bFreeze);
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
        [NativeTypeName("HRESULT (CONTROLINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CONTROLINFO*, int> GetControlInfo;
        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> OnMnemonic;
        [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> OnAmbientPropertyChange;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> FreezeEvents;
    }
}