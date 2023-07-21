// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='XML_ERROR.xml' path='doc/member[@name="XML_ERROR"]/*' />
public unsafe partial struct XML_ERROR
{
    /// <include file='XML_ERROR.xml' path='doc/member[@name="XML_ERROR._nLine"]/*' />
    [NativeTypeName("unsigned int")]
    public uint _nLine;

    /// <include file='XML_ERROR.xml' path='doc/member[@name="XML_ERROR._pchBuf"]/*' />
    [NativeTypeName("BSTR")]
    public ushort* _pchBuf;

    /// <include file='XML_ERROR.xml' path='doc/member[@name="XML_ERROR._cchBuf"]/*' />
    [NativeTypeName("unsigned int")]
    public uint _cchBuf;

    /// <include file='XML_ERROR.xml' path='doc/member[@name="XML_ERROR._ich"]/*' />
    [NativeTypeName("unsigned int")]
    public uint _ich;

    /// <include file='XML_ERROR.xml' path='doc/member[@name="XML_ERROR._pszFound"]/*' />
    [NativeTypeName("BSTR")]
    public ushort* _pszFound;

    /// <include file='XML_ERROR.xml' path='doc/member[@name="XML_ERROR._pszExpected"]/*' />
    [NativeTypeName("BSTR")]
    public ushort* _pszExpected;

    /// <include file='XML_ERROR.xml' path='doc/member[@name="XML_ERROR._reserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint _reserved1;

    /// <include file='XML_ERROR.xml' path='doc/member[@name="XML_ERROR._reserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint _reserved2;
}
