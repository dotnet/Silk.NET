// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("_cl_icd_dispatch")]
public unsafe partial struct IcdDispatch
{
    [NativeName("Anonymous1")]
    public IcdDispatchAnonymous1 Anonymous1;

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
    public IcdDispatchGetPlatformInfo ClGetPlatformInfo;

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
    public IcdDispatchGetDeviceIDs ClGetDeviceIDs;

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
    public IcdDispatchGetDeviceInfo ClGetDeviceInfo;

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
    public IcdDispatchCreateContext ClCreateContext;

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
    public IcdDispatchCreateContextFromType ClCreateContextFromType;

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
    public IcdDispatchRetainContext ClRetainContext;

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
    public IcdDispatchReleaseContext ClReleaseContext;

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
    public IcdDispatchGetContextInfo ClGetContextInfo;

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
    public IcdDispatchCreateCommandQueue ClCreateCommandQueue;

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
    public IcdDispatchRetainCommandQueue ClRetainCommandQueue;

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
    public IcdDispatchReleaseCommandQueue ClReleaseCommandQueue;

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
    public IcdDispatchGetCommandQueueInfo ClGetCommandQueueInfo;

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
    public IcdDispatchSetCommandQueueProperty ClSetCommandQueueProperty;

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
    public IcdDispatchCreateBuffer ClCreateBuffer;

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
    public IcdDispatchCreateImage2D ClCreateImage2D;

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
    public IcdDispatchCreateImage3D ClCreateImage3D;

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
    public IcdDispatchRetainMemObject ClRetainMemObject;

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
    public IcdDispatchReleaseMemObject ClReleaseMemObject;

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
    public IcdDispatchGetSupportedImageFormats ClGetSupportedImageFormats;

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
    public IcdDispatchGetMemObjectInfo ClGetMemObjectInfo;

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
    public IcdDispatchGetImageInfo ClGetImageInfo;

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
    public IcdDispatchCreateSampler ClCreateSampler;

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
    public IcdDispatchRetainSampler ClRetainSampler;

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
    public IcdDispatchReleaseSampler ClReleaseSampler;

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
    public IcdDispatchGetSamplerInfo ClGetSamplerInfo;

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
    public IcdDispatchCreateProgramWithSource ClCreateProgramWithSource;

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
    public IcdDispatchCreateProgramWithBinary ClCreateProgramWithBinary;

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
    public IcdDispatchRetainProgram ClRetainProgram;

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
    public IcdDispatchReleaseProgram ClReleaseProgram;

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
    public IcdDispatchBuildProgram ClBuildProgram;

    [NativeName("Anonymous2")]
    public IcdDispatchAnonymous2 Anonymous2;

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
    public IcdDispatchGetProgramInfo ClGetProgramInfo;

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
    public IcdDispatchGetProgramBuildInfo ClGetProgramBuildInfo;

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
    public IcdDispatchCreateKernel ClCreateKernel;

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
    public IcdDispatchCreateKernelsInProgram ClCreateKernelsInProgram;

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
    public IcdDispatchRetainKernel ClRetainKernel;

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
    public IcdDispatchReleaseKernel ClReleaseKernel;

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
    public IcdDispatchSetKernelArg ClSetKernelArg;

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
    public IcdDispatchGetKernelInfo ClGetKernelInfo;

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
    public IcdDispatchGetKernelWorkGroupInfo ClGetKernelWorkGroupInfo;

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
    public IcdDispatchWaitForEvents ClWaitForEvents;

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
    public IcdDispatchGetEventInfo ClGetEventInfo;

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
    public IcdDispatchRetainEvent ClRetainEvent;

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
    public IcdDispatchReleaseEvent ClReleaseEvent;

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
    public IcdDispatchGetEventProfilingInfo ClGetEventProfilingInfo;

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
    public IcdDispatchFlush ClFlush;

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
    public IcdDispatchFinish ClFinish;

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
    public IcdDispatchEnqueueReadBuffer ClEnqueueReadBuffer;

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
    public IcdDispatchEnqueueWriteBuffer ClEnqueueWriteBuffer;

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
    public IcdDispatchEnqueueCopyBuffer ClEnqueueCopyBuffer;

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
    public IcdDispatchEnqueueReadImage ClEnqueueReadImage;

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
    public IcdDispatchEnqueueWriteImage ClEnqueueWriteImage;

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
    public IcdDispatchEnqueueCopyImage ClEnqueueCopyImage;

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
    public IcdDispatchEnqueueCopyImageToBuffer ClEnqueueCopyImageToBuffer;

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
    public IcdDispatchEnqueueCopyBufferToImage ClEnqueueCopyBufferToImage;

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
    public IcdDispatchEnqueueMapBuffer ClEnqueueMapBuffer;

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
    public IcdDispatchEnqueueMapImage ClEnqueueMapImage;

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
    public IcdDispatchEnqueueUnmapMemObject ClEnqueueUnmapMemObject;

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
    public IcdDispatchEnqueueNDRangeKernel ClEnqueueNDRangeKernel;

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
    public IcdDispatchEnqueueTask ClEnqueueTask;

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
    public IcdDispatchEnqueueNativeKernel ClEnqueueNativeKernel;

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
    public IcdDispatchEnqueueMarker ClEnqueueMarker;

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
    public IcdDispatchEnqueueWaitForEvents ClEnqueueWaitForEvents;

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
    public IcdDispatchEnqueueBarrier ClEnqueueBarrier;

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
    public IcdDispatchGetExtensionFunctionAddress ClGetExtensionFunctionAddress;

