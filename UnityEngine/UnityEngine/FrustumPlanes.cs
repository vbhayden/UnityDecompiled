﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.FrustumPlanes
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D290425A-E4B3-4E49-A420-29F09BB3F974
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEngine.dll

using System;

namespace UnityEngine
{
  /// <summary>
  ///   <para>This struct contains the view space coordinates of the near projection plane.</para>
  /// </summary>
  [Serializable]
  public struct FrustumPlanes
  {
    /// <summary>
    ///   <para>Position in view space of the left side of the near projection plane.</para>
    /// </summary>
    public float left;
    /// <summary>
    ///   <para>Position in view space of the right side of the near projection plane.</para>
    /// </summary>
    public float right;
    /// <summary>
    ///   <para>Position in view space of the bottom side of the near projection plane.</para>
    /// </summary>
    public float bottom;
    /// <summary>
    ///   <para>Position in view space of the top side of the near projection plane.</para>
    /// </summary>
    public float top;
    /// <summary>
    ///   <para>Z distance from the origin of view space to the near projection plane.</para>
    /// </summary>
    public float zNear;
    /// <summary>
    ///   <para>Z distance from the origin of view space to the far projection plane.</para>
    /// </summary>
    public float zFar;
  }
}