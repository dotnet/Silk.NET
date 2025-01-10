// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C5BC37D6-75C7-46A1-A132-81B5F723C20F")]
[NativeTypeName("struct IMFMediaStream2 : IMFMediaStream")]
[NativeInheritance("IMFMediaStream")]
public unsafe partial struct IMFMediaStream2 : IMFMediaStream2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaStream2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaStream2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaStream2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaStream2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent* ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaStream2, uint, IMFMediaEvent*, int>)((*lpVtbl)[3]))(
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
            (delegate* unmanaged<IMFMediaStream2, IMFAsyncCallback, IUnknown, int>)((*lpVtbl)[4])
        )(this, pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndGetEvent(IMFAsyncResult pResult, IMFMediaEvent* ppEvent)
    {
        return (
            (delegate* unmanaged<IMFMediaStream2, IMFAsyncResult, IMFMediaEvent*, int>)(
                (*lpVtbl)[5]
            )
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
            (delegate* unmanaged<IMFMediaStream2, uint, Guid*, HRESULT, PROPVARIANT*, int>)(
                (*lpVtbl)[6]
            )
        )(this, met, guidExtendedType, hrStatus, pvValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMediaSource(IMFMediaSource* ppMediaSource)
    {
        return ((delegate* unmanaged<IMFMediaStream2, IMFMediaSource*, int>)((*lpVtbl)[7]))(
            this,
            ppMediaSource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStreamDescriptor(IMFStreamDescriptor* ppStreamDescriptor)
    {
        return ((delegate* unmanaged<IMFMediaStream2, IMFStreamDescriptor*, int>)((*lpVtbl)[8]))(
            this,
            ppStreamDescriptor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestSample(IUnknown pToken)
    {
        return ((delegate* unmanaged<IMFMediaStream2, IUnknown, int>)((*lpVtbl)[9]))(this, pToken);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetStreamState(MF_STREAM_STATE value)
    {
        return ((delegate* unmanaged<IMFMediaStream2, MF_STREAM_STATE, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStreamState(MF_STREAM_STATE* value)
    {
        return ((delegate* unmanaged<IMFMediaStream2, MF_STREAM_STATE*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    public interface Interface : IMFMediaStream.Interface
    {
        [VtblIndex(10)]
        HRESULT SetStreamState(MF_STREAM_STATE value);

        [VtblIndex(11)]
        HRESULT GetStreamState(MF_STREAM_STATE* value);
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

        [NativeTypeName("HRESULT (IMFMediaSource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaSource*, int> GetMediaSource;

        [NativeTypeName("HRESULT (IMFStreamDescriptor **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFStreamDescriptor*, int> GetStreamDescriptor;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> RequestSample;

        [NativeTypeName("HRESULT (MF_STREAM_STATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_STREAM_STATE, int> SetStreamState;

        [NativeTypeName("HRESULT (MF_STREAM_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_STREAM_STATE*, int> GetStreamState;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaStream2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaStream2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFMediaStream"/> to <see cref = "IMFMediaStream2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFMediaStream"/> instance to be converted </param>
    public static explicit operator IMFMediaStream2(Silk.NET.Windows.IMFMediaStream value)
    {
        return new IMFMediaStream2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaStream2"/> to <see cref = "Silk.NET.Windows.IMFMediaStream"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaStream2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFMediaStream(IMFMediaStream2 value)
    {
        return new Silk.NET.Windows.IMFMediaStream(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFMediaEventGenerator"/> to <see cref = "IMFMediaStream2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFMediaEventGenerator"/> instance to be converted </param>
    public static explicit operator IMFMediaStream2(Silk.NET.Windows.IMFMediaEventGenerator value)
    {
        return new IMFMediaStream2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaStream2"/> to <see cref = "Silk.NET.Windows.IMFMediaEventGenerator"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaStream2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFMediaEventGenerator(IMFMediaStream2 value)
    {
        return new Silk.NET.Windows.IMFMediaEventGenerator(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaStream2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaStream2(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaStream2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaStream2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaStream2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaStream2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
