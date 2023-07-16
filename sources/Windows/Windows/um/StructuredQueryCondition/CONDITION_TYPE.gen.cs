// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CONDITION_TYPE.xml' path='doc/member[@name="CONDITION_TYPE"]/*'/>
public enum CONDITION_TYPE
{
    /// <include file='CONDITION_TYPE.xml' path='doc/member[@name="CONDITION_TYPE.CT_AND_CONDITION"]/*'/>
    CT_AND_CONDITION = 0,
    /// <include file='CONDITION_TYPE.xml' path='doc/member[@name="CONDITION_TYPE.CT_OR_CONDITION"]/*'/>
    CT_OR_CONDITION = (CT_AND_CONDITION + 1),
    /// <include file='CONDITION_TYPE.xml' path='doc/member[@name="CONDITION_TYPE.CT_NOT_CONDITION"]/*'/>
    CT_NOT_CONDITION = (CT_OR_CONDITION + 1),
    /// <include file='CONDITION_TYPE.xml' path='doc/member[@name="CONDITION_TYPE.CT_LEAF_CONDITION"]/*'/>
    CT_LEAF_CONDITION = (CT_NOT_CONDITION + 1),
}