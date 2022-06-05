using System;
using System.Runtime.InteropServices;
using Silk.NET.OpenCL;

namespace CLMultiplication
{
    internal class Program
    {
        private static int Factorial(int n)
        {
            return n <= 1 ? 1 : n * Factorial(n - 1);
        }

        private static unsafe void Main(string[] args)
        {
            string[] kernelCode =
            {
                "__kernel void multiply_by(__global int* A, const int c) {",
                "   A[get_global_id(0)] = c * A[get_global_id(0)];",
                "}"
            };

            // OpenCL related declarations
            int err;
            nint platform;
            nint device;
            var props = stackalloc nint[3];
            props[0] = (nint) ContextProperties.Platform;
            props[0] = 0;
            props[0] = 0;
            nint ctx;
            nint program;
            nint queue;
            nint @event = default;
            nint kMultiplyby;
            int i;

            // OpenCL instantiation
            var cl = CL.GetApi();

            var n = 1024; // vector size
            const int cMax = 5; // max value to iterate to
            var coeff = Factorial(cMax);

            var a = stackalloc int[n];
            var b = stackalloc int[n];
            var cPtr = stackalloc int[n];

            for (i = 0; i < n; i++)
            {
                a[i] = i;
                cPtr[i] = coeff * i;
            }

            nint dA; // buffer object for A

            /* Setup OpenCL environment. */
            err = cl.GetPlatformIDs(1, &platform, null);
            AssertZero(err);
            err = cl.GetDeviceIDs(platform, DeviceType.Gpu, 1, &device, null);
            AssertZero(err);

            props[1] = platform;
            ctx = cl.CreateContext(props, 1, &device, NotifyFunc, null, &err);
            AssertZero(err);

            queue = cl.CreateCommandQueue(ctx, device, CommandQueueProperties.None, &err);
            AssertZero(err);
            program = cl.CreateProgramWithSource(ctx, (uint) kernelCode.Length, kernelCode, null, &err);
            AssertZero(err);
            err = cl.BuildProgram(program, 0, null, (byte*) null, null, null);
            try
            {
                AssertZero(err);
            }
            catch (Exception ex)
            {
                var logsize = UIntPtr.Zero;
                cl.GetProgramBuildInfo(program, device, ProgramBuildInfo.BuildLog, 0, null, &logsize);
                var log = Marshal.AllocHGlobal((nint) logsize.ToPointer());
                cl.GetProgramBuildInfo
                    (program, device, ProgramBuildInfo.BuildLog, logsize, log.ToPointer(), (nuint*) null);
                throw new Exception(Marshal.PtrToStringAnsi(log), ex);
            }

            kMultiplyby = cl.CreateKernel(program, "multiply_by", &err);
            AssertZero(err);

            // initialize buffer with data
            dA = cl.CreateBuffer(ctx, MemFlags.ReadWrite, (nuint) (n * sizeof(int)), null, &err);
            AssertZero(err);

            err = cl.EnqueueWriteBuffer
                (queue, dA, true, (nuint) 0, (nuint) (n * sizeof(int)), a, 0, null, (nint*) null);
            AssertZero(err);

            cl.SetKernelArg(kMultiplyby, 0, (nuint) sizeof(void*), &dA);
            var c = 0;
            for (c = 2; c <= cMax; c++)
            {
                cl.SetKernelArg(kMultiplyby, 1, (nuint) sizeof(int), &c);
                cl.EnqueueNdrangeKernel(queue, kMultiplyby, 1, null, (nuint*) &n, (nuint*) &n, 0u, null, null);
            }

            err = cl.Finish(queue);
            AssertZero(err);

            err = cl.EnqueueReadBuffer
                (queue, dA, true, (nuint) 0, (nuint) (n * sizeof(int)), b, 0, null, (nint*) null);
            AssertZero(err);
            err = cl.Finish(queue);
            AssertZero(err);

            var success = 1;
            for (i = 0; i < n; i++)
            {
                if (b[i] != cPtr[i])
                {
                    success = 0;
                    break;
                }
            }

            Console.WriteLine(success == 1 ? "Arrays are equal!\n" : "Arrays are NOT equal\n");

            /* Release OpenCL memory objects. */
            cl.ReleaseMemObject(dA);
            cl.ReleaseCommandQueue(queue);
            cl.ReleaseContext(ctx);
        }

        private static void AssertZero(int i)
        {
            if (i != 0)
            {
                throw new Exception($"Error code is not zero: {(ErrorCodes) i}");
            }
        }

        private static unsafe void NotifyFunc(byte* errinfo, void* privateinfo, nuint cb, void* userdata)
        {
            Console.WriteLine($"Notification: {Marshal.PtrToStringAnsi((nint) errinfo)}");
        }
    }
}
