// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5DFD4B2A-7674-4110-A4E6-8A68FD5F3688")]
[NativeTypeName("struct IMFMediaSinkPreroll : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaSinkPreroll : IMFMediaSinkPreroll.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaSinkPreroll));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSinkPreroll, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaSinkPreroll, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSinkPreroll, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT NotifyPreroll([NativeTypeName("MFTIME")] long hnsUpcomingStartTime)
    {
        return ((delegate* unmanaged<IMFMediaSinkPreroll, long, int>)((*lpVtbl)[3]))(
            this,
            hnsUpcomingStartTime
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT NotifyPreroll([NativeTypeName("MFTIME")] long hnsUpcomingStartTime);
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

        [NativeTypeName("HRESULT (MFTIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> NotifyPreroll;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaSinkPreroll"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaSinkPreroll(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaSinkPreroll"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaSinkPreroll(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaSinkPreroll(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaSinkPreroll"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaSinkPreroll"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaSinkPreroll value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
