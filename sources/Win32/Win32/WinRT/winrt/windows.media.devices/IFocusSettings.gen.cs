// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("79958F6B-3263-4275-85D6-AEAE891C96EE")]
[NativeTypeName("struct IFocusSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFocusSettings : IFocusSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFocusSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFocusSettings, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFocusSettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFocusSettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFocusSettings, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFocusSettings, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFocusSettings, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Mode(
        [NativeTypeName("ABI::Windows::Media::Devices::FocusMode *")] FocusMode* value
    )
    {
        return ((delegate* unmanaged<IFocusSettings, FocusMode*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Mode(
        [NativeTypeName("ABI::Windows::Media::Devices::FocusMode")] FocusMode value
    )
    {
        return ((delegate* unmanaged<IFocusSettings, FocusMode, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AutoFocusRange(
        [NativeTypeName("ABI::Windows::Media::Devices::AutoFocusRange *")] AutoFocusRange* value
    )
    {
        return ((delegate* unmanaged<IFocusSettings, AutoFocusRange*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AutoFocusRange(
        [NativeTypeName("ABI::Windows::Media::Devices::AutoFocusRange")] AutoFocusRange value
    )
    {
        return ((delegate* unmanaged<IFocusSettings, AutoFocusRange, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Value(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return ((delegate* unmanaged<IFocusSettings, IReference<uint>**, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Value(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
            IReference<uint>* value
    )
    {
        return ((delegate* unmanaged<IFocusSettings, IReference<uint>*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Distance(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CManualFocusDistance_t **"
        )]
            IReference<ManualFocusDistance>** value
    )
    {
        return (
            (delegate* unmanaged<IFocusSettings, IReference<ManualFocusDistance>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Distance(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CManualFocusDistance_t *"
        )]
            IReference<ManualFocusDistance>* value
    )
    {
        return (
            (delegate* unmanaged<IFocusSettings, IReference<ManualFocusDistance>*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_WaitForFocus([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IFocusSettings, byte*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_WaitForFocus([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IFocusSettings, byte, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DisableDriverFallback([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IFocusSettings, byte*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_DisableDriverFallback([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IFocusSettings, byte, int>)((*lpVtbl)[17]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Mode(
            [NativeTypeName("ABI::Windows::Media::Devices::FocusMode *")] FocusMode* value
        );

        [VtblIndex(7)]
        HRESULT put_Mode(
            [NativeTypeName("ABI::Windows::Media::Devices::FocusMode")] FocusMode value
        );

        [VtblIndex(8)]
        HRESULT get_AutoFocusRange(
            [NativeTypeName("ABI::Windows::Media::Devices::AutoFocusRange *")] AutoFocusRange* value
        );

        [VtblIndex(9)]
        HRESULT put_AutoFocusRange(
            [NativeTypeName("ABI::Windows::Media::Devices::AutoFocusRange")] AutoFocusRange value
        );

        [VtblIndex(10)]
        HRESULT get_Value(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(11)]
        HRESULT put_Value(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
                IReference<uint>* value
        );

        [VtblIndex(12)]
        HRESULT get_Distance(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CManualFocusDistance_t **"
            )]
                IReference<ManualFocusDistance>** value
        );

        [VtblIndex(13)]
        HRESULT put_Distance(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CManualFocusDistance_t *"
            )]
                IReference<ManualFocusDistance>* value
        );

        [VtblIndex(14)]
        HRESULT get_WaitForFocus([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_WaitForFocus([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT get_DisableDriverFallback([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT put_DisableDriverFallback([NativeTypeName("boolean")] byte value);
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
            "HRESULT (ABI::Windows::Media::Devices::FocusMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FocusMode*, int> get_Mode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::FocusMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FocusMode, int> put_Mode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::AutoFocusRange *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AutoFocusRange*, int> get_AutoFocusRange;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::AutoFocusRange) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AutoFocusRange, int> put_AutoFocusRange;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_Value;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>*, int> put_Value;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CManualFocusDistance_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ManualFocusDistance>**, int> get_Distance;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CDevices__CManualFocusDistance_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ManualFocusDistance>*, int> put_Distance;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_WaitForFocus;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_WaitForFocus;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_DisableDriverFallback;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_DisableDriverFallback;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFocusSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFocusSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFocusSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFocusSettings(Silk.NET.WinRT.IInspectable value)
    {
        return new IFocusSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFocusSettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFocusSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFocusSettings value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFocusSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFocusSettings(Silk.NET.Windows.IUnknown value)
    {
        return new IFocusSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFocusSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFocusSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFocusSettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
