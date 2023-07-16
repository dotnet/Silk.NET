// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PRINTPAGERANGE.xml' path='doc/member[@name="PRINTPAGERANGE"]/*'/>
public partial struct PRINTPAGERANGE
{
    /// <include file='PRINTPAGERANGE.xml' path='doc/member[@name="PRINTPAGERANGE.nFromPage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFromPage;
    /// <include file='PRINTPAGERANGE.xml' path='doc/member[@name="PRINTPAGERANGE.nToPage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nToPage;
}