// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='StringTrimming.xml' path='doc/member[@name="StringTrimming"]/*'/>
public enum StringTrimming
{
    /// <include file='StringTrimming.xml' path='doc/member[@name="StringTrimming.StringTrimmingNone"]/*'/>
    StringTrimmingNone = 0,
    /// <include file='StringTrimming.xml' path='doc/member[@name="StringTrimming.StringTrimmingCharacter"]/*'/>
    StringTrimmingCharacter = 1,
    /// <include file='StringTrimming.xml' path='doc/member[@name="StringTrimming.StringTrimmingWord"]/*'/>
    StringTrimmingWord = 2,
    /// <include file='StringTrimming.xml' path='doc/member[@name="StringTrimming.StringTrimmingEllipsisCharacter"]/*'/>
    StringTrimmingEllipsisCharacter = 3,
    /// <include file='StringTrimming.xml' path='doc/member[@name="StringTrimming.StringTrimmingEllipsisWord"]/*'/>
    StringTrimmingEllipsisWord = 4,
    /// <include file='StringTrimming.xml' path='doc/member[@name="StringTrimming.StringTrimmingEllipsisPath"]/*'/>
    StringTrimmingEllipsisPath = 5,
}