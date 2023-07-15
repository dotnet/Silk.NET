// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OLECMDEXECOPT.xml' path='doc/member[@name="OLECMDEXECOPT"]/*'/>
public enum OLECMDEXECOPT
{
    /// <include file='OLECMDEXECOPT.xml' path='doc/member[@name="OLECMDEXECOPT.OLECMDEXECOPT_DODEFAULT"]/*'/>
    OLECMDEXECOPT_DODEFAULT = 0,
    /// <include file='OLECMDEXECOPT.xml' path='doc/member[@name="OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER"]/*'/>
    OLECMDEXECOPT_PROMPTUSER = 1,
    /// <include file='OLECMDEXECOPT.xml' path='doc/member[@name="OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER"]/*'/>
    OLECMDEXECOPT_DONTPROMPTUSER = 2,
    /// <include file='OLECMDEXECOPT.xml' path='doc/member[@name="OLECMDEXECOPT.OLECMDEXECOPT_SHOWHELP"]/*'/>
    OLECMDEXECOPT_SHOWHELP = 3,
}