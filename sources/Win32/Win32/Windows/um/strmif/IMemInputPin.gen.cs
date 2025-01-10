// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A8689D-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IMemInputPin : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMemInputPin : IMemInputPin.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMemInputPin));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMemInputPin, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMemInputPin, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMemInputPin, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAllocator(IMemAllocator* ppAllocator)
    {
        return ((delegate* unmanaged<IMemInputPin, IMemAllocator*, int>)((*lpVtbl)[3]))(
            this,
            ppAllocator
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT NotifyAllocator(IMemAllocator pAllocator, BOOL bReadOnly)
    {
        return ((delegate* unmanaged<IMemInputPin, IMemAllocator, BOOL, int>)((*lpVtbl)[4]))(
            this,
            pAllocator,
            bReadOnly
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAllocatorRequirements(ALLOCATOR_PROPERTIES* pProps)
    {
        return ((delegate* unmanaged<IMemInputPin, ALLOCATOR_PROPERTIES*, int>)((*lpVtbl)[5]))(
            this,
            pProps
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Receive(IMediaSample pSample)
    {
        return ((delegate* unmanaged<IMemInputPin, IMediaSample, int>)((*lpVtbl)[6]))(
            this,
            pSample
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReceiveMultiple(
        IMediaSample* pSamples,
        [NativeTypeName("long")] int nSamples,
        [NativeTypeName("long *")] int* nSamplesProcessed
    )
    {
        return ((delegate* unmanaged<IMemInputPin, IMediaSample*, int, int*, int>)((*lpVtbl)[7]))(
            this,
            pSamples,
            nSamples,
            nSamplesProcessed
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReceiveCanBlock()
    {
        return ((delegate* unmanaged<IMemInputPin, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAllocator(IMemAllocator* ppAllocator);

        [VtblIndex(4)]
        HRESULT NotifyAllocator(IMemAllocator pAllocator, BOOL bReadOnly);

        [VtblIndex(5)]
        HRESULT GetAllocatorRequirements(ALLOCATOR_PROPERTIES* pProps);

        [VtblIndex(6)]
        HRESULT Receive(IMediaSample pSample);

        [VtblIndex(7)]
        HRESULT ReceiveMultiple(
            IMediaSample* pSamples,
            [NativeTypeName("long")] int nSamples,
            [NativeTypeName("long *")] int* nSamplesProcessed
        );

        [VtblIndex(8)]
        HRESULT ReceiveCanBlock();
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

        [NativeTypeName("HRESULT (IMemAllocator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMemAllocator*, int> GetAllocator;

        [NativeTypeName("HRESULT (IMemAllocator *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMemAllocator, BOOL, int> NotifyAllocator;

        [NativeTypeName("HRESULT (ALLOCATOR_PROPERTIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ALLOCATOR_PROPERTIES*, int> GetAllocatorRequirements;

        [NativeTypeName("HRESULT (IMediaSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMediaSample, int> Receive;

        [NativeTypeName("HRESULT (IMediaSample **, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMediaSample*, int, int*, int> ReceiveMultiple;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReceiveCanBlock;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMemInputPin"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMemInputPin(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMemInputPin"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMemInputPin(Silk.NET.Windows.IUnknown value)
    {
        return new IMemInputPin(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMemInputPin"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMemInputPin"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMemInputPin value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
