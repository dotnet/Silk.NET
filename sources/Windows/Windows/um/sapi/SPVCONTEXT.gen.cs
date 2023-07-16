// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPVCONTEXT.xml' path='doc/member[@name="SPVCONTEXT"]/*'/>
public unsafe partial struct SPVCONTEXT
{
    /// <include file='SPVCONTEXT.xml' path='doc/member[@name="SPVCONTEXT.pCategory"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pCategory;
    /// <include file='SPVCONTEXT.xml' path='doc/member[@name="SPVCONTEXT.pBefore"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pBefore;
    /// <include file='SPVCONTEXT.xml' path='doc/member[@name="SPVCONTEXT.pAfter"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pAfter;
}