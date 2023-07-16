// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DVEXTENTINFO.xml' path='doc/member[@name="DVEXTENTINFO"]/*'/>
public partial struct DVEXTENTINFO
{
    /// <include file='DVEXTENTINFO.xml' path='doc/member[@name="DVEXTENTINFO.cb"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cb;
    /// <include file='DVEXTENTINFO.xml' path='doc/member[@name="DVEXTENTINFO.dwExtentMode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwExtentMode;
    /// <include file='DVEXTENTINFO.xml' path='doc/member[@name="DVEXTENTINFO.sizelProposed"]/*'/>
    [NativeTypeName("SIZEL")]
    public SIZE sizelProposed;
}