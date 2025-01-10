// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("9E6F41E6-BAF2-4A97-B600-9333F5DF80FD")]
[NativeTypeName("struct ICachedFileUpdaterUI : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICachedFileUpdaterUI : ICachedFileUpdaterUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICachedFileUpdaterUI));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICachedFileUpdaterUI, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI, HSTRING, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UpdateTarget(
        [NativeTypeName("ABI::Windows::Storage::Provider::CachedFileTarget *")]
            CachedFileTarget* value
    )
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI, CachedFileTarget*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_FileUpdateRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CCachedFileUpdaterUI_Windows__CStorage__CProvider__CFileUpdateRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICachedFileUpdaterUI,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_FileUpdateRequested(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ICachedFileUpdaterUI, EventRegistrationToken, int>)((*lpVtbl)[10])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_UIRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CCachedFileUpdaterUI_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICachedFileUpdaterUI,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_UIRequested(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ICachedFileUpdaterUI, EventRegistrationToken, int>)((*lpVtbl)[12])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_UIStatus(
        [NativeTypeName("ABI::Windows::Storage::Provider::UIStatus *")] UIStatus* value
    )
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI, UIStatus*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_UpdateTarget(
            [NativeTypeName("ABI::Windows::Storage::Provider::CachedFileTarget *")]
                CachedFileTarget* value
        );

        [VtblIndex(9)]
        HRESULT add_FileUpdateRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CCachedFileUpdaterUI_Windows__CStorage__CProvider__CFileUpdateRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(10)]
        HRESULT remove_FileUpdateRequested(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_UIRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CCachedFileUpdaterUI_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(12)]
        HRESULT remove_UIRequested(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT get_UIStatus(
            [NativeTypeName("ABI::Windows::Storage::Provider::UIStatus *")] UIStatus* value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::CachedFileTarget *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CachedFileTarget*, int> get_UpdateTarget;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CCachedFileUpdaterUI_Windows__CStorage__CProvider__CFileUpdateRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_FileUpdateRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_FileUpdateRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CProvider__CCachedFileUpdaterUI_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_UIRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_UIRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::UIStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UIStatus*, int> get_UIStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICachedFileUpdaterUI"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICachedFileUpdaterUI(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICachedFileUpdaterUI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICachedFileUpdaterUI(Silk.NET.WinRT.IInspectable value)
    {
        return new ICachedFileUpdaterUI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICachedFileUpdaterUI"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICachedFileUpdaterUI"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICachedFileUpdaterUI value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICachedFileUpdaterUI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICachedFileUpdaterUI(Silk.NET.Windows.IUnknown value)
    {
        return new ICachedFileUpdaterUI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICachedFileUpdaterUI"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICachedFileUpdaterUI"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICachedFileUpdaterUI value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
