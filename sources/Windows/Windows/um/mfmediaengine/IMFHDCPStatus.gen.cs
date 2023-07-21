// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFHDCPStatus.xml' path='doc/member[@name="IMFHDCPStatus"]/*' />
[Guid("DE400F54-5BF1-40CF-8964-0BEA136B1E3D")]
[NativeTypeName("struct IMFHDCPStatus : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFHDCPStatus : IMFHDCPStatus.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFHDCPStatus));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFHDCPStatus*, Guid*, void**, int>)(lpVtbl[0]))((IMFHDCPStatus*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFHDCPStatus*, uint>)(lpVtbl[1]))((IMFHDCPStatus*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFHDCPStatus*, uint>)(lpVtbl[2]))((IMFHDCPStatus*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFHDCPStatus.xml' path='doc/member[@name="IMFHDCPStatus.Query"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Query(MF_HDCP_STATUS* pStatus, BOOL* pfStatus)
    {
        return ((delegate* unmanaged<IMFHDCPStatus*, MF_HDCP_STATUS*, BOOL*, int>)(lpVtbl[3]))((IMFHDCPStatus*)Unsafe.AsPointer(ref this), pStatus, pfStatus);
    }

    /// <include file='IMFHDCPStatus.xml' path='doc/member[@name="IMFHDCPStatus.Set"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Set(MF_HDCP_STATUS status)
    {
        return ((delegate* unmanaged<IMFHDCPStatus*, MF_HDCP_STATUS, int>)(lpVtbl[4]))((IMFHDCPStatus*)Unsafe.AsPointer(ref this), status);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Query(MF_HDCP_STATUS* pStatus, BOOL* pfStatus);

        [VtblIndex(4)]
        HRESULT Set(MF_HDCP_STATUS status);
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

        [NativeTypeName("HRESULT (MF_HDCP_STATUS *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_HDCP_STATUS*, BOOL*, int> Query;

        [NativeTypeName("HRESULT (MF_HDCP_STATUS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_HDCP_STATUS, int> Set;
    }
}
