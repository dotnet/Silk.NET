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

[Guid("3A3DCD6C-3EAB-43DC-BCDE-45671CE800C8")]
[NativeTypeName("struct IDataTransferManagerInterop : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDataTransferManagerInterop
    : IDataTransferManagerInterop.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataTransferManagerInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDataTransferManagerInterop, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDataTransferManagerInterop, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataTransferManagerInterop, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetForWindow(
        HWND appWindow,
        [NativeTypeName("const IID &")] Guid* riid,
        void** dataTransferManager
    )
    {
        return (
            (delegate* unmanaged<IDataTransferManagerInterop, HWND, Guid*, void**, int>)(
                (*lpVtbl)[3]
            )
        )(this, appWindow, riid, dataTransferManager);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ShowShareUIForWindow(HWND appWindow)
    {
        return ((delegate* unmanaged<IDataTransferManagerInterop, HWND, int>)((*lpVtbl)[4]))(
            this,
            appWindow
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetForWindow(
            HWND appWindow,
            [NativeTypeName("const IID &")] Guid* riid,
            void** dataTransferManager
        );

        [VtblIndex(4)]
        HRESULT ShowShareUIForWindow(HWND appWindow);
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

        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, void**, int> GetForWindow;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> ShowShareUIForWindow;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataTransferManagerInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataTransferManagerInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataTransferManagerInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataTransferManagerInterop(Silk.NET.Windows.IUnknown value)
    {
        return new IDataTransferManagerInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataTransferManagerInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataTransferManagerInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataTransferManagerInterop value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
