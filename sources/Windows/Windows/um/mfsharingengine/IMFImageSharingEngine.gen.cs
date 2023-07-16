// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFImageSharingEngine.xml' path='doc/member[@name="IMFImageSharingEngine"]/*'/>
[Guid("CFA0AE8E-7E1C-44D2-AE68-FC4C148A6354")]
[NativeTypeName("struct IMFImageSharingEngine : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFImageSharingEngine : IMFImageSharingEngine.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFImageSharingEngine));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFImageSharingEngine*, Guid*, void**, int> )(lpVtbl[0]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFImageSharingEngine*, uint> )(lpVtbl[1]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFImageSharingEngine*, uint> )(lpVtbl[2]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFImageSharingEngine.xml' path='doc/member[@name="IMFImageSharingEngine.SetSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSource(IUnknown* pStream)
    {
        return ((delegate* unmanaged<IMFImageSharingEngine*, IUnknown*, int> )(lpVtbl[3]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this), pStream);
    }

    /// <include file='IMFImageSharingEngine.xml' path='doc/member[@name="IMFImageSharingEngine.GetDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDevice(DEVICE_INFO* pDevice)
    {
        return ((delegate* unmanaged<IMFImageSharingEngine*, DEVICE_INFO*, int> )(lpVtbl[4]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this), pDevice);
    }

    /// <include file='IMFImageSharingEngine.xml' path='doc/member[@name="IMFImageSharingEngine.Shutdown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFImageSharingEngine*, int> )(lpVtbl[5]))((IMFImageSharingEngine*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSource(IUnknown* pStream);
        [VtblIndex(4)]
        HRESULT GetDevice(DEVICE_INFO* pDevice);
        [VtblIndex(5)]
        HRESULT Shutdown();
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
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetSource;
        [NativeTypeName("HRESULT (DEVICE_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DEVICE_INFO*, int> GetDevice;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;
    }
}