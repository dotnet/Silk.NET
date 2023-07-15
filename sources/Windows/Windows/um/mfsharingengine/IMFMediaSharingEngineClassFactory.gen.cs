// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFMediaSharingEngineClassFactory.xml' path='doc/member[@name="IMFMediaSharingEngineClassFactory"]/*'/>
[Guid("524D2BC4-B2B1-4FE5-8FAC-FA4E4512B4E0")]
[NativeTypeName("struct IMFMediaSharingEngineClassFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFMediaSharingEngineClassFactory : IMFMediaSharingEngineClassFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaSharingEngineClassFactory));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngineClassFactory*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngineClassFactory*, uint> )(lpVtbl[1]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSharingEngineClassFactory*, uint> )(lpVtbl[2]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaSharingEngineClassFactory.xml' path='doc/member[@name="IMFMediaSharingEngineClassFactory.CreateInstance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstance([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaSharingEngine** ppEngine)
    {
        return ((delegate* unmanaged<IMFMediaSharingEngineClassFactory*, uint, IMFAttributes*, IMFMediaSharingEngine**, int> )(lpVtbl[3]))((IMFMediaSharingEngineClassFactory*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppEngine);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateInstance([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaSharingEngine** ppEngine);
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
        [NativeTypeName("HRESULT (DWORD, IMFAttributes *, IMFMediaSharingEngine **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFAttributes*, IMFMediaSharingEngine**, int> CreateInstance;
    }
}