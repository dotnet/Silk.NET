// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR"]/*'/>
public enum MSIDBERROR
{
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_INVALIDARG"]/*'/>
    MSIDBERROR_INVALIDARG = -3,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_MOREDATA"]/*'/>
    MSIDBERROR_MOREDATA = -2,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_FUNCTIONERROR"]/*'/>
    MSIDBERROR_FUNCTIONERROR = -1,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_NOERROR"]/*'/>
    MSIDBERROR_NOERROR = 0,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_DUPLICATEKEY"]/*'/>
    MSIDBERROR_DUPLICATEKEY = 1,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_REQUIRED"]/*'/>
    MSIDBERROR_REQUIRED = 2,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADLINK"]/*'/>
    MSIDBERROR_BADLINK = 3,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_OVERFLOW"]/*'/>
    MSIDBERROR_OVERFLOW = 4,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_UNDERFLOW"]/*'/>
    MSIDBERROR_UNDERFLOW = 5,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_NOTINSET"]/*'/>
    MSIDBERROR_NOTINSET = 6,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADVERSION"]/*'/>
    MSIDBERROR_BADVERSION = 7,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADCASE"]/*'/>
    MSIDBERROR_BADCASE = 8,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADGUID"]/*'/>
    MSIDBERROR_BADGUID = 9,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADWILDCARD"]/*'/>
    MSIDBERROR_BADWILDCARD = 10,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADIDENTIFIER"]/*'/>
    MSIDBERROR_BADIDENTIFIER = 11,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADLANGUAGE"]/*'/>
    MSIDBERROR_BADLANGUAGE = 12,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADFILENAME"]/*'/>
    MSIDBERROR_BADFILENAME = 13,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADPATH"]/*'/>
    MSIDBERROR_BADPATH = 14,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADCONDITION"]/*'/>
    MSIDBERROR_BADCONDITION = 15,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADFORMATTED"]/*'/>
    MSIDBERROR_BADFORMATTED = 16,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADTEMPLATE"]/*'/>
    MSIDBERROR_BADTEMPLATE = 17,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADDEFAULTDIR"]/*'/>
    MSIDBERROR_BADDEFAULTDIR = 18,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADREGPATH"]/*'/>
    MSIDBERROR_BADREGPATH = 19,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADCUSTOMSOURCE"]/*'/>
    MSIDBERROR_BADCUSTOMSOURCE = 20,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADPROPERTY"]/*'/>
    MSIDBERROR_BADPROPERTY = 21,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_MISSINGDATA"]/*'/>
    MSIDBERROR_MISSINGDATA = 22,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADCATEGORY"]/*'/>
    MSIDBERROR_BADCATEGORY = 23,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADKEYTABLE"]/*'/>
    MSIDBERROR_BADKEYTABLE = 24,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADMAXMINVALUES"]/*'/>
    MSIDBERROR_BADMAXMINVALUES = 25,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADCABINET"]/*'/>
    MSIDBERROR_BADCABINET = 26,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADSHORTCUT"]/*'/>
    MSIDBERROR_BADSHORTCUT = 27,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_STRINGOVERFLOW"]/*'/>
    MSIDBERROR_STRINGOVERFLOW = 28,
    /// <include file='MSIDBERROR.xml' path='doc/member[@name="MSIDBERROR.MSIDBERROR_BADLOCALIZEATTRIB"]/*'/>
    MSIDBERROR_BADLOCALIZEATTRIB = 29,
}