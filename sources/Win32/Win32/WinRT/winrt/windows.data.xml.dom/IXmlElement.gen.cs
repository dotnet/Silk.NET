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

[Guid("2DFB8A1F-6B10-4EF8-9F83-EFCCE8FAEC37")]
[NativeTypeName("struct IXmlElement : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlElement : IXmlElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlElement));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXmlElement, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXmlElement, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXmlElement, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IXmlElement, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IXmlElement, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IXmlElement, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TagName(HSTRING* value)
    {
        return ((delegate* unmanaged<IXmlElement, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAttribute(HSTRING attributeName, HSTRING* attributeValue)
    {
        return ((delegate* unmanaged<IXmlElement, HSTRING, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            attributeName,
            attributeValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetAttribute(HSTRING attributeName, HSTRING attributeValue)
    {
        return ((delegate* unmanaged<IXmlElement, HSTRING, HSTRING, int>)((*lpVtbl)[8]))(
            this,
            attributeName,
            attributeValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveAttribute(HSTRING attributeName)
    {
        return ((delegate* unmanaged<IXmlElement, HSTRING, int>)((*lpVtbl)[9]))(
            this,
            attributeName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetAttributeNode(
        HSTRING attributeName,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
            IXmlAttribute* attributeNode
    )
    {
        return ((delegate* unmanaged<IXmlElement, HSTRING, IXmlAttribute*, int>)((*lpVtbl)[10]))(
            this,
            attributeName,
            attributeNode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetAttributeNode(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute *")]
            IXmlAttribute newAttribute,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
            IXmlAttribute* previousAttribute
    )
    {
        return (
            (delegate* unmanaged<IXmlElement, IXmlAttribute, IXmlAttribute*, int>)((*lpVtbl)[11])
        )(this, newAttribute, previousAttribute);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemoveAttributeNode(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute *")]
            IXmlAttribute attributeNode,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
            IXmlAttribute* removedAttribute
    )
    {
        return (
            (delegate* unmanaged<IXmlElement, IXmlAttribute, IXmlAttribute*, int>)((*lpVtbl)[12])
        )(this, attributeNode, removedAttribute);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetElementsByTagName(
        HSTRING tagName,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList* elements
    )
    {
        return ((delegate* unmanaged<IXmlElement, HSTRING, IXmlNodeList*, int>)((*lpVtbl)[13]))(
            this,
            tagName,
            elements
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetAttributeNS(IInspectable namespaceUri, HSTRING qualifiedName, HSTRING value)
    {
        return (
            (delegate* unmanaged<IXmlElement, IInspectable, HSTRING, HSTRING, int>)((*lpVtbl)[14])
        )(this, namespaceUri, qualifiedName, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetAttributeNS(IInspectable namespaceUri, HSTRING localName, HSTRING* value)
    {
        return (
            (delegate* unmanaged<IXmlElement, IInspectable, HSTRING, HSTRING*, int>)((*lpVtbl)[15])
        )(this, namespaceUri, localName, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RemoveAttributeNS(IInspectable namespaceUri, HSTRING localName)
    {
        return ((delegate* unmanaged<IXmlElement, IInspectable, HSTRING, int>)((*lpVtbl)[16]))(
            this,
            namespaceUri,
            localName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetAttributeNodeNS(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute *")]
            IXmlAttribute newAttribute,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
            IXmlAttribute* previousAttribute
    )
    {
        return (
            (delegate* unmanaged<IXmlElement, IXmlAttribute, IXmlAttribute*, int>)((*lpVtbl)[17])
        )(this, newAttribute, previousAttribute);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetAttributeNodeNS(
        IInspectable namespaceUri,
        HSTRING localName,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
            IXmlAttribute* previousAttribute
    )
    {
        return (
            (delegate* unmanaged<IXmlElement, IInspectable, HSTRING, IXmlAttribute*, int>)(
                (*lpVtbl)[18]
            )
        )(this, namespaceUri, localName, previousAttribute);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TagName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetAttribute(HSTRING attributeName, HSTRING* attributeValue);

        [VtblIndex(8)]
        HRESULT SetAttribute(HSTRING attributeName, HSTRING attributeValue);

        [VtblIndex(9)]
        HRESULT RemoveAttribute(HSTRING attributeName);

        [VtblIndex(10)]
        HRESULT GetAttributeNode(
            HSTRING attributeName,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
                IXmlAttribute* attributeNode
        );

        [VtblIndex(11)]
        HRESULT SetAttributeNode(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute *")]
                IXmlAttribute newAttribute,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
                IXmlAttribute* previousAttribute
        );

        [VtblIndex(12)]
        HRESULT RemoveAttributeNode(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute *")]
                IXmlAttribute attributeNode,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
                IXmlAttribute* removedAttribute
        );

        [VtblIndex(13)]
        HRESULT GetElementsByTagName(
            HSTRING tagName,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList* elements
        );

        [VtblIndex(14)]
        HRESULT SetAttributeNS(IInspectable namespaceUri, HSTRING qualifiedName, HSTRING value);

        [VtblIndex(15)]
        HRESULT GetAttributeNS(IInspectable namespaceUri, HSTRING localName, HSTRING* value);

        [VtblIndex(16)]
        HRESULT RemoveAttributeNS(IInspectable namespaceUri, HSTRING localName);

        [VtblIndex(17)]
        HRESULT SetAttributeNodeNS(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute *")]
                IXmlAttribute newAttribute,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
                IXmlAttribute* previousAttribute
        );

        [VtblIndex(18)]
        HRESULT GetAttributeNodeNS(
            IInspectable namespaceUri,
            HSTRING localName,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
                IXmlAttribute* previousAttribute
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_TagName;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING*, int> GetAttribute;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, int> SetAttribute;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> RemoveAttribute;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlAttribute*, int> GetAttributeNode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlAttribute *, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlAttribute, IXmlAttribute*, int> SetAttributeNode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlAttribute *, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlAttribute, IXmlAttribute*, int> RemoveAttributeNode;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNodeList **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlNodeList*, int> GetElementsByTagName;

        [NativeTypeName("HRESULT (IInspectable *, HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable, HSTRING, HSTRING, int> SetAttributeNS;

        [NativeTypeName("HRESULT (IInspectable *, HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable, HSTRING, HSTRING*, int> GetAttributeNS;

        [NativeTypeName("HRESULT (IInspectable *, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable, HSTRING, int> RemoveAttributeNS;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlAttribute *, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlAttribute, IXmlAttribute*, int> SetAttributeNodeNS;

        [NativeTypeName(
            "HRESULT (IInspectable *, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInspectable,
            HSTRING,
            IXmlAttribute*,
            int> GetAttributeNodeNS;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXmlElement"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXmlElement(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IXmlElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IXmlElement(Silk.NET.WinRT.IInspectable value)
    {
        return new IXmlElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlElement"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IXmlElement value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXmlElement"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXmlElement(Silk.NET.Windows.IUnknown value)
    {
        return new IXmlElement(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlElement"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlElement"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXmlElement value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
