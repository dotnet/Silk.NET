// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFExtendedCameraIntrinsicModel.xml' path='doc/member[@name="IMFExtendedCameraIntrinsicModel"]/*' />
[Guid("5C595E64-4630-4231-855A-12842F733245")]
[NativeTypeName("struct IMFExtendedCameraIntrinsicModel : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFExtendedCameraIntrinsicModel : IMFExtendedCameraIntrinsicModel.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFExtendedCameraIntrinsicModel));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, Guid*, void**, int>)(lpVtbl[0]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, uint>)(lpVtbl[1]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, uint>)(lpVtbl[2]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFExtendedCameraIntrinsicModel.xml' path='doc/member[@name="IMFExtendedCameraIntrinsicModel.GetModel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetModel(MFExtendedCameraIntrinsic_IntrinsicModel* pIntrinsicModel)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, MFExtendedCameraIntrinsic_IntrinsicModel*, int>)(lpVtbl[3]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this), pIntrinsicModel);
    }

    /// <include file='IMFExtendedCameraIntrinsicModel.xml' path='doc/member[@name="IMFExtendedCameraIntrinsicModel.SetModel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetModel([NativeTypeName("const MFExtendedCameraIntrinsic_IntrinsicModel *")] MFExtendedCameraIntrinsic_IntrinsicModel* pIntrinsicModel)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, MFExtendedCameraIntrinsic_IntrinsicModel*, int>)(lpVtbl[4]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this), pIntrinsicModel);
    }

    /// <include file='IMFExtendedCameraIntrinsicModel.xml' path='doc/member[@name="IMFExtendedCameraIntrinsicModel.GetDistortionModelType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDistortionModelType(MFCameraIntrinsic_DistortionModelType* pDistortionModelType)
    {
        return ((delegate* unmanaged<IMFExtendedCameraIntrinsicModel*, MFCameraIntrinsic_DistortionModelType*, int>)(lpVtbl[5]))((IMFExtendedCameraIntrinsicModel*)Unsafe.AsPointer(ref this), pDistortionModelType);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetModel(MFExtendedCameraIntrinsic_IntrinsicModel* pIntrinsicModel);

        [VtblIndex(4)]
        HRESULT SetModel([NativeTypeName("const MFExtendedCameraIntrinsic_IntrinsicModel *")] MFExtendedCameraIntrinsic_IntrinsicModel* pIntrinsicModel);

        [VtblIndex(5)]
        HRESULT GetDistortionModelType(MFCameraIntrinsic_DistortionModelType* pDistortionModelType);
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

        [NativeTypeName("HRESULT (MFExtendedCameraIntrinsic_IntrinsicModel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFExtendedCameraIntrinsic_IntrinsicModel*, int> GetModel;

        [NativeTypeName("HRESULT (const MFExtendedCameraIntrinsic_IntrinsicModel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFExtendedCameraIntrinsic_IntrinsicModel*, int> SetModel;

        [NativeTypeName("HRESULT (MFCameraIntrinsic_DistortionModelType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFCameraIntrinsic_DistortionModelType*, int> GetDistortionModelType;
    }
}
