﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Networking.UnityWebRequestAsyncOperation
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
  [UsedByNativeCode]
  [StructLayout(LayoutKind.Sequential)]
  public class UnityWebRequestAsyncOperation : AsyncOperation
  {
    public UnityWebRequest webRequest { get; internal set; }
  }
}