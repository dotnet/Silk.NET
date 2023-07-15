// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TAPE_STATISTICS.xml' path='doc/member[@name="TAPE_STATISTICS"]/*'/>
public partial struct TAPE_STATISTICS
{
    /// <include file='TAPE_STATISTICS.xml' path='doc/member[@name="TAPE_STATISTICS.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='TAPE_STATISTICS.xml' path='doc/member[@name="TAPE_STATISTICS.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='TAPE_STATISTICS.xml' path='doc/member[@name="TAPE_STATISTICS.RecoveredWrites"]/*'/>
    public LARGE_INTEGER RecoveredWrites;
    /// <include file='TAPE_STATISTICS.xml' path='doc/member[@name="TAPE_STATISTICS.UnrecoveredWrites"]/*'/>
    public LARGE_INTEGER UnrecoveredWrites;
    /// <include file='TAPE_STATISTICS.xml' path='doc/member[@name="TAPE_STATISTICS.RecoveredReads"]/*'/>
    public LARGE_INTEGER RecoveredReads;
    /// <include file='TAPE_STATISTICS.xml' path='doc/member[@name="TAPE_STATISTICS.UnrecoveredReads"]/*'/>
    public LARGE_INTEGER UnrecoveredReads;
    /// <include file='TAPE_STATISTICS.xml' path='doc/member[@name="TAPE_STATISTICS.CompressionRatioReads"]/*'/>
    public byte CompressionRatioReads;
    /// <include file='TAPE_STATISTICS.xml' path='doc/member[@name="TAPE_STATISTICS.CompressionRatioWrites"]/*'/>
    public byte CompressionRatioWrites;
}