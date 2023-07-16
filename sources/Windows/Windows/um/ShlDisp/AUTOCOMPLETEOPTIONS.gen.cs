// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AUTOCOMPLETEOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETEOPTIONS"]/*'/>
public enum AUTOCOMPLETEOPTIONS
{
    /// <include file='AUTOCOMPLETEOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETEOPTIONS.ACO_NONE"]/*'/>
    ACO_NONE = 0,
    /// <include file='AUTOCOMPLETEOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETEOPTIONS.ACO_AUTOSUGGEST"]/*'/>
    ACO_AUTOSUGGEST = 0x1,
    /// <include file='AUTOCOMPLETEOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETEOPTIONS.ACO_AUTOAPPEND"]/*'/>
    ACO_AUTOAPPEND = 0x2,
    /// <include file='AUTOCOMPLETEOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETEOPTIONS.ACO_SEARCH"]/*'/>
    ACO_SEARCH = 0x4,
    /// <include file='AUTOCOMPLETEOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETEOPTIONS.ACO_FILTERPREFIXES"]/*'/>
    ACO_FILTERPREFIXES = 0x8,
    /// <include file='AUTOCOMPLETEOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETEOPTIONS.ACO_USETAB"]/*'/>
    ACO_USETAB = 0x10,
    /// <include file='AUTOCOMPLETEOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETEOPTIONS.ACO_UPDOWNKEYDROPSLIST"]/*'/>
    ACO_UPDOWNKEYDROPSLIST = 0x20,
    /// <include file='AUTOCOMPLETEOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETEOPTIONS.ACO_RTLREADING"]/*'/>
    ACO_RTLREADING = 0x40,
    /// <include file='AUTOCOMPLETEOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETEOPTIONS.ACO_WORD_FILTER"]/*'/>
    ACO_WORD_FILTER = 0x80,
    /// <include file='AUTOCOMPLETEOPTIONS.xml' path='doc/member[@name="AUTOCOMPLETEOPTIONS.ACO_NOPREFIXFILTERING"]/*'/>
    ACO_NOPREFIXFILTERING = 0x100,
}