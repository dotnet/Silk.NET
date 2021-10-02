// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_MESSAGE_ID")]
    public enum MessageID : int
    {
        [NativeName("Name", "D3D11_MESSAGE_ID_UNKNOWN")]
        MessageIDUnknown = 0x0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_HAZARD")]
        MessageIDDeviceIasetvertexbuffersHazard = 0x1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_HAZARD")]
        MessageIDDeviceIasetindexbufferHazard = 0x2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_HAZARD")]
        MessageIDDeviceVssetshaderresourcesHazard = 0x3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_HAZARD")]
        MessageIDDeviceVssetconstantbuffersHazard = 0x4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_HAZARD")]
        MessageIDDeviceGssetshaderresourcesHazard = 0x5,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_HAZARD")]
        MessageIDDeviceGssetconstantbuffersHazard = 0x6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_HAZARD")]
        MessageIDDevicePssetshaderresourcesHazard = 0x7,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_HAZARD")]
        MessageIDDevicePssetconstantbuffersHazard = 0x8,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETS_HAZARD")]
        MessageIDDeviceOmsetrendertargetsHazard = 0x9,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SOSETTARGETS_HAZARD")]
        MessageIDDeviceSosettargetsHazard = 0xA,
        [NativeName("Name", "D3D11_MESSAGE_ID_STRING_FROM_APPLICATION")]
        MessageIDStringFromApplication = 0xB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_THIS")]
        MessageIDCorruptedThis = 0xC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER1")]
        MessageIDCorruptedParameter1 = 0xD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER2")]
        MessageIDCorruptedParameter2 = 0xE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER3")]
        MessageIDCorruptedParameter3 = 0xF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER4")]
        MessageIDCorruptedParameter4 = 0x10,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER5")]
        MessageIDCorruptedParameter5 = 0x11,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER6")]
        MessageIDCorruptedParameter6 = 0x12,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER7")]
        MessageIDCorruptedParameter7 = 0x13,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER8")]
        MessageIDCorruptedParameter8 = 0x14,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER9")]
        MessageIDCorruptedParameter9 = 0x15,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER10")]
        MessageIDCorruptedParameter10 = 0x16,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER11")]
        MessageIDCorruptedParameter11 = 0x17,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER12")]
        MessageIDCorruptedParameter12 = 0x18,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER13")]
        MessageIDCorruptedParameter13 = 0x19,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER14")]
        MessageIDCorruptedParameter14 = 0x1A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_PARAMETER15")]
        MessageIDCorruptedParameter15 = 0x1B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CORRUPTED_MULTITHREADING")]
        MessageIDCorruptedMultithreading = 0x1C,
        [NativeName("Name", "D3D11_MESSAGE_ID_MESSAGE_REPORTING_OUTOFMEMORY")]
        MessageIDMessageReportingOutofmemory = 0x1D,
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETINPUTLAYOUT_UNBINDDELETINGOBJECT")]
        MessageIDIasetinputlayoutUnbinddeletingobject = 0x1E,
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDIasetvertexbuffersUnbinddeletingobject = 0x1F,
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETINDEXBUFFER_UNBINDDELETINGOBJECT")]
        MessageIDIasetindexbufferUnbinddeletingobject = 0x20,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSHADER_UNBINDDELETINGOBJECT")]
        MessageIDVssetshaderUnbinddeletingobject = 0x21,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        MessageIDVssetshaderresourcesUnbinddeletingobject = 0x22,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDVssetconstantbuffersUnbinddeletingobject = 0x23,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        MessageIDVssetsamplersUnbinddeletingobject = 0x24,
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETSHADER_UNBINDDELETINGOBJECT")]
        MessageIDGssetshaderUnbinddeletingobject = 0x25,
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        MessageIDGssetshaderresourcesUnbinddeletingobject = 0x26,
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDGssetconstantbuffersUnbinddeletingobject = 0x27,
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        MessageIDGssetsamplersUnbinddeletingobject = 0x28,
        [NativeName("Name", "D3D11_MESSAGE_ID_SOSETTARGETS_UNBINDDELETINGOBJECT")]
        MessageIDSosettargetsUnbinddeletingobject = 0x29,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETSHADER_UNBINDDELETINGOBJECT")]
        MessageIDPssetshaderUnbinddeletingobject = 0x2A,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        MessageIDPssetshaderresourcesUnbinddeletingobject = 0x2B,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDPssetconstantbuffersUnbinddeletingobject = 0x2C,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        MessageIDPssetsamplersUnbinddeletingobject = 0x2D,
        [NativeName("Name", "D3D11_MESSAGE_ID_RSSETSTATE_UNBINDDELETINGOBJECT")]
        MessageIDRssetstateUnbinddeletingobject = 0x2E,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETBLENDSTATE_UNBINDDELETINGOBJECT")]
        MessageIDOmsetblendstateUnbinddeletingobject = 0x2F,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETDEPTHSTENCILSTATE_UNBINDDELETINGOBJECT")]
        MessageIDOmsetdepthstencilstateUnbinddeletingobject = 0x30,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_UNBINDDELETINGOBJECT")]
        MessageIDOmsetrendertargetsUnbinddeletingobject = 0x31,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPREDICATION_UNBINDDELETINGOBJECT")]
        MessageIDSetpredicationUnbinddeletingobject = 0x32,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETPRIVATEDATA_MOREDATA")]
        MessageIDGetprivatedataMoredata = 0x33,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDFREEDATA")]
        MessageIDSetprivatedataInvalidfreedata = 0x34,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDIUNKNOWN")]
        MessageIDSetprivatedataInvalidiunknown = 0x35,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_INVALIDFLAGS")]
        MessageIDSetprivatedataInvalidflags = 0x36,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS")]
        MessageIDSetprivatedataChangingparams = 0x37,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPRIVATEDATA_OUTOFMEMORY")]
        MessageIDSetprivatedataOutofmemory = 0x38,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDFORMAT")]
        MessageIDCreatebufferUnrecognizedformat = 0x39,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDSAMPLES")]
        MessageIDCreatebufferInvalidsamples = 0x3A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDUSAGE")]
        MessageIDCreatebufferUnrecognizedusage = 0x3B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDBINDFLAGS")]
        MessageIDCreatebufferUnrecognizedbindflags = 0x3C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDCPUACCESSFLAGS")]
        MessageIDCreatebufferUnrecognizedcpuaccessflags = 0x3D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_UNRECOGNIZEDMISCFLAGS")]
        MessageIDCreatebufferUnrecognizedmiscflags = 0x3E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDCPUACCESSFLAGS")]
        MessageIDCreatebufferInvalidcpuaccessflags = 0x3F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDBINDFLAGS")]
        MessageIDCreatebufferInvalidbindflags = 0x40,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDINITIALDATA")]
        MessageIDCreatebufferInvalidinitialdata = 0x41,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDDIMENSIONS")]
        MessageIDCreatebufferInvaliddimensions = 0x42,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDMIPLEVELS")]
        MessageIDCreatebufferInvalidmiplevels = 0x43,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDMISCFLAGS")]
        MessageIDCreatebufferInvalidmiscflags = 0x44,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDARG_RETURN")]
        MessageIDCreatebufferInvalidargReturn = 0x45,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_OUTOFMEMORY_RETURN")]
        MessageIDCreatebufferOutofmemoryReturn = 0x46,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_NULLDESC")]
        MessageIDCreatebufferNulldesc = 0x47,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDCONSTANTBUFFERBINDINGS")]
        MessageIDCreatebufferInvalidconstantbufferbindings = 0x48,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_LARGEALLOCATION")]
        MessageIDCreatebufferLargeallocation = 0x49,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDFORMAT")]
        MessageIDCreatetexture1DUnrecognizedformat = 0x4A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNSUPPORTEDFORMAT")]
        MessageIDCreatetexture1DUnsupportedformat = 0x4B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDSAMPLES")]
        MessageIDCreatetexture1DInvalidsamples = 0x4C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDUSAGE")]
        MessageIDCreatetexture1DUnrecognizedusage = 0x4D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDBINDFLAGS")]
        MessageIDCreatetexture1DUnrecognizedbindflags = 0x4E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDCPUACCESSFLAGS")]
        MessageIDCreatetexture1DUnrecognizedcpuaccessflags = 0x4F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_UNRECOGNIZEDMISCFLAGS")]
        MessageIDCreatetexture1DUnrecognizedmiscflags = 0x50,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDCPUACCESSFLAGS")]
        MessageIDCreatetexture1DInvalidcpuaccessflags = 0x51,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDBINDFLAGS")]
        MessageIDCreatetexture1DInvalidbindflags = 0x52,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDINITIALDATA")]
        MessageIDCreatetexture1DInvalidinitialdata = 0x53,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDDIMENSIONS")]
        MessageIDCreatetexture1DInvaliddimensions = 0x54,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDMIPLEVELS")]
        MessageIDCreatetexture1DInvalidmiplevels = 0x55,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDMISCFLAGS")]
        MessageIDCreatetexture1DInvalidmiscflags = 0x56,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDARG_RETURN")]
        MessageIDCreatetexture1DInvalidargReturn = 0x57,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_OUTOFMEMORY_RETURN")]
        MessageIDCreatetexture1DOutofmemoryReturn = 0x58,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_NULLDESC")]
        MessageIDCreatetexture1DNulldesc = 0x59,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_LARGEALLOCATION")]
        MessageIDCreatetexture1DLargeallocation = 0x5A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDFORMAT")]
        MessageIDCreatetexture2DUnrecognizedformat = 0x5B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNSUPPORTEDFORMAT")]
        MessageIDCreatetexture2DUnsupportedformat = 0x5C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDSAMPLES")]
        MessageIDCreatetexture2DInvalidsamples = 0x5D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDUSAGE")]
        MessageIDCreatetexture2DUnrecognizedusage = 0x5E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDBINDFLAGS")]
        MessageIDCreatetexture2DUnrecognizedbindflags = 0x5F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDCPUACCESSFLAGS")]
        MessageIDCreatetexture2DUnrecognizedcpuaccessflags = 0x60,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_UNRECOGNIZEDMISCFLAGS")]
        MessageIDCreatetexture2DUnrecognizedmiscflags = 0x61,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDCPUACCESSFLAGS")]
        MessageIDCreatetexture2DInvalidcpuaccessflags = 0x62,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDBINDFLAGS")]
        MessageIDCreatetexture2DInvalidbindflags = 0x63,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDINITIALDATA")]
        MessageIDCreatetexture2DInvalidinitialdata = 0x64,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDDIMENSIONS")]
        MessageIDCreatetexture2DInvaliddimensions = 0x65,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDMIPLEVELS")]
        MessageIDCreatetexture2DInvalidmiplevels = 0x66,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDMISCFLAGS")]
        MessageIDCreatetexture2DInvalidmiscflags = 0x67,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDARG_RETURN")]
        MessageIDCreatetexture2DInvalidargReturn = 0x68,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_OUTOFMEMORY_RETURN")]
        MessageIDCreatetexture2DOutofmemoryReturn = 0x69,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_NULLDESC")]
        MessageIDCreatetexture2DNulldesc = 0x6A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_LARGEALLOCATION")]
        MessageIDCreatetexture2DLargeallocation = 0x6B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDFORMAT")]
        MessageIDCreatetexture3DUnrecognizedformat = 0x6C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNSUPPORTEDFORMAT")]
        MessageIDCreatetexture3DUnsupportedformat = 0x6D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDSAMPLES")]
        MessageIDCreatetexture3DInvalidsamples = 0x6E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDUSAGE")]
        MessageIDCreatetexture3DUnrecognizedusage = 0x6F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDBINDFLAGS")]
        MessageIDCreatetexture3DUnrecognizedbindflags = 0x70,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDCPUACCESSFLAGS")]
        MessageIDCreatetexture3DUnrecognizedcpuaccessflags = 0x71,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_UNRECOGNIZEDMISCFLAGS")]
        MessageIDCreatetexture3DUnrecognizedmiscflags = 0x72,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDCPUACCESSFLAGS")]
        MessageIDCreatetexture3DInvalidcpuaccessflags = 0x73,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDBINDFLAGS")]
        MessageIDCreatetexture3DInvalidbindflags = 0x74,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDINITIALDATA")]
        MessageIDCreatetexture3DInvalidinitialdata = 0x75,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDDIMENSIONS")]
        MessageIDCreatetexture3DInvaliddimensions = 0x76,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDMIPLEVELS")]
        MessageIDCreatetexture3DInvalidmiplevels = 0x77,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDMISCFLAGS")]
        MessageIDCreatetexture3DInvalidmiscflags = 0x78,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_INVALIDARG_RETURN")]
        MessageIDCreatetexture3DInvalidargReturn = 0x79,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_OUTOFMEMORY_RETURN")]
        MessageIDCreatetexture3DOutofmemoryReturn = 0x7A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_NULLDESC")]
        MessageIDCreatetexture3DNulldesc = 0x7B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE3D_LARGEALLOCATION")]
        MessageIDCreatetexture3DLargeallocation = 0x7C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreateshaderresourceviewUnrecognizedformat = 0x7D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDESC")]
        MessageIDCreateshaderresourceviewInvaliddesc = 0x7E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFORMAT")]
        MessageIDCreateshaderresourceviewInvalidformat = 0x7F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDIMENSIONS")]
        MessageIDCreateshaderresourceviewInvaliddimensions = 0x80,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDRESOURCE")]
        MessageIDCreateshaderresourceviewInvalidresource = 0x81,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_TOOMANYOBJECTS")]
        MessageIDCreateshaderresourceviewToomanyobjects = 0x82,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDARG_RETURN")]
        MessageIDCreateshaderresourceviewInvalidargReturn = 0x83,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreateshaderresourceviewOutofmemoryReturn = 0x84,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreaterendertargetviewUnrecognizedformat = 0x85,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_UNSUPPORTEDFORMAT")]
        MessageIDCreaterendertargetviewUnsupportedformat = 0x86,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDESC")]
        MessageIDCreaterendertargetviewInvaliddesc = 0x87,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDFORMAT")]
        MessageIDCreaterendertargetviewInvalidformat = 0x88,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDIMENSIONS")]
        MessageIDCreaterendertargetviewInvaliddimensions = 0x89,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDRESOURCE")]
        MessageIDCreaterendertargetviewInvalidresource = 0x8A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_TOOMANYOBJECTS")]
        MessageIDCreaterendertargetviewToomanyobjects = 0x8B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDARG_RETURN")]
        MessageIDCreaterendertargetviewInvalidargReturn = 0x8C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreaterendertargetviewOutofmemoryReturn = 0x8D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreatedepthstencilviewUnrecognizedformat = 0x8E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDESC")]
        MessageIDCreatedepthstencilviewInvaliddesc = 0x8F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFORMAT")]
        MessageIDCreatedepthstencilviewInvalidformat = 0x90,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDIMENSIONS")]
        MessageIDCreatedepthstencilviewInvaliddimensions = 0x91,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDRESOURCE")]
        MessageIDCreatedepthstencilviewInvalidresource = 0x92,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_TOOMANYOBJECTS")]
        MessageIDCreatedepthstencilviewToomanyobjects = 0x93,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDARG_RETURN")]
        MessageIDCreatedepthstencilviewInvalidargReturn = 0x94,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreatedepthstencilviewOutofmemoryReturn = 0x95,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_OUTOFMEMORY")]
        MessageIDCreateinputlayoutOutofmemory = 0x96,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TOOMANYELEMENTS")]
        MessageIDCreateinputlayoutToomanyelements = 0x97,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDFORMAT")]
        MessageIDCreateinputlayoutInvalidformat = 0x98,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INCOMPATIBLEFORMAT")]
        MessageIDCreateinputlayoutIncompatibleformat = 0x99,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOT")]
        MessageIDCreateinputlayoutInvalidslot = 0x9A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDINPUTSLOTCLASS")]
        MessageIDCreateinputlayoutInvalidinputslotclass = 0x9B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_STEPRATESLOTCLASSMISMATCH")]
        MessageIDCreateinputlayoutSteprateslotclassmismatch = 0x9C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOTCLASSCHANGE")]
        MessageIDCreateinputlayoutInvalidslotclasschange = 0x9D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSTEPRATECHANGE")]
        MessageIDCreateinputlayoutInvalidstepratechange = 0x9E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDALIGNMENT")]
        MessageIDCreateinputlayoutInvalidalignment = 0x9F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_DUPLICATESEMANTIC")]
        MessageIDCreateinputlayoutDuplicatesemantic = 0xA0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_UNPARSEABLEINPUTSIGNATURE")]
        MessageIDCreateinputlayoutUnparseableinputsignature = 0xA1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_NULLSEMANTIC")]
        MessageIDCreateinputlayoutNullsemantic = 0xA2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_MISSINGELEMENT")]
        MessageIDCreateinputlayoutMissingelement = 0xA3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_NULLDESC")]
        MessageIDCreateinputlayoutNulldesc = 0xA4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVERTEXSHADER_OUTOFMEMORY")]
        MessageIDCreatevertexshaderOutofmemory = 0xA5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatevertexshaderInvalidshaderbytecode = 0xA6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatevertexshaderInvalidshadertype = 0xA7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_OUTOFMEMORY")]
        MessageIDCreategeometryshaderOutofmemory = 0xA8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreategeometryshaderInvalidshaderbytecode = 0xA9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERTYPE")]
        MessageIDCreategeometryshaderInvalidshadertype = 0xAA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTOFMEMORY")]
        MessageIDCreategeometryshaderwithstreamoutputOutofmemory = 0xAB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERBYTECODE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidshaderbytecode = 0xAC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidshadertype = 0xAD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMENTRIES")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidnumentries = 0xAE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSTREAMSTRIDEUNUSED")]
        MessageIDCreategeometryshaderwithstreamoutputOutputstreamstrideunused = 0xAF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDDECL")]
        MessageIDCreategeometryshaderwithstreamoutputUnexpecteddecl = 0xB0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_EXPECTEDDECL")]
        MessageIDCreategeometryshaderwithstreamoutputExpecteddecl = 0xB1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSLOT0EXPECTED")]
        MessageIDCreategeometryshaderwithstreamoutputOutputslot0Expected = 0xB2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSLOT")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidoutputslot = 0xB3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_ONLYONEELEMENTPERSLOT")]
        MessageIDCreategeometryshaderwithstreamoutputOnlyoneelementperslot = 0xB4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCOMPONENTCOUNT")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidcomponentcount = 0xB5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTARTCOMPONENTANDCOMPONENTCOUNT")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidstartcomponentandcomponentcount = 0xB6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDGAPDEFINITION")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidgapdefinition = 0xB7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_REPEATEDOUTPUT")]
        MessageIDCreategeometryshaderwithstreamoutputRepeatedoutput = 0xB8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSTREAMSTRIDE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidoutputstreamstride = 0xB9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGSEMANTIC")]
        MessageIDCreategeometryshaderwithstreamoutputMissingsemantic = 0xBA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MASKMISMATCH")]
        MessageIDCreategeometryshaderwithstreamoutputMaskmismatch = 0xBB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_CANTHAVEONLYGAPS")]
        MessageIDCreategeometryshaderwithstreamoutputCanthaveonlygaps = 0xBC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DECLTOOCOMPLEX")]
        MessageIDCreategeometryshaderwithstreamoutputDecltoocomplex = 0xBD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGOUTPUTSIGNATURE")]
        MessageIDCreategeometryshaderwithstreamoutputMissingoutputsignature = 0xBE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPIXELSHADER_OUTOFMEMORY")]
        MessageIDCreatepixelshaderOutofmemory = 0xBF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatepixelshaderInvalidshaderbytecode = 0xC0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatepixelshaderInvalidshadertype = 0xC1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFILLMODE")]
        MessageIDCreaterasterizerstateInvalidfillmode = 0xC2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDCULLMODE")]
        MessageIDCreaterasterizerstateInvalidcullmode = 0xC3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDDEPTHBIASCLAMP")]
        MessageIDCreaterasterizerstateInvaliddepthbiasclamp = 0xC4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDSLOPESCALEDDEPTHBIAS")]
        MessageIDCreaterasterizerstateInvalidslopescaleddepthbias = 0xC5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_TOOMANYOBJECTS")]
        MessageIDCreaterasterizerstateToomanyobjects = 0xC6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_NULLDESC")]
        MessageIDCreaterasterizerstateNulldesc = 0xC7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHWRITEMASK")]
        MessageIDCreatedepthstencilstateInvaliddepthwritemask = 0xC8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHFUNC")]
        MessageIDCreatedepthstencilstateInvaliddepthfunc = 0xC9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFAILOP")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilfailop = 0xCA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILZFAILOP")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilzfailop = 0xCB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILPASSOP")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilpassop = 0xCC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFUNC")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilfunc = 0xCD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFAILOP")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilfailop = 0xCE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILZFAILOP")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilzfailop = 0xCF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILPASSOP")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilpassop = 0xD0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFUNC")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilfunc = 0xD1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_TOOMANYOBJECTS")]
        MessageIDCreatedepthstencilstateToomanyobjects = 0xD2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_NULLDESC")]
        MessageIDCreatedepthstencilstateNulldesc = 0xD3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLEND")]
        MessageIDCreateblendstateInvalidsrcblend = 0xD4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLEND")]
        MessageIDCreateblendstateInvaliddestblend = 0xD5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOP")]
        MessageIDCreateblendstateInvalidblendop = 0xD6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLENDALPHA")]
        MessageIDCreateblendstateInvalidsrcblendalpha = 0xD7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLENDALPHA")]
        MessageIDCreateblendstateInvaliddestblendalpha = 0xD8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOPALPHA")]
        MessageIDCreateblendstateInvalidblendopalpha = 0xD9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDRENDERTARGETWRITEMASK")]
        MessageIDCreateblendstateInvalidrendertargetwritemask = 0xDA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_TOOMANYOBJECTS")]
        MessageIDCreateblendstateToomanyobjects = 0xDB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NULLDESC")]
        MessageIDCreateblendstateNulldesc = 0xDC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDFILTER")]
        MessageIDCreatesamplerstateInvalidfilter = 0xDD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSU")]
        MessageIDCreatesamplerstateInvalidaddressu = 0xDE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSV")]
        MessageIDCreatesamplerstateInvalidaddressv = 0xDF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDADDRESSW")]
        MessageIDCreatesamplerstateInvalidaddressw = 0xE0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMIPLODBIAS")]
        MessageIDCreatesamplerstateInvalidmiplodbias = 0xE1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXANISOTROPY")]
        MessageIDCreatesamplerstateInvalidmaxanisotropy = 0xE2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDCOMPARISONFUNC")]
        MessageIDCreatesamplerstateInvalidcomparisonfunc = 0xE3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMINLOD")]
        MessageIDCreatesamplerstateInvalidminlod = 0xE4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_INVALIDMAXLOD")]
        MessageIDCreatesamplerstateInvalidmaxlod = 0xE5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_TOOMANYOBJECTS")]
        MessageIDCreatesamplerstateToomanyobjects = 0xE6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NULLDESC")]
        MessageIDCreatesamplerstateNulldesc = 0xE7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDQUERY")]
        MessageIDCreatequeryorpredicateInvalidquery = 0xE8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDMISCFLAGS")]
        MessageIDCreatequeryorpredicateInvalidmiscflags = 0xE9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_UNEXPECTEDMISCFLAG")]
        MessageIDCreatequeryorpredicateUnexpectedmiscflag = 0xEA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_NULLDESC")]
        MessageIDCreatequeryorpredicateNulldesc = 0xEB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNRECOGNIZED")]
        MessageIDDeviceIasetprimitivetopologyTopologyUnrecognized = 0xEC,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNDEFINED")]
        MessageIDDeviceIasetprimitivetopologyTopologyUndefined = 0xED,
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_INVALIDBUFFER")]
        MessageIDIasetvertexbuffersInvalidbuffer = 0xEE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_OFFSET_TOO_LARGE")]
        MessageIDDeviceIasetvertexbuffersOffsetTooLarge = 0xEF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceIasetvertexbuffersBuffersEmpty = 0xF0,
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETINDEXBUFFER_INVALIDBUFFER")]
        MessageIDIasetindexbufferInvalidbuffer = 0xF1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_FORMAT_INVALID")]
        MessageIDDeviceIasetindexbufferFormatInvalid = 0xF2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_TOO_LARGE")]
        MessageIDDeviceIasetindexbufferOffsetTooLarge = 0xF3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETINDEXBUFFER_OFFSET_UNALIGNED")]
        MessageIDDeviceIasetindexbufferOffsetUnaligned = 0xF4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceVssetshaderresourcesViewsEmpty = 0xF5,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        MessageIDVssetconstantbuffersInvalidbuffer = 0xF6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceVssetconstantbuffersBuffersEmpty = 0xF7,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSSETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceVssetsamplersSamplersEmpty = 0xF8,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceGssetshaderresourcesViewsEmpty = 0xF9,
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        MessageIDGssetconstantbuffersInvalidbuffer = 0xFA,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceGssetconstantbuffersBuffersEmpty = 0xFB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSSETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceGssetsamplersSamplersEmpty = 0xFC,
        [NativeName("Name", "D3D11_MESSAGE_ID_SOSETTARGETS_INVALIDBUFFER")]
        MessageIDSosettargetsInvalidbuffer = 0xFD,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SOSETTARGETS_OFFSET_UNALIGNED")]
        MessageIDDeviceSosettargetsOffsetUnaligned = 0xFE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDevicePssetshaderresourcesViewsEmpty = 0xFF,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        MessageIDPssetconstantbuffersInvalidbuffer = 0x100,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDevicePssetconstantbuffersBuffersEmpty = 0x101,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSSETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDevicePssetsamplersSamplersEmpty = 0x102,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_INVALIDVIEWPORT")]
        MessageIDDeviceRssetviewportsInvalidviewport = 0x103,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_INVALIDSCISSOR")]
        MessageIDDeviceRssetscissorrectsInvalidscissor = 0x104,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARRENDERTARGETVIEW_DENORMFLUSH")]
        MessageIDClearrendertargetviewDenormflush = 0x105,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_DENORMFLUSH")]
        MessageIDCleardepthstencilviewDenormflush = 0x106,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_INVALID")]
        MessageIDCleardepthstencilviewInvalid = 0x107,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IAGETVERTEXBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceIagetvertexbuffersBuffersEmpty = 0x108,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSGETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceVsgetshaderresourcesViewsEmpty = 0x109,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceVsgetconstantbuffersBuffersEmpty = 0x10A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_VSGETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceVsgetsamplersSamplersEmpty = 0x10B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSGETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceGsgetshaderresourcesViewsEmpty = 0x10C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceGsgetconstantbuffersBuffersEmpty = 0x10D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GSGETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceGsgetsamplersSamplersEmpty = 0x10E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SOGETTARGETS_BUFFERS_EMPTY")]
        MessageIDDeviceSogettargetsBuffersEmpty = 0x10F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSGETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDevicePsgetshaderresourcesViewsEmpty = 0x110,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDevicePsgetconstantbuffersBuffersEmpty = 0x111,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_PSGETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDevicePsgetsamplersSamplersEmpty = 0x112,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSGETVIEWPORTS_VIEWPORTS_EMPTY")]
        MessageIDDeviceRsgetviewportsViewportsEmpty = 0x113,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSGETSCISSORRECTS_RECTS_EMPTY")]
        MessageIDDeviceRsgetscissorrectsRectsEmpty = 0x114,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GENERATEMIPS_RESOURCE_INVALID")]
        MessageIDDeviceGeneratemipsResourceInvalid = 0x115,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSUBRESOURCE")]
        MessageIDCopysubresourceregionInvaliddestinationsubresource = 0x116,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESUBRESOURCE")]
        MessageIDCopysubresourceregionInvalidsourcesubresource = 0x117,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCEBOX")]
        MessageIDCopysubresourceregionInvalidsourcebox = 0x118,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCE")]
        MessageIDCopysubresourceregionInvalidsource = 0x119,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDDESTINATIONSTATE")]
        MessageIDCopysubresourceregionInvaliddestinationstate = 0x11A,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_INVALIDSOURCESTATE")]
        MessageIDCopysubresourceregionInvalidsourcestate = 0x11B,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCE")]
        MessageIDCopyresourceInvalidsource = 0x11C,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDDESTINATIONSTATE")]
        MessageIDCopyresourceInvaliddestinationstate = 0x11D,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_INVALIDSOURCESTATE")]
        MessageIDCopyresourceInvalidsourcestate = 0x11E,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSUBRESOURCE")]
        MessageIDUpdatesubresourceInvaliddestinationsubresource = 0x11F,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONBOX")]
        MessageIDUpdatesubresourceInvaliddestinationbox = 0x120,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_INVALIDDESTINATIONSTATE")]
        MessageIDUpdatesubresourceInvaliddestinationstate = 0x121,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_INVALID")]
        MessageIDDeviceResolvesubresourceDestinationInvalid = 0x122,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_DESTINATION_SUBRESOURCE_INVALID")]
        MessageIDDeviceResolvesubresourceDestinationSubresourceInvalid = 0x123,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_INVALID")]
        MessageIDDeviceResolvesubresourceSourceInvalid = 0x124,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_SOURCE_SUBRESOURCE_INVALID")]
        MessageIDDeviceResolvesubresourceSourceSubresourceInvalid = 0x125,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RESOLVESUBRESOURCE_FORMAT_INVALID")]
        MessageIDDeviceResolvesubresourceFormatInvalid = 0x126,
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_MAP_INVALIDMAPTYPE")]
        MessageIDBufferMapInvalidmaptype = 0x127,
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_MAP_INVALIDFLAGS")]
        MessageIDBufferMapInvalidflags = 0x128,
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_MAP_ALREADYMAPPED")]
        MessageIDBufferMapAlreadymapped = 0x129,
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_MAP_DEVICEREMOVED_RETURN")]
        MessageIDBufferMapDeviceremovedReturn = 0x12A,
        [NativeName("Name", "D3D11_MESSAGE_ID_BUFFER_UNMAP_NOTMAPPED")]
        MessageIDBufferUnmapNotmapped = 0x12B,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDMAPTYPE")]
        MessageIDTexture1DMapInvalidmaptype = 0x12C,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDSUBRESOURCE")]
        MessageIDTexture1DMapInvalidsubresource = 0x12D,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_INVALIDFLAGS")]
        MessageIDTexture1DMapInvalidflags = 0x12E,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_ALREADYMAPPED")]
        MessageIDTexture1DMapAlreadymapped = 0x12F,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_MAP_DEVICEREMOVED_RETURN")]
        MessageIDTexture1DMapDeviceremovedReturn = 0x130,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_UNMAP_INVALIDSUBRESOURCE")]
        MessageIDTexture1DUnmapInvalidsubresource = 0x131,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE1D_UNMAP_NOTMAPPED")]
        MessageIDTexture1DUnmapNotmapped = 0x132,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDMAPTYPE")]
        MessageIDTexture2DMapInvalidmaptype = 0x133,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDSUBRESOURCE")]
        MessageIDTexture2DMapInvalidsubresource = 0x134,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_INVALIDFLAGS")]
        MessageIDTexture2DMapInvalidflags = 0x135,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_ALREADYMAPPED")]
        MessageIDTexture2DMapAlreadymapped = 0x136,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_MAP_DEVICEREMOVED_RETURN")]
        MessageIDTexture2DMapDeviceremovedReturn = 0x137,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_UNMAP_INVALIDSUBRESOURCE")]
        MessageIDTexture2DUnmapInvalidsubresource = 0x138,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE2D_UNMAP_NOTMAPPED")]
        MessageIDTexture2DUnmapNotmapped = 0x139,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDMAPTYPE")]
        MessageIDTexture3DMapInvalidmaptype = 0x13A,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDSUBRESOURCE")]
        MessageIDTexture3DMapInvalidsubresource = 0x13B,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_INVALIDFLAGS")]
        MessageIDTexture3DMapInvalidflags = 0x13C,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_ALREADYMAPPED")]
        MessageIDTexture3DMapAlreadymapped = 0x13D,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_MAP_DEVICEREMOVED_RETURN")]
        MessageIDTexture3DMapDeviceremovedReturn = 0x13E,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_UNMAP_INVALIDSUBRESOURCE")]
        MessageIDTexture3DUnmapInvalidsubresource = 0x13F,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXTURE3D_UNMAP_NOTMAPPED")]
        MessageIDTexture3DUnmapNotmapped = 0x140,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKFORMATSUPPORT_FORMAT_DEPRECATED")]
        MessageIDCheckformatsupportFormatDeprecated = 0x141,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKMULTISAMPLEQUALITYLEVELS_FORMAT_DEPRECATED")]
        MessageIDCheckmultisamplequalitylevelsFormatDeprecated = 0x142,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETEXCEPTIONMODE_UNRECOGNIZEDFLAGS")]
        MessageIDSetexceptionmodeUnrecognizedflags = 0x143,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETEXCEPTIONMODE_INVALIDARG_RETURN")]
        MessageIDSetexceptionmodeInvalidargReturn = 0x144,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETEXCEPTIONMODE_DEVICEREMOVED_RETURN")]
        MessageIDSetexceptionmodeDeviceremovedReturn = 0x145,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_SIMULATING_INFINITELY_FAST_HARDWARE")]
        MessageIDRefSimulatingInfinitelyFastHardware = 0x146,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_THREADING_MODE")]
        MessageIDRefThreadingMode = 0x147,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_UMDRIVER_EXCEPTION")]
        MessageIDRefUmdriverException = 0x148,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_KMDRIVER_EXCEPTION")]
        MessageIDRefKmdriverException = 0x149,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_HARDWARE_EXCEPTION")]
        MessageIDRefHardwareException = 0x14A,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_ACCESSING_INDEXABLE_TEMP_OUT_OF_RANGE")]
        MessageIDRefAccessingIndexableTempOutOfRange = 0x14B,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_PROBLEM_PARSING_SHADER")]
        MessageIDRefProblemParsingShader = 0x14C,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_OUT_OF_MEMORY")]
        MessageIDRefOutOfMemory = 0x14D,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_INFO")]
        MessageIDRefInfo = 0x14E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEXPOS_OVERFLOW")]
        MessageIDDeviceDrawVertexposOverflow = 0x14F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDEXED_INDEXPOS_OVERFLOW")]
        MessageIDDeviceDrawindexedIndexposOverflow = 0x150,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINSTANCED_VERTEXPOS_OVERFLOW")]
        MessageIDDeviceDrawinstancedVertexposOverflow = 0x151,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINSTANCED_INSTANCEPOS_OVERFLOW")]
        MessageIDDeviceDrawinstancedInstanceposOverflow = 0x152,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INSTANCEPOS_OVERFLOW")]
        MessageIDDeviceDrawindexedinstancedInstanceposOverflow = 0x153,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDEXEDINSTANCED_INDEXPOS_OVERFLOW")]
        MessageIDDeviceDrawindexedinstancedIndexposOverflow = 0x154,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_SHADER_NOT_SET")]
        MessageIDDeviceDrawVertexShaderNotSet = 0x155,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SEMANTICNAME_NOT_FOUND")]
        MessageIDDeviceShaderLinkageSemanticnameNotFound = 0x156,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERINDEX")]
        MessageIDDeviceShaderLinkageRegisterindex = 0x157,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_COMPONENTTYPE")]
        MessageIDDeviceShaderLinkageComponenttype = 0x158,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_REGISTERMASK")]
        MessageIDDeviceShaderLinkageRegistermask = 0x159,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_SYSTEMVALUE")]
        MessageIDDeviceShaderLinkageSystemvalue = 0x15A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_NEVERWRITTEN_ALWAYSREADS")]
        MessageIDDeviceShaderLinkageNeverwrittenAlwaysreads = 0x15B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_NOT_SET")]
        MessageIDDeviceDrawVertexBufferNotSet = 0x15C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INPUTLAYOUT_NOT_SET")]
        MessageIDDeviceDrawInputlayoutNotSet = 0x15D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_NOT_SET")]
        MessageIDDeviceDrawConstantBufferNotSet = 0x15E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_CONSTANT_BUFFER_TOO_SMALL")]
        MessageIDDeviceDrawConstantBufferTooSmall = 0x15F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLER_NOT_SET")]
        MessageIDDeviceDrawSamplerNotSet = 0x160,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SHADERRESOURCEVIEW_NOT_SET")]
        MessageIDDeviceDrawShaderresourceviewNotSet = 0x161,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VIEW_DIMENSION_MISMATCH")]
        MessageIDDeviceDrawViewDimensionMismatch = 0x162,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_STRIDE_TOO_SMALL")]
        MessageIDDeviceDrawVertexBufferStrideTooSmall = 0x163,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_BUFFER_TOO_SMALL")]
        MessageIDDeviceDrawVertexBufferTooSmall = 0x164,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_NOT_SET")]
        MessageIDDeviceDrawIndexBufferNotSet = 0x165,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_FORMAT_INVALID")]
        MessageIDDeviceDrawIndexBufferFormatInvalid = 0x166,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_BUFFER_TOO_SMALL")]
        MessageIDDeviceDrawIndexBufferTooSmall = 0x167,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_GS_INPUT_PRIMITIVE_MISMATCH")]
        MessageIDDeviceDrawGSInputPrimitiveMismatch = 0x168,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_RETURN_TYPE_MISMATCH")]
        MessageIDDeviceDrawResourceReturnTypeMismatch = 0x169,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_POSITION_NOT_PRESENT")]
        MessageIDDeviceDrawPositionNotPresent = 0x16A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_NOT_SET")]
        MessageIDDeviceDrawOutputStreamNotSet = 0x16B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_BOUND_RESOURCE_MAPPED")]
        MessageIDDeviceDrawBoundResourceMapped = 0x16C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_PRIMITIVETOPOLOGY")]
        MessageIDDeviceDrawInvalidPrimitivetopology = 0x16D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_OFFSET_UNALIGNED")]
        MessageIDDeviceDrawVertexOffsetUnaligned = 0x16E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VERTEX_STRIDE_UNALIGNED")]
        MessageIDDeviceDrawVertexStrideUnaligned = 0x16F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INDEX_OFFSET_UNALIGNED")]
        MessageIDDeviceDrawIndexOffsetUnaligned = 0x170,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OUTPUT_STREAM_OFFSET_UNALIGNED")]
        MessageIDDeviceDrawOutputStreamOffsetUnaligned = 0x171,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_LD_UNSUPPORTED")]
        MessageIDDeviceDrawResourceFormatLDUnsupported = 0x172,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_UNSUPPORTED")]
        MessageIDDeviceDrawResourceFormatSampleUnsupported = 0x173,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_SAMPLE_C_UNSUPPORTED")]
        MessageIDDeviceDrawResourceFormatSampleCUnsupported = 0x174,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_MULTISAMPLE_UNSUPPORTED")]
        MessageIDDeviceDrawResourceMultisampleUnsupported = 0x175,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SO_TARGETS_BOUND_WITHOUT_SOURCE")]
        MessageIDDeviceDrawSOTargetsBoundWithoutSource = 0x176,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SO_STRIDE_LARGER_THAN_BUFFER")]
        MessageIDDeviceDrawSOStrideLargerThanBuffer = 0x177,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OM_RENDER_TARGET_DOES_NOT_SUPPORT_BLENDING")]
        MessageIDDeviceDrawOMRenderTargetDoesNotSupportBlending = 0x178,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OM_DUAL_SOURCE_BLENDING_CAN_ONLY_HAVE_RENDER_TARGET_0")]
        MessageIDDeviceDrawOMDualSourceBlendingCanOnlyHaveRenderTarget0 = 0x179,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_AT_FAULT")]
        MessageIDDeviceRemovalProcessATFault = 0x17A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_POSSIBLY_AT_FAULT")]
        MessageIDDeviceRemovalProcessPossiblyATFault = 0x17B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_NOT_AT_FAULT")]
        MessageIDDeviceRemovalProcessNotATFault = 0x17C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_INVALIDARG_RETURN")]
        MessageIDDeviceOpenSharedResourceInvalidargReturn = 0x17D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_OUTOFMEMORY_RETURN")]
        MessageIDDeviceOpenSharedResourceOutofmemoryReturn = 0x17E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_BADINTERFACE_RETURN")]
        MessageIDDeviceOpenSharedResourceBadinterfaceReturn = 0x17F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_VIEWPORT_NOT_SET")]
        MessageIDDeviceDrawViewportNotSet = 0x180,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TRAILING_DIGIT_IN_SEMANTIC")]
        MessageIDCreateinputlayoutTrailingDigitInSemantic = 0x181,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_TRAILING_DIGIT_IN_SEMANTIC")]
        MessageIDCreategeometryshaderwithstreamoutputTrailingDigitInSemantic = 0x182,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_DENORMFLUSH")]
        MessageIDDeviceRssetviewportsDenormflush = 0x183,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_INVALIDVIEW")]
        MessageIDOmsetrendertargetsInvalidview = 0x184,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETTEXTFILTERSIZE_INVALIDDIMENSIONS")]
        MessageIDDeviceSettextfiltersizeInvaliddimensions = 0x185,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLER_MISMATCH")]
        MessageIDDeviceDrawSamplerMismatch = 0x186,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_TYPE_MISMATCH")]
        MessageIDCreateinputlayoutTypeMismatch = 0x187,
        [NativeName("Name", "D3D11_MESSAGE_ID_BLENDSTATE_GETDESC_LEGACY")]
        MessageIDBlendstateGetdescLegacy = 0x188,
        [NativeName("Name", "D3D11_MESSAGE_ID_SHADERRESOURCEVIEW_GETDESC_LEGACY")]
        MessageIDShaderresourceviewGetdescLegacy = 0x189,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERY_OUTOFMEMORY_RETURN")]
        MessageIDCreatequeryOutofmemoryReturn = 0x18A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPREDICATE_OUTOFMEMORY_RETURN")]
        MessageIDCreatepredicateOutofmemoryReturn = 0x18B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_OUTOFRANGE_COUNTER")]
        MessageIDCreatecounterOutofrangeCounter = 0x18C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_SIMULTANEOUS_ACTIVE_COUNTERS_EXHAUSTED")]
        MessageIDCreatecounterSimultaneousActiveCountersExhausted = 0x18D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER")]
        MessageIDCreatecounterUnsupportedWellknownCounter = 0x18E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_OUTOFMEMORY_RETURN")]
        MessageIDCreatecounterOutofmemoryReturn = 0x18F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_NONEXCLUSIVE_RETURN")]
        MessageIDCreatecounterNonexclusiveReturn = 0x190,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOUNTER_NULLDESC")]
        MessageIDCreatecounterNulldesc = 0x191,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCOUNTER_OUTOFRANGE_COUNTER")]
        MessageIDCheckcounterOutofrangeCounter = 0x192,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCOUNTER_UNSUPPORTED_WELLKNOWN_COUNTER")]
        MessageIDCheckcounterUnsupportedWellknownCounter = 0x193,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETPREDICATION_INVALID_PREDICATE_STATE")]
        MessageIDSetpredicationInvalidPredicateState = 0x194,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_BEGIN_UNSUPPORTED")]
        MessageIDQueryBeginUnsupported = 0x195,
        [NativeName("Name", "D3D11_MESSAGE_ID_PREDICATE_BEGIN_DURING_PREDICATION")]
        MessageIDPredicateBeginDuringPredication = 0x196,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_BEGIN_DUPLICATE")]
        MessageIDQueryBeginDuplicate = 0x197,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_BEGIN_ABANDONING_PREVIOUS_RESULTS")]
        MessageIDQueryBeginAbandoningPreviousResults = 0x198,
        [NativeName("Name", "D3D11_MESSAGE_ID_PREDICATE_END_DURING_PREDICATION")]
        MessageIDPredicateEndDuringPredication = 0x199,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_END_ABANDONING_PREVIOUS_RESULTS")]
        MessageIDQueryEndAbandoningPreviousResults = 0x19A,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_END_WITHOUT_BEGIN")]
        MessageIDQueryEndWithoutBegin = 0x19B,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_DATASIZE")]
        MessageIDQueryGetdataInvalidDatasize = 0x19C,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_FLAGS")]
        MessageIDQueryGetdataInvalidFlags = 0x19D,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERY_GETDATA_INVALID_CALL")]
        MessageIDQueryGetdataInvalidCall = 0x19E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_PS_OUTPUT_TYPE_MISMATCH")]
        MessageIDDeviceDrawPSOutputTypeMismatch = 0x19F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_FORMAT_GATHER_UNSUPPORTED")]
        MessageIDDeviceDrawResourceFormatGatherUnsupported = 0x1A0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_USE_OF_CENTER_MULTISAMPLE_PATTERN")]
        MessageIDDeviceDrawInvalidUseOfCenterMultisamplePattern = 0x1A1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_STRIDE_TOO_LARGE")]
        MessageIDDeviceIasetvertexbuffersStrideTooLarge = 0x1A2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETVERTEXBUFFERS_INVALIDRANGE")]
        MessageIDDeviceIasetvertexbuffersInvalidrange = 0x1A3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_EMPTY_LAYOUT")]
        MessageIDCreateinputlayoutEmptyLayout = 0x1A4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RESOURCE_SAMPLE_COUNT_MISMATCH")]
        MessageIDDeviceDrawResourceSampleCountMismatch = 0x1A5,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_OBJECT_SUMMARY")]
        MessageIDLiveObjectSummary = 0x1A6,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_BUFFER")]
        MessageIDLiveBuffer = 0x1A7,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE1D")]
        MessageIDLiveTexture1D = 0x1A8,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE2D")]
        MessageIDLiveTexture2D = 0x1A9,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE3D")]
        MessageIDLiveTexture3D = 0x1AA,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SHADERRESOURCEVIEW")]
        MessageIDLiveShaderresourceview = 0x1AB,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_RENDERTARGETVIEW")]
        MessageIDLiveRendertargetview = 0x1AC,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILVIEW")]
        MessageIDLiveDepthstencilview = 0x1AD,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VERTEXSHADER")]
        MessageIDLiveVertexshader = 0x1AE,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_GEOMETRYSHADER")]
        MessageIDLiveGeometryshader = 0x1AF,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PIXELSHADER")]
        MessageIDLivePixelshader = 0x1B0,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_INPUTLAYOUT")]
        MessageIDLiveInputlayout = 0x1B1,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SAMPLER")]
        MessageIDLiveSampler = 0x1B2,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_BLENDSTATE")]
        MessageIDLiveBlendstate = 0x1B3,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILSTATE")]
        MessageIDLiveDepthstencilstate = 0x1B4,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_RASTERIZERSTATE")]
        MessageIDLiveRasterizerstate = 0x1B5,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_QUERY")]
        MessageIDLiveQuery = 0x1B6,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PREDICATE")]
        MessageIDLivePredicate = 0x1B7,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_COUNTER")]
        MessageIDLiveCounter = 0x1B8,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEVICE")]
        MessageIDLiveDevice = 0x1B9,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SWAPCHAIN")]
        MessageIDLiveSwapchain = 0x1BA,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D10_MESSAGES_END")]
        MessageIDD3D10MessagesEnd = 0x1BB,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D10L9_MESSAGES_START")]
        MessageIDD3D10L9MessagesStart = 0x100000,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_STENCIL_NO_TWO_SIDED")]
        MessageIDCreatedepthstencilstateStencilNoTwoSided = 0x100001,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_DepthBiasClamp_NOT_SUPPORTED")]
        MessageIDCreaterasterizerstateDepthBiasClampNotSupported = 0x100002,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NO_COMPARISON_SUPPORT")]
        MessageIDCreatesamplerstateNoComparisonSupport = 0x100003,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_EXCESSIVE_ANISOTROPY")]
        MessageIDCreatesamplerstateExcessiveAnisotropy = 0x100004,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_OUT_OF_RANGE")]
        MessageIDCreatesamplerstateBorderOutOfRange = 0x100005,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSAMPLERS_NOT_SUPPORTED")]
        MessageIDVssetsamplersNotSupported = 0x100006,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETSAMPLERS_TOO_MANY_SAMPLERS")]
        MessageIDVssetsamplersTooManySamplers = 0x100007,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETSAMPLERS_TOO_MANY_SAMPLERS")]
        MessageIDPssetsamplersTooManySamplers = 0x100008,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_ARRAYS")]
        MessageIDCreateresourceNoArrays = 0x100009,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_VB_AND_IB_BIND")]
        MessageIDCreateresourceNoVBAndIBBind = 0x10000A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_TEXTURE_1D")]
        MessageIDCreateresourceNoTexture1D = 0x10000B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_DIMENSION_OUT_OF_RANGE")]
        MessageIDCreateresourceDimensionOutOfRange = 0x10000C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_SHADER_RESOURCE")]
        MessageIDCreateresourceNotBindableAsShaderResource = 0x10000D,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_TOO_MANY_RENDER_TARGETS")]
        MessageIDOmsetrendertargetsTooManyRenderTargets = 0x10000E,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_NO_DIFFERING_BIT_DEPTHS")]
        MessageIDOmsetrendertargetsNoDifferingBitDepths = 0x10000F,
        [NativeName("Name", "D3D11_MESSAGE_ID_IASETVERTEXBUFFERS_BAD_BUFFER_INDEX")]
        MessageIDIasetvertexbuffersBadBufferIndex = 0x100010,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETVIEWPORTS_TOO_MANY_VIEWPORTS")]
        MessageIDDeviceRssetviewportsTooManyViewports = 0x100011,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_ADJACENCY_UNSUPPORTED")]
        MessageIDDeviceIasetprimitivetopologyAdjacencyUnsupported = 0x100012,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_TOO_MANY_SCISSORS")]
        MessageIDDeviceRssetscissorrectsTooManyScissors = 0x100013,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_ONLY_TEXTURE_2D_WITHIN_GPU_MEMORY")]
        MessageIDCopyresourceOnlyTexture2DWithinGpuMemory = 0x100014,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_3D_READBACK")]
        MessageIDCopyresourceNoTexture3DReadback = 0x100015,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_NO_TEXTURE_ONLY_READBACK")]
        MessageIDCopyresourceNoTextureOnlyReadback = 0x100016,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_UNSUPPORTED_FORMAT")]
        MessageIDCreateinputlayoutUnsupportedFormat = 0x100017,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_ALPHA_TO_COVERAGE")]
        MessageIDCreateblendstateNoAlphaToCoverage = 0x100018,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_DepthClipEnable_MUST_BE_TRUE")]
        MessageIDCreaterasterizerstateDepthClipEnableMustBETrue = 0x100019,
        [NativeName("Name", "D3D11_MESSAGE_ID_DRAWINDEXED_STARTINDEXLOCATION_MUST_BE_POSITIVE")]
        MessageIDDrawindexedStartindexlocationMustBEPositive = 0x10001A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_MUST_USE_LOWEST_LOD")]
        MessageIDCreateshaderresourceviewMustUseLowestLod = 0x10001B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_MINLOD_MUST_NOT_BE_FRACTIONAL")]
        MessageIDCreatesamplerstateMinlodMustNotBEFractional = 0x10001C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_MAXLOD_MUST_BE_FLT_MAX")]
        MessageIDCreatesamplerstateMaxlodMustBEFltMax = 0x10001D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_FIRSTARRAYSLICE_MUST_BE_ZERO")]
        MessageIDCreateshaderresourceviewFirstarraysliceMustBEZero = 0x10001E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_CUBES_MUST_HAVE_6_SIDES")]
        MessageIDCreateshaderresourceviewCubesMustHave6Sides = 0x10001F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NOT_BINDABLE_AS_RENDER_TARGET")]
        MessageIDCreateresourceNotBindableAsRenderTarget = 0x100020,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_DWORD_INDEX_BUFFER")]
        MessageIDCreateresourceNoDwordIndexBuffer = 0x100021,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_MSAA_PRECLUDES_SHADER_RESOURCE")]
        MessageIDCreateresourceMsaaPrecludesShaderResource = 0x100022,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_PRESENTATION_PRECLUDES_SHADER_RESOURCE")]
        MessageIDCreateresourcePresentationPrecludesShaderResource = 0x100023,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_BLEND_ENABLE")]
        MessageIDCreateblendstateNoIndependentBlendEnable = 0x100024,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_INDEPENDENT_WRITE_MASKS")]
        MessageIDCreateblendstateNoIndependentWriteMasks = 0x100025,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_STREAM_OUT")]
        MessageIDCreateresourceNoStreamOut = 0x100026,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_ONLY_VB_IB_FOR_BUFFERS")]
        MessageIDCreateresourceOnlyVBIBForBuffers = 0x100027,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NO_AUTOGEN_FOR_VOLUMES")]
        MessageIDCreateresourceNoAutogenForVolumes = 0x100028,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_DXGI_FORMAT_R8G8B8A8_CANNOT_BE_SHARED")]
        MessageIDCreateresourceDxgiFormatR8G8B8A8CannotBEShared = 0x100029,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSHADERRESOURCES_NOT_SUPPORTED")]
        MessageIDVsshaderresourcesNotSupported = 0x10002A,
        [NativeName("Name", "D3D11_MESSAGE_ID_GEOMETRY_SHADER_NOT_SUPPORTED")]
        MessageIDGeometryShaderNotSupported = 0x10002B,
        [NativeName("Name", "D3D11_MESSAGE_ID_STREAM_OUT_NOT_SUPPORTED")]
        MessageIDStreamOutNotSupported = 0x10002C,
        [NativeName("Name", "D3D11_MESSAGE_ID_TEXT_FILTER_NOT_SUPPORTED")]
        MessageIDTextFilterNotSupported = 0x10002D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_SEPARATE_ALPHA_BLEND")]
        MessageIDCreateblendstateNoSeparateAlphaBlend = 0x10002E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_NO_MRT_BLEND")]
        MessageIDCreateblendstateNoMrtBlend = 0x10002F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_OPERATION_NOT_SUPPORTED")]
        MessageIDCreateblendstateOperationNotSupported = 0x100030,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_NO_MIRRORONCE")]
        MessageIDCreatesamplerstateNoMirroronce = 0x100031,
        [NativeName("Name", "D3D11_MESSAGE_ID_DRAWINSTANCED_NOT_SUPPORTED")]
        MessageIDDrawinstancedNotSupported = 0x100032,
        [NativeName("Name", "D3D11_MESSAGE_ID_DRAWINDEXEDINSTANCED_NOT_SUPPORTED_BELOW_9_3")]
        MessageIDDrawindexedinstancedNotSupportedBelow93 = 0x100033,
        [NativeName("Name", "D3D11_MESSAGE_ID_DRAWINDEXED_POINTLIST_UNSUPPORTED")]
        MessageIDDrawindexedPointlistUnsupported = 0x100034,
        [NativeName("Name", "D3D11_MESSAGE_ID_SETBLENDSTATE_SAMPLE_MASK_CANNOT_BE_ZERO")]
        MessageIDSetblendstateSampleMaskCannotBEZero = 0x100035,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_DIMENSION_EXCEEDS_FEATURE_LEVEL_DEFINITION")]
        MessageIDCreateresourceDimensionExceedsFeatureLevelDefinition = 0x100036,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_ONLY_SINGLE_MIP_LEVEL_DEPTH_STENCIL_SUPPORTED")]
        MessageIDCreateresourceOnlySingleMipLevelDepthStencilSupported = 0x100037,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_RSSETSCISSORRECTS_NEGATIVESCISSOR")]
        MessageIDDeviceRssetscissorrectsNegativescissor = 0x100038,
        [NativeName("Name", "D3D11_MESSAGE_ID_SLOT_ZERO_MUST_BE_D3D10_INPUT_PER_VERTEX_DATA")]
        MessageIDSlotZeroMustBED3D10InputPerVertexData = 0x100039,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERESOURCE_NON_POW_2_MIPMAP")]
        MessageIDCreateresourceNonPow2Mipmap = 0x10003A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESAMPLERSTATE_BORDER_NOT_SUPPORTED")]
        MessageIDCreatesamplerstateBorderNotSupported = 0x10003B,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETRENDERTARGETS_NO_SRGB_MRT")]
        MessageIDOmsetrendertargetsNoSrgbMrt = 0x10003C,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYRESOURCE_NO_3D_MISMATCHED_UPDATES")]
        MessageIDCopyresourceNo3DMismatchedUpdates = 0x10003D,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D10L9_MESSAGES_END")]
        MessageIDD3D10L9MessagesEnd = 0x10003E,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_MESSAGES_START")]
        MessageIDD3D11MessagesStart = 0x200000,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFLAGS")]
        MessageIDCreatedepthstencilviewInvalidflags = 0x200001,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatevertexshaderInvalidclasslinkage = 0x200002,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreategeometryshaderInvalidclasslinkage = 0x200003,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTREAMS")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidnumstreams = 0x200004,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAMTORASTERIZER")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidstreamtorasterizer = 0x200005,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTREAMS")]
        MessageIDCreategeometryshaderwithstreamoutputUnexpectedstreams = 0x200006,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCLASSLINKAGE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidclasslinkage = 0x200007,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEPIXELSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatepixelshaderInvalidclasslinkage = 0x200008,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALID_COMMANDLISTFLAGS")]
        MessageIDCreatedeferredcontextInvalidCommandlistflags = 0x200009,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_SINGLETHREADED")]
        MessageIDCreatedeferredcontextSinglethreaded = 0x20000A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALIDARG_RETURN")]
        MessageIDCreatedeferredcontextInvalidargReturn = 0x20000B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_INVALID_CALL_RETURN")]
        MessageIDCreatedeferredcontextInvalidCallReturn = 0x20000C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEFERREDCONTEXT_OUTOFMEMORY_RETURN")]
        MessageIDCreatedeferredcontextOutofmemoryReturn = 0x20000D,
        [NativeName("Name", "D3D11_MESSAGE_ID_FINISHDISPLAYLIST_ONIMMEDIATECONTEXT")]
        MessageIDFinishdisplaylistOnimmediatecontext = 0x20000E,
        [NativeName("Name", "D3D11_MESSAGE_ID_FINISHDISPLAYLIST_OUTOFMEMORY_RETURN")]
        MessageIDFinishdisplaylistOutofmemoryReturn = 0x20000F,
        [NativeName("Name", "D3D11_MESSAGE_ID_FINISHDISPLAYLIST_INVALID_CALL_RETURN")]
        MessageIDFinishdisplaylistInvalidCallReturn = 0x200010,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAM")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidstream = 0x200011,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDENTRIES")]
        MessageIDCreategeometryshaderwithstreamoutputUnexpectedentries = 0x200012,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTRIDES")]
        MessageIDCreategeometryshaderwithstreamoutputUnexpectedstrides = 0x200013,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTRIDES")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidnumstrides = 0x200014,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETSHADERRESOURCES_HAZARD")]
        MessageIDDeviceHssetshaderresourcesHazard = 0x200015,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETCONSTANTBUFFERS_HAZARD")]
        MessageIDDeviceHssetconstantbuffersHazard = 0x200016,
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        MessageIDHssetshaderresourcesUnbinddeletingobject = 0x200017,
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDHssetconstantbuffersUnbinddeletingobject = 0x200018,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDCALL")]
        MessageIDCreatehullshaderInvalidcall = 0x200019,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_OUTOFMEMORY")]
        MessageIDCreatehullshaderOutofmemory = 0x20001A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatehullshaderInvalidshaderbytecode = 0x20001B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatehullshaderInvalidshadertype = 0x20001C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEHULLSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatehullshaderInvalidclasslinkage = 0x20001D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceHssetshaderresourcesViewsEmpty = 0x20001E,
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        MessageIDHssetconstantbuffersInvalidbuffer = 0x20001F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceHssetconstantbuffersBuffersEmpty = 0x200020,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSSETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceHssetsamplersSamplersEmpty = 0x200021,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSGETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceHsgetshaderresourcesViewsEmpty = 0x200022,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceHsgetconstantbuffersBuffersEmpty = 0x200023,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_HSGETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceHsgetsamplersSamplersEmpty = 0x200024,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETSHADERRESOURCES_HAZARD")]
        MessageIDDeviceDssetshaderresourcesHazard = 0x200025,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETCONSTANTBUFFERS_HAZARD")]
        MessageIDDeviceDssetconstantbuffersHazard = 0x200026,
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        MessageIDDssetshaderresourcesUnbinddeletingobject = 0x200027,
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDDssetconstantbuffersUnbinddeletingobject = 0x200028,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCALL")]
        MessageIDCreatedomainshaderInvalidcall = 0x200029,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_OUTOFMEMORY")]
        MessageIDCreatedomainshaderOutofmemory = 0x20002A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatedomainshaderInvalidshaderbytecode = 0x20002B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatedomainshaderInvalidshadertype = 0x20002C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatedomainshaderInvalidclasslinkage = 0x20002D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceDssetshaderresourcesViewsEmpty = 0x20002E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        MessageIDDssetconstantbuffersInvalidbuffer = 0x20002F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceDssetconstantbuffersBuffersEmpty = 0x200030,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSSETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceDssetsamplersSamplersEmpty = 0x200031,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSGETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceDsgetshaderresourcesViewsEmpty = 0x200032,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceDsgetconstantbuffersBuffersEmpty = 0x200033,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DSGETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceDsgetsamplersSamplersEmpty = 0x200034,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HS_XOR_DS_MISMATCH")]
        MessageIDDeviceDrawHSXorDSMismatch = 0x200035,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEFERRED_CONTEXT_REMOVAL_PROCESS_AT_FAULT")]
        MessageIDDeferredContextRemovalProcessATFault = 0x200036,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_INVALID_ARG_BUFFER")]
        MessageIDDeviceDrawindirectInvalidArgBuffer = 0x200037,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_OFFSET_UNALIGNED")]
        MessageIDDeviceDrawindirectOffsetUnaligned = 0x200038,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAWINDIRECT_OFFSET_OVERFLOW")]
        MessageIDDeviceDrawindirectOffsetOverflow = 0x200039,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDMAPTYPE")]
        MessageIDResourceMapInvalidmaptype = 0x20003A,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDSUBRESOURCE")]
        MessageIDResourceMapInvalidsubresource = 0x20003B,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_INVALIDFLAGS")]
        MessageIDResourceMapInvalidflags = 0x20003C,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_ALREADYMAPPED")]
        MessageIDResourceMapAlreadymapped = 0x20003D,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_DEVICEREMOVED_RETURN")]
        MessageIDResourceMapDeviceremovedReturn = 0x20003E,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_OUTOFMEMORY_RETURN")]
        MessageIDResourceMapOutofmemoryReturn = 0x20003F,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_MAP_WITHOUT_INITIAL_DISCARD")]
        MessageIDResourceMapWithoutInitialDiscard = 0x200040,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_UNMAP_INVALIDSUBRESOURCE")]
        MessageIDResourceUnmapInvalidsubresource = 0x200041,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESOURCE_UNMAP_NOTMAPPED")]
        MessageIDResourceUnmapNotmapped = 0x200042,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RASTERIZING_CONTROL_POINTS")]
        MessageIDDeviceDrawRasterizingControlPoints = 0x200043,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_IASETPRIMITIVETOPOLOGY_TOPOLOGY_UNSUPPORTED")]
        MessageIDDeviceIasetprimitivetopologyTopologyUnsupported = 0x200044,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_SIGNATURE_MISMATCH")]
        MessageIDDeviceDrawHSDSSignatureMismatch = 0x200045,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HULL_SHADER_INPUT_TOPOLOGY_MISMATCH")]
        MessageIDDeviceDrawHullShaderInputTopologyMismatch = 0x200046,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_CONTROL_POINT_COUNT_MISMATCH")]
        MessageIDDeviceDrawHSDSControlPointCountMismatch = 0x200047,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_HS_DS_TESSELLATOR_DOMAIN_MISMATCH")]
        MessageIDDeviceDrawHSDSTessellatorDomainMismatch = 0x200048,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_CONTEXT")]
        MessageIDCreateContext = 0x200049,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_CONTEXT")]
        MessageIDLiveContext = 0x20004A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_CONTEXT")]
        MessageIDDestroyContext = 0x20004B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_BUFFER")]
        MessageIDCreateBuffer = 0x20004C,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_BUFFER_WIN7")]
        MessageIDLiveBufferWin7 = 0x20004D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_BUFFER")]
        MessageIDDestroyBuffer = 0x20004E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TEXTURE1D")]
        MessageIDCreateTexture1D = 0x20004F,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE1D_WIN7")]
        MessageIDLiveTexture1DWin7 = 0x200050,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_TEXTURE1D")]
        MessageIDDestroyTexture1D = 0x200051,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TEXTURE2D")]
        MessageIDCreateTexture2D = 0x200052,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE2D_WIN7")]
        MessageIDLiveTexture2DWin7 = 0x200053,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_TEXTURE2D")]
        MessageIDDestroyTexture2D = 0x200054,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TEXTURE3D")]
        MessageIDCreateTexture3D = 0x200055,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TEXTURE3D_WIN7")]
        MessageIDLiveTexture3DWin7 = 0x200056,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_TEXTURE3D")]
        MessageIDDestroyTexture3D = 0x200057,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_SHADERRESOURCEVIEW")]
        MessageIDCreateShaderresourceview = 0x200058,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SHADERRESOURCEVIEW_WIN7")]
        MessageIDLiveShaderresourceviewWin7 = 0x200059,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_SHADERRESOURCEVIEW")]
        MessageIDDestroyShaderresourceview = 0x20005A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_RENDERTARGETVIEW")]
        MessageIDCreateRendertargetview = 0x20005B,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_RENDERTARGETVIEW_WIN7")]
        MessageIDLiveRendertargetviewWin7 = 0x20005C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_RENDERTARGETVIEW")]
        MessageIDDestroyRendertargetview = 0x20005D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DEPTHSTENCILVIEW")]
        MessageIDCreateDepthstencilview = 0x20005E,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILVIEW_WIN7")]
        MessageIDLiveDepthstencilviewWin7 = 0x20005F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DEPTHSTENCILVIEW")]
        MessageIDDestroyDepthstencilview = 0x200060,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_VERTEXSHADER")]
        MessageIDCreateVertexshader = 0x200061,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VERTEXSHADER_WIN7")]
        MessageIDLiveVertexshaderWin7 = 0x200062,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_VERTEXSHADER")]
        MessageIDDestroyVertexshader = 0x200063,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_HULLSHADER")]
        MessageIDCreateHullshader = 0x200064,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_HULLSHADER")]
        MessageIDLiveHullshader = 0x200065,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_HULLSHADER")]
        MessageIDDestroyHullshader = 0x200066,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DOMAINSHADER")]
        MessageIDCreateDomainshader = 0x200067,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DOMAINSHADER")]
        MessageIDLiveDomainshader = 0x200068,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DOMAINSHADER")]
        MessageIDDestroyDomainshader = 0x200069,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_GEOMETRYSHADER")]
        MessageIDCreateGeometryshader = 0x20006A,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_GEOMETRYSHADER_WIN7")]
        MessageIDLiveGeometryshaderWin7 = 0x20006B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_GEOMETRYSHADER")]
        MessageIDDestroyGeometryshader = 0x20006C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_PIXELSHADER")]
        MessageIDCreatePixelshader = 0x20006D,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PIXELSHADER_WIN7")]
        MessageIDLivePixelshaderWin7 = 0x20006E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_PIXELSHADER")]
        MessageIDDestroyPixelshader = 0x20006F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_INPUTLAYOUT")]
        MessageIDCreateInputlayout = 0x200070,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_INPUTLAYOUT_WIN7")]
        MessageIDLiveInputlayoutWin7 = 0x200071,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_INPUTLAYOUT")]
        MessageIDDestroyInputlayout = 0x200072,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_SAMPLER")]
        MessageIDCreateSampler = 0x200073,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SAMPLER_WIN7")]
        MessageIDLiveSamplerWin7 = 0x200074,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_SAMPLER")]
        MessageIDDestroySampler = 0x200075,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_BLENDSTATE")]
        MessageIDCreateBlendstate = 0x200076,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_BLENDSTATE_WIN7")]
        MessageIDLiveBlendstateWin7 = 0x200077,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_BLENDSTATE")]
        MessageIDDestroyBlendstate = 0x200078,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DEPTHSTENCILSTATE")]
        MessageIDCreateDepthstencilstate = 0x200079,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEPTHSTENCILSTATE_WIN7")]
        MessageIDLiveDepthstencilstateWin7 = 0x20007A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DEPTHSTENCILSTATE")]
        MessageIDDestroyDepthstencilstate = 0x20007B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_RASTERIZERSTATE")]
        MessageIDCreateRasterizerstate = 0x20007C,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_RASTERIZERSTATE_WIN7")]
        MessageIDLiveRasterizerstateWin7 = 0x20007D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_RASTERIZERSTATE")]
        MessageIDDestroyRasterizerstate = 0x20007E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_QUERY")]
        MessageIDCreateQuery = 0x20007F,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_QUERY_WIN7")]
        MessageIDLiveQueryWin7 = 0x200080,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_QUERY")]
        MessageIDDestroyQuery = 0x200081,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_PREDICATE")]
        MessageIDCreatePredicate = 0x200082,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PREDICATE_WIN7")]
        MessageIDLivePredicateWin7 = 0x200083,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_PREDICATE")]
        MessageIDDestroyPredicate = 0x200084,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_COUNTER")]
        MessageIDCreateCounter = 0x200085,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_COUNTER")]
        MessageIDDestroyCounter = 0x200086,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_COMMANDLIST")]
        MessageIDCreateCommandlist = 0x200087,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_COMMANDLIST")]
        MessageIDLiveCommandlist = 0x200088,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_COMMANDLIST")]
        MessageIDDestroyCommandlist = 0x200089,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_CLASSINSTANCE")]
        MessageIDCreateClassinstance = 0x20008A,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_CLASSINSTANCE")]
        MessageIDLiveClassinstance = 0x20008B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_CLASSINSTANCE")]
        MessageIDDestroyClassinstance = 0x20008C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_CLASSLINKAGE")]
        MessageIDCreateClasslinkage = 0x20008D,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_CLASSLINKAGE")]
        MessageIDLiveClasslinkage = 0x20008E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_CLASSLINKAGE")]
        MessageIDDestroyClasslinkage = 0x20008F,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEVICE_WIN7")]
        MessageIDLiveDeviceWin7 = 0x200090,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_OBJECT_SUMMARY_WIN7")]
        MessageIDLiveObjectSummaryWin7 = 0x200091,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_COMPUTESHADER")]
        MessageIDCreateComputeshader = 0x200092,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_COMPUTESHADER")]
        MessageIDLiveComputeshader = 0x200093,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_COMPUTESHADER")]
        MessageIDDestroyComputeshader = 0x200094,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_UNORDEREDACCESSVIEW")]
        MessageIDCreateUnorderedaccessview = 0x200095,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_UNORDEREDACCESSVIEW")]
        MessageIDLiveUnorderedaccessview = 0x200096,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_UNORDEREDACCESSVIEW")]
        MessageIDDestroyUnorderedaccessview = 0x200097,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INTERFACES_FEATURELEVEL")]
        MessageIDDeviceSetshaderInterfacesFeaturelevel = 0x200098,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INTERFACE_COUNT_MISMATCH")]
        MessageIDDeviceSetshaderInterfaceCountMismatch = 0x200099,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE")]
        MessageIDDeviceSetshaderInvalidInstance = 0x20009A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_INDEX")]
        MessageIDDeviceSetshaderInvalidInstanceIndex = 0x20009B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_TYPE")]
        MessageIDDeviceSetshaderInvalidInstanceType = 0x20009C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INVALID_INSTANCE_DATA")]
        MessageIDDeviceSetshaderInvalidInstanceData = 0x20009D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_UNBOUND_INSTANCE_DATA")]
        MessageIDDeviceSetshaderUnboundInstanceData = 0x20009E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETSHADER_INSTANCE_DATA_BINDINGS")]
        MessageIDDeviceSetshaderInstanceDataBindings = 0x20009F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATESHADER_CLASSLINKAGE_FULL")]
        MessageIDDeviceCreateshaderClasslinkageFull = 0x2000A0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_UNRECOGNIZED_FEATURE")]
        MessageIDDeviceCheckfeaturesupportUnrecognizedFeature = 0x2000A1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_MISMATCHED_DATA_SIZE")]
        MessageIDDeviceCheckfeaturesupportMismatchedDataSize = 0x2000A2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_INVALIDARG_RETURN")]
        MessageIDDeviceCheckfeaturesupportInvalidargReturn = 0x2000A3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETSHADERRESOURCES_HAZARD")]
        MessageIDDeviceCssetshaderresourcesHazard = 0x2000A4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETCONSTANTBUFFERS_HAZARD")]
        MessageIDDeviceCssetconstantbuffersHazard = 0x2000A5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETSHADERRESOURCES_UNBINDDELETINGOBJECT")]
        MessageIDCssetshaderresourcesUnbinddeletingobject = 0x2000A6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_UNBINDDELETINGOBJECT")]
        MessageIDCssetconstantbuffersUnbinddeletingobject = 0x2000A7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCALL")]
        MessageIDCreatecomputeshaderInvalidcall = 0x2000A8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_OUTOFMEMORY")]
        MessageIDCreatecomputeshaderOutofmemory = 0x2000A9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatecomputeshaderInvalidshaderbytecode = 0x2000AA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERTYPE")]
        MessageIDCreatecomputeshaderInvalidshadertype = 0x2000AB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatecomputeshaderInvalidclasslinkage = 0x2000AC,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceCssetshaderresourcesViewsEmpty = 0x2000AD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_INVALIDBUFFER")]
        MessageIDCssetconstantbuffersInvalidbuffer = 0x2000AE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceCssetconstantbuffersBuffersEmpty = 0x2000AF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceCssetsamplersSamplersEmpty = 0x2000B0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSGETSHADERRESOURCES_VIEWS_EMPTY")]
        MessageIDDeviceCsgetshaderresourcesViewsEmpty = 0x2000B1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSGETCONSTANTBUFFERS_BUFFERS_EMPTY")]
        MessageIDDeviceCsgetconstantbuffersBuffersEmpty = 0x2000B2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSGETSAMPLERS_SAMPLERS_EMPTY")]
        MessageIDDeviceCsgetsamplersSamplersEmpty = 0x2000B3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderDoublefloatopsnotsupported = 0x2000B4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderDoublefloatopsnotsupported = 0x2000B5,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderDoublefloatopsnotsupported = 0x2000B6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderDoublefloatopsnotsupported = 0x2000B7,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputDoublefloatopsnotsupported = 0x2000B8,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderDoublefloatopsnotsupported = 0x2000B9,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderDoublefloatopsnotsupported = 0x2000BA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDSTRUCTURESTRIDE")]
        MessageIDCreatebufferInvalidstructurestride = 0x2000BB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFLAGS")]
        MessageIDCreateshaderresourceviewInvalidflags = 0x2000BC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDRESOURCE")]
        MessageIDCreateunorderedaccessviewInvalidresource = 0x2000BD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDESC")]
        MessageIDCreateunorderedaccessviewInvaliddesc = 0x2000BE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFORMAT")]
        MessageIDCreateunorderedaccessviewInvalidformat = 0x2000BF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDIMENSIONS")]
        MessageIDCreateunorderedaccessviewInvaliddimensions = 0x2000C0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreateunorderedaccessviewUnrecognizedformat = 0x2000C1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_HAZARD")]
        MessageIDDeviceOmsetrendertargetsandunorderedaccessviewsHazard = 0x2000C2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_OVERLAPPING_OLD_SLOTS")]
        MessageIDDeviceOmsetrendertargetsandunorderedaccessviewsOverlappingOldSlots = 0x2000C3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_NO_OP")]
        MessageIDDeviceOmsetrendertargetsandunorderedaccessviewsNoOp = 0x2000C4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETUNORDEREDACCESSVIEWS_UNBINDDELETINGOBJECT")]
        MessageIDCssetunorderedaccessviewsUnbinddeletingobject = 0x2000C5,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETUNORDEREDACCESSVIEWS_UNBINDDELETINGOBJECT")]
        MessageIDPssetunorderedaccessviewsUnbinddeletingobject = 0x2000C6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDARG_RETURN")]
        MessageIDCreateunorderedaccessviewInvalidargReturn = 0x2000C7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreateunorderedaccessviewOutofmemoryReturn = 0x2000C8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_TOOMANYOBJECTS")]
        MessageIDCreateunorderedaccessviewToomanyobjects = 0x2000C9,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_HAZARD")]
        MessageIDDeviceCssetunorderedaccessviewsHazard = 0x2000CA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_DENORMFLUSH")]
        MessageIDClearunorderedaccessviewDenormflush = 0x2000CB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSS_VIEWS_EMPTY")]
        MessageIDDeviceCssetunorderedaccesssViewsEmpty = 0x2000CC,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSGETUNORDEREDACCESSS_VIEWS_EMPTY")]
        MessageIDDeviceCsgetunorderedaccesssViewsEmpty = 0x2000CD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFLAGS")]
        MessageIDCreateunorderedaccessviewInvalidflags = 0x2000CE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESESOURCEVIEW_TOOMANYOBJECTS")]
        MessageIDCreateshaderresesourceviewToomanyobjects = 0x2000CF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_INVALID_ARG_BUFFER")]
        MessageIDDeviceDispatchindirectInvalidArgBuffer = 0x2000D0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_OFFSET_UNALIGNED")]
        MessageIDDeviceDispatchindirectOffsetUnaligned = 0x2000D1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_OFFSET_OVERFLOW")]
        MessageIDDeviceDispatchindirectOffsetOverflow = 0x2000D2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDCONTEXT")]
        MessageIDDeviceSetresourceminlodInvalidcontext = 0x2000D3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDRESOURCE")]
        MessageIDDeviceSetresourceminlodInvalidresource = 0x2000D4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETRESOURCEMINLOD_INVALIDMINLOD")]
        MessageIDDeviceSetresourceminlodInvalidminlod = 0x2000D5,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GETRESOURCEMINLOD_INVALIDCONTEXT")]
        MessageIDDeviceGetresourceminlodInvalidcontext = 0x2000D6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_GETRESOURCEMINLOD_INVALIDRESOURCE")]
        MessageIDDeviceGetresourceminlodInvalidresource = 0x2000D7,
        [NativeName("Name", "D3D11_MESSAGE_ID_OMSETDEPTHSTENCIL_UNBINDDELETINGOBJECT")]
        MessageIDOmsetdepthstencilUnbinddeletingobject = 0x2000D8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_DEPTH_READONLY")]
        MessageIDCleardepthstencilviewDepthReadonly = 0x2000D9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_STENCIL_READONLY")]
        MessageIDCleardepthstencilviewStencilReadonly = 0x2000DA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKFEATURESUPPORT_FORMAT_DEPRECATED")]
        MessageIDCheckfeaturesupportFormatDeprecated = 0x2000DB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_RETURN_TYPE_MISMATCH")]
        MessageIDDeviceUnorderedaccessviewReturnTypeMismatch = 0x2000DC,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_NOT_SET")]
        MessageIDDeviceUnorderedaccessviewNotSet = 0x2000DD,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_UNORDEREDACCESSVIEW_RENDERTARGETVIEW_OVERLAP")]
        MessageIDDeviceDrawUnorderedaccessviewRendertargetviewOverlap = 0x2000DE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_DIMENSION_MISMATCH")]
        MessageIDDeviceUnorderedaccessviewDimensionMismatch = 0x2000DF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_APPEND_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAppendUnsupported = 0x2000E0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMICS_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicsUnsupported = 0x2000E1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_STRUCTURE_STRIDE_MISMATCH")]
        MessageIDDeviceUnorderedaccessviewStructureStrideMismatch = 0x2000E2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_BUFFER_TYPE_MISMATCH")]
        MessageIDDeviceUnorderedaccessviewBufferTypeMismatch = 0x2000E3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_RAW_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewRawUnsupported = 0x2000E4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_FORMAT_LD_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewFormatLDUnsupported = 0x2000E5,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_FORMAT_STORE_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewFormatStoreUnsupported = 0x2000E6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_ADD_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicAddUnsupported = 0x2000E7,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_BITWISE_OPS_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicBitwiseOpsUnsupported = 0x2000E8,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_CMPSTORE_CMPEXCHANGE_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicCmpstoreCmpexchangeUnsupported = 0x2000E9,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_EXCHANGE_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicExchangeUnsupported = 0x2000EA,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_SIGNED_MINMAX_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicSignedMinmaxUnsupported = 0x2000EB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_ATOMIC_UNSIGNED_MINMAX_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewAtomicUnsignedMinmaxUnsupported = 0x2000EC,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCH_BOUND_RESOURCE_MAPPED")]
        MessageIDDeviceDispatchBoundResourceMapped = 0x2000ED,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCH_THREADGROUPCOUNT_OVERFLOW")]
        MessageIDDeviceDispatchThreadgroupcountOverflow = 0x2000EE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCH_THREADGROUPCOUNT_ZERO")]
        MessageIDDeviceDispatchThreadgroupcountZero = 0x2000EF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_STRUCTURE_STRIDE_MISMATCH")]
        MessageIDDeviceShaderresourceviewStructureStrideMismatch = 0x2000F0,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_BUFFER_TYPE_MISMATCH")]
        MessageIDDeviceShaderresourceviewBufferTypeMismatch = 0x2000F1,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADERRESOURCEVIEW_RAW_UNSUPPORTED")]
        MessageIDDeviceShaderresourceviewRawUnsupported = 0x2000F2,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCH_UNSUPPORTED")]
        MessageIDDeviceDispatchUnsupported = 0x2000F3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISPATCHINDIRECT_UNSUPPORTED")]
        MessageIDDeviceDispatchindirectUnsupported = 0x2000F4,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDOFFSET")]
        MessageIDCopystructurecountInvalidoffset = 0x2000F5,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_LARGEOFFSET")]
        MessageIDCopystructurecountLargeoffset = 0x2000F6,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDDESTINATIONSTATE")]
        MessageIDCopystructurecountInvaliddestinationstate = 0x2000F7,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSTRUCTURECOUNT_INVALIDSOURCESTATE")]
        MessageIDCopystructurecountInvalidsourcestate = 0x2000F8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKFORMATSUPPORT_FORMAT_NOT_SUPPORTED")]
        MessageIDCheckformatsupportFormatNotSupported = 0x2000F9,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_INVALIDVIEW")]
        MessageIDDeviceCssetunorderedaccessviewsInvalidview = 0x2000FA,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_INVALIDOFFSET")]
        MessageIDDeviceCssetunorderedaccessviewsInvalidoffset = 0x2000FB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CSSETUNORDEREDACCESSVIEWS_TOOMANYVIEWS")]
        MessageIDDeviceCssetunorderedaccessviewsToomanyviews = 0x2000FC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWFLOAT_INVALIDFORMAT")]
        MessageIDClearunorderedaccessviewfloatInvalidformat = 0x2000FD,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_COUNTER_UNSUPPORTED")]
        MessageIDDeviceUnorderedaccessviewCounterUnsupported = 0x2000FE,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING")]
        MessageIDRefWarning = 0x2000FF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_PIXEL_SHADER_WITHOUT_RTV_OR_DSV")]
        MessageIDDeviceDrawPixelShaderWithoutRtvOrDsv = 0x200100,
        [NativeName("Name", "D3D11_MESSAGE_ID_SHADER_ABORT")]
        MessageIDShaderAbort = 0x200101,
        [NativeName("Name", "D3D11_MESSAGE_ID_SHADER_MESSAGE")]
        MessageIDShaderMessage = 0x200102,
        [NativeName("Name", "D3D11_MESSAGE_ID_SHADER_ERROR")]
        MessageIDShaderError = 0x200103,
        [NativeName("Name", "D3D11_MESSAGE_ID_OFFERRESOURCES_INVALIDRESOURCE")]
        MessageIDOfferresourcesInvalidresource = 0x200104,
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        MessageIDHssetsamplersUnbinddeletingobject = 0x200105,
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        MessageIDDssetsamplersUnbinddeletingobject = 0x200106,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETSAMPLERS_UNBINDDELETINGOBJECT")]
        MessageIDCssetsamplersUnbinddeletingobject = 0x200107,
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETSHADER_UNBINDDELETINGOBJECT")]
        MessageIDHssetshaderUnbinddeletingobject = 0x200108,
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETSHADER_UNBINDDELETINGOBJECT")]
        MessageIDDssetshaderUnbinddeletingobject = 0x200109,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETSHADER_UNBINDDELETINGOBJECT")]
        MessageIDCssetshaderUnbinddeletingobject = 0x20010A,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENQUEUESETEVENT_INVALIDARG_RETURN")]
        MessageIDEnqueueseteventInvalidargReturn = 0x20010B,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENQUEUESETEVENT_OUTOFMEMORY_RETURN")]
        MessageIDEnqueueseteventOutofmemoryReturn = 0x20010C,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENQUEUESETEVENT_ACCESSDENIED_RETURN")]
        MessageIDEnqueueseteventAccessdeniedReturn = 0x20010D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_NUMUAVS_INVALIDRANGE")]
        MessageIDDeviceOmsetrendertargetsandunorderedaccessviewsNumuavsInvalidrange = 0x20010E,
        [NativeName("Name", "D3D11_MESSAGE_ID_USE_OF_ZERO_REFCOUNT_OBJECT")]
        MessageIDUseOfZeroRefcountObject = 0x20010F,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_MESSAGES_END")]
        MessageIDD3D11MessagesEnd = 0x200110,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_1_MESSAGES_START")]
        MessageIDD3D111MessagesStart = 0x300000,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_VIDEODECODER")]
        MessageIDCreateVideodecoder = 0x300001,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_VIDEOPROCESSORENUM")]
        MessageIDCreateVideoprocessorenum = 0x300002,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_VIDEOPROCESSOR")]
        MessageIDCreateVideoprocessor = 0x300003,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DECODEROUTPUTVIEW")]
        MessageIDCreateDecoderoutputview = 0x300004,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_PROCESSORINPUTVIEW")]
        MessageIDCreateProcessorinputview = 0x300005,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_PROCESSOROUTPUTVIEW")]
        MessageIDCreateProcessoroutputview = 0x300006,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_DEVICECONTEXTSTATE")]
        MessageIDCreateDevicecontextstate = 0x300007,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VIDEODECODER")]
        MessageIDLiveVideodecoder = 0x300008,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VIDEOPROCESSORENUM")]
        MessageIDLiveVideoprocessorenum = 0x300009,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_VIDEOPROCESSOR")]
        MessageIDLiveVideoprocessor = 0x30000A,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DECODEROUTPUTVIEW")]
        MessageIDLiveDecoderoutputview = 0x30000B,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PROCESSORINPUTVIEW")]
        MessageIDLiveProcessorinputview = 0x30000C,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_PROCESSOROUTPUTVIEW")]
        MessageIDLiveProcessoroutputview = 0x30000D,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_DEVICECONTEXTSTATE")]
        MessageIDLiveDevicecontextstate = 0x30000E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_VIDEODECODER")]
        MessageIDDestroyVideodecoder = 0x30000F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_VIDEOPROCESSORENUM")]
        MessageIDDestroyVideoprocessorenum = 0x300010,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_VIDEOPROCESSOR")]
        MessageIDDestroyVideoprocessor = 0x300011,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DECODEROUTPUTVIEW")]
        MessageIDDestroyDecoderoutputview = 0x300012,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_PROCESSORINPUTVIEW")]
        MessageIDDestroyProcessorinputview = 0x300013,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_PROCESSOROUTPUTVIEW")]
        MessageIDDestroyProcessoroutputview = 0x300014,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_DEVICECONTEXTSTATE")]
        MessageIDDestroyDevicecontextstate = 0x300015,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDFLAGS")]
        MessageIDCreatedevicecontextstateInvalidflags = 0x300016,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDFEATURELEVEL")]
        MessageIDCreatedevicecontextstateInvalidfeaturelevel = 0x300017,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_FEATURELEVELS_NOT_SUPPORTED")]
        MessageIDCreatedevicecontextstateFeaturelevelsNotSupported = 0x300018,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICECONTEXTSTATE_INVALIDREFIID")]
        MessageIDCreatedevicecontextstateInvalidrefiid = 0x300019,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DISCARDVIEW_INVALIDVIEW")]
        MessageIDDeviceDiscardviewInvalidview = 0x30001A,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION1_INVALIDCOPYFLAGS")]
        MessageIDCopysubresourceregion1Invalidcopyflags = 0x30001B,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE1_INVALIDCOPYFLAGS")]
        MessageIDUpdatesubresource1Invalidcopyflags = 0x30001C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFORCEDSAMPLECOUNT")]
        MessageIDCreaterasterizerstateInvalidforcedsamplecount = 0x30001D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_OUTOFMEMORY_RETURN")]
        MessageIDCreatevideodecoderOutofmemoryReturn = 0x30001E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_NULLPARAM")]
        MessageIDCreatevideodecoderNullparam = 0x30001F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_INVALIDFORMAT")]
        MessageIDCreatevideodecoderInvalidformat = 0x300020,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_ZEROWIDTHHEIGHT")]
        MessageIDCreatevideodecoderZerowidthheight = 0x300021,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_DRIVER_INVALIDBUFFERSIZE")]
        MessageIDCreatevideodecoderDriverInvalidbuffersize = 0x300022,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODER_DRIVER_INVALIDBUFFERUSAGE")]
        MessageIDCreatevideodecoderDriverInvalidbufferusage = 0x300023,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERPROFILECOUNT_OUTOFMEMORY")]
        MessageIDGetvideodecoderprofilecountOutofmemory = 0x300024,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_NULLPARAM")]
        MessageIDGetvideodecoderprofileNullparam = 0x300025,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_INVALIDINDEX")]
        MessageIDGetvideodecoderprofileInvalidindex = 0x300026,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERPROFILE_OUTOFMEMORY_RETURN")]
        MessageIDGetvideodecoderprofileOutofmemoryReturn = 0x300027,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERFORMAT_NULLPARAM")]
        MessageIDCheckvideodecoderformatNullparam = 0x300028,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERFORMAT_OUTOFMEMORY_RETURN")]
        MessageIDCheckvideodecoderformatOutofmemoryReturn = 0x300029,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIGCOUNT_NULLPARAM")]
        MessageIDGetvideodecoderconfigcountNullparam = 0x30002A,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIGCOUNT_OUTOFMEMORY_RETURN")]
        MessageIDGetvideodecoderconfigcountOutofmemoryReturn = 0x30002B,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_NULLPARAM")]
        MessageIDGetvideodecoderconfigNullparam = 0x30002C,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_INVALIDINDEX")]
        MessageIDGetvideodecoderconfigInvalidindex = 0x30002D,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCONFIG_OUTOFMEMORY_RETURN")]
        MessageIDGetvideodecoderconfigOutofmemoryReturn = 0x30002E,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERCREATIONPARAMS_NULLPARAM")]
        MessageIDGetdecodercreationparamsNullparam = 0x30002F,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERDRIVERHANDLE_NULLPARAM")]
        MessageIDGetdecoderdriverhandleNullparam = 0x300030,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERBUFFER_NULLPARAM")]
        MessageIDGetdecoderbufferNullparam = 0x300031,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERBUFFER_INVALIDBUFFER")]
        MessageIDGetdecoderbufferInvalidbuffer = 0x300032,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERBUFFER_INVALIDTYPE")]
        MessageIDGetdecoderbufferInvalidtype = 0x300033,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERBUFFER_LOCKED")]
        MessageIDGetdecoderbufferLocked = 0x300034,
        [NativeName("Name", "D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_NULLPARAM")]
        MessageIDReleasedecoderbufferNullparam = 0x300035,
        [NativeName("Name", "D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_INVALIDTYPE")]
        MessageIDReleasedecoderbufferInvalidtype = 0x300036,
        [NativeName("Name", "D3D11_MESSAGE_ID_RELEASEDECODERBUFFER_NOTLOCKED")]
        MessageIDReleasedecoderbufferNotlocked = 0x300037,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_NULLPARAM")]
        MessageIDDecoderbeginframeNullparam = 0x300038,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_HAZARD")]
        MessageIDDecoderbeginframeHazard = 0x300039,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERENDFRAME_NULLPARAM")]
        MessageIDDecoderendframeNullparam = 0x30003A,
        [NativeName("Name", "D3D11_MESSAGE_ID_SUBMITDECODERBUFFERS_NULLPARAM")]
        MessageIDSubmitdecoderbuffersNullparam = 0x30003B,
        [NativeName("Name", "D3D11_MESSAGE_ID_SUBMITDECODERBUFFERS_INVALIDTYPE")]
        MessageIDSubmitdecoderbuffersInvalidtype = 0x30003C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODEREXTENSION_NULLPARAM")]
        MessageIDDecoderextensionNullparam = 0x30003D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODEREXTENSION_INVALIDRESOURCE")]
        MessageIDDecoderextensionInvalidresource = 0x30003E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_OUTOFMEMORY_RETURN")]
        MessageIDCreatevideoprocessorenumeratorOutofmemoryReturn = 0x30003F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_NULLPARAM")]
        MessageIDCreatevideoprocessorenumeratorNullparam = 0x300040,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDFRAMEFORMAT")]
        MessageIDCreatevideoprocessorenumeratorInvalidframeformat = 0x300041,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDUSAGE")]
        MessageIDCreatevideoprocessorenumeratorInvalidusage = 0x300042,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDINPUTFRAMERATE")]
        MessageIDCreatevideoprocessorenumeratorInvalidinputframerate = 0x300043,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDOUTPUTFRAMERATE")]
        MessageIDCreatevideoprocessorenumeratorInvalidoutputframerate = 0x300044,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORENUMERATOR_INVALIDWIDTHHEIGHT")]
        MessageIDCreatevideoprocessorenumeratorInvalidwidthheight = 0x300045,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORCONTENTDESC_NULLPARAM")]
        MessageIDGetvideoprocessorcontentdescNullparam = 0x300046,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEOPROCESSORFORMAT_NULLPARAM")]
        MessageIDCheckvideoprocessorformatNullparam = 0x300047,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORCAPS_NULLPARAM")]
        MessageIDGetvideoprocessorcapsNullparam = 0x300048,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORRATECONVERSIONCAPS_NULLPARAM")]
        MessageIDGetvideoprocessorrateconversioncapsNullparam = 0x300049,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORRATECONVERSIONCAPS_INVALIDINDEX")]
        MessageIDGetvideoprocessorrateconversioncapsInvalidindex = 0x30004A,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORCUSTOMRATE_NULLPARAM")]
        MessageIDGetvideoprocessorcustomrateNullparam = 0x30004B,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORCUSTOMRATE_INVALIDINDEX")]
        MessageIDGetvideoprocessorcustomrateInvalidindex = 0x30004C,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORFILTERRANGE_NULLPARAM")]
        MessageIDGetvideoprocessorfilterrangeNullparam = 0x30004D,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEOPROCESSORFILTERRANGE_UNSUPPORTED")]
        MessageIDGetvideoprocessorfilterrangeUnsupported = 0x30004E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOR_OUTOFMEMORY_RETURN")]
        MessageIDCreatevideoprocessorOutofmemoryReturn = 0x30004F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOR_NULLPARAM")]
        MessageIDCreatevideoprocessorNullparam = 0x300050,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTTARGETRECT_NULLPARAM")]
        MessageIDVideoprocessorsetoutputtargetrectNullparam = 0x300051,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTBACKGROUNDCOLOR_NULLPARAM")]
        MessageIDVideoprocessorsetoutputbackgroundcolorNullparam = 0x300052,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTBACKGROUNDCOLOR_INVALIDALPHA")]
        MessageIDVideoprocessorsetoutputbackgroundcolorInvalidalpha = 0x300053,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCOLORSPACE_NULLPARAM")]
        MessageIDVideoprocessorsetoutputcolorspaceNullparam = 0x300054,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_NULLPARAM")]
        MessageIDVideoprocessorsetoutputalphafillmodeNullparam = 0x300055,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_UNSUPPORTED")]
        MessageIDVideoprocessorsetoutputalphafillmodeUnsupported = 0x300056,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_INVALIDSTREAM")]
        MessageIDVideoprocessorsetoutputalphafillmodeInvalidstream = 0x300057,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTALPHAFILLMODE_INVALIDFILLMODE")]
        MessageIDVideoprocessorsetoutputalphafillmodeInvalidfillmode = 0x300058,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_NULLPARAM")]
        MessageIDVideoprocessorsetoutputconstrictionNullparam = 0x300059,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSTEREOMODE_NULLPARAM")]
        MessageIDVideoprocessorsetoutputstereomodeNullparam = 0x30005A,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSTEREOMODE_UNSUPPORTED")]
        MessageIDVideoprocessorsetoutputstereomodeUnsupported = 0x30005B,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTEXTENSION_NULLPARAM")]
        MessageIDVideoprocessorsetoutputextensionNullparam = 0x30005C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTTARGETRECT_NULLPARAM")]
        MessageIDVideoprocessorgetoutputtargetrectNullparam = 0x30005D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTBACKGROUNDCOLOR_NULLPARAM")]
        MessageIDVideoprocessorgetoutputbackgroundcolorNullparam = 0x30005E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCOLORSPACE_NULLPARAM")]
        MessageIDVideoprocessorgetoutputcolorspaceNullparam = 0x30005F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTALPHAFILLMODE_NULLPARAM")]
        MessageIDVideoprocessorgetoutputalphafillmodeNullparam = 0x300060,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCONSTRICTION_NULLPARAM")]
        MessageIDVideoprocessorgetoutputconstrictionNullparam = 0x300061,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_UNSUPPORTED")]
        MessageIDVideoprocessorsetoutputconstrictionUnsupported = 0x300062,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCONSTRICTION_INVALIDSIZE")]
        MessageIDVideoprocessorsetoutputconstrictionInvalidsize = 0x300063,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTSTEREOMODE_NULLPARAM")]
        MessageIDVideoprocessorgetoutputstereomodeNullparam = 0x300064,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTEXTENSION_NULLPARAM")]
        MessageIDVideoprocessorgetoutputextensionNullparam = 0x300065,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_NULLPARAM")]
        MessageIDVideoprocessorsetstreamframeformatNullparam = 0x300066,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_INVALIDFORMAT")]
        MessageIDVideoprocessorsetstreamframeformatInvalidformat = 0x300067,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFRAMEFORMAT_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamframeformatInvalidstream = 0x300068,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE_NULLPARAM")]
        MessageIDVideoprocessorsetstreamcolorspaceNullparam = 0x300069,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamcolorspaceInvalidstream = 0x30006A,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_NULLPARAM")]
        MessageIDVideoprocessorsetstreamoutputrateNullparam = 0x30006B,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDRATE")]
        MessageIDVideoprocessorsetstreamoutputrateInvalidrate = 0x30006C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDFLAG")]
        MessageIDVideoprocessorsetstreamoutputrateInvalidflag = 0x30006D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMOUTPUTRATE_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamoutputrateInvalidstream = 0x30006E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_NULLPARAM")]
        MessageIDVideoprocessorsetstreamsourcerectNullparam = 0x30006F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamsourcerectInvalidstream = 0x300070,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSOURCERECT_INVALIDRECT")]
        MessageIDVideoprocessorsetstreamsourcerectInvalidrect = 0x300071,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_NULLPARAM")]
        MessageIDVideoprocessorsetstreamdestrectNullparam = 0x300072,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamdestrectInvalidstream = 0x300073,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMDESTRECT_INVALIDRECT")]
        MessageIDVideoprocessorsetstreamdestrectInvalidrect = 0x300074,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_NULLPARAM")]
        MessageIDVideoprocessorsetstreamalphaNullparam = 0x300075,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamalphaInvalidstream = 0x300076,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_INVALIDALPHA")]
        MessageIDVideoprocessorsetstreamalphaInvalidalpha = 0x300077,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_NULLPARAM")]
        MessageIDVideoprocessorsetstreampaletteNullparam = 0x300078,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreampaletteInvalidstream = 0x300079,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDCOUNT")]
        MessageIDVideoprocessorsetstreampaletteInvalidcount = 0x30007A,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPALETTE_INVALIDALPHA")]
        MessageIDVideoprocessorsetstreampaletteInvalidalpha = 0x30007B,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_NULLPARAM")]
        MessageIDVideoprocessorsetstreampixelaspectratioNullparam = 0x30007C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreampixelaspectratioInvalidstream = 0x30007D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_INVALIDRATIO")]
        MessageIDVideoprocessorsetstreampixelaspectratioInvalidratio = 0x30007E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_NULLPARAM")]
        MessageIDVideoprocessorsetstreamlumakeyNullparam = 0x30007F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamlumakeyInvalidstream = 0x300080,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_INVALIDRANGE")]
        MessageIDVideoprocessorsetstreamlumakeyInvalidrange = 0x300081,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMLUMAKEY_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreamlumakeyUnsupported = 0x300082,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_NULLPARAM")]
        MessageIDVideoprocessorsetstreamstereoformatNullparam = 0x300083,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamstereoformatInvalidstream = 0x300084,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreamstereoformatUnsupported = 0x300085,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_FLIPUNSUPPORTED")]
        MessageIDVideoprocessorsetstreamstereoformatFlipunsupported = 0x300086,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_MONOOFFSETUNSUPPORTED")]
        MessageIDVideoprocessorsetstreamstereoformatMonooffsetunsupported = 0x300087,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_FORMATUNSUPPORTED")]
        MessageIDVideoprocessorsetstreamstereoformatFormatunsupported = 0x300088,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMSTEREOFORMAT_INVALIDFORMAT")]
        MessageIDVideoprocessorsetstreamstereoformatInvalidformat = 0x300089,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMAUTOPROCESSINGMODE_NULLPARAM")]
        MessageIDVideoprocessorsetstreamautoprocessingmodeNullparam = 0x30008A,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMAUTOPROCESSINGMODE_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamautoprocessingmodeInvalidstream = 0x30008B,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_NULLPARAM")]
        MessageIDVideoprocessorsetstreamfilterNullparam = 0x30008C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamfilterInvalidstream = 0x30008D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDFILTER")]
        MessageIDVideoprocessorsetstreamfilterInvalidfilter = 0x30008E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreamfilterUnsupported = 0x30008F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMFILTER_INVALIDLEVEL")]
        MessageIDVideoprocessorsetstreamfilterInvalidlevel = 0x300090,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMEXTENSION_NULLPARAM")]
        MessageIDVideoprocessorsetstreamextensionNullparam = 0x300091,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMEXTENSION_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamextensionInvalidstream = 0x300092,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFRAMEFORMAT_NULLPARAM")]
        MessageIDVideoprocessorgetstreamframeformatNullparam = 0x300093,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE_NULLPARAM")]
        MessageIDVideoprocessorgetstreamcolorspaceNullparam = 0x300094,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMOUTPUTRATE_NULLPARAM")]
        MessageIDVideoprocessorgetstreamoutputrateNullparam = 0x300095,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSOURCERECT_NULLPARAM")]
        MessageIDVideoprocessorgetstreamsourcerectNullparam = 0x300096,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMDESTRECT_NULLPARAM")]
        MessageIDVideoprocessorgetstreamdestrectNullparam = 0x300097,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMALPHA_NULLPARAM")]
        MessageIDVideoprocessorgetstreamalphaNullparam = 0x300098,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPALETTE_NULLPARAM")]
        MessageIDVideoprocessorgetstreampaletteNullparam = 0x300099,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPIXELASPECTRATIO_NULLPARAM")]
        MessageIDVideoprocessorgetstreampixelaspectratioNullparam = 0x30009A,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMLUMAKEY_NULLPARAM")]
        MessageIDVideoprocessorgetstreamlumakeyNullparam = 0x30009B,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSTEREOFORMAT_NULLPARAM")]
        MessageIDVideoprocessorgetstreamstereoformatNullparam = 0x30009C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMAUTOPROCESSINGMODE_NULLPARAM")]
        MessageIDVideoprocessorgetstreamautoprocessingmodeNullparam = 0x30009D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFILTER_NULLPARAM")]
        MessageIDVideoprocessorgetstreamfilterNullparam = 0x30009E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMEXTENSION_NULLPARAM")]
        MessageIDVideoprocessorgetstreamextensionNullparam = 0x30009F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMEXTENSION_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamextensionInvalidstream = 0x3000A0,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_NULLPARAM")]
        MessageIDVideoprocessorbltNullparam = 0x3000A1,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDSTREAMCOUNT")]
        MessageIDVideoprocessorbltInvalidstreamcount = 0x3000A2,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_TARGETRECT")]
        MessageIDVideoprocessorbltTargetrect = 0x3000A3,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDOUTPUT")]
        MessageIDVideoprocessorbltInvalidoutput = 0x3000A4,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDPASTFRAMES")]
        MessageIDVideoprocessorbltInvalidpastframes = 0x3000A5,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDFUTUREFRAMES")]
        MessageIDVideoprocessorbltInvalidfutureframes = 0x3000A6,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDSOURCERECT")]
        MessageIDVideoprocessorbltInvalidsourcerect = 0x3000A7,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDDESTRECT")]
        MessageIDVideoprocessorbltInvaliddestrect = 0x3000A8,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDINPUTRESOURCE")]
        MessageIDVideoprocessorbltInvalidinputresource = 0x3000A9,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDARRAYSIZE")]
        MessageIDVideoprocessorbltInvalidarraysize = 0x3000AA,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDARRAY")]
        MessageIDVideoprocessorbltInvalidarray = 0x3000AB,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_RIGHTEXPECTED")]
        MessageIDVideoprocessorbltRightexpected = 0x3000AC,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_RIGHTNOTEXPECTED")]
        MessageIDVideoprocessorbltRightnotexpected = 0x3000AD,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_STEREONOTENABLED")]
        MessageIDVideoprocessorbltStereonotenabled = 0x3000AE,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INVALIDRIGHTRESOURCE")]
        MessageIDVideoprocessorbltInvalidrightresource = 0x3000AF,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_NOSTEREOSTREAMS")]
        MessageIDVideoprocessorbltNostereostreams = 0x3000B0,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_INPUTHAZARD")]
        MessageIDVideoprocessorbltInputhazard = 0x3000B1,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORBLT_OUTPUTHAZARD")]
        MessageIDVideoprocessorbltOutputhazard = 0x3000B2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreatevideodecoderoutputviewOutofmemoryReturn = 0x3000B3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_NULLPARAM")]
        MessageIDCreatevideodecoderoutputviewNullparam = 0x3000B4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDTYPE")]
        MessageIDCreatevideodecoderoutputviewInvalidtype = 0x3000B5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDBIND")]
        MessageIDCreatevideodecoderoutputviewInvalidbind = 0x3000B6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_UNSUPPORTEDFORMAT")]
        MessageIDCreatevideodecoderoutputviewUnsupportedformat = 0x3000B7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDMIP")]
        MessageIDCreatevideodecoderoutputviewInvalidmip = 0x3000B8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_UNSUPPORTEMIP")]
        MessageIDCreatevideodecoderoutputviewUnsupportemip = 0x3000B9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDARRAYSIZE")]
        MessageIDCreatevideodecoderoutputviewInvalidarraysize = 0x3000BA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDARRAY")]
        MessageIDCreatevideodecoderoutputviewInvalidarray = 0x3000BB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEODECODEROUTPUTVIEW_INVALIDDIMENSION")]
        MessageIDCreatevideodecoderoutputviewInvaliddimension = 0x3000BC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreatevideoprocessorinputviewOutofmemoryReturn = 0x3000BD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_NULLPARAM")]
        MessageIDCreatevideoprocessorinputviewNullparam = 0x3000BE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDTYPE")]
        MessageIDCreatevideoprocessorinputviewInvalidtype = 0x3000BF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDBIND")]
        MessageIDCreatevideoprocessorinputviewInvalidbind = 0x3000C0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMISC")]
        MessageIDCreatevideoprocessorinputviewInvalidmisc = 0x3000C1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDUSAGE")]
        MessageIDCreatevideoprocessorinputviewInvalidusage = 0x3000C2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDFORMAT")]
        MessageIDCreatevideoprocessorinputviewInvalidformat = 0x3000C3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDFOURCC")]
        MessageIDCreatevideoprocessorinputviewInvalidfourcc = 0x3000C4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMIP")]
        MessageIDCreatevideoprocessorinputviewInvalidmip = 0x3000C5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_UNSUPPORTEDMIP")]
        MessageIDCreatevideoprocessorinputviewUnsupportedmip = 0x3000C6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDARRAYSIZE")]
        MessageIDCreatevideoprocessorinputviewInvalidarraysize = 0x3000C7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDARRAY")]
        MessageIDCreatevideoprocessorinputviewInvalidarray = 0x3000C8,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDDIMENSION")]
        MessageIDCreatevideoprocessorinputviewInvaliddimension = 0x3000C9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_OUTOFMEMORY_RETURN")]
        MessageIDCreatevideoprocessoroutputviewOutofmemoryReturn = 0x3000CA,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_NULLPARAM")]
        MessageIDCreatevideoprocessoroutputviewNullparam = 0x3000CB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDTYPE")]
        MessageIDCreatevideoprocessoroutputviewInvalidtype = 0x3000CC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDBIND")]
        MessageIDCreatevideoprocessoroutputviewInvalidbind = 0x3000CD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDFORMAT")]
        MessageIDCreatevideoprocessoroutputviewInvalidformat = 0x3000CE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDMIP")]
        MessageIDCreatevideoprocessoroutputviewInvalidmip = 0x3000CF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_UNSUPPORTEDMIP")]
        MessageIDCreatevideoprocessoroutputviewUnsupportedmip = 0x3000D0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_UNSUPPORTEDARRAY")]
        MessageIDCreatevideoprocessoroutputviewUnsupportedarray = 0x3000D1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDARRAY")]
        MessageIDCreatevideoprocessoroutputviewInvalidarray = 0x3000D2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDDIMENSION")]
        MessageIDCreatevideoprocessoroutputviewInvaliddimension = 0x3000D3,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_USE_OF_FORCED_SAMPLE_COUNT")]
        MessageIDDeviceDrawInvalidUseOfForcedSampleCount = 0x3000D4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBLENDSTATE_INVALIDLOGICOPS")]
        MessageIDCreateblendstateInvalidlogicops = 0x3000D5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDARRAYWITHDECODER")]
        MessageIDCreateshaderresourceviewInvaliddarraywithdecoder = 0x3000D6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDARRAYWITHDECODER")]
        MessageIDCreateunorderedaccessviewInvaliddarraywithdecoder = 0x3000D7,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDARRAYWITHDECODER")]
        MessageIDCreaterendertargetviewInvaliddarraywithdecoder = 0x3000D8,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_LOCKEDOUT_INTERFACE")]
        MessageIDDeviceLockedoutInterface = 0x3000D9,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_ATOMIC_INCONSISTENT")]
        MessageIDRefWarningAtomicInconsistent = 0x3000DA,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_READING_UNINITIALIZED_RESOURCE")]
        MessageIDRefWarningReadingUninitializedResource = 0x3000DB,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_RAW_HAZARD")]
        MessageIDRefWarningRawHazard = 0x3000DC,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_WAR_HAZARD")]
        MessageIDRefWarningWarHazard = 0x3000DD,
        [NativeName("Name", "D3D11_MESSAGE_ID_REF_WARNING_WAW_HAZARD")]
        MessageIDRefWarningWawHazard = 0x3000DE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECRYPTOSESSION_NULLPARAM")]
        MessageIDCreatecryptosessionNullparam = 0x3000DF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATECRYPTOSESSION_OUTOFMEMORY_RETURN")]
        MessageIDCreatecryptosessionOutofmemoryReturn = 0x3000E0,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOTYPE_NULLPARAM")]
        MessageIDGetcryptotypeNullparam = 0x3000E1,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDECODERPROFILE_NULLPARAM")]
        MessageIDGetdecoderprofileNullparam = 0x3000E2,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATESIZE_NULLPARAM")]
        MessageIDGetcryptosessioncertificatesizeNullparam = 0x3000E3,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATE_NULLPARAM")]
        MessageIDGetcryptosessioncertificateNullparam = 0x3000E4,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONCERTIFICATE_WRONGSIZE")]
        MessageIDGetcryptosessioncertificateWrongsize = 0x3000E5,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONHANDLE_WRONGSIZE")]
        MessageIDGetcryptosessionhandleWrongsize = 0x3000E6,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATECRPYTOSESSIONKEYEXCHANGE_NULLPARAM")]
        MessageIDNegotiatecrpytosessionkeyexchangeNullparam = 0x3000E7,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_UNSUPPORTED")]
        MessageIDEncryptionbltUnsupported = 0x3000E8,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_NULLPARAM")]
        MessageIDEncryptionbltNullparam = 0x3000E9,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_WRONGDEVICE")]
        MessageIDEncryptionbltSrcWrongdevice = 0x3000EA,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_WRONGDEVICE")]
        MessageIDEncryptionbltDstWrongdevice = 0x3000EB,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_FORMAT_MISMATCH")]
        MessageIDEncryptionbltFormatMismatch = 0x3000EC,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SIZE_MISMATCH")]
        MessageIDEncryptionbltSizeMismatch = 0x3000ED,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_MULTISAMPLED")]
        MessageIDEncryptionbltSrcMultisampled = 0x3000EE,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_NOT_STAGING")]
        MessageIDEncryptionbltDstNotStaging = 0x3000EF,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_MAPPED")]
        MessageIDEncryptionbltSrcMapped = 0x3000F0,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_MAPPED")]
        MessageIDEncryptionbltDstMapped = 0x3000F1,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_OFFERED")]
        MessageIDEncryptionbltSrcOffered = 0x3000F2,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_DST_OFFERED")]
        MessageIDEncryptionbltDstOffered = 0x3000F3,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENCRYPTIONBLT_SRC_CONTENT_UNDEFINED")]
        MessageIDEncryptionbltSrcContentUndefined = 0x3000F4,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_UNSUPPORTED")]
        MessageIDDecryptionbltUnsupported = 0x3000F5,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_NULLPARAM")]
        MessageIDDecryptionbltNullparam = 0x3000F6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_WRONGDEVICE")]
        MessageIDDecryptionbltSrcWrongdevice = 0x3000F7,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_WRONGDEVICE")]
        MessageIDDecryptionbltDstWrongdevice = 0x3000F8,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_FORMAT_MISMATCH")]
        MessageIDDecryptionbltFormatMismatch = 0x3000F9,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SIZE_MISMATCH")]
        MessageIDDecryptionbltSizeMismatch = 0x3000FA,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_MULTISAMPLED")]
        MessageIDDecryptionbltDstMultisampled = 0x3000FB,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_NOT_STAGING")]
        MessageIDDecryptionbltSrcNotStaging = 0x3000FC,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_NOT_RENDER_TARGET")]
        MessageIDDecryptionbltDstNotRenderTarget = 0x3000FD,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_MAPPED")]
        MessageIDDecryptionbltSrcMapped = 0x3000FE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_MAPPED")]
        MessageIDDecryptionbltDstMapped = 0x3000FF,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_OFFERED")]
        MessageIDDecryptionbltSrcOffered = 0x300100,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_DST_OFFERED")]
        MessageIDDecryptionbltDstOffered = 0x300101,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECRYPTIONBLT_SRC_CONTENT_UNDEFINED")]
        MessageIDDecryptionbltSrcContentUndefined = 0x300102,
        [NativeName("Name", "D3D11_MESSAGE_ID_STARTSESSIONKEYREFRESH_NULLPARAM")]
        MessageIDStartsessionkeyrefreshNullparam = 0x300103,
        [NativeName("Name", "D3D11_MESSAGE_ID_STARTSESSIONKEYREFRESH_INVALIDSIZE")]
        MessageIDStartsessionkeyrefreshInvalidsize = 0x300104,
        [NativeName("Name", "D3D11_MESSAGE_ID_FINISHSESSIONKEYREFRESH_NULLPARAM")]
        MessageIDFinishsessionkeyrefreshNullparam = 0x300105,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETENCRYPTIONBLTKEY_NULLPARAM")]
        MessageIDGetencryptionbltkeyNullparam = 0x300106,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETENCRYPTIONBLTKEY_INVALIDSIZE")]
        MessageIDGetencryptionbltkeyInvalidsize = 0x300107,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCONTENTPROTECTIONCAPS_NULLPARAM")]
        MessageIDGetcontentprotectioncapsNullparam = 0x300108,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCRYPTOKEYEXCHANGE_NULLPARAM")]
        MessageIDCheckcryptokeyexchangeNullparam = 0x300109,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCRYPTOKEYEXCHANGE_INVALIDINDEX")]
        MessageIDCheckcryptokeyexchangeInvalidindex = 0x30010A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_NULLPARAM")]
        MessageIDCreateauthenticatedchannelNullparam = 0x30010B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_UNSUPPORTED")]
        MessageIDCreateauthenticatedchannelUnsupported = 0x30010C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_INVALIDTYPE")]
        MessageIDCreateauthenticatedchannelInvalidtype = 0x30010D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEAUTHENTICATEDCHANNEL_OUTOFMEMORY_RETURN")]
        MessageIDCreateauthenticatedchannelOutofmemoryReturn = 0x30010E,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATESIZE_INVALIDCHANNEL")]
        MessageIDGetauthenticatedchannelcertificatesizeInvalidchannel = 0x30010F,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATESIZE_NULLPARAM")]
        MessageIDGetauthenticatedchannelcertificatesizeNullparam = 0x300110,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_INVALIDCHANNEL")]
        MessageIDGetauthenticatedchannelcertificateInvalidchannel = 0x300111,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_NULLPARAM")]
        MessageIDGetauthenticatedchannelcertificateNullparam = 0x300112,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETAUTHENTICATEDCHANNELCERTIFICATE_WRONGSIZE")]
        MessageIDGetauthenticatedchannelcertificateWrongsize = 0x300113,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_INVALIDCHANNEL")]
        MessageIDNegotiateauthenticatedchannelkeyexchangeInvalidchannel = 0x300114,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_NULLPARAM")]
        MessageIDNegotiateauthenticatedchannelkeyexchangeNullparam = 0x300115,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_NULLPARAM")]
        MessageIDQueryauthenticatedchannelNullparam = 0x300116,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_WRONGCHANNEL")]
        MessageIDQueryauthenticatedchannelWrongchannel = 0x300117,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_UNSUPPORTEDQUERY")]
        MessageIDQueryauthenticatedchannelUnsupportedquery = 0x300118,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_WRONGSIZE")]
        MessageIDQueryauthenticatedchannelWrongsize = 0x300119,
        [NativeName("Name", "D3D11_MESSAGE_ID_QUERYAUTHENTICATEDCHANNEL_INVALIDPROCESSINDEX")]
        MessageIDQueryauthenticatedchannelInvalidprocessindex = 0x30011A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_NULLPARAM")]
        MessageIDConfigureauthenticatedchannelNullparam = 0x30011B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_WRONGCHANNEL")]
        MessageIDConfigureauthenticatedchannelWrongchannel = 0x30011C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_UNSUPPORTEDCONFIGURE")]
        MessageIDConfigureauthenticatedchannelUnsupportedconfigure = 0x30011D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_WRONGSIZE")]
        MessageIDConfigureauthenticatedchannelWrongsize = 0x30011E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CONFIGUREAUTHENTICATEDCHANNEL_INVALIDPROCESSIDTYPE")]
        MessageIDConfigureauthenticatedchannelInvalidprocessidtype = 0x30011F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        MessageIDVssetconstantbuffersInvalidbufferoffsetorcount = 0x300120,
        [NativeName("Name", "D3D11_MESSAGE_ID_DSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        MessageIDDssetconstantbuffersInvalidbufferoffsetorcount = 0x300121,
        [NativeName("Name", "D3D11_MESSAGE_ID_HSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        MessageIDHssetconstantbuffersInvalidbufferoffsetorcount = 0x300122,
        [NativeName("Name", "D3D11_MESSAGE_ID_GSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        MessageIDGssetconstantbuffersInvalidbufferoffsetorcount = 0x300123,
        [NativeName("Name", "D3D11_MESSAGE_ID_PSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        MessageIDPssetconstantbuffersInvalidbufferoffsetorcount = 0x300124,
        [NativeName("Name", "D3D11_MESSAGE_ID_CSSETCONSTANTBUFFERS_INVALIDBUFFEROFFSETORCOUNT")]
        MessageIDCssetconstantbuffersInvalidbufferoffsetorcount = 0x300125,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATECRPYTOSESSIONKEYEXCHANGE_INVALIDSIZE")]
        MessageIDNegotiatecrpytosessionkeyexchangeInvalidsize = 0x300126,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATEAUTHENTICATEDCHANNELKEYEXCHANGE_INVALIDSIZE")]
        MessageIDNegotiateauthenticatedchannelkeyexchangeInvalidsize = 0x300127,
        [NativeName("Name", "D3D11_MESSAGE_ID_OFFERRESOURCES_INVALIDPRIORITY")]
        MessageIDOfferresourcesInvalidpriority = 0x300128,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONHANDLE_OUTOFMEMORY")]
        MessageIDGetcryptosessionhandleOutofmemory = 0x300129,
        [NativeName("Name", "D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_NULLPARAM")]
        MessageIDAcquirehandleforcaptureNullparam = 0x30012A,
        [NativeName("Name", "D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDTYPE")]
        MessageIDAcquirehandleforcaptureInvalidtype = 0x30012B,
        [NativeName("Name", "D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDBIND")]
        MessageIDAcquirehandleforcaptureInvalidbind = 0x30012C,
        [NativeName("Name", "D3D11_MESSAGE_ID_ACQUIREHANDLEFORCAPTURE_INVALIDARRAY")]
        MessageIDAcquirehandleforcaptureInvalidarray = 0x30012D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_NULLPARAM")]
        MessageIDVideoprocessorsetstreamrotationNullparam = 0x30012E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamrotationInvalidstream = 0x30012F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_INVALID")]
        MessageIDVideoprocessorsetstreamrotationInvalid = 0x300130,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMROTATION_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreamrotationUnsupported = 0x300131,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMROTATION_NULLPARAM")]
        MessageIDVideoprocessorgetstreamrotationNullparam = 0x300132,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDVIEW")]
        MessageIDDeviceClearviewInvalidview = 0x300133,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderDoubleextensionsnotsupported = 0x300134,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderShaderextensionsnotsupported = 0x300135,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderDoubleextensionsnotsupported = 0x300136,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderShaderextensionsnotsupported = 0x300137,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderDoubleextensionsnotsupported = 0x300138,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderShaderextensionsnotsupported = 0x300139,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderDoubleextensionsnotsupported = 0x30013A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderShaderextensionsnotsupported = 0x30013B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputDoubleextensionsnotsupported = 0x30013C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputShaderextensionsnotsupported = 0x30013D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderDoubleextensionsnotsupported = 0x30013E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderShaderextensionsnotsupported = 0x30013F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderDoubleextensionsnotsupported = 0x300140,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_SHADEREXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderShaderextensionsnotsupported = 0x300141,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SHADER_LINKAGE_MINPRECISION")]
        MessageIDDeviceShaderLinkageMinprecision = 0x300142,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMALPHA_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreamalphaUnsupported = 0x300143,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMPIXELASPECTRATIO_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreampixelaspectratioUnsupported = 0x300144,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderUavsnotsupported = 0x300145,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEHULLSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderUavsnotsupported = 0x300146,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderUavsnotsupported = 0x300147,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderUavsnotsupported = 0x300148,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputUavsnotsupported = 0x300149,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderUavsnotsupported = 0x30014A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderUavsnotsupported = 0x30014B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_INVALIDOFFSET")]
        MessageIDDeviceOmsetrendertargetsandunorderedaccessviewsInvalidoffset = 0x30014C,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OMSETRENDERTARGETSANDUNORDEREDACCESSVIEWS_TOOMANYVIEWS")]
        MessageIDDeviceOmsetrendertargetsandunorderedaccessviewsToomanyviews = 0x30014D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_NOTSUPPORTED")]
        MessageIDDeviceClearviewNotsupported = 0x30014E,
        [NativeName("Name", "D3D11_MESSAGE_ID_SWAPDEVICECONTEXTSTATE_NOTSUPPORTED")]
        MessageIDSwapdevicecontextstateNotsupported = 0x30014F,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_PREFERUPDATESUBRESOURCE1")]
        MessageIDUpdatesubresourcePreferupdatesubresource1 = 0x300150,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDC_INACCESSIBLE")]
        MessageIDGetdcInaccessible = 0x300151,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDRECT")]
        MessageIDDeviceClearviewInvalidrect = 0x300152,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_SAMPLE_MASK_IGNORED_ON_FL9")]
        MessageIDDeviceDrawSampleMaskIgnoredOnFL9 = 0x300153,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE1_NOT_SUPPORTED")]
        MessageIDDeviceOpenSharedResource1NotSupported = 0x300154,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_OPEN_SHARED_RESOURCE_BY_NAME_NOT_SUPPORTED")]
        MessageIDDeviceOpenSharedResourceByNameNotSupported = 0x300155,
        [NativeName("Name", "D3D11_MESSAGE_ID_ENQUEUESETEVENT_NOT_SUPPORTED")]
        MessageIDEnqueueseteventNotSupported = 0x300156,
        [NativeName("Name", "D3D11_MESSAGE_ID_OFFERRELEASE_NOT_SUPPORTED")]
        MessageIDOfferreleaseNotSupported = 0x300157,
        [NativeName("Name", "D3D11_MESSAGE_ID_OFFERRESOURCES_INACCESSIBLE")]
        MessageIDOfferresourcesInaccessible = 0x300158,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSORINPUTVIEW_INVALIDMSAA")]
        MessageIDCreatevideoprocessorinputviewInvalidmsaa = 0x300159,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEVIDEOPROCESSOROUTPUTVIEW_INVALIDMSAA")]
        MessageIDCreatevideoprocessoroutputviewInvalidmsaa = 0x30015A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDSOURCERECT")]
        MessageIDDeviceClearviewInvalidsourcerect = 0x30015B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_CLEARVIEW_EMPTYRECT")]
        MessageIDDeviceClearviewEmptyrect = 0x30015C,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATESUBRESOURCE_EMPTYDESTBOX")]
        MessageIDUpdatesubresourceEmptydestbox = 0x30015D,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYSUBRESOURCEREGION_EMPTYSOURCEBOX")]
        MessageIDCopysubresourceregionEmptysourcebox = 0x30015E,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_OM_RENDER_TARGET_DOES_NOT_SUPPORT_LOGIC_OPS")]
        MessageIDDeviceDrawOMRenderTargetDoesNotSupportLogicOps = 0x30015F,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_DEPTHSTENCILVIEW_NOT_SET")]
        MessageIDDeviceDrawDepthstencilviewNotSet = 0x300160,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RENDERTARGETVIEW_NOT_SET")]
        MessageIDDeviceDrawRendertargetviewNotSet = 0x300161,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_RENDERTARGETVIEW_NOT_SET_DUE_TO_FLIP_PRESENT")]
        MessageIDDeviceDrawRendertargetviewNotSetDueToFlipPresent = 0x300162,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_UNORDEREDACCESSVIEW_NOT_SET_DUE_TO_FLIP_PRESENT")]
        MessageIDDeviceUnorderedaccessviewNotSetDueToFlipPresent = 0x300163,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETDATAFORNEWHARDWAREKEY_NULLPARAM")]
        MessageIDGetdatafornewhardwarekeyNullparam = 0x300164,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKCRYPTOSESSIONSTATUS_NULLPARAM")]
        MessageIDCheckcryptosessionstatusNullparam = 0x300165,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONPRIVATEDATASIZE_NULLPARAM")]
        MessageIDGetcryptosessionprivatedatasizeNullparam = 0x300166,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCAPS_NULLPARAM")]
        MessageIDGetvideodecodercapsNullparam = 0x300167,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETVIDEODECODERCAPS_ZEROWIDTHHEIGHT")]
        MessageIDGetvideodecodercapsZerowidthheight = 0x300168,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_NULLPARAM")]
        MessageIDCheckvideodecoderdownsamplingNullparam = 0x300169,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_INVALIDCOLORSPACE")]
        MessageIDCheckvideodecoderdownsamplingInvalidcolorspace = 0x30016A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEODECODERDOWNSAMPLING_ZEROWIDTHHEIGHT")]
        MessageIDCheckvideodecoderdownsamplingZerowidthheight = 0x30016B,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEODECODERENABLEDOWNSAMPLING_NULLPARAM")]
        MessageIDVideodecoderenabledownsamplingNullparam = 0x30016C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEODECODERENABLEDOWNSAMPLING_UNSUPPORTED")]
        MessageIDVideodecoderenabledownsamplingUnsupported = 0x30016D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEODECODERUPDATEDOWNSAMPLING_NULLPARAM")]
        MessageIDVideodecoderupdatedownsamplingNullparam = 0x30016E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEODECODERUPDATEDOWNSAMPLING_UNSUPPORTED")]
        MessageIDVideodecoderupdatedownsamplingUnsupported = 0x30016F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKVIDEOPROCESSORFORMATCONVERSION_NULLPARAM")]
        MessageIDCheckvideoprocessorformatconversionNullparam = 0x300170,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTCOLORSPACE1_NULLPARAM")]
        MessageIDVideoprocessorsetoutputcolorspace1Nullparam = 0x300171,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTCOLORSPACE1_NULLPARAM")]
        MessageIDVideoprocessorgetoutputcolorspace1Nullparam = 0x300172,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE1_NULLPARAM")]
        MessageIDVideoprocessorsetstreamcolorspace1Nullparam = 0x300173,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMCOLORSPACE1_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamcolorspace1Invalidstream = 0x300174,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_NULLPARAM")]
        MessageIDVideoprocessorsetstreammirrorNullparam = 0x300175,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreammirrorInvalidstream = 0x300176,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMMIRROR_UNSUPPORTED")]
        MessageIDVideoprocessorsetstreammirrorUnsupported = 0x300177,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE1_NULLPARAM")]
        MessageIDVideoprocessorgetstreamcolorspace1Nullparam = 0x300178,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMMIRROR_NULLPARAM")]
        MessageIDVideoprocessorgetstreammirrorNullparam = 0x300179,
        [NativeName("Name", "D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_NULLPARAM")]
        MessageIDRecommendvideodecoderdownsamplingNullparam = 0x30017A,
        [NativeName("Name", "D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_INVALIDCOLORSPACE")]
        MessageIDRecommendvideodecoderdownsamplingInvalidcolorspace = 0x30017B,
        [NativeName("Name", "D3D11_MESSAGE_ID_RECOMMENDVIDEODECODERDOWNSAMPLING_ZEROWIDTHHEIGHT")]
        MessageIDRecommendvideodecoderdownsamplingZerowidthheight = 0x30017C,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTSHADERUSAGE_NULLPARAM")]
        MessageIDVideoprocessorsetoutputshaderusageNullparam = 0x30017D,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTSHADERUSAGE_NULLPARAM")]
        MessageIDVideoprocessorgetoutputshaderusageNullparam = 0x30017E,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_NULLPARAM")]
        MessageIDVideoprocessorgetbehaviorhintsNullparam = 0x30017F,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDSTREAMCOUNT")]
        MessageIDVideoprocessorgetbehaviorhintsInvalidstreamcount = 0x300180,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_TARGETRECT")]
        MessageIDVideoprocessorgetbehaviorhintsTargetrect = 0x300181,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDSOURCERECT")]
        MessageIDVideoprocessorgetbehaviorhintsInvalidsourcerect = 0x300182,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETBEHAVIORHINTS_INVALIDDESTRECT")]
        MessageIDVideoprocessorgetbehaviorhintsInvaliddestrect = 0x300183,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETCRYPTOSESSIONPRIVATEDATASIZE_INVALID_KEY_EXCHANGE_TYPE")]
        MessageIDGetcryptosessionprivatedatasizeInvalidKeyExchangeType = 0x300184,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_1_MESSAGES_END")]
        MessageIDD3D111MessagesEnd = 0x300185,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_2_MESSAGES_START")]
        MessageIDD3D112MessagesStart = 0x300186,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEBUFFER_INVALIDUSAGE")]
        MessageIDCreatebufferInvalidusage = 0x300187,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE1D_INVALIDUSAGE")]
        MessageIDCreatetexture1DInvalidusage = 0x300188,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATETEXTURE2D_INVALIDUSAGE")]
        MessageIDCreatetexture2DInvalidusage = 0x300189,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_LEVEL9_STEPRATE_NOT_1")]
        MessageIDCreateinputlayoutLevel9SteprateNot1 = 0x30018A,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEINPUTLAYOUT_LEVEL9_INSTANCING_NOT_SUPPORTED")]
        MessageIDCreateinputlayoutLevel9InstancingNotSupported = 0x30018B,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATETILEMAPPINGS_INVALID_PARAMETER")]
        MessageIDUpdatetilemappingsInvalidParameter = 0x30018C,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYTILEMAPPINGS_INVALID_PARAMETER")]
        MessageIDCopytilemappingsInvalidParameter = 0x30018D,
        [NativeName("Name", "D3D11_MESSAGE_ID_COPYTILES_INVALID_PARAMETER")]
        MessageIDCopytilesInvalidParameter = 0x30018E,
        [NativeName("Name", "D3D11_MESSAGE_ID_UPDATETILES_INVALID_PARAMETER")]
        MessageIDUpdatetilesInvalidParameter = 0x30018F,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESIZETILEPOOL_INVALID_PARAMETER")]
        MessageIDResizetilepoolInvalidParameter = 0x300190,
        [NativeName("Name", "D3D11_MESSAGE_ID_TILEDRESOURCEBARRIER_INVALID_PARAMETER")]
        MessageIDTiledresourcebarrierInvalidParameter = 0x300191,
        [NativeName("Name", "D3D11_MESSAGE_ID_NULL_TILE_MAPPING_ACCESS_WARNING")]
        MessageIDNullTileMappingAccessWarning = 0x300192,
        [NativeName("Name", "D3D11_MESSAGE_ID_NULL_TILE_MAPPING_ACCESS_ERROR")]
        MessageIDNullTileMappingAccessError = 0x300193,
        [NativeName("Name", "D3D11_MESSAGE_ID_DIRTY_TILE_MAPPING_ACCESS")]
        MessageIDDirtyTileMappingAccess = 0x300194,
        [NativeName("Name", "D3D11_MESSAGE_ID_DUPLICATE_TILE_MAPPINGS_IN_COVERED_AREA")]
        MessageIDDuplicateTileMappingsInCoveredArea = 0x300195,
        [NativeName("Name", "D3D11_MESSAGE_ID_TILE_MAPPINGS_IN_COVERED_AREA_DUPLICATED_OUTSIDE")]
        MessageIDTileMappingsInCoveredAreaDuplicatedOutside = 0x300196,
        [NativeName("Name", "D3D11_MESSAGE_ID_TILE_MAPPINGS_SHARED_BETWEEN_INCOMPATIBLE_RESOURCES")]
        MessageIDTileMappingsSharedBetweenIncompatibleResources = 0x300197,
        [NativeName("Name", "D3D11_MESSAGE_ID_TILE_MAPPINGS_SHARED_BETWEEN_INPUT_AND_OUTPUT")]
        MessageIDTileMappingsSharedBetweenInputAndOutput = 0x300198,
        [NativeName("Name", "D3D11_MESSAGE_ID_CHECKMULTISAMPLEQUALITYLEVELS_INVALIDFLAGS")]
        MessageIDCheckmultisamplequalitylevelsInvalidflags = 0x300199,
        [NativeName("Name", "D3D11_MESSAGE_ID_GETRESOURCETILING_NONTILED_RESOURCE")]
        MessageIDGetresourcetilingNontiledResource = 0x30019A,
        [NativeName("Name", "D3D11_MESSAGE_ID_RESIZETILEPOOL_SHRINK_WITH_MAPPINGS_STILL_DEFINED_PAST_END")]
        MessageIDResizetilepoolShrinkWithMappingsStillDefinedPastEnd = 0x30019B,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEED_TO_CALL_TILEDRESOURCEBARRIER")]
        MessageIDNeedToCallTiledresourcebarrier = 0x30019C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICE_INVALIDARGS")]
        MessageIDCreatedeviceInvalidargs = 0x30019D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEDEVICE_WARNING")]
        MessageIDCreatedeviceWarning = 0x30019E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWUINT_HAZARD")]
        MessageIDClearunorderedaccessviewuintHazard = 0x30019F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CLEARUNORDEREDACCESSVIEWFLOAT_HAZARD")]
        MessageIDClearunorderedaccessviewfloatHazard = 0x3001A0,
        [NativeName("Name", "D3D11_MESSAGE_ID_TILED_RESOURCE_TIER_1_BUFFER_TEXTURE_MISMATCH")]
        MessageIDTiledResourceTier1BufferTextureMismatch = 0x3001A1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_CRYPTOSESSION")]
        MessageIDCreateCryptosession = 0x3001A2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_AUTHENTICATEDCHANNEL")]
        MessageIDCreateAuthenticatedchannel = 0x3001A3,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_CRYPTOSESSION")]
        MessageIDLiveCryptosession = 0x3001A4,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_AUTHENTICATEDCHANNEL")]
        MessageIDLiveAuthenticatedchannel = 0x3001A5,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_CRYPTOSESSION")]
        MessageIDDestroyCryptosession = 0x3001A6,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_AUTHENTICATEDCHANNEL")]
        MessageIDDestroyAuthenticatedchannel = 0x3001A7,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_2_MESSAGES_END")]
        MessageIDD3D112MessagesEnd = 0x3001A8,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_3_MESSAGES_START")]
        MessageIDD3D113MessagesStart = 0x3001A9,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_CONSERVATIVERASTERMODE")]
        MessageIDCreaterasterizerstateInvalidConservativerastermode = 0x3001AA,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_DRAW_INVALID_SYSTEMVALUE")]
        MessageIDDeviceDrawInvalidSystemvalue = 0x3001AB,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_INVALIDCONTEXTTYPE")]
        MessageIDCreatequeryorpredicateInvalidcontexttype = 0x3001AC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_DECODENOTSUPPORTED")]
        MessageIDCreatequeryorpredicateDecodenotsupported = 0x3001AD,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_ENCODENOTSUPPORTED")]
        MessageIDCreatequeryorpredicateEncodenotsupported = 0x3001AE,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDPLANEINDEX")]
        MessageIDCreateshaderresourceviewInvalidplaneindex = 0x3001AF,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDVIDEOPLANEINDEX")]
        MessageIDCreateshaderresourceviewInvalidvideoplaneindex = 0x3001B0,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATESHADERRESOURCEVIEW_AMBIGUOUSVIDEOPLANEINDEX")]
        MessageIDCreateshaderresourceviewAmbiguousvideoplaneindex = 0x3001B1,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDPLANEINDEX")]
        MessageIDCreaterendertargetviewInvalidplaneindex = 0x3001B2,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDVIDEOPLANEINDEX")]
        MessageIDCreaterendertargetviewInvalidvideoplaneindex = 0x3001B3,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATERENDERTARGETVIEW_AMBIGUOUSVIDEOPLANEINDEX")]
        MessageIDCreaterendertargetviewAmbiguousvideoplaneindex = 0x3001B4,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDPLANEINDEX")]
        MessageIDCreateunorderedaccessviewInvalidplaneindex = 0x3001B5,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDVIDEOPLANEINDEX")]
        MessageIDCreateunorderedaccessviewInvalidvideoplaneindex = 0x3001B6,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_AMBIGUOUSVIDEOPLANEINDEX")]
        MessageIDCreateunorderedaccessviewAmbiguousvideoplaneindex = 0x3001B7,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSCANDATAOFFSET")]
        MessageIDJpegdecodeInvalidscandataoffset = 0x3001B8,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_NOTSUPPORTED")]
        MessageIDJpegdecodeNotsupported = 0x3001B9,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DIMENSIONSTOOLARGE")]
        MessageIDJpegdecodeDimensionstoolarge = 0x3001BA,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDCOMPONENTS")]
        MessageIDJpegdecodeInvalidcomponents = 0x3001BB,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DESTINATIONNOT2D")]
        MessageIDJpegdecodeDestinationnot2D = 0x3001BC,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_TILEDRESOURCESUNSUPPORTED")]
        MessageIDJpegdecodeTiledresourcesunsupported = 0x3001BD,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_GUARDRECTSUNSUPPORTED")]
        MessageIDJpegdecodeGuardrectsunsupported = 0x3001BE,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_FORMATUNSUPPORTED")]
        MessageIDJpegdecodeFormatunsupported = 0x3001BF,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSUBRESOURCE")]
        MessageIDJpegdecodeInvalidsubresource = 0x3001C0,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDMIPLEVEL")]
        MessageIDJpegdecodeInvalidmiplevel = 0x3001C1,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_EMPTYDESTBOX")]
        MessageIDJpegdecodeEmptydestbox = 0x3001C2,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXNOT2D")]
        MessageIDJpegdecodeDestboxnot2D = 0x3001C3,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXNOTSUB")]
        MessageIDJpegdecodeDestboxnotsub = 0x3001C4,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_DESTBOXESINTERSECT")]
        MessageIDJpegdecodeDestboxesintersect = 0x3001C5,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_XSUBSAMPLEMISMATCH")]
        MessageIDJpegdecodeXsubsamplemismatch = 0x3001C6,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_YSUBSAMPLEMISMATCH")]
        MessageIDJpegdecodeYsubsamplemismatch = 0x3001C7,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_XSUBSAMPLEODD")]
        MessageIDJpegdecodeXsubsampleodd = 0x3001C8,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_YSUBSAMPLEODD")]
        MessageIDJpegdecodeYsubsampleodd = 0x3001C9,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_OUTPUTDIMENSIONSTOOLARGE")]
        MessageIDJpegdecodeOutputdimensionstoolarge = 0x3001CA,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_NONPOW2SCALEUNSUPPORTED")]
        MessageIDJpegdecodeNonpow2Scaleunsupported = 0x3001CB,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_FRACTIONALDOWNSCALETOLARGE")]
        MessageIDJpegdecodeFractionaldownscaletolarge = 0x3001CC,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_CHROMASIZEMISMATCH")]
        MessageIDJpegdecodeChromasizemismatch = 0x3001CD,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_LUMACHROMASIZEMISMATCH")]
        MessageIDJpegdecodeLumachromasizemismatch = 0x3001CE,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDNUMDESTINATIONS")]
        MessageIDJpegdecodeInvalidnumdestinations = 0x3001CF,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_SUBBOXUNSUPPORTED")]
        MessageIDJpegdecodeSubboxunsupported = 0x3001D0,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_1DESTUNSUPPORTEDFORMAT")]
        MessageIDJpegdecode1Destunsupportedformat = 0x3001D1,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_3DESTUNSUPPORTEDFORMAT")]
        MessageIDJpegdecode3Destunsupportedformat = 0x3001D2,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_SCALEUNSUPPORTED")]
        MessageIDJpegdecodeScaleunsupported = 0x3001D3,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDSOURCESIZE")]
        MessageIDJpegdecodeInvalidsourcesize = 0x3001D4,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_INVALIDCOPYFLAGS")]
        MessageIDJpegdecodeInvalidcopyflags = 0x3001D5,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_HAZARD")]
        MessageIDJpegdecodeHazard = 0x3001D6,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDSRCBUFFERUSAGE")]
        MessageIDJpegdecodeUnsupportedsrcbufferusage = 0x3001D7,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDSRCBUFFERMISCFLAGS")]
        MessageIDJpegdecodeUnsupportedsrcbuffermiscflags = 0x3001D8,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPORTEDDSTTEXTUREUSAGE")]
        MessageIDJpegdecodeUnsupporteddsttextureusage = 0x3001D9,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_BACKBUFFERNOTSUPPORTED")]
        MessageIDJpegdecodeBackbuffernotsupported = 0x3001DA,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGDECODE_UNSUPPRTEDCOPYFLAGS")]
        MessageIDJpegdecodeUnsupprtedcopyflags = 0x3001DB,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_NOTSUPPORTED")]
        MessageIDJpegencodeNotsupported = 0x3001DC,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_INVALIDSCANDATAOFFSET")]
        MessageIDJpegencodeInvalidscandataoffset = 0x3001DD,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_INVALIDCOMPONENTS")]
        MessageIDJpegencodeInvalidcomponents = 0x3001DE,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_SOURCENOT2D")]
        MessageIDJpegencodeSourcenot2D = 0x3001DF,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_TILEDRESOURCESUNSUPPORTED")]
        MessageIDJpegencodeTiledresourcesunsupported = 0x3001E0,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_GUARDRECTSUNSUPPORTED")]
        MessageIDJpegencodeGuardrectsunsupported = 0x3001E1,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_XSUBSAMPLEMISMATCH")]
        MessageIDJpegencodeXsubsamplemismatch = 0x3001E2,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_YSUBSAMPLEMISMATCH")]
        MessageIDJpegencodeYsubsamplemismatch = 0x3001E3,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_FORMATUNSUPPORTED")]
        MessageIDJpegencodeFormatunsupported = 0x3001E4,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_INVALIDSUBRESOURCE")]
        MessageIDJpegencodeInvalidsubresource = 0x3001E5,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_INVALIDMIPLEVEL")]
        MessageIDJpegencodeInvalidmiplevel = 0x3001E6,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_DIMENSIONSTOOLARGE")]
        MessageIDJpegencodeDimensionstoolarge = 0x3001E7,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_HAZARD")]
        MessageIDJpegencodeHazard = 0x3001E8,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDDSTBUFFERUSAGE")]
        MessageIDJpegencodeUnsupporteddstbufferusage = 0x3001E9,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDDSTBUFFERMISCFLAGS")]
        MessageIDJpegencodeUnsupporteddstbuffermiscflags = 0x3001EA,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_UNSUPPORTEDSRCTEXTUREUSAGE")]
        MessageIDJpegencodeUnsupportedsrctextureusage = 0x3001EB,
        [NativeName("Name", "D3D11_MESSAGE_ID_JPEGENCODE_BACKBUFFERNOTSUPPORTED")]
        MessageIDJpegencodeBackbuffernotsupported = 0x3001EC,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEQUERYORPREDICATE_UNSUPPORTEDCONTEXTTTYPEFORQUERY")]
        MessageIDCreatequeryorpredicateUnsupportedcontextttypeforquery = 0x3001ED,
        [NativeName("Name", "D3D11_MESSAGE_ID_FLUSH1_INVALIDCONTEXTTYPE")]
        MessageIDFlush1Invalidcontexttype = 0x3001EE,
        [NativeName("Name", "D3D11_MESSAGE_ID_DEVICE_SETHARDWAREPROTECTION_INVALIDCONTEXT")]
        MessageIDDeviceSethardwareprotectionInvalidcontext = 0x3001EF,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTHDRMETADATA_NULLPARAM")]
        MessageIDVideoprocessorsetoutputhdrmetadataNullparam = 0x3001F0,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETOUTPUTHDRMETADATA_INVALIDSIZE")]
        MessageIDVideoprocessorsetoutputhdrmetadataInvalidsize = 0x3001F1,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTHDRMETADATA_NULLPARAM")]
        MessageIDVideoprocessorgetoutputhdrmetadataNullparam = 0x3001F2,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETOUTPUTHDRMETADATA_INVALIDSIZE")]
        MessageIDVideoprocessorgetoutputhdrmetadataInvalidsize = 0x3001F3,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_NULLPARAM")]
        MessageIDVideoprocessorsetstreamhdrmetadataNullparam = 0x3001F4,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_INVALIDSTREAM")]
        MessageIDVideoprocessorsetstreamhdrmetadataInvalidstream = 0x3001F5,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORSETSTREAMHDRMETADATA_INVALIDSIZE")]
        MessageIDVideoprocessorsetstreamhdrmetadataInvalidsize = 0x3001F6,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_NULLPARAM")]
        MessageIDVideoprocessorgetstreamhdrmetadataNullparam = 0x3001F7,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamhdrmetadataInvalidstream = 0x3001F8,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMHDRMETADATA_INVALIDSIZE")]
        MessageIDVideoprocessorgetstreamhdrmetadataInvalidsize = 0x3001F9,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFRAMEFORMAT_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamframeformatInvalidstream = 0x3001FA,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamcolorspaceInvalidstream = 0x3001FB,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMOUTPUTRATE_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamoutputrateInvalidstream = 0x3001FC,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSOURCERECT_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamsourcerectInvalidstream = 0x3001FD,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMDESTRECT_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamdestrectInvalidstream = 0x3001FE,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMALPHA_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamalphaInvalidstream = 0x3001FF,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPALETTE_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreampaletteInvalidstream = 0x300200,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMPIXELASPECTRATIO_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreampixelaspectratioInvalidstream = 0x300201,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMLUMAKEY_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamlumakeyInvalidstream = 0x300202,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMSTEREOFORMAT_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamstereoformatInvalidstream = 0x300203,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMAUTOPROCESSINGMODE_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamautoprocessingmodeInvalidstream = 0x300204,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMFILTER_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamfilterInvalidstream = 0x300205,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMROTATION_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamrotationInvalidstream = 0x300206,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMCOLORSPACE1_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreamcolorspace1Invalidstream = 0x300207,
        [NativeName("Name", "D3D11_MESSAGE_ID_VIDEOPROCESSORGETSTREAMMIRROR_INVALIDSTREAM")]
        MessageIDVideoprocessorgetstreammirrorInvalidstream = 0x300208,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_FENCE")]
        MessageIDCreateFence = 0x300209,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_FENCE")]
        MessageIDLiveFence = 0x30020A,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_FENCE")]
        MessageIDDestroyFence = 0x30020B,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_SYNCHRONIZEDCHANNEL")]
        MessageIDCreateSynchronizedchannel = 0x30020C,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_SYNCHRONIZEDCHANNEL")]
        MessageIDLiveSynchronizedchannel = 0x30020D,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_SYNCHRONIZEDCHANNEL")]
        MessageIDDestroySynchronizedchannel = 0x30020E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATEFENCE_INVALIDFLAGS")]
        MessageIDCreatefenceInvalidflags = 0x30020F,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_3_MESSAGES_END")]
        MessageIDD3D113MessagesEnd = 0x300210,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_5_MESSAGES_START")]
        MessageIDD3D115MessagesStart = 0x300211,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATECRYPTOSESSIONKEYEXCHANGEMT_INVALIDKEYEXCHANGETYPE")]
        MessageIDNegotiatecryptosessionkeyexchangemtInvalidkeyexchangetype = 0x300212,
        [NativeName("Name", "D3D11_MESSAGE_ID_NEGOTIATECRYPTOSESSIONKEYEXCHANGEMT_NOT_SUPPORTED")]
        MessageIDNegotiatecryptosessionkeyexchangemtNotSupported = 0x300213,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_COMPONENT_COUNT")]
        MessageIDDecoderbeginframeInvalidHistogramComponentCount = 0x300214,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_COMPONENT")]
        MessageIDDecoderbeginframeInvalidHistogramComponent = 0x300215,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_SIZE")]
        MessageIDDecoderbeginframeInvalidHistogramBufferSize = 0x300216,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_USAGE")]
        MessageIDDecoderbeginframeInvalidHistogramBufferUsage = 0x300217,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_MISC_FLAGS")]
        MessageIDDecoderbeginframeInvalidHistogramBufferMiscFlags = 0x300218,
        [NativeName("Name", "D3D11_MESSAGE_ID_DECODERBEGINFRAME_INVALID_HISTOGRAM_BUFFER_OFFSET")]
        MessageIDDecoderbeginframeInvalidHistogramBufferOffset = 0x300219,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKEDWORKLOAD")]
        MessageIDCreateTrackedworkload = 0x30021A,
        [NativeName("Name", "D3D11_MESSAGE_ID_LIVE_TRACKEDWORKLOAD")]
        MessageIDLiveTrackedworkload = 0x30021B,
        [NativeName("Name", "D3D11_MESSAGE_ID_DESTROY_TRACKEDWORKLOAD")]
        MessageIDDestroyTrackedworkload = 0x30021C,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_NULLPARAM")]
        MessageIDCreateTrackedWorkloadNullparam = 0x30021D,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_MAX_INSTANCES")]
        MessageIDCreateTrackedWorkloadInvalidMaxInstances = 0x30021E,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_DEADLINE_TYPE")]
        MessageIDCreateTrackedWorkloadInvalidDeadlineType = 0x30021F,
        [NativeName("Name", "D3D11_MESSAGE_ID_CREATE_TRACKED_WORKLOAD_INVALID_ENGINE_TYPE")]
        MessageIDCreateTrackedWorkloadInvalidEngineType = 0x300220,
        [NativeName("Name", "D3D11_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOADS")]
        MessageIDMultipleTrackedWorkloads = 0x300221,
        [NativeName("Name", "D3D11_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOAD_PAIRS")]
        MessageIDMultipleTrackedWorkloadPairs = 0x300222,
        [NativeName("Name", "D3D11_MESSAGE_ID_INCOMPLETE_TRACKED_WORKLOAD_PAIR")]
        MessageIDIncompleteTrackedWorkloadPair = 0x300223,
        [NativeName("Name", "D3D11_MESSAGE_ID_OUT_OF_ORDER_TRACKED_WORKLOAD_PAIR")]
        MessageIDOutOfOrderTrackedWorkloadPair = 0x300224,
        [NativeName("Name", "D3D11_MESSAGE_ID_CANNOT_ADD_TRACKED_WORKLOAD")]
        MessageIDCannotAddTrackedWorkload = 0x300225,
        [NativeName("Name", "D3D11_MESSAGE_ID_TRACKED_WORKLOAD_NOT_SUPPORTED")]
        MessageIDTrackedWorkloadNotSupported = 0x300226,
        [NativeName("Name", "D3D11_MESSAGE_ID_TRACKED_WORKLOAD_ENGINE_TYPE_NOT_FOUND")]
        MessageIDTrackedWorkloadEngineTypeNotFound = 0x300227,
        [NativeName("Name", "D3D11_MESSAGE_ID_NO_TRACKED_WORKLOAD_SLOT_AVAILABLE")]
        MessageIDNoTrackedWorkloadSlotAvailable = 0x300228,
        [NativeName("Name", "D3D11_MESSAGE_ID_END_TRACKED_WORKLOAD_INVALID_ARG")]
        MessageIDEndTrackedWorkloadInvalidArg = 0x300229,
        [NativeName("Name", "D3D11_MESSAGE_ID_TRACKED_WORKLOAD_DISJOINT_FAILURE")]
        MessageIDTrackedWorkloadDisjointFailure = 0x30022A,
        [NativeName("Name", "D3D11_MESSAGE_ID_D3D11_5_MESSAGES_END")]
        MessageIDD3D115MessagesEnd = 0x30022B,
    }
}
