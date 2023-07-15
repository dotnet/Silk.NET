// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ui.xaml.hosting.desktopwindowxamlsource.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IDesktopWindowXamlSourceNative2.xml' path='doc/member[@name="IDesktopWindowXamlSourceNative2"]/*'/>
[Guid("E3DCD8C7-3057-4692-99C3-7B7720AFDA31")]
[NativeTypeName("struct IDesktopWindowXamlSourceNative2 : IDesktopWindowXamlSourceNative")]
[NativeInheritance("IDesktopWindowXamlSourceNative")]
[SupportedOSPlatform("windows10.0.18362.0")]
public unsafe partial struct IDesktopWindowXamlSourceNative2 : IDesktopWindowXamlSourceNative2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDesktopWindowXamlSourceNative2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative2*, Guid*, void**, int> )(lpVtbl[0]))((IDesktopWindowXamlSourceNative2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative2*, uint> )(lpVtbl[1]))((IDesktopWindowXamlSourceNative2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative2*, uint> )(lpVtbl[2]))((IDesktopWindowXamlSourceNative2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDesktopWindowXamlSourceNative.AttachToWindow"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AttachToWindow(HWND parentWnd)
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative2*, HWND, int> )(lpVtbl[3]))((IDesktopWindowXamlSourceNative2*)Unsafe.AsPointer(ref this), parentWnd);
    }

    /// <inheritdoc cref = "IDesktopWindowXamlSourceNative.get_WindowHandle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_WindowHandle(HWND* hWnd)
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative2*, HWND*, int> )(lpVtbl[4]))((IDesktopWindowXamlSourceNative2*)Unsafe.AsPointer(ref this), hWnd);
    }

    /// <include file='IDesktopWindowXamlSourceNative2.xml' path='doc/member[@name="IDesktopWindowXamlSourceNative2.PreTranslateMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT PreTranslateMessage([NativeTypeName("const MSG *")] MSG* message, BOOL* result)
    {
        return ((delegate* unmanaged<IDesktopWindowXamlSourceNative2*, MSG*, BOOL*, int> )(lpVtbl[5]))((IDesktopWindowXamlSourceNative2*)Unsafe.AsPointer(ref this), message, result);
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
}