// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LIBRARYFOLDERFILTER.xml' path='doc/member[@name="LIBRARYFOLDERFILTER"]/*'/>
public enum LIBRARYFOLDERFILTER
{
    /// <include file='LIBRARYFOLDERFILTER.xml' path='doc/member[@name="LIBRARYFOLDERFILTER.LFF_FORCEFILESYSTEM"]/*'/>
    LFF_FORCEFILESYSTEM = 1,
    /// <include file='LIBRARYFOLDERFILTER.xml' path='doc/member[@name="LIBRARYFOLDERFILTER.LFF_STORAGEITEMS"]/*'/>
    LFF_STORAGEITEMS = 2,
    /// <include file='LIBRARYFOLDERFILTER.xml' path='doc/member[@name="LIBRARYFOLDERFILTER.LFF_ALLITEMS"]/*'/>
    LFF_ALLITEMS = 3,
}