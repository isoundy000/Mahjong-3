﻿using UnityEngine;
using System.Collections;

public class CommandSocketManagerNetState : Command
{
	public NET_STATE mNetState;
	public override void init()
	{
		base.init();
		mNetState = NET_STATE.NS_SERVER_CLOSE;
	}
	public override void execute()
	{
		if(mNetState == NET_STATE.NS_NET_CLOSE)
		{
			UnityUtility.logError("网络已断开");
		}
		else if(mNetState == NET_STATE.NS_SERVER_CLOSE)
		{
			UnityUtility.logError("服务器关闭");
		}
	}
	public override string showDebugInfo()
	{
		return base.showDebugInfo() + " : state : " + mNetState;
	}
}