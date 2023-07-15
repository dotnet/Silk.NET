// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='htmlDir.xml' path='doc/member[@name="htmlDir"]/*'/>
public enum htmlDir
{
    /// <include file='htmlDir.xml' path='doc/member[@name="htmlDir.htmlDirNotSet"]/*'/>
    htmlDirNotSet = 0,
    /// <include file='htmlDir.xml' path='doc/member[@name="htmlDir.htmlDirLeftToRight"]/*'/>
    htmlDirLeftToRight = 1,
    /// <include file='htmlDir.xml' path='doc/member[@name="htmlDir.htmlDirRightToLeft"]/*'/>
    htmlDirRightToLeft = 2,
    /// <include file='htmlDir.xml' path='doc/member[@name="htmlDir.htmlDir_Max"]/*'/>
    htmlDir_Max = 2147483647,
}