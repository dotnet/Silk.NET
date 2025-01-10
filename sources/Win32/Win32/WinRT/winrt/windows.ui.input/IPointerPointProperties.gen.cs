// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C79D8A4B-C163-4EE7-803F-67CE79F9972D")]
[NativeTypeName("struct IPointerPointProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPointerPointProperties
    : IPointerPointProperties.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPointerPointProperties));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPointerPointProperties, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPointerPointProperties, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPointerPointProperties, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPointerPointProperties, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPointerPointProperties, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPointerPointProperties, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Pressure(float* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, float*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsInverted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsEraser([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Orientation(float* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, float*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_XTilt(float* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, float*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_YTilt(float* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, float*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Twist(float* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, float*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ContactRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, Rect*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ContactRectRaw(
        [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value
    )
    {
        return ((delegate* unmanaged<IPointerPointProperties, Rect*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_TouchConfidence([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsLeftButtonPressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_IsRightButtonPressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_IsMiddleButtonPressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_MouseWheelDelta([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, int*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_IsHorizontalMouseWheel([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_IsPrimary([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_IsInRange([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_IsBarrelButtonPressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_IsXButton1Pressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_IsXButton2Pressed([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPointerPointProperties, byte*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_PointerUpdateKind(
        [NativeTypeName("ABI::Windows::UI::Input::PointerUpdateKind *")] PointerUpdateKind* value
    )
    {
        return (
            (delegate* unmanaged<IPointerPointProperties, PointerUpdateKind*, int>)((*lpVtbl)[27])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT HasUsage(
        [NativeTypeName("UINT32")] uint usagePage,
        [NativeTypeName("UINT32")] uint usageId,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return (
            (delegate* unmanaged<IPointerPointProperties, uint, uint, byte*, int>)((*lpVtbl)[28])
        )(this, usagePage, usageId, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetUsageValue(
        [NativeTypeName("UINT32")] uint usagePage,
        [NativeTypeName("UINT32")] uint usageId,
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return (
            (delegate* unmanaged<IPointerPointProperties, uint, uint, int*, int>)((*lpVtbl)[29])
        )(this, usagePage, usageId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Pressure(float* value);

        [VtblIndex(7)]
        HRESULT get_IsInverted([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_IsEraser([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_Orientation(float* value);

        [VtblIndex(10)]
        HRESULT get_XTilt(float* value);

        [VtblIndex(11)]
        HRESULT get_YTilt(float* value);

        [VtblIndex(12)]
        HRESULT get_Twist(float* value);

        [VtblIndex(13)]
        HRESULT get_ContactRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(14)]
        HRESULT get_ContactRectRaw(
            [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value
        );

        [VtblIndex(15)]
        HRESULT get_TouchConfidence([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT get_IsLeftButtonPressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT get_IsRightButtonPressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(18)]
        HRESULT get_IsMiddleButtonPressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT get_MouseWheelDelta([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(20)]
        HRESULT get_IsHorizontalMouseWheel([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(21)]
        HRESULT get_IsPrimary([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(22)]
        HRESULT get_IsInRange([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(23)]
        HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(24)]
        HRESULT get_IsBarrelButtonPressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(25)]
        HRESULT get_IsXButton1Pressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(26)]
        HRESULT get_IsXButton2Pressed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(27)]
        HRESULT get_PointerUpdateKind(
            [NativeTypeName("ABI::Windows::UI::Input::PointerUpdateKind *")]
                PointerUpdateKind* value
        );

        [VtblIndex(28)]
        HRESULT HasUsage(
            [NativeTypeName("UINT32")] uint usagePage,
            [NativeTypeName("UINT32")] uint usageId,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(29)]
        HRESULT GetUsageValue(
            [NativeTypeName("UINT32")] uint usagePage,
            [NativeTypeName("UINT32")] uint usageId,
            [NativeTypeName("INT32 *")] int* value
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Pressure;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsInverted;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsEraser;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Orientation;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_XTilt;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_YTilt;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Twist;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect*, int> get_ContactRect;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect*, int> get_ContactRectRaw;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_TouchConfidence;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsLeftButtonPressed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsRightButtonPressed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsMiddleButtonPressed;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MouseWheelDelta;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsHorizontalMouseWheel;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsPrimary;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsInRange;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsCanceled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsBarrelButtonPressed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsXButton1Pressed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsXButton2Pressed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Input::PointerUpdateKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PointerUpdateKind*, int> get_PointerUpdateKind;

        [NativeTypeName("HRESULT (UINT32, UINT32, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, int> HasUsage;

        [NativeTypeName("HRESULT (UINT32, UINT32, INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int*, int> GetUsageValue;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPointerPointProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPointerPointProperties(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPointerPointProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPointerPointProperties(Silk.NET.WinRT.IInspectable value)
    {
        return new IPointerPointProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPointerPointProperties"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPointerPointProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPointerPointProperties value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPointerPointProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPointerPointProperties(Silk.NET.Windows.IUnknown value)
    {
        return new IPointerPointProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPointerPointProperties"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPointerPointProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPointerPointProperties value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
