﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvGame : MonoBehaviour
{
	[SerializeField] Text textComponent;
	[SerializeField] State startingState;

	State state;

	void Start()
	{
		state = startingState;
		textComponent.text = state.GetStateStory();
	}

	void Update()
	{
		ManageState();
	}

	private void ManageState()
	{
		var nextStates = state.GetNextStates();
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			state = nextStates[0];
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			state = nextStates[1];
		}
		textComponent.text = state.GetStateStory();
	}
}