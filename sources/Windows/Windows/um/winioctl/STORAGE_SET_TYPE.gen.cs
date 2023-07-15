// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_SET_TYPE.xml' path='doc/member[@name="STORAGE_SET_TYPE"]/*'/>
public enum STORAGE_SET_TYPE
{
    /// <include file='STORAGE_SET_TYPE.xml' path='doc/member[@name="STORAGE_SET_TYPE.PropertyStandardSet"]/*'/>
    PropertyStandardSet = 0,
    /// <include file='STORAGE_SET_TYPE.xml' path='doc/member[@name="STORAGE_SET_TYPE.PropertyExistsSet"]/*'/>
    PropertyExistsSet,
    /// <include file='STORAGE_SET_TYPE.xml' path='doc/member[@name="STORAGE_SET_TYPE.PropertySetMaxDefined"]/*'/>
    PropertySetMaxDefined,
}