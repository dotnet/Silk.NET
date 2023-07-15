// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDMLCommandRecorder"/> struct.</summary>
public static unsafe partial class IDMLCommandRecorderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDMLCommandRecorder"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDMLCommandRecorder).GUID, Is.EqualTo(IID_IDMLCommandRecorder));
    }

    /// <summary>Validates that the <see cref = "IDMLCommandRecorder"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDMLCommandRecorder>(), Is.EqualTo(sizeof(IDMLCommandRecorder)));
    }

    /// <summary>Validates that the <see cref = "IDMLCommandRecorder"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDMLCommandRecorder).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDMLCommandRecorder"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDMLCommandRecorder), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDMLCommandRecorder), Is.EqualTo(4));
        }
    }
}