// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6EF2A660-47C0-4666-B13D-CBB717F2FA2C")]
[NativeTypeName("struct IMFMediaSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaSink : IMFMediaSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IMFMediaSink, uint*, int>)((*lpVtbl)[3]))(
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
            (delegate* unmanaged<IMFMediaSink, uint, IMFMediaType, IMFStreamSink*, int>)(
                (*lpVtbl)[4]
            )
        )(this, dwStreamSinkIdentifier, pMediaType, ppStreamSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemoveStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier)
    {
        return ((delegate* unmanaged<IMFMediaSink, uint, int>)((*lpVtbl)[5]))(
            this,
            dwStreamSinkIdentifier
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStreamSinkCount([NativeTypeName("DWORD *")] uint* pcStreamSinkCount)
    {
        return ((delegate* unmanaged<IMFMediaSink, uint*, int>)((*lpVtbl)[6]))(
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
        return ((delegate* unmanaged<IMFMediaSink, uint, IMFStreamSink*, int>)((*lpVtbl)[7]))(
            this,
            dwIndex,
            ppStreamSink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStreamSinkById(
        [NativeTypeName("DWORD")] uint dwStreamSinkIdentifier,
        IMFStreamSink* ppStreamSink
    )
    {
        return ((delegate* unmanaged<IMFMediaSink, uint, IMFStreamSink*, int>)((*lpVtbl)[8]))(
            this,
            dwStreamSinkIdentifier,
            ppStreamSink
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetPresentationClock(IMFPresentationClock pPresentationClock)
    {
        return ((delegate* unmanaged<IMFMediaSink, IMFPresentationClock, int>)((*lpVtbl)[9]))(
            this,
            pPresentationClock
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPresentationClock(IMFPresentationClock* ppPresentationClock)
    {
        return ((delegate* unmanaged<IMFMediaSink, IMFPresentationClock*, int>)((*lpVtbl)[10]))(
            this,
            ppPresentationClock
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaSink, int>)((*lpVtbl)[11]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics);

        [VtblIndex(4)]
        HRESULT AddStreamSink(
            [NativeTypeName("DWORD")] uint dwStreamSinkIdentifier,
            IMFMediaType pMediaType,
            IMFStreamSink* ppStreamSink
        );

        [VtblIndex(5)]
        HRESULT RemoveStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier);

        [VtblIndex(6)]
        HRESULT GetStreamSinkCount([NativeTypeName("DWORD *")] uint* pcStreamSinkCount);

        [VtblIndex(7)]
        HRESULT GetStreamSinkByIndex(
            [NativeTypeName("DWORD")] uint dwIndex,
            IMFStreamSink* ppStreamSink
        );

        [VtblIndex(8)]
        HRESULT GetStreamSinkById(
            [NativeTypeName("DWORD")] uint dwStreamSinkIdentifier,
            IMFStreamSink* ppStreamSink
        );

        [VtblIndex(9)]
        HRESULT SetPresentationClock(IMFPresentationClock pPresentationClock);

        [VtblIndex(10)]
        HRESULT GetPresentationClock(IMFPresentationClock* ppPresentationClock);

        [VtblIndex(11)]
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaSink(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
