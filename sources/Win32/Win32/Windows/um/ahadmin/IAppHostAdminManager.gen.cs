// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9BE77978-73ED-4A9A-87FD-13F09FEC1B13")]
[NativeTypeName("struct IAppHostAdminManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostAdminManager : IAppHostAdminManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostAdminManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostAdminManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostAdminManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostAdminManager, uint>)((*lpVtbl)[2]))(this);
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
            (delegate* unmanaged<IAppHostAdminManager, ushort*, ushort*, IAppHostElement*, int>)(
                (*lpVtbl)[3]
            )
        )(this, bstrSectionName, bstrPath, ppAdminSection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged<IAppHostAdminManager, ushort*, VARIANT*, int>)((*lpVtbl)[4]))(
            this,
            bstrMetadataType,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT value)
    {
        return ((delegate* unmanaged<IAppHostAdminManager, ushort*, VARIANT, int>)((*lpVtbl)[5]))(
            this,
            bstrMetadataType,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ConfigManager(IAppHostConfigManager* ppConfigManager)
    {
        return (
            (delegate* unmanaged<IAppHostAdminManager, IAppHostConfigManager*, int>)((*lpVtbl)[6])
        )(this, ppConfigManager);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAdminSection(
            [NativeTypeName("BSTR")] ushort* bstrSectionName,
            [NativeTypeName("BSTR")] ushort* bstrPath,
            IAppHostElement* ppAdminSection
        );

        [VtblIndex(4)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(5)]
        HRESULT SetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT value);

        [VtblIndex(6)]
        HRESULT get_ConfigManager(IAppHostConfigManager* ppConfigManager);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostAdminManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostAdminManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostAdminManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostAdminManager(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostAdminManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostAdminManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostAdminManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostAdminManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
