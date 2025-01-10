// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A7E025DD-5303-4A62-89D6-E747E1EFAC73")]
[NativeTypeName("struct IMFSAMIStyle : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSAMIStyle : IMFSAMIStyle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSAMIStyle));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSAMIStyle, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSAMIStyle, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSAMIStyle, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStyleCount([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IMFSAMIStyle, uint*, int>)((*lpVtbl)[3]))(this, pdwCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStyles(PROPVARIANT* pPropVarStyleArray)
    {
        return ((delegate* unmanaged<IMFSAMIStyle, PROPVARIANT*, int>)((*lpVtbl)[4]))(
            this,
            pPropVarStyleArray
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetSelectedStyle([NativeTypeName("LPCWSTR")] ushort* pwszStyle)
    {
        return ((delegate* unmanaged<IMFSAMIStyle, ushort*, int>)((*lpVtbl)[5]))(this, pwszStyle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSelectedStyle([NativeTypeName("LPWSTR *")] ushort** ppwszStyle)
    {
        return ((delegate* unmanaged<IMFSAMIStyle, ushort**, int>)((*lpVtbl)[6]))(this, ppwszStyle);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStyleCount([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(4)]
        HRESULT GetStyles(PROPVARIANT* pPropVarStyleArray);

        [VtblIndex(5)]
        HRESULT SetSelectedStyle([NativeTypeName("LPCWSTR")] ushort* pwszStyle);

        [VtblIndex(6)]
        HRESULT GetSelectedStyle([NativeTypeName("LPWSTR *")] ushort** ppwszStyle);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetStyleCount;

        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> GetStyles;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetSelectedStyle;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSelectedStyle;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSAMIStyle"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSAMIStyle(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSAMIStyle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSAMIStyle(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSAMIStyle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSAMIStyle"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSAMIStyle"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSAMIStyle value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
