// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FOLDERLOGICALVIEWMODE.xml' path='doc/member[@name="FOLDERLOGICALVIEWMODE"]/*'/>
public enum FOLDERLOGICALVIEWMODE
{
    /// <include file='FOLDERLOGICALVIEWMODE.xml' path='doc/member[@name="FOLDERLOGICALVIEWMODE.FLVM_UNSPECIFIED"]/*'/>
    FLVM_UNSPECIFIED = -1,
    /// <include file='FOLDERLOGICALVIEWMODE.xml' path='doc/member[@name="FOLDERLOGICALVIEWMODE.FLVM_FIRST"]/*'/>
    FLVM_FIRST = 1,
    /// <include file='FOLDERLOGICALVIEWMODE.xml' path='doc/member[@name="FOLDERLOGICALVIEWMODE.FLVM_DETAILS"]/*'/>
    FLVM_DETAILS = 1,
    /// <include file='FOLDERLOGICALVIEWMODE.xml' path='doc/member[@name="FOLDERLOGICALVIEWMODE.FLVM_TILES"]/*'/>
    FLVM_TILES = 2,
    /// <include file='FOLDERLOGICALVIEWMODE.xml' path='doc/member[@name="FOLDERLOGICALVIEWMODE.FLVM_ICONS"]/*'/>
    FLVM_ICONS = 3,
    /// <include file='FOLDERLOGICALVIEWMODE.xml' path='doc/member[@name="FOLDERLOGICALVIEWMODE.FLVM_LIST"]/*'/>
    FLVM_LIST = 4,
    /// <include file='FOLDERLOGICALVIEWMODE.xml' path='doc/member[@name="FOLDERLOGICALVIEWMODE.FLVM_CONTENT"]/*'/>
    FLVM_CONTENT = 5,
    /// <include file='FOLDERLOGICALVIEWMODE.xml' path='doc/member[@name="FOLDERLOGICALVIEWMODE.FLVM_LAST"]/*'/>
    FLVM_LAST = 5,
}