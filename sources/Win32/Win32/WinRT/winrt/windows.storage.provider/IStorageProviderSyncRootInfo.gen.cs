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

[Guid("7C1305C4-99F9-41AC-8904-AB055D654926")]
[NativeTypeName("struct IStorageProviderSyncRootInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderSyncRootInfo
    : IStorageProviderSyncRootInfo.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderSyncRootInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IStorageProviderSyncRootInfo, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderSyncRootInfo, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IStorageProviderSyncRootInfo, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Id(HSTRING value)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, HSTRING, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Context(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, IBuffer*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Context(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
    )
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, IBuffer, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Path(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderSyncRootInfo, IStorageFolder*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Path(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderSyncRootInfo, IStorageFolder, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DisplayNameResource(HSTRING* value)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, HSTRING*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_DisplayNameResource(HSTRING value)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, HSTRING, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IconResource(HSTRING* value)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, HSTRING*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_IconResource(HSTRING value)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, HSTRING, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_HydrationPolicy(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicy *")]
            StorageProviderHydrationPolicy* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderSyncRootInfo,
                StorageProviderHydrationPolicy*,
                int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_HydrationPolicy(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicy")]
            StorageProviderHydrationPolicy value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderSyncRootInfo,
                StorageProviderHydrationPolicy,
                int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_HydrationPolicyModifier(
        [NativeTypeName(
            "ABI::Windows::Storage::Provider::StorageProviderHydrationPolicyModifier *"
        )]
            StorageProviderHydrationPolicyModifier* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderSyncRootInfo,
                StorageProviderHydrationPolicyModifier*,
                int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_HydrationPolicyModifier(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicyModifier")]
            StorageProviderHydrationPolicyModifier value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderSyncRootInfo,
                StorageProviderHydrationPolicyModifier,
                int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_PopulationPolicy(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderPopulationPolicy *")]
            StorageProviderPopulationPolicy* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderSyncRootInfo,
                StorageProviderPopulationPolicy*,
                int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_PopulationPolicy(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderPopulationPolicy")]
            StorageProviderPopulationPolicy value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderSyncRootInfo,
                StorageProviderPopulationPolicy,
                int>)((*lpVtbl)[21])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_InSyncPolicy(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderInSyncPolicy *")]
            StorageProviderInSyncPolicy* value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderSyncRootInfo, StorageProviderInSyncPolicy*, int>)(
                (*lpVtbl)[22]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_InSyncPolicy(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderInSyncPolicy")]
            StorageProviderInSyncPolicy value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderSyncRootInfo, StorageProviderInSyncPolicy, int>)(
                (*lpVtbl)[23]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_HardlinkPolicy(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHardlinkPolicy *")]
            StorageProviderHardlinkPolicy* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderSyncRootInfo,
                StorageProviderHardlinkPolicy*,
                int>)((*lpVtbl)[24])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_HardlinkPolicy(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHardlinkPolicy")]
            StorageProviderHardlinkPolicy value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderSyncRootInfo, StorageProviderHardlinkPolicy, int>)(
                (*lpVtbl)[25]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_ShowSiblingsAsGroup([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, byte*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_ShowSiblingsAsGroup([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, byte, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_Version(HSTRING* value)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, HSTRING*, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_Version(HSTRING value)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, HSTRING, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_ProtectionMode(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderProtectionMode *")]
            StorageProviderProtectionMode* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderSyncRootInfo,
                StorageProviderProtectionMode*,
                int>)((*lpVtbl)[30])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_ProtectionMode(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderProtectionMode")]
            StorageProviderProtectionMode value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderSyncRootInfo, StorageProviderProtectionMode, int>)(
                (*lpVtbl)[31]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_AllowPinning([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, byte*, int>)((*lpVtbl)[32]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_AllowPinning([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IStorageProviderSyncRootInfo, byte, int>)((*lpVtbl)[33]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_StorageProviderItemPropertyDefinitions(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CStorageProviderItemPropertyDefinition_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderSyncRootInfo, IVector<IntPtr>**, int>)(
                (*lpVtbl)[34]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_RecycleBinUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderSyncRootInfo, IUriRuntimeClass*, int>)(
                (*lpVtbl)[35]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_RecycleBinUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderSyncRootInfo, IUriRuntimeClass, int>)(
                (*lpVtbl)[36]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Id(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Context(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(9)]
        HRESULT put_Context(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
        );

        [VtblIndex(10)]
        HRESULT get_Path(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(11)]
        HRESULT put_Path(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder value
        );

        [VtblIndex(12)]
        HRESULT get_DisplayNameResource(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_DisplayNameResource(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_IconResource(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_IconResource(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_HydrationPolicy(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicy *")]
                StorageProviderHydrationPolicy* value
        );

        [VtblIndex(17)]
        HRESULT put_HydrationPolicy(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHydrationPolicy")]
                StorageProviderHydrationPolicy value
        );

        [VtblIndex(18)]
        HRESULT get_HydrationPolicyModifier(
            [NativeTypeName(
                "ABI::Windows::Storage::Provider::StorageProviderHydrationPolicyModifier *"
            )]
                StorageProviderHydrationPolicyModifier* value
        );

        [VtblIndex(19)]
        HRESULT put_HydrationPolicyModifier(
            [NativeTypeName(
                "ABI::Windows::Storage::Provider::StorageProviderHydrationPolicyModifier"
            )]
                StorageProviderHydrationPolicyModifier value
        );

        [VtblIndex(20)]
        HRESULT get_PopulationPolicy(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderPopulationPolicy *")]
                StorageProviderPopulationPolicy* value
        );

        [VtblIndex(21)]
        HRESULT put_PopulationPolicy(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderPopulationPolicy")]
                StorageProviderPopulationPolicy value
        );

        [VtblIndex(22)]
        HRESULT get_InSyncPolicy(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderInSyncPolicy *")]
                StorageProviderInSyncPolicy* value
        );

        [VtblIndex(23)]
        HRESULT put_InSyncPolicy(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderInSyncPolicy")]
                StorageProviderInSyncPolicy value
        );

        [VtblIndex(24)]
        HRESULT get_HardlinkPolicy(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHardlinkPolicy *")]
                StorageProviderHardlinkPolicy* value
        );

        [VtblIndex(25)]
        HRESULT put_HardlinkPolicy(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderHardlinkPolicy")]
                StorageProviderHardlinkPolicy value
        );

        [VtblIndex(26)]
        HRESULT get_ShowSiblingsAsGroup([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(27)]
        HRESULT put_ShowSiblingsAsGroup([NativeTypeName("boolean")] byte value);

        [VtblIndex(28)]
        HRESULT get_Version(HSTRING* value);

        [VtblIndex(29)]
        HRESULT put_Version(HSTRING value);

        [VtblIndex(30)]
        HRESULT get_ProtectionMode(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderProtectionMode *")]
                StorageProviderProtectionMode* value
        );

        [VtblIndex(31)]
        HRESULT put_ProtectionMode(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderProtectionMode")]
                StorageProviderProtectionMode value
        );

        [VtblIndex(32)]
        HRESULT get_AllowPinning([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(33)]
        HRESULT put_AllowPinning([NativeTypeName("boolean")] byte value);

        [VtblIndex(34)]
        HRESULT get_StorageProviderItemPropertyDefinitions(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CStorageProviderItemPropertyDefinition_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(35)]
        HRESULT get_RecycleBinUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(36)]
        HRESULT put_RecycleBinUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Id;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> get_Context;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, int> put_Context;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_Path;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder, int> put_Path;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayNameResource;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DisplayNameResource;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_IconResource;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_IconResource;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderHydrationPolicy *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            StorageProviderHydrationPolicy*,
            int> get_HydrationPolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderHydrationPolicy) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderHydrationPolicy, int> put_HydrationPolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderHydrationPolicyModifier *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            StorageProviderHydrationPolicyModifier*,
            int> get_HydrationPolicyModifier;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderHydrationPolicyModifier) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            StorageProviderHydrationPolicyModifier,
            int> put_HydrationPolicyModifier;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderPopulationPolicy *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            StorageProviderPopulationPolicy*,
            int> get_PopulationPolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderPopulationPolicy) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            StorageProviderPopulationPolicy,
            int> put_PopulationPolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderInSyncPolicy *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderInSyncPolicy*, int> get_InSyncPolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderInSyncPolicy) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderInSyncPolicy, int> put_InSyncPolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderHardlinkPolicy *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderHardlinkPolicy*, int> get_HardlinkPolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderHardlinkPolicy) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderHardlinkPolicy, int> put_HardlinkPolicy;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ShowSiblingsAsGroup;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_ShowSiblingsAsGroup;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Version;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Version;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderProtectionMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderProtectionMode*, int> get_ProtectionMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderProtectionMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderProtectionMode, int> put_ProtectionMode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AllowPinning;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AllowPinning;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CStorageProviderItemPropertyDefinition_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVector<IntPtr>**,
            int> get_StorageProviderItemPropertyDefinitions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_RecycleBinUri;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, int> put_RecycleBinUri;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageProviderSyncRootInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageProviderSyncRootInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageProviderSyncRootInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageProviderSyncRootInfo(Silk.NET.WinRT.IInspectable value)
    {
        return new IStorageProviderSyncRootInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderSyncRootInfo"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderSyncRootInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStorageProviderSyncRootInfo value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageProviderSyncRootInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageProviderSyncRootInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageProviderSyncRootInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderSyncRootInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderSyncRootInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageProviderSyncRootInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
