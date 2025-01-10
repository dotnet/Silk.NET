// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ui.xaml.hosting.desktopwindowxamlsource.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E3DCD8C7-3057-4692-99C3-7B7720AFDA31")]
[NativeTypeName("struct IDesktopWindowXamlSourceNative2 : IDesktopWindowXamlSourceNative")]
[NativeInheritance("IDesktopWindowXamlSourceNative")]
[SupportedOSPlatform("windows10.0.18362.0")]
public unsafe partial struct IDesktopWindowXamlSourceNative2
    : IDesktopWindowXamlSourceNative2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDesktopWindowXamlSourceNative2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDesktopWindowXamlSourceNative2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AttachToWindow(HWND parentWnd)
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative2, HWND, int>)((*lpVtbl)[3]))(
            this,
            parentWnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_WindowHandle(HWND* hWnd)
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative2, HWND*, int>)((*lpVtbl)[4]))(
            this,
            hWnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT PreTranslateMessage([NativeTypeName("const MSG *")] MSG* message, BOOL* result)
    {
        return (
            (delegate* unmanaged<IDesktopWindowXamlSourceNative2, MSG*, BOOL*, int>)((*lpVtbl)[5])
        )(this, message, result);
    }

    public interface Interface : IDesktopWindowXamlSourceNative.Interface
    {
        [VtblIndex(5)]
        HRESULT PreTranslateMessage([NativeTypeName("const MSG *")] MSG* message, BOOL* result);
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

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> AttachToWindow;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> get_WindowHandle;

        [NativeTypeName("HRESULT (const MSG *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, BOOL*, int> PreTranslateMessage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDesktopWindowXamlSourceNative2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDesktopWindowXamlSourceNative2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IDesktopWindowXamlSourceNative"/> to <see cref = "IDesktopWindowXamlSourceNative2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IDesktopWindowXamlSourceNative"/> instance to be converted </param>
    public static explicit operator IDesktopWindowXamlSourceNative2(
        Silk.NET.WinRT.IDesktopWindowXamlSourceNative value
    )
    {
        return new IDesktopWindowXamlSourceNative2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDesktopWindowXamlSourceNative2"/> to <see cref = "Silk.NET.WinRT.IDesktopWindowXamlSourceNative"/>.</summary>
    /// <param name = "value">The <see cref = "IDesktopWindowXamlSourceNative2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IDesktopWindowXamlSourceNative(
        IDesktopWindowXamlSourceNative2 value
    )
    {
        return new Silk.NET.WinRT.IDesktopWindowXamlSourceNative(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDesktopWindowXamlSourceNative2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDesktopWindowXamlSourceNative2(Silk.NET.Windows.IUnknown value)
    {
        return new IDesktopWindowXamlSourceNative2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDesktopWindowXamlSourceNative2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDesktopWindowXamlSourceNative2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDesktopWindowXamlSourceNative2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
