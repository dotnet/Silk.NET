// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2EC4BDC3-D9A5-455A-9811-DE24D45337E9")]
[NativeTypeName("struct IWebSocketControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebSocketControl : IWebSocketControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebSocketControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWebSocketControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWebSocketControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebSocketControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWebSocketControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWebSocketControl, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWebSocketControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OutboundBufferSizeInBytes([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IWebSocketControl, uint*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_OutboundBufferSizeInBytes([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IWebSocketControl, uint, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ServerCredential(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
            IPasswordCredential* value
    )
    {
        return ((delegate* unmanaged<IWebSocketControl, IPasswordCredential*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ServerCredential(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
            IPasswordCredential value
    )
    {
        return ((delegate* unmanaged<IWebSocketControl, IPasswordCredential, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ProxyCredential(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
            IPasswordCredential* value
    )
    {
        return ((delegate* unmanaged<IWebSocketControl, IPasswordCredential*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ProxyCredential(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
            IPasswordCredential value
    )
    {
        return ((delegate* unmanaged<IWebSocketControl, IPasswordCredential, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_SupportedProtocols(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IWebSocketControl, IVector<HSTRING>**, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OutboundBufferSizeInBytes([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_OutboundBufferSizeInBytes([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_ServerCredential(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
                IPasswordCredential* value
        );

        [VtblIndex(9)]
        HRESULT put_ServerCredential(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
                IPasswordCredential value
        );

        [VtblIndex(10)]
        HRESULT get_ProxyCredential(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
                IPasswordCredential* value
        );

        [VtblIndex(11)]
        HRESULT put_ProxyCredential(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
                IPasswordCredential value
        );

        [VtblIndex(12)]
        HRESULT get_SupportedProtocols(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_OutboundBufferSizeInBytes;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_OutboundBufferSizeInBytes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential*, int> get_ServerCredential;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential, int> put_ServerCredential;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential*, int> get_ProxyCredential;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential, int> put_ProxyCredential;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_SupportedProtocols;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebSocketControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebSocketControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebSocketControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebSocketControl(Silk.NET.WinRT.IInspectable value)
    {
        return new IWebSocketControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebSocketControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebSocketControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWebSocketControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebSocketControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebSocketControl(Silk.NET.Windows.IUnknown value)
    {
        return new IWebSocketControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebSocketControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebSocketControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWebSocketControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
