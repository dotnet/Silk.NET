// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2933BF83-7B36-11D2-B20E-00C04F983E60")]
[NativeTypeName("struct IXMLDOMNamedNodeMap : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IXMLDOMNamedNodeMap : IXMLDOMNamedNodeMap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMNamedNodeMap));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLDOMNamedNodeMap, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXMLDOMNamedNodeMap, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLDOMNamedNodeMap, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLDOMNamedNodeMap, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IXMLDOMNamedNodeMap, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<IXMLDOMNamedNodeMap, Guid*, ushort**, uint, uint, int*, int>)(
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
                IXMLDOMNamedNodeMap,
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
    public HRESULT getNamedItem([NativeTypeName("BSTR")] ushort* name, IXMLDOMNode* namedItem)
    {
        return (
            (delegate* unmanaged<IXMLDOMNamedNodeMap, ushort*, IXMLDOMNode*, int>)((*lpVtbl)[7])
        )(this, name, namedItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT setNamedItem(IXMLDOMNode newItem, IXMLDOMNode* nameItem)
    {
        return (
            (delegate* unmanaged<IXMLDOMNamedNodeMap, IXMLDOMNode, IXMLDOMNode*, int>)((*lpVtbl)[8])
        )(this, newItem, nameItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT removeNamedItem([NativeTypeName("BSTR")] ushort* name, IXMLDOMNode* namedItem)
    {
        return (
            (delegate* unmanaged<IXMLDOMNamedNodeMap, ushort*, IXMLDOMNode*, int>)((*lpVtbl)[9])
        )(this, name, namedItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_item([NativeTypeName("long")] int index, IXMLDOMNode* listItem)
    {
        return ((delegate* unmanaged<IXMLDOMNamedNodeMap, int, IXMLDOMNode*, int>)((*lpVtbl)[10]))(
            this,
            index,
            listItem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_length([NativeTypeName("long *")] int* listLength)
    {
        return ((delegate* unmanaged<IXMLDOMNamedNodeMap, int*, int>)((*lpVtbl)[11]))(
            this,
            listLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT getQualifiedItem(
        [NativeTypeName("BSTR")] ushort* baseName,
        [NativeTypeName("BSTR")] ushort* namespaceURI,
        IXMLDOMNode* qualifiedItem
    )
    {
        return (
            (delegate* unmanaged<IXMLDOMNamedNodeMap, ushort*, ushort*, IXMLDOMNode*, int>)(
                (*lpVtbl)[12]
            )
        )(this, baseName, namespaceURI, qualifiedItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT removeQualifiedItem(
        [NativeTypeName("BSTR")] ushort* baseName,
        [NativeTypeName("BSTR")] ushort* namespaceURI,
        IXMLDOMNode* qualifiedItem
    )
    {
        return (
            (delegate* unmanaged<IXMLDOMNamedNodeMap, ushort*, ushort*, IXMLDOMNode*, int>)(
                (*lpVtbl)[13]
            )
        )(this, baseName, namespaceURI, qualifiedItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT nextNode(IXMLDOMNode* nextItem)
    {
        return ((delegate* unmanaged<IXMLDOMNamedNodeMap, IXMLDOMNode*, int>)((*lpVtbl)[14]))(
            this,
            nextItem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT reset()
    {
        return ((delegate* unmanaged<IXMLDOMNamedNodeMap, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get__newEnum(IUnknown* ppUnk)
    {
        return ((delegate* unmanaged<IXMLDOMNamedNodeMap, IUnknown*, int>)((*lpVtbl)[16]))(
            this,
            ppUnk
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT getNamedItem([NativeTypeName("BSTR")] ushort* name, IXMLDOMNode* namedItem);

        [VtblIndex(8)]
        HRESULT setNamedItem(IXMLDOMNode newItem, IXMLDOMNode* nameItem);

        [VtblIndex(9)]
        HRESULT removeNamedItem([NativeTypeName("BSTR")] ushort* name, IXMLDOMNode* namedItem);

        [VtblIndex(10)]
        HRESULT get_item([NativeTypeName("long")] int index, IXMLDOMNode* listItem);

        [VtblIndex(11)]
        HRESULT get_length([NativeTypeName("long *")] int* listLength);

        [VtblIndex(12)]
        HRESULT getQualifiedItem(
            [NativeTypeName("BSTR")] ushort* baseName,
            [NativeTypeName("BSTR")] ushort* namespaceURI,
            IXMLDOMNode* qualifiedItem
        );

        [VtblIndex(13)]
        HRESULT removeQualifiedItem(
            [NativeTypeName("BSTR")] ushort* baseName,
            [NativeTypeName("BSTR")] ushort* namespaceURI,
            IXMLDOMNode* qualifiedItem
        );

        [VtblIndex(14)]
        HRESULT nextNode(IXMLDOMNode* nextItem);

        [VtblIndex(15)]
        HRESULT reset();

        [VtblIndex(16)]
        HRESULT get__newEnum(IUnknown* ppUnk);
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

        [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMNode*, int> getNamedItem;

        [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode, IXMLDOMNode*, int> setNamedItem;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMNode*, int> removeNamedItem;

        [NativeTypeName("HRESULT (long, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IXMLDOMNode*, int> get_item;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;

        [NativeTypeName("HRESULT (BSTR, BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IXMLDOMNode*, int> getQualifiedItem;

        [NativeTypeName("HRESULT (BSTR, BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IXMLDOMNode*, int> removeQualifiedItem;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, int> nextNode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> reset;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get__newEnum;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXMLDOMNamedNodeMap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXMLDOMNamedNodeMap(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IXMLDOMNamedNodeMap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IXMLDOMNamedNodeMap(Silk.NET.Windows.IDispatch value)
    {
        return new IXMLDOMNamedNodeMap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXMLDOMNamedNodeMap"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IXMLDOMNamedNodeMap"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IXMLDOMNamedNodeMap value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXMLDOMNamedNodeMap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXMLDOMNamedNodeMap(Silk.NET.Windows.IUnknown value)
    {
        return new IXMLDOMNamedNodeMap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXMLDOMNamedNodeMap"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXMLDOMNamedNodeMap"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXMLDOMNamedNodeMap value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
