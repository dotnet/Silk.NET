// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6D66D782-1D4F-4DB7-8C63-CB8C77F1EF5E")]
[NativeTypeName("struct IMFByteStreamBuffering : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFByteStreamBuffering : IMFByteStreamBuffering.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFByteStreamBuffering));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFByteStreamBuffering, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFByteStreamBuffering, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFByteStreamBuffering, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBufferingParams(MFBYTESTREAM_BUFFERING_PARAMS* pParams)
    {
        return (
            (delegate* unmanaged<IMFByteStreamBuffering, MFBYTESTREAM_BUFFERING_PARAMS*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pParams);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnableBuffering(BOOL fEnable)
    {
        return ((delegate* unmanaged<IMFByteStreamBuffering, BOOL, int>)((*lpVtbl)[4]))(
            this,
            fEnable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT StopBuffering()
    {
        return ((delegate* unmanaged<IMFByteStreamBuffering, int>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetBufferingParams(MFBYTESTREAM_BUFFERING_PARAMS* pParams);

        [VtblIndex(4)]
        HRESULT EnableBuffering(BOOL fEnable);

        [VtblIndex(5)]
        HRESULT StopBuffering();
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

        [NativeTypeName("HRESULT (MFBYTESTREAM_BUFFERING_PARAMS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFBYTESTREAM_BUFFERING_PARAMS*, int> SetBufferingParams;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> EnableBuffering;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopBuffering;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFByteStreamBuffering"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFByteStreamBuffering(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFByteStreamBuffering"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFByteStreamBuffering(Silk.NET.Windows.IUnknown value)
    {
        return new IMFByteStreamBuffering(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFByteStreamBuffering"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFByteStreamBuffering"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFByteStreamBuffering value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
