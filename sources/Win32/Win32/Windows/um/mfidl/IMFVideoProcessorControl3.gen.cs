// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2424B3F2-EB23-40F1-91AA-74BDDEEA0883")]
[NativeTypeName("struct IMFVideoProcessorControl3 : IMFVideoProcessorControl2")]
[NativeInheritance("IMFVideoProcessorControl2")]
public unsafe partial struct IMFVideoProcessorControl3
    : IMFVideoProcessorControl3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFVideoProcessorControl3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFVideoProcessorControl3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBorderColor(MFARGB* pBorderColor)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3, MFARGB*, int>)((*lpVtbl)[3]))(
            this,
            pBorderColor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSourceRectangle(RECT* pSrcRect)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3, RECT*, int>)((*lpVtbl)[4]))(
            this,
            pSrcRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDestinationRectangle(RECT* pDstRect)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3, RECT*, int>)((*lpVtbl)[5]))(
            this,
            pDstRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror)
    {
        return (
            (delegate* unmanaged<IMFVideoProcessorControl3, MF_VIDEO_PROCESSOR_MIRROR, int>)(
                (*lpVtbl)[6]
            )
        )(this, eMirror);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation)
    {
        return (
            (delegate* unmanaged<IMFVideoProcessorControl3, MF_VIDEO_PROCESSOR_ROTATION, int>)(
                (*lpVtbl)[7]
            )
        )(this, eRotation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetConstrictionSize(SIZE* pConstrictionSize)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3, SIZE*, int>)((*lpVtbl)[8]))(
            this,
            pConstrictionSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetRotationOverride(uint uiRotation)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3, uint, int>)((*lpVtbl)[9]))(
            this,
            uiRotation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnableHardwareEffects(BOOL fEnabled)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3, BOOL, int>)((*lpVtbl)[10]))(
            this,
            fEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSupportedHardwareEffects(uint* puiSupport)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3, uint*, int>)((*lpVtbl)[11]))(
            this,
            puiSupport
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetNaturalOutputType(IMFMediaType* ppType)
    {
        return (
            (delegate* unmanaged<IMFVideoProcessorControl3, IMFMediaType*, int>)((*lpVtbl)[12])
        )(this, ppType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnableSphericalVideoProcessing(
        BOOL fEnable,
        MFVideoSphericalFormat eFormat,
        MFVideoSphericalProjectionMode eProjectionMode
    )
    {
        return (
            (delegate* unmanaged<
                IMFVideoProcessorControl3,
                BOOL,
                MFVideoSphericalFormat,
                MFVideoSphericalProjectionMode,
                int>)((*lpVtbl)[13])
        )(this, fEnable, eFormat, eProjectionMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetSphericalVideoProperties(
        float X,
        float Y,
        float Z,
        float W,
        float fieldOfView
    )
    {
        return (
            (delegate* unmanaged<
                IMFVideoProcessorControl3,
                float,
                float,
                float,
                float,
                float,
                int>)((*lpVtbl)[14])
        )(this, X, Y, Z, W, fieldOfView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetOutputDevice(IUnknown pOutputDevice)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl3, IUnknown, int>)((*lpVtbl)[15]))(
            this,
            pOutputDevice
        );
    }

    public interface Interface : IMFVideoProcessorControl2.Interface
    {
        [VtblIndex(12)]
        HRESULT GetNaturalOutputType(IMFMediaType* ppType);

        [VtblIndex(13)]
        HRESULT EnableSphericalVideoProcessing(
            BOOL fEnable,
            MFVideoSphericalFormat eFormat,
            MFVideoSphericalProjectionMode eProjectionMode
        );

        [VtblIndex(14)]
        HRESULT SetSphericalVideoProperties(float X, float Y, float Z, float W, float fieldOfView);

        [VtblIndex(15)]
        HRESULT SetOutputDevice(IUnknown pOutputDevice);
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
        public delegate* unmanaged<TSelf*, IMFMediaType*, int> GetNaturalOutputType;

        [NativeTypeName(
            "HRESULT (BOOL, MFVideoSphericalFormat, MFVideoSphericalProjectionMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BOOL,
            MFVideoSphericalFormat,
            MFVideoSphericalProjectionMode,
            int> EnableSphericalVideoProcessing;

        [NativeTypeName("HRESULT (float, float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            float,
            int> SetSphericalVideoProperties;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> SetOutputDevice;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFVideoProcessorControl3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFVideoProcessorControl3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFVideoProcessorControl2"/> to <see cref = "IMFVideoProcessorControl3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFVideoProcessorControl2"/> instance to be converted </param>
    public static explicit operator IMFVideoProcessorControl3(
        Silk.NET.Windows.IMFVideoProcessorControl2 value
    )
    {
        return new IMFVideoProcessorControl3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFVideoProcessorControl3"/> to <see cref = "Silk.NET.Windows.IMFVideoProcessorControl2"/>.</summary>
    /// <param name = "value">The <see cref = "IMFVideoProcessorControl3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFVideoProcessorControl2(
        IMFVideoProcessorControl3 value
    )
    {
        return new Silk.NET.Windows.IMFVideoProcessorControl2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFVideoProcessorControl"/> to <see cref = "IMFVideoProcessorControl3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFVideoProcessorControl"/> instance to be converted </param>
    public static explicit operator IMFVideoProcessorControl3(
        Silk.NET.Windows.IMFVideoProcessorControl value
    )
    {
        return new IMFVideoProcessorControl3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFVideoProcessorControl3"/> to <see cref = "Silk.NET.Windows.IMFVideoProcessorControl"/>.</summary>
    /// <param name = "value">The <see cref = "IMFVideoProcessorControl3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFVideoProcessorControl(
        IMFVideoProcessorControl3 value
    )
    {
        return new Silk.NET.Windows.IMFVideoProcessorControl(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFVideoProcessorControl3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFVideoProcessorControl3(Silk.NET.Windows.IUnknown value)
    {
        return new IMFVideoProcessorControl3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFVideoProcessorControl3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFVideoProcessorControl3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFVideoProcessorControl3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
