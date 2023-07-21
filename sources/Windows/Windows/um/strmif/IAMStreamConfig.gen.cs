// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAMStreamConfig.xml' path='doc/member[@name="IAMStreamConfig"]/*' />
[Guid("C6E13340-30AC-11D0-A18C-00A0C9118956")]
[NativeTypeName("struct IAMStreamConfig : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMStreamConfig : IAMStreamConfig.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMStreamConfig));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMStreamConfig*, Guid*, void**, int>)(lpVtbl[0]))((IAMStreamConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMStreamConfig*, uint>)(lpVtbl[1]))((IAMStreamConfig*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMStreamConfig*, uint>)(lpVtbl[2]))((IAMStreamConfig*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMStreamConfig.xml' path='doc/member[@name="IAMStreamConfig.SetFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFormat(AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IAMStreamConfig*, AM_MEDIA_TYPE*, int>)(lpVtbl[3]))((IAMStreamConfig*)Unsafe.AsPointer(ref this), pmt);
    }

    /// <include file='IAMStreamConfig.xml' path='doc/member[@name="IAMStreamConfig.GetFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFormat(AM_MEDIA_TYPE** ppmt)
    {
        return ((delegate* unmanaged<IAMStreamConfig*, AM_MEDIA_TYPE**, int>)(lpVtbl[4]))((IAMStreamConfig*)Unsafe.AsPointer(ref this), ppmt);
    }

    /// <include file='IAMStreamConfig.xml' path='doc/member[@name="IAMStreamConfig.GetNumberOfCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetNumberOfCapabilities(int* piCount, int* piSize)
    {
        return ((delegate* unmanaged<IAMStreamConfig*, int*, int*, int>)(lpVtbl[5]))((IAMStreamConfig*)Unsafe.AsPointer(ref this), piCount, piSize);
    }

    /// <include file='IAMStreamConfig.xml' path='doc/member[@name="IAMStreamConfig.GetStreamCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStreamCaps(int iIndex, AM_MEDIA_TYPE** ppmt, byte* pSCC)
    {
        return ((delegate* unmanaged<IAMStreamConfig*, int, AM_MEDIA_TYPE**, byte*, int>)(lpVtbl[6]))((IAMStreamConfig*)Unsafe.AsPointer(ref this), iIndex, ppmt, pSCC);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetFormat(AM_MEDIA_TYPE* pmt);

        [VtblIndex(4)]
        HRESULT GetFormat(AM_MEDIA_TYPE** ppmt);

        [VtblIndex(5)]
        HRESULT GetNumberOfCapabilities(int* piCount, int* piSize);

        [VtblIndex(6)]
        HRESULT GetStreamCaps(int iIndex, AM_MEDIA_TYPE** ppmt, byte* pSCC);
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

        [NativeTypeName("HRESULT (AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AM_MEDIA_TYPE*, int> SetFormat;

        [NativeTypeName("HRESULT (AM_MEDIA_TYPE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AM_MEDIA_TYPE**, int> GetFormat;

        [NativeTypeName("HRESULT (int *, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int*, int> GetNumberOfCapabilities;

        [NativeTypeName("HRESULT (int, AM_MEDIA_TYPE **, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, AM_MEDIA_TYPE**, byte*, int> GetStreamCaps;
    }
}
