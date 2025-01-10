// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("74C2653B-5F55-4EB1-9F0F-18B8F68B7D3D")]
[NativeTypeName("struct IMFExtendedCameraIntrinsicsDistortionModel6KT : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFExtendedCameraIntrinsicsDistortionModel6KT
    : IMFExtendedCameraIntrinsicsDistortionModel6KT.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IMFExtendedCameraIntrinsicsDistortionModel6KT)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IMFExtendedCameraIntrinsicsDistortionModel6KT,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModel6KT, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IMFExtendedCameraIntrinsicsDistortionModel6KT, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDistortionModel(MFCameraIntrinsic_DistortionModel6KT* pDistortionModel)
    {
        return (
            (delegate* unmanaged<
                IMFExtendedCameraIntrinsicsDistortionModel6KT,
                MFCameraIntrinsic_DistortionModel6KT*,
                int>)((*lpVtbl)[3])
        )(this, pDistortionModel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetDistortionModel(
        [NativeTypeName("const MFCameraIntrinsic_DistortionModel6KT *")]
            MFCameraIntrinsic_DistortionModel6KT* pDistortionModel
    )
    {
        return (
            (delegate* unmanaged<
                IMFExtendedCameraIntrinsicsDistortionModel6KT,
                MFCameraIntrinsic_DistortionModel6KT*,
                int>)((*lpVtbl)[4])
        )(this, pDistortionModel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDistortionModel(MFCameraIntrinsic_DistortionModel6KT* pDistortionModel);

        [VtblIndex(4)]
        HRESULT SetDistortionModel(
            [NativeTypeName("const MFCameraIntrinsic_DistortionModel6KT *")]
                MFCameraIntrinsic_DistortionModel6KT* pDistortionModel
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

        [NativeTypeName(
            "HRESULT (MFCameraIntrinsic_DistortionModel6KT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MFCameraIntrinsic_DistortionModel6KT*,
            int> GetDistortionModel;

        [NativeTypeName(
            "HRESULT (const MFCameraIntrinsic_DistortionModel6KT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MFCameraIntrinsic_DistortionModel6KT*,
            int> SetDistortionModel;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFExtendedCameraIntrinsicsDistortionModel6KT"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFExtendedCameraIntrinsicsDistortionModel6KT(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFExtendedCameraIntrinsicsDistortionModel6KT"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFExtendedCameraIntrinsicsDistortionModel6KT(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMFExtendedCameraIntrinsicsDistortionModel6KT(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFExtendedCameraIntrinsicsDistortionModel6KT"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFExtendedCameraIntrinsicsDistortionModel6KT"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMFExtendedCameraIntrinsicsDistortionModel6KT value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
