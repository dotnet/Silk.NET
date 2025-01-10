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

[Guid("63DBBA8B-D0DB-4FE1-B745-F9433AFDC25B")]
[NativeTypeName("struct IXmlNodeSelector : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlNodeSelector : IXmlNodeSelector.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlNodeSelector));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXmlNodeSelector, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXmlNodeSelector, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXmlNodeSelector, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IXmlNodeSelector, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IXmlNodeSelector, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IXmlNodeSelector, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SelectSingleNode(
        HSTRING xpath,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* node
    )
    {
        return ((delegate* unmanaged<IXmlNodeSelector, HSTRING, IXmlNode*, int>)((*lpVtbl)[6]))(
            this,
            xpath,
            node
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SelectNodes(
        HSTRING xpath,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList* nodelist
    )
    {
        return ((delegate* unmanaged<IXmlNodeSelector, HSTRING, IXmlNodeList*, int>)((*lpVtbl)[7]))(
            this,
            xpath,
            nodelist
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SelectSingleNodeNS(
        HSTRING xpath,
        IInspectable namespaces,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* node
    )
    {
        return (
            (delegate* unmanaged<IXmlNodeSelector, HSTRING, IInspectable, IXmlNode*, int>)(
                (*lpVtbl)[8]
            )
        )(this, xpath, namespaces, node);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SelectNodesNS(
        HSTRING xpath,
        IInspectable namespaces,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList* nodelist
    )
    {
        return (
            (delegate* unmanaged<IXmlNodeSelector, HSTRING, IInspectable, IXmlNodeList*, int>)(
                (*lpVtbl)[9]
            )
        )(this, xpath, namespaces, nodelist);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SelectSingleNode(
            HSTRING xpath,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* node
        );

        [VtblIndex(7)]
        HRESULT SelectNodes(
            HSTRING xpath,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList* nodelist
        );

        [VtblIndex(8)]
        HRESULT SelectSingleNodeNS(
            HSTRING xpath,
            IInspectable namespaces,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* node
        );

        [VtblIndex(9)]
        HRESULT SelectNodesNS(
            HSTRING xpath,
            IInspectable namespaces,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNodeList **")] IXmlNodeList* nodelist
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
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlNode*, int> SelectSingleNode;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNodeList **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IXmlNodeList*, int> SelectNodes;

        [NativeTypeName(
            "HRESULT (HSTRING, IInspectable *, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IInspectable,
            IXmlNode*,
            int> SelectSingleNodeNS;

        [NativeTypeName(
            "HRESULT (HSTRING, IInspectable *, ABI::Windows::Data::Xml::Dom::IXmlNodeList **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IInspectable, IXmlNodeList*, int> SelectNodesNS;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXmlNodeSelector"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXmlNodeSelector(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IXmlNodeSelector"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IXmlNodeSelector(Silk.NET.WinRT.IInspectable value)
    {
        return new IXmlNodeSelector(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlNodeSelector"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlNodeSelector"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IXmlNodeSelector value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXmlNodeSelector"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXmlNodeSelector(Silk.NET.Windows.IUnknown value)
    {
        return new IXmlNodeSelector(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlNodeSelector"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlNodeSelector"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXmlNodeSelector value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
