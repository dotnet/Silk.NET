// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMoniker"/> struct.</summary>
public static unsafe partial class IMonikerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMoniker"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMoniker).GUID, Is.EqualTo(IID_IMoniker));
    }

    /// <summary>Validates that the <see cref = "IMoniker"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMoniker>(), Is.EqualTo(sizeof(IMoniker)));
    }

    /// <summary>Validates that the <see cref = "IMoniker"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMoniker).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMoniker"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMoniker), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMoniker), Is.EqualTo(4));
        }
    }
}