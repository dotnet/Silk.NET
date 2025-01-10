// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Windows.Graphics.Capture.Interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("3628E81B-3CAC-4C60-B7F4-23CE0E0C3356")]
[NativeTypeName("struct IGraphicsCaptureItemInterop : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IGraphicsCaptureItemInterop
    : IGraphicsCaptureItemInterop.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGraphicsCaptureItemInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IGraphicsCaptureItemInterop, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGraphicsCaptureItemInterop, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGraphicsCaptureItemInterop, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateForWindow(
        HWND window,
        [NativeTypeName("const IID &")] Guid* riid,
        void** result
    )
    {
        return (
            (delegate* unmanaged<IGraphicsCaptureItemInterop, HWND, Guid*, void**, int>)(
                (*lpVtbl)[3]
            )
        )(this, window, riid, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateForMonitor(
        HMONITOR monitor,
        [NativeTypeName("const IID &")] Guid* riid,
        void** result
    )
    {
        return (
            (delegate* unmanaged<IGraphicsCaptureItemInterop, HMONITOR, Guid*, void**, int>)(
                (*lpVtbl)[4]
            )
        )(this, monitor, riid, result);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateForWindow(
            HWND window,
            [NativeTypeName("const IID &")] Guid* riid,
            void** result
        );

        [VtblIndex(4)]
        HRESULT CreateForMonitor(
            HMONITOR monitor,
            [NativeTypeName("const IID &")] Guid* riid,
            void** result
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
            "HRESULT (HWND, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HWND, Guid*, void**, int> CreateForWindow;

        [NativeTypeName(
            "HRESULT (HMONITOR, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HMONITOR, Guid*, void**, int> CreateForMonitor;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGraphicsCaptureItemInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGraphicsCaptureItemInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGraphicsCaptureItemInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGraphicsCaptureItemInterop(Silk.NET.Windows.IUnknown value)
    {
        return new IGraphicsCaptureItemInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGraphicsCaptureItemInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGraphicsCaptureItemInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGraphicsCaptureItemInterop value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
