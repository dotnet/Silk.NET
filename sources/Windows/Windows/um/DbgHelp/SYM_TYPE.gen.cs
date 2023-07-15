// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYM_TYPE.xml' path='doc/member[@name="SYM_TYPE"]/*'/>
public enum SYM_TYPE
{
    /// <include file='SYM_TYPE.xml' path='doc/member[@name="SYM_TYPE.SymNone"]/*'/>
    SymNone = 0,
    /// <include file='SYM_TYPE.xml' path='doc/member[@name="SYM_TYPE.SymCoff"]/*'/>
    SymCoff,
    /// <include file='SYM_TYPE.xml' path='doc/member[@name="SYM_TYPE.SymCv"]/*'/>
    SymCv,
    /// <include file='SYM_TYPE.xml' path='doc/member[@name="SYM_TYPE.SymPdb"]/*'/>
    SymPdb,
    /// <include file='SYM_TYPE.xml' path='doc/member[@name="SYM_TYPE.SymExport"]/*'/>
    SymExport,
    /// <include file='SYM_TYPE.xml' path='doc/member[@name="SYM_TYPE.SymDeferred"]/*'/>
    SymDeferred,
    /// <include file='SYM_TYPE.xml' path='doc/member[@name="SYM_TYPE.SymSym"]/*'/>
    SymSym,
    /// <include file='SYM_TYPE.xml' path='doc/member[@name="SYM_TYPE.SymDia"]/*'/>
    SymDia,
    /// <include file='SYM_TYPE.xml' path='doc/member[@name="SYM_TYPE.SymVirtual"]/*'/>
    SymVirtual,
    /// <include file='SYM_TYPE.xml' path='doc/member[@name="SYM_TYPE.NumSymTypes"]/*'/>
    NumSymTypes,
}