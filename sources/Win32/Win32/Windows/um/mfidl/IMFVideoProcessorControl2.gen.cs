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

[Guid("BDE633D3-E1DC-4A7F-A693-BBAE399C4A20")]
[NativeTypeName("struct IMFVideoProcessorControl2 : IMFVideoProcessorControl")]
[NativeInheritance("IMFVideoProcessorControl")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFVideoProcessorControl2
    : IMFVideoProcessorControl2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFVideoProcessorControl2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFVideoProcessorControl2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBorderColor(MFARGB* pBorderColor)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2, MFARGB*, int>)((*lpVtbl)[3]))(
            this,
            pBorderColor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSourceRectangle(RECT* pSrcRect)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2, RECT*, int>)((*lpVtbl)[4]))(
            this,
            pSrcRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDestinationRectangle(RECT* pDstRect)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2, RECT*, int>)((*lpVtbl)[5]))(
            this,
            pDstRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetMirror(MF_VIDEO_PROCESSOR_MIRROR eMirror)
    {
        return (
            (delegate* unmanaged<IMFVideoProcessorControl2, MF_VIDEO_PROCESSOR_MIRROR, int>)(
                (*lpVtbl)[6]
            )
        )(this, eMirror);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRotation(MF_VIDEO_PROCESSOR_ROTATION eRotation)
    {
        return (
            (delegate* unmanaged<IMFVideoProcessorControl2, MF_VIDEO_PROCESSOR_ROTATION, int>)(
                (*lpVtbl)[7]
            )
        )(this, eRotation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetConstrictionSize(SIZE* pConstrictionSize)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2, SIZE*, int>)((*lpVtbl)[8]))(
            this,
            pConstrictionSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetRotationOverride(uint uiRotation)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2, uint, int>)((*lpVtbl)[9]))(
            this,
            uiRotation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnableHardwareEffects(BOOL fEnabled)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2, BOOL, int>)((*lpVtbl)[10]))(
            this,
            fEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSupportedHardwareEffects(uint* puiSupport)
    {
        return ((delegate* unmanaged<IMFVideoProcessorControl2, uint*, int>)((*lpVtbl)[11]))(
            this,
            puiSupport
        );
    }

    public interface Interface : IMFVideoProcessorControl.Interface
    {
        [VtblIndex(9)]
        HRESULT SetRotationOverride(uint uiRotation);

        [VtblIndex(10)]
        HRESULT EnableHardwareEffects(BOOL fEnabled);

        [VtblIndex(11)]
        HRESULT GetSupportedHardwareEffects(uint* puiSupport);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFVideoProcessorControl2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFVideoProcessorControl2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFVideoProcessorControl"/> to <see cref = "IMFVideoProcessorControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFVideoProcessorControl"/> instance to be converted </param>
    public static explicit operator IMFVideoProcessorControl2(
        Silk.NET.Windows.IMFVideoProcessorControl value
    )
    {
        return new IMFVideoProcessorControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFVideoProcessorControl2"/> to <see cref = "Silk.NET.Windows.IMFVideoProcessorControl"/>.</summary>
    /// <param name = "value">The <see cref = "IMFVideoProcessorControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFVideoProcessorControl(
        IMFVideoProcessorControl2 value
    )
    {
        return new Silk.NET.Windows.IMFVideoProcessorControl(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFVideoProcessorControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFVideoProcessorControl2(Silk.NET.Windows.IUnknown value)
    {
        return new IMFVideoProcessorControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFVideoProcessorControl2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFVideoProcessorControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFVideoProcessorControl2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
