// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class GP
{
    [NativeTypeName("#define GP_DLLNAME TEXT(\"DllName\")")]
    public const string GP_DLLNAME = "DllName";
    [NativeTypeName("#define GP_ENABLEASYNCHRONOUSPROCESSING TEXT(\"EnableAsynchronousProcessing\")")]
    public const string GP_ENABLEASYNCHRONOUSPROCESSING = "EnableAsynchronousProcessing";
    [NativeTypeName("#define GP_MAXNOGPOLISTCHANGESINTERVAL TEXT(\"MaxNoGPOListChangesInterval\")")]
    public const string GP_MAXNOGPOLISTCHANGESINTERVAL = "MaxNoGPOListChangesInterval";
    [NativeTypeName("#define GP_NOBACKGROUNDPOLICY TEXT(\"NoBackgroundPolicy\")")]
    public const string GP_NOBACKGROUNDPOLICY = "NoBackgroundPolicy";
    [NativeTypeName("#define GP_NOGPOLISTCHANGES TEXT(\"NoGPOListChanges\")")]
    public const string GP_NOGPOLISTCHANGES = "NoGPOListChanges";
    [NativeTypeName("#define GP_NOMACHINEPOLICY TEXT(\"NoMachinePolicy\")")]
    public const string GP_NOMACHINEPOLICY = "NoMachinePolicy";
    [NativeTypeName("#define GP_NOSLOWLINK TEXT(\"NoSlowLink\")")]
    public const string GP_NOSLOWLINK = "NoSlowLink";
    [NativeTypeName("#define GP_NOTIFYLINKTRANSITION TEXT(\"NotifyLinkTransition\")")]
    public const string GP_NOTIFYLINKTRANSITION = "NotifyLinkTransition";
    [NativeTypeName("#define GP_NOUSERPOLICY TEXT(\"NoUserPolicy\")")]
    public const string GP_NOUSERPOLICY = "NoUserPolicy";
    [NativeTypeName("#define GP_PERUSERLOCALSETTINGS TEXT(\"PerUserLocalSettings\")")]
    public const string GP_PERUSERLOCALSETTINGS = "PerUserLocalSettings";
    [NativeTypeName("#define GP_PROCESSGROUPPOLICY TEXT(\"ProcessGroupPolicy\")")]
    public const string GP_PROCESSGROUPPOLICY = "ProcessGroupPolicy";
    [NativeTypeName("#define GP_REQUIRESSUCCESSFULREGISTRY TEXT(\"RequiresSuccessfulRegistry\")")]
    public const string GP_REQUIRESSUCCESSFULREGISTRY = "RequiresSuccessfulRegistry";
}