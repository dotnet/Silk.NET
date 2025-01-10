// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FA7660F6-7B3F-4237-A8BF-ED0AD0DCBBD9")]
[NativeTypeName("struct IAppHostWritableAdminManager : IAppHostAdminManager")]
[NativeInheritance("IAppHostAdminManager")]
public unsafe partial struct IAppHostWritableAdminManager
    : IAppHostWritableAdminManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostWritableAdminManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppHostWritableAdminManager, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppHostWritableAdminManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostWritableAdminManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAdminSection(
        [NativeTypeName("BSTR")] ushort* bstrSectionName,
        [NativeTypeName("BSTR")] ushort* bstrPath,
        IAppHostElement* ppAdminSection
    )
    {
        return (
            (delegate* unmanaged<
                IAppHostWritableAdminManager,
                ushort*,
                ushort*,
                IAppHostElement*,
                int>)((*lpVtbl)[3])
        )(this, bstrSectionName, bstrPath, ppAdminSection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue)
    {
        return (
            (delegate* unmanaged<IAppHostWritableAdminManager, ushort*, VARIANT*, int>)(
                (*lpVtbl)[4]
            )
        )(this, bstrMetadataType, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT value)
    {
        return (
            (delegate* unmanaged<IAppHostWritableAdminManager, ushort*, VARIANT, int>)((*lpVtbl)[5])
        )(this, bstrMetadataType, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ConfigManager(IAppHostConfigManager* ppConfigManager)
    {
        return (
            (delegate* unmanaged<IAppHostWritableAdminManager, IAppHostConfigManager*, int>)(
                (*lpVtbl)[6]
            )
        )(this, ppConfigManager);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CommitChanges()
    {
        return ((delegate* unmanaged<IAppHostWritableAdminManager, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CommitPath([NativeTypeName("BSTR *")] ushort** pbstrCommitPath)
    {
        return ((delegate* unmanaged<IAppHostWritableAdminManager, ushort**, int>)((*lpVtbl)[8]))(
            this,
            pbstrCommitPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CommitPath([NativeTypeName("BSTR")] ushort* bstrCommitPath)
    {
        return ((delegate* unmanaged<IAppHostWritableAdminManager, ushort*, int>)((*lpVtbl)[9]))(
            this,
            bstrCommitPath
        );
    }

    public interface Interface : IAppHostAdminManager.Interface
    {
        [VtblIndex(7)]
        HRESULT CommitChanges();

        [VtblIndex(8)]
        HRESULT get_CommitPath([NativeTypeName("BSTR *")] ushort** pbstrCommitPath);

        [VtblIndex(9)]
        HRESULT put_CommitPath([NativeTypeName("BSTR")] ushort* bstrCommitPath);
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

        [NativeTypeName("HRESULT (BSTR, BSTR, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IAppHostElement*, int> GetAdminSection;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int> SetMetadata;

        [NativeTypeName("HRESULT (IAppHostConfigManager **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostConfigManager*, int> get_ConfigManager;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CommitChanges;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_CommitPath;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_CommitPath;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostWritableAdminManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostWritableAdminManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAppHostAdminManager"/> to <see cref = "IAppHostWritableAdminManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAppHostAdminManager"/> instance to be converted </param>
    public static explicit operator IAppHostWritableAdminManager(
        Silk.NET.Windows.IAppHostAdminManager value
    )
    {
        return new IAppHostWritableAdminManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostWritableAdminManager"/> to <see cref = "Silk.NET.Windows.IAppHostAdminManager"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostWritableAdminManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAppHostAdminManager(
        IAppHostWritableAdminManager value
    )
    {
        return new Silk.NET.Windows.IAppHostAdminManager(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostWritableAdminManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostWritableAdminManager(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostWritableAdminManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostWritableAdminManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostWritableAdminManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostWritableAdminManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
