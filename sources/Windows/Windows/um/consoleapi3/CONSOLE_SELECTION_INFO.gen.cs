// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/consoleapi3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CONSOLE_SELECTION_INFO.xml' path='doc/member[@name="CONSOLE_SELECTION_INFO"]/*'/>
public partial struct CONSOLE_SELECTION_INFO
{
    /// <include file='CONSOLE_SELECTION_INFO.xml' path='doc/member[@name="CONSOLE_SELECTION_INFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='CONSOLE_SELECTION_INFO.xml' path='doc/member[@name="CONSOLE_SELECTION_INFO.dwSelectionAnchor"]/*'/>
    public COORD dwSelectionAnchor;
    /// <include file='CONSOLE_SELECTION_INFO.xml' path='doc/member[@name="CONSOLE_SELECTION_INFO.srSelection"]/*'/>
    public SMALL_RECT srSelection;
}