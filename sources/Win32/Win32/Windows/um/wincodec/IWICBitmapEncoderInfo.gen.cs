// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("94C9B4EE-A09F-4F92-8A1E-4A9BCE7E76FB")]
[NativeTypeName("struct IWICBitmapEncoderInfo : IWICBitmapCodecInfo")]
[NativeInheritance("IWICBitmapCodecInfo")]
public unsafe partial struct IWICBitmapEncoderInfo : IWICBitmapEncoderInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICBitmapEncoderInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetComponentType(WICComponentType* pType)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, WICComponentType*, int>)((*lpVtbl)[3]))(
            this,
            pType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, Guid*, int>)((*lpVtbl)[4]))(
            this,
            pclsid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, uint*, int>)((*lpVtbl)[5]))(
            this,
            pStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAuthor(
        uint cchAuthor,
        [NativeTypeName("WCHAR *")] ushort* wzAuthor,
        uint* pcchActual
    )
    {
        return (
            (delegate* unmanaged<IWICBitmapEncoderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[6])
        )(this, cchAuthor, wzAuthor, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVendorGUID(Guid* pguidVendor)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, Guid*, int>)((*lpVtbl)[7]))(
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
        return (
            (delegate* unmanaged<IWICBitmapEncoderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[8])
        )(this, cchVersion, wzVersion, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSpecVersion(
        uint cchSpecVersion,
        [NativeTypeName("WCHAR *")] ushort* wzSpecVersion,
        uint* pcchActual
    )
    {
        return (
            (delegate* unmanaged<IWICBitmapEncoderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[9])
        )(this, cchSpecVersion, wzSpecVersion, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFriendlyName(
        uint cchFriendlyName,
        [NativeTypeName("WCHAR *")] ushort* wzFriendlyName,
        uint* pcchActual
    )
    {
        return (
            (delegate* unmanaged<IWICBitmapEncoderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[10])
        )(this, cchFriendlyName, wzFriendlyName, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, Guid*, int>)((*lpVtbl)[11]))(
            this,
            pguidContainerFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
    {
        return (
            (delegate* unmanaged<IWICBitmapEncoderInfo, uint, Guid*, uint*, int>)((*lpVtbl)[12])
        )(this, cFormats, pguidPixelFormats, pcActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetColorManagementVersion(
        uint cchColorManagementVersion,
        [NativeTypeName("WCHAR *")] ushort* wzColorManagementVersion,
        uint* pcchActual
    )
    {
        return (
            (delegate* unmanaged<IWICBitmapEncoderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[13])
        )(this, cchColorManagementVersion, wzColorManagementVersion, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeviceManufacturer(
        uint cchDeviceManufacturer,
        [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer,
        uint* pcchActual
    )
    {
        return (
            (delegate* unmanaged<IWICBitmapEncoderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[14])
        )(this, cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDeviceModels(
        uint cchDeviceModels,
        [NativeTypeName("WCHAR *")] ushort* wzDeviceModels,
        uint* pcchActual
    )
    {
        return (
            (delegate* unmanaged<IWICBitmapEncoderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[15])
        )(this, cchDeviceModels, wzDeviceModels, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetMimeTypes(
        uint cchMimeTypes,
        [NativeTypeName("WCHAR *")] ushort* wzMimeTypes,
        uint* pcchActual
    )
    {
        return (
            (delegate* unmanaged<IWICBitmapEncoderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[16])
        )(this, cchMimeTypes, wzMimeTypes, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetFileExtensions(
        uint cchFileExtensions,
        [NativeTypeName("WCHAR *")] ushort* wzFileExtensions,
        uint* pcchActual
    )
    {
        return (
            (delegate* unmanaged<IWICBitmapEncoderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[17])
        )(this, cchFileExtensions, wzFileExtensions, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DoesSupportAnimation(BOOL* pfSupportAnimation)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, BOOL*, int>)((*lpVtbl)[18]))(
            this,
            pfSupportAnimation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DoesSupportChromakey(BOOL* pfSupportChromakey)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, BOOL*, int>)((*lpVtbl)[19]))(
            this,
            pfSupportChromakey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT DoesSupportLossless(BOOL* pfSupportLossless)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, BOOL*, int>)((*lpVtbl)[20]))(
            this,
            pfSupportLossless
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT DoesSupportMultiframe(BOOL* pfSupportMultiframe)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, BOOL*, int>)((*lpVtbl)[21]))(
            this,
            pfSupportMultiframe
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT MatchesMimeType([NativeTypeName("LPCWSTR")] ushort* wzMimeType, BOOL* pfMatches)
    {
        return ((delegate* unmanaged<IWICBitmapEncoderInfo, ushort*, BOOL*, int>)((*lpVtbl)[22]))(
            this,
            wzMimeType,
            pfMatches
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateInstance(IWICBitmapEncoder* ppIBitmapEncoder)
    {
        return (
            (delegate* unmanaged<IWICBitmapEncoderInfo, IWICBitmapEncoder*, int>)((*lpVtbl)[23])
        )(this, ppIBitmapEncoder);
    }

    public interface Interface : IWICBitmapCodecInfo.Interface
    {
        [VtblIndex(23)]
        HRESULT CreateInstance(IWICBitmapEncoder* ppIBitmapEncoder);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetContainerFormat;

        [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, uint*, int> GetPixelFormats;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetColorManagementVersion;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetDeviceManufacturer;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetDeviceModels;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetMimeTypes;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetFileExtensions;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesSupportAnimation;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesSupportChromakey;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesSupportLossless;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesSupportMultiframe;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL*, int> MatchesMimeType;

        [NativeTypeName("HRESULT (IWICBitmapEncoder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapEncoder*, int> CreateInstance;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICBitmapEncoderInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICBitmapEncoderInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWICBitmapCodecInfo"/> to <see cref = "IWICBitmapEncoderInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWICBitmapCodecInfo"/> instance to be converted </param>
    public static explicit operator IWICBitmapEncoderInfo(
        Silk.NET.Windows.IWICBitmapCodecInfo value
    )
    {
        return new IWICBitmapEncoderInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICBitmapEncoderInfo"/> to <see cref = "Silk.NET.Windows.IWICBitmapCodecInfo"/>.</summary>
    /// <param name = "value">The <see cref = "IWICBitmapEncoderInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWICBitmapCodecInfo(
        IWICBitmapEncoderInfo value
    )
    {
        return new Silk.NET.Windows.IWICBitmapCodecInfo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWICComponentInfo"/> to <see cref = "IWICBitmapEncoderInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWICComponentInfo"/> instance to be converted </param>
    public static explicit operator IWICBitmapEncoderInfo(Silk.NET.Windows.IWICComponentInfo value)
    {
        return new IWICBitmapEncoderInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICBitmapEncoderInfo"/> to <see cref = "Silk.NET.Windows.IWICComponentInfo"/>.</summary>
    /// <param name = "value">The <see cref = "IWICBitmapEncoderInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWICComponentInfo(IWICBitmapEncoderInfo value)
    {
        return new Silk.NET.Windows.IWICComponentInfo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICBitmapEncoderInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICBitmapEncoderInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IWICBitmapEncoderInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICBitmapEncoderInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICBitmapEncoderInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICBitmapEncoderInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
