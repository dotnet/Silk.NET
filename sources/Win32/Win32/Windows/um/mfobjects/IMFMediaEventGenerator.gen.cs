// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2CD0BD52-BCD5-4B89-B62C-EADC0C031E7D")]
[NativeTypeName("struct IMFMediaEventGenerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaEventGenerator : IMFMediaEventGenerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEventGenerator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEventGenerator, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaEventGenerator, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEventGenerator, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent* ppEvent)
    {
        return (
            (delegate* unmanaged<IMFMediaEventGenerator, uint, IMFMediaEvent*, int>)((*lpVtbl)[3])
        )(this, dwFlags, ppEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginGetEvent(IMFAsyncCallback pCallback, IUnknown punkState)
    {
        return (
            (delegate* unmanaged<IMFMediaEventGenerator, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[4]
            )
        )(this, pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndGetEvent(IMFAsyncResult pResult, IMFMediaEvent* ppEvent)
    {
        return (
            (delegate* unmanaged<IMFMediaEventGenerator, IMFAsyncResult, IMFMediaEvent*, int>)(
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
            (delegate* unmanaged<IMFMediaEventGenerator, uint, Guid*, HRESULT, PROPVARIANT*, int>)(
                (*lpVtbl)[6]
            )
        )(this, met, guidExtendedType, hrStatus, pvValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent* ppEvent);

        [VtblIndex(4)]
        HRESULT BeginGetEvent(IMFAsyncCallback pCallback, IUnknown punkState);

        [VtblIndex(5)]
        HRESULT EndGetEvent(IMFAsyncResult pResult, IMFMediaEvent* ppEvent);

        [VtblIndex(6)]
        HRESULT QueueEvent(
            [NativeTypeName("MediaEventType")] uint met,
            [NativeTypeName("const GUID &")] Guid* guidExtendedType,
            HRESULT hrStatus,
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue
        );
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaEventGenerator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaEventGenerator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaEventGenerator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaEventGenerator(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaEventGenerator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaEventGenerator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaEventGenerator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaEventGenerator value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
