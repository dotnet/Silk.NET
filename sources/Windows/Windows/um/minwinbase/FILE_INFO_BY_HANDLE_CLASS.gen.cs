// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS"]/*'/>
public enum FILE_INFO_BY_HANDLE_CLASS
{
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileBasicInfo"]/*'/>
    FileBasicInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileStandardInfo"]/*'/>
    FileStandardInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileNameInfo"]/*'/>
    FileNameInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileRenameInfo"]/*'/>
    FileRenameInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileDispositionInfo"]/*'/>
    FileDispositionInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileAllocationInfo"]/*'/>
    FileAllocationInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileEndOfFileInfo"]/*'/>
    FileEndOfFileInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileStreamInfo"]/*'/>
    FileStreamInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileCompressionInfo"]/*'/>
    FileCompressionInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileAttributeTagInfo"]/*'/>
    FileAttributeTagInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileIdBothDirectoryInfo"]/*'/>
    FileIdBothDirectoryInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileIdBothDirectoryRestartInfo"]/*'/>
    FileIdBothDirectoryRestartInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileIoPriorityHintInfo"]/*'/>
    FileIoPriorityHintInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileRemoteProtocolInfo"]/*'/>
    FileRemoteProtocolInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileFullDirectoryInfo"]/*'/>
    FileFullDirectoryInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileFullDirectoryRestartInfo"]/*'/>
    FileFullDirectoryRestartInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileStorageInfo"]/*'/>
    FileStorageInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileAlignmentInfo"]/*'/>
    FileAlignmentInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileIdInfo"]/*'/>
    FileIdInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileIdExtdDirectoryInfo"]/*'/>
    FileIdExtdDirectoryInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileIdExtdDirectoryRestartInfo"]/*'/>
    FileIdExtdDirectoryRestartInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileDispositionInfoEx"]/*'/>
    FileDispositionInfoEx,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileRenameInfoEx"]/*'/>
    FileRenameInfoEx,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileCaseSensitiveInfo"]/*'/>
    FileCaseSensitiveInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.FileNormalizedNameInfo"]/*'/>
    FileNormalizedNameInfo,
    /// <include file='FILE_INFO_BY_HANDLE_CLASS.xml' path='doc/member[@name="FILE_INFO_BY_HANDLE_CLASS.MaximumFileInfoByHandleClass"]/*'/>
    MaximumFileInfoByHandleClass,
}