// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPSHORTCUTPAIR.xml' path='doc/member[@name="SPSHORTCUTPAIR"]/*'/>
public unsafe partial struct SPSHORTCUTPAIR
{
    /// <include file='SPSHORTCUTPAIR.xml' path='doc/member[@name="SPSHORTCUTPAIR.pNextSHORTCUTPAIR"]/*'/>
    [NativeTypeName("struct SPSHORTCUTPAIR *")]
    public SPSHORTCUTPAIR* pNextSHORTCUTPAIR;
    /// <include file='SPSHORTCUTPAIR.xml' path='doc/member[@name="SPSHORTCUTPAIR.LangID"]/*'/>
    [NativeTypeName("WORD")]
    public ushort LangID;
    /// <include file='SPSHORTCUTPAIR.xml' path='doc/member[@name="SPSHORTCUTPAIR.shType"]/*'/>
    public SPSHORTCUTTYPE shType;
    /// <include file='SPSHORTCUTPAIR.xml' path='doc/member[@name="SPSHORTCUTPAIR.pszDisplay"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszDisplay;
    /// <include file='SPSHORTCUTPAIR.xml' path='doc/member[@name="SPSHORTCUTPAIR.pszSpoken"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszSpoken;
}