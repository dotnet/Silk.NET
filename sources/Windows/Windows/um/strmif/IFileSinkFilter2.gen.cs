// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IFileSinkFilter2.xml' path='doc/member[@name="IFileSinkFilter2"]/*' />
[Guid("00855B90-CE1B-11D0-BD4F-00A0C911CE86")]
[NativeTypeName("struct IFileSinkFilter2 : IFileSinkFilter")]
[NativeInheritance("IFileSinkFilter")]
public unsafe partial struct IFileSinkFilter2 : IFileSinkFilter2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSinkFilter2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSinkFilter2*, Guid*, void**, int>)(lpVtbl[0]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileSinkFilter2*, uint>)(lpVtbl[1]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSinkFilter2*, uint>)(lpVtbl[2]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IFileSinkFilter.SetFileName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFileName([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IFileSinkFilter2*, ushort*, AM_MEDIA_TYPE*, int>)(lpVtbl[3]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this), pszFileName, pmt);
    }

    /// <inheritdoc cref="IFileSinkFilter.GetCurFile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName, AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IFileSinkFilter2*, ushort**, AM_MEDIA_TYPE*, int>)(lpVtbl[4]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this), ppszFileName, pmt);
    }

    /// <include file='IFileSinkFilter2.xml' path='doc/member[@name="IFileSinkFilter2.SetMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMode([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IFileSinkFilter2*, uint, int>)(lpVtbl[5]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this), dwFlags);
    }

    /// <include file='IFileSinkFilter2.xml' path='doc/member[@name="IFileSinkFilter2.GetMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMode([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IFileSinkFilter2*, uint*, int>)(lpVtbl[6]))((IFileSinkFilter2*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    public interface Interface : IFileSinkFilter.Interface
    {
        [VtblIndex(5)]
        HRESULT SetMode([NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(6)]
        HRESULT GetMode([NativeTypeName("DWORD *")] uint* pdwFlags);
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

        [NativeTypeName("HRESULT (LPCOLESTR, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, AM_MEDIA_TYPE*, int> SetFileName;

        [NativeTypeName("HRESULT (LPOLESTR *, AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, AM_MEDIA_TYPE*, int> GetCurFile;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetMode;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMode;
    }
}
