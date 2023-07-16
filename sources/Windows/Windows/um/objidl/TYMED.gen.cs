// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TYMED.xml' path='doc/member[@name="TYMED"]/*'/>
public enum TYMED
{
    /// <include file='TYMED.xml' path='doc/member[@name="TYMED.TYMED_HGLOBAL"]/*'/>
    TYMED_HGLOBAL = 1,
    /// <include file='TYMED.xml' path='doc/member[@name="TYMED.TYMED_FILE"]/*'/>
    TYMED_FILE = 2,
    /// <include file='TYMED.xml' path='doc/member[@name="TYMED.TYMED_ISTREAM"]/*'/>
    TYMED_ISTREAM = 4,
    /// <include file='TYMED.xml' path='doc/member[@name="TYMED.TYMED_ISTORAGE"]/*'/>
    TYMED_ISTORAGE = 8,
    /// <include file='TYMED.xml' path='doc/member[@name="TYMED.TYMED_GDI"]/*'/>
    TYMED_GDI = 16,
    /// <include file='TYMED.xml' path='doc/member[@name="TYMED.TYMED_MFPICT"]/*'/>
    TYMED_MFPICT = 32,
    /// <include file='TYMED.xml' path='doc/member[@name="TYMED.TYMED_ENHMF"]/*'/>
    TYMED_ENHMF = 64,
    /// <include file='TYMED.xml' path='doc/member[@name="TYMED.TYMED_NULL"]/*'/>
    TYMED_NULL = 0,
}