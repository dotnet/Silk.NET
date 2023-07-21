// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;

/// <include file='ICoreWindowComponentInterop.xml' path='doc/member[@name="ICoreWindowComponentInterop"]/*' />
[Guid("0576AB31-A310-4C40-BA31-FD37E0298DFA")]
[NativeTypeName("struct ICoreWindowComponentInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICoreWindowComponentInterop : ICoreWindowComponentInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreWindowComponentInterop));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoreWindowComponentInterop*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowComponentInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICoreWindowComponentInterop*, uint>)(lpVtbl[1]))((ICoreWindowComponentInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreWindowComponentInterop*, uint>)(lpVtbl[2]))((ICoreWindowComponentInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICoreWindowComponentInterop.xml' path='doc/member[@name="ICoreWindowComponentInterop.ConfigureComponentInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ConfigureComponentInput([NativeTypeName("UINT32")] uint hostViewInstanceId, HWND hwndHost, IUnknown* inputSourceVisual)
    {
        return ((delegate* unmanaged<ICoreWindowComponentInterop*, uint, HWND, IUnknown*, int>)(lpVtbl[3]))((ICoreWindowComponentInterop*)Unsafe.AsPointer(ref this), hostViewInstanceId, hwndHost, inputSourceVisual);
    }

    /// <include file='ICoreWindowComponentInterop.xml' path='doc/member[@name="ICoreWindowComponentInterop.GetViewInstanceId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetViewInstanceId([NativeTypeName("UINT32 *")] uint* componentViewInstanceId)
    {
        return ((delegate* unmanaged<ICoreWindowComponentInterop*, uint*, int>)(lpVtbl[4]))((ICoreWindowComponentInterop*)Unsafe.AsPointer(ref this), componentViewInstanceId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ConfigureComponentInput([NativeTypeName("UINT32")] uint hostViewInstanceId, HWND hwndHost, IUnknown* inputSourceVisual);

        [VtblIndex(4)]
        HRESULT GetViewInstanceId([NativeTypeName("UINT32 *")] uint* componentViewInstanceId);
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

        [NativeTypeName("HRESULT (UINT32, HWND, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HWND, IUnknown*, int> ConfigureComponentInput;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetViewInstanceId;
    }
}
