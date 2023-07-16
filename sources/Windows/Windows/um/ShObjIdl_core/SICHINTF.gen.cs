// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SICHINTF.xml' path='doc/member[@name="SICHINTF"]/*'/>
public enum SICHINTF
{
    /// <include file='SICHINTF.xml' path='doc/member[@name="SICHINTF.SICHINT_DISPLAY"]/*'/>
    SICHINT_DISPLAY = 0,
    /// <include file='SICHINTF.xml' path='doc/member[@name="SICHINTF.SICHINT_ALLFIELDS"]/*'/>
    SICHINT_ALLFIELDS = unchecked((int)(0x80000000)),
    /// <include file='SICHINTF.xml' path='doc/member[@name="SICHINTF.SICHINT_CANONICAL"]/*'/>
    SICHINT_CANONICAL = 0x10000000,
    /// <include file='SICHINTF.xml' path='doc/member[@name="SICHINTF.SICHINT_TEST_FILESYSPATH_IF_NOT_EQUAL"]/*'/>
    SICHINT_TEST_FILESYSPATH_IF_NOT_EQUAL = 0x20000000,
}