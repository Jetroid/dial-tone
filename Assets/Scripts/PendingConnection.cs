﻿using UnityEngine;
using System.Collections;

public class PendingConnection {

	public string incomingPort;
	public string targetPort;
	public bool spokenToOperator = false;
	public bool connected = false;
	public Conversation conv;
	public bool callEnded = false;

	public void endCall()
	{
		callEnded = true;
	}

}
