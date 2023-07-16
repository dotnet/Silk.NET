// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "ID3DBlob"/> struct.</summary>
public static unsafe partial class ID3DBlobTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ID3DBlob"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3DBlob).GUID, Is.EqualTo(IID_ID3D10Blob));
    }

    /// <summary>Validates that the <see cref = "ID3DBlob"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID3DBlob>(), Is.EqualTo(sizeof(ID3DBlob)));
    }

    /// <summary>Validates that the <see cref = "ID3DBlob"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3DBlob).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ID3DBlob"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3DBlob), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3DBlob), Is.EqualTo(4));
        }
    }
}