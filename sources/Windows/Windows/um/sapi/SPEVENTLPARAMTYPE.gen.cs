// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPEVENTLPARAMTYPE.xml' path='doc/member[@name="SPEVENTLPARAMTYPE"]/*'/>
public enum SPEVENTLPARAMTYPE
{
    /// <include file='SPEVENTLPARAMTYPE.xml' path='doc/member[@name="SPEVENTLPARAMTYPE.SPET_LPARAM_IS_UNDEFINED"]/*'/>
    SPET_LPARAM_IS_UNDEFINED = 0,
    /// <include file='SPEVENTLPARAMTYPE.xml' path='doc/member[@name="SPEVENTLPARAMTYPE.SPET_LPARAM_IS_TOKEN"]/*'/>
    SPET_LPARAM_IS_TOKEN = (SPET_LPARAM_IS_UNDEFINED + 1),
    /// <include file='SPEVENTLPARAMTYPE.xml' path='doc/member[@name="SPEVENTLPARAMTYPE.SPET_LPARAM_IS_OBJECT"]/*'/>
    SPET_LPARAM_IS_OBJECT = (SPET_LPARAM_IS_TOKEN + 1),
    /// <include file='SPEVENTLPARAMTYPE.xml' path='doc/member[@name="SPEVENTLPARAMTYPE.SPET_LPARAM_IS_POINTER"]/*'/>
    SPET_LPARAM_IS_POINTER = (SPET_LPARAM_IS_OBJECT + 1),
    /// <include file='SPEVENTLPARAMTYPE.xml' path='doc/member[@name="SPEVENTLPARAMTYPE.SPET_LPARAM_IS_STRING"]/*'/>
    SPET_LPARAM_IS_STRING = (SPET_LPARAM_IS_POINTER + 1),
}