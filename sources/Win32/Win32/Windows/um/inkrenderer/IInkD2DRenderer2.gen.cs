// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0A95DCD9-4578-4B71-B20B-BF664D4BFEEE")]
[NativeTypeName("struct IInkD2DRenderer2 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.22000.0")]
public unsafe partial struct IInkD2DRenderer2 : IInkD2DRenderer2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInkD2DRenderer2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInkD2DRenderer2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInkD2DRenderer2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInkD2DRenderer2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Draw(
        IUnknown pD2D1DeviceContext,
        IUnknown pInkStrokeIterable,
        INK_HIGH_CONTRAST_ADJUSTMENT highContrastAdjustment
    )
    {
        return (
            (delegate* unmanaged<
                IInkD2DRenderer2,
                IUnknown,
                IUnknown,
                INK_HIGH_CONTRAST_ADJUSTMENT,
                int>)((*lpVtbl)[3])
        )(this, pD2D1DeviceContext, pInkStrokeIterable, highContrastAdjustment);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Draw(
            IUnknown pD2D1DeviceContext,
            IUnknown pInkStrokeIterable,
            INK_HIGH_CONTRAST_ADJUSTMENT highContrastAdjustment
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
            "HRESULT (IUnknown *, IUnknown *, INK_HIGH_CONTRAST_ADJUSTMENT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            IUnknown,
            INK_HIGH_CONTRAST_ADJUSTMENT,
            int> Draw;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInkD2DRenderer2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInkD2DRenderer2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInkD2DRenderer2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInkD2DRenderer2(Silk.NET.Windows.IUnknown value)
    {
        return new IInkD2DRenderer2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInkD2DRenderer2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInkD2DRenderer2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInkD2DRenderer2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
