// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFMediaEngineClassFactoryEx.xml' path='doc/member[@name="IMFMediaEngineClassFactoryEx"]/*'/>
[Guid("C56156C6-EA5B-48A5-9DF8-FBE035D0929E")]
[NativeTypeName("struct IMFMediaEngineClassFactoryEx : IMFMediaEngineClassFactory")]
[NativeInheritance("IMFMediaEngineClassFactory")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFMediaEngineClassFactoryEx : IMFMediaEngineClassFactoryEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineClassFactoryEx));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, uint> )(lpVtbl[1]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, uint> )(lpVtbl[2]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFMediaEngineClassFactory.CreateInstance"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstance([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaEngine** ppPlayer)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaEngine**, int> )(lpVtbl[3]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppPlayer);
    }

    /// <inheritdoc cref = "IMFMediaEngineClassFactory.CreateTimeRange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateTimeRange(IMFMediaTimeRange** ppTimeRange)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, IMFMediaTimeRange**, int> )(lpVtbl[4]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), ppTimeRange);
    }

    /// <inheritdoc cref = "IMFMediaEngineClassFactory.CreateError"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateError(IMFMediaError** ppError)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, IMFMediaError**, int> )(lpVtbl[5]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), ppError);
    }

    /// <include file='IMFMediaEngineClassFactoryEx.xml' path='doc/member[@name="IMFMediaEngineClassFactoryEx.CreateMediaSourceExtension"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateMediaSourceExtension([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaSourceExtension** ppMSE)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, uint, IMFAttributes*, IMFMediaSourceExtension**, int> )(lpVtbl[6]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppMSE);
    }

    /// <include file='IMFMediaEngineClassFactoryEx.xml' path='doc/member[@name="IMFMediaEngineClassFactoryEx.CreateMediaKeys"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateMediaKeys([NativeTypeName("BSTR")] ushort* keySystem, [NativeTypeName("BSTR")] ushort* cdmStorePath, IMFMediaKeys** ppKeys)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, ushort*, ushort*, IMFMediaKeys**, int> )(lpVtbl[7]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), keySystem, cdmStorePath, ppKeys);
    }

    /// <include file='IMFMediaEngineClassFactoryEx.xml' path='doc/member[@name="IMFMediaEngineClassFactoryEx.IsTypeSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsTypeSupported([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("BSTR")] ushort* keySystem, BOOL* isSupported)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactoryEx*, ushort*, ushort*, BOOL*, int> )(lpVtbl[8]))((IMFMediaEngineClassFactoryEx*)Unsafe.AsPointer(ref this), type, keySystem, isSupported);
    }

    public interface Interface : IMFMediaEngineClassFactory.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateMediaSourceExtension([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaSourceExtension** ppMSE);
        [VtblIndex(7)]
        HRESULT CreateMediaKeys([NativeTypeName("BSTR")] ushort* keySystem, [NativeTypeName("BSTR")] ushort* cdmStorePath, IMFMediaKeys** ppKeys);
        [VtblIndex(8)]
        HRESULT IsTypeSupported([NativeTypeName("BSTR")] ushort* type, [NativeTypeName("BSTR")] ushort* keySystem, BOOL* isSupported);
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
        [NativeTypeName("HRESULT (DWORD, IMFAttributes *, IMFMediaEngine **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFAttributes*, IMFMediaEngine**, int> CreateInstance;
        [NativeTypeName("HRESULT (IMFMediaTimeRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaTimeRange**, int> CreateTimeRange;
        [NativeTypeName("HRESULT (IMFMediaError **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaError**, int> CreateError;
        [NativeTypeName("HRESULT (DWORD, IMFAttributes *, IMFMediaSourceExtension **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFAttributes*, IMFMediaSourceExtension**, int> CreateMediaSourceExtension;
        [NativeTypeName("HRESULT (BSTR, BSTR, IMFMediaKeys **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IMFMediaKeys**, int> CreateMediaKeys;
        [NativeTypeName("HRESULT (BSTR, BSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, BOOL*, int> IsTypeSupported;
    }
}