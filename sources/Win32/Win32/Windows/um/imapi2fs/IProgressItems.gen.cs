// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2C941FD7-975B-59BE-A960-9A2A262853A5")]
[NativeTypeName("struct IProgressItems : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IProgressItems : IProgressItems.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProgressItems));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProgressItems, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IProgressItems, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProgressItems, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IProgressItems, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IProgressItems, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
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
            (delegate* unmanaged<IProgressItems, Guid*, ushort**, uint, uint, int*, int>)(
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
                IProgressItems,
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
    public HRESULT get__NewEnum(IEnumVARIANT* NewEnum)
    {
        return ((delegate* unmanaged<IProgressItems, IEnumVARIANT*, int>)((*lpVtbl)[7]))(
            this,
            NewEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Item([NativeTypeName("long")] int Index, IProgressItem* item)
    {
        return ((delegate* unmanaged<IProgressItems, int, IProgressItem*, int>)((*lpVtbl)[8]))(
            this,
            Index,
            item
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Count([NativeTypeName("long *")] int* Count)
    {
        return ((delegate* unmanaged<IProgressItems, int*, int>)((*lpVtbl)[9]))(this, Count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ProgressItemFromBlock([NativeTypeName("ULONG")] uint block, IProgressItem* item)
    {
        return ((delegate* unmanaged<IProgressItems, uint, IProgressItem*, int>)((*lpVtbl)[10]))(
            this,
            block,
            item
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ProgressItemFromDescription(
        [NativeTypeName("BSTR")] ushort* description,
        IProgressItem* item
    )
    {
        return ((delegate* unmanaged<IProgressItems, ushort*, IProgressItem*, int>)((*lpVtbl)[11]))(
            this,
            description,
            item
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_EnumProgressItems(IEnumProgressItems* NewEnum)
    {
        return ((delegate* unmanaged<IProgressItems, IEnumProgressItems*, int>)((*lpVtbl)[12]))(
            this,
            NewEnum
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get__NewEnum(IEnumVARIANT* NewEnum);

        [VtblIndex(8)]
        HRESULT get_Item([NativeTypeName("long")] int Index, IProgressItem* item);

        [VtblIndex(9)]
        HRESULT get_Count([NativeTypeName("long *")] int* Count);

        [VtblIndex(10)]
        HRESULT ProgressItemFromBlock([NativeTypeName("ULONG")] uint block, IProgressItem* item);

        [VtblIndex(11)]
        HRESULT ProgressItemFromDescription(
            [NativeTypeName("BSTR")] ushort* description,
            IProgressItem* item
        );

        [VtblIndex(12)]
        HRESULT get_EnumProgressItems(IEnumProgressItems* NewEnum);
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

        [NativeTypeName("HRESULT (IEnumVARIANT **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumVARIANT*, int> get__NewEnum;

        [NativeTypeName("HRESULT (long, IProgressItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IProgressItem*, int> get_Item;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (ULONG, IProgressItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IProgressItem*, int> ProgressItemFromBlock;

        [NativeTypeName("HRESULT (BSTR, IProgressItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IProgressItem*,
            int> ProgressItemFromDescription;

        [NativeTypeName("HRESULT (IEnumProgressItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumProgressItems*, int> get_EnumProgressItems;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProgressItems"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProgressItems(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IProgressItems"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IProgressItems(Silk.NET.Windows.IDispatch value)
    {
        return new IProgressItems(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProgressItems"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IProgressItems"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IProgressItems value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProgressItems"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProgressItems(Silk.NET.Windows.IUnknown value)
    {
        return new IProgressItems(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProgressItems"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProgressItems"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProgressItems value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
