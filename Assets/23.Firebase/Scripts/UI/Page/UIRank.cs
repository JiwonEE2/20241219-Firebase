using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIRank : UIPage
{
	public Button goBackButton;

	public List<TextMeshProUGUI> userNameTexts;
	public List<TextMeshProUGUI> levelTexts;

	private List<UserData> userDatas;

	private void Awake()
	{
		goBackButton.onClick.AddListener(GoBackButtonClick);
	}

	private void OnEnable()
	{
		UpdateRank();
	}

	private void GoBackButtonClick()
	{
		UIManager.Instance.PageOpen<UIHome>();
	}

	private void UpdateRank()
	{
		userDatas = FirebaseManager.Instance.GetAllUserData();

		for (int i = 0; i < userDatas.Count; i++)
		{
			userNameTexts[i].text = userDatas[i].userName;
			levelTexts[i].text = userDatas[i].level.ToString();
		}
	}
}
