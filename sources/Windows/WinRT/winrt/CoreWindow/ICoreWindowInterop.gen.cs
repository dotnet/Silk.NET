// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='ICoreWindowInterop.xml' path='doc/member[@name="ICoreWindowInterop"]/*'/>
[Guid("45D64A29-A63E-4CB6-B498-5781D298CB4F")]
[NativeTypeName("struct ICoreWindowInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICoreWindowInterop : ICoreWindowInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreWindowInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoreWindowInterop*, Guid*, void**, int> )(lpVtbl[0]))((ICoreWindowInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICoreWindowInterop*, uint> )(lpVtbl[1]))((ICoreWindowInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreWindowInterop*, uint> )(lpVtbl[2]))((ICoreWindowInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICoreWindowInterop.xml' path='doc/member[@name="ICoreWindowInterop.get_WindowHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_WindowHandle(HWND* hwnd)
    {
        return ((delegate* unmanaged<ICoreWindowInterop*, HWND*, int> )(lpVtbl[3]))((ICoreWindowInterop*)Unsafe.AsPointer(ref this), hwnd);
    }

    /// <include file='ICoreWindowInterop.xml' path='doc/member[@name="ICoreWindowInterop.put_MessageHandled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_MessageHandled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICoreWindowInterop*, byte, int> )(lpVtbl[4]))((ICoreWindowInterop*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_WindowHandle(HWND* hwnd);
        [VtblIndex(4)]
        HRESULT put_MessageHandled([NativeTypeName("boolean")] byte value);
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
        public delegate* unmanaged<TSelf*, HWND*, int> get_WindowHandle;
        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_MessageHandled;
    }
}