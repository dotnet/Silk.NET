// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("376BD3AA-3845-101B-84ED-08002B2EC713")]
[NativeTypeName("struct IPerPropertyBrowsing : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPerPropertyBrowsing : IPerPropertyBrowsing.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPerPropertyBrowsing));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPerPropertyBrowsing, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPerPropertyBrowsing, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPerPropertyBrowsing, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayString(
        [NativeTypeName("DISPID")] int dispID,
        [NativeTypeName("BSTR *")] ushort** pBstr
    )
    {
        return ((delegate* unmanaged<IPerPropertyBrowsing, int, ushort**, int>)((*lpVtbl)[3]))(
            this,
            dispID,
            pBstr
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT MapPropertyToPage(
        [NativeTypeName("DISPID")] int dispID,
        [NativeTypeName("CLSID *")] Guid* pClsid
    )
    {
        return ((delegate* unmanaged<IPerPropertyBrowsing, int, Guid*, int>)((*lpVtbl)[4]))(
            this,
            dispID,
            pClsid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPredefinedStrings(
        [NativeTypeName("DISPID")] int dispID,
        CALPOLESTR* pCaStringsOut,
        CADWORD* pCaCookiesOut
    )
    {
        return (
            (delegate* unmanaged<IPerPropertyBrowsing, int, CALPOLESTR*, CADWORD*, int>)(
                (*lpVtbl)[5]
            )
        )(this, dispID, pCaStringsOut, pCaCookiesOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPredefinedValue(
        [NativeTypeName("DISPID")] int dispID,
        [NativeTypeName("DWORD")] uint dwCookie,
        VARIANT* pVarOut
    )
    {
        return (
            (delegate* unmanaged<IPerPropertyBrowsing, int, uint, VARIANT*, int>)((*lpVtbl)[6])
        )(this, dispID, dwCookie, pVarOut);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDisplayString(
            [NativeTypeName("DISPID")] int dispID,
            [NativeTypeName("BSTR *")] ushort** pBstr
        );

        [VtblIndex(4)]
        HRESULT MapPropertyToPage(
            [NativeTypeName("DISPID")] int dispID,
            [NativeTypeName("CLSID *")] Guid* pClsid
        );

        [VtblIndex(5)]
        HRESULT GetPredefinedStrings(
            [NativeTypeName("DISPID")] int dispID,
            CALPOLESTR* pCaStringsOut,
            CADWORD* pCaCookiesOut
        );

        [VtblIndex(6)]
        HRESULT GetPredefinedValue(
            [NativeTypeName("DISPID")] int dispID,
            [NativeTypeName("DWORD")] uint dwCookie,
            VARIANT* pVarOut
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

        [NativeTypeName("HRESULT (DISPID, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> GetDisplayString;

        [NativeTypeName("HRESULT (DISPID, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, int> MapPropertyToPage;

        [NativeTypeName("HRESULT (DISPID, CALPOLESTR *, CADWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, CALPOLESTR*, CADWORD*, int> GetPredefinedStrings;

        [NativeTypeName("HRESULT (DISPID, DWORD, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, VARIANT*, int> GetPredefinedValue;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPerPropertyBrowsing"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPerPropertyBrowsing(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPerPropertyBrowsing"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPerPropertyBrowsing(Silk.NET.Windows.IUnknown value)
    {
        return new IPerPropertyBrowsing(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPerPropertyBrowsing"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPerPropertyBrowsing"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPerPropertyBrowsing value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
