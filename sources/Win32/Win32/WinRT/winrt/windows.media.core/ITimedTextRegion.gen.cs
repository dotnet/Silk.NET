// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1ED0881F-8A06-4222-9F59-B21BF40124B4")]
[NativeTypeName("struct ITimedTextRegion : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextRegion : ITimedTextRegion.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextRegion));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITimedTextRegion, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITimedTextRegion, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITimedTextRegion, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITimedTextRegion, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITimedTextRegion, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<ITimedTextRegion, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Name(HSTRING value)
    {
        return ((delegate* unmanaged<ITimedTextRegion, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Position(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextPoint *")] TimedTextPoint* value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextPoint*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Position(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextPoint")] TimedTextPoint value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextPoint, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Extent(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextSize *")] TimedTextSize* value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextSize*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Extent(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextSize")] TimedTextSize value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextSize, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Background([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<ITimedTextRegion, Color*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Background([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<ITimedTextRegion, Color, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_WritingMode(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextWritingMode *")]
            TimedTextWritingMode* value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextWritingMode*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_WritingMode(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextWritingMode")]
            TimedTextWritingMode value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextWritingMode, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DisplayAlignment(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextDisplayAlignment *")]
            TimedTextDisplayAlignment* value
    )
    {
        return (
            (delegate* unmanaged<ITimedTextRegion, TimedTextDisplayAlignment*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_DisplayAlignment(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextDisplayAlignment")]
            TimedTextDisplayAlignment value
    )
    {
        return (
            (delegate* unmanaged<ITimedTextRegion, TimedTextDisplayAlignment, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_LineHeight(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble *")] TimedTextDouble* value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextDouble*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_LineHeight(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble")] TimedTextDouble value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextDouble, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_IsOverflowClipped([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ITimedTextRegion, byte*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_IsOverflowClipped([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ITimedTextRegion, byte, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Padding(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextPadding *")] TimedTextPadding* value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextPadding*, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Padding(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextPadding")] TimedTextPadding value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextPadding, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_TextWrapping(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextWrapping *")] TimedTextWrapping* value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextWrapping*, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_TextWrapping(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextWrapping")] TimedTextWrapping value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextWrapping, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_ZIndex([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ITimedTextRegion, int*, int>)((*lpVtbl)[26]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_ZIndex([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ITimedTextRegion, int, int>)((*lpVtbl)[27]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_ScrollMode(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextScrollMode *")]
            TimedTextScrollMode* value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextScrollMode*, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_ScrollMode(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextScrollMode")] TimedTextScrollMode value
    )
    {
        return ((delegate* unmanaged<ITimedTextRegion, TimedTextScrollMode, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Name(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Position(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextPoint *")] TimedTextPoint* value
        );

        [VtblIndex(9)]
        HRESULT put_Position(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextPoint")] TimedTextPoint value
        );

        [VtblIndex(10)]
        HRESULT get_Extent(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextSize *")] TimedTextSize* value
        );

        [VtblIndex(11)]
        HRESULT put_Extent(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextSize")] TimedTextSize value
        );

        [VtblIndex(12)]
        HRESULT get_Background([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(13)]
        HRESULT put_Background([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(14)]
        HRESULT get_WritingMode(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextWritingMode *")]
                TimedTextWritingMode* value
        );

        [VtblIndex(15)]
        HRESULT put_WritingMode(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextWritingMode")]
                TimedTextWritingMode value
        );

        [VtblIndex(16)]
        HRESULT get_DisplayAlignment(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextDisplayAlignment *")]
                TimedTextDisplayAlignment* value
        );

        [VtblIndex(17)]
        HRESULT put_DisplayAlignment(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextDisplayAlignment")]
                TimedTextDisplayAlignment value
        );

        [VtblIndex(18)]
        HRESULT get_LineHeight(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble *")] TimedTextDouble* value
        );

        [VtblIndex(19)]
        HRESULT put_LineHeight(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble")] TimedTextDouble value
        );

        [VtblIndex(20)]
        HRESULT get_IsOverflowClipped([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT put_IsOverflowClipped([NativeTypeName("boolean")] byte value);

        [VtblIndex(22)]
        HRESULT get_Padding(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextPadding *")]
                TimedTextPadding* value
        );

        [VtblIndex(23)]
        HRESULT put_Padding(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextPadding")] TimedTextPadding value
        );

        [VtblIndex(24)]
        HRESULT get_TextWrapping(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextWrapping *")]
                TimedTextWrapping* value
        );

        [VtblIndex(25)]
        HRESULT put_TextWrapping(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextWrapping")] TimedTextWrapping value
        );

        [VtblIndex(26)]
        HRESULT get_ZIndex([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(27)]
        HRESULT put_ZIndex([NativeTypeName("INT32")] int value);

        [VtblIndex(28)]
        HRESULT get_ScrollMode(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextScrollMode *")]
                TimedTextScrollMode* value
        );

        [VtblIndex(29)]
        HRESULT put_ScrollMode(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextScrollMode")]
                TimedTextScrollMode value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Name;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextPoint *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextPoint*, int> get_Position;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextPoint) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextPoint, int> put_Position;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextSize *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextSize*, int> get_Extent;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextSize) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextSize, int> put_Extent;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Background;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color, int> put_Background;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextWritingMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextWritingMode*, int> get_WritingMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextWritingMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextWritingMode, int> put_WritingMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextDisplayAlignment *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextDisplayAlignment*, int> get_DisplayAlignment;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextDisplayAlignment) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextDisplayAlignment, int> put_DisplayAlignment;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextDouble *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextDouble*, int> get_LineHeight;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextDouble) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextDouble, int> put_LineHeight;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsOverflowClipped;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsOverflowClipped;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextPadding *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextPadding*, int> get_Padding;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextPadding) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextPadding, int> put_Padding;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextWrapping *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextWrapping*, int> get_TextWrapping;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextWrapping) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextWrapping, int> put_TextWrapping;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ZIndex;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ZIndex;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextScrollMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextScrollMode*, int> get_ScrollMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextScrollMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextScrollMode, int> put_ScrollMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITimedTextRegion"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITimedTextRegion(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITimedTextRegion"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITimedTextRegion(Silk.NET.WinRT.IInspectable value)
    {
        return new ITimedTextRegion(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextRegion"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextRegion"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITimedTextRegion value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITimedTextRegion"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITimedTextRegion(Silk.NET.Windows.IUnknown value)
    {
        return new ITimedTextRegion(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextRegion"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextRegion"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITimedTextRegion value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
