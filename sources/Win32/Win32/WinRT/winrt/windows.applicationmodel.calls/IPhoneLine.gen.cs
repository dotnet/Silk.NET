// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("27C66F30-6A69-34CA-A2BA-65302530C311")]
[NativeTypeName("struct IPhoneLine : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneLine : IPhoneLine.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneLine));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPhoneLine, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPhoneLine, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPhoneLine, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPhoneLine, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPhoneLine, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPhoneLine, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_LineChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLine_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneLine,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_LineChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IPhoneLine, EventRegistrationToken, int>)((*lpVtbl)[7]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Id(Guid* value)
    {
        return ((delegate* unmanaged<IPhoneLine, Guid*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DisplayColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<IPhoneLine, Color*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_NetworkState(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneNetworkState *")]
            PhoneNetworkState* value
    )
    {
        return ((delegate* unmanaged<IPhoneLine, PhoneNetworkState*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IPhoneLine, HSTRING*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Voicemail(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneVoicemail **")]
            IPhoneVoicemail* value
    )
    {
        return ((delegate* unmanaged<IPhoneLine, IPhoneVoicemail*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_NetworkName(HSTRING* value)
    {
        return ((delegate* unmanaged<IPhoneLine, HSTRING*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CellularDetails(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineCellularDetails **")]
            IPhoneLineCellularDetails* value
    )
    {
        return ((delegate* unmanaged<IPhoneLine, IPhoneLineCellularDetails*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Transport(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineTransport *")]
            PhoneLineTransport* value
    )
    {
        return ((delegate* unmanaged<IPhoneLine, PhoneLineTransport*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CanDial([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPhoneLine, byte*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SupportsTile([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPhoneLine, byte*, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_VideoCallingCapabilities(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallVideoCapabilities **")]
            IPhoneCallVideoCapabilities* value
    )
    {
        return (
            (delegate* unmanaged<IPhoneLine, IPhoneCallVideoCapabilities*, int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_LineConfiguration(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineConfiguration **")]
            IPhoneLineConfiguration* value
    )
    {
        return ((delegate* unmanaged<IPhoneLine, IPhoneLineConfiguration*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT IsImmediateDialNumberAsync(
        HSTRING number,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<IPhoneLine, HSTRING, IAsyncOperation<byte>**, int>)((*lpVtbl)[20])
        )(this, number, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT Dial(HSTRING number, HSTRING displayName)
    {
        return ((delegate* unmanaged<IPhoneLine, HSTRING, HSTRING, int>)((*lpVtbl)[21]))(
            this,
            number,
            displayName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT DialWithOptions(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneDialOptions *")]
            IPhoneDialOptions options
    )
    {
        return ((delegate* unmanaged<IPhoneLine, IPhoneDialOptions, int>)((*lpVtbl)[22]))(
            this,
            options
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_LineChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLine_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_LineChanged(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_Id(Guid* value);

        [VtblIndex(9)]
        HRESULT get_DisplayColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(10)]
        HRESULT get_NetworkState(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneNetworkState *")]
                PhoneNetworkState* value
        );

        [VtblIndex(11)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Voicemail(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneVoicemail **")]
                IPhoneVoicemail* value
        );

        [VtblIndex(13)]
        HRESULT get_NetworkName(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_CellularDetails(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineCellularDetails **")]
                IPhoneLineCellularDetails* value
        );

        [VtblIndex(15)]
        HRESULT get_Transport(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineTransport *")]
                PhoneLineTransport* value
        );

        [VtblIndex(16)]
        HRESULT get_CanDial([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT get_SupportsTile([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(18)]
        HRESULT get_VideoCallingCapabilities(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Calls::IPhoneCallVideoCapabilities **"
            )]
                IPhoneCallVideoCapabilities* value
        );

        [VtblIndex(19)]
        HRESULT get_LineConfiguration(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineConfiguration **")]
                IPhoneLineConfiguration* value
        );

        [VtblIndex(20)]
        HRESULT IsImmediateDialNumberAsync(
            HSTRING number,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(21)]
        HRESULT Dial(HSTRING number, HSTRING displayName);

        [VtblIndex(22)]
        HRESULT DialWithOptions(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneDialOptions *")]
                IPhoneDialOptions options
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CCalls__CPhoneLine_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_LineChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_LineChanged;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_Id;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_DisplayColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneNetworkState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneNetworkState*, int> get_NetworkState;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneVoicemail **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPhoneVoicemail*, int> get_Voicemail;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_NetworkName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneLineCellularDetails **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPhoneLineCellularDetails*, int> get_CellularDetails;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneLineTransport *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneLineTransport*, int> get_Transport;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanDial;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SupportsTile;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallVideoCapabilities **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IPhoneCallVideoCapabilities*,
            int> get_VideoCallingCapabilities;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneLineConfiguration **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPhoneLineConfiguration*, int> get_LineConfiguration;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<byte>**,
            int> IsImmediateDialNumberAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, int> Dial;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneDialOptions *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPhoneDialOptions, int> DialWithOptions;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPhoneLine"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPhoneLine(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPhoneLine"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPhoneLine(Silk.NET.WinRT.IInspectable value)
    {
        return new IPhoneLine(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneLine"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneLine"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPhoneLine value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPhoneLine"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPhoneLine(Silk.NET.Windows.IUnknown value)
    {
        return new IPhoneLine(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneLine"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneLine"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPhoneLine value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
