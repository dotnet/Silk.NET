// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DRAGDROPPARTS.xml' path='doc/member[@name="DRAGDROPPARTS"]/*'/>
public enum DRAGDROPPARTS
{
    /// <include file='DRAGDROPPARTS.xml' path='doc/member[@name="DRAGDROPPARTS.DD_COPY"]/*'/>
    DD_COPY = 1,
    /// <include file='DRAGDROPPARTS.xml' path='doc/member[@name="DRAGDROPPARTS.DD_MOVE"]/*'/>
    DD_MOVE = 2,
    /// <include file='DRAGDROPPARTS.xml' path='doc/member[@name="DRAGDROPPARTS.DD_UPDATEMETADATA"]/*'/>
    DD_UPDATEMETADATA = 3,
    /// <include file='DRAGDROPPARTS.xml' path='doc/member[@name="DRAGDROPPARTS.DD_CREATELINK"]/*'/>
    DD_CREATELINK = 4,
    /// <include file='DRAGDROPPARTS.xml' path='doc/member[@name="DRAGDROPPARTS.DD_WARNING"]/*'/>
    DD_WARNING = 5,
    /// <include file='DRAGDROPPARTS.xml' path='doc/member[@name="DRAGDROPPARTS.DD_NONE"]/*'/>
    DD_NONE = 6,
    /// <include file='DRAGDROPPARTS.xml' path='doc/member[@name="DRAGDROPPARTS.DD_IMAGEBG"]/*'/>
    DD_IMAGEBG = 7,
    /// <include file='DRAGDROPPARTS.xml' path='doc/member[@name="DRAGDROPPARTS.DD_TEXTBG"]/*'/>
    DD_TEXTBG = 8,
}