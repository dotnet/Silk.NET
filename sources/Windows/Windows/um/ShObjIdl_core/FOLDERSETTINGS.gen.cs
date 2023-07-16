// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FOLDERSETTINGS.xml' path='doc/member[@name="FOLDERSETTINGS"]/*'/>
public partial struct FOLDERSETTINGS
{
    /// <include file='FOLDERSETTINGS.xml' path='doc/member[@name="FOLDERSETTINGS.ViewMode"]/*'/>
    public uint ViewMode;
    /// <include file='FOLDERSETTINGS.xml' path='doc/member[@name="FOLDERSETTINGS.fFlags"]/*'/>
    public uint fFlags;
}