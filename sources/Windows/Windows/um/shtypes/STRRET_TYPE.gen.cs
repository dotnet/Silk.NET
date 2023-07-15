// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STRRET_TYPE.xml' path='doc/member[@name="STRRET_TYPE"]/*'/>
public enum STRRET_TYPE
{
    /// <include file='STRRET_TYPE.xml' path='doc/member[@name="STRRET_TYPE.STRRET_WSTR"]/*'/>
    STRRET_WSTR = 0,
    /// <include file='STRRET_TYPE.xml' path='doc/member[@name="STRRET_TYPE.STRRET_OFFSET"]/*'/>
    STRRET_OFFSET = 0x1,
    /// <include file='STRRET_TYPE.xml' path='doc/member[@name="STRRET_TYPE.STRRET_CSTR"]/*'/>
    STRRET_CSTR = 0x2,
}