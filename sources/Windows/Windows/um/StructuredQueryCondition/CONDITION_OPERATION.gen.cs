// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION"]/*' />
public enum CONDITION_OPERATION
{
    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_IMPLICIT"]/*' />
    COP_IMPLICIT = 0,

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_EQUAL"]/*' />
    COP_EQUAL = (COP_IMPLICIT + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_NOTEQUAL"]/*' />
    COP_NOTEQUAL = (COP_EQUAL + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_LESSTHAN"]/*' />
    COP_LESSTHAN = (COP_NOTEQUAL + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_GREATERTHAN"]/*' />
    COP_GREATERTHAN = (COP_LESSTHAN + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_LESSTHANOREQUAL"]/*' />
    COP_LESSTHANOREQUAL = (COP_GREATERTHAN + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_GREATERTHANOREQUAL"]/*' />
    COP_GREATERTHANOREQUAL = (COP_LESSTHANOREQUAL + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_VALUE_STARTSWITH"]/*' />
    COP_VALUE_STARTSWITH = (COP_GREATERTHANOREQUAL + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_VALUE_ENDSWITH"]/*' />
    COP_VALUE_ENDSWITH = (COP_VALUE_STARTSWITH + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_VALUE_CONTAINS"]/*' />
    COP_VALUE_CONTAINS = (COP_VALUE_ENDSWITH + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_VALUE_NOTCONTAINS"]/*' />
    COP_VALUE_NOTCONTAINS = (COP_VALUE_CONTAINS + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_DOSWILDCARDS"]/*' />
    COP_DOSWILDCARDS = (COP_VALUE_NOTCONTAINS + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_WORD_EQUAL"]/*' />
    COP_WORD_EQUAL = (COP_DOSWILDCARDS + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_WORD_STARTSWITH"]/*' />
    COP_WORD_STARTSWITH = (COP_WORD_EQUAL + 1),

    /// <include file='CONDITION_OPERATION.xml' path='doc/member[@name="CONDITION_OPERATION.COP_APPLICATION_SPECIFIC"]/*' />
    COP_APPLICATION_SPECIFIC = (COP_WORD_STARTSWITH + 1),
}
