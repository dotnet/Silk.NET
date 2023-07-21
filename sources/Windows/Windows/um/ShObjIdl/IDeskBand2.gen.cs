// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IDeskBand2.xml' path='doc/member[@name="IDeskBand2"]/*' />
[Guid("79D16DE4-ABEE-4021-8D9D-9169B261D657")]
[NativeTypeName("struct IDeskBand2 : IDeskBand")]
[NativeInheritance("IDeskBand")]
public unsafe partial struct IDeskBand2 : IDeskBand2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeskBand2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeskBand2*, Guid*, void**, int>)(lpVtbl[0]))((IDeskBand2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeskBand2*, uint>)(lpVtbl[1]))((IDeskBand2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeskBand2*, uint>)(lpVtbl[2]))((IDeskBand2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IOleWindow.GetWindow" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IDeskBand2*, HWND*, int>)(lpVtbl[3]))((IDeskBand2*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <inheritdoc cref="IOleWindow.ContextSensitiveHelp" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IDeskBand2*, BOOL, int>)(lpVtbl[4]))((IDeskBand2*)Unsafe.AsPointer(ref this), fEnterMode);
    }

    /// <inheritdoc cref="IDockingWindow.ShowDW" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ShowDW(BOOL fShow)
    {
        return ((delegate* unmanaged<IDeskBand2*, BOOL, int>)(lpVtbl[5]))((IDeskBand2*)Unsafe.AsPointer(ref this), fShow);
    }

    /// <inheritdoc cref="IDockingWindow.CloseDW" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CloseDW([NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<IDeskBand2*, uint, int>)(lpVtbl[6]))((IDeskBand2*)Unsafe.AsPointer(ref this), dwReserved);
    }

    /// <inheritdoc cref="IDockingWindow.ResizeBorderDW" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResizeBorderDW([NativeTypeName("LPCRECT")] RECT* prcBorder, IUnknown* punkToolbarSite, BOOL fReserved)
    {
        return ((delegate* unmanaged<IDeskBand2*, RECT*, IUnknown*, BOOL, int>)(lpVtbl[7]))((IDeskBand2*)Unsafe.AsPointer(ref this), prcBorder, punkToolbarSite, fReserved);
    }

    /// <inheritdoc cref="IDeskBand.GetBandInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBandInfo([NativeTypeName("DWORD")] uint dwBandID, [NativeTypeName("DWORD")] uint dwViewMode, DESKBANDINFO* pdbi)
    {
        return ((delegate* unmanaged<IDeskBand2*, uint, uint, DESKBANDINFO*, int>)(lpVtbl[8]))((IDeskBand2*)Unsafe.AsPointer(ref this), dwBandID, dwViewMode, pdbi);
    }

    /// <include file='IDeskBand2.xml' path='doc/member[@name="IDeskBand2.CanRenderComposited"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CanRenderComposited(BOOL* pfCanRenderComposited)
    {
        return ((delegate* unmanaged<IDeskBand2*, BOOL*, int>)(lpVtbl[9]))((IDeskBand2*)Unsafe.AsPointer(ref this), pfCanRenderComposited);
    }

    /// <include file='IDeskBand2.xml' path='doc/member[@name="IDeskBand2.SetCompositionState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetCompositionState(BOOL fCompositionEnabled)
    {
        return ((delegate* unmanaged<IDeskBand2*, BOOL, int>)(lpVtbl[10]))((IDeskBand2*)Unsafe.AsPointer(ref this), fCompositionEnabled);
    }

    /// <include file='IDeskBand2.xml' path='doc/member[@name="IDeskBand2.GetCompositionState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetCompositionState(BOOL* pfCompositionEnabled)
    {
        return ((delegate* unmanaged<IDeskBand2*, BOOL*, int>)(lpVtbl[11]))((IDeskBand2*)Unsafe.AsPointer(ref this), pfCompositionEnabled);
    }

    public interface Interface : IDeskBand.Interface
    {
        [VtblIndex(9)]
        HRESULT CanRenderComposited(BOOL* pfCanRenderComposited);

        [VtblIndex(10)]
        HRESULT SetCompositionState(BOOL fCompositionEnabled);

        [VtblIndex(11)]
        HRESULT GetCompositionState(BOOL* pfCompositionEnabled);
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

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> CanRenderComposited;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetCompositionState;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetCompositionState;
    }
}
