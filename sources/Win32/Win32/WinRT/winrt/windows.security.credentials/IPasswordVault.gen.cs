// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("61FD2C0B-C8D4-48C1-A54F-BC5A64205AF2")]
[NativeTypeName("struct IPasswordVault : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPasswordVault : IPasswordVault.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPasswordVault));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPasswordVault, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPasswordVault, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPasswordVault, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPasswordVault, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPasswordVault, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPasswordVault, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Add(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
            IPasswordCredential credential
    )
    {
        return ((delegate* unmanaged<IPasswordVault, IPasswordCredential, int>)((*lpVtbl)[6]))(
            this,
            credential
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Remove(
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
            IPasswordCredential credential
    )
    {
        return ((delegate* unmanaged<IPasswordVault, IPasswordCredential, int>)((*lpVtbl)[7]))(
            this,
            credential
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Retrieve(
        HSTRING resource,
        HSTRING userName,
        [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
            IPasswordCredential* credential
    )
    {
        return (
            (delegate* unmanaged<IPasswordVault, HSTRING, HSTRING, IPasswordCredential*, int>)(
                (*lpVtbl)[8]
            )
        )(this, resource, userName, credential);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindAllByResource(
        HSTRING resource,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **"
        )]
            IVectorView<IntPtr>** credentials
    )
    {
        return (
            (delegate* unmanaged<IPasswordVault, HSTRING, IVectorView<IntPtr>**, int>)((*lpVtbl)[9])
        )(this, resource, credentials);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindAllByUserName(
        HSTRING userName,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **"
        )]
            IVectorView<IntPtr>** credentials
    )
    {
        return (
            (delegate* unmanaged<IPasswordVault, HSTRING, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, userName, credentials);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RetrieveAll(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **"
        )]
            IVectorView<IntPtr>** credentials
    )
    {
        return ((delegate* unmanaged<IPasswordVault, IVectorView<IntPtr>**, int>)((*lpVtbl)[11]))(
            this,
            credentials
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Add(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
                IPasswordCredential credential
        );

        [VtblIndex(7)]
        HRESULT Remove(
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential *")]
                IPasswordCredential credential
        );

        [VtblIndex(8)]
        HRESULT Retrieve(
            HSTRING resource,
            HSTRING userName,
            [NativeTypeName("ABI::Windows::Security::Credentials::IPasswordCredential **")]
                IPasswordCredential* credential
        );

        [VtblIndex(9)]
        HRESULT FindAllByResource(
            HSTRING resource,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **"
            )]
                IVectorView<IntPtr>** credentials
        );

        [VtblIndex(10)]
        HRESULT FindAllByUserName(
            HSTRING userName,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **"
            )]
                IVectorView<IntPtr>** credentials
        );

        [VtblIndex(11)]
        HRESULT RetrieveAll(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **"
            )]
                IVectorView<IntPtr>** credentials
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
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential, int> Add;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Credentials::IPasswordCredential *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPasswordCredential, int> Remove;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Security::Credentials::IPasswordCredential **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, IPasswordCredential*, int> Retrieve;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IVectorView<IntPtr>**, int> FindAllByResource;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IVectorView<IntPtr>**, int> FindAllByUserName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CSecurity__CCredentials__CPasswordCredential_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> RetrieveAll;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPasswordVault"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPasswordVault(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPasswordVault"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPasswordVault(Silk.NET.WinRT.IInspectable value)
    {
        return new IPasswordVault(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPasswordVault"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPasswordVault"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPasswordVault value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPasswordVault"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPasswordVault(Silk.NET.Windows.IUnknown value)
    {
        return new IPasswordVault(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPasswordVault"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPasswordVault"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPasswordVault value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
