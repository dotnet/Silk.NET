// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AEC63FDA-7A97-4944-B35C-6C6DF8085CC3")]
[NativeTypeName("struct IMFMediaKeySystemAccess : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaKeySystemAccess
    : IMFMediaKeySystemAccess.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaKeySystemAccess));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaKeySystemAccess, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaKeySystemAccess, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaKeySystemAccess, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateMediaKeys(IPropertyStore pCdmCustomConfig, IMFMediaKeys2* ppKeys)
    {
        return (
            (delegate* unmanaged<IMFMediaKeySystemAccess, IPropertyStore, IMFMediaKeys2*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pCdmCustomConfig, ppKeys);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_SupportedConfiguration(IPropertyStore* ppSupportedConfiguration)
    {
        return ((delegate* unmanaged<IMFMediaKeySystemAccess, IPropertyStore*, int>)((*lpVtbl)[4]))(
            this,
            ppSupportedConfiguration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_KeySystem([NativeTypeName("BSTR *")] ushort** pKeySystem)
    {
        return ((delegate* unmanaged<IMFMediaKeySystemAccess, ushort**, int>)((*lpVtbl)[5]))(
            this,
            pKeySystem
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateMediaKeys(IPropertyStore pCdmCustomConfig, IMFMediaKeys2* ppKeys);

        [VtblIndex(4)]
        HRESULT get_SupportedConfiguration(IPropertyStore* ppSupportedConfiguration);

        [VtblIndex(5)]
        HRESULT get_KeySystem([NativeTypeName("BSTR *")] ushort** pKeySystem);
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

        [NativeTypeName("HRESULT (IPropertyStore *, IMFMediaKeys2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStore, IMFMediaKeys2*, int> CreateMediaKeys;

        [NativeTypeName("HRESULT (IPropertyStore **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPropertyStore*, int> get_SupportedConfiguration;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_KeySystem;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaKeySystemAccess"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaKeySystemAccess(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaKeySystemAccess"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaKeySystemAccess(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaKeySystemAccess(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaKeySystemAccess"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaKeySystemAccess"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaKeySystemAccess value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
