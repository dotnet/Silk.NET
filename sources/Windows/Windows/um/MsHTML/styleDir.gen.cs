// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='styleDir.xml' path='doc/member[@name="styleDir"]/*'/>
public enum styleDir
{
    /// <include file='styleDir.xml' path='doc/member[@name="styleDir.styleDirNotSet"]/*'/>
    styleDirNotSet = 0,
    /// <include file='styleDir.xml' path='doc/member[@name="styleDir.styleDirLeftToRight"]/*'/>
    styleDirLeftToRight = 1,
    /// <include file='styleDir.xml' path='doc/member[@name="styleDir.styleDirRightToLeft"]/*'/>
    styleDirRightToLeft = 2,
    /// <include file='styleDir.xml' path='doc/member[@name="styleDir.styleDirInherit"]/*'/>
    styleDirInherit = 3,
    /// <include file='styleDir.xml' path='doc/member[@name="styleDir.styleDir_Max"]/*'/>
    styleDir_Max = 2147483647,
}