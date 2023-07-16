// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFDXGIDeviceManagerSource.xml' path='doc/member[@name="IMFDXGIDeviceManagerSource"]/*'/>
[Guid("20BC074B-7A8D-4609-8C3B-64A0A3B5D7CE")]
[NativeTypeName("struct IMFDXGIDeviceManagerSource : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFDXGIDeviceManagerSource : IMFDXGIDeviceManagerSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFDXGIDeviceManagerSource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManagerSource*, Guid*, void**, int> )(lpVtbl[0]))((IMFDXGIDeviceManagerSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManagerSource*, uint> )(lpVtbl[1]))((IMFDXGIDeviceManagerSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManagerSource*, uint> )(lpVtbl[2]))((IMFDXGIDeviceManagerSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFDXGIDeviceManagerSource.xml' path='doc/member[@name="IMFDXGIDeviceManagerSource.GetManager"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetManager(IMFDXGIDeviceManager** ppManager)
    {
        return ((delegate* unmanaged<IMFDXGIDeviceManagerSource*, IMFDXGIDeviceManager**, int> )(lpVtbl[3]))((IMFDXGIDeviceManagerSource*)Unsafe.AsPointer(ref this), ppManager);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetManager(IMFDXGIDeviceManager** ppManager);
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
        [NativeTypeName("HRESULT (IMFDXGIDeviceManager **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFDXGIDeviceManager**, int> GetManager;
    }
}