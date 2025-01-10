// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1AB217AD-6E34-49D3-9E6F-17F1B6DFA881")]
[NativeTypeName("struct IDeviceServicingTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceServicingTrigger
    : IDeviceServicingTrigger.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceServicingTrigger));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeviceServicingTrigger, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDeviceServicingTrigger, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceServicingTrigger, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDeviceServicingTrigger, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDeviceServicingTrigger, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDeviceServicingTrigger, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAsyncSimple(
        HSTRING deviceId,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan expectedDuration,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **"
        )]
            IAsyncOperation<DeviceTriggerResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceServicingTrigger,
                HSTRING,
                TimeSpan,
                IAsyncOperation<DeviceTriggerResult>**,
                int>)((*lpVtbl)[6])
        )(this, deviceId, expectedDuration, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAsyncWithArguments(
        HSTRING deviceId,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan expectedDuration,
        HSTRING arguments,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **"
        )]
            IAsyncOperation<DeviceTriggerResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceServicingTrigger,
                HSTRING,
                TimeSpan,
                HSTRING,
                IAsyncOperation<DeviceTriggerResult>**,
                int>)((*lpVtbl)[7])
        )(this, deviceId, expectedDuration, arguments, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAsyncSimple(
            HSTRING deviceId,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan expectedDuration,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **"
            )]
                IAsyncOperation<DeviceTriggerResult>** result
        );

        [VtblIndex(7)]
        HRESULT RequestAsyncWithArguments(
            HSTRING deviceId,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan expectedDuration,
            HSTRING arguments,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **"
            )]
                IAsyncOperation<DeviceTriggerResult>** result
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            TimeSpan,
            IAsyncOperation<DeviceTriggerResult>**,
            int> RequestAsyncSimple;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::TimeSpan, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CDeviceTriggerResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            TimeSpan,
            HSTRING,
            IAsyncOperation<DeviceTriggerResult>**,
            int> RequestAsyncWithArguments;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeviceServicingTrigger"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeviceServicingTrigger(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDeviceServicingTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDeviceServicingTrigger(Silk.NET.WinRT.IInspectable value)
    {
        return new IDeviceServicingTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceServicingTrigger"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceServicingTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDeviceServicingTrigger value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeviceServicingTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeviceServicingTrigger(Silk.NET.Windows.IUnknown value)
    {
        return new IDeviceServicingTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceServicingTrigger"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceServicingTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeviceServicingTrigger value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
