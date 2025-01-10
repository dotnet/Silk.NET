// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7B981CF0-560E-4116-9875-B099895F23D7")]
[NativeTypeName("struct IMFSourceReaderEx : IMFSourceReader")]
[NativeInheritance("IMFSourceReader")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFSourceReaderEx : IMFSourceReaderEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSourceReaderEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSourceReaderEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSourceReaderEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStreamSelection(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        BOOL* pfSelected
    )
    {
        return ((delegate* unmanaged<IMFSourceReaderEx, uint, BOOL*, int>)((*lpVtbl)[3]))(
            this,
            dwStreamIndex,
            pfSelected
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetStreamSelection([NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fSelected)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx, uint, BOOL, int>)((*lpVtbl)[4]))(
            this,
            dwStreamIndex,
            fSelected
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetNativeMediaType(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        [NativeTypeName("DWORD")] uint dwMediaTypeIndex,
        IMFMediaType* ppMediaType
    )
    {
        return (
            (delegate* unmanaged<IMFSourceReaderEx, uint, uint, IMFMediaType*, int>)((*lpVtbl)[5])
        )(this, dwStreamIndex, dwMediaTypeIndex, ppMediaType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentMediaType(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        IMFMediaType* ppMediaType
    )
    {
        return ((delegate* unmanaged<IMFSourceReaderEx, uint, IMFMediaType*, int>)((*lpVtbl)[6]))(
            this,
            dwStreamIndex,
            ppMediaType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetCurrentMediaType(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        [NativeTypeName("DWORD *")] uint* pdwReserved,
        IMFMediaType pMediaType
    )
    {
        return (
            (delegate* unmanaged<IMFSourceReaderEx, uint, uint*, IMFMediaType, int>)((*lpVtbl)[7])
        )(this, dwStreamIndex, pdwReserved, pMediaType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetCurrentPosition(
        [NativeTypeName("const GUID &")] Guid* guidTimeFormat,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* varPosition
    )
    {
        return ((delegate* unmanaged<IMFSourceReaderEx, Guid*, PROPVARIANT*, int>)((*lpVtbl)[8]))(
            this,
            guidTimeFormat,
            varPosition
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReadSample(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        [NativeTypeName("DWORD")] uint dwControlFlags,
        [NativeTypeName("DWORD *")] uint* pdwActualStreamIndex,
        [NativeTypeName("DWORD *")] uint* pdwStreamFlags,
        [NativeTypeName("LONGLONG *")] long* pllTimestamp,
        IMFSample* ppSample
    )
    {
        return (
            (delegate* unmanaged<
                IMFSourceReaderEx,
                uint,
                uint,
                uint*,
                uint*,
                long*,
                IMFSample*,
                int>)((*lpVtbl)[9])
        )(
            this,
            dwStreamIndex,
            dwControlFlags,
            pdwActualStreamIndex,
            pdwStreamFlags,
            pllTimestamp,
            ppSample
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Flush([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx, uint, int>)((*lpVtbl)[10]))(
            this,
            dwStreamIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetServiceForStream(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        [NativeTypeName("const GUID &")] Guid* guidService,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<IMFSourceReaderEx, uint, Guid*, Guid*, void**, int>)((*lpVtbl)[11])
        )(this, dwStreamIndex, guidService, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPresentationAttribute(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        [NativeTypeName("const GUID &")] Guid* guidAttribute,
        PROPVARIANT* pvarAttribute
    )
    {
        return (
            (delegate* unmanaged<IMFSourceReaderEx, uint, Guid*, PROPVARIANT*, int>)((*lpVtbl)[12])
        )(this, dwStreamIndex, guidAttribute, pvarAttribute);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetNativeMediaType(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        IMFMediaType pMediaType,
        [NativeTypeName("DWORD *")] uint* pdwStreamFlags
    )
    {
        return (
            (delegate* unmanaged<IMFSourceReaderEx, uint, IMFMediaType, uint*, int>)((*lpVtbl)[13])
        )(this, dwStreamIndex, pMediaType, pdwStreamFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT AddTransformForStream(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        IUnknown pTransformOrActivate
    )
    {
        return ((delegate* unmanaged<IMFSourceReaderEx, uint, IUnknown, int>)((*lpVtbl)[14]))(
            this,
            dwStreamIndex,
            pTransformOrActivate
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT RemoveAllTransformsForStream([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFSourceReaderEx, uint, int>)((*lpVtbl)[15]))(
            this,
            dwStreamIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetTransformForStream(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        [NativeTypeName("DWORD")] uint dwTransformIndex,
        Guid* pGuidCategory,
        IMFTransform* ppTransform
    )
    {
        return (
            (delegate* unmanaged<IMFSourceReaderEx, uint, uint, Guid*, IMFTransform*, int>)(
                (*lpVtbl)[16]
            )
        )(this, dwStreamIndex, dwTransformIndex, pGuidCategory, ppTransform);
    }

    public interface Interface : IMFSourceReader.Interface
    {
        [VtblIndex(13)]
        HRESULT SetNativeMediaType(
            [NativeTypeName("DWORD")] uint dwStreamIndex,
            IMFMediaType pMediaType,
            [NativeTypeName("DWORD *")] uint* pdwStreamFlags
        );

        [VtblIndex(14)]
        HRESULT AddTransformForStream(
            [NativeTypeName("DWORD")] uint dwStreamIndex,
            IUnknown pTransformOrActivate
        );

        [VtblIndex(15)]
        HRESULT RemoveAllTransformsForStream([NativeTypeName("DWORD")] uint dwStreamIndex);

        [VtblIndex(16)]
        HRESULT GetTransformForStream(
            [NativeTypeName("DWORD")] uint dwStreamIndex,
            [NativeTypeName("DWORD")] uint dwTransformIndex,
            Guid* pGuidCategory,
            IMFTransform* ppTransform
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

        [NativeTypeName("HRESULT (DWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> GetStreamSelection;

        [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, int> SetStreamSelection;

        [NativeTypeName("HRESULT (DWORD, DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IMFMediaType*, int> GetNativeMediaType;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, int> GetCurrentMediaType;

        [NativeTypeName("HRESULT (DWORD, DWORD *, IMFMediaType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, IMFMediaType, int> SetCurrentMediaType;

        [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> SetCurrentPosition;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, DWORD *, DWORD *, LONGLONG *, IMFSample **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            uint*,
            uint*,
            long*,
            IMFSample*,
            int> ReadSample;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Flush;

        [NativeTypeName(
            "HRESULT (DWORD, const GUID &, const IID &, LPVOID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, void**, int> GetServiceForStream;

        [NativeTypeName("HRESULT (DWORD, const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, PROPVARIANT*, int> GetPresentationAttribute;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType, uint*, int> SetNativeMediaType;

        [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown, int> AddTransformForStream;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveAllTransformsForStream;

        [NativeTypeName("HRESULT (DWORD, DWORD, GUID *, IMFTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            Guid*,
            IMFTransform*,
            int> GetTransformForStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSourceReaderEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSourceReaderEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFSourceReader"/> to <see cref = "IMFSourceReaderEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFSourceReader"/> instance to be converted </param>
    public static explicit operator IMFSourceReaderEx(Silk.NET.Windows.IMFSourceReader value)
    {
        return new IMFSourceReaderEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSourceReaderEx"/> to <see cref = "Silk.NET.Windows.IMFSourceReader"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSourceReaderEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFSourceReader(IMFSourceReaderEx value)
    {
        return new Silk.NET.Windows.IMFSourceReader(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSourceReaderEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSourceReaderEx(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSourceReaderEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSourceReaderEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSourceReaderEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSourceReaderEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
