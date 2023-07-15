// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMediaTypeInfo"/> struct.</summary>
public static unsafe partial class IMediaTypeInfoTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMediaTypeInfo"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMediaTypeInfo).GUID, Is.EqualTo(IID_IMediaTypeInfo));
    }

    /// <summary>Validates that the <see cref = "IMediaTypeInfo"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMediaTypeInfo>(), Is.EqualTo(sizeof(IMediaTypeInfo)));
    }

    /// <summary>Validates that the <see cref = "IMediaTypeInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMediaTypeInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMediaTypeInfo"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMediaTypeInfo), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMediaTypeInfo), Is.EqualTo(4));
        }
    }
}