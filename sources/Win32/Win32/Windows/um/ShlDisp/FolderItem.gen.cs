// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FAC32C80-CBE4-11CE-8350-444553540000")]
[NativeTypeName("struct FolderItem : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct FolderItem : FolderItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_FolderItem));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<FolderItem, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<FolderItem, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<FolderItem, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<FolderItem, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<FolderItem, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
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
            (delegate* unmanaged<FolderItem, Guid*, ushort**, uint, uint, int*, int>)((*lpVtbl)[5])
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
                FolderItem,
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
    public HRESULT get_Application(IDispatch* ppid)
    {
        return ((delegate* unmanaged<FolderItem, IDispatch*, int>)((*lpVtbl)[7]))(this, ppid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Parent(IDispatch* ppid)
    {
        return ((delegate* unmanaged<FolderItem, IDispatch*, int>)((*lpVtbl)[8]))(this, ppid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<FolderItem, ushort**, int>)((*lpVtbl)[9]))(this, pbs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Name([NativeTypeName("BSTR")] ushort* bs)
    {
        return ((delegate* unmanaged<FolderItem, ushort*, int>)((*lpVtbl)[10]))(this, bs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Path([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<FolderItem, ushort**, int>)((*lpVtbl)[11]))(this, pbs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_GetLink(IDispatch* ppid)
    {
        return ((delegate* unmanaged<FolderItem, IDispatch*, int>)((*lpVtbl)[12]))(this, ppid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_GetFolder(IDispatch* ppid)
    {
        return ((delegate* unmanaged<FolderItem, IDispatch*, int>)((*lpVtbl)[13]))(this, ppid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsLink([NativeTypeName("VARIANT_BOOL *")] short* pb)
    {
        return ((delegate* unmanaged<FolderItem, short*, int>)((*lpVtbl)[14]))(this, pb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsFolder([NativeTypeName("VARIANT_BOOL *")] short* pb)
    {
        return ((delegate* unmanaged<FolderItem, short*, int>)((*lpVtbl)[15]))(this, pb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsFileSystem([NativeTypeName("VARIANT_BOOL *")] short* pb)
    {
        return ((delegate* unmanaged<FolderItem, short*, int>)((*lpVtbl)[16]))(this, pb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_IsBrowsable([NativeTypeName("VARIANT_BOOL *")] short* pb)
    {
        return ((delegate* unmanaged<FolderItem, short*, int>)((*lpVtbl)[17]))(this, pb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ModifyDate([NativeTypeName("DATE *")] double* pdt)
    {
        return ((delegate* unmanaged<FolderItem, double*, int>)((*lpVtbl)[18]))(this, pdt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_ModifyDate([NativeTypeName("DATE")] double dt)
    {
        return ((delegate* unmanaged<FolderItem, double, int>)((*lpVtbl)[19]))(this, dt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Size([NativeTypeName("LONG *")] int* pul)
    {
        return ((delegate* unmanaged<FolderItem, int*, int>)((*lpVtbl)[20]))(this, pul);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Type([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<FolderItem, ushort**, int>)((*lpVtbl)[21]))(this, pbs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT Verbs(FolderItemVerbs* ppfic)
    {
        return ((delegate* unmanaged<FolderItem, FolderItemVerbs*, int>)((*lpVtbl)[22]))(
            this,
            ppfic
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT InvokeVerb(VARIANT vVerb)
    {
        return ((delegate* unmanaged<FolderItem, VARIANT, int>)((*lpVtbl)[23]))(this, vVerb);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Application(IDispatch* ppid);

        [VtblIndex(8)]
        HRESULT get_Parent(IDispatch* ppid);

        [VtblIndex(9)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbs);

        [VtblIndex(10)]
        HRESULT put_Name([NativeTypeName("BSTR")] ushort* bs);

        [VtblIndex(11)]
        HRESULT get_Path([NativeTypeName("BSTR *")] ushort** pbs);

        [VtblIndex(12)]
        HRESULT get_GetLink(IDispatch* ppid);

        [VtblIndex(13)]
        HRESULT get_GetFolder(IDispatch* ppid);

        [VtblIndex(14)]
        HRESULT get_IsLink([NativeTypeName("VARIANT_BOOL *")] short* pb);

        [VtblIndex(15)]
        HRESULT get_IsFolder([NativeTypeName("VARIANT_BOOL *")] short* pb);

        [VtblIndex(16)]
        HRESULT get_IsFileSystem([NativeTypeName("VARIANT_BOOL *")] short* pb);

        [VtblIndex(17)]
        HRESULT get_IsBrowsable([NativeTypeName("VARIANT_BOOL *")] short* pb);

        [VtblIndex(18)]
        HRESULT get_ModifyDate([NativeTypeName("DATE *")] double* pdt);

        [VtblIndex(19)]
        HRESULT put_ModifyDate([NativeTypeName("DATE")] double dt);

        [VtblIndex(20)]
        HRESULT get_Size([NativeTypeName("LONG *")] int* pul);

        [VtblIndex(21)]
        HRESULT get_Type([NativeTypeName("BSTR *")] ushort** pbs);

        [VtblIndex(22)]
        HRESULT Verbs(FolderItemVerbs* ppfic);

        [VtblIndex(23)]
        HRESULT InvokeVerb(VARIANT vVerb);
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

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Application;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_Parent;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Path;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_GetLink;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_GetFolder;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsLink;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsFolder;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsFileSystem;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsBrowsable;

        [NativeTypeName("HRESULT (DATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_ModifyDate;

        [NativeTypeName("HRESULT (DATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_ModifyDate;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Size;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Type;

        [NativeTypeName("HRESULT (FolderItemVerbs **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItemVerbs*, int> Verbs;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> InvokeVerb;
    }

    /// <summary>Initializes a new instance of the <see cref = "FolderItem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public FolderItem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "FolderItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator FolderItem(Silk.NET.Windows.IDispatch value)
    {
        return new FolderItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "FolderItem"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "FolderItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(FolderItem value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "FolderItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator FolderItem(Silk.NET.Windows.IUnknown value)
    {
        return new FolderItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "FolderItem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "FolderItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(FolderItem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
