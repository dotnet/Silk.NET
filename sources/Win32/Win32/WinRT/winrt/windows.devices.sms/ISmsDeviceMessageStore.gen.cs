// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("9889F253-F188-4427-8D54-CE0C2423C5C1")]
[NativeTypeName("struct ISmsDeviceMessageStore : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISmsDeviceMessageStore : ISmsDeviceMessageStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsDeviceMessageStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmsDeviceMessageStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmsDeviceMessageStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsDeviceMessageStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmsDeviceMessageStore, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmsDeviceMessageStore, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmsDeviceMessageStore, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
    public HRESULT DeleteMessageAsync(
        [NativeTypeName("UINT32")] uint messageId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<ISmsDeviceMessageStore, uint, IAsyncAction*, int>)((*lpVtbl)[6])
        )(this, messageId, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
    public HRESULT DeleteMessagesAsync(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageFilter")]
            SmsMessageFilter messageFilter,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<ISmsDeviceMessageStore, SmsMessageFilter, IAsyncAction*, int>)(
                (*lpVtbl)[7]
            )
        )(this, messageFilter, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
    public HRESULT GetMessageAsync(
        [NativeTypeName("UINT32")] uint messageId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CISmsMessage_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<ISmsDeviceMessageStore, uint, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, messageId, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
    public HRESULT GetMessagesAsync(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageFilter")]
            SmsMessageFilter messageFilter,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2___FIVectorView_1_Windows__CDevices__CSms__CISmsMessage_int_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, int>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<
                ISmsDeviceMessageStore,
                SmsMessageFilter,
                IAsyncOperationWithProgress<IntPtr, int>**,
                int>)((*lpVtbl)[9])
        )(this, messageFilter, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_MaxMessages([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ISmsDeviceMessageStore, uint*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10."
        )]
        HRESULT DeleteMessageAsync(
            [NativeTypeName("UINT32")] uint messageId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(7)]
        [Obsolete(
            "SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10."
        )]
        HRESULT DeleteMessagesAsync(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageFilter")]
                SmsMessageFilter messageFilter,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(8)]
        [Obsolete(
            "SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10."
        )]
        HRESULT GetMessageAsync(
            [NativeTypeName("UINT32")] uint messageId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CISmsMessage_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(9)]
        [Obsolete(
            "SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10."
        )]
        HRESULT GetMessagesAsync(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsMessageFilter")]
                SmsMessageFilter messageFilter,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2___FIVectorView_1_Windows__CDevices__CSms__CISmsMessage_int_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, int>** asyncInfo
        );

        [VtblIndex(10)]
        [Obsolete(
            "SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10."
        )]
        HRESULT get_MaxMessages([NativeTypeName("UINT32 *")] uint* value);
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
            "HRESULT (UINT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10."
        )]
        public delegate* unmanaged<TSelf*, uint, IAsyncAction*, int> DeleteMessageAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::SmsMessageFilter, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10."
        )]
        public delegate* unmanaged<
            TSelf*,
            SmsMessageFilter,
            IAsyncAction*,
            int> DeleteMessagesAsync;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSms__CISmsMessage_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10."
        )]
        public delegate* unmanaged<TSelf*, uint, IAsyncOperation<IntPtr>**, int> GetMessageAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::SmsMessageFilter, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2___FIVectorView_1_Windows__CDevices__CSms__CISmsMessage_int_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10."
        )]
        public delegate* unmanaged<
            TSelf*,
            SmsMessageFilter,
            IAsyncOperationWithProgress<IntPtr, int>**,
            int> GetMessagesAsync;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete(
            "SmsDeviceMessageStore may be altered or unavailable for releases after Windows 10."
        )]
        public delegate* unmanaged<TSelf*, uint*, int> get_MaxMessages;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsDeviceMessageStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsDeviceMessageStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmsDeviceMessageStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmsDeviceMessageStore(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmsDeviceMessageStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsDeviceMessageStore"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsDeviceMessageStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmsDeviceMessageStore value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsDeviceMessageStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsDeviceMessageStore(Silk.NET.Windows.IUnknown value)
    {
        return new ISmsDeviceMessageStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsDeviceMessageStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsDeviceMessageStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmsDeviceMessageStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
