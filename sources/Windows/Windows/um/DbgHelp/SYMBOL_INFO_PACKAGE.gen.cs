// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYMBOL_INFO_PACKAGE.xml' path='doc/member[@name="SYMBOL_INFO_PACKAGE"]/*'/>
public unsafe partial struct SYMBOL_INFO_PACKAGE
{
    /// <include file='SYMBOL_INFO_PACKAGE.xml' path='doc/member[@name="SYMBOL_INFO_PACKAGE.si"]/*'/>
    public SYMBOL_INFO si;
    /// <include file='SYMBOL_INFO_PACKAGE.xml' path='doc/member[@name="SYMBOL_INFO_PACKAGE.name"]/*'/>
    [NativeTypeName("CHAR[2001]")]
    public fixed sbyte name[2001];
}