// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.OpenCL;
using System;
using System.IO;

namespace HelloWorld
{
    internal class Program
    {
        const int ARRAY_SIZE = 1000;
        static unsafe void Main(string[] args)
        {
            var cl = CL.GetApi();
            nint context = 0;
            nint commandQueue = 0;
            nint program = 0;
            nint kernel = 0;
            nint device = 0;

            nint[] memObjects = new nint[3];

            // Create an OpenCL context on first available platform
            context = CreateContext(cl);
            if (context == IntPtr.Zero)
            {
                Console.WriteLine("Failed to create OpenCL context.");
                return;
            }
            // Create a command-queue on the first device available
            // on the created context
            commandQueue = CreateCommandQueue(cl, context, ref device);
            if (commandQueue == IntPtr.Zero)
            {
                Cleanup(cl, context, commandQueue, program, kernel, memObjects);
                return;
            }

            // Create OpenCL program from HelloWorld.cl kernel source
            program = CreateProgram(cl, context, device, "HelloWorld.cl");
            if (program == IntPtr.Zero)
            {
                Cleanup(cl, context, commandQueue, program, kernel, memObjects);
                return;
            }

            // Create OpenCL kernel
            kernel = cl.CreateKernel(program, "hello_kernel", null);
            if (kernel == IntPtr.Zero)
            {
                Console.WriteLine("Failed to create kernel");
                Cleanup(cl, context, commandQueue, program, kernel, memObjects);
                return;
            }

            // Create memory objects that will be used as arguments to
            // kernel.  First create host memory arrays that will be
            // used to store the arguments to the kernel
            float[] result = new float[ARRAY_SIZE];
            float[] a = new float[ARRAY_SIZE];
            float[] b = new float[ARRAY_SIZE];
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                a[i] = (float) i;
                b[i] = (float) (i * 2);
            }

            if (!CreateMemObjects(cl, context, memObjects, a, b))
            {
                Cleanup(cl, context, commandQueue, program, kernel, memObjects);
                return;
            }

            // Set the kernel arguments (result, a, b)
            int errNum = cl.SetKernelArg(kernel, 0, (nuint) sizeof(nint), memObjects[0]);
            errNum |= cl.SetKernelArg(kernel, 1, (nuint) sizeof(nint), memObjects[1]);
            errNum |= cl.SetKernelArg(kernel, 2, (nuint) sizeof(nint), memObjects[2]);

            if (errNum != (int) ErrorCodes.Success)
            {
                Console.WriteLine("Error setting kernel arguments.");
                Cleanup(cl, context, commandQueue, program, kernel, memObjects);
                return;
            }

            nuint[] globalWorkSize = new nuint[1] { ARRAY_SIZE };
            nuint[] localWorkSize = new nuint[1] { 1 };

            // Queue the kernel up for execution across the array
            errNum = cl.EnqueueNdrangeKernel(commandQueue, kernel, 1, (nuint*) null, globalWorkSize, localWorkSize, 0, (nint*) null, (nint*) null);
            if (errNum != (int) ErrorCodes.Success)
            {
                Console.WriteLine("Error queuing kernel for execution.");
                Cleanup(cl, context, commandQueue, program, kernel, memObjects);
                return;
            }

            fixed (void* pValue = result)
            {
                // Read the output buffer back to the Host
                errNum = cl.EnqueueReadBuffer(commandQueue, memObjects[2], true, 0, ARRAY_SIZE * sizeof(float), pValue, 0, null, null);
                if (errNum != (int) ErrorCodes.Success)
                {
                    Console.WriteLine("Error reading result buffer.");
                    Cleanup(cl, context, commandQueue, program, kernel, memObjects);
                    return;
                }
            }

            // Output the result buffer
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.WriteLine("Executed program succesfully.");
            Cleanup(cl, context, commandQueue, program, kernel, memObjects);
        }

