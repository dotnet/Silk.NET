// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='OPENASINFO.xml' path='doc/member[@name="OPENASINFO"]/*'/>
public unsafe partial struct OPENASINFO
{
    /// <include file='OPENASINFO.xml' path='doc/member[@name="OPENASINFO.pcszFile"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pcszFile;
    /// <include file='OPENASINFO.xml' path='doc/member[@name="OPENASINFO.pcszClass"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pcszClass;
    /// <include file='OPENASINFO.xml' path='doc/member[@name="OPENASINFO.oaifInFlags"]/*'/>
    [NativeTypeName("OPEN_AS_INFO_FLAGS")]
    public int oaifInFlags;
}