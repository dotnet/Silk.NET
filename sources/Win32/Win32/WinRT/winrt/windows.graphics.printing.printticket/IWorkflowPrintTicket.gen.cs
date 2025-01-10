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

[Guid("41D52285-35E8-448E-A8C5-E4B6A2CF826C")]
[NativeTypeName("struct IWorkflowPrintTicket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWorkflowPrintTicket : IWorkflowPrintTicket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWorkflowPrintTicket));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWorkflowPrintTicket, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWorkflowPrintTicket, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWorkflowPrintTicket, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWorkflowPrintTicket, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWorkflowPrintTicket, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWorkflowPrintTicket, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IWorkflowPrintTicket, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_XmlNamespace(HSTRING* value)
    {
        return ((delegate* unmanaged<IWorkflowPrintTicket, HSTRING*, int>)((*lpVtbl)[7]))(
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
        return ((delegate* unmanaged<IWorkflowPrintTicket, IXmlNode*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCapabilities(
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketCapabilities **"
        )]
            IPrintTicketCapabilities* result
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketCapabilities*, int>)(
                (*lpVtbl)[9]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DocumentBindingFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DocumentCollateFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DocumentDuplexFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DocumentHolePunchFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DocumentInputBinFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DocumentNUpFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DocumentStapleFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_JobPasscodeFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_PageBorderlessFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_PageMediaSizeFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_PageMediaTypeFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_PageOrientationFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[21])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_PageOutputColorFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[22])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_PageOutputQualityFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[23])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_PageResolutionFeature(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* value
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IPrintTicketFeature*, int>)((*lpVtbl)[24])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetFeature(
        HSTRING name,
        HSTRING xmlNamespace,
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **")]
            IPrintTicketFeature* result
    )
    {
        return (
            (delegate* unmanaged<
                IWorkflowPrintTicket,
                HSTRING,
                HSTRING,
                IPrintTicketFeature*,
                int>)((*lpVtbl)[25])
        )(this, name, xmlNamespace, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT NotifyXmlChangedAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IWorkflowPrintTicket, IAsyncAction*, int>)((*lpVtbl)[26]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT ValidateAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CPrinting__CPrintTicket__CWorkflowPrintTicketValidationResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IWorkflowPrintTicket, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[27]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetParameterInitializer(
        HSTRING name,
        HSTRING xmlNamespace,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketParameterInitializer **"
        )]
            IPrintTicketParameterInitializer* result
    )
    {
        return (
            (delegate* unmanaged<
                IWorkflowPrintTicket,
                HSTRING,
                HSTRING,
                IPrintTicketParameterInitializer*,
                int>)((*lpVtbl)[28])
        )(this, name, xmlNamespace, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT SetParameterInitializerAsInteger(
        HSTRING name,
        HSTRING xmlNamespace,
        [NativeTypeName("INT32")] int integerValue,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketParameterInitializer **"
        )]
            IPrintTicketParameterInitializer* result
    )
    {
        return (
            (delegate* unmanaged<
                IWorkflowPrintTicket,
                HSTRING,
                HSTRING,
                int,
                IPrintTicketParameterInitializer*,
                int>)((*lpVtbl)[29])
        )(this, name, xmlNamespace, integerValue, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetParameterInitializerAsString(
        HSTRING name,
        HSTRING xmlNamespace,
        HSTRING stringValue,
        [NativeTypeName(
            "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketParameterInitializer **"
        )]
            IPrintTicketParameterInitializer* result
    )
    {
        return (
            (delegate* unmanaged<
                IWorkflowPrintTicket,
                HSTRING,
                HSTRING,
                HSTRING,
                IPrintTicketParameterInitializer*,
                int>)((*lpVtbl)[30])
        )(this, name, xmlNamespace, stringValue, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT MergeAndValidateTicket(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *")]
            IWorkflowPrintTicket deltaShemaTicket,
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **")]
            IWorkflowPrintTicket* result
    )
    {
        return (
            (delegate* unmanaged<
                IWorkflowPrintTicket,
                IWorkflowPrintTicket,
                IWorkflowPrintTicket*,
                int>)((*lpVtbl)[31])
        )(this, deltaShemaTicket, result);
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
        HRESULT GetCapabilities(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketCapabilities **"
            )]
                IPrintTicketCapabilities* result
        );

        [VtblIndex(10)]
        HRESULT get_DocumentBindingFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(11)]
        HRESULT get_DocumentCollateFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(12)]
        HRESULT get_DocumentDuplexFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(13)]
        HRESULT get_DocumentHolePunchFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(14)]
        HRESULT get_DocumentInputBinFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(15)]
        HRESULT get_DocumentNUpFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(16)]
        HRESULT get_DocumentStapleFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(17)]
        HRESULT get_JobPasscodeFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(18)]
        HRESULT get_PageBorderlessFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(19)]
        HRESULT get_PageMediaSizeFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(20)]
        HRESULT get_PageMediaTypeFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(21)]
        HRESULT get_PageOrientationFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(22)]
        HRESULT get_PageOutputColorFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(23)]
        HRESULT get_PageOutputQualityFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(24)]
        HRESULT get_PageResolutionFeature(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* value
        );

        [VtblIndex(25)]
        HRESULT GetFeature(
            HSTRING name,
            HSTRING xmlNamespace,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **"
            )]
                IPrintTicketFeature* result
        );

        [VtblIndex(26)]
        HRESULT NotifyXmlChangedAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(27)]
        HRESULT ValidateAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CPrinting__CPrintTicket__CWorkflowPrintTicketValidationResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(28)]
        HRESULT GetParameterInitializer(
            HSTRING name,
            HSTRING xmlNamespace,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketParameterInitializer **"
            )]
                IPrintTicketParameterInitializer* result
        );

        [VtblIndex(29)]
        HRESULT SetParameterInitializerAsInteger(
            HSTRING name,
            HSTRING xmlNamespace,
            [NativeTypeName("INT32")] int integerValue,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketParameterInitializer **"
            )]
                IPrintTicketParameterInitializer* result
        );

        [VtblIndex(30)]
        HRESULT SetParameterInitializerAsString(
            HSTRING name,
            HSTRING xmlNamespace,
            HSTRING stringValue,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketParameterInitializer **"
            )]
                IPrintTicketParameterInitializer* result
        );

        [VtblIndex(31)]
        HRESULT MergeAndValidateTicket(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *"
            )]
                IWorkflowPrintTicket deltaShemaTicket,
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **"
            )]
                IWorkflowPrintTicket* result
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketCapabilities **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketCapabilities*, int> GetCapabilities;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_DocumentBindingFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_DocumentCollateFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_DocumentDuplexFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_DocumentHolePunchFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_DocumentInputBinFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_DocumentNUpFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_DocumentStapleFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_JobPasscodeFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_PageBorderlessFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_PageMediaSizeFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_PageMediaTypeFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_PageOrientationFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_PageOutputColorFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_PageOutputQualityFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTicketFeature*, int> get_PageResolutionFeature;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketFeature **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, IPrintTicketFeature*, int> GetFeature;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> NotifyXmlChangedAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CGraphics__CPrinting__CPrintTicket__CWorkflowPrintTicketValidationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> ValidateAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketParameterInitializer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IPrintTicketParameterInitializer*,
            int> GetParameterInitializer;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, INT32, ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketParameterInitializer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            int,
            IPrintTicketParameterInitializer*,
            int> SetParameterInitializerAsInteger;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Graphics::Printing::PrintTicket::IPrintTicketParameterInitializer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            HSTRING,
            IPrintTicketParameterInitializer*,
            int> SetParameterInitializerAsString;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket *, ABI::Windows::Graphics::Printing::PrintTicket::IWorkflowPrintTicket **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWorkflowPrintTicket,
            IWorkflowPrintTicket*,
            int> MergeAndValidateTicket;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWorkflowPrintTicket"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWorkflowPrintTicket(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWorkflowPrintTicket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWorkflowPrintTicket(Silk.NET.WinRT.IInspectable value)
    {
        return new IWorkflowPrintTicket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWorkflowPrintTicket"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWorkflowPrintTicket"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWorkflowPrintTicket value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWorkflowPrintTicket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWorkflowPrintTicket(Silk.NET.Windows.IUnknown value)
    {
        return new IWorkflowPrintTicket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWorkflowPrintTicket"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWorkflowPrintTicket"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWorkflowPrintTicket value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
