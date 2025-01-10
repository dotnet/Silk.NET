// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7FE80CC8-C247-11D0-B93A-00A0C90312E1")]
[NativeTypeName("struct IShellFolderBand : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellFolderBand : IShellFolderBand.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellFolderBand));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellFolderBand, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellFolderBand, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellFolderBand, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeSFB(
        IShellFolder psf,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl
    )
    {
        return (
            (delegate* unmanaged<IShellFolderBand, IShellFolder, ITEMIDLIST*, int>)((*lpVtbl)[3])
        )(this, psf, pidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetBandInfoSFB([NativeTypeName("PBANDINFOSFB")] BANDINFOSFB* pbi)
    {
        return ((delegate* unmanaged<IShellFolderBand, BANDINFOSFB*, int>)((*lpVtbl)[4]))(
            this,
            pbi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBandInfoSFB([NativeTypeName("PBANDINFOSFB")] BANDINFOSFB* pbi)
    {
        return ((delegate* unmanaged<IShellFolderBand, BANDINFOSFB*, int>)((*lpVtbl)[5]))(
            this,
            pbi
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializeSFB(IShellFolder psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

        [VtblIndex(4)]
        HRESULT SetBandInfoSFB([NativeTypeName("PBANDINFOSFB")] BANDINFOSFB* pbi);

        [VtblIndex(5)]
        HRESULT GetBandInfoSFB([NativeTypeName("PBANDINFOSFB")] BANDINFOSFB* pbi);
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
            "HRESULT (IShellFolder *, LPCITEMIDLIST) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellFolder, ITEMIDLIST*, int> InitializeSFB;

        [NativeTypeName("HRESULT (PBANDINFOSFB) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BANDINFOSFB*, int> SetBandInfoSFB;

        [NativeTypeName("HRESULT (PBANDINFOSFB) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BANDINFOSFB*, int> GetBandInfoSFB;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellFolderBand"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellFolderBand(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellFolderBand"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellFolderBand(Silk.NET.Windows.IUnknown value)
    {
        return new IShellFolderBand(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellFolderBand"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellFolderBand"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellFolderBand value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
