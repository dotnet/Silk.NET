// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EEBF1F5B-07C1-4447-A3AB-22ACAF78A804")]
[NativeTypeName("struct IWICMetadataReaderInfo : IWICMetadataHandlerInfo")]
[NativeInheritance("IWICMetadataHandlerInfo")]
public unsafe partial struct IWICMetadataReaderInfo : IWICMetadataReaderInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataReaderInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICMetadataReaderInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICMetadataReaderInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICMetadataReaderInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetComponentType(WICComponentType* pType)
    {
        return (
            (delegate* unmanaged<IWICMetadataReaderInfo, WICComponentType*, int>)((*lpVtbl)[3])
        )(this, pType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<IWICMetadataReaderInfo, Guid*, int>)((*lpVtbl)[4]))(
            this,
            pclsid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
    {
        return ((delegate* unmanaged<IWICMetadataReaderInfo, uint*, int>)((*lpVtbl)[5]))(
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
            (delegate* unmanaged<IWICMetadataReaderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[6])
        )(this, cchAuthor, wzAuthor, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVendorGUID(Guid* pguidVendor)
    {
        return ((delegate* unmanaged<IWICMetadataReaderInfo, Guid*, int>)((*lpVtbl)[7]))(
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
            (delegate* unmanaged<IWICMetadataReaderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[8])
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
            (delegate* unmanaged<IWICMetadataReaderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[9])
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
            (delegate* unmanaged<IWICMetadataReaderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[10])
        )(this, cchFriendlyName, wzFriendlyName, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMetadataFormat(Guid* pguidMetadataFormat)
    {
        return ((delegate* unmanaged<IWICMetadataReaderInfo, Guid*, int>)((*lpVtbl)[11]))(
            this,
            pguidMetadataFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetContainerFormats(
        uint cContainerFormats,
        Guid* pguidContainerFormats,
        uint* pcchActual
    )
    {
        return (
            (delegate* unmanaged<IWICMetadataReaderInfo, uint, Guid*, uint*, int>)((*lpVtbl)[12])
        )(this, cContainerFormats, pguidContainerFormats, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDeviceManufacturer(
        uint cchDeviceManufacturer,
        [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer,
        uint* pcchActual
    )
    {
        return (
            (delegate* unmanaged<IWICMetadataReaderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[13])
        )(this, cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeviceModels(
        uint cchDeviceModels,
        [NativeTypeName("WCHAR *")] ushort* wzDeviceModels,
        uint* pcchActual
    )
    {
        return (
            (delegate* unmanaged<IWICMetadataReaderInfo, uint, ushort*, uint*, int>)((*lpVtbl)[14])
        )(this, cchDeviceModels, wzDeviceModels, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DoesRequireFullStream(BOOL* pfRequiresFullStream)
    {
        return ((delegate* unmanaged<IWICMetadataReaderInfo, BOOL*, int>)((*lpVtbl)[15]))(
            this,
            pfRequiresFullStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT DoesSupportPadding(BOOL* pfSupportsPadding)
    {
        return ((delegate* unmanaged<IWICMetadataReaderInfo, BOOL*, int>)((*lpVtbl)[16]))(
            this,
            pfSupportsPadding
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT DoesRequireFixedSize(BOOL* pfFixedSize)
    {
        return ((delegate* unmanaged<IWICMetadataReaderInfo, BOOL*, int>)((*lpVtbl)[17]))(
            this,
            pfFixedSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetPatterns(
        [NativeTypeName("const GUID &")] Guid* guidContainerFormat,
        uint cbSize,
        WICMetadataPattern* pPattern,
        uint* pcCount,
        uint* pcbActual
    )
    {
        return (
            (delegate* unmanaged<
                IWICMetadataReaderInfo,
                Guid*,
                uint,
                WICMetadataPattern*,
                uint*,
                uint*,
                int>)((*lpVtbl)[18])
        )(this, guidContainerFormat, cbSize, pPattern, pcCount, pcbActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT MatchesPattern(
        [NativeTypeName("const GUID &")] Guid* guidContainerFormat,
        IStream pIStream,
        BOOL* pfMatches
    )
    {
        return (
            (delegate* unmanaged<IWICMetadataReaderInfo, Guid*, IStream, BOOL*, int>)((*lpVtbl)[19])
        )(this, guidContainerFormat, pIStream, pfMatches);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateInstance(IWICMetadataReader* ppIReader)
    {
        return (
            (delegate* unmanaged<IWICMetadataReaderInfo, IWICMetadataReader*, int>)((*lpVtbl)[20])
        )(this, ppIReader);
    }

    public interface Interface : IWICMetadataHandlerInfo.Interface
    {
        [VtblIndex(18)]
        HRESULT GetPatterns(
            [NativeTypeName("const GUID &")] Guid* guidContainerFormat,
            uint cbSize,
            WICMetadataPattern* pPattern,
            uint* pcCount,
            uint* pcbActual
        );

        [VtblIndex(19)]
        HRESULT MatchesPattern(
            [NativeTypeName("const GUID &")] Guid* guidContainerFormat,
            IStream pIStream,
            BOOL* pfMatches
        );

        [VtblIndex(20)]
        HRESULT CreateInstance(IWICMetadataReader* ppIReader);
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
        public delegate* unmanaged<TSelf*, Guid*, int> GetMetadataFormat;

        [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, uint*, int> GetContainerFormats;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetDeviceManufacturer;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetDeviceModels;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesRequireFullStream;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesSupportPadding;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> DoesRequireFixedSize;

        [NativeTypeName(
            "HRESULT (const GUID &, UINT, WICMetadataPattern *, UINT *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            uint,
            WICMetadataPattern*,
            uint*,
            uint*,
            int> GetPatterns;

        [NativeTypeName("HRESULT (const GUID &, IStream *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IStream, BOOL*, int> MatchesPattern;

        [NativeTypeName("HRESULT (IWICMetadataReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICMetadataReader*, int> CreateInstance;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICMetadataReaderInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICMetadataReaderInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWICMetadataHandlerInfo"/> to <see cref = "IWICMetadataReaderInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWICMetadataHandlerInfo"/> instance to be converted </param>
    public static explicit operator IWICMetadataReaderInfo(
        Silk.NET.Windows.IWICMetadataHandlerInfo value
    )
    {
        return new IWICMetadataReaderInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICMetadataReaderInfo"/> to <see cref = "Silk.NET.Windows.IWICMetadataHandlerInfo"/>.</summary>
    /// <param name = "value">The <see cref = "IWICMetadataReaderInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWICMetadataHandlerInfo(
        IWICMetadataReaderInfo value
    )
    {
        return new Silk.NET.Windows.IWICMetadataHandlerInfo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWICComponentInfo"/> to <see cref = "IWICMetadataReaderInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWICComponentInfo"/> instance to be converted </param>
    public static explicit operator IWICMetadataReaderInfo(Silk.NET.Windows.IWICComponentInfo value)
    {
        return new IWICMetadataReaderInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICMetadataReaderInfo"/> to <see cref = "Silk.NET.Windows.IWICComponentInfo"/>.</summary>
    /// <param name = "value">The <see cref = "IWICMetadataReaderInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWICComponentInfo(IWICMetadataReaderInfo value)
    {
        return new Silk.NET.Windows.IWICComponentInfo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICMetadataReaderInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICMetadataReaderInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IWICMetadataReaderInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICMetadataReaderInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICMetadataReaderInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICMetadataReaderInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
