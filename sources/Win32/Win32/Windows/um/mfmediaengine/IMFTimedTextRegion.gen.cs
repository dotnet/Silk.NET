// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C8D22AFC-BC47-4BDF-9B04-787E49CE3F58")]
[NativeTypeName("struct IMFTimedTextRegion : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFTimedTextRegion : IMFTimedTextRegion.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextRegion));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextRegion, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFTimedTextRegion, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextRegion, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IMFTimedTextRegion, ushort**, int>)((*lpVtbl)[3]))(this, name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPosition(double* pX, double* pY, MF_TIMED_TEXT_UNIT_TYPE* unitType)
    {
        return (
            (delegate* unmanaged<
                IMFTimedTextRegion,
                double*,
                double*,
                MF_TIMED_TEXT_UNIT_TYPE*,
                int>)((*lpVtbl)[4])
        )(this, pX, pY, unitType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetExtent(double* pWidth, double* pHeight, MF_TIMED_TEXT_UNIT_TYPE* unitType)
    {
        return (
            (delegate* unmanaged<
                IMFTimedTextRegion,
                double*,
                double*,
                MF_TIMED_TEXT_UNIT_TYPE*,
                int>)((*lpVtbl)[5])
        )(this, pWidth, pHeight, unitType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetBackgroundColor(MFARGB* bgColor)
    {
        return ((delegate* unmanaged<IMFTimedTextRegion, MFARGB*, int>)((*lpVtbl)[6]))(
            this,
            bgColor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetWritingMode(MF_TIMED_TEXT_WRITING_MODE* writingMode)
    {
        return (
            (delegate* unmanaged<IMFTimedTextRegion, MF_TIMED_TEXT_WRITING_MODE*, int>)(
                (*lpVtbl)[7]
            )
        )(this, writingMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDisplayAlignment(MF_TIMED_TEXT_DISPLAY_ALIGNMENT* displayAlign)
    {
        return (
            (delegate* unmanaged<IMFTimedTextRegion, MF_TIMED_TEXT_DISPLAY_ALIGNMENT*, int>)(
                (*lpVtbl)[8]
            )
        )(this, displayAlign);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetLineHeight(double* pLineHeight, MF_TIMED_TEXT_UNIT_TYPE* unitType)
    {
        return (
            (delegate* unmanaged<IMFTimedTextRegion, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(
                (*lpVtbl)[9]
            )
        )(this, pLineHeight, unitType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetClipOverflow(BOOL* clipOverflow)
    {
        return ((delegate* unmanaged<IMFTimedTextRegion, BOOL*, int>)((*lpVtbl)[10]))(
            this,
            clipOverflow
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPadding(
        double* before,
        double* start,
        double* after,
        double* end,
        MF_TIMED_TEXT_UNIT_TYPE* unitType
    )
    {
        return (
            (delegate* unmanaged<
                IMFTimedTextRegion,
                double*,
                double*,
                double*,
                double*,
                MF_TIMED_TEXT_UNIT_TYPE*,
                int>)((*lpVtbl)[11])
        )(this, before, start, after, end, unitType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetWrap(BOOL* wrap)
    {
        return ((delegate* unmanaged<IMFTimedTextRegion, BOOL*, int>)((*lpVtbl)[12]))(this, wrap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetZIndex([NativeTypeName("INT32 *")] int* zIndex)
    {
        return ((delegate* unmanaged<IMFTimedTextRegion, int*, int>)((*lpVtbl)[13]))(this, zIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetScrollMode(MF_TIMED_TEXT_SCROLL_MODE* scrollMode)
    {
        return (
            (delegate* unmanaged<IMFTimedTextRegion, MF_TIMED_TEXT_SCROLL_MODE*, int>)(
                (*lpVtbl)[14]
            )
        )(this, scrollMode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);

        [VtblIndex(4)]
        HRESULT GetPosition(double* pX, double* pY, MF_TIMED_TEXT_UNIT_TYPE* unitType);

        [VtblIndex(5)]
        HRESULT GetExtent(double* pWidth, double* pHeight, MF_TIMED_TEXT_UNIT_TYPE* unitType);

        [VtblIndex(6)]
        HRESULT GetBackgroundColor(MFARGB* bgColor);

        [VtblIndex(7)]
        HRESULT GetWritingMode(MF_TIMED_TEXT_WRITING_MODE* writingMode);

        [VtblIndex(8)]
        HRESULT GetDisplayAlignment(MF_TIMED_TEXT_DISPLAY_ALIGNMENT* displayAlign);

        [VtblIndex(9)]
        HRESULT GetLineHeight(double* pLineHeight, MF_TIMED_TEXT_UNIT_TYPE* unitType);

        [VtblIndex(10)]
        HRESULT GetClipOverflow(BOOL* clipOverflow);

        [VtblIndex(11)]
        HRESULT GetPadding(
            double* before,
            double* start,
            double* after,
            double* end,
            MF_TIMED_TEXT_UNIT_TYPE* unitType
        );

        [VtblIndex(12)]
        HRESULT GetWrap(BOOL* wrap);

        [VtblIndex(13)]
        HRESULT GetZIndex([NativeTypeName("INT32 *")] int* zIndex);

        [VtblIndex(14)]
        HRESULT GetScrollMode(MF_TIMED_TEXT_SCROLL_MODE* scrollMode);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName(
            "HRESULT (double *, double *, MF_TIMED_TEXT_UNIT_TYPE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            double*,
            double*,
            MF_TIMED_TEXT_UNIT_TYPE*,
            int> GetPosition;

        [NativeTypeName(
            "HRESULT (double *, double *, MF_TIMED_TEXT_UNIT_TYPE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            double*,
            double*,
            MF_TIMED_TEXT_UNIT_TYPE*,
            int> GetExtent;

        [NativeTypeName("HRESULT (MFARGB *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFARGB*, int> GetBackgroundColor;

        [NativeTypeName("HRESULT (MF_TIMED_TEXT_WRITING_MODE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_WRITING_MODE*, int> GetWritingMode;

        [NativeTypeName("HRESULT (MF_TIMED_TEXT_DISPLAY_ALIGNMENT *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            MF_TIMED_TEXT_DISPLAY_ALIGNMENT*,
            int> GetDisplayAlignment;

        [NativeTypeName("HRESULT (double *, MF_TIMED_TEXT_UNIT_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int> GetLineHeight;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetClipOverflow;

        [NativeTypeName(
            "HRESULT (double *, double *, double *, double *, MF_TIMED_TEXT_UNIT_TYPE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            double*,
            double*,
            double*,
            double*,
            MF_TIMED_TEXT_UNIT_TYPE*,
            int> GetPadding;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetWrap;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetZIndex;

        [NativeTypeName("HRESULT (MF_TIMED_TEXT_SCROLL_MODE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_SCROLL_MODE*, int> GetScrollMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTimedTextRegion"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTimedTextRegion(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTimedTextRegion"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTimedTextRegion(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTimedTextRegion(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTimedTextRegion"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTimedTextRegion"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTimedTextRegion value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
