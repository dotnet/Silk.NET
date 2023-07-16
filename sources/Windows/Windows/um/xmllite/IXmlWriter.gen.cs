// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter"]/*'/>
[Guid("7279FC88-709D-4095-B63D-69FE4B0D9030")]
[NativeTypeName("struct IXmlWriter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXmlWriter : IXmlWriter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlWriter));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXmlWriter*, Guid*, void**, int> )(lpVtbl[0]))((IXmlWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXmlWriter*, uint> )(lpVtbl[1]))((IXmlWriter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXmlWriter*, uint> )(lpVtbl[2]))((IXmlWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.SetOutput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetOutput(IUnknown* pOutput)
    {
        return ((delegate* unmanaged<IXmlWriter*, IUnknown*, int> )(lpVtbl[3]))((IXmlWriter*)Unsafe.AsPointer(ref this), pOutput);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.GetProperty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProperty(uint nProperty, [NativeTypeName("LONG_PTR *")] nint* ppValue)
    {
        return ((delegate* unmanaged<IXmlWriter*, uint, nint*, int> )(lpVtbl[4]))((IXmlWriter*)Unsafe.AsPointer(ref this), nProperty, ppValue);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.SetProperty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetProperty(uint nProperty, [NativeTypeName("LONG_PTR")] nint pValue)
    {
        return ((delegate* unmanaged<IXmlWriter*, uint, nint, int> )(lpVtbl[5]))((IXmlWriter*)Unsafe.AsPointer(ref this), nProperty, pValue);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteAttributes(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
    {
        return ((delegate* unmanaged<IXmlWriter*, IXmlReader*, BOOL, int> )(lpVtbl[6]))((IXmlWriter*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteAttributeString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT WriteAttributeString([NativeTypeName("LPCWSTR")] ushort* pwszPrefix, [NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri, [NativeTypeName("LPCWSTR")] ushort* pwszValue)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, ushort*, ushort*, ushort*, int> )(lpVtbl[7]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszPrefix, pwszLocalName, pwszNamespaceUri, pwszValue);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteCData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WriteCData([NativeTypeName("LPCWSTR")] ushort* pwszText)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, int> )(lpVtbl[8]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszText);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteCharEntity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WriteCharEntity([NativeTypeName("WCHAR")] ushort wch)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort, int> )(lpVtbl[9]))((IXmlWriter*)Unsafe.AsPointer(ref this), wch);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteChars"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT WriteChars([NativeTypeName("const WCHAR *")] ushort* pwch, uint cwch)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, uint, int> )(lpVtbl[10]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwch, cwch);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteComment"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT WriteComment([NativeTypeName("LPCWSTR")] ushort* pwszComment)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, int> )(lpVtbl[11]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszComment);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteDocType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteDocType([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszPublicId, [NativeTypeName("LPCWSTR")] ushort* pwszSystemId, [NativeTypeName("LPCWSTR")] ushort* pwszSubset)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, ushort*, ushort*, ushort*, int> )(lpVtbl[12]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszName, pwszPublicId, pwszSystemId, pwszSubset);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteElementString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT WriteElementString([NativeTypeName("LPCWSTR")] ushort* pwszPrefix, [NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri, [NativeTypeName("LPCWSTR")] ushort* pwszValue)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, ushort*, ushort*, ushort*, int> )(lpVtbl[13]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszPrefix, pwszLocalName, pwszNamespaceUri, pwszValue);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteEndDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT WriteEndDocument()
    {
        return ((delegate* unmanaged<IXmlWriter*, int> )(lpVtbl[14]))((IXmlWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteEndElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT WriteEndElement()
    {
        return ((delegate* unmanaged<IXmlWriter*, int> )(lpVtbl[15]))((IXmlWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteEntityRef"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT WriteEntityRef([NativeTypeName("LPCWSTR")] ushort* pwszName)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, int> )(lpVtbl[16]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszName);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteFullEndElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT WriteFullEndElement()
    {
        return ((delegate* unmanaged<IXmlWriter*, int> )(lpVtbl[17]))((IXmlWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT WriteName([NativeTypeName("LPCWSTR")] ushort* pwszName)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, int> )(lpVtbl[18]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszName);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteNmToken"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WriteNmToken([NativeTypeName("LPCWSTR")] ushort* pwszNmToken)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, int> )(lpVtbl[19]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszNmToken);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT WriteNode(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
    {
        return ((delegate* unmanaged<IXmlWriter*, IXmlReader*, BOOL, int> )(lpVtbl[20]))((IXmlWriter*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteNodeShallow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT WriteNodeShallow(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
    {
        return ((delegate* unmanaged<IXmlWriter*, IXmlReader*, BOOL, int> )(lpVtbl[21]))((IXmlWriter*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteProcessingInstruction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT WriteProcessingInstruction([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszText)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, ushort*, int> )(lpVtbl[22]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszName, pwszText);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteQualifiedName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT WriteQualifiedName([NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, ushort*, int> )(lpVtbl[23]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszLocalName, pwszNamespaceUri);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteRaw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT WriteRaw([NativeTypeName("LPCWSTR")] ushort* pwszData)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, int> )(lpVtbl[24]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszData);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteRawChars"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT WriteRawChars([NativeTypeName("const WCHAR *")] ushort* pwch, uint cwch)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, uint, int> )(lpVtbl[25]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwch, cwch);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteStartDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT WriteStartDocument(XmlStandalone standalone)
    {
        return ((delegate* unmanaged<IXmlWriter*, XmlStandalone, int> )(lpVtbl[26]))((IXmlWriter*)Unsafe.AsPointer(ref this), standalone);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteStartElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT WriteStartElement([NativeTypeName("LPCWSTR")] ushort* pwszPrefix, [NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, ushort*, ushort*, int> )(lpVtbl[27]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszPrefix, pwszLocalName, pwszNamespaceUri);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT WriteString([NativeTypeName("LPCWSTR")] ushort* pwszText)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, int> )(lpVtbl[28]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszText);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteSurrogateCharEntity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT WriteSurrogateCharEntity([NativeTypeName("WCHAR")] ushort wchLow, [NativeTypeName("WCHAR")] ushort wchHigh)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort, ushort, int> )(lpVtbl[29]))((IXmlWriter*)Unsafe.AsPointer(ref this), wchLow, wchHigh);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.WriteWhitespace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT WriteWhitespace([NativeTypeName("LPCWSTR")] ushort* pwszWhitespace)
    {
        return ((delegate* unmanaged<IXmlWriter*, ushort*, int> )(lpVtbl[30]))((IXmlWriter*)Unsafe.AsPointer(ref this), pwszWhitespace);
    }

    /// <include file='IXmlWriter.xml' path='doc/member[@name="IXmlWriter.Flush"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<IXmlWriter*, int> )(lpVtbl[31]))((IXmlWriter*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetOutput(IUnknown* pOutput);
        [VtblIndex(4)]
        HRESULT GetProperty(uint nProperty, [NativeTypeName("LONG_PTR *")] nint* ppValue);
        [VtblIndex(5)]
        HRESULT SetProperty(uint nProperty, [NativeTypeName("LONG_PTR")] nint pValue);
        [VtblIndex(6)]
        HRESULT WriteAttributes(IXmlReader* pReader, BOOL fWriteDefaultAttributes);
        [VtblIndex(7)]
        HRESULT WriteAttributeString([NativeTypeName("LPCWSTR")] ushort* pwszPrefix, [NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri, [NativeTypeName("LPCWSTR")] ushort* pwszValue);
        [VtblIndex(8)]
        HRESULT WriteCData([NativeTypeName("LPCWSTR")] ushort* pwszText);
        [VtblIndex(9)]
        HRESULT WriteCharEntity([NativeTypeName("WCHAR")] ushort wch);
        [VtblIndex(10)]
        HRESULT WriteChars([NativeTypeName("const WCHAR *")] ushort* pwch, uint cwch);
        [VtblIndex(11)]
        HRESULT WriteComment([NativeTypeName("LPCWSTR")] ushort* pwszComment);
        [VtblIndex(12)]
        HRESULT WriteDocType([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszPublicId, [NativeTypeName("LPCWSTR")] ushort* pwszSystemId, [NativeTypeName("LPCWSTR")] ushort* pwszSubset);
        [VtblIndex(13)]
        HRESULT WriteElementString([NativeTypeName("LPCWSTR")] ushort* pwszPrefix, [NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri, [NativeTypeName("LPCWSTR")] ushort* pwszValue);
        [VtblIndex(14)]
        HRESULT WriteEndDocument();
        [VtblIndex(15)]
        HRESULT WriteEndElement();
        [VtblIndex(16)]
        HRESULT WriteEntityRef([NativeTypeName("LPCWSTR")] ushort* pwszName);
        [VtblIndex(17)]
        HRESULT WriteFullEndElement();
        [VtblIndex(18)]
        HRESULT WriteName([NativeTypeName("LPCWSTR")] ushort* pwszName);
        [VtblIndex(19)]
        HRESULT WriteNmToken([NativeTypeName("LPCWSTR")] ushort* pwszNmToken);
        [VtblIndex(20)]
        HRESULT WriteNode(IXmlReader* pReader, BOOL fWriteDefaultAttributes);
        [VtblIndex(21)]
        HRESULT WriteNodeShallow(IXmlReader* pReader, BOOL fWriteDefaultAttributes);
        [VtblIndex(22)]
        HRESULT WriteProcessingInstruction([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszText);
        [VtblIndex(23)]
        HRESULT WriteQualifiedName([NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri);
        [VtblIndex(24)]
        HRESULT WriteRaw([NativeTypeName("LPCWSTR")] ushort* pwszData);
        [VtblIndex(25)]
        HRESULT WriteRawChars([NativeTypeName("const WCHAR *")] ushort* pwch, uint cwch);
        [VtblIndex(26)]
        HRESULT WriteStartDocument(XmlStandalone standalone);
        [VtblIndex(27)]
        HRESULT WriteStartElement([NativeTypeName("LPCWSTR")] ushort* pwszPrefix, [NativeTypeName("LPCWSTR")] ushort* pwszLocalName, [NativeTypeName("LPCWSTR")] ushort* pwszNamespaceUri);
        [VtblIndex(28)]
        HRESULT WriteString([NativeTypeName("LPCWSTR")] ushort* pwszText);
        [VtblIndex(29)]
        HRESULT WriteSurrogateCharEntity([NativeTypeName("WCHAR")] ushort wchLow, [NativeTypeName("WCHAR")] ushort wchHigh);
        [VtblIndex(30)]
        HRESULT WriteWhitespace([NativeTypeName("LPCWSTR")] ushort* pwszWhitespace);
        [VtblIndex(31)]
        HRESULT Flush();
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
        public delegate* unmanaged<TSelf*, IUnknown*, int> SetOutput;
        [NativeTypeName("HRESULT (UINT, LONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, nint*, int> GetProperty;
        [NativeTypeName("HRESULT (UINT, LONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, nint, int> SetProperty;
        [NativeTypeName("HRESULT (IXmlReader *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXmlReader*, BOOL, int> WriteAttributes;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, ushort*, int> WriteAttributeString;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> WriteCData;
        [NativeTypeName("HRESULT (WCHAR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> WriteCharEntity;
        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> WriteChars;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> WriteComment;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, ushort*, int> WriteDocType;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, ushort*, int> WriteElementString;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> WriteEndDocument;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> WriteEndElement;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> WriteEntityRef;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> WriteFullEndElement;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> WriteName;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> WriteNmToken;
        [NativeTypeName("HRESULT (IXmlReader *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXmlReader*, BOOL, int> WriteNode;
        [NativeTypeName("HRESULT (IXmlReader *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXmlReader*, BOOL, int> WriteNodeShallow;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> WriteProcessingInstruction;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> WriteQualifiedName;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> WriteRaw;
        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> WriteRawChars;
        [NativeTypeName("HRESULT (XmlStandalone) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XmlStandalone, int> WriteStartDocument;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> WriteStartElement;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> WriteString;
        [NativeTypeName("HRESULT (WCHAR, WCHAR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, ushort, int> WriteSurrogateCharEntity;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> WriteWhitespace;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Flush;
    }
}