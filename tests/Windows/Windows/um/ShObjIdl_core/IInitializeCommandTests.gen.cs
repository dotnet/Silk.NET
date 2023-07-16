// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IInitializeCommand"/> struct.</summary>
public static unsafe partial class IInitializeCommandTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IInitializeCommand"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IInitializeCommand).GUID, Is.EqualTo(IID_IInitializeCommand));
    }

    /// <summary>Validates that the <see cref = "IInitializeCommand"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IInitializeCommand>(), Is.EqualTo(sizeof(IInitializeCommand)));
    }

    /// <summary>Validates that the <see cref = "IInitializeCommand"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IInitializeCommand).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IInitializeCommand"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IInitializeCommand), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IInitializeCommand), Is.EqualTo(4));
        }
    }
}