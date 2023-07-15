// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DEVICE_DATA_SET_SCRUB_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_SCRUB_OUTPUT"]/*'/>
public partial struct DEVICE_DATA_SET_SCRUB_OUTPUT
{
    /// <include file='DEVICE_DATA_SET_SCRUB_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_SCRUB_OUTPUT.BytesProcessed"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BytesProcessed;
    /// <include file='DEVICE_DATA_SET_SCRUB_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_SCRUB_OUTPUT.BytesRepaired"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BytesRepaired;
    /// <include file='DEVICE_DATA_SET_SCRUB_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_SCRUB_OUTPUT.BytesFailed"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BytesFailed;
}