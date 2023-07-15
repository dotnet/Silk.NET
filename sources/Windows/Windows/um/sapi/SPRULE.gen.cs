// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPRULE.xml' path='doc/member[@name="SPRULE"]/*'/>
public unsafe partial struct SPRULE
{
    /// <include file='SPRULE.xml' path='doc/member[@name="SPRULE.pszRuleName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pszRuleName;
    /// <include file='SPRULE.xml' path='doc/member[@name="SPRULE.ulRuleId"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulRuleId;
    /// <include file='SPRULE.xml' path='doc/member[@name="SPRULE.dwAttributes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAttributes;
}