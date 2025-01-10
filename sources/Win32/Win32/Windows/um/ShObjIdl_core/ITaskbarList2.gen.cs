// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("602D4995-B13A-429B-A66E-1935E44F4317")]
[NativeTypeName("struct ITaskbarList2 : ITaskbarList")]
[NativeInheritance("ITaskbarList")]
public unsafe partial struct ITaskbarList2 : ITaskbarList2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITaskbarList2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITaskbarList2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITaskbarList2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITaskbarList2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT HrInit()
    {
        return ((delegate* unmanaged<ITaskbarList2, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddTab(HWND hwnd)
    {
        return ((delegate* unmanaged<ITaskbarList2, HWND, int>)((*lpVtbl)[4]))(this, hwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DeleteTab(HWND hwnd)
    {
        return ((delegate* unmanaged<ITaskbarList2, HWND, int>)((*lpVtbl)[5]))(this, hwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ActivateTab(HWND hwnd)
    {
        return ((delegate* unmanaged<ITaskbarList2, HWND, int>)((*lpVtbl)[6]))(this, hwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetActiveAlt(HWND hwnd)
    {
        return ((delegate* unmanaged<ITaskbarList2, HWND, int>)((*lpVtbl)[7]))(this, hwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MarkFullscreenWindow(HWND hwnd, BOOL fFullscreen)
    {
        return ((delegate* unmanaged<ITaskbarList2, HWND, BOOL, int>)((*lpVtbl)[8]))(
            this,
            hwnd,
            fFullscreen
        );
    }

    public interface Interface : ITaskbarList.Interface
    {
        [VtblIndex(8)]
        HRESULT MarkFullscreenWindow(HWND hwnd, BOOL fFullscreen);
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
        public delegate* unmanaged<TSelf*, int> HrInit;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> AddTab;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> DeleteTab;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> ActivateTab;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> SetActiveAlt;

        [NativeTypeName("HRESULT (HWND, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, BOOL, int> MarkFullscreenWindow;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITaskbarList2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITaskbarList2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITaskbarList"/> to <see cref = "ITaskbarList2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITaskbarList"/> instance to be converted </param>
    public static explicit operator ITaskbarList2(Silk.NET.Windows.ITaskbarList value)
    {
        return new ITaskbarList2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITaskbarList2"/> to <see cref = "Silk.NET.Windows.ITaskbarList"/>.</summary>
    /// <param name = "value">The <see cref = "ITaskbarList2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITaskbarList(ITaskbarList2 value)
    {
        return new Silk.NET.Windows.ITaskbarList(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITaskbarList2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITaskbarList2(Silk.NET.Windows.IUnknown value)
    {
        return new ITaskbarList2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITaskbarList2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITaskbarList2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITaskbarList2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
