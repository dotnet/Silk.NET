// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='htmlMediaNetworkState.xml' path='doc/member[@name="htmlMediaNetworkState"]/*'/>
public enum htmlMediaNetworkState
{
    /// <include file='htmlMediaNetworkState.xml' path='doc/member[@name="htmlMediaNetworkState.htmlMediaNetworkStateEmpty"]/*'/>
    htmlMediaNetworkStateEmpty = 0,
    /// <include file='htmlMediaNetworkState.xml' path='doc/member[@name="htmlMediaNetworkState.htmlMediaNetworkStateIdle"]/*'/>
    htmlMediaNetworkStateIdle = 1,
    /// <include file='htmlMediaNetworkState.xml' path='doc/member[@name="htmlMediaNetworkState.htmlMediaNetworkStateLoading"]/*'/>
    htmlMediaNetworkStateLoading = 2,
    /// <include file='htmlMediaNetworkState.xml' path='doc/member[@name="htmlMediaNetworkState.htmlMediaNetworkStateNoSource"]/*'/>
    htmlMediaNetworkStateNoSource = 3,
    /// <include file='htmlMediaNetworkState.xml' path='doc/member[@name="htmlMediaNetworkState.htmlMediaNetworkState_Max"]/*'/>
    htmlMediaNetworkState_Max = 2147483647,
}