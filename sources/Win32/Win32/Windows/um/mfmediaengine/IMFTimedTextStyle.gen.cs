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

[Guid("09B2455D-B834-4F01-A347-9052E21C450E")]
[NativeTypeName("struct IMFTimedTextStyle : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFTimedTextStyle : IMFTimedTextStyle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextStyle));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFTimedTextStyle, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextStyle, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle, ushort**, int>)((*lpVtbl)[3]))(this, name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public BOOL IsExternal()
    {
        return ((delegate* unmanaged<IMFTimedTextStyle, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFontFamily([NativeTypeName("LPWSTR *")] ushort** fontFamily)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle, ushort**, int>)((*lpVtbl)[5]))(
            this,
            fontFamily
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFontSize(double* fontSize, MF_TIMED_TEXT_UNIT_TYPE* unitType)
    {
        return (
            (delegate* unmanaged<IMFTimedTextStyle, double*, MF_TIMED_TEXT_UNIT_TYPE*, int>)(
                (*lpVtbl)[6]
            )
        )(this, fontSize, unitType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetColor(MFARGB* color)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle, MFARGB*, int>)((*lpVtbl)[7]))(this, color);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBackgroundColor(MFARGB* bgColor)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle, MFARGB*, int>)((*lpVtbl)[8]))(
            this,
            bgColor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetShowBackgroundAlways(BOOL* showBackgroundAlways)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle, BOOL*, int>)((*lpVtbl)[9]))(
            this,
            showBackgroundAlways
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFontStyle(MF_TIMED_TEXT_FONT_STYLE* fontStyle)
    {
        return (
            (delegate* unmanaged<IMFTimedTextStyle, MF_TIMED_TEXT_FONT_STYLE*, int>)((*lpVtbl)[10])
        )(this, fontStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetBold(BOOL* bold)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle, BOOL*, int>)((*lpVtbl)[11]))(this, bold);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetRightToLeft(BOOL* rightToLeft)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle, BOOL*, int>)((*lpVtbl)[12]))(
            this,
            rightToLeft
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetTextAlignment(MF_TIMED_TEXT_ALIGNMENT* textAlign)
    {
        return (
            (delegate* unmanaged<IMFTimedTextStyle, MF_TIMED_TEXT_ALIGNMENT*, int>)((*lpVtbl)[13])
        )(this, textAlign);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetTextDecoration([NativeTypeName("DWORD *")] uint* textDecoration)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle, uint*, int>)((*lpVtbl)[14]))(
            this,
            textDecoration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetTextOutline(
        MFARGB* color,
        double* thickness,
        double* blurRadius,
        MF_TIMED_TEXT_UNIT_TYPE* unitType
    )
    {
        return (
            (delegate* unmanaged<
                IMFTimedTextStyle,
                MFARGB*,
                double*,
                double*,
                MF_TIMED_TEXT_UNIT_TYPE*,
                int>)((*lpVtbl)[15])
        )(this, color, thickness, blurRadius, unitType);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);

        [VtblIndex(4)]
        BOOL IsExternal();

        [VtblIndex(5)]
        HRESULT GetFontFamily([NativeTypeName("LPWSTR *")] ushort** fontFamily);

        [VtblIndex(6)]
        HRESULT GetFontSize(double* fontSize, MF_TIMED_TEXT_UNIT_TYPE* unitType);

        [VtblIndex(7)]
        HRESULT GetColor(MFARGB* color);

        [VtblIndex(8)]
        HRESULT GetBackgroundColor(MFARGB* bgColor);

        [VtblIndex(9)]
        HRESULT GetShowBackgroundAlways(BOOL* showBackgroundAlways);

        [VtblIndex(10)]
        HRESULT GetFontStyle(MF_TIMED_TEXT_FONT_STYLE* fontStyle);

        [VtblIndex(11)]
        HRESULT GetBold(BOOL* bold);

        [VtblIndex(12)]
        HRESULT GetRightToLeft(BOOL* rightToLeft);

        [VtblIndex(13)]
        HRESULT GetTextAlignment(MF_TIMED_TEXT_ALIGNMENT* textAlign);

        [VtblIndex(14)]
        HRESULT GetTextDecoration([NativeTypeName("DWORD *")] uint* textDecoration);

        [VtblIndex(15)]
        HRESULT GetTextOutline(
            MFARGB* color,
            double* thickness,
            double* blurRadius,
            MF_TIMED_TEXT_UNIT_TYPE* unitType
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsExternal;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetFontFamily;

        [NativeTypeName("HRESULT (double *, MF_TIMED_TEXT_UNIT_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, MF_TIMED_TEXT_UNIT_TYPE*, int> GetFontSize;

        [NativeTypeName("HRESULT (MFARGB *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFARGB*, int> GetColor;

        [NativeTypeName("HRESULT (MFARGB *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFARGB*, int> GetBackgroundColor;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetShowBackgroundAlways;

        [NativeTypeName("HRESULT (MF_TIMED_TEXT_FONT_STYLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_FONT_STYLE*, int> GetFontStyle;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetBold;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetRightToLeft;

        [NativeTypeName("HRESULT (MF_TIMED_TEXT_ALIGNMENT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_ALIGNMENT*, int> GetTextAlignment;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTextDecoration;

        [NativeTypeName(
            "HRESULT (MFARGB *, double *, double *, MF_TIMED_TEXT_UNIT_TYPE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MFARGB*,
            double*,
            double*,
            MF_TIMED_TEXT_UNIT_TYPE*,
            int> GetTextOutline;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTimedTextStyle"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTimedTextStyle(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTimedTextStyle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTimedTextStyle(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTimedTextStyle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTimedTextStyle"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTimedTextStyle"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTimedTextStyle value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
