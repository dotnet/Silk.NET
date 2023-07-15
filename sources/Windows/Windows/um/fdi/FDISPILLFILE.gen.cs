// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FDISPILLFILE.xml' path='doc/member[@name="FDISPILLFILE"]/*'/>
public unsafe partial struct FDISPILLFILE
{
    /// <include file='FDISPILLFILE.xml' path='doc/member[@name="FDISPILLFILE.ach"]/*'/>
    [NativeTypeName("char[2]")]
    public fixed sbyte ach[2];
    /// <include file='FDISPILLFILE.xml' path='doc/member[@name="FDISPILLFILE.cbFile"]/*'/>
    [NativeTypeName("long")]
    public int cbFile;
}