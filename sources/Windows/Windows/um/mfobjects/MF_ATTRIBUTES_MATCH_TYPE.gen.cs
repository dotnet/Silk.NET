// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MF_ATTRIBUTES_MATCH_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTES_MATCH_TYPE"]/*'/>
public enum MF_ATTRIBUTES_MATCH_TYPE
{
    /// <include file='MF_ATTRIBUTES_MATCH_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTES_MATCH_TYPE.MF_ATTRIBUTES_MATCH_OUR_ITEMS"]/*'/>
    MF_ATTRIBUTES_MATCH_OUR_ITEMS = 0,
    /// <include file='MF_ATTRIBUTES_MATCH_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTES_MATCH_TYPE.MF_ATTRIBUTES_MATCH_THEIR_ITEMS"]/*'/>
    MF_ATTRIBUTES_MATCH_THEIR_ITEMS = 1,
    /// <include file='MF_ATTRIBUTES_MATCH_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTES_MATCH_TYPE.MF_ATTRIBUTES_MATCH_ALL_ITEMS"]/*'/>
    MF_ATTRIBUTES_MATCH_ALL_ITEMS = 2,
    /// <include file='MF_ATTRIBUTES_MATCH_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTES_MATCH_TYPE.MF_ATTRIBUTES_MATCH_INTERSECTION"]/*'/>
    MF_ATTRIBUTES_MATCH_INTERSECTION = 3,
    /// <include file='MF_ATTRIBUTES_MATCH_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTES_MATCH_TYPE.MF_ATTRIBUTES_MATCH_SMALLER"]/*'/>
    MF_ATTRIBUTES_MATCH_SMALLER = 4,
}