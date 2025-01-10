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

[Guid("1CBA2C83-6CB6-5A04-A6FC-3BE7B33FF056")]
[NativeTypeName("struct IInfraredTorchControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInfraredTorchControl : IInfraredTorchControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInfraredTorchControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInfraredTorchControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInfraredTorchControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInfraredTorchControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IInfraredTorchControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IInfraredTorchControl, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IInfraredTorchControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IInfraredTorchControl, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedModes(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CInfraredTorchMode_t **"
        )]
            IVectorView<InfraredTorchMode>** value
    )
    {
        return (
            (delegate* unmanaged<IInfraredTorchControl, IVectorView<InfraredTorchMode>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CurrentMode(
        [NativeTypeName("ABI::Windows::Media::Devices::InfraredTorchMode *")]
            InfraredTorchMode* value
    )
    {
        return (
            (delegate* unmanaged<IInfraredTorchControl, InfraredTorchMode*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CurrentMode(
        [NativeTypeName("ABI::Windows::Media::Devices::InfraredTorchMode")] InfraredTorchMode value
    )
    {
        return ((delegate* unmanaged<IInfraredTorchControl, InfraredTorchMode, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MinPower([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IInfraredTorchControl, int*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MaxPower([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IInfraredTorchControl, int*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PowerStep([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IInfraredTorchControl, int*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Power([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IInfraredTorchControl, int*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Power([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<IInfraredTorchControl, int, int>)((*lpVtbl)[14]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SupportedModes(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CInfraredTorchMode_t **"
            )]
                IVectorView<InfraredTorchMode>** value
        );

        [VtblIndex(8)]
        HRESULT get_CurrentMode(
            [NativeTypeName("ABI::Windows::Media::Devices::InfraredTorchMode *")]
                InfraredTorchMode* value
        );

        [VtblIndex(9)]
        HRESULT put_CurrentMode(
            [NativeTypeName("ABI::Windows::Media::Devices::InfraredTorchMode")]
                InfraredTorchMode value
        );

        [VtblIndex(10)]
        HRESULT get_MinPower([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(11)]
        HRESULT get_MaxPower([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT get_PowerStep([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT get_Power([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(14)]
        HRESULT put_Power([NativeTypeName("INT32")] int value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsSupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CInfraredTorchMode_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<InfraredTorchMode>**,
            int> get_SupportedModes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::InfraredTorchMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, InfraredTorchMode*, int> get_CurrentMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::InfraredTorchMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, InfraredTorchMode, int> put_CurrentMode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MinPower;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MaxPower;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_PowerStep;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Power;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_Power;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInfraredTorchControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInfraredTorchControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IInfraredTorchControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IInfraredTorchControl(Silk.NET.WinRT.IInspectable value)
    {
        return new IInfraredTorchControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInfraredTorchControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IInfraredTorchControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IInfraredTorchControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInfraredTorchControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInfraredTorchControl(Silk.NET.Windows.IUnknown value)
    {
        return new IInfraredTorchControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInfraredTorchControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInfraredTorchControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInfraredTorchControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
