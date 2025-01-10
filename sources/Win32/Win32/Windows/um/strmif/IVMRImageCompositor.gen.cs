// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7A4FB5AF-479F-4074-BB40-CE6722E43C82")]
[NativeTypeName("struct IVMRImageCompositor : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRImageCompositor : IVMRImageCompositor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRImageCompositor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRImageCompositor, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVMRImageCompositor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRImageCompositor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitCompositionTarget(
        IUnknown pD3DDevice,
        [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7 pddsRenderTarget
    )
    {
        return (
            (delegate* unmanaged<IVMRImageCompositor, IUnknown, IDirectDrawSurface7, int>)(
                (*lpVtbl)[3]
            )
        )(this, pD3DDevice, pddsRenderTarget);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TermCompositionTarget(
        IUnknown pD3DDevice,
        [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7 pddsRenderTarget
    )
    {
        return (
            (delegate* unmanaged<IVMRImageCompositor, IUnknown, IDirectDrawSurface7, int>)(
                (*lpVtbl)[4]
            )
        )(this, pD3DDevice, pddsRenderTarget);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStreamMediaType(
        [NativeTypeName("DWORD")] uint dwStrmID,
        AM_MEDIA_TYPE* pmt,
        BOOL fTexture
    )
    {
        return (
            (delegate* unmanaged<IVMRImageCompositor, uint, AM_MEDIA_TYPE*, BOOL, int>)(
                (*lpVtbl)[5]
            )
        )(this, dwStrmID, pmt, fTexture);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CompositeImage(
        IUnknown pD3DDevice,
        [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7 pddsRenderTarget,
        AM_MEDIA_TYPE* pmtRenderTarget,
        [NativeTypeName("REFERENCE_TIME")] long rtStart,
        [NativeTypeName("REFERENCE_TIME")] long rtEnd,
        [NativeTypeName("DWORD")] uint dwClrBkGnd,
        VMRVIDEOSTREAMINFO* pVideoStreamInfo,
        uint cStreams
    )
    {
        return (
            (delegate* unmanaged<
                IVMRImageCompositor,
                IUnknown,
                IDirectDrawSurface7,
                AM_MEDIA_TYPE*,
                long,
                long,
                uint,
                VMRVIDEOSTREAMINFO*,
                uint,
                int>)((*lpVtbl)[6])
        )(
            this,
            pD3DDevice,
            pddsRenderTarget,
            pmtRenderTarget,
            rtStart,
            rtEnd,
            dwClrBkGnd,
            pVideoStreamInfo,
            cStreams
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitCompositionTarget(
            IUnknown pD3DDevice,
            [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7 pddsRenderTarget
        );

        [VtblIndex(4)]
        HRESULT TermCompositionTarget(
            IUnknown pD3DDevice,
            [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7 pddsRenderTarget
        );

        [VtblIndex(5)]
        HRESULT SetStreamMediaType(
            [NativeTypeName("DWORD")] uint dwStrmID,
            AM_MEDIA_TYPE* pmt,
            BOOL fTexture
        );

        [VtblIndex(6)]
        HRESULT CompositeImage(
            IUnknown pD3DDevice,
            [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7 pddsRenderTarget,
            AM_MEDIA_TYPE* pmtRenderTarget,
            [NativeTypeName("REFERENCE_TIME")] long rtStart,
            [NativeTypeName("REFERENCE_TIME")] long rtEnd,
            [NativeTypeName("DWORD")] uint dwClrBkGnd,
            VMRVIDEOSTREAMINFO* pVideoStreamInfo,
            uint cStreams
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

        [NativeTypeName("HRESULT (IUnknown *, LPDIRECTDRAWSURFACE7) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            IDirectDrawSurface7,
            int> InitCompositionTarget;

        [NativeTypeName("HRESULT (IUnknown *, LPDIRECTDRAWSURFACE7) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            IDirectDrawSurface7,
            int> TermCompositionTarget;

        [NativeTypeName("HRESULT (DWORD, AM_MEDIA_TYPE *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, AM_MEDIA_TYPE*, BOOL, int> SetStreamMediaType;

        [NativeTypeName(
            "HRESULT (IUnknown *, LPDIRECTDRAWSURFACE7, AM_MEDIA_TYPE *, REFERENCE_TIME, REFERENCE_TIME, DWORD, VMRVIDEOSTREAMINFO *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            IDirectDrawSurface7,
            AM_MEDIA_TYPE*,
            long,
            long,
            uint,
            VMRVIDEOSTREAMINFO*,
            uint,
            int> CompositeImage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVMRImageCompositor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVMRImageCompositor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVMRImageCompositor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVMRImageCompositor(Silk.NET.Windows.IUnknown value)
    {
        return new IVMRImageCompositor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVMRImageCompositor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVMRImageCompositor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVMRImageCompositor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
