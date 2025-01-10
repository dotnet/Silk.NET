// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("BF8ECAAD-ED96-49A7-9084-D416CAE88DCB")]
[NativeTypeName("struct IHostName : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHostName : IHostName.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHostName));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHostName, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHostName, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHostName, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHostName, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHostName, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHostName, TrustLevel*, int>)((*lpVtbl)[5]))(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IPInformation(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::IIPInformation **")]
            IIPInformation* value
    )
    {
        return ((delegate* unmanaged<IHostName, IIPInformation*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RawName(HSTRING* value)
    {
        return ((delegate* unmanaged<IHostName, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IHostName, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CanonicalName(HSTRING* value)
    {
        return ((delegate* unmanaged<IHostName, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Type(
        [NativeTypeName("ABI::Windows::Networking::HostNameType *")] HostNameType* value
    )
    {
        return ((delegate* unmanaged<IHostName, HostNameType*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsEqual(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName hostName,
        [NativeTypeName("boolean *")] byte* isEqual
    )
    {
        return ((delegate* unmanaged<IHostName, IHostName, byte*, int>)((*lpVtbl)[11]))(
            this,
            hostName,
            isEqual
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IPInformation(
            [NativeTypeName("ABI::Windows::Networking::Connectivity::IIPInformation **")]
                IIPInformation* value
        );

        [VtblIndex(7)]
        HRESULT get_RawName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_CanonicalName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_Type(
            [NativeTypeName("ABI::Windows::Networking::HostNameType *")] HostNameType* value
        );

        [VtblIndex(11)]
        HRESULT IsEqual(
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName hostName,
            [NativeTypeName("boolean *")] byte* isEqual
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
            "HRESULT (ABI::Windows::Networking::Connectivity::IIPInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIPInformation*, int> get_IPInformation;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RawName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_CanonicalName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::HostNameType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HostNameType*, int> get_Type;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHostName, byte*, int> IsEqual;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHostName"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHostName(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHostName"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHostName(Silk.NET.WinRT.IInspectable value)
    {
        return new IHostName(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHostName"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHostName"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHostName value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHostName"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHostName(Silk.NET.Windows.IUnknown value)
    {
        return new IHostName(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHostName"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHostName"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHostName value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
