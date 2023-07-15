// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CONTROLINFO.xml' path='doc/member[@name="CONTROLINFO"]/*'/>
public partial struct CONTROLINFO
{
    /// <include file='CONTROLINFO.xml' path='doc/member[@name="CONTROLINFO.cb"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cb;
    /// <include file='CONTROLINFO.xml' path='doc/member[@name="CONTROLINFO.hAccel"]/*'/>
    public HACCEL hAccel;
    /// <include file='CONTROLINFO.xml' path='doc/member[@name="CONTROLINFO.cAccel"]/*'/>
    public ushort cAccel;
    /// <include file='CONTROLINFO.xml' path='doc/member[@name="CONTROLINFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}