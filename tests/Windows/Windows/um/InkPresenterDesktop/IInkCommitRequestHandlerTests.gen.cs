// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InkPresenterDesktop.h and um/InkPresenterDesktop_i.c in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IInkCommitRequestHandler"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IInkCommitRequestHandlerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IInkCommitRequestHandler"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IInkCommitRequestHandler).GUID, Is.EqualTo(IID_IInkCommitRequestHandler));
    }

    /// <summary>Validates that the <see cref = "IInkCommitRequestHandler"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IInkCommitRequestHandler>(), Is.EqualTo(sizeof(IInkCommitRequestHandler)));
    }

    /// <summary>Validates that the <see cref = "IInkCommitRequestHandler"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IInkCommitRequestHandler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IInkCommitRequestHandler"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IInkCommitRequestHandler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IInkCommitRequestHandler), Is.EqualTo(4));
        }
    }
}