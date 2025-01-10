// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B63EA76D-1F85-456F-A19C-48159EFA858B")]
[NativeTypeName("struct IShellItemArray : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellItemArray : IShellItemArray.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellItemArray));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellItemArray, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellItemArray, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellItemArray, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BindToHandler(
        IBindCtx pbc,
        [NativeTypeName("const GUID &")] Guid* bhid,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvOut
    )
    {
        return (
            (delegate* unmanaged<IShellItemArray, IBindCtx, Guid*, Guid*, void**, int>)(
                (*lpVtbl)[3]
            )
        )(this, pbc, bhid, riid, ppvOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyStore(
        GETPROPERTYSTOREFLAGS flags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IShellItemArray, GETPROPERTYSTOREFLAGS, Guid*, void**, int>)(
                (*lpVtbl)[4]
            )
        )(this, flags, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPropertyDescriptionList(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* keyType,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IShellItemArray, PROPERTYKEY*, Guid*, void**, int>)((*lpVtbl)[5])
        )(this, keyType, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAttributes(
        SIATTRIBFLAGS AttribFlags,
        [NativeTypeName("SFGAOF")] uint sfgaoMask,
        [NativeTypeName("SFGAOF *")] uint* psfgaoAttribs
    )
    {
        return (
            (delegate* unmanaged<IShellItemArray, SIATTRIBFLAGS, uint, uint*, int>)((*lpVtbl)[6])
        )(this, AttribFlags, sfgaoMask, psfgaoAttribs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCount([NativeTypeName("DWORD *")] uint* pdwNumItems)
    {
        return ((delegate* unmanaged<IShellItemArray, uint*, int>)((*lpVtbl)[7]))(
            this,
            pdwNumItems
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetItemAt([NativeTypeName("DWORD")] uint dwIndex, IShellItem* ppsi)
    {
        return ((delegate* unmanaged<IShellItemArray, uint, IShellItem*, int>)((*lpVtbl)[8]))(
            this,
            dwIndex,
            ppsi
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnumItems(IEnumShellItems* ppenumShellItems)
    {
        return ((delegate* unmanaged<IShellItemArray, IEnumShellItems*, int>)((*lpVtbl)[9]))(
            this,
            ppenumShellItems
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BindToHandler(
            IBindCtx pbc,
            [NativeTypeName("const GUID &")] Guid* bhid,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvOut
        );

        [VtblIndex(4)]
        HRESULT GetPropertyStore(
            GETPROPERTYSTOREFLAGS flags,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(5)]
        HRESULT GetPropertyDescriptionList(
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* keyType,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(6)]
        HRESULT GetAttributes(
            SIATTRIBFLAGS AttribFlags,
            [NativeTypeName("SFGAOF")] uint sfgaoMask,
            [NativeTypeName("SFGAOF *")] uint* psfgaoAttribs
        );

        [VtblIndex(7)]
        HRESULT GetCount([NativeTypeName("DWORD *")] uint* pdwNumItems);

        [VtblIndex(8)]
        HRESULT GetItemAt([NativeTypeName("DWORD")] uint dwIndex, IShellItem* ppsi);

        [VtblIndex(9)]
        HRESULT EnumItems(IEnumShellItems* ppenumShellItems);
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
            "HRESULT (IBindCtx *, const GUID &, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBindCtx, Guid*, Guid*, void**, int> BindToHandler;

        [NativeTypeName(
            "HRESULT (GETPROPERTYSTOREFLAGS, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            GETPROPERTYSTOREFLAGS,
            Guid*,
            void**,
            int> GetPropertyStore;

        [NativeTypeName(
            "HRESULT (const PROPERTYKEY &, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PROPERTYKEY*,
            Guid*,
            void**,
            int> GetPropertyDescriptionList;

        [NativeTypeName("HRESULT (SIATTRIBFLAGS, SFGAOF, SFGAOF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIATTRIBFLAGS, uint, uint*, int> GetAttributes;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (DWORD, IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IShellItem*, int> GetItemAt;

        [NativeTypeName("HRESULT (IEnumShellItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumShellItems*, int> EnumItems;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellItemArray"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellItemArray(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellItemArray"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellItemArray(Silk.NET.Windows.IUnknown value)
    {
        return new IShellItemArray(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellItemArray"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellItemArray"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellItemArray value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
