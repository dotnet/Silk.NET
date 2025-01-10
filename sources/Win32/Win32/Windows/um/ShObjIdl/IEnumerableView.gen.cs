// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8C8BF236-1AEC-495F-9894-91D57C3C686F")]
[NativeTypeName("struct IEnumerableView : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumerableView : IEnumerableView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumerableView));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumerableView, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEnumerableView, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumerableView, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetEnumReadyCallback(IEnumReadyCallback percb)
    {
        return ((delegate* unmanaged<IEnumerableView, IEnumReadyCallback, int>)((*lpVtbl)[3]))(
            this,
            percb
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateEnumIDListFromContents(
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
        [NativeTypeName("DWORD")] uint dwEnumFlags,
        IEnumIDList* ppEnumIDList
    )
    {
        return (
            (delegate* unmanaged<IEnumerableView, ITEMIDLIST*, uint, IEnumIDList*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pidlFolder, dwEnumFlags, ppEnumIDList);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetEnumReadyCallback(IEnumReadyCallback percb);

        [VtblIndex(4)]
        HRESULT CreateEnumIDListFromContents(
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder,
            [NativeTypeName("DWORD")] uint dwEnumFlags,
            IEnumIDList* ppEnumIDList
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

        [NativeTypeName("HRESULT (IEnumReadyCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumReadyCallback, int> SetEnumReadyCallback;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, DWORD, IEnumIDList **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ITEMIDLIST*,
            uint,
            IEnumIDList*,
            int> CreateEnumIDListFromContents;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEnumerableView"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEnumerableView(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEnumerableView"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEnumerableView(Silk.NET.Windows.IUnknown value)
    {
        return new IEnumerableView(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEnumerableView"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEnumerableView"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEnumerableView value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
