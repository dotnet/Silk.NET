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

[Guid("F7F3A506-1E87-42D6-BCFB-B8C809FA5494")]
[NativeTypeName("struct IXmlDocument : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlDocument : IXmlDocument.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlDocument));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXmlDocument, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXmlDocument, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXmlDocument, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IXmlDocument, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IXmlDocument, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IXmlDocument, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Doctype(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocumentType **")]
            IXmlDocumentType* value
    )
    {
        return ((delegate* unmanaged<IXmlDocument, IXmlDocumentType*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Implementation(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDomImplementation **")]
            IXmlDomImplementation* value
    )
    {
        return ((delegate* unmanaged<IXmlDocument, IXmlDomImplementation*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DocumentElement(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement* value
    )
    {
        return ((delegate* unmanaged<IXmlDocument, IXmlElement*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateElement(
        HSTRING tagName,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement* newElement
    )
    {
        return ((delegate* unmanaged<IXmlDocument, HSTRING, IXmlElement*, int>)((*lpVtbl)[9]))(
            this,
            tagName,
            newElement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateDocumentFragment(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocumentFragment **")]
            IXmlDocumentFragment* newDocumentFragment
    )
    {
        return ((delegate* unmanaged<IXmlDocument, IXmlDocumentFragment*, int>)((*lpVtbl)[10]))(
            this,
            newDocumentFragment
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateTextNode(
        HSTRING data,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlText **")] IXmlText* newTextNode
    )
    {
        return ((delegate* unmanaged<IXmlDocument, HSTRING, IXmlText*, int>)((*lpVtbl)[11]))(
            this,
            data,
            newTextNode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateComment(
        HSTRING data,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlComment **")] IXmlComment* newComment
    )
    {
        return ((delegate* unmanaged<IXmlDocument, HSTRING, IXmlComment*, int>)((*lpVtbl)[12]))(
            this,
            data,
            newComment
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateProcessingInstruction(
        HSTRING target,
        HSTRING data,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlProcessingInstruction **")]
            IXmlProcessingInstruction* newProcessingInstruction
    )
    {
        return (
            (delegate* unmanaged<IXmlDocument, HSTRING, HSTRING, IXmlProcessingInstruction*, int>)(
                (*lpVtbl)[13]
            )
        )(this, target, data, newProcessingInstruction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateAttribute(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
            IXmlAttribute* newAttribute
    )
    {
        return ((delegate* unmanaged<IXmlDocument, HSTRING, IXmlAttribute*, int>)((*lpVtbl)[14]))(
            this,
            name,
            newAttribute
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateEntityReference(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlEntityReference **")]
            IXmlEntityReference* newEntityReference
    )
    {
        return (
            (delegate* unmanaged<IXmlDocument, HSTRING, IXmlEntityReference*, int>)((*lpVtbl)[15])
        )(this, name, newEntityReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetElementsByTagName(
        HSTRING tagName,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList* elements
    )
    {
        return ((delegate* unmanaged<IXmlDocument, HSTRING, IXmlNodeList*, int>)((*lpVtbl)[16]))(
            this,
            tagName,
            elements
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateCDataSection(
        HSTRING data,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlCDataSection **")]
            IXmlCDataSection* newCDataSection
    )
    {
        return (
            (delegate* unmanaged<IXmlDocument, HSTRING, IXmlCDataSection*, int>)((*lpVtbl)[17])
        )(this, data, newCDataSection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_DocumentUri(HSTRING* value)
    {
        return ((delegate* unmanaged<IXmlDocument, HSTRING*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateAttributeNS(
        IInspectable namespaceUri,
        HSTRING qualifiedName,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
            IXmlAttribute* newAttribute
    )
    {
        return (
            (delegate* unmanaged<IXmlDocument, IInspectable, HSTRING, IXmlAttribute*, int>)(
                (*lpVtbl)[19]
            )
        )(this, namespaceUri, qualifiedName, newAttribute);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateElementNS(
        IInspectable namespaceUri,
        HSTRING qualifiedName,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement* newElement
    )
    {
        return (
            (delegate* unmanaged<IXmlDocument, IInspectable, HSTRING, IXmlElement*, int>)(
                (*lpVtbl)[20]
            )
        )(this, namespaceUri, qualifiedName, newElement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetElementById(
        HSTRING elementId,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement* element
    )
    {
        return ((delegate* unmanaged<IXmlDocument, HSTRING, IXmlElement*, int>)((*lpVtbl)[21]))(
            this,
            elementId,
            element
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ImportNode(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode node,
        [NativeTypeName("boolean")] byte deep,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* newNode
    )
    {
        return ((delegate* unmanaged<IXmlDocument, IXmlNode, byte, IXmlNode*, int>)((*lpVtbl)[22]))(
            this,
            node,
            deep,
            newNode
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Doctype(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocumentType **")]
                IXmlDocumentType* value
        );

        [VtblIndex(7)]
        HRESULT get_Implementation(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDomImplementation **")]
                IXmlDomImplementation* value
        );

        [VtblIndex(8)]
        HRESULT get_DocumentElement(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement* value
        );

        [VtblIndex(9)]
        HRESULT CreateElement(
            HSTRING tagName,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement* newElement
        );

        [VtblIndex(10)]
        HRESULT CreateDocumentFragment(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocumentFragment **")]
                IXmlDocumentFragment* newDocumentFragment
        );

        [VtblIndex(11)]
        HRESULT CreateTextNode(
            HSTRING data,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlText **")] IXmlText* newTextNode
        );

        [VtblIndex(12)]
        HRESULT CreateComment(
            HSTRING data,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlComment **")] IXmlComment* newComment
        );

        [VtblIndex(13)]
        HRESULT CreateProcessingInstruction(
            HSTRING target,
            HSTRING data,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlProcessingInstruction **")]
                IXmlProcessingInstruction* newProcessingInstruction
        );

        [VtblIndex(14)]
        HRESULT CreateAttribute(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
                IXmlAttribute* newAttribute
        );

        [VtblIndex(15)]
        HRESULT CreateEntityReference(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlEntityReference **")]
                IXmlEntityReference* newEntityReference
        );

        [VtblIndex(16)]
        HRESULT GetElementsByTagName(
            HSTRING tagName,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList* elements
        );

        [VtblIndex(17)]
        HRESULT CreateCDataSection(
            HSTRING data,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlCDataSection **")]
                IXmlCDataSection* newCDataSection
        );

        [VtblIndex(18)]
        HRESULT get_DocumentUri(HSTRING* value);

        [VtblIndex(19)]
        HRESULT CreateAttributeNS(
            IInspectable namespaceUri,
            HSTRING qualifiedName,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlAttribute **")]
                IXmlAttribute* newAttribute
        );

        [VtblIndex(20)]
        HRESULT CreateElementNS(
            IInspectable namespaceUri,
            HSTRING qualifiedName,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement* newElement
        );

        [VtblIndex(21)]
        HRESULT GetElementById(
            HSTRING elementId,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlElement **")] IXmlElement* element
        );

        [VtblIndex(22)]
        HRESULT ImportNode(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode node,
            [NativeTypeName("boolean")] byte deep,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* newNode
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDocumentType **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlDocumentType*, int> get_Doctype;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDomImplementation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlDomImplementation*, int> get_Implementation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlElement **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlElement*, int> get_DocumentElement;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlElement **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlElement*, int> CreateElement;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDocumentFragment **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlDocumentFragment*, int> CreateDocumentFragment;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlText **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlText*, int> CreateTextNode;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlComment **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlComment*, int> CreateComment;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlProcessingInstruction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IXmlProcessingInstruction*,
            int> CreateProcessingInstruction;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlAttribute*, int> CreateAttribute;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlEntityReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IXmlEntityReference*,
            int> CreateEntityReference;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNodeList **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlNodeList*, int> GetElementsByTagName;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlCDataSection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlCDataSection*, int> CreateCDataSection;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DocumentUri;

        [NativeTypeName(
            "HRESULT (IInspectable *, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlAttribute **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInspectable,
            HSTRING,
            IXmlAttribute*,
            int> CreateAttributeNS;

        [NativeTypeName(
            "HRESULT (IInspectable *, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlElement **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInspectable,
            HSTRING,
            IXmlElement*,
            int> CreateElementNS;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlElement **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlElement*, int> GetElementById;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode *, boolean, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode, byte, IXmlNode*, int> ImportNode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXmlDocument"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXmlDocument(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IXmlDocument"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IXmlDocument(Silk.NET.WinRT.IInspectable value)
    {
        return new IXmlDocument(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlDocument"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlDocument"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IXmlDocument value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXmlDocument"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXmlDocument(Silk.NET.Windows.IUnknown value)
    {
        return new IXmlDocument(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlDocument"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlDocument"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXmlDocument value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
