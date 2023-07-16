// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_SHADER_DEBUG_FILE_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_FILE_INFO"]/*'/>
public partial struct D3D10_SHADER_DEBUG_FILE_INFO
{
    /// <include file='D3D10_SHADER_DEBUG_FILE_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_FILE_INFO.FileName"]/*'/>
    public uint FileName;
    /// <include file='D3D10_SHADER_DEBUG_FILE_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_FILE_INFO.FileNameLen"]/*'/>
    public uint FileNameLen;
    /// <include file='D3D10_SHADER_DEBUG_FILE_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_FILE_INFO.FileData"]/*'/>
    public uint FileData;
    /// <include file='D3D10_SHADER_DEBUG_FILE_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_FILE_INFO.FileLen"]/*'/>
    public uint FileLen;
}