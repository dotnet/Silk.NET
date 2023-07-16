// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPWORD.xml' path='doc/member[@name="SPWORD"]/*'/>
public unsafe partial struct SPWORD
{
    /// <include file='SPWORD.xml' path='doc/member[@name="SPWORD.pNextWord"]/*'/>
    [NativeTypeName("struct SPWORD *")]
    public SPWORD* pNextWord;
    /// <include file='SPWORD.xml' path='doc/member[@name="SPWORD.LangID"]/*'/>
    [NativeTypeName("WORD")]
    public ushort LangID;
    /// <include file='SPWORD.xml' path='doc/member[@name="SPWORD.wReserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReserved;
    /// <include file='SPWORD.xml' path='doc/member[@name="SPWORD.eWordType"]/*'/>
    public SPWORDTYPE eWordType;
    /// <include file='SPWORD.xml' path='doc/member[@name="SPWORD.pszWord"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszWord;
    /// <include file='SPWORD.xml' path='doc/member[@name="SPWORD.pFirstWordPronunciation"]/*'/>
    public SPWORDPRONUNCIATION* pFirstWordPronunciation;
}