// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B196B289-BAB4-101A-B69C-00AA00341D07")]
[NativeTypeName("struct IOleControlSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleControlSite : IOleControlSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleControlSite));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleControlSite, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleControlSite, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleControlSite, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnControlInfoChanged()
    {
        return ((delegate* unmanaged<IOleControlSite, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LockInPlaceActive(BOOL fLock)
    {
        return ((delegate* unmanaged<IOleControlSite, BOOL, int>)((*lpVtbl)[4]))(this, fLock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetExtendedControl(IDispatch* ppDisp)
    {
        return ((delegate* unmanaged<IOleControlSite, IDispatch*, int>)((*lpVtbl)[5]))(
            this,
            ppDisp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TransformCoords(
        POINTL* pPtlHimetric,
        POINTF* pPtfContainer,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<IOleControlSite, POINTL*, POINTF*, uint, int>)((*lpVtbl)[6]))(
            this,
            pPtlHimetric,
            pPtfContainer,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TranslateAccelerator(MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers)
    {
        return ((delegate* unmanaged<IOleControlSite, MSG*, uint, int>)((*lpVtbl)[7]))(
            this,
            pMsg,
            grfModifiers
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnFocus(BOOL fGotFocus)
    {
        return ((delegate* unmanaged<IOleControlSite, BOOL, int>)((*lpVtbl)[8]))(this, fGotFocus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ShowPropertyFrame()
    {
        return ((delegate* unmanaged<IOleControlSite, int>)((*lpVtbl)[9]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnControlInfoChanged();

        [VtblIndex(4)]
        HRESULT LockInPlaceActive(BOOL fLock);

        [VtblIndex(5)]
        HRESULT GetExtendedControl(IDispatch* ppDisp);

        [VtblIndex(6)]
        HRESULT TransformCoords(
            POINTL* pPtlHimetric,
            POINTF* pPtfContainer,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(7)]
        HRESULT TranslateAccelerator(MSG* pMsg, [NativeTypeName("DWORD")] uint grfModifiers);

        [VtblIndex(8)]
        HRESULT OnFocus(BOOL fGotFocus);

        [VtblIndex(9)]
        HRESULT ShowPropertyFrame();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnControlInfoChanged;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> LockInPlaceActive;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> GetExtendedControl;

        [NativeTypeName("HRESULT (POINTL *, POINTF *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINTL*, POINTF*, uint, int> TransformCoords;

        [NativeTypeName("HRESULT (MSG *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, uint, int> TranslateAccelerator;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> OnFocus;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ShowPropertyFrame;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleControlSite"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleControlSite(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleControlSite"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleControlSite(Silk.NET.Windows.IUnknown value)
    {
        return new IOleControlSite(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleControlSite"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleControlSite"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleControlSite value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
