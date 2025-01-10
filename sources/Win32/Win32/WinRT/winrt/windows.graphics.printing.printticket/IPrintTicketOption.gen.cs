// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.printticket.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B086CF90-B367-4E4B-BD48-9C78A0BB31CE")]
[NativeTypeName("struct IPrintTicketOption : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTicketOption : IPrintTicketOption.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintTicketOption));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintTicketOption, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPrintTicketOption, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintTicketOption, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPrintTicketOption, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPrintTicketOption, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPrintTicketOption, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IPrintTicketOption, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_XmlNamespace(HSTRING* value)
    {
        return ((delegate* unmanaged<IPrintTicketOption, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_XmlNode(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* value
    )
    {
        return ((delegate* unmanaged<IPrintTicketOption, IXmlNode*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IPrintTicketOption, HSTRING*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPropertyNode(
        HSTRING name,
        HSTRING xmlNamespace,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* result
    )
    {
        return (
            (delegate* unmanaged<IPrintTicketOption, HSTRING, HSTRING, IXmlNode*, int>)(
                (*lpVtbl)[10]
            )
        )(this, name, xmlNamespace, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetScoredPropertyNode(
        HSTRING name,
        HSTRING xmlNamespace,
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* result
    )
    {
        return (
            (delegate* unmanaged<IPrintTicketOption, HSTRING, HSTRING, IXmlNode*, int>)(
                (*lpVtbl)[11]
            )
        )(this, name, xmlNamespace, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPropertyValue(
        HSTRING name,
        HSTRING xmlNamespace,
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **")]
            IPrintTicketValue* result
    )
    {
        return (
            (delegate* unmanaged<IPrintTicketOption, HSTRING, HSTRING, IPrintTicketValue*, int>)(
                (*lpVtbl)[12]
            )
        )(this, name, xmlNamespace, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetScoredPropertyValue(
        HSTRING name,
        HSTRING xmlNamespace,
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **")]
            IPrintTicketValue* result
    )
    {
        return (
            (delegate* unmanaged<IPrintTicketOption, HSTRING, HSTRING, IPrintTicketValue*, int>)(
                (*lpVtbl)[13]
            )
        )(this, name, xmlNamespace, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_XmlNamespace(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_XmlNode(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* value
        );

        [VtblIndex(9)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT GetPropertyNode(
            HSTRING name,
            HSTRING xmlNamespace,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* result
        );

        [VtblIndex(11)]
        HRESULT GetScoredPropertyNode(
            HSTRING name,
            HSTRING xmlNamespace,
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNode **")] IXmlNode* result
        );

        [VtblIndex(12)]
        HRESULT GetPropertyValue(
            HSTRING name,
            HSTRING xmlNamespace,
            [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **")]
                IPrintTicketValue* result
        );

        [VtblIndex(13)]
        HRESULT GetScoredPropertyValue(
            HSTRING name,
            HSTRING xmlNamespace,
            [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **")]
                IPrintTicketValue* result
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_XmlNamespace;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNode*, int> get_XmlNode;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, IXmlNode*, int> GetPropertyNode;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Data::Xml::Dom::IXmlNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, IXmlNode*, int> GetScoredPropertyNode;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IPrintTicketValue*,
            int> GetPropertyValue;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IPrintTicketValue*,
            int> GetScoredPropertyValue;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintTicketOption"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintTicketOption(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintTicketOption"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintTicketOption(Silk.NET.WinRT.IInspectable value)
    {
        return new IPrintTicketOption(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintTicketOption"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintTicketOption"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPrintTicketOption value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintTicketOption"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintTicketOption(Silk.NET.Windows.IUnknown value)
    {
        return new IPrintTicketOption(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintTicketOption"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintTicketOption"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrintTicketOption value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
