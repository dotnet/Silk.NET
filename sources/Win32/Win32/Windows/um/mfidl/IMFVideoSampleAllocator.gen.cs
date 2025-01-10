// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("86CBC910-E533-4751-8E3B-F19B5B806A03")]
[NativeTypeName("struct IMFVideoSampleAllocator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFVideoSampleAllocator
    : IMFVideoSampleAllocator.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFVideoSampleAllocator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocator, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFVideoSampleAllocator, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocator, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDirectXManager(IUnknown pManager)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocator, IUnknown, int>)((*lpVtbl)[3]))(
            this,
            pManager
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UninitializeSampleAllocator()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocator, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InitializeSampleAllocator(
        [NativeTypeName("DWORD")] uint cRequestedFrames,
        IMFMediaType pMediaType
    )
    {
        return (
            (delegate* unmanaged<IMFVideoSampleAllocator, uint, IMFMediaType, int>)((*lpVtbl)[5])
        )(this, cRequestedFrames, pMediaType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AllocateSample(IMFSample* ppSample)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocator, IMFSample*, int>)((*lpVtbl)[6]))(
            this,
            ppSample
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDirectXManager(IUnknown pManager);

        [VtblIndex(4)]
        HRESULT UninitializeSampleAllocator();

        [VtblIndex(5)]
        HRESULT InitializeSampleAllocator(
            [NativeTypeName("DWORD")] uint cRequestedFrames,
            IMFMediaType pMediaType
        );

        [VtblIndex(6)]
        HRESULT AllocateSample(IMFSample* ppSample);
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> SetDirectXManager;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UninitializeSampleAllocator;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType, int> InitializeSampleAllocator;

        [NativeTypeName("HRESULT (IMFSample **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSample*, int> AllocateSample;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFVideoSampleAllocator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFVideoSampleAllocator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFVideoSampleAllocator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFVideoSampleAllocator(Silk.NET.Windows.IUnknown value)
    {
        return new IMFVideoSampleAllocator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFVideoSampleAllocator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFVideoSampleAllocator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFVideoSampleAllocator value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
