// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BE8F4F4E-5B16-4D29-B350-7F6B5D9298AC")]
[NativeTypeName("struct IDMOVideoOutputOptimizations : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDMOVideoOutputOptimizations
    : IDMOVideoOutputOptimizations.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDMOVideoOutputOptimizations));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDMOVideoOutputOptimizations, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDMOVideoOutputOptimizations, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDMOVideoOutputOptimizations, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryOperationModePreferences(
        [NativeTypeName("ULONG")] uint ulOutputStreamIndex,
        [NativeTypeName("DWORD *")] uint* pdwRequestedCapabilities
    )
    {
        return (
            (delegate* unmanaged<IDMOVideoOutputOptimizations, uint, uint*, int>)((*lpVtbl)[3])
        )(this, ulOutputStreamIndex, pdwRequestedCapabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOperationMode(
        [NativeTypeName("ULONG")] uint ulOutputStreamIndex,
        [NativeTypeName("DWORD")] uint dwEnabledFeatures
    )
    {
        return ((delegate* unmanaged<IDMOVideoOutputOptimizations, uint, uint, int>)((*lpVtbl)[4]))(
            this,
            ulOutputStreamIndex,
            dwEnabledFeatures
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentOperationMode(
        [NativeTypeName("ULONG")] uint ulOutputStreamIndex,
        [NativeTypeName("DWORD *")] uint* pdwEnabledFeatures
    )
    {
        return (
            (delegate* unmanaged<IDMOVideoOutputOptimizations, uint, uint*, int>)((*lpVtbl)[5])
        )(this, ulOutputStreamIndex, pdwEnabledFeatures);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentSampleRequirements(
        [NativeTypeName("ULONG")] uint ulOutputStreamIndex,
        [NativeTypeName("DWORD *")] uint* pdwRequestedFeatures
    )
    {
        return (
            (delegate* unmanaged<IDMOVideoOutputOptimizations, uint, uint*, int>)((*lpVtbl)[6])
        )(this, ulOutputStreamIndex, pdwRequestedFeatures);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryOperationModePreferences(
            [NativeTypeName("ULONG")] uint ulOutputStreamIndex,
            [NativeTypeName("DWORD *")] uint* pdwRequestedCapabilities
        );

        [VtblIndex(4)]
        HRESULT SetOperationMode(
            [NativeTypeName("ULONG")] uint ulOutputStreamIndex,
            [NativeTypeName("DWORD")] uint dwEnabledFeatures
        );

        [VtblIndex(5)]
        HRESULT GetCurrentOperationMode(
            [NativeTypeName("ULONG")] uint ulOutputStreamIndex,
            [NativeTypeName("DWORD *")] uint* pdwEnabledFeatures
        );

        [VtblIndex(6)]
        HRESULT GetCurrentSampleRequirements(
            [NativeTypeName("ULONG")] uint ulOutputStreamIndex,
            [NativeTypeName("DWORD *")] uint* pdwRequestedFeatures
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

        [NativeTypeName("HRESULT (ULONG, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> QueryOperationModePreferences;

        [NativeTypeName("HRESULT (ULONG, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetOperationMode;

        [NativeTypeName("HRESULT (ULONG, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetCurrentOperationMode;

        [NativeTypeName("HRESULT (ULONG, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetCurrentSampleRequirements;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDMOVideoOutputOptimizations"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDMOVideoOutputOptimizations(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDMOVideoOutputOptimizations"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDMOVideoOutputOptimizations(Silk.NET.Windows.IUnknown value)
    {
        return new IDMOVideoOutputOptimizations(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDMOVideoOutputOptimizations"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDMOVideoOutputOptimizations"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDMOVideoOutputOptimizations value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
