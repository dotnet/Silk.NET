// TODO: Exanite: This example is easier to read as a Program class. We should probably do the same for the other examples.
//
// TODO: Exanite: I plan to rename these "tutorials" to be "smoke tests" and to reserve tutorials to be for examples properly designed for educational purposes.
// TODO: Exanite: The existing tutorials just test if the API works and I don't want to misrepresent that.

using System.Runtime.CompilerServices;
using Silk.NET.OpenCL;

internal unsafe class Program
{
    // Based on https://community.nxp.com/t5/i-MX-Processors-Knowledge-Base/OpenCL-Hello-World/ta-p/1113358?profile.language=en
    private const string _kernelSource = """
        __kernel void VectorAdd(__global int* c, __global int* a, __global int* b)
        {
            unsigned int n = get_global_id(0);
            c[n] = a[n] + b[n];
        }
        """;

    private static readonly int[] _initialData1 =
    [
        37,
        50,
        54,
        50,
        56,
        0,
        43,
        43,
        74,
        71,
        32,
        36,
        16,
        43,
        56,
        100,
        50,
        25,
        15,
        17,
    ];

    private static readonly int[] _initialData2 =
    [
        35,
        51,
        54,
        58,
        55,
        32,
        36,
        69,
        27,
        39,
        35,
        40,
        16,
        44,
        55,
        14,
        58,
        75,
        18,
        15,
    ];

    private const int _elementCount = 100;

