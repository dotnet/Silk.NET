// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='RGNDATA.xml' path='doc/member[@name="RGNDATA"]/*'/>
public unsafe partial struct RGNDATA
{
    /// <include file='RGNDATA.xml' path='doc/member[@name="RGNDATA.rdh"]/*'/>
    public RGNDATAHEADER rdh;
    /// <include file='RGNDATA.xml' path='doc/member[@name="RGNDATA.Buffer"]/*'/>
    [NativeTypeName("char[1]")]
    public fixed sbyte Buffer[1];
}