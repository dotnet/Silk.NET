// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("ADA4E6FB-E025-401E-A5D0-C3134A281F07")]
[NativeTypeName("struct IAppHostConfigFile : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostConfigFile : IAppHostConfigFile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostConfigFile));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostConfigFile, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostConfigFile, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostConfigFile, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_ConfigPath([NativeTypeName("BSTR *")] ushort** pbstrConfigPath)
    {
        return ((delegate* unmanaged<IAppHostConfigFile, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrConfigPath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_FilePath([NativeTypeName("BSTR *")] ushort** pbstrFilePath)
    {
        return ((delegate* unmanaged<IAppHostConfigFile, ushort**, int>)((*lpVtbl)[4]))(
            this,
            pbstrFilePath
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_Locations(IAppHostConfigLocationCollection* ppLocations)
    {
        return (
            (delegate* unmanaged<IAppHostConfigFile, IAppHostConfigLocationCollection*, int>)(
                (*lpVtbl)[5]
            )
        )(this, ppLocations);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAdminSection(
        [NativeTypeName("BSTR")] ushort* bstrSectionName,
        [NativeTypeName("BSTR")] ushort* bstrPath,
        IAppHostElement* ppAdminSection
    )
    {
        return (
            (delegate* unmanaged<IAppHostConfigFile, ushort*, ushort*, IAppHostElement*, int>)(
                (*lpVtbl)[6]
            )
        )(this, bstrSectionName, bstrPath, ppAdminSection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue)
    {
        return ((delegate* unmanaged<IAppHostConfigFile, ushort*, VARIANT*, int>)((*lpVtbl)[7]))(
            this,
            bstrMetadataType,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT value)
    {
        return ((delegate* unmanaged<IAppHostConfigFile, ushort*, VARIANT, int>)((*lpVtbl)[8]))(
            this,
            bstrMetadataType,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ClearInvalidSections()
    {
        return ((delegate* unmanaged<IAppHostConfigFile, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RootSectionGroup(IAppHostSectionGroup* ppSectionGroups)
    {
        return (
            (delegate* unmanaged<IAppHostConfigFile, IAppHostSectionGroup*, int>)((*lpVtbl)[10])
        )(this, ppSectionGroups);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_ConfigPath([NativeTypeName("BSTR *")] ushort** pbstrConfigPath);

        [VtblIndex(4)]
        HRESULT get_FilePath([NativeTypeName("BSTR *")] ushort** pbstrFilePath);

        [VtblIndex(5)]
        HRESULT get_Locations(IAppHostConfigLocationCollection* ppLocations);

        [VtblIndex(6)]
        HRESULT GetAdminSection(
            [NativeTypeName("BSTR")] ushort* bstrSectionName,
            [NativeTypeName("BSTR")] ushort* bstrPath,
            IAppHostElement* ppAdminSection
        );

        [VtblIndex(7)]
        HRESULT GetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT* pValue);

        [VtblIndex(8)]
        HRESULT SetMetadata([NativeTypeName("BSTR")] ushort* bstrMetadataType, VARIANT value);

        [VtblIndex(9)]
        HRESULT ClearInvalidSections();

        [VtblIndex(10)]
        HRESULT get_RootSectionGroup(IAppHostSectionGroup* ppSectionGroups);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_ConfigPath;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_FilePath;

        [NativeTypeName("HRESULT (IAppHostConfigLocationCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostConfigLocationCollection*, int> get_Locations;

        [NativeTypeName("HRESULT (BSTR, BSTR, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IAppHostElement*, int> GetAdminSection;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> GetMetadata;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int> SetMetadata;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearInvalidSections;

        [NativeTypeName("HRESULT (IAppHostSectionGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppHostSectionGroup*, int> get_RootSectionGroup;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostConfigFile"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostConfigFile(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostConfigFile"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostConfigFile(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostConfigFile(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostConfigFile"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostConfigFile"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostConfigFile value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
