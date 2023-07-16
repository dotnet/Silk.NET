// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IFileSinkFilter.xml' path='doc/member[@name="IFileSinkFilter"]/*'/>
[Guid("A2104830-7C70-11CF-8BCE-00AA00A3F1A6")]
[NativeTypeName("struct IFileSinkFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileSinkFilter : IFileSinkFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSinkFilter));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSinkFilter*, Guid*, void**, int> )(lpVtbl[0]))((IFileSinkFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileSinkFilter*, uint> )(lpVtbl[1]))((IFileSinkFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSinkFilter*, uint> )(lpVtbl[2]))((IFileSinkFilter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFileSinkFilter.xml' path='doc/member[@name="IFileSinkFilter.SetFileName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFileName([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IFileSinkFilter*, ushort*, AM_MEDIA_TYPE*, int> )(lpVtbl[3]))((IFileSinkFilter*)Unsafe.AsPointer(ref this), pszFileName, pmt);
    }

    /// <include file='IFileSinkFilter.xml' path='doc/member[@name="IFileSinkFilter.GetCurFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName, AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IFileSinkFilter*, ushort**, AM_MEDIA_TYPE*, int> )(lpVtbl[4]))((IFileSinkFilter*)Unsafe.AsPointer(ref this), ppszFileName, pmt);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetFileName([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt);
        [VtblIndex(4)]
        HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName, AM_MEDIA_TYPE* pmt);
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
    }
}