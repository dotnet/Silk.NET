// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IContact.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("70DD27DD-5CBD-46E8-BEF0-23B6B346288F")]
[NativeTypeName("struct IContactProperties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IContactProperties : IContactProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactProperties));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactProperties, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactProperties, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactProperties, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetString(
        [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPWSTR")] ushort* pszValue,
        [NativeTypeName("DWORD")] uint cchValue,
        [NativeTypeName("DWORD *")] uint* pdwcchPropertyValueRequired
    )
    {
        return (
            (delegate* unmanaged<IContactProperties, ushort*, uint, ushort*, uint, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pszPropertyName, dwFlags, pszValue, cchValue, pdwcchPropertyValueRequired);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDate(
        [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
        [NativeTypeName("DWORD")] uint dwFlags,
        FILETIME* pftDateTime
    )
    {
        return (
            (delegate* unmanaged<IContactProperties, ushort*, uint, FILETIME*, int>)((*lpVtbl)[4])
        )(this, pszPropertyName, dwFlags, pftDateTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBinary(
        [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPWSTR")] ushort* pszContentType,
        [NativeTypeName("DWORD")] uint cchContentType,
        [NativeTypeName("DWORD *")] uint* pdwcchContentTypeRequired,
        IStream* ppStream
    )
    {
        return (
            (delegate* unmanaged<
                IContactProperties,
                ushort*,
                uint,
                ushort*,
                uint,
                uint*,
                IStream*,
                int>)((*lpVtbl)[5])
        )(
            this,
            pszPropertyName,
            dwFlags,
            pszContentType,
            cchContentType,
            pdwcchContentTypeRequired,
            ppStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetLabels(
        [NativeTypeName("LPCWSTR")] ushort* pszArrayElementName,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPWSTR")] ushort* pszLabels,
        [NativeTypeName("DWORD")] uint cchLabels,
        [NativeTypeName("DWORD *")] uint* pdwcchLabelsRequired
    )
    {
        return (
            (delegate* unmanaged<IContactProperties, ushort*, uint, ushort*, uint, uint*, int>)(
                (*lpVtbl)[6]
            )
        )(this, pszArrayElementName, dwFlags, pszLabels, cchLabels, pdwcchLabelsRequired);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetString(
        [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* pszValue
    )
    {
        return (
            (delegate* unmanaged<IContactProperties, ushort*, uint, ushort*, int>)((*lpVtbl)[7])
        )(this, pszPropertyName, dwFlags, pszValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDate(
        [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
        [NativeTypeName("DWORD")] uint dwFlags,
        FILETIME ftDateTime
    )
    {
        return (
            (delegate* unmanaged<IContactProperties, ushort*, uint, FILETIME, int>)((*lpVtbl)[8])
        )(this, pszPropertyName, dwFlags, ftDateTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetBinary(
        [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* pszContentType,
        IStream pStream
    )
    {
        return (
            (delegate* unmanaged<IContactProperties, ushort*, uint, ushort*, IStream, int>)(
                (*lpVtbl)[9]
            )
        )(this, pszPropertyName, dwFlags, pszContentType, pStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLabels(
        [NativeTypeName("LPCWSTR")] ushort* pszArrayElementName,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwLabelCount,
        [NativeTypeName("LPCWSTR[]")] ushort** ppszLabels
    )
    {
        return (
            (delegate* unmanaged<IContactProperties, ushort*, uint, uint, ushort**, int>)(
                (*lpVtbl)[10]
            )
        )(this, pszArrayElementName, dwFlags, dwLabelCount, ppszLabels);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateArrayNode(
        [NativeTypeName("LPCWSTR")] ushort* pszArrayName,
        [NativeTypeName("DWORD")] uint dwFlags,
        BOOL fAppend,
        [NativeTypeName("LPWSTR")] ushort* pszNewArrayElementName,
        [NativeTypeName("DWORD")] uint cchNewArrayElementName,
        [NativeTypeName("DWORD *")] uint* pdwcchNewArrayElementNameRequired
    )
    {
        return (
            (delegate* unmanaged<
                IContactProperties,
                ushort*,
                uint,
                BOOL,
                ushort*,
                uint,
                uint*,
                int>)((*lpVtbl)[11])
        )(
            this,
            pszArrayName,
            dwFlags,
            fAppend,
            pszNewArrayElementName,
            cchNewArrayElementName,
            pdwcchNewArrayElementNameRequired
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeleteProperty(
        [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<IContactProperties, ushort*, uint, int>)((*lpVtbl)[12]))(
            this,
            pszPropertyName,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DeleteArrayNode(
        [NativeTypeName("LPCWSTR")] ushort* pszArrayElementName,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<IContactProperties, ushort*, uint, int>)((*lpVtbl)[13]))(
            this,
            pszArrayElementName,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT DeleteLabels(
        [NativeTypeName("LPCWSTR")] ushort* pszArrayElementName,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return ((delegate* unmanaged<IContactProperties, ushort*, uint, int>)((*lpVtbl)[14]))(
            this,
            pszArrayElementName,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetPropertyCollection(
        IContactPropertyCollection* ppPropertyCollection,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* pszMultiValueName,
        [NativeTypeName("DWORD")] uint dwLabelCount,
        [NativeTypeName("LPCWSTR[]")] ushort** ppszLabels,
        BOOL fAnyLabelMatches
    )
    {
        return (
            (delegate* unmanaged<
                IContactProperties,
                IContactPropertyCollection*,
                uint,
                ushort*,
                uint,
                ushort**,
                BOOL,
                int>)((*lpVtbl)[15])
        )(
            this,
            ppPropertyCollection,
            dwFlags,
            pszMultiValueName,
            dwLabelCount,
            ppszLabels,
            fAnyLabelMatches
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetString(
            [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("LPWSTR")] ushort* pszValue,
            [NativeTypeName("DWORD")] uint cchValue,
            [NativeTypeName("DWORD *")] uint* pdwcchPropertyValueRequired
        );

        [VtblIndex(4)]
        HRESULT GetDate(
            [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
            [NativeTypeName("DWORD")] uint dwFlags,
            FILETIME* pftDateTime
        );

        [VtblIndex(5)]
        HRESULT GetBinary(
            [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("LPWSTR")] ushort* pszContentType,
            [NativeTypeName("DWORD")] uint cchContentType,
            [NativeTypeName("DWORD *")] uint* pdwcchContentTypeRequired,
            IStream* ppStream
        );

        [VtblIndex(6)]
        HRESULT GetLabels(
            [NativeTypeName("LPCWSTR")] ushort* pszArrayElementName,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("LPWSTR")] ushort* pszLabels,
            [NativeTypeName("DWORD")] uint cchLabels,
            [NativeTypeName("DWORD *")] uint* pdwcchLabelsRequired
        );

        [VtblIndex(7)]
        HRESULT SetString(
            [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("LPCWSTR")] ushort* pszValue
        );

        [VtblIndex(8)]
        HRESULT SetDate(
            [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
            [NativeTypeName("DWORD")] uint dwFlags,
            FILETIME ftDateTime
        );

        [VtblIndex(9)]
        HRESULT SetBinary(
            [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("LPCWSTR")] ushort* pszContentType,
            IStream pStream
        );

        [VtblIndex(10)]
        HRESULT SetLabels(
            [NativeTypeName("LPCWSTR")] ushort* pszArrayElementName,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("DWORD")] uint dwLabelCount,
            [NativeTypeName("LPCWSTR[]")] ushort** ppszLabels
        );

        [VtblIndex(11)]
        HRESULT CreateArrayNode(
            [NativeTypeName("LPCWSTR")] ushort* pszArrayName,
            [NativeTypeName("DWORD")] uint dwFlags,
            BOOL fAppend,
            [NativeTypeName("LPWSTR")] ushort* pszNewArrayElementName,
            [NativeTypeName("DWORD")] uint cchNewArrayElementName,
            [NativeTypeName("DWORD *")] uint* pdwcchNewArrayElementNameRequired
        );

        [VtblIndex(12)]
        HRESULT DeleteProperty(
            [NativeTypeName("LPCWSTR")] ushort* pszPropertyName,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(13)]
        HRESULT DeleteArrayNode(
            [NativeTypeName("LPCWSTR")] ushort* pszArrayElementName,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(14)]
        HRESULT DeleteLabels(
            [NativeTypeName("LPCWSTR")] ushort* pszArrayElementName,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(15)]
        HRESULT GetPropertyCollection(
            IContactPropertyCollection* ppPropertyCollection,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("LPCWSTR")] ushort* pszMultiValueName,
            [NativeTypeName("DWORD")] uint dwLabelCount,
            [NativeTypeName("LPCWSTR[]")] ushort** ppszLabels,
            BOOL fAnyLabelMatches
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

        [NativeTypeName(
            "HRESULT (LPCWSTR, DWORD, LPWSTR, DWORD, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort*, uint, uint*, int> GetString;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, FILETIME*, int> GetDate;

        [NativeTypeName(
            "HRESULT (LPCWSTR, DWORD, LPWSTR, DWORD, DWORD *, IStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            ushort*,
            uint,
            uint*,
            IStream*,
            int> GetBinary;

        [NativeTypeName(
            "HRESULT (LPCWSTR, DWORD, LPWSTR, DWORD, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort*, uint, uint*, int> GetLabels;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort*, int> SetString;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, FILETIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, FILETIME, int> SetDate;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, LPCWSTR, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort*, IStream, int> SetBinary;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, DWORD, LPCWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint, ushort**, int> SetLabels;

        [NativeTypeName(
            "HRESULT (LPCWSTR, DWORD, BOOL, LPWSTR, DWORD, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            BOOL,
            ushort*,
            uint,
            uint*,
            int> CreateArrayNode;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> DeleteProperty;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> DeleteArrayNode;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> DeleteLabels;

        [NativeTypeName(
            "HRESULT (IContactPropertyCollection **, DWORD, LPCWSTR, DWORD, LPCWSTR *, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IContactPropertyCollection*,
            uint,
            ushort*,
            uint,
            ushort**,
            BOOL,
            int> GetPropertyCollection;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactProperties(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactProperties(Silk.NET.Windows.IUnknown value)
    {
        return new IContactProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactProperties"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactProperties value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
