// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("DF9A26C6-E746-4BCD-B5D4-120103C4209B")]
[NativeTypeName("struct IUser : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUser : IUser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUser));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUser, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUser, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUser, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IUser, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUser, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUser, TrustLevel*, int>)((*lpVtbl)[5]))(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NonRoamableId(HSTRING* value)
    {
        return ((delegate* unmanaged<IUser, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AuthenticationStatus(
        [NativeTypeName("ABI::Windows::System::UserAuthenticationStatus *")]
            UserAuthenticationStatus* value
    )
    {
        return ((delegate* unmanaged<IUser, UserAuthenticationStatus*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Type([NativeTypeName("ABI::Windows::System::UserType *")] UserType* value)
    {
        return ((delegate* unmanaged<IUser, UserType*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPropertyAsync(
        HSTRING value,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **")]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IUser, HSTRING, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[9])
        )(this, value, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPropertiesAsync(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t *")]
            IVectorView<HSTRING>* values,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___F__CIPropertySet_t **")]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IUser, IVectorView<HSTRING>*, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, values, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetPictureAsync(
        [NativeTypeName("ABI::Windows::System::UserPictureSize")] UserPictureSize desiredSize,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IUser, UserPictureSize, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, desiredSize, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NonRoamableId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_AuthenticationStatus(
            [NativeTypeName("ABI::Windows::System::UserAuthenticationStatus *")]
                UserAuthenticationStatus* value
        );

        [VtblIndex(8)]
        HRESULT get_Type([NativeTypeName("ABI::Windows::System::UserType *")] UserType* value);

        [VtblIndex(9)]
        HRESULT GetPropertyAsync(
            HSTRING value,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **")]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(10)]
        HRESULT GetPropertiesAsync(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t *")]
                IVectorView<HSTRING>* values,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___F__CIPropertySet_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(11)]
        HRESULT GetPictureAsync(
            [NativeTypeName("ABI::Windows::System::UserPictureSize")] UserPictureSize desiredSize,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_NonRoamableId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::UserAuthenticationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UserAuthenticationStatus*, int> get_AuthenticationStatus;

        [NativeTypeName("HRESULT (ABI::Windows::System::UserType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UserType*, int> get_Type;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetPropertyAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___F__CIPropertySet_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<HSTRING>*,
            IAsyncOperation<IntPtr>**,
            int> GetPropertiesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::UserPictureSize, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            UserPictureSize,
            IAsyncOperation<IntPtr>**,
            int> GetPictureAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUser"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUser(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUser"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUser(Silk.NET.WinRT.IInspectable value)
    {
        return new IUser(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUser"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUser"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IUser value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUser"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUser(Silk.NET.Windows.IUnknown value)
    {
        return new IUser(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUser"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUser"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUser value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
