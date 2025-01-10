// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A3E015B7-A82C-4DCD-A150-569AEEED36AB")]
[NativeTypeName("struct IInternetBindInfoEx : IInternetBindInfo")]
[NativeInheritance("IInternetBindInfo")]
public unsafe partial struct IInternetBindInfoEx : IInternetBindInfoEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetBindInfoEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetBindInfoEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInternetBindInfoEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetBindInfoEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo)
    {
        return ((delegate* unmanaged<IInternetBindInfoEx, uint*, BINDINFO*, int>)((*lpVtbl)[3]))(
            this,
            grfBINDF,
            pbindinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBindString(
        [NativeTypeName("ULONG")] uint ulStringType,
        [NativeTypeName("LPOLESTR *")] ushort** ppwzStr,
        [NativeTypeName("ULONG")] uint cEl,
        [NativeTypeName("ULONG *")] uint* pcElFetched
    )
    {
        return (
            (delegate* unmanaged<IInternetBindInfoEx, uint, ushort**, uint, uint*, int>)(
                (*lpVtbl)[4]
            )
        )(this, ulStringType, ppwzStr, cEl, pcElFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBindInfoEx(
        [NativeTypeName("DWORD *")] uint* grfBINDF,
        BINDINFO* pbindinfo,
        [NativeTypeName("DWORD *")] uint* grfBINDF2,
        [NativeTypeName("DWORD *")] uint* pdwReserved
    )
    {
        return (
            (delegate* unmanaged<IInternetBindInfoEx, uint*, BINDINFO*, uint*, uint*, int>)(
                (*lpVtbl)[5]
            )
        )(this, grfBINDF, pbindinfo, grfBINDF2, pdwReserved);
    }

    public interface Interface : IInternetBindInfo.Interface
    {
        [VtblIndex(5)]
        HRESULT GetBindInfoEx(
            [NativeTypeName("DWORD *")] uint* grfBINDF,
            BINDINFO* pbindinfo,
            [NativeTypeName("DWORD *")] uint* grfBINDF2,
            [NativeTypeName("DWORD *")] uint* pdwReserved
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

        [NativeTypeName("HRESULT (DWORD *, BINDINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, BINDINFO*, int> GetBindInfo;

        [NativeTypeName("HRESULT (ULONG, LPOLESTR *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, uint, uint*, int> GetBindString;

        [NativeTypeName("HRESULT (DWORD *, BINDINFO *, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, BINDINFO*, uint*, uint*, int> GetBindInfoEx;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInternetBindInfoEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInternetBindInfoEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IInternetBindInfo"/> to <see cref = "IInternetBindInfoEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IInternetBindInfo"/> instance to be converted </param>
    public static explicit operator IInternetBindInfoEx(Silk.NET.Windows.IInternetBindInfo value)
    {
        return new IInternetBindInfoEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetBindInfoEx"/> to <see cref = "Silk.NET.Windows.IInternetBindInfo"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetBindInfoEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IInternetBindInfo(IInternetBindInfoEx value)
    {
        return new Silk.NET.Windows.IInternetBindInfo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInternetBindInfoEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInternetBindInfoEx(Silk.NET.Windows.IUnknown value)
    {
        return new IInternetBindInfoEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetBindInfoEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetBindInfoEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInternetBindInfoEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
