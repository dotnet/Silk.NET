// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5752238B-24F0-495A-82F1-2FD593056796")]
[NativeTypeName("struct IFrameworkInputPane : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IFrameworkInputPane : IFrameworkInputPane.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameworkInputPane));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFrameworkInputPane, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFrameworkInputPane, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFrameworkInputPane, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(
        IUnknown pWindow,
        IFrameworkInputPaneHandler pHandler,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return (
            (delegate* unmanaged<
                IFrameworkInputPane,
                IUnknown,
                IFrameworkInputPaneHandler,
                uint*,
                int>)((*lpVtbl)[3])
        )(this, pWindow, pHandler, pdwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AdviseWithHWND(
        HWND hwnd,
        IFrameworkInputPaneHandler pHandler,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return (
            (delegate* unmanaged<
                IFrameworkInputPane,
                HWND,
                IFrameworkInputPaneHandler,
                uint*,
                int>)((*lpVtbl)[4])
        )(this, hwnd, pHandler, pdwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IFrameworkInputPane, uint, int>)((*lpVtbl)[5]))(
            this,
            dwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Location(RECT* prcInputPaneScreenLocation)
    {
        return ((delegate* unmanaged<IFrameworkInputPane, RECT*, int>)((*lpVtbl)[6]))(
            this,
            prcInputPaneScreenLocation
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Advise(
            IUnknown pWindow,
            IFrameworkInputPaneHandler pHandler,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        );

        [VtblIndex(4)]
        HRESULT AdviseWithHWND(
            HWND hwnd,
            IFrameworkInputPaneHandler pHandler,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        );

        [VtblIndex(5)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie);

        [VtblIndex(6)]
        HRESULT Location(RECT* prcInputPaneScreenLocation);
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

        [NativeTypeName(
            "HRESULT (IUnknown *, IFrameworkInputPaneHandler *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUnknown, IFrameworkInputPaneHandler, uint*, int> Advise;

        [NativeTypeName(
            "HRESULT (HWND, IFrameworkInputPaneHandler *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            IFrameworkInputPaneHandler,
            uint*,
            int> AdviseWithHWND;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> Location;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFrameworkInputPane"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFrameworkInputPane(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFrameworkInputPane"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFrameworkInputPane(Silk.NET.Windows.IUnknown value)
    {
        return new IFrameworkInputPane(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFrameworkInputPane"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFrameworkInputPane"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFrameworkInputPane value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
