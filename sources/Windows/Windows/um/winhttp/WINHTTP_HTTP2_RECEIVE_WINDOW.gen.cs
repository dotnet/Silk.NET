// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINHTTP_HTTP2_RECEIVE_WINDOW.xml' path='doc/member[@name="WINHTTP_HTTP2_RECEIVE_WINDOW"]/*'/>
public partial struct WINHTTP_HTTP2_RECEIVE_WINDOW
{
    /// <include file='WINHTTP_HTTP2_RECEIVE_WINDOW.xml' path='doc/member[@name="WINHTTP_HTTP2_RECEIVE_WINDOW.ulStreamWindow"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulStreamWindow;
    /// <include file='WINHTTP_HTTP2_RECEIVE_WINDOW.xml' path='doc/member[@name="WINHTTP_HTTP2_RECEIVE_WINDOW.ulStreamWindowUpdateDelta"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulStreamWindowUpdateDelta;
}