// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IContactManagerInterop.xml' path='doc/member[@name="IContactManagerInterop"]/*'/>
[Guid("99EACBA7-E073-43B6-A896-55AFE48A0833")]
[NativeTypeName("struct IContactManagerInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IContactManagerInterop : IContactManagerInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactManagerInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactManagerInterop*, Guid*, void**, int> )(lpVtbl[0]))((IContactManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IContactManagerInterop*, uint> )(lpVtbl[1]))((IContactManagerInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactManagerInterop*, uint> )(lpVtbl[2]))((IContactManagerInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IContactManagerInterop.xml' path='doc/member[@name="IContactManagerInterop.ShowContactCardForWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShowContactCardForWindow(HWND appWindow, IUnknown* contact, [NativeTypeName("const RECT *")] RECT* selection, FLYOUT_PLACEMENT preferredPlacement)
    {
        return ((delegate* unmanaged<IContactManagerInterop*, HWND, IUnknown*, RECT*, FLYOUT_PLACEMENT, int> )(lpVtbl[3]))((IContactManagerInterop*)Unsafe.AsPointer(ref this), appWindow, contact, selection, preferredPlacement);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShowContactCardForWindow(HWND appWindow, IUnknown* contact, [NativeTypeName("const RECT *")] RECT* selection, FLYOUT_PLACEMENT preferredPlacement);
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
        [NativeTypeName("HRESULT (HWND, IUnknown *, const RECT *, FLYOUT_PLACEMENT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IUnknown*, RECT*, FLYOUT_PLACEMENT, int> ShowContactCardForWindow;
    }
}