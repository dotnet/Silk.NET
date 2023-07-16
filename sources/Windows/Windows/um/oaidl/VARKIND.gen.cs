// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='VARKIND.xml' path='doc/member[@name="VARKIND"]/*'/>
public enum VARKIND
{
    /// <include file='VARKIND.xml' path='doc/member[@name="VARKIND.VAR_PERINSTANCE"]/*'/>
    VAR_PERINSTANCE = 0,
    /// <include file='VARKIND.xml' path='doc/member[@name="VARKIND.VAR_STATIC"]/*'/>
    VAR_STATIC = (VAR_PERINSTANCE + 1),
    /// <include file='VARKIND.xml' path='doc/member[@name="VARKIND.VAR_CONST"]/*'/>
    VAR_CONST = (VAR_STATIC + 1),
    /// <include file='VARKIND.xml' path='doc/member[@name="VARKIND.VAR_DISPATCH"]/*'/>
    VAR_DISPATCH = (VAR_CONST + 1),
}