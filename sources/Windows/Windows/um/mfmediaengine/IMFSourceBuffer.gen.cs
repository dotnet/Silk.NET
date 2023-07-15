// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer"]/*'/>
[Guid("E2CD3A4B-AF25-4D3D-9110-DA0E6F8EE877")]
[NativeTypeName("struct IMFSourceBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFSourceBuffer : IMFSourceBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSourceBuffer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, Guid*, void**, int> )(lpVtbl[0]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, uint> )(lpVtbl[1]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, uint> )(lpVtbl[2]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer.GetUpdating"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL GetUpdating()
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, int> )(lpVtbl[3]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer.GetBuffered"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBuffered(IMFMediaTimeRange** ppBuffered)
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, IMFMediaTimeRange**, int> )(lpVtbl[4]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), ppBuffered);
    }

    /// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer.GetTimeStampOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public double GetTimeStampOffset()
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, double> )(lpVtbl[5]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer.SetTimeStampOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTimeStampOffset(double offset)
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, double, int> )(lpVtbl[6]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), offset);
    }

    /// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer.GetAppendWindowStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public double GetAppendWindowStart()
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, double> )(lpVtbl[7]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer.SetAppendWindowStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetAppendWindowStart(double time)
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, double, int> )(lpVtbl[8]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), time);
    }

    /// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer.GetAppendWindowEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public double GetAppendWindowEnd()
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, double> )(lpVtbl[9]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer.SetAppendWindowEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetAppendWindowEnd(double time)
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, double, int> )(lpVtbl[10]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), time);
    }

    /// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer.Append"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Append([NativeTypeName("const BYTE *")] byte* pData, [NativeTypeName("DWORD")] uint len)
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, byte*, uint, int> )(lpVtbl[11]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), pData, len);
    }

    /// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer.AppendByteStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AppendByteStream(IMFByteStream* pStream, [NativeTypeName("DWORDLONG *")] ulong* pMaxLen)
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, IMFByteStream*, ulong*, int> )(lpVtbl[12]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), pStream, pMaxLen);
    }

    /// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer.Abort"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Abort()
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, int> )(lpVtbl[13]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceBuffer.xml' path='doc/member[@name="IMFSourceBuffer.Remove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Remove(double start, double end)
    {
        return ((delegate* unmanaged<IMFSourceBuffer*, double, double, int> )(lpVtbl[14]))((IMFSourceBuffer*)Unsafe.AsPointer(ref this), start, end);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        BOOL GetUpdating();
        [VtblIndex(4)]
        HRESULT GetBuffered(IMFMediaTimeRange** ppBuffered);
        [VtblIndex(5)]
        double GetTimeStampOffset();
        [VtblIndex(6)]
        HRESULT SetTimeStampOffset(double offset);
        [VtblIndex(7)]
        double GetAppendWindowStart();
        [VtblIndex(8)]
        HRESULT SetAppendWindowStart(double time);
        [VtblIndex(9)]
        double GetAppendWindowEnd();
        [VtblIndex(10)]
        HRESULT SetAppendWindowEnd(double time);
        [VtblIndex(11)]
        HRESULT Append([NativeTypeName("const BYTE *")] byte* pData, [NativeTypeName("DWORD")] uint len);
        [VtblIndex(12)]
        HRESULT AppendByteStream(IMFByteStream* pStream, [NativeTypeName("DWORDLONG *")] ulong* pMaxLen);
        [VtblIndex(13)]
        HRESULT Abort();
        [VtblIndex(14)]
        HRESULT Remove(double start, double end);
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
        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetUpdating;
        [NativeTypeName("HRESULT (IMFMediaTimeRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaTimeRange**, int> GetBuffered;
        [NativeTypeName("double () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double> GetTimeStampOffset;
        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetTimeStampOffset;
        [NativeTypeName("double () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double> GetAppendWindowStart;
        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetAppendWindowStart;
        [NativeTypeName("double () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double> GetAppendWindowEnd;
        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetAppendWindowEnd;
        [NativeTypeName("HRESULT (const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> Append;
        [NativeTypeName("HRESULT (IMFByteStream *, DWORDLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFByteStream*, ulong*, int> AppendByteStream;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Abort;
        [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, int> Remove;
    }
}