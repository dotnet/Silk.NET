// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DE400F54-5BF1-40CF-8964-0BEA136B1E3D")]
[NativeTypeName("struct IMFHDCPStatus : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFHDCPStatus : IMFHDCPStatus.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFHDCPStatus));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFHDCPStatus, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFHDCPStatus, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFHDCPStatus, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Query(MF_HDCP_STATUS* pStatus, BOOL* pfStatus)
    {
        return ((delegate* unmanaged<IMFHDCPStatus, MF_HDCP_STATUS*, BOOL*, int>)((*lpVtbl)[3]))(
            this,
            pStatus,
            pfStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Set(MF_HDCP_STATUS status)
    {
        return ((delegate* unmanaged<IMFHDCPStatus, MF_HDCP_STATUS, int>)((*lpVtbl)[4]))(
            this,
            status
        );
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

    /// <summary>Initializes a new instance of the <see cref = "IMFHDCPStatus"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFHDCPStatus(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFHDCPStatus"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFHDCPStatus(Silk.NET.Windows.IUnknown value)
    {
        return new IMFHDCPStatus(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFHDCPStatus"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFHDCPStatus"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFHDCPStatus value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
