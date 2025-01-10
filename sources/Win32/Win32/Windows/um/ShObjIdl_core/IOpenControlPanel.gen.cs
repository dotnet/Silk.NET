// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D11AD862-66DE-4DF4-BF6C-1F5621996AF1")]
[NativeTypeName("struct IOpenControlPanel : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOpenControlPanel : IOpenControlPanel.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOpenControlPanel));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOpenControlPanel, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOpenControlPanel, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOpenControlPanel, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Open(
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        [NativeTypeName("LPCWSTR")] ushort* pszPage,
        IUnknown punkSite
    )
    {
        return (
            (delegate* unmanaged<IOpenControlPanel, ushort*, ushort*, IUnknown, int>)((*lpVtbl)[3])
        )(this, pszName, pszPage, punkSite);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPath(
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        [NativeTypeName("LPWSTR")] ushort* pszPath,
        uint cchPath
    )
    {
        return (
            (delegate* unmanaged<IOpenControlPanel, ushort*, ushort*, uint, int>)((*lpVtbl)[4])
        )(this, pszName, pszPath, cchPath);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentView(CPVIEW* pView)
    {
        return ((delegate* unmanaged<IOpenControlPanel, CPVIEW*, int>)((*lpVtbl)[5]))(this, pView);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Open(
            [NativeTypeName("LPCWSTR")] ushort* pszName,
            [NativeTypeName("LPCWSTR")] ushort* pszPage,
            IUnknown punkSite
        );

        [VtblIndex(4)]
        HRESULT GetPath(
            [NativeTypeName("LPCWSTR")] ushort* pszName,
            [NativeTypeName("LPWSTR")] ushort* pszPath,
            uint cchPath
        );

        [VtblIndex(5)]
        HRESULT GetCurrentView(CPVIEW* pView);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IUnknown, int> Open;

        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, uint, int> GetPath;

        [NativeTypeName("HRESULT (CPVIEW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CPVIEW*, int> GetCurrentView;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOpenControlPanel"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOpenControlPanel(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOpenControlPanel"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOpenControlPanel(Silk.NET.Windows.IUnknown value)
    {
        return new IOpenControlPanel(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOpenControlPanel"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOpenControlPanel"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOpenControlPanel value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