    [NativeName("clCreateFromGLBuffer")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchCreateFromGLBuffer ClCreateFromGLBuffer;

    [NativeName("clCreateFromGLTexture2D")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchCreateFromGLTexture2D ClCreateFromGLTexture2D;

    [NativeName("clCreateFromGLTexture3D")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchCreateFromGLTexture3D ClCreateFromGLTexture3D;

    [NativeName("clCreateFromGLRenderbuffer")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchCreateFromGLRenderbuffer ClCreateFromGLRenderbuffer;

    [NativeName("clGetGLObjectInfo")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchGetGLObjectInfo ClGetGLObjectInfo;

    [NativeName("clGetGLTextureInfo")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchGetGLTextureInfo ClGetGLTextureInfo;

    [NativeName("clEnqueueAcquireGLObjects")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchEnqueueAcquireGLObjects ClEnqueueAcquireGLObjects;

    [NativeName("clEnqueueReleaseGLObjects")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchEnqueueReleaseGLObjects ClEnqueueReleaseGLObjects;

    [NativeName("clGetGLContextInfoKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchGetGLContextInfoKHR ClGetGLContextInfoKHR;

    [NativeName("clGetDeviceIDsFromD3D10KHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d10_sharing"])]
    public void* ClGetDeviceIDsFromD3D10KHR;

    [NativeName("clCreateFromD3D10BufferKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d10_sharing"])]
    public void* ClCreateFromD3D10BufferKHR;

    [NativeName("clCreateFromD3D10Texture2DKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d10_sharing"])]
    public void* ClCreateFromD3D10Texture2DKHR;

    [NativeName("clCreateFromD3D10Texture3DKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d10_sharing"])]
    public void* ClCreateFromD3D10Texture3DKHR;

    [NativeName("clEnqueueAcquireD3D10ObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d10_sharing"])]
    public void* ClEnqueueAcquireD3D10ObjectsKHR;

    [NativeName("clEnqueueReleaseD3D10ObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d10_sharing"])]
    public void* ClEnqueueReleaseD3D10ObjectsKHR;

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
    public IcdDispatchSetEventCallback ClSetEventCallback;

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
    public IcdDispatchCreateSubBuffer ClCreateSubBuffer;

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
    public IcdDispatchSetMemObjectDestructorCallback ClSetMemObjectDestructorCallback;

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
    public IcdDispatchCreateUserEvent ClCreateUserEvent;

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
    public IcdDispatchSetUserEventStatus ClSetUserEventStatus;

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
    public IcdDispatchEnqueueReadBufferRect ClEnqueueReadBufferRect;

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
    public IcdDispatchEnqueueWriteBufferRect ClEnqueueWriteBufferRect;

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
    public IcdDispatchEnqueueCopyBufferRect ClEnqueueCopyBufferRect;

    [NativeName("clCreateSubDevicesEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    public IcdDispatchCreateSubDevicesEXT ClCreateSubDevicesEXT;

    [NativeName("clRetainDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    public IcdDispatchRetainDeviceEXT ClRetainDeviceEXT;

    [NativeName("clReleaseDeviceEXT")]
    [SupportedApiProfile("opencl", ["cl_ext_device_fission"])]
    public IcdDispatchReleaseDeviceEXT ClReleaseDeviceEXT;

    [NativeName("clCreateEventFromGLsyncKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_event"], ImpliesSets = ["cl_khr_gl_sharing"])]
    public IcdDispatchCreateEventFromGLsyncKHR ClCreateEventFromGLsyncKHR;

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
    public IcdDispatchCreateSubDevices ClCreateSubDevices;

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
    public IcdDispatchRetainDevice ClRetainDevice;

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
    public IcdDispatchReleaseDevice ClReleaseDevice;

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
    public IcdDispatchCreateImage ClCreateImage;

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
    public IcdDispatchCreateProgramWithBuiltInKernels ClCreateProgramWithBuiltInKernels;

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
    public IcdDispatchCompileProgram ClCompileProgram;

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
    public IcdDispatchLinkProgram ClLinkProgram;

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
    public IcdDispatchUnloadPlatformCompiler ClUnloadPlatformCompiler;

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
    public IcdDispatchGetKernelArgInfo ClGetKernelArgInfo;

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
    public IcdDispatchEnqueueFillBuffer ClEnqueueFillBuffer;

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
    public IcdDispatchEnqueueFillImage ClEnqueueFillImage;

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
    public IcdDispatchEnqueueMigrateMemObjects ClEnqueueMigrateMemObjects;

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
    public IcdDispatchEnqueueMarkerWithWaitList ClEnqueueMarkerWithWaitList;

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
    public IcdDispatchEnqueueBarrierWithWaitList ClEnqueueBarrierWithWaitList;

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
    public IcdDispatchGetExtensionFunctionAddressForPlatform ClGetExtensionFunctionAddressForPlatform;

    [NativeName("clCreateFromGLTexture")]
    [SupportedApiProfile("opencl", ["cl_khr_gl_sharing"])]
    public IcdDispatchCreateFromGLTexture ClCreateFromGLTexture;

    [NativeName("clGetDeviceIDsFromD3D11KHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d11_sharing"])]
    public void* ClGetDeviceIDsFromD3D11KHR;

    [NativeName("clCreateFromD3D11BufferKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d11_sharing"])]
    public void* ClCreateFromD3D11BufferKHR;

    [NativeName("clCreateFromD3D11Texture2DKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d11_sharing"])]
    public void* ClCreateFromD3D11Texture2DKHR;

    [NativeName("clCreateFromD3D11Texture3DKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d11_sharing"])]
    public void* ClCreateFromD3D11Texture3DKHR;

    [NativeName("clCreateFromDX9MediaSurfaceKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_dx9_media_sharing"])]
    public void* ClCreateFromDx9MediaSurfaceKHR;

    [NativeName("clEnqueueAcquireD3D11ObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d11_sharing"])]
    public void* ClEnqueueAcquireD3D11ObjectsKHR;

    [NativeName("clEnqueueReleaseD3D11ObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_d3d11_sharing"])]
    public void* ClEnqueueReleaseD3D11ObjectsKHR;

