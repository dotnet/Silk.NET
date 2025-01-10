// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9E1-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetBindInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetBindInfo : IInternetBindInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetBindInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetBindInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInternetBindInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetBindInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo)
    {
        return ((delegate* unmanaged<IInternetBindInfo, uint*, BINDINFO*, int>)((*lpVtbl)[3]))(
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
            (delegate* unmanaged<IInternetBindInfo, uint, ushort**, uint, uint*, int>)((*lpVtbl)[4])
        )(this, ulStringType, ppwzStr, cEl, pcElFetched);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, BINDINFO* pbindinfo);

        [VtblIndex(4)]
        HRESULT GetBindString(
            [NativeTypeName("ULONG")] uint ulStringType,
            [NativeTypeName("LPOLESTR *")] ushort** ppwzStr,
            [NativeTypeName("ULONG")] uint cEl,
            [NativeTypeName("ULONG *")] uint* pcElFetched
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IInternetBindInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInternetBindInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInternetBindInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInternetBindInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IInternetBindInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetBindInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetBindInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInternetBindInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
