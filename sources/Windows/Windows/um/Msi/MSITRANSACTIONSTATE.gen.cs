// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MSITRANSACTIONSTATE.xml' path='doc/member[@name="MSITRANSACTIONSTATE"]/*'/>
public enum MSITRANSACTIONSTATE
{
    /// <include file='MSITRANSACTIONSTATE.xml' path='doc/member[@name="MSITRANSACTIONSTATE.MSITRANSACTIONSTATE_ROLLBACK"]/*'/>
    MSITRANSACTIONSTATE_ROLLBACK = 0x00000000,
    /// <include file='MSITRANSACTIONSTATE.xml' path='doc/member[@name="MSITRANSACTIONSTATE.MSITRANSACTIONSTATE_COMMIT"]/*'/>
    MSITRANSACTIONSTATE_COMMIT = 0x00000001,
}