    [NativeName("clGetDeviceIDsFromDX9MediaAdapterKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_dx9_media_sharing"])]
    public void* ClGetDeviceIDsFromDx9MediaAdapterKHR;

    [NativeName("clEnqueueAcquireDX9MediaSurfacesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_dx9_media_sharing"])]
    public void* ClEnqueueAcquireDx9MediaSurfacesKHR;

    [NativeName("clEnqueueReleaseDX9MediaSurfacesKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_dx9_media_sharing"])]
    public void* ClEnqueueReleaseDx9MediaSurfacesKHR;

    [NativeName("clCreateFromEGLImageKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_egl_image"])]
    public IcdDispatchCreateFromEglImageKHR ClCreateFromEglImageKHR;

    [NativeName("clEnqueueAcquireEGLObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_egl_image"])]
    public IcdDispatchEnqueueAcquireEglObjectsKHR ClEnqueueAcquireEglObjectsKHR;

    [NativeName("clEnqueueReleaseEGLObjectsKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_egl_image"])]
    public IcdDispatchEnqueueReleaseEglObjectsKHR ClEnqueueReleaseEglObjectsKHR;

    [NativeName("clCreateEventFromEGLSyncKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_egl_event"])]
    public IcdDispatchCreateEventFromEglSyncKHR ClCreateEventFromEglSyncKHR;

    [NativeName("clCreateCommandQueueWithProperties")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchCreateCommandQueueWithProperties ClCreateCommandQueueWithProperties;

    [NativeName("clCreatePipe")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchCreatePipe ClCreatePipe;

    [NativeName("clGetPipeInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchGetPipeInfo ClGetPipeInfo;

    [NativeName("clSVMAlloc")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchSvmAlloc ClSvmAlloc;

    [NativeName("clSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchSvmFree ClSvmFree;

    [NativeName("clEnqueueSVMFree")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchEnqueueSvmFree ClEnqueueSvmFree;

    [NativeName("clEnqueueSVMMemcpy")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchEnqueueSvmMemcpy ClEnqueueSvmMemcpy;

    [NativeName("clEnqueueSVMMemFill")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchEnqueueSvmMemFill ClEnqueueSvmMemFill;

    [NativeName("clEnqueueSVMMap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchEnqueueSvmMap ClEnqueueSvmMap;

    [NativeName("clEnqueueSVMUnmap")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchEnqueueSvmUnmap ClEnqueueSvmUnmap;

    [NativeName("clCreateSamplerWithProperties")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchCreateSamplerWithProperties ClCreateSamplerWithProperties;

    [NativeName("clSetKernelArgSVMPointer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchSetKernelArgSvmPointer ClSetKernelArgSvmPointer;

    [NativeName("clSetKernelExecInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_0", "CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.0"
    )]
    public IcdDispatchSetKernelExecInfo ClSetKernelExecInfo;

    [NativeName("clGetKernelSubGroupInfoKHR")]
    [SupportedApiProfile("opencl", ["cl_khr_subgroups"])]
    public IcdDispatchGetKernelSubGroupInfoKHR ClGetKernelSubGroupInfoKHR;

    [NativeName("clCloneKernel")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchCloneKernel ClCloneKernel;

    [NativeName("clCreateProgramWithIL")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchCreateProgramWithIL ClCreateProgramWithIL;

    [NativeName("clEnqueueSVMMigrateMem")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchEnqueueSvmMigrateMem ClEnqueueSvmMigrateMem;

    [NativeName("clGetDeviceAndHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchGetDeviceAndHostTimer ClGetDeviceAndHostTimer;

    [NativeName("clGetHostTimer")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchGetHostTimer ClGetHostTimer;

    [NativeName("clGetKernelSubGroupInfo")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchGetKernelSubGroupInfo ClGetKernelSubGroupInfo;

    [NativeName("clSetDefaultDeviceCommandQueue")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_1", "CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.1"
    )]
    public IcdDispatchSetDefaultDeviceCommandQueue ClSetDefaultDeviceCommandQueue;

    [NativeName("clSetProgramReleaseCallback")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.2"
    )]
    public IcdDispatchSetProgramReleaseCallback ClSetProgramReleaseCallback;

    [NativeName("clSetProgramSpecializationConstant")]
    [SupportedApiProfile(
        "opencl",
        ["CL_VERSION_2_2", "CL_VERSION_3_0", "CL_VERSION_3_1"],
        MinVersion = "2.2"
    )]
    public IcdDispatchSetProgramSpecializationConstant ClSetProgramSpecializationConstant;

    [NativeName("clCreateBufferWithProperties")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    public IcdDispatchCreateBufferWithProperties ClCreateBufferWithProperties;

    [NativeName("clCreateImageWithProperties")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    public IcdDispatchCreateImageWithProperties ClCreateImageWithProperties;

    [NativeName("clSetContextDestructorCallback")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_0", "CL_VERSION_3_1"], MinVersion = "3.0")]
    public IcdDispatchSetContextDestructorCallback ClSetContextDestructorCallback;

    [NativeName("clGetKernelSuggestedLocalWorkSize")]
    [SupportedApiProfile("opencl", ["CL_VERSION_3_1"], MinVersion = "3.1")]
    public IcdDispatchGetKernelSuggestedLocalWorkSize ClGetKernelSuggestedLocalWorkSize;

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
