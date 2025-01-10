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

[Guid("DB139AF2-78C9-4FEB-9622-452328088D62")]
[NativeTypeName("struct ISmsSendMessageResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsSendMessageResult : ISmsSendMessageResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsSendMessageResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmsSendMessageResult, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmsSendMessageResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsSendMessageResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmsSendMessageResult, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmsSendMessageResult, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmsSendMessageResult, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsSuccessful([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISmsSendMessageResult, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MessageReferenceNumbers(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_int_t **")]
            IVectorView<int>** value
    )
    {
        return (
            (delegate* unmanaged<ISmsSendMessageResult, IVectorView<int>**, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CellularClass(
        [NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value
    )
    {
        return ((delegate* unmanaged<ISmsSendMessageResult, CellularClass*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ModemErrorCode(
        [NativeTypeName("ABI::Windows::Devices::Sms::SmsModemErrorCode *")] SmsModemErrorCode* value
    )
    {
        return (
            (delegate* unmanaged<ISmsSendMessageResult, SmsModemErrorCode*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsErrorTransient([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISmsSendMessageResult, byte*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_NetworkCauseCode([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISmsSendMessageResult, int*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_TransportFailureCause([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISmsSendMessageResult, int*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsSuccessful([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_MessageReferenceNumbers(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_int_t **")]
                IVectorView<int>** value
        );

        [VtblIndex(8)]
        HRESULT get_CellularClass(
            [NativeTypeName("ABI::Windows::Devices::Sms::CellularClass *")] CellularClass* value
        );

        [VtblIndex(9)]
        HRESULT get_ModemErrorCode(
            [NativeTypeName("ABI::Windows::Devices::Sms::SmsModemErrorCode *")]
                SmsModemErrorCode* value
        );

        [VtblIndex(10)]
        HRESULT get_IsErrorTransient([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_NetworkCauseCode([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT get_TransportFailureCause([NativeTypeName("INT32 *")] int* value);
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
        public delegate* unmanaged<TSelf*, byte*, int> get_IsSuccessful;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_int_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<int>**, int> get_MessageReferenceNumbers;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::CellularClass *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CellularClass*, int> get_CellularClass;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::SmsModemErrorCode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SmsModemErrorCode*, int> get_ModemErrorCode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsErrorTransient;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NetworkCauseCode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TransportFailureCause;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsSendMessageResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsSendMessageResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmsSendMessageResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmsSendMessageResult(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmsSendMessageResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsSendMessageResult"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsSendMessageResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmsSendMessageResult value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsSendMessageResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsSendMessageResult(Silk.NET.Windows.IUnknown value)
    {
        return new ISmsSendMessageResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsSendMessageResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsSendMessageResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmsSendMessageResult value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
