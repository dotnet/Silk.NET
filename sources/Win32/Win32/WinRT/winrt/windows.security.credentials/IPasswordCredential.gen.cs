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

[Guid("6AB18989-C720-41A7-A6C1-FEADB36329A0")]
[NativeTypeName("struct IPasswordCredential : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPasswordCredential : IPasswordCredential.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPasswordCredential));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPasswordCredential, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPasswordCredential, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPasswordCredential, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPasswordCredential, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPasswordCredential, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPasswordCredential, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Resource(HSTRING* resource)
    {
        return ((delegate* unmanaged<IPasswordCredential, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            resource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Resource(HSTRING resource)
    {
        return ((delegate* unmanaged<IPasswordCredential, HSTRING, int>)((*lpVtbl)[7]))(
            this,
            resource
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UserName(HSTRING* userName)
    {
        return ((delegate* unmanaged<IPasswordCredential, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            userName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_UserName(HSTRING userName)
    {
        return ((delegate* unmanaged<IPasswordCredential, HSTRING, int>)((*lpVtbl)[9]))(
            this,
            userName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Password(HSTRING* password)
    {
        return ((delegate* unmanaged<IPasswordCredential, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            password
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Password(HSTRING password)
    {
        return ((delegate* unmanaged<IPasswordCredential, HSTRING, int>)((*lpVtbl)[11]))(
            this,
            password
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RetrievePassword()
    {
        return ((delegate* unmanaged<IPasswordCredential, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Properties(
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")]
            IPropertySet* props
    )
    {
        return ((delegate* unmanaged<IPasswordCredential, IPropertySet*, int>)((*lpVtbl)[13]))(
            this,
            props
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Resource(HSTRING* resource);

        [VtblIndex(7)]
        HRESULT put_Resource(HSTRING resource);

        [VtblIndex(8)]
        HRESULT get_UserName(HSTRING* userName);

        [VtblIndex(9)]
        HRESULT put_UserName(HSTRING userName);

        [VtblIndex(10)]
        HRESULT get_Password(HSTRING* password);

        [VtblIndex(11)]
        HRESULT put_Password(HSTRING password);

        [VtblIndex(12)]
        HRESULT RetrievePassword();

        [VtblIndex(13)]
        HRESULT get_Properties(
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")]
                IPropertySet* props
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Resource;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Resource;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UserName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_UserName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Password;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Password;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RetrievePassword;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPropertySet*, int> get_Properties;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPasswordCredential"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPasswordCredential(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPasswordCredential"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPasswordCredential(Silk.NET.WinRT.IInspectable value)
    {
        return new IPasswordCredential(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPasswordCredential"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPasswordCredential"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPasswordCredential value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPasswordCredential"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPasswordCredential(Silk.NET.Windows.IUnknown value)
    {
        return new IPasswordCredential(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPasswordCredential"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPasswordCredential"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPasswordCredential value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
