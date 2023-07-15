// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.WinRT;
/// <include file='SourceInfo.xml' path='doc/member[@name="SourceInfo"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct SourceInfo
{
    /// <include file='SourceInfo.xml' path='doc/member[@name="SourceInfo.FileName"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* FileName;
    /// <include file='SourceInfo.xml' path='doc/member[@name="SourceInfo.LineNumber"]/*'/>
    [NativeTypeName("unsigned int")]
    public uint LineNumber;
    /// <include file='SourceInfo.xml' path='doc/member[@name="SourceInfo.ColumnNumber"]/*'/>
    [NativeTypeName("unsigned int")]
    public uint ColumnNumber;
    /// <include file='SourceInfo.xml' path='doc/member[@name="SourceInfo.CharPosition"]/*'/>
    [NativeTypeName("unsigned int")]
    public uint CharPosition;
    /// <include file='SourceInfo.xml' path='doc/member[@name="SourceInfo.Hash"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* Hash;
}