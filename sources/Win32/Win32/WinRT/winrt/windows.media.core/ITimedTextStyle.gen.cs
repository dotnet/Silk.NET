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

[Guid("1BB2384D-A825-40C2-A7F5-281EAEDF3B55")]
[NativeTypeName("struct ITimedTextStyle : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ITimedTextStyle : ITimedTextStyle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITimedTextStyle));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITimedTextStyle, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITimedTextStyle, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITimedTextStyle, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ITimedTextStyle, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ITimedTextStyle, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<ITimedTextStyle, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Name(HSTRING value)
    {
        return ((delegate* unmanaged<ITimedTextStyle, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FontFamily(HSTRING* value)
    {
        return ((delegate* unmanaged<ITimedTextStyle, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_FontFamily(HSTRING value)
    {
        return ((delegate* unmanaged<ITimedTextStyle, HSTRING, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_FontSize(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble *")] TimedTextDouble* value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle, TimedTextDouble*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_FontSize(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble")] TimedTextDouble value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle, TimedTextDouble, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FontWeight(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextWeight *")] TimedTextWeight* value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle, TimedTextWeight*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_FontWeight(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextWeight")] TimedTextWeight value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle, TimedTextWeight, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Foreground([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<ITimedTextStyle, Color*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Foreground([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<ITimedTextStyle, Color, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Background([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<ITimedTextStyle, Color*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Background([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<ITimedTextStyle, Color, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_IsBackgroundAlwaysShown([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ITimedTextStyle, byte*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_IsBackgroundAlwaysShown([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ITimedTextStyle, byte, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_FlowDirection(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextFlowDirection *")]
            TimedTextFlowDirection* value
    )
    {
        return (
            (delegate* unmanaged<ITimedTextStyle, TimedTextFlowDirection*, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_FlowDirection(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextFlowDirection")]
            TimedTextFlowDirection value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle, TimedTextFlowDirection, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_LineAlignment(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextLineAlignment *")]
            TimedTextLineAlignment* value
    )
    {
        return (
            (delegate* unmanaged<ITimedTextStyle, TimedTextLineAlignment*, int>)((*lpVtbl)[22])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_LineAlignment(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextLineAlignment")]
            TimedTextLineAlignment value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle, TimedTextLineAlignment, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_OutlineColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<ITimedTextStyle, Color*, int>)((*lpVtbl)[24]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_OutlineColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<ITimedTextStyle, Color, int>)((*lpVtbl)[25]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_OutlineThickness(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble *")] TimedTextDouble* value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle, TimedTextDouble*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_OutlineThickness(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble")] TimedTextDouble value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle, TimedTextDouble, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_OutlineRadius(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble *")] TimedTextDouble* value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle, TimedTextDouble*, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_OutlineRadius(
        [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble")] TimedTextDouble value
    )
    {
        return ((delegate* unmanaged<ITimedTextStyle, TimedTextDouble, int>)((*lpVtbl)[29]))(
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
        HRESULT get_FontFamily(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_FontFamily(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_FontSize(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble *")] TimedTextDouble* value
        );

        [VtblIndex(11)]
        HRESULT put_FontSize(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble")] TimedTextDouble value
        );

        [VtblIndex(12)]
        HRESULT get_FontWeight(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextWeight *")] TimedTextWeight* value
        );

        [VtblIndex(13)]
        HRESULT put_FontWeight(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextWeight")] TimedTextWeight value
        );

        [VtblIndex(14)]
        HRESULT get_Foreground([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(15)]
        HRESULT put_Foreground([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(16)]
        HRESULT get_Background([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(17)]
        HRESULT put_Background([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(18)]
        HRESULT get_IsBackgroundAlwaysShown([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT put_IsBackgroundAlwaysShown([NativeTypeName("boolean")] byte value);

        [VtblIndex(20)]
        HRESULT get_FlowDirection(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextFlowDirection *")]
                TimedTextFlowDirection* value
        );

        [VtblIndex(21)]
        HRESULT put_FlowDirection(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextFlowDirection")]
                TimedTextFlowDirection value
        );

        [VtblIndex(22)]
        HRESULT get_LineAlignment(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextLineAlignment *")]
                TimedTextLineAlignment* value
        );

        [VtblIndex(23)]
        HRESULT put_LineAlignment(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextLineAlignment")]
                TimedTextLineAlignment value
        );

        [VtblIndex(24)]
        HRESULT get_OutlineColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(25)]
        HRESULT put_OutlineColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(26)]
        HRESULT get_OutlineThickness(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble *")] TimedTextDouble* value
        );

        [VtblIndex(27)]
        HRESULT put_OutlineThickness(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble")] TimedTextDouble value
        );

        [VtblIndex(28)]
        HRESULT get_OutlineRadius(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble *")] TimedTextDouble* value
        );

        [VtblIndex(29)]
        HRESULT put_OutlineRadius(
            [NativeTypeName("ABI::Windows::Media::Core::TimedTextDouble")] TimedTextDouble value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_FontFamily;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_FontFamily;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextDouble *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextDouble*, int> get_FontSize;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextDouble) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextDouble, int> put_FontSize;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextWeight *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextWeight*, int> get_FontWeight;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextWeight) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextWeight, int> put_FontWeight;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Foreground;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color, int> put_Foreground;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_Background;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color, int> put_Background;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsBackgroundAlwaysShown;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsBackgroundAlwaysShown;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextFlowDirection *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextFlowDirection*, int> get_FlowDirection;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextFlowDirection) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextFlowDirection, int> put_FlowDirection;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextLineAlignment *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextLineAlignment*, int> get_LineAlignment;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextLineAlignment) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextLineAlignment, int> put_LineAlignment;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_OutlineColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color, int> put_OutlineColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextDouble *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextDouble*, int> get_OutlineThickness;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextDouble) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextDouble, int> put_OutlineThickness;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextDouble *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextDouble*, int> get_OutlineRadius;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::TimedTextDouble) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimedTextDouble, int> put_OutlineRadius;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITimedTextStyle"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITimedTextStyle(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ITimedTextStyle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ITimedTextStyle(Silk.NET.WinRT.IInspectable value)
    {
        return new ITimedTextStyle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextStyle"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextStyle"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ITimedTextStyle value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITimedTextStyle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITimedTextStyle(Silk.NET.Windows.IUnknown value)
    {
        return new ITimedTextStyle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITimedTextStyle"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITimedTextStyle"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITimedTextStyle value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
