// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("88F1A1B8-78AB-4EE8-B4E3-046D6E2FE5E2")]
[NativeTypeName("struct IEmailQueryOptionsFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailQueryOptionsFactory
    : IEmailQueryOptionsFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailQueryOptionsFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEmailQueryOptionsFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEmailQueryOptionsFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailQueryOptionsFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IEmailQueryOptionsFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailQueryOptionsFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IEmailQueryOptionsFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithText(
        HSTRING text,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions **")]
            IEmailQueryOptions* result
    )
    {
        return (
            (delegate* unmanaged<IEmailQueryOptionsFactory, HSTRING, IEmailQueryOptions*, int>)(
                (*lpVtbl)[6]
            )
        )(this, text, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithTextAndFields(
        HSTRING text,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySearchFields")]
            EmailQuerySearchFields fields,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions **")]
            IEmailQueryOptions* result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailQueryOptionsFactory,
                HSTRING,
                EmailQuerySearchFields,
                IEmailQueryOptions*,
                int>)((*lpVtbl)[7])
        )(this, text, fields, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithText(
            HSTRING text,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions **")]
                IEmailQueryOptions* result
        );

        [VtblIndex(7)]
        HRESULT CreateWithTextAndFields(
            HSTRING text,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailQuerySearchFields")]
                EmailQuerySearchFields fields,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions **")]
                IEmailQueryOptions* result
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
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Email::IEmailQueryOptions **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IEmailQueryOptions*, int> CreateWithText;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Email::EmailQuerySearchFields, ABI::Windows::ApplicationModel::Email::IEmailQueryOptions **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            EmailQuerySearchFields,
            IEmailQueryOptions*,
            int> CreateWithTextAndFields;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailQueryOptionsFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailQueryOptionsFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailQueryOptionsFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailQueryOptionsFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IEmailQueryOptionsFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailQueryOptionsFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailQueryOptionsFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IEmailQueryOptionsFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailQueryOptionsFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailQueryOptionsFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailQueryOptionsFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailQueryOptionsFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailQueryOptionsFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailQueryOptionsFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
