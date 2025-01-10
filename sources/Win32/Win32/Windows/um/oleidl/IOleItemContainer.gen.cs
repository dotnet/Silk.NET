// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000011C-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleItemContainer : IOleContainer")]
[NativeInheritance("IOleContainer")]
public unsafe partial struct IOleItemContainer : IOleItemContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleItemContainer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleItemContainer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleItemContainer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleItemContainer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ParseDisplayName(
        IBindCtx pbc,
        [NativeTypeName("LPOLESTR")] ushort* pszDisplayName,
        [NativeTypeName("ULONG *")] uint* pchEaten,
        IMoniker* ppmkOut
    )
    {
        return (
            (delegate* unmanaged<IOleItemContainer, IBindCtx, ushort*, uint*, IMoniker*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pbc, pszDisplayName, pchEaten, ppmkOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumObjects([NativeTypeName("DWORD")] uint grfFlags, IEnumUnknown* ppenum)
    {
        return ((delegate* unmanaged<IOleItemContainer, uint, IEnumUnknown*, int>)((*lpVtbl)[4]))(
            this,
            grfFlags,
            ppenum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LockContainer(BOOL fLock)
    {
        return ((delegate* unmanaged<IOleItemContainer, BOOL, int>)((*lpVtbl)[5]))(this, fLock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetObject(
        [NativeTypeName("LPOLESTR")] ushort* pszItem,
        [NativeTypeName("DWORD")] uint dwSpeedNeeded,
        IBindCtx pbc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<IOleItemContainer, ushort*, uint, IBindCtx, Guid*, void**, int>)(
                (*lpVtbl)[6]
            )
        )(this, pszItem, dwSpeedNeeded, pbc, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetObjectStorage(
        [NativeTypeName("LPOLESTR")] ushort* pszItem,
        IBindCtx pbc,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvStorage
    )
    {
        return (
            (delegate* unmanaged<IOleItemContainer, ushort*, IBindCtx, Guid*, void**, int>)(
                (*lpVtbl)[7]
            )
        )(this, pszItem, pbc, riid, ppvStorage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsRunning([NativeTypeName("LPOLESTR")] ushort* pszItem)
    {
        return ((delegate* unmanaged<IOleItemContainer, ushort*, int>)((*lpVtbl)[8]))(
            this,
            pszItem
        );
    }

    public interface Interface : IOleContainer.Interface
    {
        [VtblIndex(6)]
        HRESULT GetObject(
            [NativeTypeName("LPOLESTR")] ushort* pszItem,
            [NativeTypeName("DWORD")] uint dwSpeedNeeded,
            IBindCtx pbc,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvObject
        );

        [VtblIndex(7)]
        HRESULT GetObjectStorage(
            [NativeTypeName("LPOLESTR")] ushort* pszItem,
            IBindCtx pbc,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvStorage
        );

        [VtblIndex(8)]
        HRESULT IsRunning([NativeTypeName("LPOLESTR")] ushort* pszItem);
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
            "HRESULT (IBindCtx *, LPOLESTR, ULONG *, IMoniker **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBindCtx,
            ushort*,
            uint*,
            IMoniker*,
            int> ParseDisplayName;

        [NativeTypeName("HRESULT (DWORD, IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IEnumUnknown*, int> EnumObjects;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> LockContainer;

        [NativeTypeName(
            "HRESULT (LPOLESTR, DWORD, IBindCtx *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, IBindCtx, Guid*, void**, int> GetObject;

        [NativeTypeName(
            "HRESULT (LPOLESTR, IBindCtx *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, IBindCtx, Guid*, void**, int> GetObjectStorage;

        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> IsRunning;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleItemContainer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleItemContainer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IOleContainer"/> to <see cref = "IOleItemContainer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IOleContainer"/> instance to be converted </param>
    public static explicit operator IOleItemContainer(Silk.NET.Windows.IOleContainer value)
    {
        return new IOleItemContainer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleItemContainer"/> to <see cref = "Silk.NET.Windows.IOleContainer"/>.</summary>
    /// <param name = "value">The <see cref = "IOleItemContainer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IOleContainer(IOleItemContainer value)
    {
        return new Silk.NET.Windows.IOleContainer(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IParseDisplayName"/> to <see cref = "IOleItemContainer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IParseDisplayName"/> instance to be converted </param>
    public static explicit operator IOleItemContainer(Silk.NET.Windows.IParseDisplayName value)
    {
        return new IOleItemContainer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleItemContainer"/> to <see cref = "Silk.NET.Windows.IParseDisplayName"/>.</summary>
    /// <param name = "value">The <see cref = "IOleItemContainer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IParseDisplayName(IOleItemContainer value)
    {
        return new Silk.NET.Windows.IParseDisplayName(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleItemContainer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleItemContainer(Silk.NET.Windows.IUnknown value)
    {
        return new IOleItemContainer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleItemContainer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleItemContainer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleItemContainer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
