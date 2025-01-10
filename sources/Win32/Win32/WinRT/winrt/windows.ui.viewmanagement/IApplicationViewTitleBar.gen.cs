// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("00924AC0-932B-4A6B-9C4B-DC38C82478CE")]
[NativeTypeName("struct IApplicationViewTitleBar : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationViewTitleBar
    : IApplicationViewTitleBar.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationViewTitleBar));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationViewTitleBar, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IApplicationViewTitleBar, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationViewTitleBar, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IApplicationViewTitleBar, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IApplicationViewTitleBar, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IApplicationViewTitleBar, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_ForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>**, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_BackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>**, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ButtonForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ButtonForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>**, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_ButtonBackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ButtonBackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>**, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_ButtonHoverForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ButtonHoverForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>**, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_ButtonHoverBackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ButtonHoverBackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>**, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_ButtonPressedForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>*, int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ButtonPressedForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>**, int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_ButtonPressedBackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>*, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_ButtonPressedBackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>**, int>)((*lpVtbl)[21])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_InactiveForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>*, int>)((*lpVtbl)[22])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_InactiveForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>**, int>)((*lpVtbl)[23])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_InactiveBackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>*, int>)((*lpVtbl)[24])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_InactiveBackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>**, int>)((*lpVtbl)[25])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_ButtonInactiveForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>*, int>)((*lpVtbl)[26])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_ButtonInactiveForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>**, int>)((*lpVtbl)[27])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_ButtonInactiveBackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>*, int>)((*lpVtbl)[28])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_ButtonInactiveBackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationViewTitleBar, IReference<Color>**, int>)((*lpVtbl)[29])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_ForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(7)]
        HRESULT get_ForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(8)]
        HRESULT put_BackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(9)]
        HRESULT get_BackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(10)]
        HRESULT put_ButtonForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(11)]
        HRESULT get_ButtonForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(12)]
        HRESULT put_ButtonBackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(13)]
        HRESULT get_ButtonBackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(14)]
        HRESULT put_ButtonHoverForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(15)]
        HRESULT get_ButtonHoverForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(16)]
        HRESULT put_ButtonHoverBackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(17)]
        HRESULT get_ButtonHoverBackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(18)]
        HRESULT put_ButtonPressedForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(19)]
        HRESULT get_ButtonPressedForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(20)]
        HRESULT put_ButtonPressedBackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(21)]
        HRESULT get_ButtonPressedBackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(22)]
        HRESULT put_InactiveForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(23)]
        HRESULT get_InactiveForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(24)]
        HRESULT put_InactiveBackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(25)]
        HRESULT get_InactiveBackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(26)]
        HRESULT put_ButtonInactiveForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(27)]
        HRESULT get_ButtonInactiveForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(28)]
        HRESULT put_ButtonInactiveBackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(29)]
        HRESULT get_ButtonInactiveBackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>*, int> put_ForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>**, int> get_ForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>*, int> put_BackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>**, int> get_BackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>*, int> put_ButtonForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>**, int> get_ButtonForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>*, int> put_ButtonBackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>**, int> get_ButtonBackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>*, int> put_ButtonHoverForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>**, int> get_ButtonHoverForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>*, int> put_ButtonHoverBackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>**, int> get_ButtonHoverBackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<Color>*,
            int> put_ButtonPressedForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<Color>**,
            int> get_ButtonPressedForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<Color>*,
            int> put_ButtonPressedBackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<Color>**,
            int> get_ButtonPressedBackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>*, int> put_InactiveForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>**, int> get_InactiveForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>*, int> put_InactiveBackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>**, int> get_InactiveBackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<Color>*,
            int> put_ButtonInactiveForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<Color>**,
            int> get_ButtonInactiveForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<Color>*,
            int> put_ButtonInactiveBackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<Color>**,
            int> get_ButtonInactiveBackgroundColor;
    }

    /// <summary>Initializes a new instance of the <see cref = "IApplicationViewTitleBar"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IApplicationViewTitleBar(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IApplicationViewTitleBar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IApplicationViewTitleBar(Silk.NET.WinRT.IInspectable value)
    {
        return new IApplicationViewTitleBar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationViewTitleBar"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationViewTitleBar"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IApplicationViewTitleBar value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IApplicationViewTitleBar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IApplicationViewTitleBar(Silk.NET.Windows.IUnknown value)
    {
        return new IApplicationViewTitleBar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationViewTitleBar"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationViewTitleBar"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IApplicationViewTitleBar value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
