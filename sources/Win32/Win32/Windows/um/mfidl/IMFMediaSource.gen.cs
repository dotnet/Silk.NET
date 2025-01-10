// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("279A808D-AEC7-40C8-9C6B-A6B492C78A66")]
[NativeTypeName("struct IMFMediaSource : IMFMediaEventGenerator")]
[NativeInheritance("IMFMediaEventGenerator")]
public unsafe partial struct IMFMediaSource : IMFMediaSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSource, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent* ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaSource, uint, IMFMediaEvent*, int>)((*lpVtbl)[3]))(
            this,
            dwFlags,
            ppEvent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginGetEvent(IMFAsyncCallback pCallback, IUnknown punkState)
    {
        return (
            (delegate* unmanaged<IMFMediaSource, IMFAsyncCallback, IUnknown, int>)((*lpVtbl)[4])
        )(this, pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndGetEvent(IMFAsyncResult pResult, IMFMediaEvent* ppEvent)
    {
        return (
            (delegate* unmanaged<IMFMediaSource, IMFAsyncResult, IMFMediaEvent*, int>)((*lpVtbl)[5])
        )(this, pResult, ppEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueueEvent(
        [NativeTypeName("MediaEventType")] uint met,
        [NativeTypeName("const GUID &")] Guid* guidExtendedType,
        HRESULT hrStatus,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue
    )
    {
        return (
            (delegate* unmanaged<IMFMediaSource, uint, Guid*, HRESULT, PROPVARIANT*, int>)(
                (*lpVtbl)[6]
            )
        )(this, met, guidExtendedType, hrStatus, pvValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IMFMediaSource, uint*, int>)((*lpVtbl)[7]))(
            this,
            pdwCharacteristics
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreatePresentationDescriptor(IMFPresentationDescriptor* ppPresentationDescriptor)
    {
        return (
            (delegate* unmanaged<IMFMediaSource, IMFPresentationDescriptor*, int>)((*lpVtbl)[8])
        )(this, ppPresentationDescriptor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Start(
        IMFPresentationDescriptor pPresentationDescriptor,
        [NativeTypeName("const GUID *")] Guid* pguidTimeFormat,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition
    )
    {
        return (
            (delegate* unmanaged<
                IMFMediaSource,
                IMFPresentationDescriptor,
                Guid*,
                PROPVARIANT*,
                int>)((*lpVtbl)[9])
        )(this, pPresentationDescriptor, pguidTimeFormat, pvarStartPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IMFMediaSource, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMFMediaSource, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaSource, int>)((*lpVtbl)[12]))(this);
    }

    public interface Interface : IMFMediaEventGenerator.Interface
    {
        [VtblIndex(7)]
        HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics);

        [VtblIndex(8)]
        HRESULT CreatePresentationDescriptor(IMFPresentationDescriptor* ppPresentationDescriptor);

        [VtblIndex(9)]
        HRESULT Start(
            IMFPresentationDescriptor pPresentationDescriptor,
            [NativeTypeName("const GUID *")] Guid* pguidTimeFormat,
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarStartPosition
        );

        [VtblIndex(10)]
        HRESULT Stop();

        [VtblIndex(11)]
        HRESULT Pause();

        [VtblIndex(12)]
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

        [NativeTypeName("HRESULT (DWORD, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaEvent*, int> GetEvent;

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback, IUnknown, int> BeginGetEvent;

        [NativeTypeName("HRESULT (IMFAsyncResult *, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult, IMFMediaEvent*, int> EndGetEvent;

        [NativeTypeName(
            "HRESULT (MediaEventType, const GUID &, HRESULT, const PROPVARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Guid*, HRESULT, PROPVARIANT*, int> QueueEvent;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCharacteristics;

        [NativeTypeName("HRESULT (IMFPresentationDescriptor **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMFPresentationDescriptor*,
            int> CreatePresentationDescriptor;

        [NativeTypeName(
            "HRESULT (IMFPresentationDescriptor *, const GUID *, const PROPVARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFPresentationDescriptor,
            Guid*,
            PROPVARIANT*,
            int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFMediaEventGenerator"/> to <see cref = "IMFMediaSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFMediaEventGenerator"/> instance to be converted </param>
    public static explicit operator IMFMediaSource(Silk.NET.Windows.IMFMediaEventGenerator value)
    {
        return new IMFMediaSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaSource"/> to <see cref = "Silk.NET.Windows.IMFMediaEventGenerator"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFMediaEventGenerator(IMFMediaSource value)
    {
        return new Silk.NET.Windows.IMFMediaEventGenerator(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaSource(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
