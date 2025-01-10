// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DEEC8D99-FA1D-4D82-84C2-2C8969944867")]
[NativeTypeName("struct IMFSourceReaderCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSourceReaderCallback
    : IMFSourceReaderCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSourceReaderCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSourceReaderCallback, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSourceReaderCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSourceReaderCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnReadSample(
        HRESULT hrStatus,
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        [NativeTypeName("DWORD")] uint dwStreamFlags,
        [NativeTypeName("LONGLONG")] long llTimestamp,
        IMFSample pSample
    )
    {
        return (
            (delegate* unmanaged<
                IMFSourceReaderCallback,
                HRESULT,
                uint,
                uint,
                long,
                IMFSample,
                int>)((*lpVtbl)[3])
        )(this, hrStatus, dwStreamIndex, dwStreamFlags, llTimestamp, pSample);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnFlush([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSourceReaderCallback, uint, int>)((*lpVtbl)[4]))(
            this,
            dwStreamIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnEvent([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaEvent pEvent)
    {
        return (
            (delegate* unmanaged<IMFSourceReaderCallback, uint, IMFMediaEvent, int>)((*lpVtbl)[5])
        )(this, dwStreamIndex, pEvent);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnReadSample(
            HRESULT hrStatus,
            [NativeTypeName("DWORD")] uint dwStreamIndex,
            [NativeTypeName("DWORD")] uint dwStreamFlags,
            [NativeTypeName("LONGLONG")] long llTimestamp,
            IMFSample pSample
        );

        [VtblIndex(4)]
        HRESULT OnFlush([NativeTypeName("DWORD")] uint dwStreamIndex);

        [VtblIndex(5)]
        HRESULT OnEvent([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaEvent pEvent);
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

        [NativeTypeName(
            "HRESULT (HRESULT, DWORD, DWORD, LONGLONG, IMFSample *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HRESULT, uint, uint, long, IMFSample, int> OnReadSample;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnFlush;

        [NativeTypeName("HRESULT (DWORD, IMFMediaEvent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaEvent, int> OnEvent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSourceReaderCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSourceReaderCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSourceReaderCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSourceReaderCallback(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSourceReaderCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSourceReaderCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSourceReaderCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSourceReaderCallback value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
