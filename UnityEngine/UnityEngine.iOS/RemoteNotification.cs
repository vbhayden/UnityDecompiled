using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.iOS
{
	[RequiredByNativeCode]
	public sealed class RemoteNotification
	{
		private IntPtr m_Ptr;

		public extern string alertBody
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public extern string soundName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public extern int applicationIconBadgeNumber
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public extern IDictionary userInfo
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public extern bool hasAction
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		private RemoteNotification()
		{
		}

		~RemoteNotification()
		{
			NotificationHelper.DestroyRemote(this.m_Ptr);
		}
	}
}
