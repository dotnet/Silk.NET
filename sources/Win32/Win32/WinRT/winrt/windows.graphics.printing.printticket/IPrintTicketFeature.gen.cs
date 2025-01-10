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

[Guid("E7607D6A-59F5-4103-8858-B97710963D39")]
[NativeTypeName("struct IPrintTicketFeature : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTicketFeature : IPrintTicketFeature.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintTicketFeature));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintTicketFeature, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPrintTicketFeature, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintTicketFeature, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPrintTicketFeature, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPrintTicketFeature, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPrintTicketFeature, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IPrintTicketFeature, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_XmlNamespace(HSTRING* value)
    {
        return ((delegate* unmanaged<IPrintTicketFeature, HSTRING*, int>)((*lpVtbl)[7]))(
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
        return ((delegate* unmanaged<IPrintTicketFeature, IXmlNode*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IPrintTicketFeature, HSTRING*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetOption(
        HSTRING name,
        HSTRING xmlNamespace,
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption **")]
            IPrintTicketOption* result
    )
    {
        return (
            (delegate* unmanaged<IPrintTicketFeature, HSTRING, HSTRING, IPrintTicketOption*, int>)(
                (*lpVtbl)[10]
            )
        )(this, name, xmlNamespace, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Options(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CPrinting__CPrintTicket__CPrintTicketOption_t **"
        )]
            IVectorView<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IPrintTicketFeature, IVectorView<IntPtr>**, int>)((*lpVtbl)[11])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetSelectedOption(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption **")]
            IPrintTicketOption* value
    )
    {
        return (
            (delegate* unmanaged<IPrintTicketFeature, IPrintTicketOption*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetSelectedOption(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption *")]
            IPrintTicketOption value
    )
    {
        return ((delegate* unmanaged<IPrintTicketFeature, IPrintTicketOption, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SelectionType(
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::PrintTicket::PrintTicketFeatureSelectionType *"
        )]
            PrintTicketFeatureSelectionType* value
    )
    {
        return (
            (delegate* unmanaged<IPrintTicketFeature, PrintTicketFeatureSelectionType*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
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
        HRESULT GetOption(
            HSTRING name,
            HSTRING xmlNamespace,
            [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption **")]
                IPrintTicketOption* result
        );

        [VtblIndex(11)]
        HRESULT get_Options(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CPrinting__CPrintTicket__CPrintTicketOption_t **"
            )]
                IVectorView<IntPtr>** result
        );

        [VtblIndex(12)]
        HRESULT GetSelectedOption(
            [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption **")]
                IPrintTicketOption* value
        );

        [VtblIndex(13)]
        HRESULT SetSelectedOption(
            [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption *")]
                IPrintTicketOption value
        );

        [VtblIndex(14)]
        HRESULT get_SelectionType(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::PrintTicketFeatureSelectionType *"
            )]
                PrintTicketFeatureSelectionType* value
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
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, IPrintTicketOption*, int> GetOption;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CPrinting__CPrintTicket__CPrintTicketOption_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_Options;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketOption*, int> GetSelectedOption;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketOption *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketOption, int> SetSelectedOption;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::PrintTicketFeatureSelectionType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PrintTicketFeatureSelectionType*, int> get_SelectionType;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintTicketFeature"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintTicketFeature(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintTicketFeature"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintTicketFeature(Silk.NET.WinRT.IInspectable value)
    {
        return new IPrintTicketFeature(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintTicketFeature"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintTicketFeature"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPrintTicketFeature value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintTicketFeature"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintTicketFeature(Silk.NET.Windows.IUnknown value)
    {
        return new IPrintTicketFeature(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintTicketFeature"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintTicketFeature"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrintTicketFeature value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