    public static int Main(string[] args)
    {
        // TODO: Exanite: The todos in this file represent issues that I found or thoughts that I had while working on this smoke test.
        // TODO: Exanite: These might not represent actual problems, but I want to document these so we can address them later.

        // Load API
        var cl = Cl.Create(); // TODO: This should be disposable

        // Initialize host data
        var hostData1 = new int[_elementCount];
        var hostData2 = new int[_elementCount];
        var hostOutput = new int[_elementCount];
        var expectedOutput = new int[_elementCount];

        for (var i = 0; i < _elementCount; i++)
        {
            hostData1[i] = _initialData1[i % _initialData1.Length];
            hostData2[i] = _initialData2[i % _initialData2.Length];
            expectedOutput[i] = hostData1[i] + hostData2[i];
        }

        // Select platform and device
        // TODO: I'm going to prefer the DSL types whenever possible
        // TODO: Return type should be ErrorCodes
        var platform = default(PlatformIdHandle); // TODO: Using the DSL types requires us to initialize the variable first, which is annoying
        CheckError(cl.GetPlatformIDs(1, platform.AsRef(), nullptr));

        var device = default(DeviceIdHandle);
        CheckError(cl.GetDeviceIDs(platform, (ulong)DeviceType.Gpu, 1, device.AsRef(), nullptr)); // TODO: 2nd parameter shouldn't need a cast

        Span<byte> buffer = stackalloc byte[1024];

        CheckError(
            cl.GetDeviceInfo(
                device,
                (uint)DeviceInfo.DeviceName, // TODO: Shouldn't need a cast.
                (nuint)buffer.Length,
                buffer.AsRef(),
                nullptr
            )
        );
        // var deviceName = SilkMarshal.NativeToString(ref buffer.AsRef().Handle); // TODO: There should be a Ref overload for NativeToString.
        var deviceName = buffer.AsRef().ReadToString();

        Console.WriteLine($"Found device: {deviceName}");

        CheckError(
            cl.GetDeviceInfo(
                device,
                (uint)DeviceInfo.DriverVersion, // TODO: Shouldn't need a cast
                (nuint)buffer.Length,
                buffer.AsRef(),
                nullptr
            )
        );
        // var driverVersion = SilkMarshal.NativeToString(ref buffer.AsRef().Handle); // TODO: There should be a Ref overload for NativeToString.
        var driverVersion = buffer.AsRef().ReadToString();

        Console.WriteLine($"Driver version: {driverVersion}");

        // Create context and command queue
        var properties = new[]
        {
            (nint)ContextProperties.ContextPlatform,
            (nint)platform.Handle,
            0,
        };

        var errorCode = default(int);
        var context = cl.CreateContextFromType(
            properties.AsRef(),
            (ulong)DeviceType.Gpu, // TODO:  Shouldn't need a cast
            null,
            nullptr,
            errorCode.AsRef()
        );
        CheckError(errorCode);

        var commandQueue = cl.CreateCommandQueueWithProperties(
            context,
            device,
            nullptr,
            errorCode.AsRef()
        );
        CheckError(errorCode);

        // Create buffers
        var deviceDataBuffer1 = cl.CreateBuffer(
            context,
            (ulong)(MemFlags.ReadOnly | MemFlags.CopyHostPtr), // TODO:  Shouldn't need a cast
            sizeof(int) * _elementCount,
            hostData1.AsRef(),
            errorCode.AsRef()
        );
        CheckError(errorCode);

        var deviceDataBuffer2 = cl.CreateBuffer(
            context,
            (ulong)(MemFlags.ReadOnly | MemFlags.CopyHostPtr), // TODO:  Shouldn't need a cast
            sizeof(int) * _elementCount,
            hostData2.AsRef(),
            errorCode.AsRef()
        );
        CheckError(errorCode);

        var deviceOutputBuffer = cl.CreateBuffer(
            context,
            (ulong)MemFlags.WriteOnly, // TODO:  Shouldn't need a cast
            sizeof(int) * _elementCount,
            nullptr,
            errorCode.AsRef()
        );
        CheckError(errorCode);

        // Compile kernel
        ref readonly var kernelSource = ref SilkMarshal.StringToNative(_kernelSource); // TODO: Why is the returned ref readonly?
        var kernelSourceLength = (nuint)_kernelSource.Length; // TODO: This is wrong, but we don't have SilkMarshal.StringLength?
        var uhh = Unsafe.As<byte, sbyte>(ref Unsafe.AsRef(in kernelSource)).AsRef(); // TODO: Uhh? How do we do this properly?
        var program = cl.CreateProgramWithSource(
            context,
            1u,
            uhh.AsRef2D(), // TODO: Yeah, the above wasn't all...
            kernelSourceLength.AsRef(),
            errorCode.AsRef()
        );
        CheckError(errorCode);

        CheckError(cl.BuildProgram(program, 0, nullptr, nullptr, null, nullptr));

        var kernelName = "VectorAdd"u8;
        var kernel = cl.CreateKernel(
            program,
            Unsafe.As<byte, sbyte>(ref kernelName.AsRef().Handle).AsRef(), // TODO: sbyte strikes again
            errorCode.AsRef()
        );
        CheckError(errorCode);

        CheckError(
            cl.SetKernelArg(kernel, 0, (nuint)sizeof(MemHandle), deviceOutputBuffer.AsRef())
        );
        CheckError(cl.SetKernelArg(kernel, 1, (nuint)sizeof(MemHandle), deviceDataBuffer1.AsRef()));
        CheckError(cl.SetKernelArg(kernel, 2, (nuint)sizeof(MemHandle), deviceDataBuffer2.AsRef()));

        nuint workgroupSize = _elementCount;
        CheckError(
            cl.EnqueueNDRangeKernel(
                commandQueue,
                kernel,
                1,
                nullptr,
                workgroupSize.AsRef(),
                nullptr,
                0,
                nullptr,
                nullptr
            )
        );

        CheckError(
            cl.EnqueueReadBuffer(
                commandQueue,
                deviceOutputBuffer,
                true,
                0,
                sizeof(int) * _elementCount,
                hostOutput.AsRef(),
                0,
                nullptr,
                nullptr
            )
        );

        Console.WriteLine("Actual output calculated by OpenCL:");
        Console.WriteLine($"[{string.Join(", ", hostOutput)}]");

        Console.WriteLine("Expected output:");
        Console.WriteLine($"[{string.Join(", ", expectedOutput)}]");

        var matches = true;
        for (var i = 0; i < hostOutput.Length; i++)
        {
            if (hostOutput[i] != expectedOutput[i])
            {
                matches = false;
                break;
            }
        }

        Console.WriteLine($"Actual matches expected: {matches}");

        // Cleanup
        CheckError(cl.ReleaseKernel(kernel));
        CheckError(cl.ReleaseProgram(program));
        // SilkMarshal.Free(kernelSource.AsRef()); // TODO: We don't need to free the output of StringToNative, right? Seems to be a managed array backing it.
        CheckError(cl.ReleaseMemObject(deviceOutputBuffer));
        CheckError(cl.ReleaseMemObject(deviceDataBuffer2));
        CheckError(cl.ReleaseMemObject(deviceDataBuffer1));
        CheckError(cl.ReleaseCommandQueue(commandQueue));
        CheckError(cl.ReleaseContext(context));

        return 0;
    }

    private static void CheckError(int error) // TODO: Parameter should be ErrorCodes, but can't since return types are not correct right now
    {
        var errorCode = (ErrorCodes)error;
        if (errorCode != ErrorCodes.Success)
        {
            throw new Exception($"OpenCL error: {errorCode}");
        }
    }
}
