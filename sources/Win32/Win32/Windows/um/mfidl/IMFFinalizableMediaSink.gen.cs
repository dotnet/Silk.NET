// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EAECB74A-9A50-42CE-9541-6A7F57AA4AD7")]
[NativeTypeName("struct IMFFinalizableMediaSink : IMFMediaSink")]
[NativeInheritance("IMFMediaSink")]
public unsafe partial struct IMFFinalizableMediaSink
    : IMFFinalizableMediaSink.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFFinalizableMediaSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFFinalizableMediaSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink, uint*, int>)((*lpVtbl)[3]))(
            this,
            pdwCharacteristics
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddStreamSink(
        [NativeTypeName("DWORD")] uint dwStreamSinkIdentifier,
        IMFMediaType pMediaType,
        IMFStreamSink* ppStreamSink
    )
    {
        return (
            (delegate* unmanaged<IMFFinalizableMediaSink, uint, IMFMediaType, IMFStreamSink*, int>)(
                (*lpVtbl)[4]
            )
        )(this, dwStreamSinkIdentifier, pMediaType, ppStreamSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemoveStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink, uint, int>)((*lpVtbl)[5]))(
            this,
            dwStreamSinkIdentifier
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStreamSinkCount([NativeTypeName("DWORD *")] uint* pcStreamSinkCount)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink, uint*, int>)((*lpVtbl)[6]))(
            this,
            pcStreamSinkCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetStreamSinkByIndex(
        [NativeTypeName("DWORD")] uint dwIndex,
        IMFStreamSink* ppStreamSink
    )
    {
        return (
            (delegate* unmanaged<IMFFinalizableMediaSink, uint, IMFStreamSink*, int>)((*lpVtbl)[7])
        )(this, dwIndex, ppStreamSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStreamSinkById(
        [NativeTypeName("DWORD")] uint dwStreamSinkIdentifier,
        IMFStreamSink* ppStreamSink
    )
    {
        return (
            (delegate* unmanaged<IMFFinalizableMediaSink, uint, IMFStreamSink*, int>)((*lpVtbl)[8])
        )(this, dwStreamSinkIdentifier, ppStreamSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetPresentationClock(IMFPresentationClock pPresentationClock)
    {
        return (
            (delegate* unmanaged<IMFFinalizableMediaSink, IMFPresentationClock, int>)((*lpVtbl)[9])
        )(this, pPresentationClock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPresentationClock(IMFPresentationClock* ppPresentationClock)
    {
        return (
            (delegate* unmanaged<IMFFinalizableMediaSink, IMFPresentationClock*, int>)(
                (*lpVtbl)[10]
            )
        )(this, ppPresentationClock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT BeginFinalize(IMFAsyncCallback pCallback, IUnknown punkState)
    {
        return (
            (delegate* unmanaged<IMFFinalizableMediaSink, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[12]
            )
        )(this, pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EndFinalize(IMFAsyncResult pResult)
    {
        return ((delegate* unmanaged<IMFFinalizableMediaSink, IMFAsyncResult, int>)((*lpVtbl)[13]))(
            this,
            pResult
        );
    }

    public interface Interface : IMFMediaSink.Interface
    {
        [VtblIndex(12)]
        HRESULT BeginFinalize(IMFAsyncCallback pCallback, IUnknown punkState);

        [VtblIndex(13)]
        HRESULT EndFinalize(IMFAsyncResult pResult);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCharacteristics;

        [NativeTypeName(
            "HRESULT (DWORD, IMFMediaType *, IMFStreamSink **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType, IMFStreamSink*, int> AddStreamSink;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveStreamSink;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetStreamSinkCount;

        [NativeTypeName("HRESULT (DWORD, IMFStreamSink **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFStreamSink*, int> GetStreamSinkByIndex;

        [NativeTypeName("HRESULT (DWORD, IMFStreamSink **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFStreamSink*, int> GetStreamSinkById;

        [NativeTypeName("HRESULT (IMFPresentationClock *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationClock, int> SetPresentationClock;

        [NativeTypeName("HRESULT (IMFPresentationClock **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPresentationClock*, int> GetPresentationClock;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback, IUnknown, int> BeginFinalize;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult, int> EndFinalize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFFinalizableMediaSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFFinalizableMediaSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFMediaSink"/> to <see cref = "IMFFinalizableMediaSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFMediaSink"/> instance to be converted </param>
    public static explicit operator IMFFinalizableMediaSink(Silk.NET.Windows.IMFMediaSink value)
    {
        return new IMFFinalizableMediaSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFFinalizableMediaSink"/> to <see cref = "Silk.NET.Windows.IMFMediaSink"/>.</summary>
    /// <param name = "value">The <see cref = "IMFFinalizableMediaSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFMediaSink(IMFFinalizableMediaSink value)
    {
        return new Silk.NET.Windows.IMFMediaSink(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFFinalizableMediaSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFFinalizableMediaSink(Silk.NET.Windows.IUnknown value)
    {
        return new IMFFinalizableMediaSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFFinalizableMediaSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFFinalizableMediaSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFFinalizableMediaSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
