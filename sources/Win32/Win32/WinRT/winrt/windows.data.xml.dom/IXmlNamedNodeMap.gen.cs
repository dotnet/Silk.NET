// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B3A69EB0-AAB0-4B82-A6FA-B1453F7C021B")]
[NativeTypeName("struct IXmlNamedNodeMap : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlNamedNodeMap : IXmlNamedNodeMap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlNamedNodeMap));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXmlNamedNodeMap, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXmlNamedNodeMap, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXmlNamedNodeMap, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IXmlNamedNodeMap, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IXmlNamedNodeMap, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IXmlNamedNodeMap, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Length([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IXmlNamedNodeMap, uint*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Item(
        [NativeTypeName("UINT32")] uint index,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* node
    )
    {
        return ((delegate* unmanaged<IXmlNamedNodeMap, uint, IXmlNode*, int>)((*lpVtbl)[7]))(
            this,
            index,
            node
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetNamedItem(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* node
    )
    {
        return ((delegate* unmanaged<IXmlNamedNodeMap, HSTRING, IXmlNode*, int>)((*lpVtbl)[8]))(
            this,
            name,
            node
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetNamedItem(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode node,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* previousNode
    )
    {
        return ((delegate* unmanaged<IXmlNamedNodeMap, IXmlNode, IXmlNode*, int>)((*lpVtbl)[9]))(
            this,
            node,
            previousNode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RemoveNamedItem(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* previousNode
    )
    {
        return ((delegate* unmanaged<IXmlNamedNodeMap, HSTRING, IXmlNode*, int>)((*lpVtbl)[10]))(
            this,
            name,
            previousNode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetNamedItemNS(
        IInspectable namespaceUri,
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* node
    )
    {
        return (
            (delegate* unmanaged<IXmlNamedNodeMap, IInspectable, HSTRING, IXmlNode*, int>)(
                (*lpVtbl)[11]
            )
        )(this, namespaceUri, name, node);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemoveNamedItemNS(
        IInspectable namespaceUri,
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* previousNode
    )
    {
        return (
            (delegate* unmanaged<IXmlNamedNodeMap, IInspectable, HSTRING, IXmlNode*, int>)(
                (*lpVtbl)[12]
            )
        )(this, namespaceUri, name, previousNode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetNamedItemNS(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode node,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* previousNode
    )
    {
        return ((delegate* unmanaged<IXmlNamedNodeMap, IXmlNode, IXmlNode*, int>)((*lpVtbl)[13]))(
            this,
            node,
            previousNode
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Length([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT Item(
            [NativeTypeName("UINT32")] uint index,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* node
        );

        [VtblIndex(8)]
        HRESULT GetNamedItem(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* node
        );

        [VtblIndex(9)]
        HRESULT SetNamedItem(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode node,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* previousNode
        );

        [VtblIndex(10)]
        HRESULT RemoveNamedItem(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* previousNode
        );

        [VtblIndex(11)]
        HRESULT GetNamedItemNS(
            IInspectable namespaceUri,
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* node
        );

        [VtblIndex(12)]
        HRESULT RemoveNamedItemNS(
            IInspectable namespaceUri,
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* previousNode
        );

        [VtblIndex(13)]
        HRESULT SetNamedItemNS(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode node,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* previousNode
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Length;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IXmlNode*, int> Item;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlNode*, int> GetNamedItem;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode *, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode, IXmlNode*, int> SetNamedItem;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlNode*, int> RemoveNamedItem;

        [NativeTypeName(
            "HRESULT (IInspectable *, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IInspectable, HSTRING, IXmlNode*, int> GetNamedItemNS;

        [NativeTypeName(
            "HRESULT (IInspectable *, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IInspectable, HSTRING, IXmlNode*, int> RemoveNamedItemNS;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode *, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode, IXmlNode*, int> SetNamedItemNS;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXmlNamedNodeMap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXmlNamedNodeMap(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IXmlNamedNodeMap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IXmlNamedNodeMap(Silk.NET.WinRT.IInspectable value)
    {
        return new IXmlNamedNodeMap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlNamedNodeMap"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlNamedNodeMap"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IXmlNamedNodeMap value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXmlNamedNodeMap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXmlNamedNodeMap(Silk.NET.Windows.IUnknown value)
    {
        return new IXmlNamedNodeMap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlNamedNodeMap"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlNamedNodeMap"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXmlNamedNodeMap value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
