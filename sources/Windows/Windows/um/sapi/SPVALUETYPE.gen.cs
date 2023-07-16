// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPVALUETYPE.xml' path='doc/member[@name="SPVALUETYPE"]/*'/>
public enum SPVALUETYPE
{
    /// <include file='SPVALUETYPE.xml' path='doc/member[@name="SPVALUETYPE.SPDF_PROPERTY"]/*'/>
    SPDF_PROPERTY = 0x1,
    /// <include file='SPVALUETYPE.xml' path='doc/member[@name="SPVALUETYPE.SPDF_REPLACEMENT"]/*'/>
    SPDF_REPLACEMENT = 0x2,
    /// <include file='SPVALUETYPE.xml' path='doc/member[@name="SPVALUETYPE.SPDF_RULE"]/*'/>
    SPDF_RULE = 0x4,
    /// <include file='SPVALUETYPE.xml' path='doc/member[@name="SPVALUETYPE.SPDF_DISPLAYTEXT"]/*'/>
    SPDF_DISPLAYTEXT = 0x8,
    /// <include file='SPVALUETYPE.xml' path='doc/member[@name="SPVALUETYPE.SPDF_LEXICALFORM"]/*'/>
    SPDF_LEXICALFORM = 0x10,
    /// <include file='SPVALUETYPE.xml' path='doc/member[@name="SPVALUETYPE.SPDF_PRONUNCIATION"]/*'/>
    SPDF_PRONUNCIATION = 0x20,
    /// <include file='SPVALUETYPE.xml' path='doc/member[@name="SPVALUETYPE.SPDF_AUDIO"]/*'/>
    SPDF_AUDIO = 0x40,
    /// <include file='SPVALUETYPE.xml' path='doc/member[@name="SPVALUETYPE.SPDF_ALTERNATES"]/*'/>
    SPDF_ALTERNATES = 0x80,
    /// <include file='SPVALUETYPE.xml' path='doc/member[@name="SPVALUETYPE.SPDF_ALL"]/*'/>
    SPDF_ALL = 0xff,
}