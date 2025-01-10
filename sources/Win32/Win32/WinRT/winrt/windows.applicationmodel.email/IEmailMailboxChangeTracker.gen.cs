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

[Guid("7AE48638-5166-42B7-8882-FD21C92BDD4B")]
[NativeTypeName("struct IEmailMailboxChangeTracker : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxChangeTracker
    : IEmailMailboxChangeTracker.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailboxChangeTracker));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IEmailMailboxChangeTracker, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEmailMailboxChangeTracker, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailMailboxChangeTracker, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IEmailMailboxChangeTracker, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailMailboxChangeTracker, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IEmailMailboxChangeTracker, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsTracking([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IEmailMailboxChangeTracker, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Enable()
    {
        return ((delegate* unmanaged<IEmailMailboxChangeTracker, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetChangeReader(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxChangeReader **")]
            IEmailMailboxChangeReader* value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailboxChangeTracker, IEmailMailboxChangeReader*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEmailMailboxChangeTracker, int>)((*lpVtbl)[9]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsTracking([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT Enable();

        [VtblIndex(8)]
        HRESULT GetChangeReader(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxChangeReader **")]
                IEmailMailboxChangeReader* value
        );

        [VtblIndex(9)]
        HRESULT Reset();
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
        public delegate* unmanaged<TSelf*, byte*, int> get_IsTracking;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Enable;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxChangeReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailMailboxChangeReader*, int> GetChangeReader;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailMailboxChangeTracker"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailMailboxChangeTracker(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailMailboxChangeTracker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailMailboxChangeTracker(Silk.NET.WinRT.IInspectable value)
    {
        return new IEmailMailboxChangeTracker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailMailboxChangeTracker"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailMailboxChangeTracker"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IEmailMailboxChangeTracker value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailMailboxChangeTracker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailMailboxChangeTracker(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailMailboxChangeTracker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailMailboxChangeTracker"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailMailboxChangeTracker"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailMailboxChangeTracker value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
