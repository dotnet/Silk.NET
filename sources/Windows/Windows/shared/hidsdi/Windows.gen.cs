// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidsdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetAttributes"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetAttributes(HANDLE HidDeviceObject, [NativeTypeName("PHIDD_ATTRIBUTES")] HIDD_ATTRIBUTES* Attributes);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetHidGuid"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    public static extern void HidD_GetHidGuid([NativeTypeName("LPGUID")] Guid* HidGuid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetPreparsedData"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetPreparsedData(HANDLE HidDeviceObject, PHIDP_PREPARSED_DATA* PreparsedData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_FreePreparsedData"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_FreePreparsedData(PHIDP_PREPARSED_DATA PreparsedData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_FlushQueue"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_FlushQueue(HANDLE HidDeviceObject);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetConfiguration"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetConfiguration(HANDLE HidDeviceObject, [NativeTypeName("PHIDD_CONFIGURATION")] HIDD_CONFIGURATION* Configuration, [NativeTypeName("ULONG")] uint ConfigurationLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_SetConfiguration"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_SetConfiguration(HANDLE HidDeviceObject, [NativeTypeName("PHIDD_CONFIGURATION")] HIDD_CONFIGURATION* Configuration, [NativeTypeName("ULONG")] uint ConfigurationLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetFeature"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetFeature(HANDLE HidDeviceObject, [NativeTypeName("PVOID")] void* ReportBuffer, [NativeTypeName("ULONG")] uint ReportBufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_SetFeature"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_SetFeature(HANDLE HidDeviceObject, [NativeTypeName("PVOID")] void* ReportBuffer, [NativeTypeName("ULONG")] uint ReportBufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetInputReport"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetInputReport(HANDLE HidDeviceObject, [NativeTypeName("PVOID")] void* ReportBuffer, [NativeTypeName("ULONG")] uint ReportBufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_SetOutputReport"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_SetOutputReport(HANDLE HidDeviceObject, [NativeTypeName("PVOID")] void* ReportBuffer, [NativeTypeName("ULONG")] uint ReportBufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetNumInputBuffers"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetNumInputBuffers(HANDLE HidDeviceObject, [NativeTypeName("PULONG")] uint* NumberBuffers);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_SetNumInputBuffers"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_SetNumInputBuffers(HANDLE HidDeviceObject, [NativeTypeName("ULONG")] uint NumberBuffers);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetPhysicalDescriptor"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetPhysicalDescriptor(HANDLE HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetManufacturerString"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetManufacturerString(HANDLE HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetProductString"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetProductString(HANDLE HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetIndexedString"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetIndexedString(HANDLE HidDeviceObject, [NativeTypeName("ULONG")] uint StringIndex, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetSerialNumberString"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetSerialNumberString(HANDLE HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidD_GetMsGenreDescriptor"]/*'/>
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetMsGenreDescriptor(HANDLE HidDeviceObject, [NativeTypeName("PVOID")] void* Buffer, [NativeTypeName("ULONG")] uint BufferLength);
}