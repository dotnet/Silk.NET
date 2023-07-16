// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='INVOKEKIND.xml' path='doc/member[@name="INVOKEKIND"]/*'/>
public enum INVOKEKIND
{
    /// <include file='INVOKEKIND.xml' path='doc/member[@name="INVOKEKIND.INVOKE_FUNC"]/*'/>
    INVOKE_FUNC = 1,
    /// <include file='INVOKEKIND.xml' path='doc/member[@name="INVOKEKIND.INVOKE_PROPERTYGET"]/*'/>
    INVOKE_PROPERTYGET = 2,
    /// <include file='INVOKEKIND.xml' path='doc/member[@name="INVOKEKIND.INVOKE_PROPERTYPUT"]/*'/>
    INVOKE_PROPERTYPUT = 4,
    /// <include file='INVOKEKIND.xml' path='doc/member[@name="INVOKEKIND.INVOKE_PROPERTYPUTREF"]/*'/>
    INVOKE_PROPERTYPUTREF = 8,
}