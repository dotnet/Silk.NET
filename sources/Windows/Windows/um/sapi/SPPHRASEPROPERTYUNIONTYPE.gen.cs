// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPPHRASEPROPERTYUNIONTYPE.xml' path='doc/member[@name="SPPHRASEPROPERTYUNIONTYPE"]/*'/>
public enum SPPHRASEPROPERTYUNIONTYPE
{
    /// <include file='SPPHRASEPROPERTYUNIONTYPE.xml' path='doc/member[@name="SPPHRASEPROPERTYUNIONTYPE.SPPPUT_UNUSED"]/*'/>
    SPPPUT_UNUSED = 0,
    /// <include file='SPPHRASEPROPERTYUNIONTYPE.xml' path='doc/member[@name="SPPHRASEPROPERTYUNIONTYPE.SPPPUT_ARRAY_INDEX"]/*'/>
    SPPPUT_ARRAY_INDEX = (SPPPUT_UNUSED + 1),
}