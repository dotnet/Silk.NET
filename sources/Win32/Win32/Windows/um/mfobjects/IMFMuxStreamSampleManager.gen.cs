// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("74ABBC19-B1CC-4E41-BB8B-9D9B86A8F6CA")]
[NativeTypeName("struct IMFMuxStreamSampleManager : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFMuxStreamSampleManager
    : IMFMuxStreamSampleManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMuxStreamSampleManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMuxStreamSampleManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMuxStreamSampleManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMuxStreamSampleManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount)
    {
        return ((delegate* unmanaged<IMFMuxStreamSampleManager, uint*, int>)((*lpVtbl)[3]))(
            this,
            pdwMuxStreamCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSample([NativeTypeName("DWORD")] uint dwMuxStreamIndex, IMFSample* ppSample)
    {
        return (
            (delegate* unmanaged<IMFMuxStreamSampleManager, uint, IMFSample*, int>)((*lpVtbl)[4])
        )(this, dwMuxStreamIndex, ppSample);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("ULONGLONG")]
    public ulong GetStreamConfiguration()
    {
        return ((delegate* unmanaged<IMFMuxStreamSampleManager, ulong>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStreamCount([NativeTypeName("DWORD *")] uint* pdwMuxStreamCount);

        [VtblIndex(4)]
        HRESULT GetSample([NativeTypeName("DWORD")] uint dwMuxStreamIndex, IMFSample* ppSample);

        [VtblIndex(5)]
        [return: NativeTypeName("ULONGLONG")]
        ulong GetStreamConfiguration();
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetStreamCount;

        [NativeTypeName("HRESULT (DWORD, IMFSample **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFSample*, int> GetSample;

        [NativeTypeName("ULONGLONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetStreamConfiguration;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMuxStreamSampleManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMuxStreamSampleManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMuxStreamSampleManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMuxStreamSampleManager(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMuxStreamSampleManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMuxStreamSampleManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMuxStreamSampleManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMuxStreamSampleManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
