// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED"]/*'/>
public enum PERCEIVED
{
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_FIRST"]/*'/>
    PERCEIVED_TYPE_FIRST = -3,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_CUSTOM"]/*'/>
    PERCEIVED_TYPE_CUSTOM = -3,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_UNSPECIFIED"]/*'/>
    PERCEIVED_TYPE_UNSPECIFIED = -2,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_FOLDER"]/*'/>
    PERCEIVED_TYPE_FOLDER = -1,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_UNKNOWN"]/*'/>
    PERCEIVED_TYPE_UNKNOWN = 0,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_TEXT"]/*'/>
    PERCEIVED_TYPE_TEXT = 1,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_IMAGE"]/*'/>
    PERCEIVED_TYPE_IMAGE = 2,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_AUDIO"]/*'/>
    PERCEIVED_TYPE_AUDIO = 3,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_VIDEO"]/*'/>
    PERCEIVED_TYPE_VIDEO = 4,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_COMPRESSED"]/*'/>
    PERCEIVED_TYPE_COMPRESSED = 5,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_DOCUMENT"]/*'/>
    PERCEIVED_TYPE_DOCUMENT = 6,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_SYSTEM"]/*'/>
    PERCEIVED_TYPE_SYSTEM = 7,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_APPLICATION"]/*'/>
    PERCEIVED_TYPE_APPLICATION = 8,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_GAMEMEDIA"]/*'/>
    PERCEIVED_TYPE_GAMEMEDIA = 9,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_CONTACTS"]/*'/>
    PERCEIVED_TYPE_CONTACTS = 10,
    /// <include file='PERCEIVED.xml' path='doc/member[@name="PERCEIVED.PERCEIVED_TYPE_LAST"]/*'/>
    PERCEIVED_TYPE_LAST = 10,
}