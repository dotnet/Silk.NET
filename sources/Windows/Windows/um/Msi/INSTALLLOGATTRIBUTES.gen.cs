// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='INSTALLLOGATTRIBUTES.xml' path='doc/member[@name="INSTALLLOGATTRIBUTES"]/*'/>
public enum INSTALLLOGATTRIBUTES
{
    /// <include file='INSTALLLOGATTRIBUTES.xml' path='doc/member[@name="INSTALLLOGATTRIBUTES.INSTALLLOGATTRIBUTES_APPEND"]/*'/>
    INSTALLLOGATTRIBUTES_APPEND = (1 << 0),
    /// <include file='INSTALLLOGATTRIBUTES.xml' path='doc/member[@name="INSTALLLOGATTRIBUTES.INSTALLLOGATTRIBUTES_FLUSHEACHLINE"]/*'/>
    INSTALLLOGATTRIBUTES_FLUSHEACHLINE = (1 << 1),
}