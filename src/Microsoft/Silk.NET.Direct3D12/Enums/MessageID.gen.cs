// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MESSAGE_ID")]
    public enum MessageID : int
    {
        [NativeName("Name", "D3D12_MESSAGE_ID_UNKNOWN")]
        MessageIDUnknown = 0x0,
        [NativeName("Name", "D3D12_MESSAGE_ID_STRING_FROM_APPLICATION")]
        MessageIDStringFromApplication = 0x1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_THIS")]
        MessageIDCorruptedThis = 0x2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER1")]
        MessageIDCorruptedParameter1 = 0x3,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER2")]
        MessageIDCorruptedParameter2 = 0x4,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER3")]
        MessageIDCorruptedParameter3 = 0x5,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER4")]
        MessageIDCorruptedParameter4 = 0x6,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER5")]
        MessageIDCorruptedParameter5 = 0x7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER6")]
        MessageIDCorruptedParameter6 = 0x8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER7")]
        MessageIDCorruptedParameter7 = 0x9,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER8")]
        MessageIDCorruptedParameter8 = 0xA,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER9")]
        MessageIDCorruptedParameter9 = 0xB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER10")]
        MessageIDCorruptedParameter10 = 0xC,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER11")]
        MessageIDCorruptedParameter11 = 0xD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER12")]
        MessageIDCorruptedParameter12 = 0xE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER13")]
        MessageIDCorruptedParameter13 = 0xF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER14")]
        MessageIDCorruptedParameter14 = 0x10,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_PARAMETER15")]
        MessageIDCorruptedParameter15 = 0x11,
        [NativeName("Name", "D3D12_MESSAGE_ID_CORRUPTED_MULTITHREADING")]
        MessageIDCorruptedMultithreading = 0x12,
        [NativeName("Name", "D3D12_MESSAGE_ID_MESSAGE_REPORTING_OUTOFMEMORY")]
        MessageIDMessageReportingOutofmemory = 0x13,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETPRIVATEDATA_MOREDATA")]
        MessageIDGetprivatedataMoredata = 0x14,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETPRIVATEDATA_INVALIDFREEDATA")]
        MessageIDSetprivatedataInvalidfreedata = 0x15,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETPRIVATEDATA_CHANGINGPARAMS")]
        MessageIDSetprivatedataChangingparams = 0x18,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETPRIVATEDATA_OUTOFMEMORY")]
        MessageIDSetprivatedataOutofmemory = 0x19,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreateshaderresourceviewUnrecognizedformat = 0x1A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDESC")]
        MessageIDCreateshaderresourceviewInvaliddesc = 0x1B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDFORMAT")]
        MessageIDCreateshaderresourceviewInvalidformat = 0x1C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDVIDEOPLANESLICE")]
        MessageIDCreateshaderresourceviewInvalidvideoplaneslice = 0x1D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDPLANESLICE")]
        MessageIDCreateshaderresourceviewInvalidplaneslice = 0x1E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDDIMENSIONS")]
        MessageIDCreateshaderresourceviewInvaliddimensions = 0x1F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERRESOURCEVIEW_INVALIDRESOURCE")]
        MessageIDCreateshaderresourceviewInvalidresource = 0x20,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreaterendertargetviewUnrecognizedformat = 0x23,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_UNSUPPORTEDFORMAT")]
        MessageIDCreaterendertargetviewUnsupportedformat = 0x24,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDESC")]
        MessageIDCreaterendertargetviewInvaliddesc = 0x25,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDFORMAT")]
        MessageIDCreaterendertargetviewInvalidformat = 0x26,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDVIDEOPLANESLICE")]
        MessageIDCreaterendertargetviewInvalidvideoplaneslice = 0x27,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDPLANESLICE")]
        MessageIDCreaterendertargetviewInvalidplaneslice = 0x28,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDDIMENSIONS")]
        MessageIDCreaterendertargetviewInvaliddimensions = 0x29,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERENDERTARGETVIEW_INVALIDRESOURCE")]
        MessageIDCreaterendertargetviewInvalidresource = 0x2A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreatedepthstencilviewUnrecognizedformat = 0x2D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDESC")]
        MessageIDCreatedepthstencilviewInvaliddesc = 0x2E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFORMAT")]
        MessageIDCreatedepthstencilviewInvalidformat = 0x2F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDDIMENSIONS")]
        MessageIDCreatedepthstencilviewInvaliddimensions = 0x30,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDRESOURCE")]
        MessageIDCreatedepthstencilviewInvalidresource = 0x31,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_OUTOFMEMORY")]
        MessageIDCreateinputlayoutOutofmemory = 0x34,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TOOMANYELEMENTS")]
        MessageIDCreateinputlayoutToomanyelements = 0x35,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDFORMAT")]
        MessageIDCreateinputlayoutInvalidformat = 0x36,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INCOMPATIBLEFORMAT")]
        MessageIDCreateinputlayoutIncompatibleformat = 0x37,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOT")]
        MessageIDCreateinputlayoutInvalidslot = 0x38,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDINPUTSLOTCLASS")]
        MessageIDCreateinputlayoutInvalidinputslotclass = 0x39,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_STEPRATESLOTCLASSMISMATCH")]
        MessageIDCreateinputlayoutSteprateslotclassmismatch = 0x3A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSLOTCLASSCHANGE")]
        MessageIDCreateinputlayoutInvalidslotclasschange = 0x3B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDSTEPRATECHANGE")]
        MessageIDCreateinputlayoutInvalidstepratechange = 0x3C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_INVALIDALIGNMENT")]
        MessageIDCreateinputlayoutInvalidalignment = 0x3D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_DUPLICATESEMANTIC")]
        MessageIDCreateinputlayoutDuplicatesemantic = 0x3E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_UNPARSEABLEINPUTSIGNATURE")]
        MessageIDCreateinputlayoutUnparseableinputsignature = 0x3F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_NULLSEMANTIC")]
        MessageIDCreateinputlayoutNullsemantic = 0x40,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_MISSINGELEMENT")]
        MessageIDCreateinputlayoutMissingelement = 0x41,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEVERTEXSHADER_OUTOFMEMORY")]
        MessageIDCreatevertexshaderOutofmemory = 0x42,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatevertexshaderInvalidshaderbytecode = 0x43,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatevertexshaderInvalidshadertype = 0x44,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_OUTOFMEMORY")]
        MessageIDCreategeometryshaderOutofmemory = 0x45,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreategeometryshaderInvalidshaderbytecode = 0x46,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDSHADERTYPE")]
        MessageIDCreategeometryshaderInvalidshadertype = 0x47,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTOFMEMORY")]
        MessageIDCreategeometryshaderwithstreamoutputOutofmemory = 0x48,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERBYTECODE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidshaderbytecode = 0x49,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidshadertype = 0x4A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMENTRIES")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidnumentries = 0x4B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSTREAMSTRIDEUNUSED")]
        MessageIDCreategeometryshaderwithstreamoutputOutputstreamstrideunused = 0x4C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_OUTPUTSLOT0EXPECTED")]
        MessageIDCreategeometryshaderwithstreamoutputOutputslot0Expected = 0x4F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSLOT")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidoutputslot = 0x50,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_ONLYONEELEMENTPERSLOT")]
        MessageIDCreategeometryshaderwithstreamoutputOnlyoneelementperslot = 0x51,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDCOMPONENTCOUNT")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidcomponentcount = 0x52,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTARTCOMPONENTANDCOMPONENTCOUNT")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidstartcomponentandcomponentcount = 0x53,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDGAPDEFINITION")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidgapdefinition = 0x54,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_REPEATEDOUTPUT")]
        MessageIDCreategeometryshaderwithstreamoutputRepeatedoutput = 0x55,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDOUTPUTSTREAMSTRIDE")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidoutputstreamstride = 0x56,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGSEMANTIC")]
        MessageIDCreategeometryshaderwithstreamoutputMissingsemantic = 0x57,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MASKMISMATCH")]
        MessageIDCreategeometryshaderwithstreamoutputMaskmismatch = 0x58,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_CANTHAVEONLYGAPS")]
        MessageIDCreategeometryshaderwithstreamoutputCanthaveonlygaps = 0x59,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DECLTOOCOMPLEX")]
        MessageIDCreategeometryshaderwithstreamoutputDecltoocomplex = 0x5A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_MISSINGOUTPUTSIGNATURE")]
        MessageIDCreategeometryshaderwithstreamoutputMissingoutputsignature = 0x5B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIXELSHADER_OUTOFMEMORY")]
        MessageIDCreatepixelshaderOutofmemory = 0x5C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatepixelshaderInvalidshaderbytecode = 0x5D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatepixelshaderInvalidshadertype = 0x5E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFILLMODE")]
        MessageIDCreaterasterizerstateInvalidfillmode = 0x5F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDCULLMODE")]
        MessageIDCreaterasterizerstateInvalidcullmode = 0x60,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDDEPTHBIASCLAMP")]
        MessageIDCreaterasterizerstateInvaliddepthbiasclamp = 0x61,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDSLOPESCALEDDEPTHBIAS")]
        MessageIDCreaterasterizerstateInvalidslopescaleddepthbias = 0x62,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHWRITEMASK")]
        MessageIDCreatedepthstencilstateInvaliddepthwritemask = 0x64,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDDEPTHFUNC")]
        MessageIDCreatedepthstencilstateInvaliddepthfunc = 0x65,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFAILOP")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilfailop = 0x66,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILZFAILOP")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilzfailop = 0x67,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILPASSOP")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilpassop = 0x68,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDFRONTFACESTENCILFUNC")]
        MessageIDCreatedepthstencilstateInvalidfrontfacestencilfunc = 0x69,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFAILOP")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilfailop = 0x6A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILZFAILOP")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilzfailop = 0x6B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILPASSOP")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilpassop = 0x6C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_INVALIDBACKFACESTENCILFUNC")]
        MessageIDCreatedepthstencilstateInvalidbackfacestencilfunc = 0x6D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLEND")]
        MessageIDCreateblendstateInvalidsrcblend = 0x6F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLEND")]
        MessageIDCreateblendstateInvaliddestblend = 0x70,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOP")]
        MessageIDCreateblendstateInvalidblendop = 0x71,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDSRCBLENDALPHA")]
        MessageIDCreateblendstateInvalidsrcblendalpha = 0x72,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDDESTBLENDALPHA")]
        MessageIDCreateblendstateInvaliddestblendalpha = 0x73,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDBLENDOPALPHA")]
        MessageIDCreateblendstateInvalidblendopalpha = 0x74,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDRENDERTARGETWRITEMASK")]
        MessageIDCreateblendstateInvalidrendertargetwritemask = 0x75,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_INVALID")]
        MessageIDCleardepthstencilviewInvalid = 0x87,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ROOT_SIGNATURE_NOT_SET")]
        MessageIDCommandListDrawRootSignatureNotSet = 0xC8,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCommandListDrawRootSignatureMismatch = 0xC9,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_NOT_SET")]
        MessageIDCommandListDrawVertexBufferNotSet = 0xCA,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_STRIDE_TOO_SMALL")]
        MessageIDCommandListDrawVertexBufferStrideTooSmall = 0xD1,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_BUFFER_TOO_SMALL")]
        MessageIDCommandListDrawVertexBufferTooSmall = 0xD2,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_NOT_SET")]
        MessageIDCommandListDrawIndexBufferNotSet = 0xD3,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_FORMAT_INVALID")]
        MessageIDCommandListDrawIndexBufferFormatInvalid = 0xD4,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_BUFFER_TOO_SMALL")]
        MessageIDCommandListDrawIndexBufferTooSmall = 0xD5,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INVALID_PRIMITIVETOPOLOGY")]
        MessageIDCommandListDrawInvalidPrimitivetopology = 0xDB,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_VERTEX_STRIDE_UNALIGNED")]
        MessageIDCommandListDrawVertexStrideUnaligned = 0xDD,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_INDEX_OFFSET_UNALIGNED")]
        MessageIDCommandListDrawIndexOffsetUnaligned = 0xDE,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_AT_FAULT")]
        MessageIDDeviceRemovalProcessATFault = 0xE8,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_POSSIBLY_AT_FAULT")]
        MessageIDDeviceRemovalProcessPossiblyATFault = 0xE9,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_REMOVAL_PROCESS_NOT_AT_FAULT")]
        MessageIDDeviceRemovalProcessNotATFault = 0xEA,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TRAILING_DIGIT_IN_SEMANTIC")]
        MessageIDCreateinputlayoutTrailingDigitInSemantic = 0xEF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_TRAILING_DIGIT_IN_SEMANTIC")]
        MessageIDCreategeometryshaderwithstreamoutputTrailingDigitInSemantic = 0xF0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_TYPE_MISMATCH")]
        MessageIDCreateinputlayoutTypeMismatch = 0xF5,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEINPUTLAYOUT_EMPTY_LAYOUT")]
        MessageIDCreateinputlayoutEmptyLayout = 0xFD,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_OBJECT_SUMMARY")]
        MessageIDLiveObjectSummary = 0xFF,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_DEVICE")]
        MessageIDLiveDevice = 0x112,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_SWAPCHAIN")]
        MessageIDLiveSwapchain = 0x113,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILVIEW_INVALIDFLAGS")]
        MessageIDCreatedepthstencilviewInvalidflags = 0x114,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEVERTEXSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatevertexshaderInvalidclasslinkage = 0x115,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreategeometryshaderInvalidclasslinkage = 0x116,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAMTORASTERIZER")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidstreamtorasterizer = 0x118,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIXELSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatepixelshaderInvalidclasslinkage = 0x11B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDSTREAM")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidstream = 0x11C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDENTRIES")]
        MessageIDCreategeometryshaderwithstreamoutputUnexpectedentries = 0x11D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UNEXPECTEDSTRIDES")]
        MessageIDCreategeometryshaderwithstreamoutputUnexpectedstrides = 0x11E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_INVALIDNUMSTRIDES")]
        MessageIDCreategeometryshaderwithstreamoutputInvalidnumstrides = 0x11F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHULLSHADER_OUTOFMEMORY")]
        MessageIDCreatehullshaderOutofmemory = 0x121,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatehullshaderInvalidshaderbytecode = 0x122,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatehullshaderInvalidshadertype = 0x123,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHULLSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatehullshaderInvalidclasslinkage = 0x124,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDOMAINSHADER_OUTOFMEMORY")]
        MessageIDCreatedomainshaderOutofmemory = 0x126,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatedomainshaderInvalidshaderbytecode = 0x127,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDSHADERTYPE")]
        MessageIDCreatedomainshaderInvalidshadertype = 0x128,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDOMAINSHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatedomainshaderInvalidclasslinkage = 0x129,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_UNMAP_NOTMAPPED")]
        MessageIDResourceUnmapNotmapped = 0x136,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CHECKFEATURESUPPORT_MISMATCHED_DATA_SIZE")]
        MessageIDDeviceCheckfeaturesupportMismatchedDataSize = 0x13E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTESHADER_OUTOFMEMORY")]
        MessageIDCreatecomputeshaderOutofmemory = 0x141,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatecomputeshaderInvalidshaderbytecode = 0x142,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTESHADER_INVALIDCLASSLINKAGE")]
        MessageIDCreatecomputeshaderInvalidclasslinkage = 0x143,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderDoublefloatopsnotsupported = 0x14B,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderDoublefloatopsnotsupported = 0x14C,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderDoublefloatopsnotsupported = 0x14D,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderDoublefloatopsnotsupported = 0x14E,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputDoublefloatopsnotsupported = 0x14F,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderDoublefloatopsnotsupported = 0x150,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEFLOATOPSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderDoublefloatopsnotsupported = 0x151,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDRESOURCE")]
        MessageIDCreateunorderedaccessviewInvalidresource = 0x154,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDESC")]
        MessageIDCreateunorderedaccessviewInvaliddesc = 0x155,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFORMAT")]
        MessageIDCreateunorderedaccessviewInvalidformat = 0x156,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDVIDEOPLANESLICE")]
        MessageIDCreateunorderedaccessviewInvalidvideoplaneslice = 0x157,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDPLANESLICE")]
        MessageIDCreateunorderedaccessviewInvalidplaneslice = 0x158,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDDIMENSIONS")]
        MessageIDCreateunorderedaccessviewInvaliddimensions = 0x159,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_UNRECOGNIZEDFORMAT")]
        MessageIDCreateunorderedaccessviewUnrecognizedformat = 0x15A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEUNORDEREDACCESSVIEW_INVALIDFLAGS")]
        MessageIDCreateunorderedaccessviewInvalidflags = 0x162,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALIDFORCEDSAMPLECOUNT")]
        MessageIDCreaterasterizerstateInvalidforcedsamplecount = 0x191,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_INVALIDLOGICOPS")]
        MessageIDCreateblendstateInvalidlogicops = 0x193,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderDoubleextensionsnotsupported = 0x19A,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderDoubleextensionsnotsupported = 0x19C,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderDoubleextensionsnotsupported = 0x19E,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderDoubleextensionsnotsupported = 0x1A0,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputDoubleextensionsnotsupported = 0x1A2,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderDoubleextensionsnotsupported = 0x1A4,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_DOUBLEEXTENSIONSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderDoubleextensionsnotsupported = 0x1A6,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEVERTEXSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatevertexshaderUavsnotsupported = 0x1A9,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEHULLSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatehullshaderUavsnotsupported = 0x1AA,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEDOMAINSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatedomainshaderUavsnotsupported = 0x1AB,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderUavsnotsupported = 0x1AC,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEGEOMETRYSHADERWITHSTREAMOUTPUT_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreategeometryshaderwithstreamoutputUavsnotsupported = 0x1AD,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATEPIXELSHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatepixelshaderUavsnotsupported = 0x1AE,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATECOMPUTESHADER_UAVSNOTSUPPORTED")]
        MessageIDDeviceCreatecomputeshaderUavsnotsupported = 0x1AF,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CLEARVIEW_INVALIDSOURCERECT")]
        MessageIDDeviceClearviewInvalidsourcerect = 0x1BF,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CLEARVIEW_EMPTYRECT")]
        MessageIDDeviceClearviewEmptyrect = 0x1C0,
        [NativeName("Name", "D3D12_MESSAGE_ID_UPDATETILEMAPPINGS_INVALID_PARAMETER")]
        MessageIDUpdatetilemappingsInvalidParameter = 0x1ED,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTILEMAPPINGS_INVALID_PARAMETER")]
        MessageIDCopytilemappingsInvalidParameter = 0x1EE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEVICE_INVALIDARGS")]
        MessageIDCreatedeviceInvalidargs = 0x1FA,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEVICE_WARNING")]
        MessageIDCreatedeviceWarning = 0x1FB,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_TYPE")]
        MessageIDResourceBarrierInvalidType = 0x207,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_NULL_POINTER")]
        MessageIDResourceBarrierNullPointer = 0x208,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_SUBRESOURCE")]
        MessageIDResourceBarrierInvalidSubresource = 0x209,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_RESERVED_BITS")]
        MessageIDResourceBarrierReservedBits = 0x20A,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISSING_BIND_FLAGS")]
        MessageIDResourceBarrierMissingBindFlags = 0x20B,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_MISC_FLAGS")]
        MessageIDResourceBarrierMismatchingMiscFlags = 0x20C,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MATCHING_STATES")]
        MessageIDResourceBarrierMatchingStates = 0x20D,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMBINATION")]
        MessageIDResourceBarrierInvalidCombination = 0x20E,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_BEFORE_AFTER_MISMATCH")]
        MessageIDResourceBarrierBeforeAfterMismatch = 0x20F,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_RESOURCE")]
        MessageIDResourceBarrierInvalidResource = 0x210,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_SAMPLE_COUNT")]
        MessageIDResourceBarrierSampleCount = 0x211,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAGS")]
        MessageIDResourceBarrierInvalidFlags = 0x212,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMBINED_FLAGS")]
        MessageIDResourceBarrierInvalidCombinedFlags = 0x213,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAGS_FOR_FORMAT")]
        MessageIDResourceBarrierInvalidFlagsForFormat = 0x214,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_SPLIT_BARRIER")]
        MessageIDResourceBarrierInvalidSplitBarrier = 0x215,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_UNMATCHED_END")]
        MessageIDResourceBarrierUnmatchedEnd = 0x216,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_UNMATCHED_BEGIN")]
        MessageIDResourceBarrierUnmatchedBegin = 0x217,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_FLAG")]
        MessageIDResourceBarrierInvalidFlag = 0x218,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_COMMAND_LIST_TYPE")]
        MessageIDResourceBarrierInvalidCommandListType = 0x219,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_SUBRESOURCE_STATE")]
        MessageIDInvalidSubresourceState = 0x21A,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_CONTENTION")]
        MessageIDCommandAllocatorContention = 0x21C,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_RESET")]
        MessageIDCommandAllocatorReset = 0x21D,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_RESET_BUNDLE")]
        MessageIDCommandAllocatorResetBundle = 0x21E,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_CANNOT_RESET")]
        MessageIDCommandAllocatorCannotReset = 0x21F,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_OPEN")]
        MessageIDCommandListOpen = 0x220,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_BUNDLE_API")]
        MessageIDInvalidBundleApi = 0x222,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_CLOSED")]
        MessageIDCommandListClosed = 0x223,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRONG_COMMAND_ALLOCATOR_TYPE")]
        MessageIDWrongCommandAllocatorType = 0x225,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_SYNC")]
        MessageIDCommandAllocatorSync = 0x228,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_SYNC")]
        MessageIDCommandListSync = 0x229,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_DESCRIPTOR_HEAP_INVALID")]
        MessageIDSetDescriptorHeapInvalid = 0x22A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDQUEUE")]
        MessageIDCreateCommandqueue = 0x22D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDALLOCATOR")]
        MessageIDCreateCommandallocator = 0x22E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_PIPELINESTATE")]
        MessageIDCreatePipelinestate = 0x22F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDLIST12")]
        MessageIDCreateCommandlist12 = 0x230,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_RESOURCE")]
        MessageIDCreateResource = 0x232,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_DESCRIPTORHEAP")]
        MessageIDCreateDescriptorheap = 0x233,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOTSIGNATURE")]
        MessageIDCreateRootsignature = 0x234,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_LIBRARY")]
        MessageIDCreateLibrary = 0x235,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_HEAP")]
        MessageIDCreateHeap = 0x236,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_MONITOREDFENCE")]
        MessageIDCreateMonitoredfence = 0x237,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUERYHEAP")]
        MessageIDCreateQueryheap = 0x238,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDSIGNATURE")]
        MessageIDCreateCommandsignature = 0x239,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDQUEUE")]
        MessageIDLiveCommandqueue = 0x23A,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDALLOCATOR")]
        MessageIDLiveCommandallocator = 0x23B,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_PIPELINESTATE")]
        MessageIDLivePipelinestate = 0x23C,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDLIST12")]
        MessageIDLiveCommandlist12 = 0x23D,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_RESOURCE")]
        MessageIDLiveResource = 0x23F,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_DESCRIPTORHEAP")]
        MessageIDLiveDescriptorheap = 0x240,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_ROOTSIGNATURE")]
        MessageIDLiveRootsignature = 0x241,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_LIBRARY")]
        MessageIDLiveLibrary = 0x242,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_HEAP")]
        MessageIDLiveHeap = 0x243,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_MONITOREDFENCE")]
        MessageIDLiveMonitoredfence = 0x244,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_QUERYHEAP")]
        MessageIDLiveQueryheap = 0x245,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDSIGNATURE")]
        MessageIDLiveCommandsignature = 0x246,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDQUEUE")]
        MessageIDDestroyCommandqueue = 0x247,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDALLOCATOR")]
        MessageIDDestroyCommandallocator = 0x248,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_PIPELINESTATE")]
        MessageIDDestroyPipelinestate = 0x249,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDLIST12")]
        MessageIDDestroyCommandlist12 = 0x24A,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_RESOURCE")]
        MessageIDDestroyResource = 0x24C,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_DESCRIPTORHEAP")]
        MessageIDDestroyDescriptorheap = 0x24D,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_ROOTSIGNATURE")]
        MessageIDDestroyRootsignature = 0x24E,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_LIBRARY")]
        MessageIDDestroyLibrary = 0x24F,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_HEAP")]
        MessageIDDestroyHeap = 0x250,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_MONITOREDFENCE")]
        MessageIDDestroyMonitoredfence = 0x251,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_QUERYHEAP")]
        MessageIDDestroyQueryheap = 0x252,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDSIGNATURE")]
        MessageIDDestroyCommandsignature = 0x253,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDIMENSIONS")]
        MessageIDCreateresourceInvaliddimensions = 0x255,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDMISCFLAGS")]
        MessageIDCreateresourceInvalidmiscflags = 0x257,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDARG_RETURN")]
        MessageIDCreateresourceInvalidargReturn = 0x25A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_OUTOFMEMORY_RETURN")]
        MessageIDCreateresourceOutofmemoryReturn = 0x25B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDESC")]
        MessageIDCreateresourceInvaliddesc = 0x25C,
        [NativeName("Name", "D3D12_MESSAGE_ID_POSSIBLY_INVALID_SUBRESOURCE_STATE")]
        MessageIDPossiblyInvalidSubresourceState = 0x25F,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_USE_OF_NON_RESIDENT_RESOURCE")]
        MessageIDInvalidUseOfNonResidentResource = 0x260,
        [NativeName("Name", "D3D12_MESSAGE_ID_POSSIBLE_INVALID_USE_OF_NON_RESIDENT_RESOURCE")]
        MessageIDPossibleInvalidUseOfNonResidentResource = 0x261,
        [NativeName("Name", "D3D12_MESSAGE_ID_BUNDLE_PIPELINE_STATE_MISMATCH")]
        MessageIDBundlePipelineStateMismatch = 0x262,
        [NativeName("Name", "D3D12_MESSAGE_ID_PRIMITIVE_TOPOLOGY_MISMATCH_PIPELINE_STATE")]
        MessageIDPrimitiveTopologyMismatchPipelineState = 0x263,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_TARGET_FORMAT_MISMATCH_PIPELINE_STATE")]
        MessageIDRenderTargetFormatMismatchPipelineState = 0x265,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_TARGET_SAMPLE_DESC_MISMATCH_PIPELINE_STATE")]
        MessageIDRenderTargetSampleDescMismatchPipelineState = 0x266,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEPTH_STENCIL_FORMAT_MISMATCH_PIPELINE_STATE")]
        MessageIDDepthStencilFormatMismatchPipelineState = 0x267,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEPTH_STENCIL_SAMPLE_DESC_MISMATCH_PIPELINE_STATE")]
        MessageIDDepthStencilSampleDescMismatchPipelineState = 0x268,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADER_INVALIDBYTECODE")]
        MessageIDCreateshaderInvalidbytecode = 0x26E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_NULLDESC")]
        MessageIDCreateheapNulldesc = 0x26F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDSIZE")]
        MessageIDCreateheapInvalidsize = 0x270,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDHEAPTYPE")]
        MessageIDCreateheapUnrecognizedheaptype = 0x271,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDCPUPAGEPROPERTIES")]
        MessageIDCreateheapUnrecognizedcpupageproperties = 0x272,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDMEMORYPOOL")]
        MessageIDCreateheapUnrecognizedmemorypool = 0x273,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDPROPERTIES")]
        MessageIDCreateheapInvalidproperties = 0x274,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDALIGNMENT")]
        MessageIDCreateheapInvalidalignment = 0x275,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_UNRECOGNIZEDMISCFLAGS")]
        MessageIDCreateheapUnrecognizedmiscflags = 0x276,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDMISCFLAGS")]
        MessageIDCreateheapInvalidmiscflags = 0x277,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_INVALIDARG_RETURN")]
        MessageIDCreateheapInvalidargReturn = 0x278,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEHEAP_OUTOFMEMORY_RETURN")]
        MessageIDCreateheapOutofmemoryReturn = 0x279,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLHEAPPROPERTIES")]
        MessageIDCreateresourceandheapNullheapproperties = 0x27A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDHEAPTYPE")]
        MessageIDCreateresourceandheapUnrecognizedheaptype = 0x27B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDCPUPAGEPROPERTIES")]
        MessageIDCreateresourceandheapUnrecognizedcpupageproperties = 0x27C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDMEMORYPOOL")]
        MessageIDCreateresourceandheapUnrecognizedmemorypool = 0x27D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPPROPERTIES")]
        MessageIDCreateresourceandheapInvalidheapproperties = 0x27E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_UNRECOGNIZEDHEAPMISCFLAGS")]
        MessageIDCreateresourceandheapUnrecognizedheapmiscflags = 0x27F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDHEAPMISCFLAGS")]
        MessageIDCreateresourceandheapInvalidheapmiscflags = 0x280,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_INVALIDARG_RETURN")]
        MessageIDCreateresourceandheapInvalidargReturn = 0x281,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_OUTOFMEMORY_RETURN")]
        MessageIDCreateresourceandheapOutofmemoryReturn = 0x282,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCUSTOMHEAPPROPERTIES_UNRECOGNIZEDHEAPTYPE")]
        MessageIDGetcustomheappropertiesUnrecognizedheaptype = 0x283,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCUSTOMHEAPPROPERTIES_INVALIDHEAPTYPE")]
        MessageIDGetcustomheappropertiesInvalidheaptype = 0x284,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_DESCRIPTOR_HEAP_INVALID_DESC")]
        MessageIDCreateDescriptorHeapInvalidDesc = 0x285,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_DESCRIPTOR_HANDLE")]
        MessageIDInvalidDescriptorHandle = 0x286,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERASTERIZERSTATE_INVALID_CONSERVATIVERASTERMODE")]
        MessageIDCreaterasterizerstateInvalidConservativerastermode = 0x287,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_CONSTANT_BUFFER_VIEW_INVALID_RESOURCE")]
        MessageIDCreateConstantBufferViewInvalidResource = 0x289,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_CONSTANT_BUFFER_VIEW_INVALID_DESC")]
        MessageIDCreateConstantBufferViewInvalidDesc = 0x28A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_UNORDEREDACCESS_VIEW_INVALID_COUNTER_USAGE")]
        MessageIDCreateUnorderedaccessViewInvalidCounterUsage = 0x28C,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_DESCRIPTORS_INVALID_RANGES")]
        MessageIDCopyDescriptorsInvalidRanges = 0x28D,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_DESCRIPTORS_WRITE_ONLY_DESCRIPTOR")]
        MessageIDCopyDescriptorsWriteOnlyDescriptor = 0x28E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RTV_FORMAT_NOT_UNKNOWN")]
        MessageIDCreategraphicspipelinestateRtvFormatNotUnknown = 0x28F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_RENDER_TARGET_COUNT")]
        MessageIDCreategraphicspipelinestateInvalidRenderTargetCount = 0x290,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VERTEX_SHADER_NOT_SET")]
        MessageIDCreategraphicspipelinestateVertexShaderNotSet = 0x291,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INPUTLAYOUT_NOT_SET")]
        MessageIDCreategraphicspipelinestateInputlayoutNotSet = 0x292,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_HS_DS_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateShaderLinkageHSDSSignatureMismatch = 0x293,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_REGISTERINDEX")]
        MessageIDCreategraphicspipelinestateShaderLinkageRegisterindex = 0x294,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_COMPONENTTYPE")]
        MessageIDCreategraphicspipelinestateShaderLinkageComponenttype = 0x295,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_REGISTERMASK")]
        MessageIDCreategraphicspipelinestateShaderLinkageRegistermask = 0x296,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_SYSTEMVALUE")]
        MessageIDCreategraphicspipelinestateShaderLinkageSystemvalue = 0x297,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_NEVERWRITTEN_ALWAYSREADS")]
        MessageIDCreategraphicspipelinestateShaderLinkageNeverwrittenAlwaysreads = 0x298,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_MINPRECISION")]
        MessageIDCreategraphicspipelinestateShaderLinkageMinprecision = 0x299,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_LINKAGE_SEMANTICNAME_NOT_FOUND")]
        MessageIDCreategraphicspipelinestateShaderLinkageSemanticnameNotFound = 0x29A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_XOR_DS_MISMATCH")]
        MessageIDCreategraphicspipelinestateHSXorDSMismatch = 0x29B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HULL_SHADER_INPUT_TOPOLOGY_MISMATCH")]
        MessageIDCreategraphicspipelinestateHullShaderInputTopologyMismatch = 0x29C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_DS_CONTROL_POINT_COUNT_MISMATCH")]
        MessageIDCreategraphicspipelinestateHSDSControlPointCountMismatch = 0x29D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_DS_TESSELLATOR_DOMAIN_MISMATCH")]
        MessageIDCreategraphicspipelinestateHSDSTessellatorDomainMismatch = 0x29E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_USE_OF_CENTER_MULTISAMPLE_PATTERN")]
        MessageIDCreategraphicspipelinestateInvalidUseOfCenterMultisamplePattern = 0x29F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_USE_OF_FORCED_SAMPLE_COUNT")]
        MessageIDCreategraphicspipelinestateInvalidUseOfForcedSampleCount = 0x2A0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_PRIMITIVETOPOLOGY")]
        MessageIDCreategraphicspipelinestateInvalidPrimitivetopology = 0x2A1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_SYSTEMVALUE")]
        MessageIDCreategraphicspipelinestateInvalidSystemvalue = 0x2A2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_DUAL_SOURCE_BLENDING_CAN_ONLY_HAVE_RENDER_TARGET_0")]
        MessageIDCreategraphicspipelinestateOMDualSourceBlendingCanOnlyHaveRenderTarget0 = 0x2A3,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_RENDER_TARGET_DOES_NOT_SUPPORT_BLENDING")]
        MessageIDCreategraphicspipelinestateOMRenderTargetDoesNotSupportBlending = 0x2A4,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_OUTPUT_TYPE_MISMATCH")]
        MessageIDCreategraphicspipelinestatePSOutputTypeMismatch = 0x2A5,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_OM_RENDER_TARGET_DOES_NOT_SUPPORT_LOGIC_OPS")]
        MessageIDCreategraphicspipelinestateOMRenderTargetDoesNotSupportLogicOps = 0x2A6,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RENDERTARGETVIEW_NOT_SET")]
        MessageIDCreategraphicspipelinestateRendertargetviewNotSet = 0x2A7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_DEPTHSTENCILVIEW_NOT_SET")]
        MessageIDCreategraphicspipelinestateDepthstencilviewNotSet = 0x2A8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_GS_INPUT_PRIMITIVE_MISMATCH")]
        MessageIDCreategraphicspipelinestateGSInputPrimitiveMismatch = 0x2A9,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_POSITION_NOT_PRESENT")]
        MessageIDCreategraphicspipelinestatePositionNotPresent = 0x2AA,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MISSING_ROOT_SIGNATURE_FLAGS")]
        MessageIDCreategraphicspipelinestateMissingRootSignatureFlags = 0x2AB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_INDEX_BUFFER_PROPERTIES")]
        MessageIDCreategraphicspipelinestateInvalidIndexBufferProperties = 0x2AC,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INVALID_SAMPLE_DESC")]
        MessageIDCreategraphicspipelinestateInvalidSampleDesc = 0x2AD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_HS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateHSRootSignatureMismatch = 0x2AE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_DS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateDSRootSignatureMismatch = 0x2AF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateVSRootSignatureMismatch = 0x2B0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_GS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateGSRootSignatureMismatch = 0x2B1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestatePSRootSignatureMismatch = 0x2B2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MISSING_ROOT_SIGNATURE")]
        MessageIDCreategraphicspipelinestateMissingRootSignature = 0x2B3,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_BUNDLE_OPEN_BUNDLE")]
        MessageIDExecuteBundleOpenBundle = 0x2B4,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_BUNDLE_DESCRIPTOR_HEAP_MISMATCH")]
        MessageIDExecuteBundleDescriptorHeapMismatch = 0x2B5,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_BUNDLE_TYPE")]
        MessageIDExecuteBundleType = 0x2B6,
        [NativeName("Name", "D3D12_MESSAGE_ID_DRAW_EMPTY_SCISSOR_RECTANGLE")]
        MessageIDDrawEmptyScissorRectangle = 0x2B7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_BLOB_NOT_FOUND")]
        MessageIDCreateRootSignatureBlobNotFound = 0x2B8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_DESERIALIZE_FAILED")]
        MessageIDCreateRootSignatureDeserializeFailed = 0x2B9,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_INVALID_CONFIGURATION")]
        MessageIDCreateRootSignatureInvalidConfiguration = 0x2BA,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_NOT_SUPPORTED_ON_DEVICE")]
        MessageIDCreateRootSignatureNotSupportedOnDevice = 0x2BB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLRESOURCEPROPERTIES")]
        MessageIDCreateresourceandheapNullresourceproperties = 0x2BC,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCEANDHEAP_NULLHEAP")]
        MessageIDCreateresourceandheapNullheap = 0x2BD,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETRESOURCEALLOCATIONINFO_INVALIDRDESCS")]
        MessageIDGetresourceallocationinfoInvalidrdescs = 0x2BE,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAKERESIDENT_NULLOBJECTARRAY")]
        MessageIDMakeresidentNullobjectarray = 0x2BF,
        [NativeName("Name", "D3D12_MESSAGE_ID_EVICT_NULLOBJECTARRAY")]
        MessageIDEvictNullobjectarray = 0x2C1,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_DESCRIPTOR_TABLE_INVALID")]
        MessageIDSetDescriptorTableInvalid = 0x2C4,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_ROOT_CONSTANT_INVALID")]
        MessageIDSetRootConstantInvalid = 0x2C5,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_ROOT_CONSTANT_BUFFER_VIEW_INVALID")]
        MessageIDSetRootConstantBufferViewInvalid = 0x2C6,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_ROOT_SHADER_RESOURCE_VIEW_INVALID")]
        MessageIDSetRootShaderResourceViewInvalid = 0x2C7,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_ROOT_UNORDERED_ACCESS_VIEW_INVALID")]
        MessageIDSetRootUnorderedAccessViewInvalid = 0x2C8,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_VERTEX_BUFFERS_INVALID_DESC")]
        MessageIDSetVertexBuffersInvalidDesc = 0x2C9,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_INDEX_BUFFER_INVALID_DESC")]
        MessageIDSetIndexBufferInvalidDesc = 0x2CB,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_STREAM_OUTPUT_BUFFERS_INVALID_DESC")]
        MessageIDSetStreamOutputBuffersInvalidDesc = 0x2CD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDDIMENSIONALITY")]
        MessageIDCreateresourceUnrecognizeddimensionality = 0x2CE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDLAYOUT")]
        MessageIDCreateresourceUnrecognizedlayout = 0x2CF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDDIMENSIONALITY")]
        MessageIDCreateresourceInvaliddimensionality = 0x2D0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDALIGNMENT")]
        MessageIDCreateresourceInvalidalignment = 0x2D1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDMIPLEVELS")]
        MessageIDCreateresourceInvalidmiplevels = 0x2D2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDSAMPLEDESC")]
        MessageIDCreateresourceInvalidsampledesc = 0x2D3,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDLAYOUT")]
        MessageIDCreateresourceInvalidlayout = 0x2D4,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_INDEX_BUFFER_INVALID")]
        MessageIDSetIndexBufferInvalid = 0x2D5,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_VERTEX_BUFFERS_INVALID")]
        MessageIDSetVertexBuffersInvalid = 0x2D6,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_STREAM_OUTPUT_BUFFERS_INVALID")]
        MessageIDSetStreamOutputBuffersInvalid = 0x2D7,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_RENDER_TARGETS_INVALID")]
        MessageIDSetRenderTargetsInvalid = 0x2D8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEQUERY_HEAP_INVALID_PARAMETERS")]
        MessageIDCreatequeryHeapInvalidParameters = 0x2D9,
        [NativeName("Name", "D3D12_MESSAGE_ID_BEGIN_END_QUERY_INVALID_PARAMETERS")]
        MessageIDBeginEndQueryInvalidParameters = 0x2DB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLOSE_COMMAND_LIST_OPEN_QUERY")]
        MessageIDCloseCommandListOpenQuery = 0x2DC,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_QUERY_DATA_INVALID_PARAMETERS")]
        MessageIDResolveQueryDataInvalidParameters = 0x2DD,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_PREDICATION_INVALID_PARAMETERS")]
        MessageIDSetPredicationInvalidParameters = 0x2DE,
        [NativeName("Name", "D3D12_MESSAGE_ID_TIMESTAMPS_NOT_SUPPORTED")]
        MessageIDTimestampsNotSupported = 0x2DF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDFORMAT")]
        MessageIDCreateresourceUnrecognizedformat = 0x2E1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDFORMAT")]
        MessageIDCreateresourceInvalidformat = 0x2E2,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_INVALIDSUBRESOURCERANGE")]
        MessageIDGetcopyablefootprintsInvalidsubresourcerange = 0x2E3,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_INVALIDBASEOFFSET")]
        MessageIDGetcopyablefootprintsInvalidbaseoffset = 0x2E4,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLELAYOUT_INVALIDSUBRESOURCERANGE")]
        MessageIDGetcopyablelayoutInvalidsubresourcerange = 0x2E3,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLELAYOUT_INVALIDBASEOFFSET")]
        MessageIDGetcopyablelayoutInvalidbaseoffset = 0x2E4,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_INVALID_HEAP")]
        MessageIDResourceBarrierInvalidHeap = 0x2E5,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_SAMPLER_INVALID")]
        MessageIDCreateSamplerInvalid = 0x2E6,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMMANDSIGNATURE_INVALID")]
        MessageIDCreatecommandsignatureInvalid = 0x2E7,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_INDIRECT_INVALID_PARAMETERS")]
        MessageIDExecuteIndirectInvalidParameters = 0x2E8,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETGPUVIRTUALADDRESS_INVALID_RESOURCE_DIMENSION")]
        MessageIDGetgpuvirtualaddressInvalidResourceDimension = 0x2E9,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDCLEARVALUE")]
        MessageIDCreateresourceInvalidclearvalue = 0x32F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_UNRECOGNIZEDCLEARVALUEFORMAT")]
        MessageIDCreateresourceUnrecognizedclearvalueformat = 0x330,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_INVALIDCLEARVALUEFORMAT")]
        MessageIDCreateresourceInvalidclearvalueformat = 0x331,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATERESOURCE_CLEARVALUEDENORMFLUSH")]
        MessageIDCreateresourceClearvaluedenormflush = 0x332,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARRENDERTARGETVIEW_MISMATCHINGCLEARVALUE")]
        MessageIDClearrendertargetviewMismatchingclearvalue = 0x334,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARDEPTHSTENCILVIEW_MISMATCHINGCLEARVALUE")]
        MessageIDCleardepthstencilviewMismatchingclearvalue = 0x335,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDHEAP")]
        MessageIDMapInvalidheap = 0x336,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALIDHEAP")]
        MessageIDUnmapInvalidheap = 0x337,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDRESOURCE")]
        MessageIDMapInvalidresource = 0x338,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALIDRESOURCE")]
        MessageIDUnmapInvalidresource = 0x339,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDSUBRESOURCE")]
        MessageIDMapInvalidsubresource = 0x33A,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALIDSUBRESOURCE")]
        MessageIDUnmapInvalidsubresource = 0x33B,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDRANGE")]
        MessageIDMapInvalidrange = 0x33C,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALIDRANGE")]
        MessageIDUnmapInvalidrange = 0x33D,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDDATAPOINTER")]
        MessageIDMapInvaliddatapointer = 0x340,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALIDARG_RETURN")]
        MessageIDMapInvalidargReturn = 0x341,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_OUTOFMEMORY_RETURN")]
        MessageIDMapOutofmemoryReturn = 0x342,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_BUNDLENOTSUPPORTED")]
        MessageIDExecutecommandlistsBundlenotsupported = 0x343,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_COMMANDLISTMISMATCH")]
        MessageIDExecutecommandlistsCommandlistmismatch = 0x344,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_OPENCOMMANDLIST")]
        MessageIDExecutecommandlistsOpencommandlist = 0x345,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_FAILEDCOMMANDLIST")]
        MessageIDExecutecommandlistsFailedcommandlist = 0x346,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_NULLDST")]
        MessageIDCopybufferregionNulldst = 0x347,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDDSTRESOURCEDIMENSION")]
        MessageIDCopybufferregionInvaliddstresourcedimension = 0x348,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_DSTRANGEOUTOFBOUNDS")]
        MessageIDCopybufferregionDstrangeoutofbounds = 0x349,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_NULLSRC")]
        MessageIDCopybufferregionNullsrc = 0x34A,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDSRCRESOURCEDIMENSION")]
        MessageIDCopybufferregionInvalidsrcresourcedimension = 0x34B,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_SRCRANGEOUTOFBOUNDS")]
        MessageIDCopybufferregionSrcrangeoutofbounds = 0x34C,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALIDCOPYFLAGS")]
        MessageIDCopybufferregionInvalidcopyflags = 0x34D,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_NULLDST")]
        MessageIDCopytextureregionNulldst = 0x34E,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDDSTTYPE")]
        MessageIDCopytextureregionUnrecognizeddsttype = 0x34F,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTRESOURCEDIMENSION")]
        MessageIDCopytextureregionInvaliddstresourcedimension = 0x350,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTRESOURCE")]
        MessageIDCopytextureregionInvaliddstresource = 0x351,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTSUBRESOURCE")]
        MessageIDCopytextureregionInvaliddstsubresource = 0x352,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTOFFSET")]
        MessageIDCopytextureregionInvaliddstoffset = 0x353,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDDSTFORMAT")]
        MessageIDCopytextureregionUnrecognizeddstformat = 0x354,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTFORMAT")]
        MessageIDCopytextureregionInvaliddstformat = 0x355,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTDIMENSIONS")]
        MessageIDCopytextureregionInvaliddstdimensions = 0x356,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTROWPITCH")]
        MessageIDCopytextureregionInvaliddstrowpitch = 0x357,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTPLACEMENT")]
        MessageIDCopytextureregionInvaliddstplacement = 0x358,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTDSPLACEDFOOTPRINTFORMAT")]
        MessageIDCopytextureregionInvaliddstdsplacedfootprintformat = 0x359,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_DSTREGIONOUTOFBOUNDS")]
        MessageIDCopytextureregionDstregionoutofbounds = 0x35A,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_NULLSRC")]
        MessageIDCopytextureregionNullsrc = 0x35B,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDSRCTYPE")]
        MessageIDCopytextureregionUnrecognizedsrctype = 0x35C,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCRESOURCEDIMENSION")]
        MessageIDCopytextureregionInvalidsrcresourcedimension = 0x35D,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCRESOURCE")]
        MessageIDCopytextureregionInvalidsrcresource = 0x35E,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCSUBRESOURCE")]
        MessageIDCopytextureregionInvalidsrcsubresource = 0x35F,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCOFFSET")]
        MessageIDCopytextureregionInvalidsrcoffset = 0x360,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_UNRECOGNIZEDSRCFORMAT")]
        MessageIDCopytextureregionUnrecognizedsrcformat = 0x361,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCFORMAT")]
        MessageIDCopytextureregionInvalidsrcformat = 0x362,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCDIMENSIONS")]
        MessageIDCopytextureregionInvalidsrcdimensions = 0x363,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCROWPITCH")]
        MessageIDCopytextureregionInvalidsrcrowpitch = 0x364,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCPLACEMENT")]
        MessageIDCopytextureregionInvalidsrcplacement = 0x365,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCDSPLACEDFOOTPRINTFORMAT")]
        MessageIDCopytextureregionInvalidsrcdsplacedfootprintformat = 0x366,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_SRCREGIONOUTOFBOUNDS")]
        MessageIDCopytextureregionSrcregionoutofbounds = 0x367,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDDSTCOORDINATES")]
        MessageIDCopytextureregionInvaliddstcoordinates = 0x368,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDSRCBOX")]
        MessageIDCopytextureregionInvalidsrcbox = 0x369,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_FORMATMISMATCH")]
        MessageIDCopytextureregionFormatmismatch = 0x36A,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_EMPTYBOX")]
        MessageIDCopytextureregionEmptybox = 0x36B,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_INVALIDCOPYFLAGS")]
        MessageIDCopytextureregionInvalidcopyflags = 0x36C,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_SUBRESOURCE_INDEX")]
        MessageIDResolvesubresourceInvalidSubresourceIndex = 0x36D,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_FORMAT")]
        MessageIDResolvesubresourceInvalidFormat = 0x36E,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_RESOURCE_MISMATCH")]
        MessageIDResolvesubresourceResourceMismatch = 0x36F,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALID_SAMPLE_COUNT")]
        MessageIDResolvesubresourceInvalidSampleCount = 0x370,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_INVALID_SHADER")]
        MessageIDCreatecomputepipelinestateInvalidShader = 0x371,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_CS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreatecomputepipelinestateCSRootSignatureMismatch = 0x372,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMPUTEPIPELINESTATE_MISSING_ROOT_SIGNATURE")]
        MessageIDCreatecomputepipelinestateMissingRootSignature = 0x373,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALIDCACHEDBLOB")]
        MessageIDCreatepipelinestateInvalidcachedblob = 0x374,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBADAPTERMISMATCH")]
        MessageIDCreatepipelinestateCachedblobadaptermismatch = 0x375,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBDRIVERVERSIONMISMATCH")]
        MessageIDCreatepipelinestateCachedblobdriverversionmismatch = 0x376,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBDESCMISMATCH")]
        MessageIDCreatepipelinestateCachedblobdescmismatch = 0x377,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CACHEDBLOBIGNORED")]
        MessageIDCreatepipelinestateCachedblobignored = 0x378,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDHEAP")]
        MessageIDWritetosubresourceInvalidheap = 0x379,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDRESOURCE")]
        MessageIDWritetosubresourceInvalidresource = 0x37A,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDBOX")]
        MessageIDWritetosubresourceInvalidbox = 0x37B,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_INVALIDSUBRESOURCE")]
        MessageIDWritetosubresourceInvalidsubresource = 0x37C,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITETOSUBRESOURCE_EMPTYBOX")]
        MessageIDWritetosubresourceEmptybox = 0x37D,
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDHEAP")]
        MessageIDReadfromsubresourceInvalidheap = 0x37E,
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDRESOURCE")]
        MessageIDReadfromsubresourceInvalidresource = 0x37F,
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDBOX")]
        MessageIDReadfromsubresourceInvalidbox = 0x380,
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_INVALIDSUBRESOURCE")]
        MessageIDReadfromsubresourceInvalidsubresource = 0x381,
        [NativeName("Name", "D3D12_MESSAGE_ID_READFROMSUBRESOURCE_EMPTYBOX")]
        MessageIDReadfromsubresourceEmptybox = 0x382,
        [NativeName("Name", "D3D12_MESSAGE_ID_TOO_MANY_NODES_SPECIFIED")]
        MessageIDTooManyNodesSpecified = 0x383,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_NODE_INDEX")]
        MessageIDInvalidNodeIndex = 0x384,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETHEAPPROPERTIES_INVALIDRESOURCE")]
        MessageIDGetheappropertiesInvalidresource = 0x385,
        [NativeName("Name", "D3D12_MESSAGE_ID_NODE_MASK_MISMATCH")]
        MessageIDNodeMaskMismatch = 0x386,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_OUTOFMEMORY")]
        MessageIDCommandListOutofmemory = 0x387,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_MULTIPLE_SWAPCHAIN_BUFFER_REFERENCES")]
        MessageIDCommandListMultipleSwapchainBufferReferences = 0x388,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_TOO_MANY_SWAPCHAIN_REFERENCES")]
        MessageIDCommandListTooManySwapchainReferences = 0x389,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_QUEUE_TOO_MANY_SWAPCHAIN_REFERENCES")]
        MessageIDCommandQueueTooManySwapchainReferences = 0x38A,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_WRONGSWAPCHAINBUFFERREFERENCE")]
        MessageIDExecutecommandlistsWrongswapchainbufferreference = 0x38B,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_SETRENDERTARGETS_INVALIDNUMRENDERTARGETS")]
        MessageIDCommandListSetrendertargetsInvalidnumrendertargets = 0x38C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_TYPE")]
        MessageIDCreateQueueInvalidType = 0x38D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_FLAGS")]
        MessageIDCreateQueueInvalidFlags = 0x38E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHAREDRESOURCE_INVALIDFLAGS")]
        MessageIDCreatesharedresourceInvalidflags = 0x38F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHAREDRESOURCE_INVALIDFORMAT")]
        MessageIDCreatesharedresourceInvalidformat = 0x390,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHAREDHEAP_INVALIDFLAGS")]
        MessageIDCreatesharedheapInvalidflags = 0x391,
        [NativeName("Name", "D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_UNRECOGNIZEDPROPERTIES")]
        MessageIDReflectsharedpropertiesUnrecognizedproperties = 0x392,
        [NativeName("Name", "D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_INVALIDSIZE")]
        MessageIDReflectsharedpropertiesInvalidsize = 0x393,
        [NativeName("Name", "D3D12_MESSAGE_ID_REFLECTSHAREDPROPERTIES_INVALIDOBJECT")]
        MessageIDReflectsharedpropertiesInvalidobject = 0x394,
        [NativeName("Name", "D3D12_MESSAGE_ID_KEYEDMUTEX_INVALIDOBJECT")]
        MessageIDKeyedmutexInvalidobject = 0x395,
        [NativeName("Name", "D3D12_MESSAGE_ID_KEYEDMUTEX_INVALIDKEY")]
        MessageIDKeyedmutexInvalidkey = 0x396,
        [NativeName("Name", "D3D12_MESSAGE_ID_KEYEDMUTEX_WRONGSTATE")]
        MessageIDKeyedmutexWrongstate = 0x397,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUEUE_INVALID_PRIORITY")]
        MessageIDCreateQueueInvalidPriority = 0x398,
        [NativeName("Name", "D3D12_MESSAGE_ID_OBJECT_DELETED_WHILE_STILL_IN_USE")]
        MessageIDObjectDeletedWhileStillInUse = 0x399,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALID_FLAGS")]
        MessageIDCreatepipelinestateInvalidFlags = 0x39A,
        [NativeName("Name", "D3D12_MESSAGE_ID_HEAP_ADDRESS_RANGE_HAS_NO_RESOURCE")]
        MessageIDHeapAddressRangeHasNoResource = 0x39B,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DRAW_RENDER_TARGET_DELETED")]
        MessageIDCommandListDrawRenderTargetDeleted = 0x39C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_ALL_RENDER_TARGETS_HAVE_UNKNOWN_FORMAT")]
        MessageIDCreategraphicspipelinestateAllRenderTargetsHaveUnknownFormat = 0x39D,
        [NativeName("Name", "D3D12_MESSAGE_ID_HEAP_ADDRESS_RANGE_INTERSECTS_MULTIPLE_BUFFERS")]
        MessageIDHeapAddressRangeIntersectsMultipleBuffers = 0x39E,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTECOMMANDLISTS_GPU_WRITTEN_READBACK_RESOURCE_MAPPED")]
        MessageIDExecutecommandlistsGpuWrittenReadbackResourceMapped = 0x39F,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_RANGE_NOT_EMPTY")]
        MessageIDUnmapRangeNotEmpty = 0x3A1,
        [NativeName("Name", "D3D12_MESSAGE_ID_MAP_INVALID_NULLRANGE")]
        MessageIDMapInvalidNullrange = 0x3A2,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNMAP_INVALID_NULLRANGE")]
        MessageIDUnmapInvalidNullrange = 0x3A3,
        [NativeName("Name", "D3D12_MESSAGE_ID_NO_GRAPHICS_API_SUPPORT")]
        MessageIDNoGraphicsApiSupport = 0x3A4,
        [NativeName("Name", "D3D12_MESSAGE_ID_NO_COMPUTE_API_SUPPORT")]
        MessageIDNoComputeApiSupport = 0x3A5,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_RESOURCE_FLAGS_NOT_SUPPORTED")]
        MessageIDResolvesubresourceResourceFlagsNotSupported = 0x3A6,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_ROOT_ARGUMENT_UNINITIALIZED")]
        MessageIDGpuBasedValidationRootArgumentUninitialized = 0x3A7,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_HEAP_INDEX_OUT_OF_BOUNDS")]
        MessageIDGpuBasedValidationDescriptorHeapIndexOutOfBounds = 0x3A8,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_TABLE_REGISTER_INDEX_OUT_OF_BOUNDS")]
        MessageIDGpuBasedValidationDescriptorTableRegisterIndexOutOfBounds = 0x3A9,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_UNINITIALIZED")]
        MessageIDGpuBasedValidationDescriptorUninitialized = 0x3AA,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_DESCRIPTOR_TYPE_MISMATCH")]
        MessageIDGpuBasedValidationDescriptorTypeMismatch = 0x3AB,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_SRV_RESOURCE_DIMENSION_MISMATCH")]
        MessageIDGpuBasedValidationSrvResourceDimensionMismatch = 0x3AC,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_UAV_RESOURCE_DIMENSION_MISMATCH")]
        MessageIDGpuBasedValidationUavResourceDimensionMismatch = 0x3AD,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INCOMPATIBLE_RESOURCE_STATE")]
        MessageIDGpuBasedValidationIncompatibleResourceState = 0x3AE,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_NULLDST")]
        MessageIDCopyresourceNulldst = 0x3AF,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_INVALIDDSTRESOURCE")]
        MessageIDCopyresourceInvaliddstresource = 0x3B0,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_NULLSRC")]
        MessageIDCopyresourceNullsrc = 0x3B1,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_INVALIDSRCRESOURCE")]
        MessageIDCopyresourceInvalidsrcresource = 0x3B2,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_NULLDST")]
        MessageIDResolvesubresourceNulldst = 0x3B3,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALIDDSTRESOURCE")]
        MessageIDResolvesubresourceInvaliddstresource = 0x3B4,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_NULLSRC")]
        MessageIDResolvesubresourceNullsrc = 0x3B5,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_INVALIDSRCRESOURCE")]
        MessageIDResolvesubresourceInvalidsrcresource = 0x3B6,
        [NativeName("Name", "D3D12_MESSAGE_ID_PIPELINE_STATE_TYPE_MISMATCH")]
        MessageIDPipelineStateTypeMismatch = 0x3B7,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DISPATCH_ROOT_SIGNATURE_NOT_SET")]
        MessageIDCommandListDispatchRootSignatureNotSet = 0x3B8,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DISPATCH_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCommandListDispatchRootSignatureMismatch = 0x3B9,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_ZERO_BARRIERS")]
        MessageIDResourceBarrierZeroBarriers = 0x3BA,
        [NativeName("Name", "D3D12_MESSAGE_ID_BEGIN_END_EVENT_MISMATCH")]
        MessageIDBeginEndEventMismatch = 0x3BB,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_POSSIBLE_BEFORE_AFTER_MISMATCH")]
        MessageIDResourceBarrierPossibleBeforeAfterMismatch = 0x3BC,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_BEGIN_END")]
        MessageIDResourceBarrierMismatchingBeginEnd = 0x3BD,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_INVALID_RESOURCE")]
        MessageIDGpuBasedValidationInvalidResource = 0x3BE,
        [NativeName("Name", "D3D12_MESSAGE_ID_USE_OF_ZERO_REFCOUNT_OBJECT")]
        MessageIDUseOfZeroRefcountObject = 0x3BF,
        [NativeName("Name", "D3D12_MESSAGE_ID_OBJECT_EVICTED_WHILE_STILL_IN_USE")]
        MessageIDObjectEvictedWhileStillInUse = 0x3C0,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_ROOT_DESCRIPTOR_ACCESS_OUT_OF_BOUNDS")]
        MessageIDGpuBasedValidationRootDescriptorAccessOutOfBounds = 0x3C1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_INVALIDLIBRARYBLOB")]
        MessageIDCreatepipelinelibraryInvalidlibraryblob = 0x3C2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_DRIVERVERSIONMISMATCH")]
        MessageIDCreatepipelinelibraryDriverversionmismatch = 0x3C3,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_ADAPTERVERSIONMISMATCH")]
        MessageIDCreatepipelinelibraryAdapterversionmismatch = 0x3C4,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINELIBRARY_UNSUPPORTED")]
        MessageIDCreatepipelinelibraryUnsupported = 0x3C5,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_PIPELINELIBRARY")]
        MessageIDCreatePipelinelibrary = 0x3C6,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_PIPELINELIBRARY")]
        MessageIDLivePipelinelibrary = 0x3C7,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_PIPELINELIBRARY")]
        MessageIDDestroyPipelinelibrary = 0x3C8,
        [NativeName("Name", "D3D12_MESSAGE_ID_STOREPIPELINE_NONAME")]
        MessageIDStorepipelineNoname = 0x3C9,
        [NativeName("Name", "D3D12_MESSAGE_ID_STOREPIPELINE_DUPLICATENAME")]
        MessageIDStorepipelineDuplicatename = 0x3CA,
        [NativeName("Name", "D3D12_MESSAGE_ID_LOADPIPELINE_NAMENOTFOUND")]
        MessageIDLoadpipelineNamenotfound = 0x3CB,
        [NativeName("Name", "D3D12_MESSAGE_ID_LOADPIPELINE_INVALIDDESC")]
        MessageIDLoadpipelineInvaliddesc = 0x3CC,
        [NativeName("Name", "D3D12_MESSAGE_ID_PIPELINELIBRARY_SERIALIZE_NOTENOUGHMEMORY")]
        MessageIDPipelinelibrarySerializeNotenoughmemory = 0x3CD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_PS_OUTPUT_RT_OUTPUT_MISMATCH")]
        MessageIDCreategraphicspipelinestatePSOutputRTOutputMismatch = 0x3CE,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETEVENTONMULTIPLEFENCECOMPLETION_INVALIDFLAGS")]
        MessageIDSeteventonmultiplefencecompletionInvalidflags = 0x3CF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_QUEUE_VIDEO_NOT_SUPPORTED")]
        MessageIDCreateQueueVideoNotSupported = 0x3D0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_ALLOCATOR_VIDEO_NOT_SUPPORTED")]
        MessageIDCreateCommandAllocatorVideoNotSupported = 0x3D1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEQUERY_HEAP_VIDEO_DECODE_STATISTICS_NOT_SUPPORTED")]
        MessageIDCreatequeryHeapVideoDecodeStatisticsNotSupported = 0x3D2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODECOMMANDLIST")]
        MessageIDCreateVideodecodecommandlist = 0x3D3,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODER")]
        MessageIDCreateVideodecoder = 0x3D4,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODESTREAM")]
        MessageIDCreateVideodecodestream = 0x3D5,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODECOMMANDLIST")]
        MessageIDLiveVideodecodecommandlist = 0x3D6,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODER")]
        MessageIDLiveVideodecoder = 0x3D7,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODESTREAM")]
        MessageIDLiveVideodecodestream = 0x3D8,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODECOMMANDLIST")]
        MessageIDDestroyVideodecodecommandlist = 0x3D9,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODER")]
        MessageIDDestroyVideodecoder = 0x3DA,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODESTREAM")]
        MessageIDDestroyVideodecodestream = 0x3DB,
        [NativeName("Name", "D3D12_MESSAGE_ID_DECODE_FRAME_INVALID_PARAMETERS")]
        MessageIDDecodeFrameInvalidParameters = 0x3DC,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEPRECATED_API")]
        MessageIDDeprecatedApi = 0x3DD,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_MISMATCHING_COMMAND_LIST_TYPE")]
        MessageIDResourceBarrierMismatchingCommandListType = 0x3DE,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_DESCRIPTOR_TABLE_NOT_SET")]
        MessageIDCommandListDescriptorTableNotSet = 0x3DF,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_CONSTANT_BUFFER_VIEW_NOT_SET")]
        MessageIDCommandListRootConstantBufferViewNotSet = 0x3E0,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_SHADER_RESOURCE_VIEW_NOT_SET")]
        MessageIDCommandListRootShaderResourceViewNotSet = 0x3E1,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_ROOT_UNORDERED_ACCESS_VIEW_NOT_SET")]
        MessageIDCommandListRootUnorderedAccessViewNotSet = 0x3E2,
        [NativeName("Name", "D3D12_MESSAGE_ID_DISCARD_INVALID_SUBRESOURCE_RANGE")]
        MessageIDDiscardInvalidSubresourceRange = 0x3E3,
        [NativeName("Name", "D3D12_MESSAGE_ID_DISCARD_ONE_SUBRESOURCE_FOR_MIPS_WITH_RECTS")]
        MessageIDDiscardOneSubresourceForMipsWithRects = 0x3E4,
        [NativeName("Name", "D3D12_MESSAGE_ID_DISCARD_NO_RECTS_FOR_NON_TEXTURE2D")]
        MessageIDDiscardNoRectsForNonTexture2D = 0x3E5,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_ON_SAME_SUBRESOURCE")]
        MessageIDCopyOnSameSubresource = 0x3E6,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETRESIDENCYPRIORITY_INVALID_PAGEABLE")]
        MessageIDSetresidencypriorityInvalidPageable = 0x3E7,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_UNSUPPORTED")]
        MessageIDGpuBasedValidationUnsupported = 0x3E8,
        [NativeName("Name", "D3D12_MESSAGE_ID_STATIC_DESCRIPTOR_INVALID_DESCRIPTOR_CHANGE")]
        MessageIDStaticDescriptorInvalidDescriptorChange = 0x3E9,
        [NativeName("Name", "D3D12_MESSAGE_ID_DATA_STATIC_DESCRIPTOR_INVALID_DATA_CHANGE")]
        MessageIDDataStaticDescriptorInvalidDataChange = 0x3EA,
        [NativeName("Name", "D3D12_MESSAGE_ID_DATA_STATIC_WHILE_SET_AT_EXECUTE_DESCRIPTOR_INVALID_DATA_CHANGE")]
        MessageIDDataStaticWhileSetATExecuteDescriptorInvalidDataChange = 0x3EB,
        [NativeName("Name", "D3D12_MESSAGE_ID_EXECUTE_BUNDLE_STATIC_DESCRIPTOR_DATA_STATIC_NOT_SET")]
        MessageIDExecuteBundleStaticDescriptorDataStaticNotSet = 0x3EC,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_RESOURCE_ACCESS_OUT_OF_BOUNDS")]
        MessageIDGpuBasedValidationResourceAccessOutOfBounds = 0x3ED,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_SAMPLER_MODE_MISMATCH")]
        MessageIDGpuBasedValidationSamplerModeMismatch = 0x3EE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_FENCE_INVALID_FLAGS")]
        MessageIDCreateFenceInvalidFlags = 0x3EF,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_BARRIER_DUPLICATE_SUBRESOURCE_TRANSITIONS")]
        MessageIDResourceBarrierDuplicateSubresourceTransitions = 0x3F0,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETRESIDENCYPRIORITY_INVALID_PRIORITY")]
        MessageIDSetresidencypriorityInvalidPriority = 0x3F1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_DESCRIPTOR_HEAP_LARGE_NUM_DESCRIPTORS")]
        MessageIDCreateDescriptorHeapLargeNumDescriptors = 0x3F5,
        [NativeName("Name", "D3D12_MESSAGE_ID_BEGIN_EVENT")]
        MessageIDBeginEvent = 0x3F6,
        [NativeName("Name", "D3D12_MESSAGE_ID_END_EVENT")]
        MessageIDEndEvent = 0x3F7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEVICE_DEBUG_LAYER_STARTUP_OPTIONS")]
        MessageIDCreatedeviceDebugLayerStartupOptions = 0x3F8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEDEPTHSTENCILSTATE_DEPTHBOUNDSTEST_UNSUPPORTED")]
        MessageIDCreatedepthstencilstateDepthboundstestUnsupported = 0x3F9,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_DUPLICATE_SUBOBJECT")]
        MessageIDCreatepipelinestateDuplicateSubobject = 0x3FA,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_UNKNOWN_SUBOBJECT")]
        MessageIDCreatepipelinestateUnknownSubobject = 0x3FB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_ZERO_SIZE_STREAM")]
        MessageIDCreatepipelinestateZeroSizeStream = 0x3FC,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_INVALID_STREAM")]
        MessageIDCreatepipelinestateInvalidStream = 0x3FD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_CANNOT_DEDUCE_TYPE")]
        MessageIDCreatepipelinestateCannotDeduceType = 0x3FE,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_STATIC_DESCRIPTOR_RESOURCE_DIMENSION_MISMATCH")]
        MessageIDCommandListStaticDescriptorResourceDimensionMismatch = 0x3FF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_QUEUE_INSUFFICIENT_PRIVILEGE_FOR_GLOBAL_REALTIME")]
        MessageIDCreateCommandQueueInsufficientPrivilegeForGlobalRealtime = 0x400,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_QUEUE_INSUFFICIENT_HARDWARE_SUPPORT_FOR_GLOBAL_REALTIME")]
        MessageIDCreateCommandQueueInsufficientHardwareSupportForGlobalRealtime = 0x401,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_ARCHITECTURE")]
        MessageIDAtomiccopybufferInvalidArchitecture = 0x402,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DST")]
        MessageIDAtomiccopybufferNullDst = 0x403,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DST_RESOURCE_DIMENSION")]
        MessageIDAtomiccopybufferInvalidDstResourceDimension = 0x404,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DST_RANGE_OUT_OF_BOUNDS")]
        MessageIDAtomiccopybufferDstRangeOutOfBounds = 0x405,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_SRC")]
        MessageIDAtomiccopybufferNullSrc = 0x406,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_SRC_RESOURCE_DIMENSION")]
        MessageIDAtomiccopybufferInvalidSrcResourceDimension = 0x407,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_SRC_RANGE_OUT_OF_BOUNDS")]
        MessageIDAtomiccopybufferSrcRangeOutOfBounds = 0x408,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_OFFSET_ALIGNMENT")]
        MessageIDAtomiccopybufferInvalidOffsetAlignment = 0x409,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DEPENDENT_RESOURCES")]
        MessageIDAtomiccopybufferNullDependentResources = 0x40A,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_NULL_DEPENDENT_SUBRESOURCE_RANGES")]
        MessageIDAtomiccopybufferNullDependentSubresourceRanges = 0x40B,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DEPENDENT_RESOURCE")]
        MessageIDAtomiccopybufferInvalidDependentResource = 0x40C,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DEPENDENT_SUBRESOURCE_RANGE")]
        MessageIDAtomiccopybufferInvalidDependentSubresourceRange = 0x40D,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DEPENDENT_SUBRESOURCE_OUT_OF_BOUNDS")]
        MessageIDAtomiccopybufferDependentSubresourceOutOfBounds = 0x40E,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_DEPENDENT_RANGE_OUT_OF_BOUNDS")]
        MessageIDAtomiccopybufferDependentRangeOutOfBounds = 0x40F,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_ZERO_DEPENDENCIES")]
        MessageIDAtomiccopybufferZeroDependencies = 0x410,
        [NativeName("Name", "D3D12_MESSAGE_ID_DEVICE_CREATE_SHARED_HANDLE_INVALIDARG")]
        MessageIDDeviceCreateSharedHandleInvalidarg = 0x411,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESCRIPTOR_HANDLE_WITH_INVALID_RESOURCE")]
        MessageIDDescriptorHandleWithInvalidResource = 0x412,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETDEPTHBOUNDS_INVALIDARGS")]
        MessageIDSetdepthboundsInvalidargs = 0x413,
        [NativeName("Name", "D3D12_MESSAGE_ID_GPU_BASED_VALIDATION_RESOURCE_STATE_IMPRECISE")]
        MessageIDGpuBasedValidationResourceStateImprecise = 0x414,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_PIPELINE_STATE_NOT_SET")]
        MessageIDCommandListPipelineStateNotSet = 0x415,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_SHADER_MODEL_MISMATCH")]
        MessageIDCreategraphicspipelinestateShaderModelMismatch = 0x416,
        [NativeName("Name", "D3D12_MESSAGE_ID_OBJECT_ACCESSED_WHILE_STILL_IN_USE")]
        MessageIDObjectAccessedWhileStillInUse = 0x417,
        [NativeName("Name", "D3D12_MESSAGE_ID_PROGRAMMABLE_MSAA_UNSUPPORTED")]
        MessageIDProgrammableMsaaUnsupported = 0x418,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETSAMPLEPOSITIONS_INVALIDARGS")]
        MessageIDSetsamplepositionsInvalidargs = 0x419,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCEREGION_INVALID_RECT")]
        MessageIDResolvesubresourceregionInvalidRect = 0x41A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODECOMMANDQUEUE")]
        MessageIDCreateVideodecodecommandqueue = 0x41B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSCOMMANDLIST")]
        MessageIDCreateVideoprocesscommandlist = 0x41C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSCOMMANDQUEUE")]
        MessageIDCreateVideoprocesscommandqueue = 0x41D,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODECOMMANDQUEUE")]
        MessageIDLiveVideodecodecommandqueue = 0x41E,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSCOMMANDLIST")]
        MessageIDLiveVideoprocesscommandlist = 0x41F,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSCOMMANDQUEUE")]
        MessageIDLiveVideoprocesscommandqueue = 0x420,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODECOMMANDQUEUE")]
        MessageIDDestroyVideodecodecommandqueue = 0x421,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSCOMMANDLIST")]
        MessageIDDestroyVideoprocesscommandlist = 0x422,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSCOMMANDQUEUE")]
        MessageIDDestroyVideoprocesscommandqueue = 0x423,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSOR")]
        MessageIDCreateVideoprocessor = 0x424,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOPROCESSSTREAM")]
        MessageIDCreateVideoprocessstream = 0x425,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSOR")]
        MessageIDLiveVideoprocessor = 0x426,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOPROCESSSTREAM")]
        MessageIDLiveVideoprocessstream = 0x427,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSOR")]
        MessageIDDestroyVideoprocessor = 0x428,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOPROCESSSTREAM")]
        MessageIDDestroyVideoprocessstream = 0x429,
        [NativeName("Name", "D3D12_MESSAGE_ID_PROCESS_FRAME_INVALID_PARAMETERS")]
        MessageIDProcessFrameInvalidParameters = 0x42A,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_INVALIDLAYOUT")]
        MessageIDCopyInvalidlayout = 0x42B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_CRYPTO_SESSION")]
        MessageIDCreateCryptoSession = 0x42C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_CRYPTO_SESSION_POLICY")]
        MessageIDCreateCryptoSessionPolicy = 0x42D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_PROTECTED_RESOURCE_SESSION")]
        MessageIDCreateProtectedResourceSession = 0x42E,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_CRYPTO_SESSION")]
        MessageIDLiveCryptoSession = 0x42F,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_CRYPTO_SESSION_POLICY")]
        MessageIDLiveCryptoSessionPolicy = 0x430,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_PROTECTED_RESOURCE_SESSION")]
        MessageIDLiveProtectedResourceSession = 0x431,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_CRYPTO_SESSION")]
        MessageIDDestroyCryptoSession = 0x432,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_CRYPTO_SESSION_POLICY")]
        MessageIDDestroyCryptoSessionPolicy = 0x433,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_PROTECTED_RESOURCE_SESSION")]
        MessageIDDestroyProtectedResourceSession = 0x434,
        [NativeName("Name", "D3D12_MESSAGE_ID_PROTECTED_RESOURCE_SESSION_UNSUPPORTED")]
        MessageIDProtectedResourceSessionUnsupported = 0x435,
        [NativeName("Name", "D3D12_MESSAGE_ID_FENCE_INVALIDOPERATION")]
        MessageIDFenceInvalidoperation = 0x436,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEQUERY_HEAP_COPY_QUEUE_TIMESTAMPS_NOT_SUPPORTED")]
        MessageIDCreatequeryHeapCopyQueueTimestampsNotSupported = 0x437,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_DEFERRED")]
        MessageIDSamplepositionsMismatchDeferred = 0x438,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_RECORDTIME_ASSUMEDFROMFIRSTUSE")]
        MessageIDSamplepositionsMismatchRecordtimeAssumedfromfirstuse = 0x439,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLEPOSITIONS_MISMATCH_RECORDTIME_ASSUMEDFROMCLEAR")]
        MessageIDSamplepositionsMismatchRecordtimeAssumedfromclear = 0x43A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEODECODERHEAP")]
        MessageIDCreateVideodecoderheap = 0x43B,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEODECODERHEAP")]
        MessageIDLiveVideodecoderheap = 0x43C,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEODECODERHEAP")]
        MessageIDDestroyVideodecoderheap = 0x43D,
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDARG_RETURN")]
        MessageIDOpenexistingheapInvalidargReturn = 0x43E,
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_OUTOFMEMORY_RETURN")]
        MessageIDOpenexistingheapOutofmemoryReturn = 0x43F,
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDADDRESS")]
        MessageIDOpenexistingheapInvalidaddress = 0x440,
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_INVALIDHANDLE")]
        MessageIDOpenexistingheapInvalidhandle = 0x441,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_DEST")]
        MessageIDWritebufferimmediateInvalidDest = 0x442,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_MODE")]
        MessageIDWritebufferimmediateInvalidMode = 0x443,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_INVALID_ALIGNMENT")]
        MessageIDWritebufferimmediateInvalidAlignment = 0x444,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITEBUFFERIMMEDIATE_NOT_SUPPORTED")]
        MessageIDWritebufferimmediateNotSupported = 0x445,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETVIEWINSTANCEMASK_INVALIDARGS")]
        MessageIDSetviewinstancemaskInvalidargs = 0x446,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIEW_INSTANCING_UNSUPPORTED")]
        MessageIDViewInstancingUnsupported = 0x447,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIEW_INSTANCING_INVALIDARGS")]
        MessageIDViewInstancingInvalidargs = 0x448,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_MISMATCH_DECODE_REFERENCE_ONLY_FLAG")]
        MessageIDCopytextureregionMismatchDecodeReferenceOnlyFlag = 0x449,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_MISMATCH_DECODE_REFERENCE_ONLY_FLAG")]
        MessageIDCopyresourceMismatchDecodeReferenceOnlyFlag = 0x44A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_DECODE_HEAP_CAPS_FAILURE")]
        MessageIDCreateVideoDecodeHeapCapsFailure = 0x44B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_DECODE_HEAP_CAPS_UNSUPPORTED")]
        MessageIDCreateVideoDecodeHeapCapsUnsupported = 0x44C,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_DECODE_SUPPORT_INVALID_INPUT")]
        MessageIDVideoDecodeSupportInvalidInput = 0x44D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_DECODER_UNSUPPORTED")]
        MessageIDCreateVideoDecoderUnsupported = 0x44E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_METADATA_ERROR")]
        MessageIDCreategraphicspipelinestateMetadataError = 0x44F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_VIEW_INSTANCING_VERTEX_SIZE_EXCEEDED")]
        MessageIDCreategraphicspipelinestateViewInstancingVertexSizeExceeded = 0x450,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_RUNTIME_INTERNAL_ERROR")]
        MessageIDCreategraphicspipelinestateRuntimeInternalError = 0x451,
        [NativeName("Name", "D3D12_MESSAGE_ID_NO_VIDEO_API_SUPPORT")]
        MessageIDNoVideoApiSupport = 0x452,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_PROCESS_SUPPORT_INVALID_INPUT")]
        MessageIDVideoProcessSupportInvalidInput = 0x453,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_PROCESSOR_CAPS_FAILURE")]
        MessageIDCreateVideoProcessorCapsFailure = 0x454,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_PROCESS_SUPPORT_UNSUPPORTED_FORMAT")]
        MessageIDVideoProcessSupportUnsupportedFormat = 0x455,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_DECODE_FRAME_INVALID_ARGUMENT")]
        MessageIDVideoDecodeFrameInvalidArgument = 0x456,
        [NativeName("Name", "D3D12_MESSAGE_ID_ENQUEUE_MAKE_RESIDENT_INVALID_FLAGS")]
        MessageIDEnqueueMakeResidentInvalidFlags = 0x457,
        [NativeName("Name", "D3D12_MESSAGE_ID_OPENEXISTINGHEAP_UNSUPPORTED")]
        MessageIDOpenexistingheapUnsupported = 0x458,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_PROCESS_FRAMES_INVALID_ARGUMENT")]
        MessageIDVideoProcessFramesInvalidArgument = 0x459,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_DECODE_SUPPORT_UNSUPPORTED")]
        MessageIDVideoDecodeSupportUnsupported = 0x45A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDRECORDER")]
        MessageIDCreateCommandrecorder = 0x45B,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDRECORDER")]
        MessageIDLiveCommandrecorder = 0x45C,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDRECORDER")]
        MessageIDDestroyCommandrecorder = 0x45D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_VIDEO_NOT_SUPPORTED")]
        MessageIDCreateCommandRecorderVideoNotSupported = 0x45E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_INVALID_SUPPORT_FLAGS")]
        MessageIDCreateCommandRecorderInvalidSupportFlags = 0x45F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_INVALID_FLAGS")]
        MessageIDCreateCommandRecorderInvalidFlags = 0x460,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_RECORDER_MORE_RECORDERS_THAN_LOGICAL_PROCESSORS")]
        MessageIDCreateCommandRecorderMoreRecordersThanLogicalProcessors = 0x461,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMANDPOOL")]
        MessageIDCreateCommandpool = 0x462,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_COMMANDPOOL")]
        MessageIDLiveCommandpool = 0x463,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_COMMANDPOOL")]
        MessageIDDestroyCommandpool = 0x464,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_POOL_INVALID_FLAGS")]
        MessageIDCreateCommandPoolInvalidFlags = 0x465,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_VIDEO_NOT_SUPPORTED")]
        MessageIDCreateCommandListVideoNotSupported = 0x466,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_RECORDER_SUPPORT_FLAGS_MISMATCH")]
        MessageIDCommandRecorderSupportFlagsMismatch = 0x467,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_RECORDER_CONTENTION")]
        MessageIDCommandRecorderContention = 0x468,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_RECORDER_USAGE_WITH_CREATECOMMANDLIST_COMMAND_LIST")]
        MessageIDCommandRecorderUsageWithCreatecommandlistCommandList = 0x469,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_ALLOCATOR_USAGE_WITH_CREATECOMMANDLIST1_COMMAND_LIST")]
        MessageIDCommandAllocatorUsageWithCreatecommandlist1CommandList = 0x46A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_EXECUTE_EMPTY_COMMAND_LIST")]
        MessageIDCannotExecuteEmptyCommandList = 0x46B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_RESET_COMMAND_POOL_WITH_OPEN_COMMAND_LISTS")]
        MessageIDCannotResetCommandPoolWithOpenCommandLists = 0x46C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_USE_COMMAND_RECORDER_WITHOUT_CURRENT_TARGET")]
        MessageIDCannotUseCommandRecorderWithoutCurrentTarget = 0x46D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_CHANGE_COMMAND_RECORDER_TARGET_WHILE_RECORDING")]
        MessageIDCannotChangeCommandRecorderTargetWhileRecording = 0x46E,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_POOL_SYNC")]
        MessageIDCommandPoolSync = 0x46F,
        [NativeName("Name", "D3D12_MESSAGE_ID_EVICT_UNDERFLOW")]
        MessageIDEvictUnderflow = 0x470,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_META_COMMAND")]
        MessageIDCreateMetaCommand = 0x471,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_META_COMMAND")]
        MessageIDLiveMetaCommand = 0x472,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_META_COMMAND")]
        MessageIDDestroyMetaCommand = 0x473,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALID_DST_RESOURCE")]
        MessageIDCopybufferregionInvalidDstResource = 0x474,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYBUFFERREGION_INVALID_SRC_RESOURCE")]
        MessageIDCopybufferregionInvalidSrcResource = 0x475,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_DST_RESOURCE")]
        MessageIDAtomiccopybufferInvalidDstResource = 0x476,
        [NativeName("Name", "D3D12_MESSAGE_ID_ATOMICCOPYBUFFER_INVALID_SRC_RESOURCE")]
        MessageIDAtomiccopybufferInvalidSrcResource = 0x477,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_NULL_BUFFER")]
        MessageIDCreateplacedresourceonbufferNullBuffer = 0x478,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_NULL_RESOURCE_DESC")]
        MessageIDCreateplacedresourceonbufferNullResourceDesc = 0x479,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_UNSUPPORTED")]
        MessageIDCreateplacedresourceonbufferUnsupported = 0x47A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_DIMENSION")]
        MessageIDCreateplacedresourceonbufferInvalidBufferDimension = 0x47B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_FLAGS")]
        MessageIDCreateplacedresourceonbufferInvalidBufferFlags = 0x47C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_BUFFER_OFFSET")]
        MessageIDCreateplacedresourceonbufferInvalidBufferOffset = 0x47D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_RESOURCE_DIMENSION")]
        MessageIDCreateplacedresourceonbufferInvalidResourceDimension = 0x47E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_INVALID_RESOURCE_FLAGS")]
        MessageIDCreateplacedresourceonbufferInvalidResourceFlags = 0x47F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPLACEDRESOURCEONBUFFER_OUTOFMEMORY_RETURN")]
        MessageIDCreateplacedresourceonbufferOutofmemoryReturn = 0x480,
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_CREATE_GRAPHICS_AND_VIDEO_COMMAND_RECORDER")]
        MessageIDCannotCreateGraphicsAndVideoCommandRecorder = 0x481,
        [NativeName("Name", "D3D12_MESSAGE_ID_UPDATETILEMAPPINGS_POSSIBLY_MISMATCHING_PROPERTIES")]
        MessageIDUpdatetilemappingsPossiblyMismatchingProperties = 0x482,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_INVALID_COMMAND_LIST_TYPE")]
        MessageIDCreateCommandListInvalidCommandListType = 0x483,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_INCOMPATIBLE_WITH_STRUCTURED_BUFFERS")]
        MessageIDClearunorderedaccessviewIncompatibleWithStructuredBuffers = 0x484,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMPUTE_ONLY_DEVICE_OPERATION_UNSUPPORTED")]
        MessageIDComputeOnlyDeviceOperationUnsupported = 0x485,
        [NativeName("Name", "D3D12_MESSAGE_ID_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INVALID")]
        MessageIDBuildRaytracingAccelerationStructureInvalid = 0x486,
        [NativeName("Name", "D3D12_MESSAGE_ID_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_INVALID")]
        MessageIDEmitRaytracingAccelerationStructurePostbuildInfoInvalid = 0x487,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPY_RAYTRACING_ACCELERATION_STRUCTURE_INVALID")]
        MessageIDCopyRaytracingAccelerationStructureInvalid = 0x488,
        [NativeName("Name", "D3D12_MESSAGE_ID_DISPATCH_RAYS_INVALID")]
        MessageIDDispatchRaysInvalid = 0x489,
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO_INVALID")]
        MessageIDGetRaytracingAccelerationStructurePrebuildInfoInvalid = 0x48A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_LIFETIMETRACKER")]
        MessageIDCreateLifetimetracker = 0x48B,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_LIFETIMETRACKER")]
        MessageIDLiveLifetimetracker = 0x48C,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_LIFETIMETRACKER")]
        MessageIDDestroyLifetimetracker = 0x48D,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROYOWNEDOBJECT_OBJECTNOTOWNED")]
        MessageIDDestroyownedobjectObjectnotowned = 0x48E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_TRACKEDWORKLOAD")]
        MessageIDCreateTrackedworkload = 0x48F,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_TRACKEDWORKLOAD")]
        MessageIDLiveTrackedworkload = 0x490,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_TRACKEDWORKLOAD")]
        MessageIDDestroyTrackedworkload = 0x491,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_ERROR")]
        MessageIDRenderPassError = 0x492,
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_ID_INVALID")]
        MessageIDMetaCommandIDInvalid = 0x493,
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_UNSUPPORTED_PARAMS")]
        MessageIDMetaCommandUnsupportedParams = 0x494,
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_FAILED_ENUMERATION")]
        MessageIDMetaCommandFailedEnumeration = 0x495,
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_PARAMETER_SIZE_MISMATCH")]
        MessageIDMetaCommandParameterSizeMismatch = 0x496,
        [NativeName("Name", "D3D12_MESSAGE_ID_UNINITIALIZED_META_COMMAND")]
        MessageIDUninitializedMetaCommand = 0x497,
        [NativeName("Name", "D3D12_MESSAGE_ID_META_COMMAND_INVALID_GPU_VIRTUAL_ADDRESS")]
        MessageIDMetaCommandInvalidGpuVirtualAddress = 0x498,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOENCODECOMMANDLIST")]
        MessageIDCreateVideoencodecommandlist = 0x499,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOENCODECOMMANDLIST")]
        MessageIDLiveVideoencodecommandlist = 0x49A,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOENCODECOMMANDLIST")]
        MessageIDDestroyVideoencodecommandlist = 0x49B,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOENCODECOMMANDQUEUE")]
        MessageIDCreateVideoencodecommandqueue = 0x49C,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOENCODECOMMANDQUEUE")]
        MessageIDLiveVideoencodecommandqueue = 0x49D,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOENCODECOMMANDQUEUE")]
        MessageIDDestroyVideoencodecommandqueue = 0x49E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOMOTIONESTIMATOR")]
        MessageIDCreateVideomotionestimator = 0x49F,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOMOTIONESTIMATOR")]
        MessageIDLiveVideomotionestimator = 0x4A0,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOMOTIONESTIMATOR")]
        MessageIDDestroyVideomotionestimator = 0x4A1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOMOTIONVECTORHEAP")]
        MessageIDCreateVideomotionvectorheap = 0x4A2,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOMOTIONVECTORHEAP")]
        MessageIDLiveVideomotionvectorheap = 0x4A3,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOMOTIONVECTORHEAP")]
        MessageIDDestroyVideomotionvectorheap = 0x4A4,
        [NativeName("Name", "D3D12_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOADS")]
        MessageIDMultipleTrackedWorkloads = 0x4A5,
        [NativeName("Name", "D3D12_MESSAGE_ID_MULTIPLE_TRACKED_WORKLOAD_PAIRS")]
        MessageIDMultipleTrackedWorkloadPairs = 0x4A6,
        [NativeName("Name", "D3D12_MESSAGE_ID_OUT_OF_ORDER_TRACKED_WORKLOAD_PAIR")]
        MessageIDOutOfOrderTrackedWorkloadPair = 0x4A7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CANNOT_ADD_TRACKED_WORKLOAD")]
        MessageIDCannotAddTrackedWorkload = 0x4A8,
        [NativeName("Name", "D3D12_MESSAGE_ID_INCOMPLETE_TRACKED_WORKLOAD_PAIR")]
        MessageIDIncompleteTrackedWorkloadPair = 0x4A9,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_STATE_OBJECT_ERROR")]
        MessageIDCreateStateObjectError = 0x4AA,
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_SHADER_IDENTIFIER_ERROR")]
        MessageIDGetShaderIdentifierError = 0x4AB,
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_SHADER_STACK_SIZE_ERROR")]
        MessageIDGetShaderStackSizeError = 0x4AC,
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_PIPELINE_STACK_SIZE_ERROR")]
        MessageIDGetPipelineStackSizeError = 0x4AD,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_PIPELINE_STACK_SIZE_ERROR")]
        MessageIDSetPipelineStackSizeError = 0x4AE,
        [NativeName("Name", "D3D12_MESSAGE_ID_GET_SHADER_IDENTIFIER_SIZE_INVALID")]
        MessageIDGetShaderIdentifierSizeInvalid = 0x4AF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CHECK_DRIVER_MATCHING_IDENTIFIER_INVALID")]
        MessageIDCheckDriverMatchingIdentifierInvalid = 0x4B0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CHECK_DRIVER_MATCHING_IDENTIFIER_DRIVER_REPORTED_ISSUE")]
        MessageIDCheckDriverMatchingIdentifierDriverReportedIssue = 0x4B1,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_INVALID_RESOURCE_BARRIER")]
        MessageIDRenderPassInvalidResourceBarrier = 0x4B2,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_DISALLOWED_API_CALLED")]
        MessageIDRenderPassDisallowedApiCalled = 0x4B3,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_NEST_RENDER_PASSES")]
        MessageIDRenderPassCannotNestRenderPasses = 0x4B4,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_END_WITHOUT_BEGIN")]
        MessageIDRenderPassCannotEndWithoutBegin = 0x4B5,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_CANNOT_CLOSE_COMMAND_LIST")]
        MessageIDRenderPassCannotCloseCommandList = 0x4B6,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_GPU_WORK_WHILE_SUSPENDED")]
        MessageIDRenderPassGpuWorkWhileSuspended = 0x4B7,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_SUSPEND_RESUME")]
        MessageIDRenderPassMismatchingSuspendResume = 0x4B8,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_NO_PRIOR_SUSPEND_WITHIN_EXECUTECOMMANDLISTS")]
        MessageIDRenderPassNoPriorSuspendWithinExecutecommandlists = 0x4B9,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_NO_SUBSEQUENT_RESUME_WITHIN_EXECUTECOMMANDLISTS")]
        MessageIDRenderPassNoSubsequentResumeWithinExecutecommandlists = 0x4BA,
        [NativeName("Name", "D3D12_MESSAGE_ID_TRACKED_WORKLOAD_COMMAND_QUEUE_MISMATCH")]
        MessageIDTrackedWorkloadCommandQueueMismatch = 0x4BB,
        [NativeName("Name", "D3D12_MESSAGE_ID_TRACKED_WORKLOAD_NOT_SUPPORTED")]
        MessageIDTrackedWorkloadNotSupported = 0x4BC,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_MISMATCHING_NO_ACCESS")]
        MessageIDRenderPassMismatchingNoAccess = 0x4BD,
        [NativeName("Name", "D3D12_MESSAGE_ID_RENDER_PASS_UNSUPPORTED_RESOLVE")]
        MessageIDRenderPassUnsupportedResolve = 0x4BE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEARUNORDEREDACCESSVIEW_INVALID_RESOURCE_PTR")]
        MessageIDClearunorderedaccessviewInvalidResourcePtr = 0x4BF,
        [NativeName("Name", "D3D12_MESSAGE_ID_WINDOWS7_FENCE_OUTOFORDER_SIGNAL")]
        MessageIDWindows7FenceOutoforderSignal = 0x4C0,
        [NativeName("Name", "D3D12_MESSAGE_ID_WINDOWS7_FENCE_OUTOFORDER_WAIT")]
        MessageIDWindows7FenceOutoforderWait = 0x4C1,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_CREATE_MOTION_ESTIMATOR_INVALID_ARGUMENT")]
        MessageIDVideoCreateMotionEstimatorInvalidArgument = 0x4C2,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_CREATE_MOTION_VECTOR_HEAP_INVALID_ARGUMENT")]
        MessageIDVideoCreateMotionVectorHeapInvalidArgument = 0x4C3,
        [NativeName("Name", "D3D12_MESSAGE_ID_ESTIMATE_MOTION_INVALID_ARGUMENT")]
        MessageIDEstimateMotionInvalidArgument = 0x4C4,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_MOTION_VECTOR_HEAP_INVALID_ARGUMENT")]
        MessageIDResolveMotionVectorHeapInvalidArgument = 0x4C5,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETGPUVIRTUALADDRESS_INVALID_HEAP_TYPE")]
        MessageIDGetgpuvirtualaddressInvalidHeapType = 0x4C6,
        [NativeName("Name", "D3D12_MESSAGE_ID_SET_BACKGROUND_PROCESSING_MODE_INVALID_ARGUMENT")]
        MessageIDSetBackgroundProcessingModeInvalidArgument = 0x4C7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_COMMAND_LIST_INVALID_COMMAND_LIST_TYPE_FOR_FEATURE_LEVEL")]
        MessageIDCreateCommandListInvalidCommandListTypeForFeatureLevel = 0x4C8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOEXTENSIONCOMMAND")]
        MessageIDCreateVideoextensioncommand = 0x4C9,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOEXTENSIONCOMMAND")]
        MessageIDLiveVideoextensioncommand = 0x4CA,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOEXTENSIONCOMMAND")]
        MessageIDDestroyVideoextensioncommand = 0x4CB,
        [NativeName("Name", "D3D12_MESSAGE_ID_INVALID_VIDEO_EXTENSION_COMMAND_ID")]
        MessageIDInvalidVideoExtensionCommandID = 0x4CC,
        [NativeName("Name", "D3D12_MESSAGE_ID_VIDEO_EXTENSION_COMMAND_INVALID_ARGUMENT")]
        MessageIDVideoExtensionCommandInvalidArgument = 0x4CD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_NOT_UNIQUE_IN_DXIL_LIBRARY")]
        MessageIDCreateRootSignatureNotUniqueInDxilLibrary = 0x4CE,
        [NativeName("Name", "D3D12_MESSAGE_ID_VARIABLE_SHADING_RATE_NOT_ALLOWED_WITH_TIR")]
        MessageIDVariableShadingRateNotAllowedWithTir = 0x4CF,
        [NativeName("Name", "D3D12_MESSAGE_ID_GEOMETRY_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE")]
        MessageIDGeometryShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 0x4D0,
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADING_RATE_INVALID_SHADING_RATE")]
        MessageIDRssetshadingRateInvalidShadingRate = 0x4D1,
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADING_RATE_SHADING_RATE_NOT_PERMITTED_BY_CAP")]
        MessageIDRssetshadingRateShadingRateNotPermittedByCap = 0x4D2,
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADING_RATE_INVALID_COMBINER")]
        MessageIDRssetshadingRateInvalidCombiner = 0x4D3,
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADINGRATEIMAGE_REQUIRES_TIER_2")]
        MessageIDRssetshadingrateimageRequiresTier2 = 0x4D4,
        [NativeName("Name", "D3D12_MESSAGE_ID_RSSETSHADINGRATE_REQUIRES_TIER_1")]
        MessageIDRssetshadingrateRequiresTier1 = 0x4D5,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_FORMAT")]
        MessageIDShadingRateImageIncorrectFormat = 0x4D6,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_ARRAY_SIZE")]
        MessageIDShadingRateImageIncorrectArraySize = 0x4D7,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_MIP_LEVEL")]
        MessageIDShadingRateImageIncorrectMipLevel = 0x4D8,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_SAMPLE_COUNT")]
        MessageIDShadingRateImageIncorrectSampleCount = 0x4D9,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADING_RATE_IMAGE_INCORRECT_SAMPLE_QUALITY")]
        MessageIDShadingRateImageIncorrectSampleQuality = 0x4DA,
        [NativeName("Name", "D3D12_MESSAGE_ID_NON_RETAIL_SHADER_MODEL_WONT_VALIDATE")]
        MessageIDNonRetailShaderModelWontValidate = 0x4DB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_AS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateAsRootSignatureMismatch = 0x4DC,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_ROOT_SIGNATURE_MISMATCH")]
        MessageIDCreategraphicspipelinestateMSRootSignatureMismatch = 0x4DD,
        [NativeName("Name", "D3D12_MESSAGE_ID_ADD_TO_STATE_OBJECT_ERROR")]
        MessageIDAddToStateObjectError = 0x4DE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_PROTECTED_RESOURCE_SESSION_INVALID_ARGUMENT")]
        MessageIDCreateProtectedResourceSessionInvalidArgument = 0x4DF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_PSO_DESC_MISMATCH")]
        MessageIDCreategraphicspipelinestateMSPsoDescMismatch = 0x4E0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEPIPELINESTATE_MS_INCOMPLETE_TYPE")]
        MessageIDCreatepipelinestateMSIncompleteType = 0x4E1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_AS_NOT_MS_MISMATCH")]
        MessageIDCreategraphicspipelinestateAsNotMSMismatch = 0x4E2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_MS_NOT_PS_MISMATCH")]
        MessageIDCreategraphicspipelinestateMSNotPSMismatch = 0x4E3,
        [NativeName("Name", "D3D12_MESSAGE_ID_NONZERO_SAMPLER_FEEDBACK_MIP_REGION_WITH_INCOMPATIBLE_FORMAT")]
        MessageIDNonzeroSamplerFeedbackMipRegionWithIncompatibleFormat = 0x4E4,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEGRAPHICSPIPELINESTATE_INPUTLAYOUT_SHADER_MISMATCH")]
        MessageIDCreategraphicspipelinestateInputlayoutShaderMismatch = 0x4E5,
        [NativeName("Name", "D3D12_MESSAGE_ID_EMPTY_DISPATCH")]
        MessageIDEmptyDispatch = 0x4E6,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOURCE_FORMAT_REQUIRES_SAMPLER_FEEDBACK_CAPABILITY")]
        MessageIDResourceFormatRequiresSamplerFeedbackCapability = 0x4E7,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_MIP_REGION")]
        MessageIDSamplerFeedbackMapInvalidMipRegion = 0x4E8,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_DIMENSION")]
        MessageIDSamplerFeedbackMapInvalidDimension = 0x4E9,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_SAMPLE_COUNT")]
        MessageIDSamplerFeedbackMapInvalidSampleCount = 0x4EA,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_SAMPLE_QUALITY")]
        MessageIDSamplerFeedbackMapInvalidSampleQuality = 0x4EB,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_INVALID_LAYOUT")]
        MessageIDSamplerFeedbackMapInvalidLayout = 0x4EC,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_MAP_REQUIRES_UNORDERED_ACCESS_FLAG")]
        MessageIDSamplerFeedbackMapRequiresUnorderedAccessFlag = 0x4ED,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_NULL_ARGUMENTS")]
        MessageIDSamplerFeedbackCreateUavNullArguments = 0x4EE,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_UAV_REQUIRES_SAMPLER_FEEDBACK_CAPABILITY")]
        MessageIDSamplerFeedbackUavRequiresSamplerFeedbackCapability = 0x4EF,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_REQUIRES_FEEDBACK_MAP_FORMAT")]
        MessageIDSamplerFeedbackCreateUavRequiresFeedbackMapFormat = 0x4F0,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreatemeshshaderInvalidshaderbytecode = 0x4F1,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_OUTOFMEMORY")]
        MessageIDCreatemeshshaderOutofmemory = 0x4F2,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADERWITHSTREAMOUTPUT_INVALIDSHADERTYPE")]
        MessageIDCreatemeshshaderwithstreamoutputInvalidshadertype = 0x4F3,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_TRANSCODE_INVALID_FORMAT")]
        MessageIDResolvesubresourceSamplerFeedbackTranscodeInvalidFormat = 0x4F4,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_INVALID_MIP_LEVEL_COUNT")]
        MessageIDResolvesubresourceSamplerFeedbackInvalidMipLevelCount = 0x4F5,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVESUBRESOURCE_SAMPLER_FEEDBACK_TRANSCODE_ARRAY_SIZE_MISMATCH")]
        MessageIDResolvesubresourceSamplerFeedbackTranscodeArraySizeMismatch = 0x4F6,
        [NativeName("Name", "D3D12_MESSAGE_ID_SAMPLER_FEEDBACK_CREATE_UAV_MISMATCHING_TARGETED_RESOURCE")]
        MessageIDSamplerFeedbackCreateUavMismatchingTargetedResource = 0x4F7,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_OUTPUTEXCEEDSMAXSIZE")]
        MessageIDCreatemeshshaderOutputexceedsmaxsize = 0x4F8,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_GROUPSHAREDEXCEEDSMAXSIZE")]
        MessageIDCreatemeshshaderGroupsharedexceedsmaxsize = 0x4F9,
        [NativeName("Name", "D3D12_MESSAGE_ID_VERTEX_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE")]
        MessageIDVertexShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 0x4FA,
        [NativeName("Name", "D3D12_MESSAGE_ID_MESH_SHADER_OUTPUTTING_BOTH_VIEWPORT_ARRAY_INDEX_AND_SHADING_RATE_NOT_SUPPORTED_ON_DEVICE")]
        MessageIDMeshShaderOutputtingBothViewportArrayIndexAndShadingRateNotSupportedOnDevice = 0x4FB,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_MISMATCHEDASMSPAYLOADSIZE")]
        MessageIDCreatemeshshaderMismatchedasmspayloadsize = 0x4FC,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_ROOT_SIGNATURE_UNBOUNDED_STATIC_DESCRIPTORS")]
        MessageIDCreateRootSignatureUnboundedStaticDescriptors = 0x4FD,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEAMPLIFICATIONSHADER_INVALIDSHADERBYTECODE")]
        MessageIDCreateamplificationshaderInvalidshaderbytecode = 0x4FE,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEAMPLIFICATIONSHADER_OUTOFMEMORY")]
        MessageIDCreateamplificationshaderOutofmemory = 0x4FF,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_SHADERCACHESESSION")]
        MessageIDCreateShadercachesession = 0x500,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_SHADERCACHESESSION")]
        MessageIDLiveShadercachesession = 0x501,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_SHADERCACHESESSION")]
        MessageIDDestroyShadercachesession = 0x502,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_INVALIDARGS")]
        MessageIDCreateshadercachesessionInvalidargs = 0x503,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_DISABLED")]
        MessageIDCreateshadercachesessionDisabled = 0x504,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATESHADERCACHESESSION_ALREADYOPEN")]
        MessageIDCreateshadercachesessionAlreadyopen = 0x505,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_DEVELOPERMODE")]
        MessageIDShadercachecontrolDevelopermode = 0x506,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_INVALIDFLAGS")]
        MessageIDShadercachecontrolInvalidflags = 0x507,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_STATEALREADYSET")]
        MessageIDShadercachecontrolStatealreadyset = 0x508,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_IGNOREDFLAG")]
        MessageIDShadercachecontrolIgnoredflag = 0x509,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_ALREADYPRESENT")]
        MessageIDShadercachesessionStorevalueAlreadypresent = 0x50A,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_HASHCOLLISION")]
        MessageIDShadercachesessionStorevalueHashcollision = 0x50B,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_STOREVALUE_CACHEFULL")]
        MessageIDShadercachesessionStorevalueCachefull = 0x50C,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_FINDVALUE_NOTFOUND")]
        MessageIDShadercachesessionFindvalueNotfound = 0x50D,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_CORRUPT")]
        MessageIDShadercachesessionCorrupt = 0x50E,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_DISABLED")]
        MessageIDShadercachesessionDisabled = 0x50F,
        [NativeName("Name", "D3D12_MESSAGE_ID_OVERSIZED_DISPATCH")]
        MessageIDOversizedDispatch = 0x510,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOENCODER")]
        MessageIDCreateVideoencoder = 0x511,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOENCODER")]
        MessageIDLiveVideoencoder = 0x512,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOENCODER")]
        MessageIDDestroyVideoencoder = 0x513,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEOENCODERHEAP")]
        MessageIDCreateVideoencoderheap = 0x514,
        [NativeName("Name", "D3D12_MESSAGE_ID_LIVE_VIDEOENCODERHEAP")]
        MessageIDLiveVideoencoderheap = 0x515,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESTROY_VIDEOENCODERHEAP")]
        MessageIDDestroyVideoencoderheap = 0x516,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYTEXTUREREGION_MISMATCH_ENCODE_REFERENCE_ONLY_FLAG")]
        MessageIDCopytextureregionMismatchEncodeReferenceOnlyFlag = 0x517,
        [NativeName("Name", "D3D12_MESSAGE_ID_COPYRESOURCE_MISMATCH_ENCODE_REFERENCE_ONLY_FLAG")]
        MessageIDCopyresourceMismatchEncodeReferenceOnlyFlag = 0x518,
        [NativeName("Name", "D3D12_MESSAGE_ID_ENCODE_FRAME_INVALID_PARAMETERS")]
        MessageIDEncodeFrameInvalidParameters = 0x519,
        [NativeName("Name", "D3D12_MESSAGE_ID_ENCODE_FRAME_UNSUPPORTED_PARAMETERS")]
        MessageIDEncodeFrameUnsupportedParameters = 0x51A,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_ENCODER_OUTPUT_METADATA_INVALID_PARAMETERS")]
        MessageIDResolveEncoderOutputMetadataInvalidParameters = 0x51B,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_ENCODER_OUTPUT_METADATA_UNSUPPORTED_PARAMETERS")]
        MessageIDResolveEncoderOutputMetadataUnsupportedParameters = 0x51C,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_INVALID_PARAMETERS")]
        MessageIDCreateVideoEncoderInvalidParameters = 0x51D,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_UNSUPPORTED_PARAMETERS")]
        MessageIDCreateVideoEncoderUnsupportedParameters = 0x51E,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_HEAP_INVALID_PARAMETERS")]
        MessageIDCreateVideoEncoderHeapInvalidParameters = 0x51F,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATE_VIDEO_ENCODER_HEAP_UNSUPPORTED_PARAMETERS")]
        MessageIDCreateVideoEncoderHeapUnsupportedParameters = 0x520,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATECOMMANDLIST_NULL_COMMANDALLOCATOR")]
        MessageIDCreatecommandlistNullCommandallocator = 0x521,
        [NativeName("Name", "D3D12_MESSAGE_ID_CLEAR_UNORDERED_ACCESS_VIEW_INVALID_DESCRIPTOR_HANDLE")]
        MessageIDClearUnorderedAccessViewInvalidDescriptorHandle = 0x522,
        [NativeName("Name", "D3D12_MESSAGE_ID_DESCRIPTOR_HEAP_NOT_SHADER_VISIBLE")]
        MessageIDDescriptorHeapNotShaderVisible = 0x523,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_BLENDOP_WARNING")]
        MessageIDCreateblendstateBlendopWarning = 0x524,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEBLENDSTATE_BLENDOPALPHA_WARNING")]
        MessageIDCreateblendstateBlendopalphaWarning = 0x525,
        [NativeName("Name", "D3D12_MESSAGE_ID_WRITE_COMBINE_PERFORMANCE_WARNING")]
        MessageIDWriteCombinePerformanceWarning = 0x526,
        [NativeName("Name", "D3D12_MESSAGE_ID_RESOLVE_QUERY_INVALID_QUERY_STATE")]
        MessageIDResolveQueryInvalidQueryState = 0x527,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETPRIVATEDATA_NO_ACCESS")]
        MessageIDSetprivatedataNoAccess = 0x528,
        [NativeName("Name", "D3D12_MESSAGE_ID_COMMAND_LIST_STATIC_DESCRIPTOR_SAMPLER_MODE_MISMATCH")]
        MessageIDCommandListStaticDescriptorSamplerModeMismatch = 0x529,
        [NativeName("Name", "D3D12_MESSAGE_ID_GETCOPYABLEFOOTPRINTS_UNSUPPORTED_BUFFER_WIDTH")]
        MessageIDGetcopyablefootprintsUnsupportedBufferWidth = 0x52A,
        [NativeName("Name", "D3D12_MESSAGE_ID_CREATEMESHSHADER_TOPOLOGY_MISMATCH")]
        MessageIDCreatemeshshaderTopologyMismatch = 0x52B,
        [NativeName("Name", "D3D12_MESSAGE_ID_VRS_SUM_COMBINER_REQUIRES_CAPABILITY")]
        MessageIDVrsSumCombinerRequiresCapability = 0x52C,
        [NativeName("Name", "D3D12_MESSAGE_ID_SETTING_SHADING_RATE_FROM_MS_REQUIRES_CAPABILITY")]
        MessageIDSettingShadingRateFromMSRequiresCapability = 0x52D,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHESESSION_SHADERCACHEDELETE_NOTSUPPORTED")]
        MessageIDShadercachesessionShadercachedeleteNotsupported = 0x52E,
        [NativeName("Name", "D3D12_MESSAGE_ID_SHADERCACHECONTROL_SHADERCACHECLEAR_NOTSUPPORTED")]
        MessageIDShadercachecontrolShadercacheclearNotsupported = 0x52F,
        [NativeName("Name", "D3D12_MESSAGE_ID_D3D12_MESSAGES_END")]
        MessageIDD3D12MessagesEnd = 0x530,
    }
}
