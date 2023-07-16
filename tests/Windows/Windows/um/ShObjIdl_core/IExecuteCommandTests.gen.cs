// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IExecuteCommand"/> struct.</summary>
public static unsafe partial class IExecuteCommandTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IExecuteCommand"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IExecuteCommand).GUID, Is.EqualTo(IID_IExecuteCommand));
    }

    /// <summary>Validates that the <see cref = "IExecuteCommand"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IExecuteCommand>(), Is.EqualTo(sizeof(IExecuteCommand)));
    }

    /// <summary>Validates that the <see cref = "IExecuteCommand"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IExecuteCommand).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IExecuteCommand"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IExecuteCommand), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IExecuteCommand), Is.EqualTo(4));
        }
    }
}