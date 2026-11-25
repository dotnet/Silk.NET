// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch_windows")]
public unsafe partial struct IcdDispatchWindows
{
    [NativeName("Anonymous1")]
    public IcdDispatchWindowsAnonymous1 Anonymous1;

    [NativeName("clGetPlatformInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetPlatformInfo ClGetPlatformInfo;

    [NativeName("clGetDeviceIDs")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetDeviceIDs ClGetDeviceIDs;

    [NativeName("clGetDeviceInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetDeviceInfo ClGetDeviceInfo;

    [NativeName("clCreateContext")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsCreateContext ClCreateContext;

    [NativeName("clCreateContextFromType")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsCreateContextFromType ClCreateContextFromType;

    [NativeName("clRetainContext")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsRetainContext ClRetainContext;

    [NativeName("clReleaseContext")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsReleaseContext ClReleaseContext;

    [NativeName("clGetContextInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetContextInfo ClGetContextInfo;

    [NativeName("clCreateCommandQueue")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsCreateCommandQueue ClCreateCommandQueue;

    [NativeName("clRetainCommandQueue")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsRetainCommandQueue ClRetainCommandQueue;

    [NativeName("clReleaseCommandQueue")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsReleaseCommandQueue ClReleaseCommandQueue;

    [NativeName("clGetCommandQueueInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetCommandQueueInfo ClGetCommandQueueInfo;

    [NativeName("clSetCommandQueueProperty")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsSetCommandQueueProperty ClSetCommandQueueProperty;

    [NativeName("clCreateBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsCreateBuffer ClCreateBuffer;

    [NativeName("clCreateImage2D")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsCreateImage2D ClCreateImage2D;

    [NativeName("clCreateImage3D")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsCreateImage3D ClCreateImage3D;

    [NativeName("clRetainMemObject")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsRetainMemObject ClRetainMemObject;

    [NativeName("clReleaseMemObject")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsReleaseMemObject ClReleaseMemObject;

    [NativeName("clGetSupportedImageFormats")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetSupportedImageFormats ClGetSupportedImageFormats;

    [NativeName("clGetMemObjectInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetMemObjectInfo ClGetMemObjectInfo;

    [NativeName("clGetImageInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetImageInfo ClGetImageInfo;

    [NativeName("clCreateSampler")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsCreateSampler ClCreateSampler;

    [NativeName("clRetainSampler")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsRetainSampler ClRetainSampler;

    [NativeName("clReleaseSampler")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsReleaseSampler ClReleaseSampler;

    [NativeName("clGetSamplerInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetSamplerInfo ClGetSamplerInfo;

    [NativeName("clCreateProgramWithSource")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsCreateProgramWithSource ClCreateProgramWithSource;

    [NativeName("clCreateProgramWithBinary")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsCreateProgramWithBinary ClCreateProgramWithBinary;

    [NativeName("clRetainProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsRetainProgram ClRetainProgram;

    [NativeName("clReleaseProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsReleaseProgram ClReleaseProgram;

    [NativeName("clBuildProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsBuildProgram ClBuildProgram;

    [NativeName("Anonymous2")]
    public IcdDispatchWindowsAnonymous2 Anonymous2;

    [NativeName("clGetProgramInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetProgramInfo ClGetProgramInfo;

    [NativeName("clGetProgramBuildInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetProgramBuildInfo ClGetProgramBuildInfo;

    [NativeName("clCreateKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsCreateKernel ClCreateKernel;

    [NativeName("clCreateKernelsInProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsCreateKernelsInProgram ClCreateKernelsInProgram;

    [NativeName("clRetainKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsRetainKernel ClRetainKernel;

    [NativeName("clReleaseKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsReleaseKernel ClReleaseKernel;

    [NativeName("clSetKernelArg")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsSetKernelArg ClSetKernelArg;

    [NativeName("clGetKernelInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetKernelInfo ClGetKernelInfo;

    [NativeName("clGetKernelWorkGroupInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetKernelWorkGroupInfo ClGetKernelWorkGroupInfo;

    [NativeName("clWaitForEvents")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsWaitForEvents ClWaitForEvents;

    [NativeName("clGetEventInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetEventInfo ClGetEventInfo;

    [NativeName("clRetainEvent")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsRetainEvent ClRetainEvent;

    [NativeName("clReleaseEvent")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsReleaseEvent ClReleaseEvent;

    [NativeName("clGetEventProfilingInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetEventProfilingInfo ClGetEventProfilingInfo;

    [NativeName("clFlush")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsFlush ClFlush;

    [NativeName("clFinish")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsFinish ClFinish;

    [NativeName("clEnqueueReadBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueReadBuffer ClEnqueueReadBuffer;

    [NativeName("clEnqueueWriteBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueWriteBuffer ClEnqueueWriteBuffer;

    [NativeName("clEnqueueCopyBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueCopyBuffer ClEnqueueCopyBuffer;

    [NativeName("clEnqueueReadImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueReadImage ClEnqueueReadImage;

    [NativeName("clEnqueueWriteImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueWriteImage ClEnqueueWriteImage;

    [NativeName("clEnqueueCopyImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueCopyImage ClEnqueueCopyImage;

    [NativeName("clEnqueueCopyImageToBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueCopyImageToBuffer ClEnqueueCopyImageToBuffer;

    [NativeName("clEnqueueCopyBufferToImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueCopyBufferToImage ClEnqueueCopyBufferToImage;

    [NativeName("clEnqueueMapBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueMapBuffer ClEnqueueMapBuffer;

    [NativeName("clEnqueueMapImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueMapImage ClEnqueueMapImage;

    [NativeName("clEnqueueUnmapMemObject")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueUnmapMemObject ClEnqueueUnmapMemObject;

    [NativeName("clEnqueueNDRangeKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueNDRangeKernel ClEnqueueNDRangeKernel;

    [NativeName("clEnqueueTask")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueTask ClEnqueueTask;

    [NativeName("clEnqueueNativeKernel")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueNativeKernel ClEnqueueNativeKernel;

    [NativeName("clEnqueueMarker")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueMarker ClEnqueueMarker;

    [NativeName("clEnqueueWaitForEvents")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueWaitForEvents ClEnqueueWaitForEvents;

    [NativeName("clEnqueueBarrier")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsEnqueueBarrier ClEnqueueBarrier;

    [NativeName("clGetExtensionFunctionAddress")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public IcdDispatchWindowsGetExtensionFunctionAddress ClGetExtensionFunctionAddress;

    [NativeName("clCreateFromGLBuffer")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchWindowsCreateFromGLBuffer ClCreateFromGLBuffer;

    [NativeName("clCreateFromGLTexture2D")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchWindowsCreateFromGLTexture2D ClCreateFromGLTexture2D;

    [NativeName("clCreateFromGLTexture3D")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchWindowsCreateFromGLTexture3D ClCreateFromGLTexture3D;

    [NativeName("clCreateFromGLRenderbuffer")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchWindowsCreateFromGLRenderbuffer ClCreateFromGLRenderbuffer;

    [NativeName("clGetGLObjectInfo")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchWindowsGetGLObjectInfo ClGetGLObjectInfo;

    [NativeName("clGetGLTextureInfo")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchWindowsGetGLTextureInfo ClGetGLTextureInfo;

    [NativeName("clEnqueueAcquireGLObjects")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchWindowsEnqueueAcquireGLObjects ClEnqueueAcquireGLObjects;

    [NativeName("clEnqueueReleaseGLObjects")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchWindowsEnqueueReleaseGLObjects ClEnqueueReleaseGLObjects;

    [NativeName("clGetGLContextInfoKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchWindowsGetGLContextInfoKHR ClGetGLContextInfoKHR;

    [NativeName("clGetDeviceIDsFromD3D10KHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d10_sharing"])]
    public IcdDispatchWindowsGetDeviceIDsFromD3D10KHR ClGetDeviceIDsFromD3D10KHR;

    [NativeName("clCreateFromD3D10BufferKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d10_sharing"])]
    public IcdDispatchWindowsCreateFromD3D10BufferKHR ClCreateFromD3D10BufferKHR;

    [NativeName("clCreateFromD3D10Texture2DKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d10_sharing"])]
    public IcdDispatchWindowsCreateFromD3D10Texture2DKHR ClCreateFromD3D10Texture2DKHR;

    [NativeName("clCreateFromD3D10Texture3DKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d10_sharing"])]
    public IcdDispatchWindowsCreateFromD3D10Texture3DKHR ClCreateFromD3D10Texture3DKHR;

    [NativeName("clEnqueueAcquireD3D10ObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d10_sharing"])]
    public IcdDispatchWindowsEnqueueAcquireD3D10ObjectsKHR ClEnqueueAcquireD3D10ObjectsKHR;

    [NativeName("clEnqueueReleaseD3D10ObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d10_sharing"])]
    public IcdDispatchWindowsEnqueueReleaseD3D10ObjectsKHR ClEnqueueReleaseD3D10ObjectsKHR;

    [NativeName("clSetEventCallback")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    public IcdDispatchWindowsSetEventCallback ClSetEventCallback;

    [NativeName("clCreateSubBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    public IcdDispatchWindowsCreateSubBuffer ClCreateSubBuffer;

    [NativeName("clSetMemObjectDestructorCallback")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    public IcdDispatchWindowsSetMemObjectDestructorCallback ClSetMemObjectDestructorCallback;

    [NativeName("clCreateUserEvent")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    public IcdDispatchWindowsCreateUserEvent ClCreateUserEvent;

    [NativeName("clSetUserEventStatus")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    public IcdDispatchWindowsSetUserEventStatus ClSetUserEventStatus;

    [NativeName("clEnqueueReadBufferRect")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    public IcdDispatchWindowsEnqueueReadBufferRect ClEnqueueReadBufferRect;

    [NativeName("clEnqueueWriteBufferRect")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    public IcdDispatchWindowsEnqueueWriteBufferRect ClEnqueueWriteBufferRect;

    [NativeName("clEnqueueCopyBufferRect")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.1"
    )]
    public IcdDispatchWindowsEnqueueCopyBufferRect ClEnqueueCopyBufferRect;

    [NativeName("clCreateSubDevicesEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    public IcdDispatchWindowsCreateSubDevicesEXT ClCreateSubDevicesEXT;

    [NativeName("clRetainDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    public IcdDispatchWindowsRetainDeviceEXT ClRetainDeviceEXT;

    [NativeName("clReleaseDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    public IcdDispatchWindowsReleaseDeviceEXT ClReleaseDeviceEXT;

    [NativeName("clCreateEventFromGLsyncKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_event"], ImpliesSets = ["cl_khr_gl_sharing"])]
    public IcdDispatchWindowsCreateEventFromGLsyncKHR ClCreateEventFromGLsyncKHR;

    [NativeName("clCreateSubDevices")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsCreateSubDevices ClCreateSubDevices;

    [NativeName("clRetainDevice")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsRetainDevice ClRetainDevice;

    [NativeName("clReleaseDevice")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsReleaseDevice ClReleaseDevice;

    [NativeName("clCreateImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsCreateImage ClCreateImage;

    [NativeName("clCreateProgramWithBuiltInKernels")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsCreateProgramWithBuiltInKernels ClCreateProgramWithBuiltInKernels;

    [NativeName("clCompileProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsCompileProgram ClCompileProgram;

    [NativeName("clLinkProgram")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsLinkProgram ClLinkProgram;

    [NativeName("clUnloadPlatformCompiler")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsUnloadPlatformCompiler ClUnloadPlatformCompiler;

    [NativeName("clGetKernelArgInfo")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsGetKernelArgInfo ClGetKernelArgInfo;

    [NativeName("clEnqueueFillBuffer")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsEnqueueFillBuffer ClEnqueueFillBuffer;

    [NativeName("clEnqueueFillImage")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsEnqueueFillImage ClEnqueueFillImage;

    [NativeName("clEnqueueMigrateMemObjects")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsEnqueueMigrateMemObjects ClEnqueueMigrateMemObjects;

    [NativeName("clEnqueueMarkerWithWaitList")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsEnqueueMarkerWithWaitList ClEnqueueMarkerWithWaitList;

    [NativeName("clEnqueueBarrierWithWaitList")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsEnqueueBarrierWithWaitList ClEnqueueBarrierWithWaitList;

    [NativeName("clGetExtensionFunctionAddressForPlatform")]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.2"
    )]
    public IcdDispatchWindowsGetExtensionFunctionAddressForPlatform ClGetExtensionFunctionAddressForPlatform;

    [NativeName("clCreateFromGLTexture")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchWindowsCreateFromGLTexture ClCreateFromGLTexture;

    [NativeName("clGetDeviceIDsFromD3D11KHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d11_sharing"])]
    public IcdDispatchWindowsGetDeviceIDsFromD3D11KHR ClGetDeviceIDsFromD3D11KHR;

    [NativeName("clCreateFromD3D11BufferKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d11_sharing"])]
    public IcdDispatchWindowsCreateFromD3D11BufferKHR ClCreateFromD3D11BufferKHR;

    [NativeName("clCreateFromD3D11Texture2DKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d11_sharing"])]
    public IcdDispatchWindowsCreateFromD3D11Texture2DKHR ClCreateFromD3D11Texture2DKHR;

    [NativeName("clCreateFromD3D11Texture3DKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d11_sharing"])]
    public IcdDispatchWindowsCreateFromD3D11Texture3DKHR ClCreateFromD3D11Texture3DKHR;

    [NativeName("clCreateFromDX9MediaSurfaceKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_dx9_media_sharing"])]
    public IcdDispatchWindowsCreateFromDx9MediaSurfaceKHR ClCreateFromDx9MediaSurfaceKHR;

    [NativeName("clEnqueueAcquireD3D11ObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d11_sharing"])]
    public IcdDispatchWindowsEnqueueAcquireD3D11ObjectsKHR ClEnqueueAcquireD3D11ObjectsKHR;

    [NativeName("clEnqueueReleaseD3D11ObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d11_sharing"])]
    public IcdDispatchWindowsEnqueueReleaseD3D11ObjectsKHR ClEnqueueReleaseD3D11ObjectsKHR;

    [NativeName("clGetDeviceIDsFromDX9MediaAdapterKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_dx9_media_sharing"])]
    public IcdDispatchWindowsGetDeviceIDsFromDx9MediaAdapterKHR ClGetDeviceIDsFromDx9MediaAdapterKHR;

    [NativeName("clEnqueueAcquireDX9MediaSurfacesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_dx9_media_sharing"])]
    public IcdDispatchWindowsEnqueueAcquireDx9MediaSurfacesKHR ClEnqueueAcquireDx9MediaSurfacesKHR;

    [NativeName("clEnqueueReleaseDX9MediaSurfacesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_dx9_media_sharing"])]
    public IcdDispatchWindowsEnqueueReleaseDx9MediaSurfacesKHR ClEnqueueReleaseDx9MediaSurfacesKHR;

    [NativeName("clCreateFromEGLImageKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_egl_image"])]
    public IcdDispatchWindowsCreateFromEglImageKHR ClCreateFromEglImageKHR;

    [NativeName("clEnqueueAcquireEGLObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_egl_image"])]
    public IcdDispatchWindowsEnqueueAcquireEglObjectsKHR ClEnqueueAcquireEglObjectsKHR;

    [NativeName("clEnqueueReleaseEGLObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_egl_image"])]
    public IcdDispatchWindowsEnqueueReleaseEglObjectsKHR ClEnqueueReleaseEglObjectsKHR;

    [NativeName("clCreateEventFromEGLSyncKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_egl_event"])]
    public IcdDispatchWindowsCreateEventFromEglSyncKHR ClCreateEventFromEglSyncKHR;

    [NativeName("clCreateCommandQueueWithProperties")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsCreateCommandQueueWithProperties ClCreateCommandQueueWithProperties;

    [NativeName("clCreatePipe")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsCreatePipe ClCreatePipe;

    [NativeName("clGetPipeInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsGetPipeInfo ClGetPipeInfo;

    [NativeName("clSVMAlloc")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsSvmAlloc ClSvmAlloc;

    [NativeName("clSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsSvmFree ClSvmFree;

    [NativeName("clEnqueueSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsEnqueueSvmFree ClEnqueueSvmFree;

    [NativeName("clEnqueueSVMMemcpy")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsEnqueueSvmMemcpy ClEnqueueSvmMemcpy;

    [NativeName("clEnqueueSVMMemFill")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsEnqueueSvmMemFill ClEnqueueSvmMemFill;

    [NativeName("clEnqueueSVMMap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsEnqueueSvmMap ClEnqueueSvmMap;

    [NativeName("clEnqueueSVMUnmap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsEnqueueSvmUnmap ClEnqueueSvmUnmap;

    [NativeName("clCreateSamplerWithProperties")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsCreateSamplerWithProperties ClCreateSamplerWithProperties;

    [NativeName("clSetKernelArgSVMPointer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsSetKernelArgSvmPointer ClSetKernelArgSvmPointer;

    [NativeName("clSetKernelExecInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchWindowsSetKernelExecInfo ClSetKernelExecInfo;

    [NativeName("clGetKernelSubGroupInfoKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_subgroups"])]
    public IcdDispatchWindowsGetKernelSubGroupInfoKHR ClGetKernelSubGroupInfoKHR;

    [NativeName("clCloneKernel")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchWindowsCloneKernel ClCloneKernel;

    [NativeName("clCreateProgramWithIL")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchWindowsCreateProgramWithIL ClCreateProgramWithIL;

    [NativeName("clEnqueueSVMMigrateMem")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchWindowsEnqueueSvmMigrateMem ClEnqueueSvmMigrateMem;

    [NativeName("clGetDeviceAndHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchWindowsGetDeviceAndHostTimer ClGetDeviceAndHostTimer;

    [NativeName("clGetHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchWindowsGetHostTimer ClGetHostTimer;

    [NativeName("clGetKernelSubGroupInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchWindowsGetKernelSubGroupInfo ClGetKernelSubGroupInfo;

    [NativeName("clSetDefaultDeviceCommandQueue")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchWindowsSetDefaultDeviceCommandQueue ClSetDefaultDeviceCommandQueue;

    [NativeName("clSetProgramReleaseCallback")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.2"
    )]
    public IcdDispatchWindowsSetProgramReleaseCallback ClSetProgramReleaseCallback;

    [NativeName("clSetProgramSpecializationConstant")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.2"
    )]
    public IcdDispatchWindowsSetProgramSpecializationConstant ClSetProgramSpecializationConstant;

    [NativeName("clCreateBufferWithProperties")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    public IcdDispatchWindowsCreateBufferWithProperties ClCreateBufferWithProperties;

    [NativeName("clCreateImageWithProperties")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    public IcdDispatchWindowsCreateImageWithProperties ClCreateImageWithProperties;

    [NativeName("clSetContextDestructorCallback")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    public IcdDispatchWindowsSetContextDestructorCallback ClSetContextDestructorCallback;

    [NativeName("clGetKernelSuggestedLocalWorkSize")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_1"], MinVersion = "3.1")]
    public IcdDispatchWindowsGetKernelSuggestedLocalWorkSize ClGetKernelSuggestedLocalWorkSize;

    [NativeName("clGetPlatformIDs")]
    [UnscopedRef]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public ref delegate* unmanaged<uint, PlatformIdHandle*, uint*, int> GetPlatformIDs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.ClGetPlatformIDs; }
    }

    [NativeName("clGetPlatformIDs_icd2_tag")]
    [UnscopedRef]
    public ref nint GetPlatformIDsIcd2Tag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.ClGetPlatformIDsIcd2Tag; }
    }

    [NativeName("clUnloadCompiler")]
    [UnscopedRef]
    [SupportedApiProfile(
        "opencl",
        [
            "CL_VERSION_1_0",
            "CL_VERSION_1_1",
            "CL_VERSION_1_2",
            "CL_VERSION_2_0",
            "CL_VERSION_2_1",
            "CL_VERSION_2_2",
            "CL_VERSION_3_0",
            "CL_VERSION_3_1",
        ],
        MinVersion = "1.0"
    )]
    public ref delegate* unmanaged<int> UnloadCompiler
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.ClUnloadCompiler; }
    }

    [NativeName("clUnloadCompiler_icd2_tag")]
    [UnscopedRef]
    public ref nint UnloadCompilerIcd2Tag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.ClUnloadCompilerIcd2Tag; }
    }
}
