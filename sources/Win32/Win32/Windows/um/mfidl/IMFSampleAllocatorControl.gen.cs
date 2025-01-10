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

[Guid("DA62B958-3A38-4A97-BD27-149C640C0771")]
[NativeTypeName("struct IMFSampleAllocatorControl : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IMFSampleAllocatorControl
    : IMFSampleAllocatorControl.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSampleAllocatorControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSampleAllocatorControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSampleAllocatorControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSampleAllocatorControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetDefaultAllocator(
        [NativeTypeName("DWORD")] uint dwOutputStreamID,
        IUnknown pAllocator
    )
    {
        return (
            (delegate* unmanaged<IMFSampleAllocatorControl, uint, IUnknown, int>)((*lpVtbl)[3])
        )(this, dwOutputStreamID, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAllocatorUsage(
        [NativeTypeName("DWORD")] uint dwOutputStreamID,
        [NativeTypeName("DWORD *")] uint* pdwInputStreamID,
        MFSampleAllocatorUsage* peUsage
    )
    {
        return (
            (delegate* unmanaged<
                IMFSampleAllocatorControl,
                uint,
                uint*,
                MFSampleAllocatorUsage*,
                int>)((*lpVtbl)[4])
        )(this, dwOutputStreamID, pdwInputStreamID, peUsage);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetDefaultAllocator(
            [NativeTypeName("DWORD")] uint dwOutputStreamID,
            IUnknown pAllocator
        );

        [VtblIndex(4)]
        HRESULT GetAllocatorUsage(
            [NativeTypeName("DWORD")] uint dwOutputStreamID,
            [NativeTypeName("DWORD *")] uint* pdwInputStreamID,
            MFSampleAllocatorUsage* peUsage
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

        [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown, int> SetDefaultAllocator;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD *, MFSampleAllocatorUsage *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint*,
            MFSampleAllocatorUsage*,
            int> GetAllocatorUsage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSampleAllocatorControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSampleAllocatorControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSampleAllocatorControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSampleAllocatorControl(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSampleAllocatorControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSampleAllocatorControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSampleAllocatorControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSampleAllocatorControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
