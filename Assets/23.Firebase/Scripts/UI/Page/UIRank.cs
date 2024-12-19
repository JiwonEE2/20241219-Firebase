using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRank : UIPage
{
	public Button goBackButton;

	private void Awake()
	{
		goBackButton.onClick.AddListener(GoBackButtonClick);
	}

	private void GoBackButtonClick()
	{
		UIManager.Instance.PageOpen<UIHome>();
	}
}
