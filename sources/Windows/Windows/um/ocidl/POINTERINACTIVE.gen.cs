// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POINTERINACTIVE.xml' path='doc/member[@name="POINTERINACTIVE"]/*' />
public enum POINTERINACTIVE
{
    /// <include file='POINTERINACTIVE.xml' path='doc/member[@name="POINTERINACTIVE.POINTERINACTIVE_ACTIVATEONENTRY"]/*' />
    POINTERINACTIVE_ACTIVATEONENTRY = 1,

    /// <include file='POINTERINACTIVE.xml' path='doc/member[@name="POINTERINACTIVE.POINTERINACTIVE_DEACTIVATEONLEAVE"]/*' />
    POINTERINACTIVE_DEACTIVATEONLEAVE = 2,

    /// <include file='POINTERINACTIVE.xml' path='doc/member[@name="POINTERINACTIVE.POINTERINACTIVE_ACTIVATEONDRAG"]/*' />
    POINTERINACTIVE_ACTIVATEONDRAG = 4,
}
