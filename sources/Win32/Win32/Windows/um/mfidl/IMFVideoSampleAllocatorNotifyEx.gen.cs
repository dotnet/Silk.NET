// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3978AA1A-6D5B-4B7F-A340-90899189AE34")]
[NativeTypeName("struct IMFVideoSampleAllocatorNotifyEx : IMFVideoSampleAllocatorNotify")]
[NativeInheritance("IMFVideoSampleAllocatorNotify")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFVideoSampleAllocatorNotifyEx
    : IMFVideoSampleAllocatorNotifyEx.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFVideoSampleAllocatorNotifyEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFVideoSampleAllocatorNotifyEx, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorNotifyEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorNotifyEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT NotifyRelease()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorNotifyEx, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT NotifyPrune(IMFSample __MIDL__IMFVideoSampleAllocatorNotifyEx0000)
    {
        return (
            (delegate* unmanaged<IMFVideoSampleAllocatorNotifyEx, IMFSample, int>)((*lpVtbl)[4])
        )(this, __MIDL__IMFVideoSampleAllocatorNotifyEx0000);
    }

    public interface Interface : IMFVideoSampleAllocatorNotify.Interface
    {
        [VtblIndex(4)]
        HRESULT NotifyPrune(IMFSample __MIDL__IMFVideoSampleAllocatorNotifyEx0000);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyRelease;

        [NativeTypeName("HRESULT (IMFSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSample, int> NotifyPrune;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFVideoSampleAllocatorNotifyEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFVideoSampleAllocatorNotifyEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFVideoSampleAllocatorNotify"/> to <see cref = "IMFVideoSampleAllocatorNotifyEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFVideoSampleAllocatorNotify"/> instance to be converted </param>
    public static explicit operator IMFVideoSampleAllocatorNotifyEx(
        Silk.NET.Windows.IMFVideoSampleAllocatorNotify value
    )
    {
        return new IMFVideoSampleAllocatorNotifyEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFVideoSampleAllocatorNotifyEx"/> to <see cref = "Silk.NET.Windows.IMFVideoSampleAllocatorNotify"/>.</summary>
    /// <param name = "value">The <see cref = "IMFVideoSampleAllocatorNotifyEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFVideoSampleAllocatorNotify(
        IMFVideoSampleAllocatorNotifyEx value
    )
    {
        return new Silk.NET.Windows.IMFVideoSampleAllocatorNotify(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFVideoSampleAllocatorNotifyEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFVideoSampleAllocatorNotifyEx(Silk.NET.Windows.IUnknown value)
    {
        return new IMFVideoSampleAllocatorNotifyEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFVideoSampleAllocatorNotifyEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFVideoSampleAllocatorNotifyEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFVideoSampleAllocatorNotifyEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
