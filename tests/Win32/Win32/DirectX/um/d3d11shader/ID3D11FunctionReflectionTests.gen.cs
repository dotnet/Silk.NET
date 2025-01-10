// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "ID3D11FunctionReflection"/> struct.</summary>
public static unsafe partial class ID3D11FunctionReflectionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID3D11FunctionReflection"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(ID3D11FunctionReflection).GUID,
            Is.EqualTo(IID_ID3D11FunctionReflection)
        );
    }

    /// <summary>Validates that the <see cref = "ID3D11FunctionReflection"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ID3D11FunctionReflection>(),
            Is.EqualTo(sizeof(ID3D11FunctionReflection))
        );
    }

    /// <summary>Validates that the <see cref = "ID3D11FunctionReflection"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D11FunctionReflection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3D11FunctionReflection"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D11FunctionReflection), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D11FunctionReflection), Is.EqualTo(4));
        }
    }
}
