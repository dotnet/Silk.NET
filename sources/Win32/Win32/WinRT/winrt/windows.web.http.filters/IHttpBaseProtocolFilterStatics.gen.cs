// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.filters.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6D4DEE0C-E908-494E-B5A3-1263C9B8242A")]
[NativeTypeName("struct IHttpBaseProtocolFilterStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpBaseProtocolFilterStatics
    : IHttpBaseProtocolFilterStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpBaseProtocolFilterStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHttpBaseProtocolFilterStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilterStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilterStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHttpBaseProtocolFilterStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpBaseProtocolFilterStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHttpBaseProtocolFilterStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateForUser(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        [NativeTypeName("ABI::Windows::Web::Http::Filters::IHttpBaseProtocolFilter **")]
            IHttpBaseProtocolFilter* result
    )
    {
        return (
            (delegate* unmanaged<
                IHttpBaseProtocolFilterStatics,
                IUser,
                IHttpBaseProtocolFilter*,
                int>)((*lpVtbl)[6])
        )(this, user, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateForUser(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            [NativeTypeName("ABI::Windows::Web::Http::Filters::IHttpBaseProtocolFilter **")]
                IHttpBaseProtocolFilter* result
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
            "HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Web::Http::Filters::IHttpBaseProtocolFilter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUser, IHttpBaseProtocolFilter*, int> CreateForUser;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpBaseProtocolFilterStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpBaseProtocolFilterStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpBaseProtocolFilterStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpBaseProtocolFilterStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IHttpBaseProtocolFilterStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpBaseProtocolFilterStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpBaseProtocolFilterStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IHttpBaseProtocolFilterStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpBaseProtocolFilterStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpBaseProtocolFilterStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpBaseProtocolFilterStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpBaseProtocolFilterStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpBaseProtocolFilterStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpBaseProtocolFilterStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
