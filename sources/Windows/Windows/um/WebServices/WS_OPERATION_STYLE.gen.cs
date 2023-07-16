// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_OPERATION_STYLE.xml' path='doc/member[@name="WS_OPERATION_STYLE"]/*'/>
public enum WS_OPERATION_STYLE
{
    /// <include file='WS_OPERATION_STYLE.xml' path='doc/member[@name="WS_OPERATION_STYLE.WS_NON_RPC_LITERAL_OPERATION"]/*'/>
    WS_NON_RPC_LITERAL_OPERATION = 0,
    /// <include file='WS_OPERATION_STYLE.xml' path='doc/member[@name="WS_OPERATION_STYLE.WS_RPC_LITERAL_OPERATION"]/*'/>
    WS_RPC_LITERAL_OPERATION = 1,
}