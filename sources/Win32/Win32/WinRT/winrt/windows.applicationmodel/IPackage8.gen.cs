// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2C584F7B-CE2A-4BE6-A093-77CFBB2A7EA1")]
[NativeTypeName("struct IPackage8 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackage8 : IPackage8.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackage8));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPackage8, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPackage8, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPackage8, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPackage8, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPackage8, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPackage8, TrustLevel*, int>)((*lpVtbl)[5]))(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EffectiveExternalLocation(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IPackage8, IStorageFolder*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MachineExternalLocation(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IPackage8, IStorageFolder*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_UserExternalLocation(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IPackage8, IStorageFolder*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_InstalledPath(HSTRING* value)
    {
        return ((delegate* unmanaged<IPackage8, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MutablePath(HSTRING* value)
    {
        return ((delegate* unmanaged<IPackage8, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_EffectivePath(HSTRING* value)
    {
        return ((delegate* unmanaged<IPackage8, HSTRING*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_EffectiveExternalPath(HSTRING* value)
    {
        return ((delegate* unmanaged<IPackage8, HSTRING*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MachineExternalPath(HSTRING* value)
    {
        return ((delegate* unmanaged<IPackage8, HSTRING*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_UserExternalPath(HSTRING* value)
    {
        return ((delegate* unmanaged<IPackage8, HSTRING*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetLogoAsRandomAccessStreamReference(
        [NativeTypeName("ABI::Windows::Foundation::Size")] Size size,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* result
    )
    {
        return (
            (delegate* unmanaged<IPackage8, Size, IRandomAccessStreamReference*, int>)(
                (*lpVtbl)[15]
            )
        )(this, size, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetAppListEntries(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCore__CAppListEntry_t **"
        )]
            IVectorView<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IPackage8, IVectorView<IntPtr>**, int>)((*lpVtbl)[16]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_IsStub([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackage8, byte*, int>)((*lpVtbl)[17]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EffectiveExternalLocation(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(7)]
        HRESULT get_MachineExternalLocation(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(8)]
        HRESULT get_UserExternalLocation(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(9)]
        HRESULT get_InstalledPath(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_MutablePath(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_EffectivePath(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_EffectiveExternalPath(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_MachineExternalPath(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_UserExternalPath(HSTRING* value);

        [VtblIndex(15)]
        HRESULT GetLogoAsRandomAccessStreamReference(
            [NativeTypeName("ABI::Windows::Foundation::Size")] Size size,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* result
        );

        [VtblIndex(16)]
        HRESULT GetAppListEntries(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCore__CAppListEntry_t **"
            )]
                IVectorView<IntPtr>** result
        );

        [VtblIndex(17)]
        HRESULT get_IsStub([NativeTypeName("boolean *")] byte* value);
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
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_EffectiveExternalLocation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_MachineExternalLocation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_UserExternalLocation;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_InstalledPath;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_MutablePath;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_EffectivePath;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_EffectiveExternalPath;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_MachineExternalPath;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UserExternalPath;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Size, ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Size,
            IRandomAccessStreamReference*,
            int> GetLogoAsRandomAccessStreamReference;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CApplicationModel__CCore__CAppListEntry_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> GetAppListEntries;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsStub;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPackage8"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPackage8(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPackage8"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPackage8(Silk.NET.WinRT.IInspectable value)
    {
        return new IPackage8(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackage8"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPackage8"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPackage8 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPackage8"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPackage8(Silk.NET.Windows.IUnknown value)
    {
        return new IPackage8(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackage8"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPackage8"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPackage8 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
