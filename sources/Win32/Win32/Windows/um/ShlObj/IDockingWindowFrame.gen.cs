// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("47D2657A-7B27-11D0-8CA9-00A0C92DBFE8")]
[NativeTypeName("struct IDockingWindowFrame : IOleWindow")]
[NativeInheritance("IOleWindow")]
public unsafe partial struct IDockingWindowFrame : IDockingWindowFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDockingWindowFrame));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDockingWindowFrame, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDockingWindowFrame, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDockingWindowFrame, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IDockingWindowFrame, HWND*, int>)((*lpVtbl)[3]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ContextSensitiveHelp(BOOL fEnterMode)
    {
        return ((delegate* unmanaged<IDockingWindowFrame, BOOL, int>)((*lpVtbl)[4]))(
            this,
            fEnterMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddToolbar(
        IUnknown punkSrc,
        [NativeTypeName("PCWSTR")] ushort* pwszItem,
        [NativeTypeName("DWORD")] uint dwAddFlags
    )
    {
        return (
            (delegate* unmanaged<IDockingWindowFrame, IUnknown, ushort*, uint, int>)((*lpVtbl)[5])
        )(this, punkSrc, pwszItem, dwAddFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveToolbar(IUnknown punkSrc, [NativeTypeName("DWORD")] uint dwRemoveFlags)
    {
        return ((delegate* unmanaged<IDockingWindowFrame, IUnknown, uint, int>)((*lpVtbl)[6]))(
            this,
            punkSrc,
            dwRemoveFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindToolbar(
        [NativeTypeName("PCWSTR")] ushort* pwszItem,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IDockingWindowFrame, ushort*, Guid*, void**, int>)((*lpVtbl)[7])
        )(this, pwszItem, riid, ppv);
    }

    public interface Interface : IOleWindow.Interface
    {
        [VtblIndex(5)]
        HRESULT AddToolbar(
            IUnknown punkSrc,
            [NativeTypeName("PCWSTR")] ushort* pwszItem,
            [NativeTypeName("DWORD")] uint dwAddFlags
        );

        [VtblIndex(6)]
        HRESULT RemoveToolbar(IUnknown punkSrc, [NativeTypeName("DWORD")] uint dwRemoveFlags);

        [VtblIndex(7)]
        HRESULT FindToolbar(
            [NativeTypeName("PCWSTR")] ushort* pwszItem,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
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

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWindow;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ContextSensitiveHelp;

        [NativeTypeName(
            "HRESULT (IUnknown *, PCWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUnknown, ushort*, uint, int> AddToolbar;

        [NativeTypeName(
            "HRESULT (IUnknown *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUnknown, uint, int> RemoveToolbar;

        [NativeTypeName(
            "HRESULT (PCWSTR, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, void**, int> FindToolbar;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDockingWindowFrame"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDockingWindowFrame(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleWindow"/> to <see cref = "IDockingWindowFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleWindow"/> instance to be converted </param>
    public static explicit operator IDockingWindowFrame(Silk.NET.Windows.IOleWindow value)
    {
        return new IDockingWindowFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDockingWindowFrame"/> to <see cref = "Silk.NET.Windows.IOleWindow"/>.</summary>
    /// <param name = "value">The <see cref = "IDockingWindowFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleWindow(IDockingWindowFrame value)
    {
        return new Silk.NET.Windows.IOleWindow(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDockingWindowFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDockingWindowFrame(Silk.NET.Windows.IUnknown value)
    {
        return new IDockingWindowFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDockingWindowFrame"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDockingWindowFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDockingWindowFrame value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
