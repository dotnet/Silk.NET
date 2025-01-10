// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A9DB33A2-AF5F-43C7-B679-74F5984B5AA4")]
[NativeTypeName("struct IWICPixelFormatInfo2 : IWICPixelFormatInfo")]
[NativeInheritance("IWICPixelFormatInfo")]
public unsafe partial struct IWICPixelFormatInfo2 : IWICPixelFormatInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICPixelFormatInfo2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICPixelFormatInfo2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetComponentType(WICComponentType* pType)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo2, WICComponentType*, int>)((*lpVtbl)[3]))(
            this,
            pType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo2, Guid*, int>)((*lpVtbl)[4]))(
            this,
            pclsid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo2, uint*, int>)((*lpVtbl)[5]))(
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
            (delegate* unmanaged<IWICPixelFormatInfo2, uint, ushort*, uint*, int>)((*lpVtbl)[6])
        )(this, cchAuthor, wzAuthor, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVendorGUID(Guid* pguidVendor)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo2, Guid*, int>)((*lpVtbl)[7]))(
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
            (delegate* unmanaged<IWICPixelFormatInfo2, uint, ushort*, uint*, int>)((*lpVtbl)[8])
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
            (delegate* unmanaged<IWICPixelFormatInfo2, uint, ushort*, uint*, int>)((*lpVtbl)[9])
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
            (delegate* unmanaged<IWICPixelFormatInfo2, uint, ushort*, uint*, int>)((*lpVtbl)[10])
        )(this, cchFriendlyName, wzFriendlyName, pcchActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFormatGUID(Guid* pFormat)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo2, Guid*, int>)((*lpVtbl)[11]))(
            this,
            pFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetColorContext(IWICColorContext* ppIColorContext)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo2, IWICColorContext*, int>)((*lpVtbl)[12]))(
            this,
            ppIColorContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetBitsPerPixel(uint* puiBitsPerPixel)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo2, uint*, int>)((*lpVtbl)[13]))(
            this,
            puiBitsPerPixel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetChannelCount(uint* puiChannelCount)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo2, uint*, int>)((*lpVtbl)[14]))(
            this,
            puiChannelCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetChannelMask(
        uint uiChannelIndex,
        uint cbMaskBuffer,
        byte* pbMaskBuffer,
        uint* pcbActual
    )
    {
        return (
            (delegate* unmanaged<IWICPixelFormatInfo2, uint, uint, byte*, uint*, int>)(
                (*lpVtbl)[15]
            )
        )(this, uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SupportsTransparency(BOOL* pfSupportsTransparency)
    {
        return ((delegate* unmanaged<IWICPixelFormatInfo2, BOOL*, int>)((*lpVtbl)[16]))(
            this,
            pfSupportsTransparency
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetNumericRepresentation(
        WICPixelFormatNumericRepresentation* pNumericRepresentation
    )
    {
        return (
            (delegate* unmanaged<IWICPixelFormatInfo2, WICPixelFormatNumericRepresentation*, int>)(
                (*lpVtbl)[17]
            )
        )(this, pNumericRepresentation);
    }

    public interface Interface : IWICPixelFormatInfo.Interface
    {
        [VtblIndex(16)]
        HRESULT SupportsTransparency(BOOL* pfSupportsTransparency);

        [VtblIndex(17)]
        HRESULT GetNumericRepresentation(
            WICPixelFormatNumericRepresentation* pNumericRepresentation
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetFormatGUID;

        [NativeTypeName("HRESULT (IWICColorContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICColorContext*, int> GetColorContext;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetBitsPerPixel;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetChannelCount;

        [NativeTypeName("HRESULT (UINT, UINT, BYTE *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint*, int> GetChannelMask;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> SupportsTransparency;

        [NativeTypeName("HRESULT (WICPixelFormatNumericRepresentation *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            WICPixelFormatNumericRepresentation*,
            int> GetNumericRepresentation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICPixelFormatInfo2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICPixelFormatInfo2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWICPixelFormatInfo"/> to <see cref = "IWICPixelFormatInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWICPixelFormatInfo"/> instance to be converted </param>
    public static explicit operator IWICPixelFormatInfo2(Silk.NET.Windows.IWICPixelFormatInfo value)
    {
        return new IWICPixelFormatInfo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICPixelFormatInfo2"/> to <see cref = "Silk.NET.Windows.IWICPixelFormatInfo"/>.</summary>
    /// <param name = "value">The <see cref = "IWICPixelFormatInfo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWICPixelFormatInfo(IWICPixelFormatInfo2 value)
    {
        return new Silk.NET.Windows.IWICPixelFormatInfo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWICComponentInfo"/> to <see cref = "IWICPixelFormatInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWICComponentInfo"/> instance to be converted </param>
    public static explicit operator IWICPixelFormatInfo2(Silk.NET.Windows.IWICComponentInfo value)
    {
        return new IWICPixelFormatInfo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICPixelFormatInfo2"/> to <see cref = "Silk.NET.Windows.IWICComponentInfo"/>.</summary>
    /// <param name = "value">The <see cref = "IWICPixelFormatInfo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWICComponentInfo(IWICPixelFormatInfo2 value)
    {
        return new Silk.NET.Windows.IWICComponentInfo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICPixelFormatInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICPixelFormatInfo2(Silk.NET.Windows.IUnknown value)
    {
        return new IWICPixelFormatInfo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICPixelFormatInfo2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICPixelFormatInfo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICPixelFormatInfo2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
