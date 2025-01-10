// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("30510413-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IWPCBlockedUrls : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWPCBlockedUrls : IWPCBlockedUrls.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWPCBlockedUrls));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWPCBlockedUrls, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWPCBlockedUrls, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWPCBlockedUrls, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IWPCBlockedUrls, uint*, int>)((*lpVtbl)[3]))(this, pdwCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetUrl(
        [NativeTypeName("DWORD")] uint dwIdx,
        [NativeTypeName("BSTR *")] ushort** pbstrUrl
    )
    {
        return ((delegate* unmanaged<IWPCBlockedUrls, uint, ushort**, int>)((*lpVtbl)[4]))(
            this,
            dwIdx,
            pbstrUrl
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount([NativeTypeName("DWORD *")] uint* pdwCount);

        [VtblIndex(4)]
        HRESULT GetUrl(
            [NativeTypeName("DWORD")] uint dwIdx,
            [NativeTypeName("BSTR *")] ushort** pbstrUrl
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetUrl;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWPCBlockedUrls"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWPCBlockedUrls(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWPCBlockedUrls"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWPCBlockedUrls(Silk.NET.Windows.IUnknown value)
    {
        return new IWPCBlockedUrls(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWPCBlockedUrls"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWPCBlockedUrls"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWPCBlockedUrls value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
