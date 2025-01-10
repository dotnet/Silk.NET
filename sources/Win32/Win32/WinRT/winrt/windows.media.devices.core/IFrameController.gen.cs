// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C16459D9-BAEF-4052-9177-48AFF2AF7522")]
[NativeTypeName("struct IFrameController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFrameController : IFrameController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameController));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFrameController, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFrameController, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFrameController, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFrameController, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFrameController, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFrameController, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ExposureControl(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureControl **")]
            IFrameExposureControl* value
    )
    {
        return ((delegate* unmanaged<IFrameController, IFrameExposureControl*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExposureCompensationControl(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureCompensationControl **")]
            IFrameExposureCompensationControl* value
    )
    {
        return (
            (delegate* unmanaged<IFrameController, IFrameExposureCompensationControl*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsoSpeedControl(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameIsoSpeedControl **")]
            IFrameIsoSpeedControl* value
    )
    {
        return ((delegate* unmanaged<IFrameController, IFrameIsoSpeedControl*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_FocusControl(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameFocusControl **")]
            IFrameFocusControl* value
    )
    {
        return ((delegate* unmanaged<IFrameController, IFrameFocusControl*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PhotoConfirmationEnabled(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")]
            IReference<byte>** value
    )
    {
        return ((delegate* unmanaged<IFrameController, IReference<byte>**, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PhotoConfirmationEnabled(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")]
            IReference<byte>* value
    )
    {
        return ((delegate* unmanaged<IFrameController, IReference<byte>*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ExposureControl(
            [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureControl **")]
                IFrameExposureControl* value
        );

        [VtblIndex(7)]
        HRESULT get_ExposureCompensationControl(
            [NativeTypeName(
                "ABI::Windows::Media::Devices::Core::IFrameExposureCompensationControl **"
            )]
                IFrameExposureCompensationControl* value
        );

        [VtblIndex(8)]
        HRESULT get_IsoSpeedControl(
            [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameIsoSpeedControl **")]
                IFrameIsoSpeedControl* value
        );

        [VtblIndex(9)]
        HRESULT get_FocusControl(
            [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameFocusControl **")]
                IFrameFocusControl* value
        );

        [VtblIndex(10)]
        HRESULT get_PhotoConfirmationEnabled(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t **")]
                IReference<byte>** value
        );

        [VtblIndex(11)]
        HRESULT put_PhotoConfirmationEnabled(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_boolean_t *")]
                IReference<byte>* value
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
            "HRESULT (ABI::Windows::Media::Devices::Core::IFrameExposureControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFrameExposureControl*, int> get_ExposureControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::Core::IFrameExposureCompensationControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IFrameExposureCompensationControl*,
            int> get_ExposureCompensationControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::Core::IFrameIsoSpeedControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFrameIsoSpeedControl*, int> get_IsoSpeedControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::Core::IFrameFocusControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFrameFocusControl*, int> get_FocusControl;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<byte>**, int> get_PhotoConfirmationEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_boolean_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<byte>*, int> put_PhotoConfirmationEnabled;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFrameController"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFrameController(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFrameController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFrameController(Silk.NET.WinRT.IInspectable value)
    {
        return new IFrameController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFrameController"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFrameController"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFrameController value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFrameController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFrameController(Silk.NET.Windows.IUnknown value)
    {
        return new IFrameController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFrameController"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFrameController"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFrameController value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