        /// <summary>
        /// Create memory objects used as the arguments to the kernel
        /// The kernel takes three arguments: result (output), a (input),
        /// and b (input)
        /// </summary>
        /// <param name="context"></param>
        /// <param name="memObjects"></param>
        /// <param name=""></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static unsafe bool CreateMemObjects(CL cl, nint context, nint[] memObjects, float[] a, float[] b)
        {
            fixed (void* pa = a)
            {
                memObjects[0] = cl.CreateBuffer(context, MemFlags.ReadOnly | MemFlags.CopyHostPtr, sizeof(float) * ARRAY_SIZE, pa, null);
            }

            fixed (void* pb = b)
            {
                memObjects[1] = cl.CreateBuffer(context, MemFlags.ReadOnly | MemFlags.CopyHostPtr, sizeof(float) * ARRAY_SIZE, pb, null);
            }

            memObjects[2] = cl.CreateBuffer(context, MemFlags.ReadWrite, sizeof(float) * ARRAY_SIZE, null, null);

            if (memObjects[0] == IntPtr.Zero || memObjects[1] == IntPtr.Zero || memObjects[2] == IntPtr.Zero)
            {
                Console.WriteLine("Error creating memory objects.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Create an OpenCL program from the kernel source file
        /// </summary>
        /// <param name="cl"></param>
        /// <param name="context"></param>
        /// <param name="device"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static unsafe nint CreateProgram(CL cl, nint context, nint device, string fileName)
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine($"File does not exist: {fileName}");
                return IntPtr.Zero;
            }
            using StreamReader sr = new StreamReader(fileName);
            string clStr = sr.ReadToEnd();

            var program = cl.CreateProgramWithSource(context, 1, new string[] { clStr }, null, null);
            if (program == IntPtr.Zero)
            {
                Console.WriteLine("Failed to create CL program from source.");
                return IntPtr.Zero;
            }

            var errNum = cl.BuildProgram(program, 0, null, (byte*) null, null, null);

            if (errNum != (int) ErrorCodes.Success)
            {
                _ = cl.GetProgramBuildInfo(program, device, ProgramBuildInfo.BuildLog, 0, null, out nuint buildLogSize);
                byte[] log = new byte[buildLogSize / (nuint) sizeof(byte)];
                fixed (void* pValue = log)
                {
                    cl.GetProgramBuildInfo(program, device, ProgramBuildInfo.BuildLog, buildLogSize, pValue, null);
                }
                string? build_log = System.Text.Encoding.UTF8.GetString(log);

                //Console.WriteLine("Error in kernel: ");
                Console.WriteLine("=============== OpenCL Program Build Info ================");
                Console.WriteLine(build_log);
                Console.WriteLine("==========================================================");

                cl.ReleaseProgram(program);
                return IntPtr.Zero;
            }

            return program;
        }

        /// <summary>
        /// Cleanup any created OpenCL resources
        /// </summary>
        /// <param name="cl"></param>
        /// <param name="context"></param>
        /// <param name="commandQueue"></param>
        /// <param name="program"></param>
        /// <param name="kernel"></param>
        /// <param name="memObjects"></param>
        static void Cleanup(CL cl, nint context, nint commandQueue,
             nint program, nint kernel, nint[] memObjects)
        {
            for (int i = 0; i < memObjects.Length; i++)
            {
                if (memObjects[i] != 0)
                    cl.ReleaseMemObject(memObjects[i]);
            }
            if (commandQueue != 0)
                cl.ReleaseCommandQueue(commandQueue);

            if (kernel != 0)
                cl.ReleaseKernel(kernel);

            if (program != 0)
                cl.ReleaseProgram(program);

            if (context != 0)
                cl.ReleaseContext(context);
        }

        /// <summary>
        /// Create a command queue on the first device available on the
        /// context
        /// </summary>
        /// <param name="cL"></param>
        /// <param name="context"></param>
        /// <param name="device"></param>
        /// <returns></returns>
        static unsafe nint CreateCommandQueue(CL cL, nint context, ref nint device)
        {
            int errNum = cL.GetContextInfo(context, ContextInfo.Devices, 0, null, out nuint deviceBufferSize);
            if (errNum != (int) ErrorCodes.Success)
            {
                Console.WriteLine("Failed call to clGetContextInfo(...,GL_CONTEXT_DEVICES,...)");
                return IntPtr.Zero;
            }

            if (deviceBufferSize <= 0)
            {
                Console.WriteLine("No devices available.");
                return IntPtr.Zero;
            }

            nint[] devices = new nint[deviceBufferSize / (nuint) sizeof(nuint)];
            fixed (void* pValue = devices)
            {
                int er = cL.GetContextInfo(context, ContextInfo.Devices, deviceBufferSize, pValue, null);

            }
            if (errNum != (int) ErrorCodes.Success)
            {
                devices = null;
                Console.WriteLine("Failed to get device IDs");
                return IntPtr.Zero;
            }

            // In this example, we just choose the first available device.  In a
            // real program, you would likely use all available devices or choose
            // the highest performance device based on OpenCL device queries
            var commandQueue = cL.CreateCommandQueue(context, devices[0], CommandQueueProperties.None, null);
            if (commandQueue == IntPtr.Zero)
            {
                Console.WriteLine("Failed to create commandQueue for device 0");
                return IntPtr.Zero;
            }

            device = devices[0];
            return commandQueue;
        }

        /// <summary>
        /// Create an OpenCL context on the first available platform using
        /// either a GPU or CPU depending on what is available.
        /// </summary>
        /// <param name="cL"></param>
        /// <returns></returns>
        static unsafe nint CreateContext(CL cL)
        {
            var errNum = cL.GetPlatformIDs(1, out nint firstPlatformId, out uint numPlatforms);
            if (errNum != (int) ErrorCodes.Success || numPlatforms <= 0)
            {
                Console.WriteLine("Failed to find any OpenCL platforms.");
                return IntPtr.Zero;
            }

            // Next, create an OpenCL context on the platform.  Attempt to
            // create a GPU-based context, and if that fails, try to create
            // a CPU-based context.
            nint[] contextProperties = new nint[]
            {
                (nint)ContextProperties.Platform,
                firstPlatformId,
                0
            };

            fixed (nint* p = contextProperties)
            {
                var context = cL.CreateContextFromType(p, DeviceType.Gpu, null, null, out errNum);
                if (errNum != (int) ErrorCodes.Success)
                {
                    Console.WriteLine("Could not create GPU context, trying CPU...");

                    context = cL.CreateContextFromType(p, DeviceType.Cpu, null, null, out errNum);

                    if (errNum != (int) ErrorCodes.Success)
                    {
                        Console.WriteLine("Failed to create an OpenCL GPU or CPU context.");
                        return IntPtr.Zero;
                    }

                    return context;
                }

                return context;
            }
        }
    }
}
