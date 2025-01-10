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

[Guid("1C741D59-2122-47D5-A856-83F3D4214875")]
[NativeTypeName("struct IXmlNode : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlNode : IXmlNode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlNode));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXmlNode, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXmlNode, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXmlNode, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IXmlNode, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IXmlNode, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IXmlNode, TrustLevel*, int>)((*lpVtbl)[5]))(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NodeValue(IInspectable* value)
    {
        return ((delegate* unmanaged<IXmlNode, IInspectable*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_NodeValue(IInspectable value)
    {
        return ((delegate* unmanaged<IXmlNode, IInspectable, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_NodeType(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::NodeType *")] NodeType* value
    )
    {
        return ((delegate* unmanaged<IXmlNode, NodeType*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_NodeName(HSTRING* value)
    {
        return ((delegate* unmanaged<IXmlNode, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ParentNode(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* value
    )
    {
        return ((delegate* unmanaged<IXmlNode, IXmlNode*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ChildNodes(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList* value
    )
    {
        return ((delegate* unmanaged<IXmlNode, IXmlNodeList*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FirstChild(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* value
    )
    {
        return ((delegate* unmanaged<IXmlNode, IXmlNode*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_LastChild(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* value
    )
    {
        return ((delegate* unmanaged<IXmlNode, IXmlNode*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_PreviousSibling(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* value
    )
    {
        return ((delegate* unmanaged<IXmlNode, IXmlNode*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_NextSibling(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* value
    )
    {
        return ((delegate* unmanaged<IXmlNode, IXmlNode*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Attributes(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNamedNodeMap **")]
            IXmlNamedNodeMap* value
    )
    {
        return ((delegate* unmanaged<IXmlNode, IXmlNamedNodeMap*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT HasChildNodes([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IXmlNode, byte*, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_OwnerDocument(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument* value
    )
    {
        return ((delegate* unmanaged<IXmlNode, IXmlDocument*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT InsertBefore(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode newChild,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode referenceChild,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* insertedChild
    )
    {
        return ((delegate* unmanaged<IXmlNode, IXmlNode, IXmlNode, IXmlNode*, int>)((*lpVtbl)[19]))(
            this,
            newChild,
            referenceChild,
            insertedChild
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT ReplaceChild(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode newChild,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode referenceChild,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* previousChild
    )
    {
        return ((delegate* unmanaged<IXmlNode, IXmlNode, IXmlNode, IXmlNode*, int>)((*lpVtbl)[20]))(
            this,
            newChild,
            referenceChild,
            previousChild
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RemoveChild(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode childNode,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* removedChild
    )
    {
        return ((delegate* unmanaged<IXmlNode, IXmlNode, IXmlNode*, int>)((*lpVtbl)[21]))(
            this,
            childNode,
            removedChild
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT AppendChild(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode newChild,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* appendedChild
    )
    {
        return ((delegate* unmanaged<IXmlNode, IXmlNode, IXmlNode*, int>)((*lpVtbl)[22]))(
            this,
            newChild,
            appendedChild
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CloneNode(
        [NativeTypeName("boolean")] byte deep,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* newNode
    )
    {
        return ((delegate* unmanaged<IXmlNode, byte, IXmlNode*, int>)((*lpVtbl)[23]))(
            this,
            deep,
            newNode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_NamespaceUri(IInspectable* value)
    {
        return ((delegate* unmanaged<IXmlNode, IInspectable*, int>)((*lpVtbl)[24]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_LocalName(IInspectable* value)
    {
        return ((delegate* unmanaged<IXmlNode, IInspectable*, int>)((*lpVtbl)[25]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Prefix(IInspectable* value)
    {
        return ((delegate* unmanaged<IXmlNode, IInspectable*, int>)((*lpVtbl)[26]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT Normalize()
    {
        return ((delegate* unmanaged<IXmlNode, int>)((*lpVtbl)[27]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_Prefix(IInspectable value)
    {
        return ((delegate* unmanaged<IXmlNode, IInspectable, int>)((*lpVtbl)[28]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NodeValue(IInspectable* value);

        [VtblIndex(7)]
        HRESULT put_NodeValue(IInspectable value);

        [VtblIndex(8)]
        HRESULT get_NodeType(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::NodeType *")] NodeType* value
        );

        [VtblIndex(9)]
        HRESULT get_NodeName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_ParentNode(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* value
        );

        [VtblIndex(11)]
        HRESULT get_ChildNodes(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList* value
        );

        [VtblIndex(12)]
        HRESULT get_FirstChild(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* value
        );

        [VtblIndex(13)]
        HRESULT get_LastChild(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* value
        );

        [VtblIndex(14)]
        HRESULT get_PreviousSibling(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* value
        );

        [VtblIndex(15)]
        HRESULT get_NextSibling(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* value
        );

        [VtblIndex(16)]
        HRESULT get_Attributes(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNamedNodeMap **")]
                IXmlNamedNodeMap* value
        );

        [VtblIndex(17)]
        HRESULT HasChildNodes([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(18)]
        HRESULT get_OwnerDocument(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlDocument **")] IXmlDocument* value
        );

        [VtblIndex(19)]
        HRESULT InsertBefore(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode newChild,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode referenceChild,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* insertedChild
        );

        [VtblIndex(20)]
        HRESULT ReplaceChild(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode newChild,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode referenceChild,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* previousChild
        );

        [VtblIndex(21)]
        HRESULT RemoveChild(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode childNode,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* removedChild
        );

        [VtblIndex(22)]
        HRESULT AppendChild(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode *")] IXmlNode newChild,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* appendedChild
        );

        [VtblIndex(23)]
        HRESULT CloneNode(
            [NativeTypeName("boolean")] byte deep,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* newNode
        );

        [VtblIndex(24)]
        HRESULT get_NamespaceUri(IInspectable* value);

        [VtblIndex(25)]
        HRESULT get_LocalName(IInspectable* value);

        [VtblIndex(26)]
        HRESULT get_Prefix(IInspectable* value);

        [VtblIndex(27)]
        HRESULT Normalize();

        [VtblIndex(28)]
        HRESULT put_Prefix(IInspectable value);
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

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable*, int> get_NodeValue;

        [NativeTypeName("HRESULT (IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable, int> put_NodeValue;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::NodeType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, NodeType*, int> get_NodeType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_NodeName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode*, int> get_ParentNode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNodeList **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNodeList*, int> get_ChildNodes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode*, int> get_FirstChild;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode*, int> get_LastChild;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode*, int> get_PreviousSibling;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode*, int> get_NextSibling;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNamedNodeMap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNamedNodeMap*, int> get_Attributes;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> HasChildNodes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlDocument **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlDocument*, int> get_OwnerDocument;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode *, ABI::Windows::Data::Xml::Dom::IXmlNode *, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode, IXmlNode, IXmlNode*, int> InsertBefore;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode *, ABI::Windows::Data::Xml::Dom::IXmlNode *, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode, IXmlNode, IXmlNode*, int> ReplaceChild;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode *, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode, IXmlNode*, int> RemoveChild;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode *, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode, IXmlNode*, int> AppendChild;

        [NativeTypeName(
            "HRESULT (boolean, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte, IXmlNode*, int> CloneNode;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable*, int> get_NamespaceUri;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable*, int> get_LocalName;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable*, int> get_Prefix;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Normalize;

        [NativeTypeName("HRESULT (IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable, int> put_Prefix;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXmlNode"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXmlNode(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IXmlNode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IXmlNode(Silk.NET.WinRT.IInspectable value)
    {
        return new IXmlNode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlNode"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlNode"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IXmlNode value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXmlNode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXmlNode(Silk.NET.Windows.IUnknown value)
    {
        return new IXmlNode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlNode"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlNode"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXmlNode value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
