// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("23BC3F0A-698B-4357-886B-F24D50671334")]
[NativeTypeName("struct IWICComponentInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICComponentInfo : IWICComponentInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICComponentInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICComponentInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICComponentInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICComponentInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetComponentType(WICComponentType* pType)
    {
        return ((delegate* unmanaged<IWICComponentInfo, WICComponentType*, int>)((*lpVtbl)[3]))(
            this,
            pType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<IWICComponentInfo, Guid*, int>)((*lpVtbl)[4]))(this, pclsid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
    {
        return ((delegate* unmanaged<IWICComponentInfo, uint*, int>)((*lpVtbl)[5]))(this, pStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAuthor(
        uint cchAuthor,
        [NativeTypeName("WCHAR *")] ushort* wzAuthor,
        uint* pcchActual
    )
    {
        return ((delegate* unmanaged<IWICComponentInfo, uint, ushort*, uint*, int>)((*lpVtbl)[6]))(
            this,
            cchAuthor,
            wzAuthor,
            pcchActual
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVendorGUID(Guid* pguidVendor)
    {
        return ((delegate* unmanaged<IWICComponentInfo, Guid*, int>)((*lpVtbl)[7]))(
            this,
            pguidVendor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetVersion(
        uint cchVersion,
        [NativeTypeName("WCHAR *")] ushort* wzVersion,
        uint* pcchActual
    )
    {
        return ((delegate* unmanaged<IWICComponentInfo, uint, ushort*, uint*, int>)((*lpVtbl)[8]))(
            this,
            cchVersion,
            wzVersion,
            pcchActual
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSpecVersion(
        uint cchSpecVersion,
        [NativeTypeName("WCHAR *")] ushort* wzSpecVersion,
        uint* pcchActual
    )
    {
        return ((delegate* unmanaged<IWICComponentInfo, uint, ushort*, uint*, int>)((*lpVtbl)[9]))(
            this,
            cchSpecVersion,
            wzSpecVersion,
            pcchActual
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFriendlyName(
        uint cchFriendlyName,
        [NativeTypeName("WCHAR *")] ushort* wzFriendlyName,
        uint* pcchActual
    )
    {
        return ((delegate* unmanaged<IWICComponentInfo, uint, ushort*, uint*, int>)((*lpVtbl)[10]))(
            this,
            cchFriendlyName,
            wzFriendlyName,
            pcchActual
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetComponentType(WICComponentType* pType);

        [VtblIndex(4)]
        HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid);

        [VtblIndex(5)]
        HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus);

        [VtblIndex(6)]
        HRESULT GetAuthor(
            uint cchAuthor,
            [NativeTypeName("WCHAR *")] ushort* wzAuthor,
            uint* pcchActual
        );

        [VtblIndex(7)]
        HRESULT GetVendorGUID(Guid* pguidVendor);

        [VtblIndex(8)]
        HRESULT GetVersion(
            uint cchVersion,
            [NativeTypeName("WCHAR *")] ushort* wzVersion,
            uint* pcchActual
        );

        [VtblIndex(9)]
        HRESULT GetSpecVersion(
            uint cchSpecVersion,
            [NativeTypeName("WCHAR *")] ushort* wzSpecVersion,
            uint* pcchActual
        );

        [VtblIndex(10)]
        HRESULT GetFriendlyName(
            uint cchFriendlyName,
            [NativeTypeName("WCHAR *")] ushort* wzFriendlyName,
            uint* pcchActual
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

        [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICComponentType*, int> GetComponentType;

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetCLSID;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSigningStatus;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetAuthor;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetVendorGUID;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetVersion;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetSpecVersion;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetFriendlyName;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICComponentInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICComponentInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICComponentInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICComponentInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IWICComponentInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICComponentInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICComponentInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICComponentInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
