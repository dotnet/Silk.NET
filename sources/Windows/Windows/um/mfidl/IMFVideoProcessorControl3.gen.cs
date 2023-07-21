// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFVideoProcessorControl3.xml' path='doc/member[@name="IMFVideoProcessorControl3"]/*' />
[Guid("2424B3F2-EB23-40F1-91AA-74BDDEEA0883")]
[NativeTypeName("struct IMFVideoProcessorControl3 : IMFVideoProcessorControl2")]
[NativeInheritance("IMFVideoProcessorControl2")]
public unsafe partial struct IMFVideoProcessorControl3 : IMFVideoProcessorControl3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFVideoProcessorControl3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, uint>)(lpVtbl[1]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, uint>)(lpVtbl[2]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFVideoProcessorControl.SetBorderColor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBorderColor(MFARGB* pBorderColor)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, MFARGB*, int>)(lpVtbl[3]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pBorderColor);
    }

    /// <inheritdoc cref="IMFVideoProcessorControl.SetSourceRectangle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSourceRectangle(RECT* pSrcRect)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, RECT*, int>)(lpVtbl[4]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pSrcRect);
    }

    /// <inheritdoc cref="IMFVideoProcessorControl.SetDestinationRectangle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDestinationRectangle(RECT* pDstRect)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, RECT*, int>)(lpVtbl[5]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pDstRect);
    }

    /// <inheritdoc cref="IMFVideoProcessorControl.SetMirror" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, MF_VIDEO_PROCESSOR_MIRROR, int>)(lpVtbl[6]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), eMirror);
    }

    /// <inheritdoc cref="IMFVideoProcessorControl.SetRotation" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, MF_VIDEO_PROCESSOR_ROTATION, int>)(lpVtbl[7]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), eRotation);
    }

    /// <inheritdoc cref="IMFVideoProcessorControl.SetConstrictionSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetConstrictionSize(SIZE* pConstrictionSize)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, SIZE*, int>)(lpVtbl[8]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pConstrictionSize);
    }

    /// <inheritdoc cref="IMFVideoProcessorControl2.SetRotationOverride" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetRotationOverride(uint uiRotation)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, uint, int>)(lpVtbl[9]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), uiRotation);
    }

    /// <inheritdoc cref="IMFVideoProcessorControl2.EnableHardwareEffects" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnableHardwareEffects(BOOL fEnabled)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, BOOL, int>)(lpVtbl[10]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), fEnabled);
    }

    /// <inheritdoc cref="IMFVideoProcessorControl2.GetSupportedHardwareEffects" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSupportedHardwareEffects(uint* puiSupport)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, uint*, int>)(lpVtbl[11]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), puiSupport);
    }

    /// <include file='IMFVideoProcessorControl3.xml' path='doc/member[@name="IMFVideoProcessorControl3.GetNaturalOutputType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetNaturalOutputType(IMFMediaType** ppType)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, IMFMediaType**, int>)(lpVtbl[12]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), ppType);
    }

    /// <include file='IMFVideoProcessorControl3.xml' path='doc/member[@name="IMFVideoProcessorControl3.EnableSphericalVideoProcessing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnableSphericalVideoProcessing(BOOL fEnable, MFVideoSphericalFormat eFormat, MFVideoSphericalProjectionMode eProjectionMode)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, BOOL, MFVideoSphericalFormat, MFVideoSphericalProjectionMode, int>)(lpVtbl[13]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), fEnable, eFormat, eProjectionMode);
    }

    /// <include file='IMFVideoProcessorControl3.xml' path='doc/member[@name="IMFVideoProcessorControl3.SetSphericalVideoProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetSphericalVideoProperties(float X, float Y, float Z, float W, float fieldOfView)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, float, float, float, float, float, int>)(lpVtbl[14]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), X, Y, Z, W, fieldOfView);
    }

    /// <include file='IMFVideoProcessorControl3.xml' path='doc/member[@name="IMFVideoProcessorControl3.SetOutputDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetOutputDevice(IUnknown* pOutputDevice)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3*, IUnknown*, int>)(lpVtbl[15]))((IMFVideoProcessorControl3*)Unsafe.AsPointer(ref this), pOutputDevice);
    }

    public interface Interface : IMFVideoProcessorControl2.Interface
    {
        [VtblIndex(12)]
        HRESULT GetNaturalOutputType(IMFMediaType** ppType);

        [VtblIndex(13)]
        HRESULT EnableSphericalVideoProcessing(BOOL fEnable, MFVideoSphericalFormat eFormat, MFVideoSphericalProjectionMode eProjectionMode);

        [VtblIndex(14)]
        HRESULT SetSphericalVideoProperties(float X, float Y, float Z, float W, float fieldOfView);

        [VtblIndex(15)]
        HRESULT SetOutputDevice(IUnknown* pOutputDevice);
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

        [NativeTypeName("HRESULT (MFARGB *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFARGB*, int> SetBorderColor;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetSourceRectangle;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetDestinationRectangle;

        [NativeTypeName("HRESULT (MF_VIDEO_PROCESSOR_MIRROR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_VIDEO_PROCESSOR_MIRROR, int> SetMirror;

        [NativeTypeName("HRESULT (MF_VIDEO_PROCESSOR_ROTATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_VIDEO_PROCESSOR_ROTATION, int> SetRotation;

        [NativeTypeName("HRESULT (SIZE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE*, int> SetConstrictionSize;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetRotationOverride;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> EnableHardwareEffects;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSupportedHardwareEffects;

        [NativeTypeName("HRESULT (IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaType**, int> GetNaturalOutputType;

        [NativeTypeName("HRESULT (BOOL, MFVideoSphericalFormat, MFVideoSphericalProjectionMode) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, MFVideoSphericalFormat, MFVideoSphericalProjectionMode, int> EnableSphericalVideoProcessing;

        [NativeTypeName("HRESULT (float, float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, float, int> SetSphericalVideoProperties;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetOutputDevice;
    }
}
