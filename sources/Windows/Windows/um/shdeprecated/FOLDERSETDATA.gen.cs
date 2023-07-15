// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='FOLDERSETDATA.xml' path='doc/member[@name="FOLDERSETDATA"]/*'/>
public partial struct FOLDERSETDATA
{
    /// <include file='FOLDERSETDATA.xml' path='doc/member[@name="FOLDERSETDATA._fs"]/*'/>
    public FOLDERSETTINGS _fs;
    /// <include file='FOLDERSETDATA.xml' path='doc/member[@name="FOLDERSETDATA._vidRestore"]/*'/>
    [NativeTypeName("SHELLVIEWID")]
    public Guid _vidRestore;
    /// <include file='FOLDERSETDATA.xml' path='doc/member[@name="FOLDERSETDATA._dwViewPriority"]/*'/>
    [NativeTypeName("DWORD")]
    public uint _dwViewPriority;
}