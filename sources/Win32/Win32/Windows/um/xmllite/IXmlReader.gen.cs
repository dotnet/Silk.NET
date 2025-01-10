// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7279FC81-709D-4095-B63D-69FE4B0D9030")]
[NativeTypeName("struct IXmlReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXmlReader : IXmlReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlReader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXmlReader, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXmlReader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXmlReader, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(IUnknown pInput)
    {
        return ((delegate* unmanaged<IXmlReader, IUnknown, int>)((*lpVtbl)[3]))(this, pInput);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProperty(uint nProperty, [NativeTypeName("LONG_PTR *")] nint* ppValue)
    {
        return ((delegate* unmanaged<IXmlReader, uint, nint*, int>)((*lpVtbl)[4]))(
            this,
            nProperty,
            ppValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetProperty(uint nProperty, [NativeTypeName("LONG_PTR")] nint pValue)
    {
        return ((delegate* unmanaged<IXmlReader, uint, nint, int>)((*lpVtbl)[5]))(
            this,
            nProperty,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Read(XmlNodeType* pNodeType)
    {
        return ((delegate* unmanaged<IXmlReader, XmlNodeType*, int>)((*lpVtbl)[6]))(
            this,
            pNodeType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetNodeType(XmlNodeType* pNodeType)
    {
        return ((delegate* unmanaged<IXmlReader, XmlNodeType*, int>)((*lpVtbl)[7]))(
            this,
            pNodeType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MoveToFirstAttribute()
    {
        return ((delegate* unmanaged<IXmlReader, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT MoveToNextAttribute()
    {
        return ((delegate* unmanaged<IXmlReader, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT MoveToAttributeByName(
        [NativeTypeName("LPCWSTR")] ushort* pwszLocalName,
        [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri
    )
    {
        return ((delegate* unmanaged<IXmlReader, ushort*, ushort*, int>)((*lpVtbl)[10]))(
            this,
            pwszLocalName,
            pwszNamespaceUri
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT MoveToElement()
    {
        return ((delegate* unmanaged<IXmlReader, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetQualifiedName(
        [NativeTypeName("LPCWSTR *")] ushort** ppwszQualifiedName,
        uint* pcwchQualifiedName
    )
    {
        return ((delegate* unmanaged<IXmlReader, ushort**, uint*, int>)((*lpVtbl)[12]))(
            this,
            ppwszQualifiedName,
            pcwchQualifiedName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetNamespaceUri(
        [NativeTypeName("LPCWSTR *")] ushort** ppwszNamespaceUri,
        uint* pcwchNamespaceUri
    )
    {
        return ((delegate* unmanaged<IXmlReader, ushort**, uint*, int>)((*lpVtbl)[13]))(
            this,
            ppwszNamespaceUri,
            pcwchNamespaceUri
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetLocalName(
        [NativeTypeName("LPCWSTR *")] ushort** ppwszLocalName,
        uint* pcwchLocalName
    )
    {
        return ((delegate* unmanaged<IXmlReader, ushort**, uint*, int>)((*lpVtbl)[14]))(
            this,
            ppwszLocalName,
            pcwchLocalName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetPrefix([NativeTypeName("LPCWSTR *")] ushort** ppwszPrefix, uint* pcwchPrefix)
    {
        return ((delegate* unmanaged<IXmlReader, ushort**, uint*, int>)((*lpVtbl)[15]))(
            this,
            ppwszPrefix,
            pcwchPrefix
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetValue([NativeTypeName("LPCWSTR *")] ushort** ppwszValue, uint* pcwchValue)
    {
        return ((delegate* unmanaged<IXmlReader, ushort**, uint*, int>)((*lpVtbl)[16]))(
            this,
            ppwszValue,
            pcwchValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ReadValueChunk(
        [NativeTypeName("WCHAR *")] ushort* pwchBuffer,
        uint cwchChunkSize,
        uint* pcwchRead
    )
    {
        return ((delegate* unmanaged<IXmlReader, ushort*, uint, uint*, int>)((*lpVtbl)[17]))(
            this,
            pwchBuffer,
            cwchChunkSize,
            pcwchRead
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetBaseUri(
        [NativeTypeName("LPCWSTR *")] ushort** ppwszBaseUri,
        uint* pcwchBaseUri
    )
    {
        return ((delegate* unmanaged<IXmlReader, ushort**, uint*, int>)((*lpVtbl)[18]))(
            this,
            ppwszBaseUri,
            pcwchBaseUri
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public BOOL IsDefault()
    {
        return ((delegate* unmanaged<IXmlReader, int>)((*lpVtbl)[19]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public BOOL IsEmptyElement()
    {
        return ((delegate* unmanaged<IXmlReader, int>)((*lpVtbl)[20]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetLineNumber(uint* pnLineNumber)
    {
        return ((delegate* unmanaged<IXmlReader, uint*, int>)((*lpVtbl)[21]))(this, pnLineNumber);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetLinePosition(uint* pnLinePosition)
    {
        return ((delegate* unmanaged<IXmlReader, uint*, int>)((*lpVtbl)[22]))(this, pnLinePosition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetAttributeCount(uint* pnAttributeCount)
    {
        return ((delegate* unmanaged<IXmlReader, uint*, int>)((*lpVtbl)[23]))(
            this,
            pnAttributeCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetDepth(uint* pnDepth)
    {
        return ((delegate* unmanaged<IXmlReader, uint*, int>)((*lpVtbl)[24]))(this, pnDepth);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public BOOL IsEOF()
    {
        return ((delegate* unmanaged<IXmlReader, int>)((*lpVtbl)[25]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetInput(IUnknown pInput);

        [VtblIndex(4)]
        HRESULT GetProperty(uint nProperty, [NativeTypeName("LONG_PTR *")] nint* ppValue);

        [VtblIndex(5)]
        HRESULT SetProperty(uint nProperty, [NativeTypeName("LONG_PTR")] nint pValue);

        [VtblIndex(6)]
        HRESULT Read(XmlNodeType* pNodeType);

        [VtblIndex(7)]
        HRESULT GetNodeType(XmlNodeType* pNodeType);

        [VtblIndex(8)]
        HRESULT MoveToFirstAttribute();

        [VtblIndex(9)]
        HRESULT MoveToNextAttribute();

        [VtblIndex(10)]
        HRESULT MoveToAttributeByName(
            [NativeTypeName("LPCWSTR")] ushort* pwszLocalName,
            [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri
        );

        [VtblIndex(11)]
        HRESULT MoveToElement();

        [VtblIndex(12)]
        HRESULT GetQualifiedName(
            [NativeTypeName("LPCWSTR *")] ushort** ppwszQualifiedName,
            uint* pcwchQualifiedName
        );

        [VtblIndex(13)]
        HRESULT GetNamespaceUri(
            [NativeTypeName("LPCWSTR *")] ushort** ppwszNamespaceUri,
            uint* pcwchNamespaceUri
        );

        [VtblIndex(14)]
        HRESULT GetLocalName(
            [NativeTypeName("LPCWSTR *")] ushort** ppwszLocalName,
            uint* pcwchLocalName
        );

        [VtblIndex(15)]
        HRESULT GetPrefix([NativeTypeName("LPCWSTR *")] ushort** ppwszPrefix, uint* pcwchPrefix);

        [VtblIndex(16)]
        HRESULT GetValue([NativeTypeName("LPCWSTR *")] ushort** ppwszValue, uint* pcwchValue);

        [VtblIndex(17)]
        HRESULT ReadValueChunk(
            [NativeTypeName("WCHAR *")] ushort* pwchBuffer,
            uint cwchChunkSize,
            uint* pcwchRead
        );

        [VtblIndex(18)]
        HRESULT GetBaseUri([NativeTypeName("LPCWSTR *")] ushort** ppwszBaseUri, uint* pcwchBaseUri);

        [VtblIndex(19)]
        BOOL IsDefault();

        [VtblIndex(20)]
        BOOL IsEmptyElement();

        [VtblIndex(21)]
        HRESULT GetLineNumber(uint* pnLineNumber);

        [VtblIndex(22)]
        HRESULT GetLinePosition(uint* pnLinePosition);

        [VtblIndex(23)]
        HRESULT GetAttributeCount(uint* pnAttributeCount);

        [VtblIndex(24)]
        HRESULT GetDepth(uint* pnDepth);

        [VtblIndex(25)]
        BOOL IsEOF();
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> SetInput;

        [NativeTypeName("HRESULT (UINT, LONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, nint*, int> GetProperty;

        [NativeTypeName("HRESULT (UINT, LONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, nint, int> SetProperty;

        [NativeTypeName("HRESULT (XmlNodeType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XmlNodeType*, int> Read;

        [NativeTypeName("HRESULT (XmlNodeType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XmlNodeType*, int> GetNodeType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> MoveToFirstAttribute;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> MoveToNextAttribute;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> MoveToAttributeByName;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> MoveToElement;

        [NativeTypeName("HRESULT (LPCWSTR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, int> GetQualifiedName;

        [NativeTypeName("HRESULT (LPCWSTR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, int> GetNamespaceUri;

        [NativeTypeName("HRESULT (LPCWSTR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, int> GetLocalName;

        [NativeTypeName("HRESULT (LPCWSTR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, int> GetPrefix;

        [NativeTypeName("HRESULT (LPCWSTR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, int> GetValue;

        [NativeTypeName("HRESULT (WCHAR *, UINT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint*, int> ReadValueChunk;

        [NativeTypeName("HRESULT (LPCWSTR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, int> GetBaseUri;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDefault;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsEmptyElement;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLineNumber;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLinePosition;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetAttributeCount;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDepth;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsEOF;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXmlReader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXmlReader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXmlReader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXmlReader(Silk.NET.Windows.IUnknown value)
    {
        return new IXmlReader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlReader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlReader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXmlReader value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
