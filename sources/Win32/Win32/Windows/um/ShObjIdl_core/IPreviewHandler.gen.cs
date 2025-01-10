// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8895B1C6-B41F-4C1C-A562-0D564250836F")]
[NativeTypeName("struct IPreviewHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPreviewHandler : IPreviewHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPreviewHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPreviewHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPreviewHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPreviewHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetWindow(HWND hwnd, [NativeTypeName("const RECT *")] RECT* prc)
    {
        return ((delegate* unmanaged<IPreviewHandler, HWND, RECT*, int>)((*lpVtbl)[3]))(
            this,
            hwnd,
            prc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetRect([NativeTypeName("const RECT *")] RECT* prc)
    {
        return ((delegate* unmanaged<IPreviewHandler, RECT*, int>)((*lpVtbl)[4]))(this, prc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DoPreview()
    {
        return ((delegate* unmanaged<IPreviewHandler, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Unload()
    {
        return ((delegate* unmanaged<IPreviewHandler, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFocus()
    {
        return ((delegate* unmanaged<IPreviewHandler, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT QueryFocus(HWND* phwnd)
    {
        return ((delegate* unmanaged<IPreviewHandler, HWND*, int>)((*lpVtbl)[8]))(this, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TranslateAcceleratorW(MSG* pmsg)
    {
        return ((delegate* unmanaged<IPreviewHandler, MSG*, int>)((*lpVtbl)[9]))(this, pmsg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetWindow(HWND hwnd, [NativeTypeName("const RECT *")] RECT* prc);

        [VtblIndex(4)]
        HRESULT SetRect([NativeTypeName("const RECT *")] RECT* prc);

        [VtblIndex(5)]
        HRESULT DoPreview();

        [VtblIndex(6)]
        HRESULT Unload();

        [VtblIndex(7)]
        HRESULT SetFocus();

        [VtblIndex(8)]
        HRESULT QueryFocus(HWND* phwnd);

        [VtblIndex(9)]
        HRESULT TranslateAcceleratorW(MSG* pmsg);
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

        [NativeTypeName("HRESULT (HWND, const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, RECT*, int> SetWindow;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetRect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DoPreview;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unload;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetFocus;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> QueryFocus;

        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> TranslateAcceleratorW;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPreviewHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPreviewHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPreviewHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPreviewHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IPreviewHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPreviewHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPreviewHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPreviewHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
