// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.protection.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("45694947-C741-434B-A79E-474C12D93D2F")]
[NativeTypeName("struct IMediaProtectionManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaProtectionManager
    : IMediaProtectionManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaProtectionManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaProtectionManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaProtectionManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaProtectionManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaProtectionManager, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaProtectionManager, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaProtectionManager, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ServiceRequested(
        [NativeTypeName("ABI::Windows::Media::Protection::IServiceRequestedEventHandler *")]
            IServiceRequestedEventHandler handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                IMediaProtectionManager,
                IServiceRequestedEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ServiceRequested(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<IMediaProtectionManager, EventRegistrationToken, int>)(
                (*lpVtbl)[7]
            )
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_RebootNeeded(
        [NativeTypeName("ABI::Windows::Media::Protection::IRebootNeededEventHandler *")]
            IRebootNeededEventHandler handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                IMediaProtectionManager,
                IRebootNeededEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_RebootNeeded(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<IMediaProtectionManager, EventRegistrationToken, int>)(
                (*lpVtbl)[9]
            )
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ComponentLoadFailed(
        [NativeTypeName("ABI::Windows::Media::Protection::IComponentLoadFailedEventHandler *")]
            IComponentLoadFailedEventHandler handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                IMediaProtectionManager,
                IComponentLoadFailedEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ComponentLoadFailed(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<IMediaProtectionManager, EventRegistrationToken, int>)(
                (*lpVtbl)[11]
            )
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Properties(
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")]
            IPropertySet* value
    )
    {
        return ((delegate* unmanaged<IMediaProtectionManager, IPropertySet*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ServiceRequested(
            [NativeTypeName("ABI::Windows::Media::Protection::IServiceRequestedEventHandler *")]
                IServiceRequestedEventHandler handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(7)]
        HRESULT remove_ServiceRequested(EventRegistrationToken cookie);

        [VtblIndex(8)]
        HRESULT add_RebootNeeded(
            [NativeTypeName("ABI::Windows::Media::Protection::IRebootNeededEventHandler *")]
                IRebootNeededEventHandler handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(9)]
        HRESULT remove_RebootNeeded(EventRegistrationToken cookie);

        [VtblIndex(10)]
        HRESULT add_ComponentLoadFailed(
            [NativeTypeName("ABI::Windows::Media::Protection::IComponentLoadFailedEventHandler *")]
                IComponentLoadFailedEventHandler handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(11)]
        HRESULT remove_ComponentLoadFailed(EventRegistrationToken cookie);

        [VtblIndex(12)]
        HRESULT get_Properties(
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")]
                IPropertySet* value
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
            "HRESULT (ABI::Windows::Media::Protection::IServiceRequestedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IServiceRequestedEventHandler,
            EventRegistrationToken*,
            int> add_ServiceRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ServiceRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Protection::IRebootNeededEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRebootNeededEventHandler,
            EventRegistrationToken*,
            int> add_RebootNeeded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_RebootNeeded;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Protection::IComponentLoadFailedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IComponentLoadFailedEventHandler,
            EventRegistrationToken*,
            int> add_ComponentLoadFailed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ComponentLoadFailed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPropertySet*, int> get_Properties;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaProtectionManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaProtectionManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaProtectionManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaProtectionManager(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaProtectionManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaProtectionManager"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaProtectionManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaProtectionManager value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaProtectionManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaProtectionManager(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaProtectionManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaProtectionManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaProtectionManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaProtectionManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
