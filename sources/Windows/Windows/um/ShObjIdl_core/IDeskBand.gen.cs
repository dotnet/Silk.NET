// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDeskBand.xml' path='doc/member[@name="IDeskBand"]/*'/>
[Guid("EB0FE172-1A3A-11D0-89B3-00A0C90A90AC")]
[NativeTypeName("struct IDeskBand : IDockingWindow")]
[NativeInheritance("IDockingWindow")]
public unsafe partial struct IDeskBand : IDeskBand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeskBand));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeskBand*, Guid*, void**, int> )(lpVtbl[0]))((IDeskBand*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeskBand*, uint> )(lpVtbl[1]))((IDeskBand*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeskBand*, uint> )(lpVtbl[2]))((IDeskBand*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IOleWindow.GetWindow"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IDeskBand*, HWND*, int> )(lpVtbl[3]))((IDeskBand*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <inheritdoc cref = "IOleWindow.ContextSensitiveHelp"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IDeskBand*, BOOL, int> )(lpVtbl[4]))((IDeskBand*)Unsafe.AsPointer(ref this), fEnterMode);
    }

    /// <inheritdoc cref = "IDockingWindow.ShowDW"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ShowDW(BOOL fShow)
    {
        return ((delegate* unmanaged<IDeskBand*, BOOL, int> )(lpVtbl[5]))((IDeskBand*)Unsafe.AsPointer(ref this), fShow);
    }

    /// <inheritdoc cref = "IDockingWindow.CloseDW"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CloseDW([NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<IDeskBand*, uint, int> )(lpVtbl[6]))((IDeskBand*)Unsafe.AsPointer(ref this), dwReserved);
    }

    /// <inheritdoc cref = "IDockingWindow.ResizeBorderDW"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResizeBorderDW([NativeTypeName("LPCRECT")] RECT* prcBorder, IUnknown* punkToolbarSite, BOOL fReserved)
    {
        return ((delegate* unmanaged<IDeskBand*, RECT*, IUnknown*, BOOL, int> )(lpVtbl[7]))((IDeskBand*)Unsafe.AsPointer(ref this), prcBorder, punkToolbarSite, fReserved);
    }

    /// <include file='IDeskBand.xml' path='doc/member[@name="IDeskBand.GetBandInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBandInfo([NativeTypeName("DWORD")] uint dwBandID, [NativeTypeName("DWORD")] uint dwViewMode, DESKBANDINFO* pdbi)
    {
        return ((delegate* unmanaged<IDeskBand*, uint, uint, DESKBANDINFO*, int> )(lpVtbl[8]))((IDeskBand*)Unsafe.AsPointer(ref this), dwBandID, dwViewMode, pdbi);
    }

    public interface Interface : IDockingWindow.Interface
    {
        [VtblIndex(8)]
        HRESULT GetBandInfo([NativeTypeName("DWORD")] uint dwBandID, [NativeTypeName("DWORD")] uint dwViewMode, DESKBANDINFO* pdbi);
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
        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWindow;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ContextSensitiveHelp;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ShowDW;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> CloseDW;
        [NativeTypeName("HRESULT (LPCRECT, IUnknown *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, IUnknown*, BOOL, int> ResizeBorderDW;
        [NativeTypeName("HRESULT (DWORD, DWORD, DESKBANDINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, DESKBANDINFO*, int> GetBandInfo;
    }
}