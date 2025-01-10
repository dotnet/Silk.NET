// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F88CFB8C-EF16-4991-B450-CB8C69E51704")]
[NativeTypeName("struct IMFMetadata : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMetadata : IMFMetadata.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMetadata));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMetadata, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMetadata, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMetadata, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetLanguage([NativeTypeName("LPCWSTR")] ushort* pwszRFC1766)
    {
        return ((delegate* unmanaged<IMFMetadata, ushort*, int>)((*lpVtbl)[3]))(this, pwszRFC1766);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLanguage([NativeTypeName("LPWSTR *")] ushort** ppwszRFC1766)
    {
        return ((delegate* unmanaged<IMFMetadata, ushort**, int>)((*lpVtbl)[4]))(
            this,
            ppwszRFC1766
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAllLanguages(PROPVARIANT* ppvLanguages)
    {
        return ((delegate* unmanaged<IMFMetadata, PROPVARIANT*, int>)((*lpVtbl)[5]))(
            this,
            ppvLanguages
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetProperty(
        [NativeTypeName("LPCWSTR")] ushort* pwszName,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* ppvValue
    )
    {
        return ((delegate* unmanaged<IMFMetadata, ushort*, PROPVARIANT*, int>)((*lpVtbl)[6]))(
            this,
            pwszName,
            ppvValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetProperty([NativeTypeName("LPCWSTR")] ushort* pwszName, PROPVARIANT* ppvValue)
    {
        return ((delegate* unmanaged<IMFMetadata, ushort*, PROPVARIANT*, int>)((*lpVtbl)[7]))(
            this,
            pwszName,
            ppvValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteProperty([NativeTypeName("LPCWSTR")] ushort* pwszName)
    {
        return ((delegate* unmanaged<IMFMetadata, ushort*, int>)((*lpVtbl)[8]))(this, pwszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAllPropertyNames(PROPVARIANT* ppvNames)
    {
        return ((delegate* unmanaged<IMFMetadata, PROPVARIANT*, int>)((*lpVtbl)[9]))(
            this,
            ppvNames
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetLanguage([NativeTypeName("LPCWSTR")] ushort* pwszRFC1766);

        [VtblIndex(4)]
        HRESULT GetLanguage([NativeTypeName("LPWSTR *")] ushort** ppwszRFC1766);

        [VtblIndex(5)]
        HRESULT GetAllLanguages(PROPVARIANT* ppvLanguages);

        [VtblIndex(6)]
        HRESULT SetProperty(
            [NativeTypeName("LPCWSTR")] ushort* pwszName,
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* ppvValue
        );

        [VtblIndex(7)]
        HRESULT GetProperty([NativeTypeName("LPCWSTR")] ushort* pwszName, PROPVARIANT* ppvValue);

        [VtblIndex(8)]
        HRESULT DeleteProperty([NativeTypeName("LPCWSTR")] ushort* pwszName);

        [VtblIndex(9)]
        HRESULT GetAllPropertyNames(PROPVARIANT* ppvNames);
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetLanguage;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetLanguage;

        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> GetAllLanguages;

        [NativeTypeName("HRESULT (LPCWSTR, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, PROPVARIANT*, int> SetProperty;

        [NativeTypeName("HRESULT (LPCWSTR, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, PROPVARIANT*, int> GetProperty;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> DeleteProperty;

        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> GetAllPropertyNames;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMetadata"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMetadata(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMetadata"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMetadata(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMetadata(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMetadata"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMetadata"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMetadata value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
