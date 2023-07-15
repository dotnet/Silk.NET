// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream"]/*'/>
[Guid("AD4C1B00-4BF7-422F-9175-756693D9130D")]
[NativeTypeName("struct IMFByteStream : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFByteStream : IMFByteStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFByteStream));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFByteStream*, Guid*, void**, int> )(lpVtbl[0]))((IMFByteStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFByteStream*, uint> )(lpVtbl[1]))((IMFByteStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFByteStream*, uint> )(lpVtbl[2]))((IMFByteStream*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.GetCapabilities"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCapabilities([NativeTypeName("DWORD *")] uint* pdwCapabilities)
    {
        return ((delegate* unmanaged<IMFByteStream*, uint*, int> )(lpVtbl[3]))((IMFByteStream*)Unsafe.AsPointer(ref this), pdwCapabilities);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.GetLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLength([NativeTypeName("QWORD *")] ulong* pqwLength)
    {
        return ((delegate* unmanaged<IMFByteStream*, ulong*, int> )(lpVtbl[4]))((IMFByteStream*)Unsafe.AsPointer(ref this), pqwLength);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.SetLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetLength([NativeTypeName("QWORD")] ulong qwLength)
    {
        return ((delegate* unmanaged<IMFByteStream*, ulong, int> )(lpVtbl[5]))((IMFByteStream*)Unsafe.AsPointer(ref this), qwLength);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.GetCurrentPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentPosition([NativeTypeName("QWORD *")] ulong* pqwPosition)
    {
        return ((delegate* unmanaged<IMFByteStream*, ulong*, int> )(lpVtbl[6]))((IMFByteStream*)Unsafe.AsPointer(ref this), pqwPosition);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.SetCurrentPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetCurrentPosition([NativeTypeName("QWORD")] ulong qwPosition)
    {
        return ((delegate* unmanaged<IMFByteStream*, ulong, int> )(lpVtbl[7]))((IMFByteStream*)Unsafe.AsPointer(ref this), qwPosition);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.IsEndOfStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsEndOfStream(BOOL* pfEndOfStream)
    {
        return ((delegate* unmanaged<IMFByteStream*, BOOL*, int> )(lpVtbl[8]))((IMFByteStream*)Unsafe.AsPointer(ref this), pfEndOfStream);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.Read"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Read(byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
    {
        return ((delegate* unmanaged<IMFByteStream*, byte*, uint, uint*, int> )(lpVtbl[9]))((IMFByteStream*)Unsafe.AsPointer(ref this), pb, cb, pcbRead);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.BeginRead"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT BeginRead(byte* pb, [NativeTypeName("ULONG")] uint cb, IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFByteStream*, byte*, uint, IMFAsyncCallback*, IUnknown*, int> )(lpVtbl[10]))((IMFByteStream*)Unsafe.AsPointer(ref this), pb, cb, pCallback, punkState);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.EndRead"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EndRead(IMFAsyncResult* pResult, [NativeTypeName("ULONG *")] uint* pcbRead)
    {
        return ((delegate* unmanaged<IMFByteStream*, IMFAsyncResult*, uint*, int> )(lpVtbl[11]))((IMFByteStream*)Unsafe.AsPointer(ref this), pResult, pcbRead);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.Write"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Write([NativeTypeName("const BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
    {
        return ((delegate* unmanaged<IMFByteStream*, byte*, uint, uint*, int> )(lpVtbl[12]))((IMFByteStream*)Unsafe.AsPointer(ref this), pb, cb, pcbWritten);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.BeginWrite"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT BeginWrite([NativeTypeName("const BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFByteStream*, byte*, uint, IMFAsyncCallback*, IUnknown*, int> )(lpVtbl[13]))((IMFByteStream*)Unsafe.AsPointer(ref this), pb, cb, pCallback, punkState);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.EndWrite"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EndWrite(IMFAsyncResult* pResult, [NativeTypeName("ULONG *")] uint* pcbWritten)
    {
        return ((delegate* unmanaged<IMFByteStream*, IMFAsyncResult*, uint*, int> )(lpVtbl[14]))((IMFByteStream*)Unsafe.AsPointer(ref this), pResult, pcbWritten);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.Seek"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Seek(MFBYTESTREAM_SEEK_ORIGIN SeekOrigin, [NativeTypeName("LONGLONG")] long llSeekOffset, [NativeTypeName("DWORD")] uint dwSeekFlags, [NativeTypeName("QWORD *")] ulong* pqwCurrentPosition)
    {
        return ((delegate* unmanaged<IMFByteStream*, MFBYTESTREAM_SEEK_ORIGIN, long, uint, ulong*, int> )(lpVtbl[15]))((IMFByteStream*)Unsafe.AsPointer(ref this), SeekOrigin, llSeekOffset, dwSeekFlags, pqwCurrentPosition);
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.Flush"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<IMFByteStream*, int> )(lpVtbl[16]))((IMFByteStream*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFByteStream.xml' path='doc/member[@name="IMFByteStream.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IMFByteStream*, int> )(lpVtbl[17]))((IMFByteStream*)Unsafe.AsPointer(ref this));
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
        HRESULT Read(byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead);
        [VtblIndex(10)]
        HRESULT BeginRead(byte* pb, [NativeTypeName("ULONG")] uint cb, IMFAsyncCallback* pCallback, IUnknown* punkState);
        [VtblIndex(11)]
        HRESULT EndRead(IMFAsyncResult* pResult, [NativeTypeName("ULONG *")] uint* pcbRead);
        [VtblIndex(12)]
        HRESULT Write([NativeTypeName("const BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten);
        [VtblIndex(13)]
        HRESULT BeginWrite([NativeTypeName("const BYTE *")] byte* pb, [NativeTypeName("ULONG")] uint cb, IMFAsyncCallback* pCallback, IUnknown* punkState);
        [VtblIndex(14)]
        HRESULT EndWrite(IMFAsyncResult* pResult, [NativeTypeName("ULONG *")] uint* pcbWritten);
        [VtblIndex(15)]
        HRESULT Seek(MFBYTESTREAM_SEEK_ORIGIN SeekOrigin, [NativeTypeName("LONGLONG")] long llSeekOffset, [NativeTypeName("DWORD")] uint dwSeekFlags, [NativeTypeName("QWORD *")] ulong* pqwCurrentPosition);
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
        [NativeTypeName("HRESULT (BYTE *, ULONG, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, IMFAsyncCallback*, IUnknown*, int> BeginRead;
        [NativeTypeName("HRESULT (IMFAsyncResult *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, uint*, int> EndRead;
        [NativeTypeName("HRESULT (const BYTE *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, uint*, int> Write;
        [NativeTypeName("HRESULT (const BYTE *, ULONG, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, IMFAsyncCallback*, IUnknown*, int> BeginWrite;
        [NativeTypeName("HRESULT (IMFAsyncResult *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, uint*, int> EndWrite;
        [NativeTypeName("HRESULT (MFBYTESTREAM_SEEK_ORIGIN, LONGLONG, DWORD, QWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFBYTESTREAM_SEEK_ORIGIN, long, uint, ulong*, int> Seek;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Flush;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }
}