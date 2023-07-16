// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FINDTEXT_FLAGS.xml' path='doc/member[@name="FINDTEXT_FLAGS"]/*'/>
public enum FINDTEXT_FLAGS
{
    /// <include file='FINDTEXT_FLAGS.xml' path='doc/member[@name="FINDTEXT_FLAGS.FINDTEXT_BACKWARDS"]/*'/>
    FINDTEXT_BACKWARDS = 0x1,
    /// <include file='FINDTEXT_FLAGS.xml' path='doc/member[@name="FINDTEXT_FLAGS.FINDTEXT_WHOLEWORD"]/*'/>
    FINDTEXT_WHOLEWORD = 0x2,
    /// <include file='FINDTEXT_FLAGS.xml' path='doc/member[@name="FINDTEXT_FLAGS.FINDTEXT_MATCHCASE"]/*'/>
    FINDTEXT_MATCHCASE = 0x4,
    /// <include file='FINDTEXT_FLAGS.xml' path='doc/member[@name="FINDTEXT_FLAGS.FINDTEXT_RAW"]/*'/>
    FINDTEXT_RAW = 0x20000,
    /// <include file='FINDTEXT_FLAGS.xml' path='doc/member[@name="FINDTEXT_FLAGS.FINDTEXT_MATCHREPEATEDWHITESPACE"]/*'/>
    FINDTEXT_MATCHREPEATEDWHITESPACE = 0x40000,
    /// <include file='FINDTEXT_FLAGS.xml' path='doc/member[@name="FINDTEXT_FLAGS.FINDTEXT_MATCHDIAC"]/*'/>
    FINDTEXT_MATCHDIAC = 0x20000000,
    /// <include file='FINDTEXT_FLAGS.xml' path='doc/member[@name="FINDTEXT_FLAGS.FINDTEXT_MATCHKASHIDA"]/*'/>
    FINDTEXT_MATCHKASHIDA = 0x40000000,
    /// <include file='FINDTEXT_FLAGS.xml' path='doc/member[@name="FINDTEXT_FLAGS.FINDTEXT_MATCHALEFHAMZA"]/*'/>
    FINDTEXT_MATCHALEFHAMZA = unchecked((int)(0x80000000)),
    /// <include file='FINDTEXT_FLAGS.xml' path='doc/member[@name="FINDTEXT_FLAGS.FINDTEXT_FLAGS_Max"]/*'/>
    FINDTEXT_FLAGS_Max = 2147483647,
}