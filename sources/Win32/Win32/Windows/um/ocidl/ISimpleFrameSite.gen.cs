// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("742B0E01-14E6-101B-914E-00AA00300CAB")]
[NativeTypeName("struct ISimpleFrameSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISimpleFrameSite : ISimpleFrameSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISimpleFrameSite));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISimpleFrameSite, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISimpleFrameSite, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISimpleFrameSite, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT PreMessageFilter(
        HWND hWnd,
        uint msg,
        WPARAM wp,
        LPARAM lp,
        LRESULT* plResult,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    )
    {
        return (
            (delegate* unmanaged<
                ISimpleFrameSite,
                HWND,
                uint,
                WPARAM,
                LPARAM,
                LRESULT*,
                uint*,
                int>)((*lpVtbl)[3])
        )(this, hWnd, msg, wp, lp, plResult, pdwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PostMessageFilter(
        HWND hWnd,
        uint msg,
        WPARAM wp,
        LPARAM lp,
        LRESULT* plResult,
        [NativeTypeName("DWORD")] uint dwCookie
    )
    {
        return (
            (delegate* unmanaged<
                ISimpleFrameSite,
                HWND,
                uint,
                WPARAM,
                LPARAM,
                LRESULT*,
                uint,
                int>)((*lpVtbl)[4])
        )(this, hWnd, msg, wp, lp, plResult, dwCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT PreMessageFilter(
            HWND hWnd,
            uint msg,
            WPARAM wp,
            LPARAM lp,
            LRESULT* plResult,
            [NativeTypeName("DWORD *")] uint* pdwCookie
        );

        [VtblIndex(4)]
        HRESULT PostMessageFilter(
            HWND hWnd,
            uint msg,
            WPARAM wp,
            LPARAM lp,
            LRESULT* plResult,
            [NativeTypeName("DWORD")] uint dwCookie
        );
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
            "HRESULT (HWND, UINT, WPARAM, LPARAM, LRESULT *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            uint,
            WPARAM,
            LPARAM,
            LRESULT*,
            uint*,
            int> PreMessageFilter;

        [NativeTypeName(
            "HRESULT (HWND, UINT, WPARAM, LPARAM, LRESULT *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            uint,
            WPARAM,
            LPARAM,
            LRESULT*,
            uint,
            int> PostMessageFilter;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISimpleFrameSite"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISimpleFrameSite(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISimpleFrameSite"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISimpleFrameSite(Silk.NET.Windows.IUnknown value)
    {
        return new ISimpleFrameSite(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISimpleFrameSite"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISimpleFrameSite"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISimpleFrameSite value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
