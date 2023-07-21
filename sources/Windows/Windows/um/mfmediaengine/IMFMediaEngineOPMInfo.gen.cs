// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFMediaEngineOPMInfo.xml' path='doc/member[@name="IMFMediaEngineOPMInfo"]/*' />
[Guid("765763E6-6C01-4B01-BB0F-B829F60ED28C")]
[NativeTypeName("struct IMFMediaEngineOPMInfo : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFMediaEngineOPMInfo : IMFMediaEngineOPMInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineOPMInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineOPMInfo*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineOPMInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineOPMInfo*, uint>)(lpVtbl[1]))((IMFMediaEngineOPMInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineOPMInfo*, uint>)(lpVtbl[2]))((IMFMediaEngineOPMInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineOPMInfo.xml' path='doc/member[@name="IMFMediaEngineOPMInfo.GetOPMInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOPMInfo(MF_MEDIA_ENGINE_OPM_STATUS* pStatus, BOOL* pConstricted)
    {
        return ((delegate* unmanaged<IMFMediaEngineOPMInfo*, MF_MEDIA_ENGINE_OPM_STATUS*, BOOL*, int>)(lpVtbl[3]))((IMFMediaEngineOPMInfo*)Unsafe.AsPointer(ref this), pStatus, pConstricted);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetOPMInfo(MF_MEDIA_ENGINE_OPM_STATUS* pStatus, BOOL* pConstricted);
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

        [NativeTypeName("HRESULT (MF_MEDIA_ENGINE_OPM_STATUS *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_MEDIA_ENGINE_OPM_STATUS*, BOOL*, int> GetOPMInfo;
    }
}
