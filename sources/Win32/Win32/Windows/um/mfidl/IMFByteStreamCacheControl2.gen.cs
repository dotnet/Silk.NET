// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("71CE469C-F34B-49EA-A56B-2D2A10E51149")]
[NativeTypeName("struct IMFByteStreamCacheControl2 : IMFByteStreamCacheControl")]
[NativeInheritance("IMFByteStreamCacheControl")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFByteStreamCacheControl2
    : IMFByteStreamCacheControl2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFByteStreamCacheControl2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFByteStreamCacheControl2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFByteStreamCacheControl2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFByteStreamCacheControl2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT StopBackgroundTransfer()
    {
        return ((delegate* unmanaged<IMFByteStreamCacheControl2, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetByteRanges(
        [NativeTypeName("DWORD *")] uint* pcRanges,
        MF_BYTE_STREAM_CACHE_RANGE** ppRanges
    )
    {
        return (
            (delegate* unmanaged<
                IMFByteStreamCacheControl2,
                uint*,
                MF_BYTE_STREAM_CACHE_RANGE**,
                int>)((*lpVtbl)[4])
        )(this, pcRanges, ppRanges);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetCacheLimit([NativeTypeName("QWORD")] ulong qwBytes)
    {
        return ((delegate* unmanaged<IMFByteStreamCacheControl2, ulong, int>)((*lpVtbl)[5]))(
            this,
            qwBytes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsBackgroundTransferActive(BOOL* pfActive)
    {
        return ((delegate* unmanaged<IMFByteStreamCacheControl2, BOOL*, int>)((*lpVtbl)[6]))(
            this,
            pfActive
        );
    }

    public interface Interface : IMFByteStreamCacheControl.Interface
    {
        [VtblIndex(4)]
        HRESULT GetByteRanges(
            [NativeTypeName("DWORD *")] uint* pcRanges,
            MF_BYTE_STREAM_CACHE_RANGE** ppRanges
        );

        [VtblIndex(5)]
        HRESULT SetCacheLimit([NativeTypeName("QWORD")] ulong qwBytes);

        [VtblIndex(6)]
        HRESULT IsBackgroundTransferActive(BOOL* pfActive);
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
        public delegate* unmanaged<TSelf*, int> StopBackgroundTransfer;

        [NativeTypeName(
            "HRESULT (DWORD *, MF_BYTE_STREAM_CACHE_RANGE **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, MF_BYTE_STREAM_CACHE_RANGE**, int> GetByteRanges;

        [NativeTypeName("HRESULT (QWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> SetCacheLimit;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsBackgroundTransferActive;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFByteStreamCacheControl2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFByteStreamCacheControl2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFByteStreamCacheControl"/> to <see cref = "IMFByteStreamCacheControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFByteStreamCacheControl"/> instance to be converted </param>
    public static explicit operator IMFByteStreamCacheControl2(
        Silk.NET.Windows.IMFByteStreamCacheControl value
    )
    {
        return new IMFByteStreamCacheControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFByteStreamCacheControl2"/> to <see cref = "Silk.NET.Windows.IMFByteStreamCacheControl"/>.</summary>
    /// <param name = "value">The <see cref = "IMFByteStreamCacheControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFByteStreamCacheControl(
        IMFByteStreamCacheControl2 value
    )
    {
        return new Silk.NET.Windows.IMFByteStreamCacheControl(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFByteStreamCacheControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFByteStreamCacheControl2(Silk.NET.Windows.IUnknown value)
    {
        return new IMFByteStreamCacheControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFByteStreamCacheControl2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFByteStreamCacheControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFByteStreamCacheControl2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
