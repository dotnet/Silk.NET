// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IVirtualSurfaceUpdatesCallbackNative.xml' path='doc/member[@name="IVirtualSurfaceUpdatesCallbackNative"]/*'/>
[Guid("DBF2E947-8E6C-4254-9EEE-7738F71386C9")]
[NativeTypeName("struct IVirtualSurfaceUpdatesCallbackNative : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IVirtualSurfaceUpdatesCallbackNative : IVirtualSurfaceUpdatesCallbackNative.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVirtualSurfaceUpdatesCallbackNative));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVirtualSurfaceUpdatesCallbackNative*, Guid*, void**, int> )(lpVtbl[0]))((IVirtualSurfaceUpdatesCallbackNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVirtualSurfaceUpdatesCallbackNative*, uint> )(lpVtbl[1]))((IVirtualSurfaceUpdatesCallbackNative*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVirtualSurfaceUpdatesCallbackNative*, uint> )(lpVtbl[2]))((IVirtualSurfaceUpdatesCallbackNative*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVirtualSurfaceUpdatesCallbackNative.xml' path='doc/member[@name="IVirtualSurfaceUpdatesCallbackNative.UpdatesNeeded"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UpdatesNeeded()
    {
        return ((delegate* unmanaged<IVirtualSurfaceUpdatesCallbackNative*, int> )(lpVtbl[3]))((IVirtualSurfaceUpdatesCallbackNative*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT UpdatesNeeded();
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
        public delegate* unmanaged<TSelf*, int> UpdatesNeeded;
    }
}