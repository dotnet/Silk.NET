// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WBEM_GENUS_TYPE.xml' path='doc/member[@name="WBEM_GENUS_TYPE"]/*'/>
public enum WBEM_GENUS_TYPE
{
    /// <include file='WBEM_GENUS_TYPE.xml' path='doc/member[@name="WBEM_GENUS_TYPE.WBEM_GENUS_CLASS"]/*'/>
    WBEM_GENUS_CLASS = 1,
    /// <include file='WBEM_GENUS_TYPE.xml' path='doc/member[@name="WBEM_GENUS_TYPE.WBEM_GENUS_INSTANCE"]/*'/>
    WBEM_GENUS_INSTANCE = 2,
}