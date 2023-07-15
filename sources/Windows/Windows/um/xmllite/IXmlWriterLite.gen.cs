// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite"]/*'/>
[Guid("862494C6-1310-4AAD-B3CD-2DBEEBF670D3")]
[NativeTypeName("struct IXmlWriterLite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXmlWriterLite : IXmlWriterLite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlWriterLite));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, Guid*, void**, int> )(lpVtbl[0]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXmlWriterLite*, uint> )(lpVtbl[1]))((IXmlWriterLite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXmlWriterLite*, uint> )(lpVtbl[2]))((IXmlWriterLite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.SetOutput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetOutput(IUnknown* pOutput)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, IUnknown*, int> )(lpVtbl[3]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pOutput);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.GetProperty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProperty(uint nProperty, [NativeTypeName("LONG_PTR *")] nint* ppValue)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, uint, nint*, int> )(lpVtbl[4]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), nProperty, ppValue);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.SetProperty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetProperty(uint nProperty, [NativeTypeName("LONG_PTR")] nint pValue)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, uint, nint, int> )(lpVtbl[5]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), nProperty, pValue);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteAttributes(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, IXmlReader*, BOOL, int> )(lpVtbl[6]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteAttributeString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT WriteAttributeString([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName, [NativeTypeName("const WCHAR *")] ushort* pwszValue, uint cwszValue)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, ushort*, uint, int> )(lpVtbl[7]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName, pwszValue, cwszValue);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteCData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WriteCData([NativeTypeName("LPCWSTR")] ushort* pwszText)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int> )(lpVtbl[8]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszText);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteCharEntity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WriteCharEntity([NativeTypeName("WCHAR")] ushort wch)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort, int> )(lpVtbl[9]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), wch);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteChars"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT WriteChars([NativeTypeName("const WCHAR *")] ushort* pwch, uint cwch)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int> )(lpVtbl[10]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwch, cwch);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteComment"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT WriteComment([NativeTypeName("LPCWSTR")] ushort* pwszComment)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int> )(lpVtbl[11]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszComment);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteDocType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteDocType([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszPublicId, [NativeTypeName("LPCWSTR")] ushort* pwszSystemId, [NativeTypeName("LPCWSTR")] ushort* pwszSubset)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, ushort*, ushort*, ushort*, int> )(lpVtbl[12]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszName, pwszPublicId, pwszSystemId, pwszSubset);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteElementString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT WriteElementString([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName, [NativeTypeName("LPCWSTR")] ushort* pwszValue)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, ushort*, int> )(lpVtbl[13]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName, pwszValue);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteEndDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT WriteEndDocument()
    {
        return ((delegate* unmanaged<IXmlWriterLite*, int> )(lpVtbl[14]))((IXmlWriterLite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteEndElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT WriteEndElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int> )(lpVtbl[15]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteEntityRef"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT WriteEntityRef([NativeTypeName("LPCWSTR")] ushort* pwszName)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int> )(lpVtbl[16]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszName);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteFullEndElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT WriteFullEndElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int> )(lpVtbl[17]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT WriteName([NativeTypeName("LPCWSTR")] ushort* pwszName)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int> )(lpVtbl[18]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszName);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteNmToken"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WriteNmToken([NativeTypeName("LPCWSTR")] ushort* pwszNmToken)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int> )(lpVtbl[19]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszNmToken);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteNode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT WriteNode(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, IXmlReader*, BOOL, int> )(lpVtbl[20]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteNodeShallow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT WriteNodeShallow(IXmlReader* pReader, BOOL fWriteDefaultAttributes)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, IXmlReader*, BOOL, int> )(lpVtbl[21]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pReader, fWriteDefaultAttributes);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteProcessingInstruction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT WriteProcessingInstruction([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("LPCWSTR")] ushort* pwszText)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, ushort*, int> )(lpVtbl[22]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszName, pwszText);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteRaw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT WriteRaw([NativeTypeName("LPCWSTR")] ushort* pwszData)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int> )(lpVtbl[23]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszData);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteRawChars"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT WriteRawChars([NativeTypeName("const WCHAR *")] ushort* pwch, uint cwch)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int> )(lpVtbl[24]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwch, cwch);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteStartDocument"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT WriteStartDocument(XmlStandalone standalone)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, XmlStandalone, int> )(lpVtbl[25]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), standalone);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteStartElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT WriteStartElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, uint, int> )(lpVtbl[26]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszQName, cwszQName);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT WriteString([NativeTypeName("LPCWSTR")] ushort* pwszText)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int> )(lpVtbl[27]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszText);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteSurrogateCharEntity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT WriteSurrogateCharEntity([NativeTypeName("WCHAR")] ushort wchLow, [NativeTypeName("WCHAR")] ushort wchHigh)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort, ushort, int> )(lpVtbl[28]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), wchLow, wchHigh);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.WriteWhitespace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT WriteWhitespace([NativeTypeName("LPCWSTR")] ushort* pwszWhitespace)
    {
        return ((delegate* unmanaged<IXmlWriterLite*, ushort*, int> )(lpVtbl[29]))((IXmlWriterLite*)Unsafe.AsPointer(ref this), pwszWhitespace);
    }

    /// <include file='IXmlWriterLite.xml' path='doc/member[@name="IXmlWriterLite.Flush"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<IXmlWriterLite*, int> )(lpVtbl[30]))((IXmlWriterLite*)Unsafe.AsPointer(ref this));
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
        HRESULT WriteAttributeString([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName, [NativeTypeName("const WCHAR *")] ushort* pwszValue, uint cwszValue);
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
        HRESULT WriteElementString([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName, [NativeTypeName("LPCWSTR")] ushort* pwszValue);
        [VtblIndex(14)]
        HRESULT WriteEndDocument();
        [VtblIndex(15)]
        HRESULT WriteEndElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName);
        [VtblIndex(16)]
        HRESULT WriteEntityRef([NativeTypeName("LPCWSTR")] ushort* pwszName);
        [VtblIndex(17)]
        HRESULT WriteFullEndElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName);
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
        HRESULT WriteRaw([NativeTypeName("LPCWSTR")] ushort* pwszData);
        [VtblIndex(24)]
        HRESULT WriteRawChars([NativeTypeName("const WCHAR *")] ushort* pwch, uint cwch);
        [VtblIndex(25)]
        HRESULT WriteStartDocument(XmlStandalone standalone);
        [VtblIndex(26)]
        HRESULT WriteStartElement([NativeTypeName("const WCHAR *")] ushort* pwszQName, uint cwszQName);
        [VtblIndex(27)]
        HRESULT WriteString([NativeTypeName("LPCWSTR")] ushort* pwszText);
        [VtblIndex(28)]
        HRESULT WriteSurrogateCharEntity([NativeTypeName("WCHAR")] ushort wchLow, [NativeTypeName("WCHAR")] ushort wchHigh);
        [VtblIndex(29)]
        HRESULT WriteWhitespace([NativeTypeName("LPCWSTR")] ushort* pwszWhitespace);
        [VtblIndex(30)]
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
        [NativeTypeName("HRESULT (const WCHAR *, UINT, const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort*, uint, int> WriteAttributeString;
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
        [NativeTypeName("HRESULT (const WCHAR *, UINT, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort*, int> WriteElementString;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> WriteEndDocument;
        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> WriteEndElement;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> WriteEntityRef;
        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> WriteFullEndElement;
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
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> WriteRaw;
        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> WriteRawChars;
        [NativeTypeName("HRESULT (XmlStandalone) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XmlStandalone, int> WriteStartDocument;
        [NativeTypeName("HRESULT (const WCHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> WriteStartElement;
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