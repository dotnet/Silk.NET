// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFMediaTimeRange.xml' path='doc/member[@name="IMFMediaTimeRange"]/*' />
[Guid("DB71A2FC-078A-414E-9DF9-8C2531B0AA6C")]
[NativeTypeName("struct IMFMediaTimeRange : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFMediaTimeRange : IMFMediaTimeRange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaTimeRange));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaTimeRange*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaTimeRange*, uint>)(lpVtbl[1]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaTimeRange*, uint>)(lpVtbl[2]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaTimeRange.xml' path='doc/member[@name="IMFMediaTimeRange.GetLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint GetLength()
    {
        return ((delegate* unmanaged<IMFMediaTimeRange*, uint>)(lpVtbl[3]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaTimeRange.xml' path='doc/member[@name="IMFMediaTimeRange.GetStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStart([NativeTypeName("DWORD")] uint index, double* pStart)
    {
        return ((delegate* unmanaged<IMFMediaTimeRange*, uint, double*, int>)(lpVtbl[4]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this), index, pStart);
    }

    /// <include file='IMFMediaTimeRange.xml' path='doc/member[@name="IMFMediaTimeRange.GetEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEnd([NativeTypeName("DWORD")] uint index, double* pEnd)
    {
        return ((delegate* unmanaged<IMFMediaTimeRange*, uint, double*, int>)(lpVtbl[5]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this), index, pEnd);
    }

    /// <include file='IMFMediaTimeRange.xml' path='doc/member[@name="IMFMediaTimeRange.ContainsTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL ContainsTime(double time)
    {
        return ((delegate* unmanaged<IMFMediaTimeRange*, double, int>)(lpVtbl[6]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this), time);
    }

    /// <include file='IMFMediaTimeRange.xml' path='doc/member[@name="IMFMediaTimeRange.AddRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddRange(double startTime, double endTime)
    {
        return ((delegate* unmanaged<IMFMediaTimeRange*, double, double, int>)(lpVtbl[7]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this), startTime, endTime);
    }

    /// <include file='IMFMediaTimeRange.xml' path='doc/member[@name="IMFMediaTimeRange.Clear"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<IMFMediaTimeRange*, int>)(lpVtbl[8]))((IMFMediaTimeRange*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint GetLength();

        [VtblIndex(4)]
        HRESULT GetStart([NativeTypeName("DWORD")] uint index, double* pStart);

        [VtblIndex(5)]
        HRESULT GetEnd([NativeTypeName("DWORD")] uint index, double* pEnd);

        [VtblIndex(6)]
        BOOL ContainsTime(double time);

        [VtblIndex(7)]
        HRESULT AddRange(double startTime, double endTime);

        [VtblIndex(8)]
        HRESULT Clear();
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

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetLength;

        [NativeTypeName("HRESULT (DWORD, double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, double*, int> GetStart;

        [NativeTypeName("HRESULT (DWORD, double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, double*, int> GetEnd;

        [NativeTypeName("BOOL (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> ContainsTime;

        [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, int> AddRange;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Clear;
    }
}
