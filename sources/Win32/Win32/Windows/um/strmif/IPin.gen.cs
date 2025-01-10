// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A86891-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IPin : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPin : IPin.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPin));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPin, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPin, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPin, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Connect(
        IPin pReceivePin,
        [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt
    )
    {
        return ((delegate* unmanaged<IPin, IPin, AM_MEDIA_TYPE*, int>)((*lpVtbl)[3]))(
            this,
            pReceivePin,
            pmt
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReceiveConnection(
        IPin pConnector,
        [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt
    )
    {
        return ((delegate* unmanaged<IPin, IPin, AM_MEDIA_TYPE*, int>)((*lpVtbl)[4]))(
            this,
            pConnector,
            pmt
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Disconnect()
    {
        return ((delegate* unmanaged<IPin, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ConnectedTo(IPin* pPin)
    {
        return ((delegate* unmanaged<IPin, IPin*, int>)((*lpVtbl)[6]))(this, pPin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConnectionMediaType(AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IPin, AM_MEDIA_TYPE*, int>)((*lpVtbl)[7]))(this, pmt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT QueryPinInfo(PIN_INFO* pInfo)
    {
        return ((delegate* unmanaged<IPin, PIN_INFO*, int>)((*lpVtbl)[8]))(this, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT QueryDirection(PIN_DIRECTION* pPinDir)
    {
        return ((delegate* unmanaged<IPin, PIN_DIRECTION*, int>)((*lpVtbl)[9]))(this, pPinDir);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT QueryId([NativeTypeName("LPWSTR *")] ushort** Id)
    {
        return ((delegate* unmanaged<IPin, ushort**, int>)((*lpVtbl)[10]))(this, Id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT QueryAccept([NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IPin, AM_MEDIA_TYPE*, int>)((*lpVtbl)[11]))(this, pmt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnumMediaTypes(IEnumMediaTypes* ppEnum)
    {
        return ((delegate* unmanaged<IPin, IEnumMediaTypes*, int>)((*lpVtbl)[12]))(this, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT QueryInternalConnections(IPin* apPin, [NativeTypeName("ULONG *")] uint* nPin)
    {
        return ((delegate* unmanaged<IPin, IPin*, uint*, int>)((*lpVtbl)[13]))(this, apPin, nPin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EndOfStream()
    {
        return ((delegate* unmanaged<IPin, int>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT BeginFlush()
    {
        return ((delegate* unmanaged<IPin, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EndFlush()
    {
        return ((delegate* unmanaged<IPin, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT NewSegment(
        [NativeTypeName("REFERENCE_TIME")] long tStart,
        [NativeTypeName("REFERENCE_TIME")] long tStop,
        double dRate
    )
    {
        return ((delegate* unmanaged<IPin, long, long, double, int>)((*lpVtbl)[17]))(
            this,
            tStart,
            tStop,
            dRate
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Connect(
            IPin pReceivePin,
            [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt
        );

        [VtblIndex(4)]
        HRESULT ReceiveConnection(
            IPin pConnector,
            [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt
        );

        [VtblIndex(5)]
        HRESULT Disconnect();

        [VtblIndex(6)]
        HRESULT ConnectedTo(IPin* pPin);

        [VtblIndex(7)]
        HRESULT ConnectionMediaType(AM_MEDIA_TYPE* pmt);

        [VtblIndex(8)]
        HRESULT QueryPinInfo(PIN_INFO* pInfo);

        [VtblIndex(9)]
        HRESULT QueryDirection(PIN_DIRECTION* pPinDir);

        [VtblIndex(10)]
        HRESULT QueryId([NativeTypeName("LPWSTR *")] ushort** Id);

        [VtblIndex(11)]
        HRESULT QueryAccept([NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt);

        [VtblIndex(12)]
        HRESULT EnumMediaTypes(IEnumMediaTypes* ppEnum);

        [VtblIndex(13)]
        HRESULT QueryInternalConnections(IPin* apPin, [NativeTypeName("ULONG *")] uint* nPin);

        [VtblIndex(14)]
        HRESULT EndOfStream();

        [VtblIndex(15)]
        HRESULT BeginFlush();

        [VtblIndex(16)]
        HRESULT EndFlush();

        [VtblIndex(17)]
        HRESULT NewSegment(
            [NativeTypeName("REFERENCE_TIME")] long tStart,
            [NativeTypeName("REFERENCE_TIME")] long tStop,
            double dRate
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

        [NativeTypeName("HRESULT (IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin, AM_MEDIA_TYPE*, int> Connect;

        [NativeTypeName("HRESULT (IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin, AM_MEDIA_TYPE*, int> ReceiveConnection;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Disconnect;

        [NativeTypeName("HRESULT (IPin **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, int> ConnectedTo;

        [NativeTypeName("HRESULT (AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AM_MEDIA_TYPE*, int> ConnectionMediaType;

        [NativeTypeName("HRESULT (PIN_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PIN_INFO*, int> QueryPinInfo;

        [NativeTypeName("HRESULT (PIN_DIRECTION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PIN_DIRECTION*, int> QueryDirection;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> QueryId;

        [NativeTypeName("HRESULT (const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AM_MEDIA_TYPE*, int> QueryAccept;

        [NativeTypeName("HRESULT (IEnumMediaTypes **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumMediaTypes*, int> EnumMediaTypes;

        [NativeTypeName("HRESULT (IPin **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, uint*, int> QueryInternalConnections;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndOfStream;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> BeginFlush;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndFlush;

        [NativeTypeName(
            "HRESULT (REFERENCE_TIME, REFERENCE_TIME, double) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, long, long, double, int> NewSegment;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPin"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPin(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPin"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPin(Silk.NET.Windows.IUnknown value)
    {
        return new IPin(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPin"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPin"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPin value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
