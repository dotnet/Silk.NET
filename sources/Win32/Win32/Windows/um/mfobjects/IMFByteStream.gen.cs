// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AD4C1B00-4BF7-422F-9175-756693D9130D")]
[NativeTypeName("struct IMFByteStream : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFByteStream : IMFByteStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFByteStream));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFByteStream, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFByteStream, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFByteStream, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCapabilities([NativeTypeName("DWORD *")] uint* pdwCapabilities)
    {
        return ((delegate* unmanaged<IMFByteStream, uint*, int>)((*lpVtbl)[3]))(
            this,
            pdwCapabilities
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLength([NativeTypeName("QWORD *")] ulong* pqwLength)
    {
        return ((delegate* unmanaged<IMFByteStream, ulong*, int>)((*lpVtbl)[4]))(this, pqwLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetLength([NativeTypeName("QWORD")] ulong qwLength)
    {
        return ((delegate* unmanaged<IMFByteStream, ulong, int>)((*lpVtbl)[5]))(this, qwLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentPosition([NativeTypeName("QWORD *")] ulong* pqwPosition)
    {
        return ((delegate* unmanaged<IMFByteStream, ulong*, int>)((*lpVtbl)[6]))(this, pqwPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetCurrentPosition([NativeTypeName("QWORD")] ulong qwPosition)
    {
        return ((delegate* unmanaged<IMFByteStream, ulong, int>)((*lpVtbl)[7]))(this, qwPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsEndOfStream(BOOL* pfEndOfStream)
    {
        return ((delegate* unmanaged<IMFByteStream, BOOL*, int>)((*lpVtbl)[8]))(
            this,
            pfEndOfStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Read(
        byte* pb,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbRead
    )
    {
        return ((delegate* unmanaged<IMFByteStream, byte*, uint, uint*, int>)((*lpVtbl)[9]))(
            this,
            pb,
            cb,
            pcbRead
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT BeginRead(
        byte* pb,
        [NativeTypeName("ULONG")] uint cb,
        IMFAsyncCallback pCallback,
        IUnknown punkState
    )
    {
        return (
            (delegate* unmanaged<IMFByteStream, byte*, uint, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[10]
            )
        )(this, pb, cb, pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EndRead(IMFAsyncResult pResult, [NativeTypeName("ULONG *")] uint* pcbRead)
    {
        return ((delegate* unmanaged<IMFByteStream, IMFAsyncResult, uint*, int>)((*lpVtbl)[11]))(
            this,
            pResult,
            pcbRead
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Write(
        [NativeTypeName("const BYTE *")] byte* pb,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbWritten
    )
    {
        return ((delegate* unmanaged<IMFByteStream, byte*, uint, uint*, int>)((*lpVtbl)[12]))(
            this,
            pb,
            cb,
            pcbWritten
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT BeginWrite(
        [NativeTypeName("const BYTE *")] byte* pb,
        [NativeTypeName("ULONG")] uint cb,
        IMFAsyncCallback pCallback,
        IUnknown punkState
    )
    {
        return (
            (delegate* unmanaged<IMFByteStream, byte*, uint, IMFAsyncCallback, IUnknown, int>)(
                (*lpVtbl)[13]
            )
        )(this, pb, cb, pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EndWrite(IMFAsyncResult pResult, [NativeTypeName("ULONG *")] uint* pcbWritten)
    {
        return ((delegate* unmanaged<IMFByteStream, IMFAsyncResult, uint*, int>)((*lpVtbl)[14]))(
            this,
            pResult,
            pcbWritten
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Seek(
        MFBYTESTREAM_SEEK_ORIGIN SeekOrigin,
        [NativeTypeName("LONGLONG")] long llSeekOffset,
        [NativeTypeName("DWORD")] uint dwSeekFlags,
        [NativeTypeName("QWORD *")] ulong* pqwCurrentPosition
    )
    {
        return (
            (delegate* unmanaged<IMFByteStream, MFBYTESTREAM_SEEK_ORIGIN, long, uint, ulong*, int>)(
                (*lpVtbl)[15]
            )
        )(this, SeekOrigin, llSeekOffset, dwSeekFlags, pqwCurrentPosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<IMFByteStream, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IMFByteStream, int>)((*lpVtbl)[17]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCapabilities([NativeTypeName("DWORD *")] uint* pdwCapabilities);

        [VtblIndex(4)]
        HRESULT GetLength([NativeTypeName("QWORD *")] ulong* pqwLength);

        [VtblIndex(5)]
        HRESULT SetLength([NativeTypeName("QWORD")] ulong qwLength);

        [VtblIndex(6)]
        HRESULT GetCurrentPosition([NativeTypeName("QWORD *")] ulong* pqwPosition);

        [VtblIndex(7)]
        HRESULT SetCurrentPosition([NativeTypeName("QWORD")] ulong qwPosition);

        [VtblIndex(8)]
        HRESULT IsEndOfStream(BOOL* pfEndOfStream);

        [VtblIndex(9)]
        HRESULT Read(
            byte* pb,
            [NativeTypeName("ULONG")] uint cb,
            [NativeTypeName("ULONG *")] uint* pcbRead
        );

        [VtblIndex(10)]
        HRESULT BeginRead(
            byte* pb,
            [NativeTypeName("ULONG")] uint cb,
            IMFAsyncCallback pCallback,
            IUnknown punkState
        );

        [VtblIndex(11)]
        HRESULT EndRead(IMFAsyncResult pResult, [NativeTypeName("ULONG *")] uint* pcbRead);

        [VtblIndex(12)]
        HRESULT Write(
            [NativeTypeName("const BYTE *")] byte* pb,
            [NativeTypeName("ULONG")] uint cb,
            [NativeTypeName("ULONG *")] uint* pcbWritten
        );

        [VtblIndex(13)]
        HRESULT BeginWrite(
            [NativeTypeName("const BYTE *")] byte* pb,
            [NativeTypeName("ULONG")] uint cb,
            IMFAsyncCallback pCallback,
            IUnknown punkState
        );

        [VtblIndex(14)]
        HRESULT EndWrite(IMFAsyncResult pResult, [NativeTypeName("ULONG *")] uint* pcbWritten);

        [VtblIndex(15)]
        HRESULT Seek(
            MFBYTESTREAM_SEEK_ORIGIN SeekOrigin,
            [NativeTypeName("LONGLONG")] long llSeekOffset,
            [NativeTypeName("DWORD")] uint dwSeekFlags,
            [NativeTypeName("QWORD *")] ulong* pqwCurrentPosition
        );

        [VtblIndex(16)]
        HRESULT Flush();

        [VtblIndex(17)]
        HRESULT Close();
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
        public delegate* unmanaged<TSelf*, uint*, int> GetCapabilities;

        [NativeTypeName("HRESULT (QWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetLength;

        [NativeTypeName("HRESULT (QWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> SetLength;

        [NativeTypeName("HRESULT (QWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetCurrentPosition;

        [NativeTypeName("HRESULT (QWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> SetCurrentPosition;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsEndOfStream;

        [NativeTypeName("HRESULT (BYTE *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, uint*, int> Read;

        [NativeTypeName(
            "HRESULT (BYTE *, ULONG, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte*, uint, IMFAsyncCallback, IUnknown, int> BeginRead;

        [NativeTypeName("HRESULT (IMFAsyncResult *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult, uint*, int> EndRead;

        [NativeTypeName("HRESULT (const BYTE *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, uint*, int> Write;

        [NativeTypeName(
            "HRESULT (const BYTE *, ULONG, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte*, uint, IMFAsyncCallback, IUnknown, int> BeginWrite;

        [NativeTypeName("HRESULT (IMFAsyncResult *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult, uint*, int> EndWrite;

        [NativeTypeName(
            "HRESULT (MFBYTESTREAM_SEEK_ORIGIN, LONGLONG, DWORD, QWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MFBYTESTREAM_SEEK_ORIGIN, long, uint, ulong*, int> Seek;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Flush;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFByteStream"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFByteStream(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFByteStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFByteStream(Silk.NET.Windows.IUnknown value)
    {
        return new IMFByteStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFByteStream"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFByteStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFByteStream value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
