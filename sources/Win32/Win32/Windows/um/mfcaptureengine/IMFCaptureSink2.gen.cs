// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F9E4219E-6197-4B5E-B888-BEE310AB2C59")]
[NativeTypeName("struct IMFCaptureSink2 : IMFCaptureSink")]
[NativeInheritance("IMFCaptureSink")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFCaptureSink2 : IMFCaptureSink2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCaptureSink2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCaptureSink2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFCaptureSink2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCaptureSink2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOutputMediaType(
        [NativeTypeName("DWORD")] uint dwSinkStreamIndex,
        IMFMediaType* ppMediaType
    )
    {
        return ((delegate* unmanaged<IMFCaptureSink2, uint, IMFMediaType*, int>)((*lpVtbl)[3]))(
            this,
            dwSinkStreamIndex,
            ppMediaType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetService(
        [NativeTypeName("DWORD")] uint dwSinkStreamIndex,
        [NativeTypeName("const GUID &")] Guid* rguidService,
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown* ppUnknown
    )
    {
        return (
            (delegate* unmanaged<IMFCaptureSink2, uint, Guid*, Guid*, IUnknown*, int>)((*lpVtbl)[4])
        )(this, dwSinkStreamIndex, rguidService, riid, ppUnknown);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddStream(
        [NativeTypeName("DWORD")] uint dwSourceStreamIndex,
        IMFMediaType pMediaType,
        IMFAttributes pAttributes,
        [NativeTypeName("DWORD *")] uint* pdwSinkStreamIndex
    )
    {
        return (
            (delegate* unmanaged<IMFCaptureSink2, uint, IMFMediaType, IMFAttributes, uint*, int>)(
                (*lpVtbl)[5]
            )
        )(this, dwSourceStreamIndex, pMediaType, pAttributes, pdwSinkStreamIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Prepare()
    {
        return ((delegate* unmanaged<IMFCaptureSink2, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveAllStreams()
    {
        return ((delegate* unmanaged<IMFCaptureSink2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetOutputMediaType(
        [NativeTypeName("DWORD")] uint dwStreamIndex,
        IMFMediaType pMediaType,
        IMFAttributes pEncodingAttributes
    )
    {
        return (
            (delegate* unmanaged<IMFCaptureSink2, uint, IMFMediaType, IMFAttributes, int>)(
                (*lpVtbl)[8]
            )
        )(this, dwStreamIndex, pMediaType, pEncodingAttributes);
    }

    public interface Interface : IMFCaptureSink.Interface
    {
        [VtblIndex(8)]
        HRESULT SetOutputMediaType(
            [NativeTypeName("DWORD")] uint dwStreamIndex,
            IMFMediaType pMediaType,
            IMFAttributes pEncodingAttributes
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

        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType*, int> GetOutputMediaType;

        [NativeTypeName(
            "HRESULT (DWORD, const GUID &, const IID &, IUnknown **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, IUnknown*, int> GetService;

        [NativeTypeName(
            "HRESULT (DWORD, IMFMediaType *, IMFAttributes *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType, IMFAttributes, uint*, int> AddStream;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Prepare;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllStreams;

        [NativeTypeName(
            "HRESULT (DWORD, IMFMediaType *, IMFAttributes *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IMFMediaType,
            IMFAttributes,
            int> SetOutputMediaType;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFCaptureSink2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFCaptureSink2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFCaptureSink"/> to <see cref = "IMFCaptureSink2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFCaptureSink"/> instance to be converted </param>
    public static explicit operator IMFCaptureSink2(Silk.NET.Windows.IMFCaptureSink value)
    {
        return new IMFCaptureSink2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFCaptureSink2"/> to <see cref = "Silk.NET.Windows.IMFCaptureSink"/>.</summary>
    /// <param name = "value">The <see cref = "IMFCaptureSink2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFCaptureSink(IMFCaptureSink2 value)
    {
        return new Silk.NET.Windows.IMFCaptureSink(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFCaptureSink2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFCaptureSink2(Silk.NET.Windows.IUnknown value)
    {
        return new IMFCaptureSink2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFCaptureSink2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFCaptureSink2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFCaptureSink2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
