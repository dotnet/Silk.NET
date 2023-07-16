// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='msidbIniFileAction.xml' path='doc/member[@name="msidbIniFileAction"]/*'/>
public enum msidbIniFileAction
{
    /// <include file='msidbIniFileAction.xml' path='doc/member[@name="msidbIniFileAction.msidbIniFileActionAddLine"]/*'/>
    msidbIniFileActionAddLine = 0x00000000,
    /// <include file='msidbIniFileAction.xml' path='doc/member[@name="msidbIniFileAction.msidbIniFileActionCreateLine"]/*'/>
    msidbIniFileActionCreateLine = 0x00000001,
    /// <include file='msidbIniFileAction.xml' path='doc/member[@name="msidbIniFileAction.msidbIniFileActionRemoveLine"]/*'/>
    msidbIniFileActionRemoveLine = 0x00000002,
    /// <include file='msidbIniFileAction.xml' path='doc/member[@name="msidbIniFileAction.msidbIniFileActionAddTag"]/*'/>
    msidbIniFileActionAddTag = 0x00000003,
    /// <include file='msidbIniFileAction.xml' path='doc/member[@name="msidbIniFileAction.msidbIniFileActionRemoveTag"]/*'/>
    msidbIniFileActionRemoveTag = 0x00000004,
}