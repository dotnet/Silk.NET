// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2C941FDC-975B-59BE-A960-9A2A262853A5")]
[NativeTypeName("struct IFsiDirectoryItem : IFsiItem")]
[NativeInheritance("IFsiItem")]
public unsafe partial struct IFsiDirectoryItem : IFsiDirectoryItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFsiDirectoryItem));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFsiDirectoryItem, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IFsiDirectoryItem, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
        )(this, iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IFsiDirectoryItem, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IFsiDirectoryItem,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, ushort**, int>)((*lpVtbl)[7]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FullPath([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, ushort**, int>)((*lpVtbl)[8]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CreationTime([NativeTypeName("DATE *")] double* pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, double*, int>)((*lpVtbl)[9]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_CreationTime([NativeTypeName("DATE")] double newVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, double, int>)((*lpVtbl)[10]))(this, newVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_LastAccessedTime([NativeTypeName("DATE *")] double* pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, double*, int>)((*lpVtbl)[11]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_LastAccessedTime([NativeTypeName("DATE")] double newVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, double, int>)((*lpVtbl)[12]))(this, newVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_LastModifiedTime([NativeTypeName("DATE *")] double* pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, double*, int>)((*lpVtbl)[13]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_LastModifiedTime([NativeTypeName("DATE")] double newVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, double, int>)((*lpVtbl)[14]))(this, newVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsHidden([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, short*, int>)((*lpVtbl)[15]))(this, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_IsHidden([NativeTypeName("VARIANT_BOOL")] short newVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, short, int>)((*lpVtbl)[16]))(this, newVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT FileSystemName(
        FsiFileSystems fileSystem,
        [NativeTypeName("BSTR *")] ushort** pVal
    )
    {
        return (
            (delegate* unmanaged<IFsiDirectoryItem, FsiFileSystems, ushort**, int>)((*lpVtbl)[17])
        )(this, fileSystem, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT FileSystemPath(
        FsiFileSystems fileSystem,
        [NativeTypeName("BSTR *")] ushort** pVal
    )
    {
        return (
            (delegate* unmanaged<IFsiDirectoryItem, FsiFileSystems, ushort**, int>)((*lpVtbl)[18])
        )(this, fileSystem, pVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get__NewEnum(IEnumVARIANT* NewEnum)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, IEnumVARIANT*, int>)((*lpVtbl)[19]))(
            this,
            NewEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Item([NativeTypeName("BSTR")] ushort* path, IFsiItem* item)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, ushort*, IFsiItem*, int>)((*lpVtbl)[20]))(
            this,
            path,
            item
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* Count)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, int*, int>)((*lpVtbl)[21]))(this, Count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_EnumFsiItems(IEnumFsiItems* NewEnum)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, IEnumFsiItems*, int>)((*lpVtbl)[22]))(
            this,
            NewEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT AddDirectory([NativeTypeName("BSTR")] ushort* path)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, ushort*, int>)((*lpVtbl)[23]))(this, path);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT AddFile([NativeTypeName("BSTR")] ushort* path, IStream fileData)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, ushort*, IStream, int>)((*lpVtbl)[24]))(
            this,
            path,
            fileData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT AddTree(
        [NativeTypeName("BSTR")] ushort* sourceDirectory,
        [NativeTypeName("VARIANT_BOOL")] short includeBaseDirectory
    )
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, ushort*, short, int>)((*lpVtbl)[25]))(
            this,
            sourceDirectory,
            includeBaseDirectory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT Add(IFsiItem item)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, IFsiItem, int>)((*lpVtbl)[26]))(this, item);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT Remove([NativeTypeName("BSTR")] ushort* path)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, ushort*, int>)((*lpVtbl)[27]))(this, path);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT RemoveTree([NativeTypeName("BSTR")] ushort* path)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem, ushort*, int>)((*lpVtbl)[28]))(this, path);
    }

    public interface Interface : IFsiItem.Interface
    {
        [VtblIndex(19)]
        HRESULT get__NewEnum(IEnumVARIANT* NewEnum);

        [VtblIndex(20)]
        HRESULT get_Item([NativeTypeName("BSTR")] ushort* path, IFsiItem* item);

        [VtblIndex(21)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* Count);

        [VtblIndex(22)]
        HRESULT get_EnumFsiItems(IEnumFsiItems* NewEnum);

        [VtblIndex(23)]
        HRESULT AddDirectory([NativeTypeName("BSTR")] ushort* path);

        [VtblIndex(24)]
        HRESULT AddFile([NativeTypeName("BSTR")] ushort* path, IStream fileData);

        [VtblIndex(25)]
        HRESULT AddTree(
            [NativeTypeName("BSTR")] ushort* sourceDirectory,
            [NativeTypeName("VARIANT_BOOL")] short includeBaseDirectory
        );

        [VtblIndex(26)]
        HRESULT Add(IFsiItem item);

        [VtblIndex(27)]
        HRESULT Remove([NativeTypeName("BSTR")] ushort* path);

        [VtblIndex(28)]
        HRESULT RemoveTree([NativeTypeName("BSTR")] ushort* path);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_FullPath;

        [NativeTypeName("HRESULT (DATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_CreationTime;

        [NativeTypeName("HRESULT (DATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_CreationTime;

        [NativeTypeName("HRESULT (DATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_LastAccessedTime;

        [NativeTypeName("HRESULT (DATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_LastAccessedTime;

        [NativeTypeName("HRESULT (DATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_LastModifiedTime;

        [NativeTypeName("HRESULT (DATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_LastModifiedTime;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsHidden;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_IsHidden;

        [NativeTypeName("HRESULT (FsiFileSystems, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems, ushort**, int> FileSystemName;

        [NativeTypeName("HRESULT (FsiFileSystems, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems, ushort**, int> FileSystemPath;

        [NativeTypeName("HRESULT (IEnumVARIANT **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumVARIANT*, int> get__NewEnum;

        [NativeTypeName("HRESULT (BSTR, IFsiItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IFsiItem*, int> get_Item;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (IEnumFsiItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumFsiItems*, int> get_EnumFsiItems;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> AddDirectory;

        [NativeTypeName("HRESULT (BSTR, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IStream, int> AddFile;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, int> AddTree;

        [NativeTypeName("HRESULT (IFsiItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFsiItem, int> Add;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> Remove;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RemoveTree;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFsiDirectoryItem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFsiDirectoryItem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IFsiItem"/> to <see cref = "IFsiDirectoryItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IFsiItem"/> instance to be converted </param>
    public static explicit operator IFsiDirectoryItem(Silk.NET.Windows.IFsiItem value)
    {
        return new IFsiDirectoryItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFsiDirectoryItem"/> to <see cref = "Silk.NET.Windows.IFsiItem"/>.</summary>
    /// <param name = "value">The <see cref = "IFsiDirectoryItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IFsiItem(IFsiDirectoryItem value)
    {
        return new Silk.NET.Windows.IFsiItem(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IFsiDirectoryItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IFsiDirectoryItem(Silk.NET.Windows.IDispatch value)
    {
        return new IFsiDirectoryItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFsiDirectoryItem"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IFsiDirectoryItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IFsiDirectoryItem value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFsiDirectoryItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFsiDirectoryItem(Silk.NET.Windows.IUnknown value)
    {
        return new IFsiDirectoryItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFsiDirectoryItem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFsiDirectoryItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFsiDirectoryItem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
