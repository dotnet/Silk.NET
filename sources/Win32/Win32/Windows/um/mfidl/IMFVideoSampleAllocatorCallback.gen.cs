// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("992388B4-3372-4F67-8B6F-C84C071F4751")]
[NativeTypeName("struct IMFVideoSampleAllocatorCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFVideoSampleAllocatorCallback
    : IMFVideoSampleAllocatorCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFVideoSampleAllocatorCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFVideoSampleAllocatorCallback, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetCallback(IMFVideoSampleAllocatorNotify pNotify)
    {
        return (
            (delegate* unmanaged<
                IMFVideoSampleAllocatorCallback,
                IMFVideoSampleAllocatorNotify,
                int>)((*lpVtbl)[3])
        )(this, pNotify);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFreeSampleCount([NativeTypeName("LONG *")] int* plSamples)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorCallback, int*, int>)((*lpVtbl)[4]))(
            this,
            plSamples
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetCallback(IMFVideoSampleAllocatorNotify pNotify);

        [VtblIndex(4)]
        HRESULT GetFreeSampleCount([NativeTypeName("LONG *")] int* plSamples);
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

        [NativeTypeName("HRESULT (IMFVideoSampleAllocatorNotify *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFVideoSampleAllocatorNotify, int> SetCallback;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetFreeSampleCount;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFVideoSampleAllocatorCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFVideoSampleAllocatorCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFVideoSampleAllocatorCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFVideoSampleAllocatorCallback(Silk.NET.Windows.IUnknown value)
    {
        return new IMFVideoSampleAllocatorCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFVideoSampleAllocatorCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFVideoSampleAllocatorCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFVideoSampleAllocatorCallback value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
