// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C3373FDF-6D39-4E5F-8E79-BF40C0B7ED77")]
[NativeTypeName("struct IWICBitmapSourceTransform2 : IWICBitmapSourceTransform")]
[NativeInheritance("IWICBitmapSourceTransform")]
public unsafe partial struct IWICBitmapSourceTransform2
    : IWICBitmapSourceTransform2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapSourceTransform2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWICBitmapSourceTransform2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICBitmapSourceTransform2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapSourceTransform2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CopyPixels(
        [NativeTypeName("const WICRect *")] WICRect* prc,
        uint uiWidth,
        uint uiHeight,
        [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat,
        WICBitmapTransformOptions dstTransform,
        uint nStride,
        uint cbBufferSize,
        byte* pbBuffer
    )
    {
        return (
            (delegate* unmanaged<
                IWICBitmapSourceTransform2,
                WICRect*,
                uint,
                uint,
                Guid*,
                WICBitmapTransformOptions,
                uint,
                uint,
                byte*,
                int>)((*lpVtbl)[3])
        )(
            this,
            prc,
            uiWidth,
            uiHeight,
            pguidDstFormat,
            dstTransform,
            nStride,
            cbBufferSize,
            pbBuffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetClosestSize(uint* puiWidth, uint* puiHeight)
    {
        return ((delegate* unmanaged<IWICBitmapSourceTransform2, uint*, uint*, int>)((*lpVtbl)[4]))(
            this,
            puiWidth,
            puiHeight
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetClosestPixelFormat(
        [NativeTypeName("WICPixelFormatGUID *")] Guid* pguidDstFormat
    )
    {
        return ((delegate* unmanaged<IWICBitmapSourceTransform2, Guid*, int>)((*lpVtbl)[5]))(
            this,
            pguidDstFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DoesSupportTransform(WICBitmapTransformOptions dstTransform, BOOL* pfIsSupported)
    {
        return (
            (delegate* unmanaged<
                IWICBitmapSourceTransform2,
                WICBitmapTransformOptions,
                BOOL*,
                int>)((*lpVtbl)[6])
        )(this, dstTransform, pfIsSupported);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetColorContextsForPixelFormat(
        [NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat,
        uint cCount,
        IWICColorContext* ppIColorContexts,
        uint* pcActualCount
    )
    {
        return (
            (delegate* unmanaged<
                IWICBitmapSourceTransform2,
                Guid*,
                uint,
                IWICColorContext*,
                uint*,
                int>)((*lpVtbl)[7])
        )(this, pPixelFormat, cCount, ppIColorContexts, pcActualCount);
    }

    public interface Interface : IWICBitmapSourceTransform.Interface
    {
        [VtblIndex(7)]
        HRESULT GetColorContextsForPixelFormat(
            [NativeTypeName("WICPixelFormatGUID *")] Guid* pPixelFormat,
            uint cCount,
            IWICColorContext* ppIColorContexts,
            uint* pcActualCount
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
            "HRESULT (const WICRect *, UINT, UINT, WICPixelFormatGUID *, WICBitmapTransformOptions, UINT, UINT, BYTE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WICRect*,
            uint,
            uint,
            Guid*,
            WICBitmapTransformOptions,
            uint,
            uint,
            byte*,
            int> CopyPixels;

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetClosestSize;

        [NativeTypeName("HRESULT (WICPixelFormatGUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetClosestPixelFormat;

        [NativeTypeName("HRESULT (WICBitmapTransformOptions, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            WICBitmapTransformOptions,
            BOOL*,
            int> DoesSupportTransform;

        [NativeTypeName(
            "HRESULT (WICPixelFormatGUID *, UINT, IWICColorContext **, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            uint,
            IWICColorContext*,
            uint*,
            int> GetColorContextsForPixelFormat;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICBitmapSourceTransform2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICBitmapSourceTransform2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWICBitmapSourceTransform"/> to <see cref = "IWICBitmapSourceTransform2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWICBitmapSourceTransform"/> instance to be converted </param>
    public static explicit operator IWICBitmapSourceTransform2(
        Silk.NET.Windows.IWICBitmapSourceTransform value
    )
    {
        return new IWICBitmapSourceTransform2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICBitmapSourceTransform2"/> to <see cref = "Silk.NET.Windows.IWICBitmapSourceTransform"/>.</summary>
    /// <param name = "value">The <see cref = "IWICBitmapSourceTransform2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWICBitmapSourceTransform(
        IWICBitmapSourceTransform2 value
    )
    {
        return new Silk.NET.Windows.IWICBitmapSourceTransform(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICBitmapSourceTransform2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICBitmapSourceTransform2(Silk.NET.Windows.IUnknown value)
    {
        return new IWICBitmapSourceTransform2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICBitmapSourceTransform2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICBitmapSourceTransform2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICBitmapSourceTransform2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
