// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFSourceReaderEx.xml' path='doc/member[@name="IMFSourceReaderEx"]/*' />
[Guid("7B981CF0-560E-4116-9875-B099895F23D7")]
[NativeTypeName("struct IMFSourceReaderEx : IMFSourceReader")]
[NativeInheritance("IMFSourceReader")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFSourceReaderEx : IMFSourceReaderEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSourceReaderEx));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint>)(lpVtbl[1]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint>)(lpVtbl[2]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFSourceReader.GetStreamSelection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL* pfSelected)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, BOOL*, int>)(lpVtbl[3]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pfSelected);
    }

    /// <inheritdoc cref="IMFSourceReader.SetStreamSelection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fSelected)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, BOOL, int>)(lpVtbl[4]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, fSelected);
    }

    /// <inheritdoc cref="IMFSourceReader.GetNativeMediaType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetNativeMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwMediaTypeIndex, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, uint, IMFMediaType**, int>)(lpVtbl[5]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, dwMediaTypeIndex, ppMediaType);
    }

    /// <inheritdoc cref="IMFSourceReader.GetCurrentMediaType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, IMFMediaType**, int>)(lpVtbl[6]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, ppMediaType);
    }

    /// <inheritdoc cref="IMFSourceReader.SetCurrentMediaType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetCurrentMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD *")] uint* pdwReserved, IMFMediaType* pMediaType)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, uint*, IMFMediaType*, int>)(lpVtbl[7]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pdwReserved, pMediaType);
    }

    /// <inheritdoc cref="IMFSourceReader.SetCurrentPosition" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetCurrentPosition([NativeTypeName("const GUID &")] Guid* guidTimeFormat, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* varPosition)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, Guid*, PROPVARIANT*, int>)(lpVtbl[8]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), guidTimeFormat, varPosition);
    }

    /// <inheritdoc cref="IMFSourceReader.ReadSample" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReadSample([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwControlFlags, [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex, [NativeTypeName("DWORD *")] uint* pdwStreamFlags, [NativeTypeName("LONGLONG *")] long* pllTimestamp, IMFSample** ppSample)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, uint, uint*, uint*, long*, IMFSample**, int>)(lpVtbl[9]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, dwControlFlags, pdwActualStreamIndex, pdwStreamFlags, pllTimestamp, ppSample);
    }

    /// <inheritdoc cref="IMFSourceReader.Flush" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Flush([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, int>)(lpVtbl[10]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex);
    }

    /// <inheritdoc cref="IMFSourceReader.GetServiceForStream" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetServiceForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, Guid*, Guid*, void**, int>)(lpVtbl[11]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, guidService, riid, ppvObject);
    }

    /// <inheritdoc cref="IMFSourceReader.GetPresentationAttribute" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPresentationAttribute([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("const GUID &")] Guid* guidAttribute, PROPVARIANT* pvarAttribute)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[12]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, guidAttribute, pvarAttribute);
    }

    /// <include file='IMFSourceReaderEx.xml' path='doc/member[@name="IMFSourceReaderEx.SetNativeMediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetNativeMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType* pMediaType, [NativeTypeName("DWORD *")] uint* pdwStreamFlags)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, IMFMediaType*, uint*, int>)(lpVtbl[13]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pMediaType, pdwStreamFlags);
    }

    /// <include file='IMFSourceReaderEx.xml' path='doc/member[@name="IMFSourceReaderEx.AddTransformForStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT AddTransformForStream([NativeTypeName("DWORD")] uint dwStreamIndex, IUnknown* pTransformOrActivate)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, IUnknown*, int>)(lpVtbl[14]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, pTransformOrActivate);
    }

    /// <include file='IMFSourceReaderEx.xml' path='doc/member[@name="IMFSourceReaderEx.RemoveAllTransformsForStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT RemoveAllTransformsForStream([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, int>)(lpVtbl[15]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex);
    }

    /// <include file='IMFSourceReaderEx.xml' path='doc/member[@name="IMFSourceReaderEx.GetTransformForStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetTransformForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwTransformIndex, Guid* pGuidCategory, IMFTransform** ppTransform)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx*, uint, uint, Guid*, IMFTransform**, int>)(lpVtbl[16]))((IMFSourceReaderEx*)Unsafe.AsPointer(ref this), dwStreamIndex, dwTransformIndex, pGuidCategory, ppTransform);
    }

    public interface Interface : IMFSourceReader.Interface
    {
        [VtblIndex(13)]
        HRESULT SetNativeMediaType([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaType* pMediaType, [NativeTypeName("DWORD *")] uint* pdwStreamFlags);

        [VtblIndex(14)]
        HRESULT AddTransformForStream([NativeTypeName("DWORD")] uint dwStreamIndex, IUnknown* pTransformOrActivate);

        [VtblIndex(15)]
        HRESULT RemoveAllTransformsForStream([NativeTypeName("DWORD")] uint dwStreamIndex);

        [VtblIndex(16)]
        HRESULT GetTransformForStream([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwTransformIndex, Guid* pGuidCategory, IMFTransform** ppTransform);
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

        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, uint*, int> SetNativeMediaType;

        [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown*, int> AddTransformForStream;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveAllTransformsForStream;

        [NativeTypeName("HRESULT (DWORD, DWORD, GUID *, IMFTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, Guid*, IMFTransform**, int> GetTransformForStream;
    }
}
