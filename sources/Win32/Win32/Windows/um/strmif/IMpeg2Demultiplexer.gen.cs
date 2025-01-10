// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("436EEE9C-264F-4242-90E1-4E330C107512")]
[NativeTypeName("struct IMpeg2Demultiplexer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMpeg2Demultiplexer : IMpeg2Demultiplexer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMpeg2Demultiplexer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMpeg2Demultiplexer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMpeg2Demultiplexer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMpeg2Demultiplexer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateOutputPin(
        AM_MEDIA_TYPE* pMediaType,
        [NativeTypeName("LPWSTR")] ushort* pszPinName,
        IPin* ppIPin
    )
    {
        return (
            (delegate* unmanaged<IMpeg2Demultiplexer, AM_MEDIA_TYPE*, ushort*, IPin*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pMediaType, pszPinName, ppIPin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOutputPinMediaType(
        [NativeTypeName("LPWSTR")] ushort* pszPinName,
        AM_MEDIA_TYPE* pMediaType
    )
    {
        return (
            (delegate* unmanaged<IMpeg2Demultiplexer, ushort*, AM_MEDIA_TYPE*, int>)((*lpVtbl)[4])
        )(this, pszPinName, pMediaType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DeleteOutputPin([NativeTypeName("LPWSTR")] ushort* pszPinName)
    {
        return ((delegate* unmanaged<IMpeg2Demultiplexer, ushort*, int>)((*lpVtbl)[5]))(
            this,
            pszPinName
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateOutputPin(
            AM_MEDIA_TYPE* pMediaType,
            [NativeTypeName("LPWSTR")] ushort* pszPinName,
            IPin* ppIPin
        );

        [VtblIndex(4)]
        HRESULT SetOutputPinMediaType(
            [NativeTypeName("LPWSTR")] ushort* pszPinName,
            AM_MEDIA_TYPE* pMediaType
        );

        [VtblIndex(5)]
        HRESULT DeleteOutputPin([NativeTypeName("LPWSTR")] ushort* pszPinName);
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

        [NativeTypeName("HRESULT (AM_MEDIA_TYPE *, LPWSTR, IPin **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AM_MEDIA_TYPE*, ushort*, IPin*, int> CreateOutputPin;

        [NativeTypeName("HRESULT (LPWSTR, AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, AM_MEDIA_TYPE*, int> SetOutputPinMediaType;

        [NativeTypeName("HRESULT (LPWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> DeleteOutputPin;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMpeg2Demultiplexer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMpeg2Demultiplexer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMpeg2Demultiplexer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMpeg2Demultiplexer(Silk.NET.Windows.IUnknown value)
    {
        return new IMpeg2Demultiplexer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMpeg2Demultiplexer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMpeg2Demultiplexer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMpeg2Demultiplexer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
