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

[Guid("F7342425-9781-4964-8E94-9B1C6DFC9BC7")]
[NativeTypeName("struct IXmlDocumentType : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlDocumentType : IXmlDocumentType.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlDocumentType));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXmlDocumentType, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXmlDocumentType, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXmlDocumentType, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IXmlDocumentType, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IXmlDocumentType, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IXmlDocumentType, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IXmlDocumentType, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Entities(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNamedNodeMap **")]
            IXmlNamedNodeMap* value
    )
    {
        return ((delegate* unmanaged<IXmlDocumentType, IXmlNamedNodeMap*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Notations(
        [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNamedNodeMap **")]
            IXmlNamedNodeMap* value
    )
    {
        return ((delegate* unmanaged<IXmlDocumentType, IXmlNamedNodeMap*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Entities(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNamedNodeMap **")]
                IXmlNamedNodeMap* value
        );

        [VtblIndex(8)]
        HRESULT get_Notations(
            [NativeTypeName("ABI::Windows::Data::Xml::Dom::IXmlNamedNodeMap **")]
                IXmlNamedNodeMap* value
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNamedNodeMap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNamedNodeMap*, int> get_Entities;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Xml::Dom::IXmlNamedNodeMap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IXmlNamedNodeMap*, int> get_Notations;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXmlDocumentType"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXmlDocumentType(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IXmlDocumentType"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IXmlDocumentType(Silk.NET.WinRT.IInspectable value)
    {
        return new IXmlDocumentType(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlDocumentType"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlDocumentType"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IXmlDocumentType value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXmlDocumentType"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXmlDocumentType(Silk.NET.Windows.IUnknown value)
    {
        return new IXmlDocumentType(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlDocumentType"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlDocumentType"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXmlDocumentType value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
