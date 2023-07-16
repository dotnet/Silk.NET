// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFMediaEngineClassFactory.xml' path='doc/member[@name="IMFMediaEngineClassFactory"]/*'/>
[Guid("4D645ACE-26AA-4688-9BE1-DF3516990B93")]
[NativeTypeName("struct IMFMediaEngineClassFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFMediaEngineClassFactory : IMFMediaEngineClassFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineClassFactory));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaEngineClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory*, uint> )(lpVtbl[1]))((IMFMediaEngineClassFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory*, uint> )(lpVtbl[2]))((IMFMediaEngineClassFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineClassFactory.xml' path='doc/member[@name="IMFMediaEngineClassFactory.CreateInstance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstance([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaEngine** ppPlayer)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory*, uint, IMFAttributes*, IMFMediaEngine**, int> )(lpVtbl[3]))((IMFMediaEngineClassFactory*)Unsafe.AsPointer(ref this), dwFlags, pAttr, ppPlayer);
    }

    /// <include file='IMFMediaEngineClassFactory.xml' path='doc/member[@name="IMFMediaEngineClassFactory.CreateTimeRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateTimeRange(IMFMediaTimeRange** ppTimeRange)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory*, IMFMediaTimeRange**, int> )(lpVtbl[4]))((IMFMediaEngineClassFactory*)Unsafe.AsPointer(ref this), ppTimeRange);
    }

    /// <include file='IMFMediaEngineClassFactory.xml' path='doc/member[@name="IMFMediaEngineClassFactory.CreateError"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateError(IMFMediaError** ppError)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory*, IMFMediaError**, int> )(lpVtbl[5]))((IMFMediaEngineClassFactory*)Unsafe.AsPointer(ref this), ppError);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateInstance([NativeTypeName("DWORD")] uint dwFlags, IMFAttributes* pAttr, IMFMediaEngine** ppPlayer);
        [VtblIndex(4)]
        HRESULT CreateTimeRange(IMFMediaTimeRange** ppTimeRange);
        [VtblIndex(5)]
        HRESULT CreateError(IMFMediaError** ppError);
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
    }
}