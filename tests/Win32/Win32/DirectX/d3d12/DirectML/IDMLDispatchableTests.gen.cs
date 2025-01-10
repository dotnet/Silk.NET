// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "IDMLDispatchable"/> struct.</summary>
public static unsafe partial class IDMLDispatchableTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDMLDispatchable"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDMLDispatchable).GUID, Is.EqualTo(IID_IDMLDispatchable));
    }

    /// <summary>Validates that the <see cref = "IDMLDispatchable"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDMLDispatchable>(), Is.EqualTo(sizeof(IDMLDispatchable)));
    }

    /// <summary>Validates that the <see cref = "IDMLDispatchable"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDMLDispatchable).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDMLDispatchable"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDMLDispatchable), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDMLDispatchable), Is.EqualTo(4));
        }
    }
}
