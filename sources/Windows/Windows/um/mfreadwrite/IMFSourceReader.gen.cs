// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFSourceReader.xml' path='doc/member[@name="IMFSourceReader"]/*'/>
[Guid("70AE66F2-C809-4E4F-8915-BDCB406B7993")]
[NativeTypeName("struct IMFSourceReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSourceReader : IMFSourceReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSourceReader));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSourceReader*, Guid*, void**, int> )(lpVtbl[0]))((IMFSourceReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSourceReader*, uint> )(lpVtbl[1]))((IMFSourceReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSourceReader*, uint> )(lpVtbl[2]))((IMFSourceReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceReader.xml' path='doc/member[@name="IMFSourceReader.GetStreamSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pfSelected)
    {
        return ((delegate* unmanaged<IMFSourceReader*, uint, BOOL*, int> )(lpVtbl[3]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, pfSelected);
    }

    /// <include file='IMFSourceReader.xml' path='doc/member[@name="IMFSourceReader.SetStreamSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fSelected)
    {
        return ((delegate* unmanaged<IMFSourceReader*, uint, BOOL, int> )(lpVtbl[4]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, fSelected);
    }

    /// <include file='IMFSourceReader.xml' path='doc/member[@name="IMFSourceReader.GetNativeMediaType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetNativeMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwMediaTypeIndex, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFSourceReader*, uint, uint, IMFMediaType**, int> )(lpVtbl[5]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, dwMediaTypeIndex, ppMediaType);
    }

    /// <include file='IMFSourceReader.xml' path='doc/member[@name="IMFSourceReader.GetCurrentMediaType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFSourceReader*, uint, IMFMediaType**, int> )(lpVtbl[6]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, ppMediaType);
    }

    /// <include file='IMFSourceReader.xml' path='doc/member[@name="IMFSourceReader.SetCurrentMediaType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, IMFMediaType* pMediaType)
    {
        return ((delegate* unmanaged<IMFSourceReader*, uint, uint*, IMFMediaType*, int> )(lpVtbl[7]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, pdwReserved, pMediaType);
    }

    /// <include file='IMFSourceReader.xml' path='doc/member[@name="IMFSourceReader.SetCurrentPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetCurrentPosition([NativeTypeName("const GUID &")] Guid* guidTimeFormat, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* varPosition)
    {
        return ((delegate* unmanaged<IMFSourceReader*, Guid*, PROPVARIANT*, int> )(lpVtbl[8]))((IMFSourceReader*)Unsafe.AsPointer(ref this), guidTimeFormat, varPosition);
    }

    /// <include file='IMFSourceReader.xml' path='doc/member[@name="IMFSourceReader.ReadSample"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReadSample([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwControlFlags, [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex, [NativeTypeName("DWORD *")] uint* pdwStreamFlags, [NativeTypeName("LONGLONG *")] long* pllTimestamp, IMFSample** ppSample)
    {
        return ((delegate* unmanaged<IMFSourceReader*, uint, uint, uint*, uint*, long*, IMFSample**, int> )(lpVtbl[9]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, dwControlFlags, pdwActualStreamIndex, pdwStreamFlags, pllTimestamp, ppSample);
    }

    /// <include file='IMFSourceReader.xml' path='doc/member[@name="IMFSourceReader.Flush"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Flush([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSourceReader*, uint, int> )(lpVtbl[10]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex);
    }

    /// <include file='IMFSourceReader.xml' path='doc/member[@name="IMFSourceReader.GetServiceForStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetServiceForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSourceReader*, uint, Guid*, Guid*, void**, int> )(lpVtbl[11]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, guidService, riid, ppvObject);
    }

    /// <include file='IMFSourceReader.xml' path='doc/member[@name="IMFSourceReader.GetPresentationAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPresentationAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidAttribute, PROPVARIANT* pvarAttribute)
    {
        return ((delegate* unmanaged<IMFSourceReader*, uint, Guid*, PROPVARIANT*, int> )(lpVtbl[12]))((IMFSourceReader*)Unsafe.AsPointer(ref this), dwStreamIndex, guidAttribute, pvarAttribute);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pfSelected);
        [VtblIndex(4)]
        HRESULT SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fSelected);
        [VtblIndex(5)]
        HRESULT GetNativeMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwMediaTypeIndex, IMFMediaType** ppMediaType);
        [VtblIndex(6)]
        HRESULT GetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType** ppMediaType);
        [VtblIndex(7)]
        HRESULT SetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, IMFMediaType* pMediaType);
        [VtblIndex(8)]
        HRESULT SetCurrentPosition([NativeTypeName("const GUID &")] Guid* guidTimeFormat, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* varPosition);
        [VtblIndex(9)]
        HRESULT ReadSample([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwControlFlags, [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex, [NativeTypeName("DWORD *")] uint* pdwStreamFlags, [NativeTypeName("LONGLONG *")] long* pllTimestamp, IMFSample** ppSample);
        [VtblIndex(10)]
        HRESULT Flush([NativeTypeName("DWORD")] uint dwStreamIndex);
        [VtblIndex(11)]
        HRESULT GetServiceForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);
        [VtblIndex(12)]
        HRESULT GetPresentationAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidAttribute, PROPVARIANT* pvarAttribute);
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
        [NativeTypeName("HRESULT (DWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> GetStreamSelection;
        [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, int> SetStreamSelection;
        [NativeTypeName("HRESULT (DWORD, DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IMFMediaType**, int> GetNativeMediaType;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType**, int> GetCurrentMediaType;
        [NativeTypeName("HRESULT (DWORD, DWORD *, IMFMediaType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, IMFMediaType*, int> SetCurrentMediaType;
        [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> SetCurrentPosition;
        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *, DWORD *, LONGLONG *, IMFSample **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint*, uint*, long*, IMFSample**, int> ReadSample;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Flush;
        [NativeTypeName("HRESULT (DWORD, const GUID &, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, void**, int> GetServiceForStream;
        [NativeTypeName("HRESULT (DWORD, const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, PROPVARIANT*, int> GetPresentationAttribute;
    }
}